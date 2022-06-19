using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryData
{
    public class Thing :Base <Thing>
    {
        public string NameThing { get; set; }

        public int Count { get; set; }

     

       
        

        private int tempCount;

        public int TempCount
        {
            get { return tempCount; }
            private set
            {
                tempCount = Count;
            }
        }

        public Thing():this(default,default)
        {

        }
        public Thing(string name , int count )
        {
            this.NameThing = name;
            this.Count = count;
            

        }

        public List<Sharing3> Sharings3
        {
            get
            {
                return Sharing3.Items.Values.Where(sh => sh.Thing == this).ToList();
            }
        }
        public List<User> Users 
        {
            get
            {
                return Sharing3.Items.Values.Where(sh => sh.Thing == this).Select(sh => sh.User).ToList();
            }
        }

        public override string ToString()
        {
            return String.Format($"{NameThing} ({Count})");
        }
    }
}
