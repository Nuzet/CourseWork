using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryData
{
    public class User : Base<User>
    {

        public string Name { get; set; } // имя

        public DateTime _age { get; set; } // возраст (дата)


        public bool isStudent { get; set; } // чи студент?

        public bool isRentedBook { get; set; } = false; // чи взяв книгу?


        public User():this(default, default,default)
        {

        }
        public User (string name , DateTime age , bool isStudent )
        {
            this.Name = name;
            this.isStudent = isStudent;
            this._age = age;
        }


        public List<Sharing> Sharings// зв'язок до допоміжного класу Sharing (багато BookLibrary до багато User ) 
        {
            get
            {
                return Sharing.Items.Values.Where(sh=>sh.User==this ).ToList(); 
            }
        }

        public List<BookLibrary> BookLibraries// зв'язок  багато до  багатьох  BookLibrary
        {
            get
            {
                return Sharing.Items.Values.Where(sh => sh.User == this).Select(sh => sh.BookLibrary).ToList();
            }
        }

        public List<Sharing2> Sharings2 // зв'язок до допоміжного класу Sharing2(багато Book до багато User ) 
        {
            get
            {
                return Sharing2.Items.Values.Where(sh => sh.User == this).ToList();
            }
        }

        public List<Book> Books // зв'язок  багато до  багатьох  Book
        {
            get
            {
                return Sharing2.Items.Values.Where(sh => sh.User == this).Select(sh => sh.Book).ToList();
            }
        }
        public List <Sharing3> Sharings3
        {
            get
            {
                return Sharing3.Items.Values.Where(sh => sh.User == this).ToList();
            }
        }

        public List<Thing> Things
        {
            get
            {
                return Sharing3.Items.Values.Where(sh=>sh.User == this).Select(sh => sh.Thing).ToList();
            }
        }



        public override string ToString()
        {
            int ages = (DateTime.Now - _age).Days / 365;
            return string.Format($"Name: {Name}\tAge:{ages}");
        }

    }
}
