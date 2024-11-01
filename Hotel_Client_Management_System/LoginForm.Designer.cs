namespace Hotel_Client_Management_System
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            chkShow = new CheckBox();
            lblExit = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtUser = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(chkShow);
            panel1.Controls.Add(lblExit);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(343, 190);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 360);
            panel1.TabIndex = 0;
            // 
            // chkShow
            // 
            chkShow.AutoSize = true;
            chkShow.Cursor = Cursors.Hand;
            chkShow.FlatStyle = FlatStyle.Flat;
            chkShow.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkShow.Location = new Point(474, 225);
            chkShow.Name = "chkShow";
            chkShow.Size = new Size(119, 21);
            chkShow.TabIndex = 8;
            chkShow.Text = "Show Password";
            chkShow.UseVisualStyleBackColor = true;
            chkShow.CheckedChanged += chkShow_CheckedChanged;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Cursor = Cursors.Hand;
            lblExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.Location = new Point(645, 12);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(24, 25);
            lblExit.TabIndex = 7;
            lblExit.Text = "X";
            lblExit.Click += label2_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(192, 192, 255);
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = Color.RosyBrown;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.Black;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(468, 266);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 34);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseMnemonic = false;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(407, 192);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(186, 27);
            txtPassword.TabIndex = 5;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(355, 192);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(355, 138);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(407, 138);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = " Username";
            txtUser.Size = new Size(186, 27);
            txtUser.TabIndex = 2;
            txtUser.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(393, 58);
            label1.Name = "label1";
            label1.Size = new Size(200, 37);
            label1.TabIndex = 0;
            label1.Text = "Admin Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1081, 648);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tess Apartelle Login";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtUser;
        private Button btnLogin;
        private TextBox txtPassword;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label lblExit;
        private CheckBox chkShow;
    }
}
