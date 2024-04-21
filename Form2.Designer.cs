namespace Fitnes_system_Viking__by_Orlov__Timoshin_
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            UpPanel = new Panel();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            patronymicbox = new TextBox();
            surnamebox = new TextBox();
            namebox = new TextBox();
            yearbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ticketcheckbox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 25;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // UpPanel
            // 
            UpPanel.BackColor = Color.FromArgb(64, 64, 64);
            UpPanel.Dock = DockStyle.Top;
            UpPanel.Location = new Point(0, 0);
            UpPanel.Name = "UpPanel";
            UpPanel.Size = new Size(1042, 41);
            UpPanel.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 519);
            button1.Name = "button1";
            button1.Size = new Size(80, 21);
            button1.TabIndex = 1;
            button1.Text = "бд";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(511, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(519, 461);
            dataGridView1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(54, 222);
            button2.Name = "button2";
            button2.Size = new Size(148, 23);
            button2.TabIndex = 3;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // patronymicbox
            // 
            patronymicbox.Location = new Point(12, 168);
            patronymicbox.Name = "patronymicbox";
            patronymicbox.Size = new Size(100, 23);
            patronymicbox.TabIndex = 4;
            // 
            // surnamebox
            // 
            surnamebox.Location = new Point(12, 121);
            surnamebox.Name = "surnamebox";
            surnamebox.Size = new Size(100, 23);
            surnamebox.TabIndex = 5;
            // 
            // namebox
            // 
            namebox.Location = new Point(138, 121);
            namebox.Name = "namebox";
            namebox.Size = new Size(100, 23);
            namebox.TabIndex = 6;
            // 
            // yearbox
            // 
            yearbox.Location = new Point(138, 168);
            yearbox.Name = "yearbox";
            yearbox.Size = new Size(100, 23);
            yearbox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 103);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 8;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 9;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 150);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 10;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 150);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 11;
            label4.Text = "Год рождения";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 68);
            label5.Name = "label5";
            label5.Size = new Size(152, 15);
            label5.TabIndex = 12;
            label5.Text = "Добавление пользователя";
            // 
            // ticketcheckbox
            // 
            ticketcheckbox.AutoSize = true;
            ticketcheckbox.Location = new Point(278, 121);
            ticketcheckbox.Name = "ticketcheckbox";
            ticketcheckbox.Size = new Size(144, 19);
            ticketcheckbox.TabIndex = 13;
            ticketcheckbox.Text = "Наличие абонемента";
            ticketcheckbox.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 583);
            Controls.Add(ticketcheckbox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(yearbox);
            Controls.Add(namebox);
            Controls.Add(surnamebox);
            Controls.Add(patronymicbox);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(UpPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Panel UpPanel;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox yearbox;
        private TextBox namebox;
        private TextBox surnamebox;
        private TextBox patronymicbox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private CheckBox ticketcheckbox;
        private Label label5;
    }
}