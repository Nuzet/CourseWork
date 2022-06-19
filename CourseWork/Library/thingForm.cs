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
    public partial class thingForm : Form
    {
        public thingForm()
        {
            InitializeComponent();
        }

        private void button_things_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void thingListBox_Load(object sender, EventArgs e)
        {
            eventLogList.DataSource = Log.EventLog.ToList();
            thingsList.DataSource = Thing.Items.Values.ToList() ;
        }

        private void btn_thingsList_Add_Click(object sender, EventArgs e)
        {
                Thing tempThing = new Thing(textBox_thingList_Name.Text, Convert.ToInt32(textBox_thingList_Count.Text));
                string message = $"(Admin) Created new Thing '{tempThing.NameThing}' (Count - {tempThing.Count}) ";
                Log.EventLog.Add(message);
                eventLogList.DataSource = null;
                eventLogList.DataSource = Log.EventLog.ToList();
                thingsList.DataSource = null;
                thingsList.DataSource = Thing.Items.Values.ToList();
                Log.Writer(message);
        }

        private void thingsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(thingsList.SelectedItem != null)
            {
                Thing t = (Thing)thingsList.SelectedItem;
                textBox_thingList_Name.Text = t.NameThing;
                textBox_thingList_Count.Text = t.Count.ToString();
               
            }
        }

        private void btn_thingsListRemake_Click(object sender, EventArgs e)
        {
            if((Thing)thingsList.SelectedItem!= null)
            {
                string tempThingName = ((Thing)thingsList.SelectedItem).NameThing;
                ((Thing)thingsList.SelectedItem).NameThing = textBox_thingList_Name.Text;
                ((Thing)thingsList.SelectedItem).Count = Convert.ToInt32(textBox_thingList_Count.Text);
                string message = $"(Admin) Thing '{tempThingName}' was changed!";
                Log.EventLog.Add(message);
                eventLogList.DataSource = null;
                eventLogList.DataSource = Log.EventLog.ToList();
                thingsList.DataSource = null;
                thingsList.DataSource = Thing.Items.Values.ToList();
                Log.Writer(message);



            }
        }

        private void btn_thingsListDelete_Click(object sender, EventArgs e)
        {
            if((Thing)thingsList.SelectedItem != null )
            {
                string tempThingName = ((Thing)thingsList.SelectedItem).NameThing;
                Thing.Items.Remove(((Thing)thingsList.SelectedItem).Id);
                string message = $"(Admin) Thing '{tempThingName}' was deleted!";
                Log.EventLog.Add(message);
                eventLogList.DataSource = null;
                eventLogList.DataSource = Log.EventLog.ToList();
                thingsList.DataSource = null;
                thingsList.DataSource = Thing.Items.Values.ToList();
                Log.Writer(message);

            }
        }
    }
}
