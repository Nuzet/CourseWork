using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryData
{
    public class Book:Base<Book>
    {

        private string _name;
        private string _author;// автор книги

        private int _pages; // сторінки книги 

        public string _language;// мова  книги

       


        public Guid _id { get; private set; } = Guid.NewGuid(); //  номер книги 

        public DateTime date { get;  set; } // дата 

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                }
            }
        }
        public string Author
        {
            get { return _author; }
            set
            {
                if (value != null)
                {
                    _author = value;
                }
                else
                {
                    _author = "No Author";
                }
            }
        }

        public Book(string name , string author , int pages , string language , DateTime dateTime , BookLibrary bookLibrary)
        {

            Name = name;
            Author = author;
            Pages = pages;
            Language = language;
            _id = Guid.NewGuid();
            date = dateTime;
            BookLibrary = bookLibrary;

        }

        public Book():this(default, default,default,default,default,default)
        {

        }

        

        public int Pages
        {
            get { return _pages; }
            set
            {
                if(value >0)
                {
                    _pages = value;
                }
            }
        }
         
       
        public string Language
        {
            get { return _language; }

            set
            {
                if( value != null)
                {
                    _language = value;
                }
            }
        }

        public override string ToString()
        {
            return String.Format($"Name: {_name}");
        }


        private Guid _bookLibraryID;

        public BookLibrary BookLibrary  //зв'язок  багато Book  до одного BookLibrary
        {
            get
            {
                return BookLibrary.Items[_bookLibraryID];
            }
            set { _bookLibraryID = value.Id; }
        }

        public List<Sharing2> Sharings2 // зв'язок до допоміжного класу Sharing2(багато Book до багато User ) 
        {
            get
            {
                return Sharing2.Items.Values.Where(sh => sh.Book == this).ToList();
            }
        }

        public List<User> Users // зв'язок  багато до багатьох  User
        {
            get
            {
                return Sharing2.Items.Values.Where(sh => sh.Book == this).Select(sh => sh.User).ToList();
            }
        }



    }
}
