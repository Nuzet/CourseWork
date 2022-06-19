using LibraryData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class bookRentListForm : Form
    {
        public bookRentListForm()
        {
            InitializeComponent();
        }

        private void button_bookRentListFormExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bookRentListForm_Load(object sender, EventArgs e)
        {
            booksList.DataSource = Book.Items.Values.ToList();
            usersList.DataSource = User.Items.Values.ToList();
            eventLogList.DataSource = Log.EventLog.ToList();
        }

        private void button_rent_Click(object sender, EventArgs e)
        {
            if (((User)usersList.SelectedItem).isRentedBook == false)
            {
                new Sharing2() { Book = (Book)booksList.SelectedItem, User = (User)usersList.SelectedItem };
                ((User)usersList.SelectedItem).isRentedBook = true;
                string message = $"The user '{((User)usersList.SelectedItem).Name}' has rented a book '{((Book)booksList.SelectedItem).Name}'";
                Log.Writer(message);
                Log.EventLog.Add(message);
                eventLogList.DataSource = null;
                eventLogList.DataSource = Log.EventLog.ToList();
            }
            else
            {
                string message = $"User '{((User)usersList.SelectedItem).Name}' already rented a book '{((Book)booksList.SelectedItem).Name}',must be returned first! ";
                Log.Writer(message);
                Log.EventLog.Add(message);
                eventLogList.DataSource = null;
                eventLogList.DataSource = Log.EventLog.ToList();

            }
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            var user = (User)usersList.SelectedItem;
            var book = (Book)booksList.SelectedItem;
            var sharingToDel = Sharing2.Items.Values.Where(sh => sh.Book == book && sh.User == user).FirstOrDefault();
            if(sharingToDel != null)
            {
                Sharing2.Items.Remove(sharingToDel.Id);
                string message = $"User '{user.Name}' returned rented book '{book.Name}' ";
                Log.Writer(message);
                Log.EventLog.Add(message);
                eventLogList.DataSource = null;
                eventLogList.DataSource = Log.EventLog.ToList();
                user.isRentedBook = false;
            }
            else
            {
                string message = $"User '{user.Name}' haven't rented a book {book.Name} yet ";
                Log.Writer(message);
                Log.EventLog.Add(message);
                eventLogList.DataSource = null;
                eventLogList.DataSource = Log.EventLog.ToList();
            }
            

        }
    }
}
