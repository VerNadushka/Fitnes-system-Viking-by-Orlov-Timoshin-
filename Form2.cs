using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
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
            Database database = new Database();

            string query = "CREATE TABLE \"Users\" (\r\n\t\"id\"\tINTEGER NOT NULL,\r\n\t\"name\"\tTEXT,\r\n\t\"surname\"\tTEXT,\r\n\t\"patronymic\"\tTEXT,\r\n\t\"birthday\"\tTEXT,\r\n\t\"number\"\tTEXT,\r\n\t\"status\"\tTEXT,\r\n\t\"tickettime\"\tTEXT,\r\n\tPRIMARY KEY(\"id\" AUTOINCREMENT)\r\n);";
            database.myConnection.Open();
            SQLiteCommand command = new SQLiteCommand(query, database.myConnection);
            command.ExecuteNonQuery();
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
            string number = numberbox.Text;
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
            string query = "INSERT INTO Users ('name', 'surname', 'patronymic','ticket', 'birthday','number') VALUES (@name, @surname, @patronymic, @ticket, @birthday,@number)";
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObj.myConnection);
            databaseObj.OpenConnection();
            myCommand.Parameters.AddWithValue($"@name", name);
            myCommand.Parameters.AddWithValue($"@surname", surname);
            myCommand.Parameters.AddWithValue($"@patronymic", patronymic);
            myCommand.Parameters.AddWithValue($"@birthday", birthday);
            myCommand.Parameters.AddWithValue($"@ticket", ticket);
            myCommand.Parameters.AddWithValue($"@number", number);
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
            Database dataobject = new Database();
            dataobject.OpenConnection();
            //string query = "SELECT * FROM Users ORDER BY id";
            //SQLiteCommand command = new SQLiteCommand(query, dataobject.myConnection);
            //SQLiteDataReader reader = command.ExecuteReader();
            //List<string[]> data = new List<string[]>();


            //while (reader.Read())
            //{
            //    data.Add(new string[6]);
            //    data[data.Count - 1][0] = reader[0].ToString();
            //    data[data.Count - 1][1] = reader[0].ToString();
            //    data[data.Count - 1][2] = reader[0].ToString();
            //    data[data.Count - 1][3] = reader[0].ToString();
            //    data[data.Count - 1][4] = reader[0].ToString();
            //    data[data.Count - 1][5] = reader[0].ToString();
            //}
            //reader.Close();
            //dataobject.CloseConnection();
            //foreach (string[] row in data)
            //{
            //    dataGridView1.Rows.Add(row);
            //}
            DataTable dt = new DataTable();
            using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Users", dataobject.myConnection))
            {
                da.Fill(dt);
                dataGridView1.DataSource= dt;
            }
            dataobject.CloseConnection();

        }

        private void surnamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        Point mousepoint;
        private void UpPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mousepoint.X;
                this.Top += e.Y - mousepoint.Y;
            }
        }

        private void UpPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mousepoint = new Point(e.X, e.Y);
        }
    }

} 