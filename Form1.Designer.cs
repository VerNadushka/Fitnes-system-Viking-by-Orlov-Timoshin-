namespace Fitnes_system_Viking__by_Orlov__Timoshin_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panel1 = new Panel();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            label1 = new Label();
            LoginTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            PasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2BorderlessForm2
            // 
            guna2BorderlessForm2.BorderRadius = 35;
            guna2BorderlessForm2.ContainerControl = this;
            guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm2.TransparentWhileDrag = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 46, 46);
            panel1.Controls.Add(guna2CircleButton1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 110);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.Cursor = Cursors.Hand;
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.FromArgb(64, 64, 64);
            guna2CircleButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Location = new Point(355, 7);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges7;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(29, 28);
            guna2CircleButton1.TabIndex = 1;
            guna2CircleButton1.Text = "X";
            guna2CircleButton1.Click += guna2CircleButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(135, 33);
            label1.Name = "label1";
            label1.Size = new Size(120, 42);
            label1.TabIndex = 0;
            label1.Text = "ВХОД";
            label1.Click += label1_Click;
            // 
            // LoginTextBox
            // 
            LoginTextBox.BorderRadius = 10;
            LoginTextBox.CustomizableEdges = customizableEdges5;
            LoginTextBox.DefaultText = "";
            LoginTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            LoginTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            LoginTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            LoginTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            LoginTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            LoginTextBox.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LoginTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            LoginTextBox.Location = new Point(51, 152);
            LoginTextBox.Margin = new Padding(5);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.PasswordChar = '\0';
            LoginTextBox.PlaceholderText = "Логин";
            LoginTextBox.SelectedText = "";
            LoginTextBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            LoginTextBox.Size = new Size(276, 40);
            LoginTextBox.TabIndex = 1;
            LoginTextBox.TextChanged += LoginTextBox_TextChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BorderRadius = 10;
            PasswordTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            PasswordTextBox.CustomizableEdges = customizableEdges3;
            PasswordTextBox.DefaultText = "";
            PasswordTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PasswordTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PasswordTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PasswordTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PasswordTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTextBox.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTextBox.Location = new Point(51, 220);
            PasswordTextBox.Margin = new Padding(5);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '\0';
            PasswordTextBox.PlaceholderText = " Пароль";
            PasswordTextBox.SelectedText = "";
            PasswordTextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            PasswordTextBox.Size = new Size(276, 40);
            PasswordTextBox.TabIndex = 2;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 15;
            guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Button1.Cursor = Cursors.Hand;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(0, 192, 0);
            guna2Button1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(105, 437);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(180, 45);
            guna2Button1.TabIndex = 3;
            guna2Button1.Text = "Войти";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // guna2CheckBox1
            // 
            guna2CheckBox1.AutoSize = true;
            guna2CheckBox1.CheckedState.BorderColor = Color.FromArgb(0, 192, 0);
            guna2CheckBox1.CheckedState.BorderRadius = 0;
            guna2CheckBox1.CheckedState.BorderThickness = 0;
            guna2CheckBox1.CheckedState.FillColor = Color.FromArgb(0, 192, 0);
            guna2CheckBox1.Cursor = Cursors.Hand;
            guna2CheckBox1.Location = new Point(63, 268);
            guna2CheckBox1.Name = "guna2CheckBox1";
            guna2CheckBox1.Size = new Size(119, 19);
            guna2CheckBox1.TabIndex = 4;
            guna2CheckBox1.Text = "Показать пароль";
            guna2CheckBox1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            guna2CheckBox1.UncheckedState.BorderRadius = 0;
            guna2CheckBox1.UncheckedState.BorderThickness = 0;
            guna2CheckBox1.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            guna2CheckBox1.CheckedChanged += guna2CheckBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 518);
            Controls.Add(guna2CheckBox1);
            Controls.Add(guna2Button1);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(392, 518);
            MinimumSize = new Size(392, 518);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.CodeDom.CodeTypeReference guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
        private Panel panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox LoginTextBox;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
    }
}