using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryData
{
    public class BookLibrary: Base<BookLibrary>
    {
        public string Name { get; set; }

        public BookLibrary(string name)
        {
            this.Name = name;

        }
        public BookLibrary() : this(default)
        {

        }

        public override string ToString()
        {
            return string.Format("Book Name : " + Name);
        }

        public List<Book> BookItems //зв'язок  один  до  багатьох Book
        {
            get 
            {
               List<Book> books = new List<Book>();

                foreach (var item in Book.Items.Values)
                {
                    if( item.BookLibrary== this)
                    {
                        books.Add((Book)item);
                    }
                }
                return books;
            }
        }
        public List<Sharing> Sharings // зв'язок до допоміжного класу Sharing (багато BookLibrary до багато User ) 
        {
            get
            {
                return Sharing.Items.Values.Where(sh => sh.BookLibrary == this).ToList();
            }
        }
        public List<User> Users //зв'язок багато до багатьох  User
        {
            get
            {
                return Sharing.Items.Values.Where(sh => sh.BookLibrary == this).Select(sh=>sh.User).ToList();
            }
        }



     
        

    }
}
