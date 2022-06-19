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
    public partial class ReviewForm : Form
    {
        public ReviewForm()
        {
            InitializeComponent();
        }

        private void button_ReviewForm_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            usersList.DataSource = User.Items.Values.ToList();
            eventLogList.DataSource = Log.EventLog.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_review_Send_Click(object sender, EventArgs e)
        {
            if((User)usersList.SelectedItem!=null)
            {
                string tempName = ((User)usersList.SelectedItem).Name;

                string review = $"{tempName}:  {textBoxReview.Text} ";
                string message = $"User:{tempName} left a review!";
                Log.EventLog.Add(message);
                Log.ReviewToFile(review);
                Log.Writer(message);
                eventLogList.DataSource = null;
                eventLogList.DataSource = Log.EventLog.ToList();
                textBoxReview.Text = null;

            }
        }
      
    }
}
