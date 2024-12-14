namespace Hotel_Client_Management_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            btnCheckIn = new Button();
            panelSlide = new Panel();
            btnReport = new Button();
            btnReservation = new Button();
            btnRoomAvailable = new Button();
            btnCustomer = new Button();
            btnDashboard = new Button();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            lblUsername = new Label();
            label1 = new Label();
            panel5 = new Panel();
            lblDateTime = new Label();
            linkLabelLogOut = new LinkLabel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            userControlDashboard1 = new UControl.UserControlDashboard();
            userControlReservation2 = new UControl.UserControlReservation();
            userControlCheckInAndOut2 = new UControl.UserControlCheckInAndOut();
            userControlReport1 = new UControl.UserControlReport();
            userControlCustomer1 = new UControl.UserControlCustomer();
            userControlRoom1 = new UControl.UserControlRoom();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(btnCheckIn);
            panel1.Controls.Add(panelSlide);
            panel1.Controls.Add(btnReport);
            panel1.Controls.Add(btnReservation);
            panel1.Controls.Add(btnRoomAvailable);
            panel1.Controls.Add(btnCustomer);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 720);
            panel1.TabIndex = 0;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCheckIn.Cursor = Cursors.Hand;
            btnCheckIn.FlatAppearance.BorderSize = 0;
            btnCheckIn.FlatStyle = FlatStyle.Flat;
            btnCheckIn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckIn.ForeColor = Color.White;
            btnCheckIn.Image = Properties.Resources.check_in;
            btnCheckIn.ImageAlign = ContentAlignment.MiddleLeft;
            btnCheckIn.Location = new Point(47, 393);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(161, 49);
            btnCheckIn.TabIndex = 7;
            btnCheckIn.Text = "    Check - In";
            btnCheckIn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCheckIn.UseVisualStyleBackColor = true;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // panelSlide
            // 
            panelSlide.BackColor = Color.White;
            panelSlide.Location = new Point(31, 263);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(10, 43);
            panelSlide.TabIndex = 0;
            // 
            // btnReport
            // 
            btnReport.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnReport.Cursor = Cursors.Hand;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.ForeColor = Color.White;
            btnReport.Image = Properties.Resources.health_check;
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(47, 635);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(161, 49);
            btnReport.TabIndex = 6;
            btnReport.Text = "   Report";
            btnReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnReservation
            // 
            btnReservation.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnReservation.Cursor = Cursors.Hand;
            btnReservation.FlatAppearance.BorderSize = 0;
            btnReservation.FlatStyle = FlatStyle.Flat;
            btnReservation.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservation.ForeColor = Color.White;
            btnReservation.Image = Properties.Resources.booking__1_;
            btnReservation.ImageAlign = ContentAlignment.MiddleLeft;
            btnReservation.Location = new Point(47, 558);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(161, 49);
            btnReservation.TabIndex = 4;
            btnReservation.Text = "   Reservation";
            btnReservation.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReservation.UseVisualStyleBackColor = true;
            btnReservation.Click += btnReservation_Click;
            // 
            // btnRoomAvailable
            // 
            btnRoomAvailable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnRoomAvailable.Cursor = Cursors.Hand;
            btnRoomAvailable.FlatAppearance.BorderSize = 0;
            btnRoomAvailable.FlatStyle = FlatStyle.Flat;
            btnRoomAvailable.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoomAvailable.ForeColor = Color.White;
            btnRoomAvailable.Image = Properties.Resources.room__2_;
            btnRoomAvailable.ImageAlign = ContentAlignment.MiddleLeft;
            btnRoomAvailable.Location = new Point(47, 472);
            btnRoomAvailable.Name = "btnRoomAvailable";
            btnRoomAvailable.Size = new Size(161, 49);
            btnRoomAvailable.TabIndex = 3;
            btnRoomAvailable.Text = "       Room          Available";
            btnRoomAvailable.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRoomAvailable.UseVisualStyleBackColor = true;
            btnRoomAvailable.Click += btnRoomAvailable_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCustomer.Cursor = Cursors.Hand;
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomer.ForeColor = Color.White;
            btnCustomer.Image = Properties.Resources.rating;
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(47, 309);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(161, 49);
            btnCustomer.TabIndex = 2;
            btnCustomer.Text = "      Customer";
            btnCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = Properties.Resources.layout;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(47, 233);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(161, 49);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "      Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(258, 198);
            panel3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.tessapartelle_logo;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(258, 198);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.Controls.Add(lblUsername);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(258, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1108, 198);
            panel4.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.FromArgb(64, 64, 64);
            lblUsername.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(111, 139);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(18, 19);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 64, 64);
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 139);
            label1.Name = "label1";
            label1.Size = new Size(87, 19);
            label1.TabIndex = 1;
            label1.Text = "Welcome:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(lblDateTime);
            panel5.Controls.Add(linkLabelLogOut);
            panel5.Controls.Add(pictureBox1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1108, 94);
            panel5.TabIndex = 0;
            panel5.Paint += panel5_Paint;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateTime.Location = new Point(18, 35);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(18, 19);
            lblDateTime.TabIndex = 0;
            lblDateTime.Text = "?";
            // 
            // linkLabelLogOut
            // 
            linkLabelLogOut.ActiveLinkColor = Color.FromArgb(64, 64, 64);
            linkLabelLogOut.AutoSize = true;
            linkLabelLogOut.DisabledLinkColor = Color.FromArgb(64, 64, 64);
            linkLabelLogOut.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelLogOut.ForeColor = Color.FromArgb(64, 64, 64);
            linkLabelLogOut.LinkColor = Color.Black;
            linkLabelLogOut.Location = new Point(1020, 40);
            linkLabelLogOut.Name = "linkLabelLogOut";
            linkLabelLogOut.Size = new Size(57, 16);
            linkLabelLogOut.TabIndex = 0;
            linkLabelLogOut.TabStop = true;
            linkLabelLogOut.Text = "Log Out";
            linkLabelLogOut.VisitedLinkColor = Color.FromArgb(64, 64, 64);
            linkLabelLogOut.LinkClicked += linkLabelLogOut_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.software_engineer;
            pictureBox1.Location = new Point(932, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(userControlDashboard1);
            panel2.Controls.Add(userControlReservation2);
            panel2.Controls.Add(userControlCheckInAndOut2);
            panel2.Controls.Add(userControlReport1);
            panel2.Controls.Add(userControlCustomer1);
            panel2.Controls.Add(userControlRoom1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(258, 198);
            panel2.Name = "panel2";
            panel2.Size = new Size(1108, 522);
            panel2.TabIndex = 0;
            // 
            // userControlDashboard1
            // 
            userControlDashboard1.BackColor = Color.LightGray;
            userControlDashboard1.Dock = DockStyle.Fill;
            userControlDashboard1.Location = new Point(0, 0);
            userControlDashboard1.Name = "userControlDashboard1";
            userControlDashboard1.Size = new Size(1108, 522);
            userControlDashboard1.TabIndex = 0;
            // 
            // userControlReservation2
            // 
            userControlReservation2.Dock = DockStyle.Fill;
            userControlReservation2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userControlReservation2.Location = new Point(0, 0);
            userControlReservation2.Name = "userControlReservation2";
            userControlReservation2.Size = new Size(1108, 522);
            userControlReservation2.TabIndex = 0;
            userControlReservation2.Visible = false;
            // 
            // userControlCheckInAndOut2
            // 
            userControlCheckInAndOut2.Dock = DockStyle.Fill;
            userControlCheckInAndOut2.Location = new Point(0, 0);
            userControlCheckInAndOut2.Name = "userControlCheckInAndOut2";
            userControlCheckInAndOut2.Size = new Size(1108, 522);
            userControlCheckInAndOut2.TabIndex = 0;
            userControlCheckInAndOut2.Visible = false;
            // 
            // userControlReport1
            // 
            userControlReport1.Dock = DockStyle.Fill;
            userControlReport1.Location = new Point(0, 0);
            userControlReport1.Name = "userControlReport1";
            userControlReport1.Size = new Size(1108, 522);
            userControlReport1.TabIndex = 0;
            userControlReport1.Visible = false;
            // 
            // userControlCustomer1
            // 
            userControlCustomer1.BackColor = Color.White;
            userControlCustomer1.Dock = DockStyle.Fill;
            userControlCustomer1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControlCustomer1.Location = new Point(0, 0);
            userControlCustomer1.Name = "userControlCustomer1";
            userControlCustomer1.Size = new Size(1108, 522);
            userControlCustomer1.TabIndex = 0;
            userControlCustomer1.Visible = false;
            // 
            // userControlRoom1
            // 
            userControlRoom1.BackColor = Color.White;
            userControlRoom1.Dock = DockStyle.Fill;
            userControlRoom1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userControlRoom1.Location = new Point(0, 0);
            userControlRoom1.Name = "userControlRoom1";
            userControlRoom1.Size = new Size(1108, 522);
            userControlRoom1.TabIndex = 0;
            userControlRoom1.Visible = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1366, 720);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox1;
        private LinkLabel linkLabelLogOut;
        private PictureBox pictureBox2;
        private Label lblUsername;
        private Label label1;
        private Label lblDateTime;
        private Button btnDashboard;
        private Button btnRoomAvailable;
        private Button btnCustomer;
        private Button btnReservation;
        private Button btnReport;
        private Panel panelSlide;
        private Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private UControl.UserControlRoom userControlRoom1;
        private UControl.UserControlCustomer userControlCustomer1;
        private UControl.UserControlReservation userControlReservation1;
        private Button btnCheckIn;
        private UControl.UserControlCheckInAndOut userControlCheckInAndOut1;
        private UControl.UserControlReport userControlReport1;
        private UControl.UserControlDashboard userControlDashboard1;
        private UControl.UserControlReservation userControlReservation2;
        private UControl.UserControlCheckInAndOut userControlCheckInAndOut2;
    }
}