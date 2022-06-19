using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryData
{
    public  class Sharing3:Base<Sharing3>
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

        private Guid _thingId;

        public Thing Thing
        {
            get
            {
                return Thing.Items[_thingId];
            }
            set
            {
                _thingId = value.Id;
            }
        }
        
    }
}
