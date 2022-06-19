using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibraryData
{
    public struct Log
    {
        public static List<string> EventLog = new List<string>();

        public static void UserHistoryLog(string userInfoToFile)
        {
            using(StreamWriter sw = new StreamWriter("..\\..\\..\\UserHistoryLog.txt",true))
            {
                
                sw.WriteLine(userInfoToFile+"\t Date:  " +DateTime.Now);
                sw.WriteLine();
            }
        }

        public static void ReviewToFile(string review)
        {
            using (StreamWriter streamWriter = new StreamWriter("..\\..\\..\\reviews.txt", true))
            {
                streamWriter.WriteLine(review+ "\t Date:  " + DateTime.Now);
                streamWriter.WriteLine();
            }
        }
        public static void Writer(string message)
        {
            using (StreamWriter writer = new StreamWriter("..\\..\\..\\eventLog.txt", true))
            {
                writer.WriteLine(message + "\tDate:   " + DateTime.Now);
                writer.WriteLine();
            }
        }

    }
}
