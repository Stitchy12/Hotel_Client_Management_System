namespace Hotel_Client_Management_System.UControl
{
    partial class UserControlCheckInAndOut
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
            tabControlCheckInAndOut = new TabControl();
            tabPageAddCheckIn = new TabPage();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            txtCheckInPrice = new TextBox();
            cmbCheckInRoomDescription = new ComboBox();
            label5 = new Label();
            label12 = new Label();
            cmbCheckInRoomType = new ComboBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            label11 = new Label();
            txtCustomerType = new TextBox();
            label10 = new Label();
            txtCheckInAddress = new TextBox();
            label8 = new Label();
            txtCheckInPhoneNumber = new TextBox();
            label9 = new Label();
            txtCheckInFirstName = new TextBox();
            txtCheckInLastName = new TextBox();
            label3 = new Label();
            btnCheckIn = new Button();
            tabPageSearchCheckIn = new TabPage();
            groupBox2 = new GroupBox();
            txtSearchCheckInID = new TextBox();
            label4 = new Label();
            dataGVCheckIn = new DataGridView();
            check_in_id = new DataGridViewTextBoxColumn();
            cus_id = new DataGridViewTextBoxColumn();
            room_type = new DataGridViewTextBoxColumn();
            room_description = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            check_in_date = new DataGridViewTextBoxColumn();
            tabPageCheckOut = new TabPage();
            groupBox5 = new GroupBox();
            btnCancel = new Button();
            btnUpdate = new Button();
            cmbCheckOutRoomDescription = new ComboBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            dptUpdateCheckOut = new DateTimePicker();
            dtpUpdateCheckIn = new DateTimePicker();
            cmbUpdatePrice = new ComboBox();
            cmbCheckOutRoomType = new ComboBox();
            label16 = new Label();
            label17 = new Label();
            comboBox1 = new ComboBox();
            tabControlCheckInAndOut.SuspendLayout();
            tabPageAddCheckIn.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPageSearchCheckIn.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVCheckIn).BeginInit();
            tabPageCheckOut.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCheckInAndOut
            // 
            tabControlCheckInAndOut.Alignment = TabAlignment.Bottom;
            tabControlCheckInAndOut.Controls.Add(tabPageAddCheckIn);
            tabControlCheckInAndOut.Controls.Add(tabPageSearchCheckIn);
            tabControlCheckInAndOut.Controls.Add(tabPageCheckOut);
            tabControlCheckInAndOut.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControlCheckInAndOut.Location = new Point(3, 3);
            tabControlCheckInAndOut.Name = "tabControlCheckInAndOut";
            tabControlCheckInAndOut.SelectedIndex = 0;
            tabControlCheckInAndOut.Size = new Size(1096, 535);
            tabControlCheckInAndOut.TabIndex = 1;
            // 
            // tabPageAddCheckIn
            // 
            tabPageAddCheckIn.Controls.Add(groupBox3);
            tabPageAddCheckIn.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageAddCheckIn.Location = new Point(4, 4);
            tabPageAddCheckIn.Name = "tabPageAddCheckIn";
            tabPageAddCheckIn.Padding = new Padding(3);
            tabPageAddCheckIn.Size = new Size(1088, 504);
            tabPageAddCheckIn.TabIndex = 0;
            tabPageAddCheckIn.Text = "Add Check - In";
            tabPageAddCheckIn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.BackColor = Color.DimGray;
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(groupBox1);
            groupBox3.Controls.Add(btnCheckIn);
            groupBox3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(6, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1076, 492);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Check - In And Check - Out";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Silver;
            groupBox4.Controls.Add(txtCheckInPrice);
            groupBox4.Controls.Add(cmbCheckInRoomDescription);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(cmbCheckInRoomType);
            groupBox4.Controls.Add(label6);
            groupBox4.Location = new Point(527, 37);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(476, 384);
            groupBox4.TabIndex = 28;
            groupBox4.TabStop = false;
            groupBox4.Text = "Room and Price";
            // 
            // txtCheckInPrice
            // 
            txtCheckInPrice.Location = new Point(172, 263);
            txtCheckInPrice.Name = "txtCheckInPrice";
            txtCheckInPrice.ReadOnly = true;
            txtCheckInPrice.Size = new Size(128, 23);
            txtCheckInPrice.TabIndex = 37;
            txtCheckInPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbCheckInRoomDescription
            // 
            cmbCheckInRoomDescription.Anchor = AnchorStyles.None;
            cmbCheckInRoomDescription.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCheckInRoomDescription.FlatStyle = FlatStyle.Flat;
            cmbCheckInRoomDescription.FormattingEnabled = true;
            cmbCheckInRoomDescription.Location = new Point(255, 142);
            cmbCheckInRoomDescription.Name = "cmbCheckInRoomDescription";
            cmbCheckInRoomDescription.Size = new Size(128, 24);
            cmbCheckInRoomDescription.TabIndex = 14;
            cmbCheckInRoomDescription.SelectedIndexChanged += cmbCheckInRoomDescription_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(255, 104);
            label5.Margin = new Padding(3);
            label5.Name = "label5";
            label5.Size = new Size(142, 18);
            label5.TabIndex = 2;
            label5.Text = "Room Description:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(172, 223);
            label12.Margin = new Padding(3);
            label12.Name = "label12";
            label12.Size = new Size(49, 18);
            label12.TabIndex = 26;
            label12.Text = "Price:";
            // 
            // cmbCheckInRoomType
            // 
            cmbCheckInRoomType.Anchor = AnchorStyles.None;
            cmbCheckInRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCheckInRoomType.FlatStyle = FlatStyle.Flat;
            cmbCheckInRoomType.FormattingEnabled = true;
            cmbCheckInRoomType.Location = new Point(65, 142);
            cmbCheckInRoomType.Name = "cmbCheckInRoomType";
            cmbCheckInRoomType.Size = new Size(128, 24);
            cmbCheckInRoomType.TabIndex = 9;
            cmbCheckInRoomType.SelectedIndexChanged += cmbCheckInRoomType_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(65, 104);
            label6.Margin = new Padding(3);
            label6.Name = "label6";
            label6.Size = new Size(94, 18);
            label6.TabIndex = 0;
            label6.Text = "Room Type:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Silver;
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtCustomerType);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtCheckInAddress);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtCheckInPhoneNumber);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtCheckInFirstName);
            groupBox1.Controls.Add(txtCheckInLastName);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(43, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 384);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(253, 164);
            label11.Margin = new Padding(3);
            label11.Name = "label11";
            label11.Size = new Size(121, 18);
            label11.TabIndex = 26;
            label11.Text = "Customer Type:";
            // 
            // txtCustomerType
            // 
            txtCustomerType.Location = new Point(274, 197);
            txtCustomerType.Name = "txtCustomerType";
            txtCustomerType.Size = new Size(85, 23);
            txtCustomerType.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(35, 263);
            label10.Margin = new Padding(3);
            label10.Name = "label10";
            label10.Size = new Size(70, 18);
            label10.TabIndex = 21;
            label10.Text = "Address:";
            // 
            // txtCheckInAddress
            // 
            txtCheckInAddress.Location = new Point(35, 287);
            txtCheckInAddress.Multiline = true;
            txtCheckInAddress.Name = "txtCheckInAddress";
            txtCheckInAddress.Size = new Size(339, 58);
            txtCheckInAddress.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(35, 51);
            label8.Margin = new Padding(3);
            label8.Name = "label8";
            label8.Size = new Size(87, 18);
            label8.TabIndex = 17;
            label8.Text = "First Name:";
            // 
            // txtCheckInPhoneNumber
            // 
            txtCheckInPhoneNumber.Location = new Point(35, 197);
            txtCheckInPhoneNumber.Name = "txtCheckInPhoneNumber";
            txtCheckInPhoneNumber.Size = new Size(207, 23);
            txtCheckInPhoneNumber.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(35, 164);
            label9.Margin = new Padding(3);
            label9.Name = "label9";
            label9.Size = new Size(121, 18);
            label9.TabIndex = 19;
            label9.Text = "Phone Number:";
            // 
            // txtCheckInFirstName
            // 
            txtCheckInFirstName.Location = new Point(35, 84);
            txtCheckInFirstName.Name = "txtCheckInFirstName";
            txtCheckInFirstName.Size = new Size(163, 23);
            txtCheckInFirstName.TabIndex = 18;
            // 
            // txtCheckInLastName
            // 
            txtCheckInLastName.Location = new Point(211, 84);
            txtCheckInLastName.Name = "txtCheckInLastName";
            txtCheckInLastName.Size = new Size(163, 23);
            txtCheckInLastName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(211, 51);
            label3.Margin = new Padding(3);
            label3.Name = "label3";
            label3.Size = new Size(88, 18);
            label3.TabIndex = 4;
            label3.Text = "Last Name:";
            // 
            // btnCheckIn
            // 
            btnCheckIn.BackColor = Color.Silver;
            btnCheckIn.Cursor = Cursors.Hand;
            btnCheckIn.FlatAppearance.BorderSize = 0;
            btnCheckIn.FlatStyle = FlatStyle.Flat;
            btnCheckIn.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            btnCheckIn.ForeColor = Color.Black;
            btnCheckIn.Location = new Point(436, 448);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(136, 27);
            btnCheckIn.TabIndex = 8;
            btnCheckIn.Text = "Check - In";
            btnCheckIn.UseVisualStyleBackColor = false;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // tabPageSearchCheckIn
            // 
            tabPageSearchCheckIn.Controls.Add(groupBox2);
            tabPageSearchCheckIn.Location = new Point(4, 4);
            tabPageSearchCheckIn.Name = "tabPageSearchCheckIn";
            tabPageSearchCheckIn.Padding = new Padding(3);
            tabPageSearchCheckIn.Size = new Size(1088, 504);
            tabPageSearchCheckIn.TabIndex = 1;
            tabPageSearchCheckIn.Text = "Search Check - In";
            tabPageSearchCheckIn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.BackColor = Color.DimGray;
            groupBox2.Controls.Add(txtSearchCheckInID);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dataGVCheckIn);
            groupBox2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1082, 498);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search Check - In";
            // 
            // txtSearchCheckInID
            // 
            txtSearchCheckInID.Location = new Point(339, 23);
            txtSearchCheckInID.Name = "txtSearchCheckInID";
            txtSearchCheckInID.Size = new Size(195, 23);
            txtSearchCheckInID.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(217, 26);
            label4.Name = "label4";
            label4.Size = new Size(95, 16);
            label4.TabIndex = 1;
            label4.Text = "Check - In ID:";
            // 
            // dataGVCheckIn
            // 
            dataGVCheckIn.AllowUserToAddRows = false;
            dataGVCheckIn.AllowUserToDeleteRows = false;
            dataGVCheckIn.BorderStyle = BorderStyle.None;
            dataGVCheckIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVCheckIn.Columns.AddRange(new DataGridViewColumn[] { check_in_id, cus_id, room_type, room_description, price, check_in_date });
            dataGVCheckIn.Location = new Point(6, 60);
            dataGVCheckIn.Name = "dataGVCheckIn";
            dataGVCheckIn.ReadOnly = true;
            dataGVCheckIn.Size = new Size(1064, 432);
            dataGVCheckIn.TabIndex = 0;
            // 
            // check_in_id
            // 
            check_in_id.DataPropertyName = "check_in_id";
            check_in_id.HeaderText = "Check - In ID";
            check_in_id.Name = "check_in_id";
            check_in_id.ReadOnly = true;
            check_in_id.Width = 150;
            // 
            // cus_id
            // 
            cus_id.DataPropertyName = "cus_id";
            cus_id.HeaderText = "Customer ID";
            cus_id.Name = "cus_id";
            cus_id.ReadOnly = true;
            cus_id.Width = 120;
            // 
            // room_type
            // 
            room_type.DataPropertyName = "room_type";
            room_type.HeaderText = "Room Type";
            room_type.Name = "room_type";
            room_type.ReadOnly = true;
            room_type.Width = 200;
            // 
            // room_description
            // 
            room_description.DataPropertyName = "room_description";
            room_description.HeaderText = "Room Description";
            room_description.Name = "room_description";
            room_description.ReadOnly = true;
            room_description.Width = 150;
            // 
            // price
            // 
            price.DataPropertyName = "price";
            price.HeaderText = "Price";
            price.Name = "price";
            price.ReadOnly = true;
            price.Width = 160;
            // 
            // check_in_date
            // 
            check_in_date.DataPropertyName = "check_in_date";
            check_in_date.HeaderText = "Check - In Date";
            check_in_date.Name = "check_in_date";
            check_in_date.ReadOnly = true;
            check_in_date.Width = 200;
            // 
            // tabPageCheckOut
            // 
            tabPageCheckOut.BackColor = Color.DimGray;
            tabPageCheckOut.Controls.Add(groupBox5);
            tabPageCheckOut.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPageCheckOut.Location = new Point(4, 4);
            tabPageCheckOut.Name = "tabPageCheckOut";
            tabPageCheckOut.Padding = new Padding(3);
            tabPageCheckOut.Size = new Size(1088, 504);
            tabPageCheckOut.TabIndex = 2;
            tabPageCheckOut.Text = "Check - Out";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Silver;
            groupBox5.Controls.Add(btnCancel);
            groupBox5.Controls.Add(btnUpdate);
            groupBox5.Controls.Add(cmbCheckOutRoomDescription);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(dptUpdateCheckOut);
            groupBox5.Controls.Add(dtpUpdateCheckIn);
            groupBox5.Controls.Add(cmbUpdatePrice);
            groupBox5.Controls.Add(cmbCheckOutRoomType);
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(label17);
            groupBox5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(27, 24);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1034, 463);
            groupBox5.TabIndex = 29;
            groupBox5.TabStop = false;
            groupBox5.Text = "Update and Cancel Reservation";
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Location = new Point(528, 377);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 33);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Location = new Point(412, 377);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 33);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // cmbCheckOutRoomDescription
            // 
            cmbCheckOutRoomDescription.Anchor = AnchorStyles.None;
            cmbCheckOutRoomDescription.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCheckOutRoomDescription.FlatStyle = FlatStyle.Flat;
            cmbCheckOutRoomDescription.FormattingEnabled = true;
            cmbCheckOutRoomDescription.Location = new Point(276, 143);
            cmbCheckOutRoomDescription.Name = "cmbCheckOutRoomDescription";
            cmbCheckOutRoomDescription.Size = new Size(128, 26);
            cmbCheckOutRoomDescription.TabIndex = 14;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(276, 105);
            label13.Margin = new Padding(3);
            label13.Name = "label13";
            label13.Size = new Size(142, 18);
            label13.TabIndex = 2;
            label13.Text = "Room Description:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(583, 222);
            label14.Margin = new Padding(3);
            label14.Name = "label14";
            label14.Size = new Size(141, 18);
            label14.TabIndex = 13;
            label14.Text = "Check - Out Date:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(597, 105);
            label15.Margin = new Padding(3);
            label15.Name = "label15";
            label15.Size = new Size(49, 18);
            label15.TabIndex = 26;
            label15.Text = "Price:";
            // 
            // dptUpdateCheckOut
            // 
            dptUpdateCheckOut.Location = new Point(518, 255);
            dptUpdateCheckOut.Name = "dptUpdateCheckOut";
            dptUpdateCheckOut.Size = new Size(271, 26);
            dptUpdateCheckOut.TabIndex = 12;
            // 
            // dtpUpdateCheckIn
            // 
            dtpUpdateCheckIn.Location = new Point(217, 258);
            dtpUpdateCheckIn.Name = "dtpUpdateCheckIn";
            dtpUpdateCheckIn.Size = new Size(256, 26);
            dtpUpdateCheckIn.TabIndex = 10;
            // 
            // cmbUpdatePrice
            // 
            cmbUpdatePrice.Anchor = AnchorStyles.None;
            cmbUpdatePrice.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUpdatePrice.FlatStyle = FlatStyle.Flat;
            cmbUpdatePrice.FormattingEnabled = true;
            cmbUpdatePrice.Location = new Point(597, 143);
            cmbUpdatePrice.Name = "cmbUpdatePrice";
            cmbUpdatePrice.Size = new Size(128, 26);
            cmbUpdatePrice.TabIndex = 25;
            // 
            // cmbCheckOutRoomType
            // 
            cmbCheckOutRoomType.Anchor = AnchorStyles.None;
            cmbCheckOutRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCheckOutRoomType.FlatStyle = FlatStyle.Flat;
            cmbCheckOutRoomType.FormattingEnabled = true;
            cmbCheckOutRoomType.Location = new Point(437, 143);
            cmbCheckOutRoomType.Name = "cmbCheckOutRoomType";
            cmbCheckOutRoomType.Size = new Size(128, 26);
            cmbCheckOutRoomType.TabIndex = 9;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(275, 222);
            label16.Margin = new Padding(3);
            label16.Name = "label16";
            label16.Size = new Size(128, 18);
            label16.TabIndex = 6;
            label16.Text = "Check - In Date:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(437, 105);
            label17.Margin = new Padding(3);
            label17.Name = "label17";
            label17.Size = new Size(94, 18);
            label17.TabIndex = 0;
            label17.Text = "Room Type:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(274, 226);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(85, 24);
            comboBox1.TabIndex = 27;
            // 
            // UserControlCheckInAndOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlCheckInAndOut);
            Name = "UserControlCheckInAndOut";
            Size = new Size(1102, 538);
            tabControlCheckInAndOut.ResumeLayout(false);
            tabPageAddCheckIn.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPageSearchCheckIn.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVCheckIn).EndInit();
            tabPageCheckOut.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlCheckInAndOut;
        private TabPage tabPageAddCheckIn;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private ComboBox cmbCheckInRoomDescription;
        private Label label5;
        private Label label12;
        private ComboBox cmbCheckInRoomType;
        private Label label6;
        private GroupBox groupBox1;
        private Label label10;
        private TextBox txtCheckInAddress;
        private Label label8;
        private TextBox txtCheckInPhoneNumber;
        private Label label9;
        private TextBox txtCheckInFirstName;
        private TextBox txtCheckInLastName;
        private Label label3;
        private Button btnCheckIn;
        private TabPage tabPageSearchCheckIn;
        private GroupBox groupBox2;
        private TextBox txtSearchCheckInID;
        private Label label4;
        private DataGridView dataGVCheckIn;
        private TabPage tabPageCheckOut;
        private GroupBox groupBox5;
        private Button btnCancel;
        private Button btnUpdate;
        private ComboBox cmbCheckOutRoomDescription;
        private Label label13;
        private Label label14;
        private Label label15;
        private DateTimePicker dptUpdateCheckOut;
        private DateTimePicker dtpUpdateCheckIn;
        private ComboBox cmbUpdatePrice;
        private ComboBox cmbCheckOutRoomType;
        private Label label16;
        private Label label17;
        private TextBox txtCheckInPrice;
        private DataGridViewTextBoxColumn check_in_id;
        private DataGridViewTextBoxColumn cus_id;
        private DataGridViewTextBoxColumn room_type;
        private DataGridViewTextBoxColumn room_description;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn check_in_date;
        private Label label11;
        private TextBox txtCustomerType;
        private ComboBox comboBox1;
    }
}
