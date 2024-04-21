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
            myConnection = new SQLiteConnection("Data Source=FitnesUsers.sqlite3");// создание файла бд 
            if (!File.Exists("./FitnesUsers.sqlite3"))// создавать файл если он не создан
            {
                SQLiteConnection.CreateFile("FitnesUsers.sqlite3");
            }
        }
        public void OpenConnection()//Метод проверки подключения и подключения к бд
        {
            if(myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }
        public void CloseConnection()// отключение от бд
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }
    }
}
