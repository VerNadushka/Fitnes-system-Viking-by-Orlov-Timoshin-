namespace Fitnes_system_Viking__by_Orlov__Timoshin_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point mousepoint;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mousepoint.X;
                this.Top += e.Y - mousepoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousepoint = new Point(e.X, e.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PassHide();
        }

        private void PassShow()
        {
            PasswordTextBox.UseSystemPasswordChar = false;
        }
        private void PassHide()
        {
            PasswordTextBox.UseSystemPasswordChar = true;
        }
        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked == true)
            {
                PassShow();
            }
            else if (guna2CheckBox1.Checked == false)
            {
                PassHide();
            }
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string login = "Admin";
            string password = "AdminPass";
            if (LoginTextBox.Text == login || PasswordTextBox.Text == password )
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильно введен пароль или логин", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}