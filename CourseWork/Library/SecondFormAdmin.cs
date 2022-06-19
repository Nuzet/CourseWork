using LibraryData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class SecondFormAdmin : Form
    {
        public SecondFormAdmin()
        {
            InitializeComponent();
        }

       

        private void SecondForm_Load(object sender, EventArgs e)
        {
           
           
        }

        private void button_SecondForm_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_open_booksList_Click(object sender, EventArgs e)
        {
            new BooksListForm().Show();
        }

        private void btn_open_userList_Click(object sender, EventArgs e)
        {
            new UsersForm().Show();
        }

        

        private void buttonOpenThingsListForm_Click(object sender, EventArgs e)
        {
            new thingForm().Show();
        }

       
    }
}
