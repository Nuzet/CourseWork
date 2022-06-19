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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void btn_UsersForm_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            usersList.DataSource = User.Items.Values.ToList();
            eventLogList.DataSource = Log.EventLog.ToList();
        }

        private void btn_usersList_Add_Click(object sender, EventArgs e)
        {
             User tempuser = new User (textBox_userList_Name.Text, Convert.ToDateTime(dateTimePicker_userListDateAge.Text), checkBox_userList_student.Checked);
             string message = $"(Admin) Created new User: '{tempuser.Name}' ";
             Log.EventLog.Add(message);
             eventLogList.DataSource = null;
             eventLogList.DataSource = Log.EventLog.ToList();
             usersList.DataSource = null;
             usersList.DataSource = User.Items.Values.ToList();
             Log.Writer(message);
             string user = $"User: {tempuser.Name}\t   ID: {tempuser.Id}\t   BirthDay: {tempuser._age}\t   Student:{tempuser.isStudent}  ";
             Log.UserHistoryLog(user);

        }

        private void btn_usersListRemake_Click(object sender, EventArgs e)
        {
            if ((User)usersList.SelectedItem != null)
            {
                string tempName = ((User)usersList.SelectedItem).Name;
                ((User)usersList.SelectedItem).Name = textBox_userList_Name.Text;
                ((User)usersList.SelectedItem)._age = dateTimePicker_userListDateAge.Value;
                ((User)usersList.SelectedItem).isStudent = checkBox_userList_student.Checked;
                string message = $"(Admin) User: '{tempName}' was changed!";
                Log.EventLog.Add(message);
                eventLogList.DataSource = null;
                eventLogList.DataSource = Log.EventLog.ToList();
                usersList.DataSource = null;
                usersList.DataSource = User.Items.Values.ToList();
                Log.Writer(message);
            }
        }

        private void btn_usersListDelete_Click(object sender, EventArgs e)
        {
            if ((User)usersList.SelectedItem != null)
            {
                string tempName = ((User)usersList.SelectedItem).Name;
                User.Items.Remove(((User)usersList.SelectedItem).Id);
                string message = $"(Admin) User: '{tempName}' was deleted! ";
                Log.EventLog.Add(message);
                usersList.DataSource = null;
                usersList.DataSource = User.Items.Values.ToList();
                eventLogList.DataSource = null;
                eventLogList.DataSource = Log.EventLog.ToList();
                Log.Writer(message);
            }
        }

        private void usersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usersList.SelectedItem != null)
            {
                User u = ((User)usersList.SelectedItem);
                textBox_userList_Name.Text = u.Name;
                dateTimePicker_userListDateAge.Value = u._age;
                checkBox_userList_student.Checked = u.isStudent;

            }
        }
       

        private void eventLogList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
