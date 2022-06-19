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
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }

        private void button_SecondForm_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {

        }

        private void button_open_bookRentListForm_Click(object sender, EventArgs e)
        {
            new bookRentListForm().Show();
        }

        private void button_thingRentalListOpen_Click(object sender, EventArgs e)
        {
            new thingRentListForm().Show();
        }

        private void buttonReview_Click(object sender, EventArgs e)
        {
            new ReviewForm().Show();
        }
    }
}
