using LibraryData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Library
{
    public partial class BooksListForm : Form
    {

        public BooksListForm()
        {
            InitializeComponent();
        }

        private void BooksListForm_Load(object sender, EventArgs e)
        {
            booksList.DataSource = Book.Items.Values.ToList();
            eventLogList.DataSource = Log.EventLog.ToList();
            mainBooksList.DataSource = BookLibrary.Items.Values.ToList();
        }

        private void btn_BooksListForm_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_maidBookList_Add_Click(object sender, EventArgs e)
        {
           BookLibrary l=  new BookLibrary(textBox_mainBookListName.Text);

            mainBooksList.DataSource = null;
            mainBooksList.DataSource= BookLibrary.Items.Values.ToList();
            string message = $"(Admin) Created new Main Book: '{l.Name}'";
            Log.EventLog.Add(message);
            eventLogList.DataSource = null;
            eventLogList.DataSource = Log.EventLog.ToList();
            Log.Writer(message);

         
        }

        private void btn_mainBookListRemake_Click(object sender, EventArgs e)
        {
            string tempNameFirst = ((BookLibrary)mainBooksList.SelectedItem).Name;
            string tempNameSecond = textBox_mainBookListName.Text;
            ((BookLibrary)mainBooksList.SelectedItem).Name = textBox_mainBookListName.Text;
            mainBooksList.DataSource = null;
            mainBooksList.DataSource = BookLibrary.Items.Values.ToList();
            string message = $"(Admin) Main Book Name changed from '{tempNameFirst}' to '{tempNameSecond}'";
            Log.EventLog.Add(message);
            eventLogList.DataSource = null;
            eventLogList.DataSource = Log.EventLog.ToList();
            Log.Writer(message);
        }

        private void mainBooksList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainBooksList.SelectedItem != null)
            {
                textBox_mainBookListName.Text = ((BookLibrary)mainBooksList.SelectedItem).Name;
            }
        }

        private void btn_mainBokkList_delete_Click(object sender, EventArgs e)
        {
            BookLibrary temp = ((BookLibrary)mainBooksList.SelectedItem);
            BookLibrary.Items.Remove(((BookLibrary)mainBooksList.SelectedItem).Id);
            mainBooksList.DataSource = null;
            mainBooksList.DataSource = BookLibrary.Items.Values.ToList();
            string message = $"(Admin) Main Book : '{temp.Name}' was deleted! ";
            Log.EventLog.Add(message);
            eventLogList.DataSource = null;
            eventLogList.DataSource = Log.EventLog.ToList();
            Log.Writer(message);
        }

        private void booksList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (booksList.SelectedItem != null)
            {
                textBox_booksList_Name.Text = ((Book)booksList.SelectedItem).Name;
                textBoxBooksListAuthor.Text = ((Book)booksList.SelectedItem).Author;
                textBoxBooksListLanguage.Text = ((Book)booksList.SelectedItem).Language;
                textBoxBooksListPages.Text = ((Book)booksList.SelectedItem).Pages.ToString();
                dateTimePickerBooksListDate.Value= ((Book)booksList.SelectedItem).date;

            }
        }

        private void btn_bookList_Add_Click(object sender, EventArgs e)
        {
            if (mainBooksList.SelectedItem != null)
            {
               Book book=  new Book(textBox_booksList_Name.Text, textBoxBooksListAuthor.Text, Convert.ToInt32(textBoxBooksListPages.Text), textBoxBooksListLanguage.Text, Convert.ToDateTime(dateTimePickerBooksListDate.Text), (BookLibrary)mainBooksList.SelectedItem);
               string message = $"(Admin) Created new Book: '{book.Name}' Author:'{book.Author}'";
               Log.EventLog.Add(message);
               eventLogList.DataSource = null;
               eventLogList.DataSource = Log.EventLog.ToList();
               Log.Writer(message);
            }

            booksList.DataSource = null;
            booksList.DataSource = Book.Items.Values.ToList();
            
        }

        private void btn_bookListDelete_Click(object sender, EventArgs e)
        {
            Book tempBook = (Book)booksList.SelectedItem;
            Book.Items.Remove(((Book)booksList.SelectedItem).Id);
            booksList.DataSource = null;
            booksList.DataSource = Book.Items.Values.ToList();
            string message = $"(Admin) Book: '{tempBook.Name}' was deleted! ";
            Log.EventLog.Add(message);
            eventLogList.DataSource = null;
            eventLogList.DataSource = Log.EventLog.ToList();
            Log.Writer(message);
        }

        private void btn_bookListRemake_Click(object sender, EventArgs e)
        {
            string tempName = ((Book)booksList.SelectedItem).Name;
            ((Book)booksList.SelectedItem).Name = textBox_booksList_Name.Text;
            ((Book)booksList.SelectedItem).Author = textBoxBooksListAuthor.Text;
            ((Book)booksList.SelectedItem).Language = textBoxBooksListLanguage.Text;
            ((Book)booksList.SelectedItem).Pages = Convert.ToInt32(textBoxBooksListPages.Text);
            ((Book)booksList.SelectedItem).date =Convert.ToDateTime(dateTimePickerBooksListDate.Text);
            booksList.DataSource = null;
            booksList.DataSource = Book.Items.Values.ToList();
            string message = $"(Admin) Book: '{tempName} was changed!' ";
            Log.EventLog.Add(message);
            Log.Writer(message);

            eventLogList.DataSource = null;
            eventLogList.DataSource = Log.EventLog.ToList();

        }

        private void eventLogList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }


    }
}
