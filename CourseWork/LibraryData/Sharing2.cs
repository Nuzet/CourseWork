using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryData
{
    public class Sharing2:Base<Sharing2>
    {
        private Guid _userId;
        public User User
        {
            get
            {
                return User.Items[_userId];
            }
            set
            {
                _userId = value.Id;
            }
        }

        private Guid _bookId;

        public Book Book
        {
            get
            {
                return Book.Items[_bookId];
            }
            set
            {
                _bookId = value.Id;
            }
        }
    }
}
