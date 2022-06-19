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
    public partial class GuestForm : Form
    {
        public GuestForm()
        {
            InitializeComponent();
        }

        private void btn_GuesrForm_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGuestCreate_Click(object sender, EventArgs e)
        {
            
                User uNew = new User(textBoxGuestName.Text, Convert.ToDateTime(dateTimePicker_GuestAge.Text), Convert.ToBoolean(checkBoxGuest_student.Checked));
                string message = $"Created new User '{textBoxGuestName.Text}'";
                Log.EventLog.Add(message);
                Log.Writer(message);
                
                using (StreamWriter sw = new StreamWriter("..\\..\\..\\inputUsers.txt",true))
                {
                   string user = $"{uNew.Name} {uNew._age.Day}.{uNew._age.Month}.{uNew._age.Year} {uNew.isStudent}";
                   sw.Write(user + "\n");
                
                }

                new SecondForm().Show();
        }

        private void button_inputUser_Click(object sender, EventArgs e)
        {
            bool isTrue = false;
            foreach( var user in User.Items.Values)
            {
                if(user.Name== textBoxGuestName.Text && user._age == (Convert.ToDateTime(dateTimePicker_GuestAge.Text)) && user.isStudent == Convert.ToBoolean(checkBoxGuest_student.Checked) )
                {
                 isTrue = true;
                }
               
            }
            if(isTrue)
            {
                new SecondForm().Show();
            }
            else
            {
                string message = $"The user with such data does not exist!! Try to create a new one!";
                MessageBox.Show(message);
            }
        }
    }
}
