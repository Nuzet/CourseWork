using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryData;
namespace Library
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btn_MainFormClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            if(textBoxAdminName.Text ==Admin.AdminName && textBoxAdminPassword.Text == Admin.AdminPassword)
            {
                new SecondFormAdmin().Show();
            }
            else
            {
                MessageBox.Show("Admin Тame or Password is not correct!");
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
