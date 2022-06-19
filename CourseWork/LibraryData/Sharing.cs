using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryData
{
    public  class Sharing: Base<Sharing>
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

        private Guid _bookLibraryId;

        public BookLibrary BookLibrary
        {
            get
            {
                return BookLibrary.Items[_bookLibraryId];
            }
            set
            {
                _bookLibraryId = value.Id;
            }
        }

      
        
        

    }
}
