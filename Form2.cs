using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Fitnes_system_Viking__by_Orlov__Timoshin_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database databaseObject = new Database();

            /*
             * INSERT INTO DATABASE
             * 
             */
            //string query = "INSERT INTO users";
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = namebox.Text;
            string surname = surnamebox.Text;
            string patronymic = patronymicbox.Text;
            string birthday = yearbox.Text;
            string ticket;
            if (ticketcheckbox.Checked == true)
            {
                ticket = "Есть";
            }
            else
            {
                ticket = "Нету";
            }
            Database databaseObj = new Database();
            /**
             * INSERT INTO DATABASE
             * *
             */
            string query = "INSERT INTO Users ('name', 'surname', 'patronymic','ticket', 'birthday') VALUES (@name, @surname, @patronymic, @ticket, @birthday)";
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObj.myConnection);
            databaseObj.OpenConnection();
            myCommand.Parameters.AddWithValue($"@name", name);
            myCommand.Parameters.AddWithValue($"@surname", surname);
            myCommand.Parameters.AddWithValue($"@patronymic", patronymic);
            myCommand.Parameters.AddWithValue($"@birthday", birthday);
            myCommand.Parameters.AddWithValue($"@ticket", ticket);
            var result = myCommand.ExecuteNonQuery();
            databaseObj.CloseConnection();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ticketcheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoadData_Click(object sender, EventArgs e)
        {

        }
    }
}
