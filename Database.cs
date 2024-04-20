using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
namespace Fitnes_system_Viking__by_Orlov__Timoshin_
{
    internal class Database
    {
        public SQLiteConnection myConnection;
        public Database()
        {
            myConnection = new SQLiteConnection("DBfitnes.sqlite3");
            if (File.Exists("./DBfitnes.sqlite3"))
            {
            SQLiteConnection.CreateFile("");

            }
        }
    }
}
