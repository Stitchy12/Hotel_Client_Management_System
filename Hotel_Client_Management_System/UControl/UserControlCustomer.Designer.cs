namespace Hotel_Client_Management_System.UControl
{
    partial class UserControlCustomer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tControlCustomer = new TabControl();
            tabPageSearchCustomer = new TabPage();
            groupBox2 = new GroupBox();
            btnViewHistory = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            dataGVCustomer = new DataGridView();
            cus_id = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            cus_type = new DataGridViewTextBoxColumn();
            cus_phone = new DataGridViewTextBoxColumn();
            cus_address = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            tabPageCustomerHistory = new TabPage();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            txtLastCheckedIn = new TextBox();
            label5 = new Label();
            label3 = new Label();
            txtCustomerStatus = new TextBox();
            label2 = new Label();
            txtTimeCheckedIn = new TextBox();
            label10 = new Label();
            txtBalance = new TextBox();
            label11 = new Label();
            txtCustomerAddress = new TextBox();
            label8 = new Label();
            txtCustomerPhoneNumber = new TextBox();
            label9 = new Label();
            txtCustomerType = new TextBox();
            label7 = new Label();
            txtCustomerLastName = new TextBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            txtCustomerFirstName = new TextBox();
            tControlCustomer.SuspendLayout();
            tabPageSearchCustomer.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVCustomer).BeginInit();
            tabPageCustomerHistory.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tControlCustomer
            // 
            tControlCustomer.Alignment = TabAlignment.Bottom;
            tControlCustomer.Anchor = AnchorStyles.None;
            tControlCustomer.Controls.Add(tabPageSearchCustomer);
            tControlCustomer.Controls.Add(tabPageCustomerHistory);
            tControlCustomer.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tControlCustomer.Location = new Point(3, 3);
            tControlCustomer.Name = "tControlCustomer";
            tControlCustomer.SelectedIndex = 0;
            tControlCustomer.Size = new Size(1096, 532);
            tControlCustomer.TabIndex = 0;
            // 
            // tabPageSearchCustomer
            // 
            tabPageSearchCustomer.Controls.Add(groupBox2);
            tabPageSearchCustomer.Location = new Point(4, 4);
            tabPageSearchCustomer.Name = "tabPageSearchCustomer";
            tabPageSearchCustomer.Padding = new Padding(3);
            tabPageSearchCustomer.Size = new Size(1088, 501);
            tabPageSearchCustomer.TabIndex = 1;
            tabPageSearchCustomer.Text = "Customer Information";
            tabPageSearchCustomer.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.BackColor = Color.DimGray;
            groupBox2.Controls.Add(btnViewHistory);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dataGVCustomer);
            groupBox2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1076, 489);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Customer Information";
            // 
            // btnViewHistory
            // 
            btnViewHistory.Cursor = Cursors.Hand;
            btnViewHistory.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewHistory.Location = new Point(1004, 57);
            btnViewHistory.Name = "btnViewHistory";
            btnViewHistory.Size = new Size(66, 47);
            btnViewHistory.TabIndex = 3;
            btnViewHistory.Text = "View History";
            btnViewHistory.UseVisualStyleBackColor = true;
            btnViewHistory.Click += btnViewHistory_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            txtSearch.Location = new Point(358, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(158, 26);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label1.Location = new Point(277, 19);
            label1.Name = "label1";
            label1.Size = new Size(64, 18);
            label1.TabIndex = 1;
            label1.Text = "Search:";
            // 
            // dataGVCustomer
            // 
            dataGVCustomer.AllowUserToAddRows = false;
            dataGVCustomer.AllowUserToDeleteRows = false;
            dataGVCustomer.BorderStyle = BorderStyle.None;
            dataGVCustomer.CausesValidation = false;
            dataGVCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVCustomer.Columns.AddRange(new DataGridViewColumn[] { cus_id, FullName, cus_type, cus_phone, cus_address, status });
            dataGVCustomer.Location = new Point(23, 57);
            dataGVCustomer.Name = "dataGVCustomer";
            dataGVCustomer.ReadOnly = true;
            dataGVCustomer.Size = new Size(975, 411);
            dataGVCustomer.TabIndex = 0;
            dataGVCustomer.CellClick += dataGVCustomer_CellClick_1;
            // 
            // cus_id
            // 
            cus_id.DataPropertyName = "cus_id";
            cus_id.HeaderText = "Customer ID";
            cus_id.Name = "cus_id";
            cus_id.ReadOnly = true;
            cus_id.Width = 120;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Full Name";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.Width = 200;
            // 
            // cus_type
            // 
            cus_type.DataPropertyName = "cus_type";
            cus_type.HeaderText = "Customer Type";
            cus_type.Name = "cus_type";
            cus_type.ReadOnly = true;
            cus_type.Width = 130;
            // 
            // cus_phone
            // 
            cus_phone.DataPropertyName = "cus_phone";
            cus_phone.HeaderText = "Phone No.";
            cus_phone.Name = "cus_phone";
            cus_phone.ReadOnly = true;
            cus_phone.Width = 150;
            // 
            // cus_address
            // 
            cus_address.DataPropertyName = "cus_address";
            cus_address.HeaderText = "Address";
            cus_address.Name = "cus_address";
            cus_address.ReadOnly = true;
            cus_address.Width = 230;
            // 
            // status
            // 
            status.DataPropertyName = "status";
            status.HeaderText = "Status";
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // tabPageCustomerHistory
            // 
            tabPageCustomerHistory.Controls.Add(groupBox4);
            tabPageCustomerHistory.Location = new Point(4, 4);
            tabPageCustomerHistory.Name = "tabPageCustomerHistory";
            tabPageCustomerHistory.Padding = new Padding(3);
            tabPageCustomerHistory.Size = new Size(1088, 501);
            tabPageCustomerHistory.TabIndex = 3;
            tabPageCustomerHistory.Text = "Customer History";
            tabPageCustomerHistory.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.DimGray;
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(6, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1076, 489);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Customer History";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Silver;
            groupBox5.Controls.Add(txtLastCheckedIn);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(txtCustomerStatus);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(txtTimeCheckedIn);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(txtBalance);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(txtCustomerAddress);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(txtCustomerPhoneNumber);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(txtCustomerType);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(txtCustomerLastName);
            groupBox5.Controls.Add(pictureBox1);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(txtCustomerFirstName);
            groupBox5.Location = new Point(26, 25);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1022, 438);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            // 
            // txtLastCheckedIn
            // 
            txtLastCheckedIn.Location = new Point(700, 279);
            txtLastCheckedIn.Name = "txtLastCheckedIn";
            txtLastCheckedIn.ReadOnly = true;
            txtLastCheckedIn.Size = new Size(85, 23);
            txtLastCheckedIn.TabIndex = 18;
            txtLastCheckedIn.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(678, 246);
            label5.Name = "label5";
            label5.Size = new Size(120, 16);
            label5.TabIndex = 17;
            label5.Text = "Last Checked - In";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(580, 164);
            label3.Name = "label3";
            label3.Size = new Size(45, 16);
            label3.TabIndex = 16;
            label3.Text = "Status";
            // 
            // txtCustomerStatus
            // 
            txtCustomerStatus.Location = new Point(549, 195);
            txtCustomerStatus.Name = "txtCustomerStatus";
            txtCustomerStatus.ReadOnly = true;
            txtCustomerStatus.Size = new Size(103, 23);
            txtCustomerStatus.TabIndex = 15;
            txtCustomerStatus.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(678, 164);
            label2.Name = "label2";
            label2.Size = new Size(131, 16);
            label2.TabIndex = 14;
            label2.Text = "Times Checked - In";
            // 
            // txtTimeCheckedIn
            // 
            txtTimeCheckedIn.Location = new Point(700, 195);
            txtTimeCheckedIn.Name = "txtTimeCheckedIn";
            txtTimeCheckedIn.ReadOnly = true;
            txtTimeCheckedIn.Size = new Size(85, 23);
            txtTimeCheckedIn.TabIndex = 13;
            txtTimeCheckedIn.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(560, 246);
            label10.Name = "label10";
            label10.Size = new Size(65, 16);
            label10.TabIndex = 12;
            label10.Text = "Balance:";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(549, 279);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(103, 23);
            txtBalance.TabIndex = 11;
            txtBalance.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(498, 322);
            label11.Name = "label11";
            label11.Size = new Size(60, 16);
            label11.TabIndex = 10;
            label11.Text = "Address";
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.Location = new Point(399, 351);
            txtCustomerAddress.Multiline = true;
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.Size = new Size(240, 48);
            txtCustomerAddress.TabIndex = 9;
            txtCustomerAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(224, 246);
            label8.Name = "label8";
            label8.Size = new Size(102, 16);
            label8.TabIndex = 8;
            label8.Text = "Phone Number";
            // 
            // txtCustomerPhoneNumber
            // 
            txtCustomerPhoneNumber.Location = new Point(207, 279);
            txtCustomerPhoneNumber.Name = "txtCustomerPhoneNumber";
            txtCustomerPhoneNumber.Size = new Size(134, 23);
            txtCustomerPhoneNumber.TabIndex = 7;
            txtCustomerPhoneNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(374, 246);
            label9.Name = "label9";
            label9.Size = new Size(103, 16);
            label9.TabIndex = 6;
            label9.Text = "Customer Type";
            // 
            // txtCustomerType
            // 
            txtCustomerType.Location = new Point(384, 279);
            txtCustomerType.Name = "txtCustomerType";
            txtCustomerType.ReadOnly = true;
            txtCustomerType.Size = new Size(75, 23);
            txtCustomerType.TabIndex = 5;
            txtCustomerType.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(374, 164);
            label7.Name = "label7";
            label7.Size = new Size(75, 16);
            label7.TabIndex = 4;
            label7.Text = "Last Name";
            // 
            // txtCustomerLastName
            // 
            txtCustomerLastName.Location = new Point(354, 195);
            txtCustomerLastName.Name = "txtCustomerLastName";
            txtCustomerLastName.Size = new Size(134, 23);
            txtCustomerLastName.TabIndex = 3;
            txtCustomerLastName.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.generic_user_icon_13;
            pictureBox1.Location = new Point(450, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(224, 164);
            label4.Name = "label4";
            label4.Size = new Size(75, 16);
            label4.TabIndex = 1;
            label4.Text = "First Name";
            // 
            // txtCustomerFirstName
            // 
            txtCustomerFirstName.Location = new Point(207, 195);
            txtCustomerFirstName.Name = "txtCustomerFirstName";
            txtCustomerFirstName.Size = new Size(134, 23);
            txtCustomerFirstName.TabIndex = 0;
            txtCustomerFirstName.TextAlign = HorizontalAlignment.Center;
            // 
            // UserControlCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tControlCustomer);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UserControlCustomer";
            Size = new Size(1102, 538);
            tControlCustomer.ResumeLayout(false);
            tabPageSearchCustomer.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVCustomer).EndInit();
            tabPageCustomerHistory.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tControlCustomer;
        private TabPage tabPageSearchCustomer;
        private GroupBox groupBox2;
        private DataGridView dataGVCustomer;
        private GroupBox groupBox3;
        private GroupBox groupBox1;
        private TextBox txtAddress;
        private Label label2;
        private TabPage tabPageCustomerHistory;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label4;
        private TextBox txtCustomerFirstName;
        private Label label7;
        private TextBox txtCustomerLastName;
        private PictureBox pictureBox1;
        private Label label10;
        private TextBox txtBalance;
        private Label label11;
        private TextBox txtCustomerAddress;
        private Label label8;
        private TextBox txtCustomerPhoneNumber;
        private Label label9;
        private TextBox txtCustomerType;
        private TextBox txtTimeCheckedIn;
        private TextBox txtSearch;
        private Label label1;
        private Button btnViewHistory;
        private Label label3;
        private TextBox txtCustomerStatus;
        private DataGridViewTextBoxColumn cus_id;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn cus_type;
        private DataGridViewTextBoxColumn cus_phone;
        private DataGridViewTextBoxColumn cus_address;
        private DataGridViewTextBoxColumn status;
        private TextBox txtLastCheckedIn;
        private Label label5;
    }
}
