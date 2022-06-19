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
    public partial class thingRentListForm : Form
    {
        public thingRentListForm()
        {
            InitializeComponent();
        }

        private void button_thingRentListFormExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void thingRentListForm_Load(object sender, EventArgs e)
        {
            usersList.DataSource = User.Items.Values.ToList();
            eventLogList.DataSource = Log.EventLog.ToList();
            thingList.DataSource = Thing.Items.Values.ToList();
        }

        private void button_rent_Click(object sender, EventArgs e)
        {
            if ((Thing)thingList.SelectedItem != null)
            {
                if (((Thing)thingList.SelectedItem).Count > 0)
                {
                    
                        new Sharing3() { Thing = (Thing)thingList.SelectedItem, User = (User)usersList.SelectedItem };
                        ((Thing)thingList.SelectedItem).Count--;
                        string message = $"The user '{((User)usersList.SelectedItem).Name}' has rented/took  a thing ' {((Thing)thingList.SelectedItem).NameThing}' ";
                        Log.Writer(message);
                        Log.EventLog.Add(message);
                        eventLogList.DataSource = null;
                        eventLogList.DataSource = Log.EventLog.ToList();
                        thingList.DataSource = null;
                        thingList.DataSource = Thing.Items.Values.ToList();
                    
                }
                else
                {
                    string message = $"The user '{((User)usersList.SelectedItem).Name}' wanted to rent/took a thing '{((Thing)thingList.SelectedItem).NameThing}'but all places are occupied!  ";
                    Log.Writer(message);
                    Log.EventLog.Add(message);
                    eventLogList.DataSource = null;
                    eventLogList.DataSource = Log.EventLog.ToList();
                    thingList.DataSource = null;
                    thingList.DataSource = Thing.Items.Values.ToList();
                }
            }
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            
            
                var user = (User)usersList.SelectedItem;
                var thing = (Thing)thingList.SelectedItem;
                var sharingToDel = Sharing3.Items.Values.Where(sh => sh.Thing == thing && sh.User == user).FirstOrDefault();
                if ((Thing)thingList.SelectedItem != null)
                {
                    if (sharingToDel != null)
                    {
                     
                        if (thing.Count >= thing.TempCount)
                        {
                            Sharing3.Items.Remove(sharingToDel.Id);
                            string message = $"User '{user.Name}' returned rented thing '{thing.NameThing}' ";
                            Log.Writer(message);
                            Log.EventLog.Add(message);
                            eventLogList.DataSource = null;
                            eventLogList.DataSource = Log.EventLog.ToList();
                            thing.Count++;
                            thingList.DataSource = null;
                            thingList.DataSource = Thing.Items.Values.ToList();

                        }

                    }
                    else
                    {
                        string message = $"User '{user.Name}' haven't rented a thing '{thing.NameThing}' yet ";
                        Log.Writer(message);
                        Log.EventLog.Add(message);
                        eventLogList.DataSource = null;
                        eventLogList.DataSource = Log.EventLog.ToList();
                    }
                }
            
        }
    }
}
