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
using System.IO;
namespace Library
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var harryPotterMainBook = new BookLibrary("Harry Potter ");


            InputUsersFromFile("..\\..\\..\\inputUsers.txt");
            InputBooksFromFile("..\\..\\..\\inputBooksHarryPotter.txt", harryPotterMainBook);
            InputThingsFromFile("..\\..\\..\\inputThings.txt");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AdminForm().Show();
        }

        private void btn_MainFormClose_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void InputUsersFromFile(string filName)
        {

            using (StreamReader sr = new StreamReader(filName))
            {
                try
                {
                    while (!sr.EndOfStream)
                    {
                        string[] lines = sr.ReadLine().Split(" ");
                        if(DateTime.TryParse(lines[1], out DateTime date)&& bool.TryParse(lines[2], out bool isStudent))
                        {
                            User u = new User(lines[0], date , isStudent);
                            string user = $"User: {u.Name}\t   ID: {u.Id}\t   BirthDay: {u._age}\t   Student:{u.isStudent}  ";
                            Log.UserHistoryLog(user);

                        }

                    }
                }
                catch (Exception ex)
                {

                }
            }


        }

        private void InputThingsFromFile(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);

            while (!sr.EndOfStream)
            {
                try
                {
                    string[] lines = sr.ReadLine().Split(' ');
                    if (int.TryParse(lines[1], out int count) )
                    {
                        new Thing(lines[0], count);
                    }
                }
                catch (Exception ex)
                {

                }
            }


        }

        private void InputBooksFromFile(string fileName , BookLibrary bookLibrary)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                {
                    string[] lines = sr.ReadLine().Split(", ");

                    new Book(lines[0], lines[1], Convert.ToInt32(lines[2]), lines [3] , Convert.ToDateTime(lines[4]) , bookLibrary);

                }
            }
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
          new GuestForm().Show();
        }
    }
}
