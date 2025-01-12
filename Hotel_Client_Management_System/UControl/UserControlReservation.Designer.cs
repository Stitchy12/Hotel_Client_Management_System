namespace Hotel_Client_Management_System.UControl
{
    partial class UserControlReservation
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
            tabPageUpdateAndCancelReservation = new TabPage();
            groupBox5 = new GroupBox();
            txtUpdatePrice = new TextBox();
            btnCancel = new Button();
            btnReservationUpdate = new Button();
            cmbUpdateRoomType = new ComboBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            dtpUpdateCheckOut = new DateTimePicker();
            dtpUpdateCheckIn = new DateTimePicker();
            cmbUpdateRoomDescription = new ComboBox();
            label16 = new Label();
            label17 = new Label();
            tabPageSearchReservation = new TabPage();
            groupBox2 = new GroupBox();
            txtSearchReservationID = new TextBox();
            label4 = new Label();
            dataGVReservation = new DataGridView();
            reservation_id = new DataGridViewTextBoxColumn();
            room_description = new DataGridViewTextBoxColumn();
            room_type = new DataGridViewTextBoxColumn();
            room_price = new DataGridViewTextBoxColumn();
            partial_payment = new DataGridViewTextBoxColumn();
            check_in_date = new DataGridViewTextBoxColumn();
            check_out_date = new DataGridViewTextBoxColumn();
            tabPageAddReservation = new TabPage();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            txtPartialPayment = new TextBox();
            label7 = new Label();
            txtAddPrice = new TextBox();
            cmbRoomDescription = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            label12 = new Label();
            dtpCheckOutDate = new DateTimePicker();
            dtpCheckInDate = new DateTimePicker();
            cmbRoomType = new ComboBox();
            label2 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            cmbCustomerType = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            txtAddress = new TextBox();
            label8 = new Label();
            txtPhoneNumber = new TextBox();
            label9 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            btnAdd = new Button();
            tabControlReservation = new TabControl();
            tabPageUpdateAndCancelReservation.SuspendLayout();
            groupBox5.SuspendLayout();
            tabPageSearchReservation.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVReservation).BeginInit();
            tabPageAddReservation.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            tabControlReservation.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageUpdateAndCancelReservation
            // 
            tabPageUpdateAndCancelReservation.BackColor = Color.DimGray;
            tabPageUpdateAndCancelReservation.Controls.Add(groupBox5);
            tabPageUpdateAndCancelReservation.Location = new Point(4, 4);
            tabPageUpdateAndCancelReservation.Name = "tabPageUpdateAndCancelReservation";
            tabPageUpdateAndCancelReservation.Padding = new Padding(3);
            tabPageUpdateAndCancelReservation.Size = new Size(1089, 504);
            tabPageUpdateAndCancelReservation.TabIndex = 2;
            tabPageUpdateAndCancelReservation.Text = "Update and Cancel Reservation";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Silver;
            groupBox5.Controls.Add(txtUpdatePrice);
            groupBox5.Controls.Add(btnCancel);
            groupBox5.Controls.Add(btnReservationUpdate);
            groupBox5.Controls.Add(cmbUpdateRoomType);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(dtpUpdateCheckOut);
            groupBox5.Controls.Add(dtpUpdateCheckIn);
            groupBox5.Controls.Add(cmbUpdateRoomDescription);
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(label17);
            groupBox5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(56, 70);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(973, 355);
            groupBox5.TabIndex = 29;
            groupBox5.TabStop = false;
            groupBox5.Text = "Update and Cancel Reservation";
            // 
            // txtUpdatePrice
            // 
            txtUpdatePrice.Location = new Point(558, 113);
            txtUpdatePrice.Name = "txtUpdatePrice";
            txtUpdatePrice.ReadOnly = true;
            txtUpdatePrice.Size = new Size(116, 23);
            txtUpdatePrice.TabIndex = 38;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Location = new Point(494, 290);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 33);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnReservationUpdate
            // 
            btnReservationUpdate.Cursor = Cursors.Hand;
            btnReservationUpdate.Location = new Point(378, 290);
            btnReservationUpdate.Name = "btnReservationUpdate";
            btnReservationUpdate.Size = new Size(75, 33);
            btnReservationUpdate.TabIndex = 27;
            btnReservationUpdate.Text = "Update";
            btnReservationUpdate.UseVisualStyleBackColor = true;
            btnReservationUpdate.Click += btnReservationUpdate_Click;
            // 
            // cmbUpdateRoomType
            // 
            cmbUpdateRoomType.Anchor = AnchorStyles.None;
            cmbUpdateRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUpdateRoomType.FlatStyle = FlatStyle.Flat;
            cmbUpdateRoomType.FormattingEnabled = true;
            cmbUpdateRoomType.Location = new Point(231, 113);
            cmbUpdateRoomType.Name = "cmbUpdateRoomType";
            cmbUpdateRoomType.Size = new Size(128, 24);
            cmbUpdateRoomType.TabIndex = 14;
            cmbUpdateRoomType.SelectedIndexChanged += cmbUpdateRoomType_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(231, 79);
            label13.Margin = new Padding(3);
            label13.Name = "label13";
            label13.Size = new Size(86, 16);
            label13.TabIndex = 2;
            label13.Text = "Room Type.:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(497, 194);
            label14.Margin = new Padding(3);
            label14.Name = "label14";
            label14.Size = new Size(123, 16);
            label14.TabIndex = 13;
            label14.Text = "Check - Out Date:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(558, 79);
            label15.Margin = new Padding(3);
            label15.Name = "label15";
            label15.Size = new Size(43, 16);
            label15.TabIndex = 26;
            label15.Text = "Price:";
            // 
            // dtpUpdateCheckOut
            // 
            dtpUpdateCheckOut.Location = new Point(497, 227);
            dtpUpdateCheckOut.Name = "dtpUpdateCheckOut";
            dtpUpdateCheckOut.Size = new Size(257, 23);
            dtpUpdateCheckOut.TabIndex = 12;
            // 
            // dtpUpdateCheckIn
            // 
            dtpUpdateCheckIn.Location = new Point(196, 227);
            dtpUpdateCheckIn.Name = "dtpUpdateCheckIn";
            dtpUpdateCheckIn.Size = new Size(257, 23);
            dtpUpdateCheckIn.TabIndex = 10;
            // 
            // cmbUpdateRoomDescription
            // 
            cmbUpdateRoomDescription.Anchor = AnchorStyles.None;
            cmbUpdateRoomDescription.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUpdateRoomDescription.FlatStyle = FlatStyle.Flat;
            cmbUpdateRoomDescription.FormattingEnabled = true;
            cmbUpdateRoomDescription.Location = new Point(392, 113);
            cmbUpdateRoomDescription.Name = "cmbUpdateRoomDescription";
            cmbUpdateRoomDescription.Size = new Size(142, 24);
            cmbUpdateRoomDescription.TabIndex = 9;
            cmbUpdateRoomDescription.SelectedIndexChanged += cmbUpdateRoomDescription_SelectedIndexChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(268, 191);
            label16.Margin = new Padding(3);
            label16.Name = "label16";
            label16.Size = new Size(112, 16);
            label16.TabIndex = 6;
            label16.Text = "Check - In Date:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(392, 79);
            label17.Margin = new Padding(3);
            label17.Name = "label17";
            label17.Size = new Size(124, 16);
            label17.TabIndex = 0;
            label17.Text = "Room Description:";
            // 
            // tabPageSearchReservation
            // 
            tabPageSearchReservation.Controls.Add(groupBox2);
            tabPageSearchReservation.Location = new Point(4, 4);
            tabPageSearchReservation.Name = "tabPageSearchReservation";
            tabPageSearchReservation.Padding = new Padding(3);
            tabPageSearchReservation.Size = new Size(1089, 504);
            tabPageSearchReservation.TabIndex = 1;
            tabPageSearchReservation.Text = "Search Reservation";
            tabPageSearchReservation.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.BackColor = Color.DimGray;
            groupBox2.Controls.Add(txtSearchReservationID);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dataGVReservation);
            groupBox2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(6, -2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1077, 482);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search Reservation";
            // 
            // txtSearchReservationID
            // 
            txtSearchReservationID.Location = new Point(339, 23);
            txtSearchReservationID.Name = "txtSearchReservationID";
            txtSearchReservationID.Size = new Size(195, 23);
            txtSearchReservationID.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(217, 26);
            label4.Name = "label4";
            label4.Size = new Size(103, 16);
            label4.TabIndex = 1;
            label4.Text = "Reservation ID:";
            // 
            // dataGVReservation
            // 
            dataGVReservation.AllowUserToAddRows = false;
            dataGVReservation.AllowUserToDeleteRows = false;
            dataGVReservation.BorderStyle = BorderStyle.None;
            dataGVReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVReservation.Columns.AddRange(new DataGridViewColumn[] { reservation_id, room_description, room_type, room_price, partial_payment, check_in_date, check_out_date });
            dataGVReservation.Location = new Point(6, 60);
            dataGVReservation.Name = "dataGVReservation";
            dataGVReservation.ReadOnly = true;
            dataGVReservation.Size = new Size(1061, 416);
            dataGVReservation.TabIndex = 0;
            dataGVReservation.CellClick += dataGVReservation_CellClick_1;
            // 
            // reservation_id
            // 
            reservation_id.DataPropertyName = "reservation_id";
            reservation_id.HeaderText = "Reservation ID";
            reservation_id.Name = "reservation_id";
            reservation_id.ReadOnly = true;
            reservation_id.Width = 130;
            // 
            // room_description
            // 
            room_description.DataPropertyName = "room_description";
            room_description.HeaderText = "Room Description";
            room_description.Name = "room_description";
            room_description.ReadOnly = true;
            room_description.Width = 150;
            // 
            // room_type
            // 
            room_type.DataPropertyName = "room_type";
            room_type.HeaderText = "Room Type";
            room_type.Name = "room_type";
            room_type.ReadOnly = true;
            room_type.Width = 120;
            // 
            // room_price
            // 
            room_price.DataPropertyName = "Room_price";
            room_price.HeaderText = "Price";
            room_price.Name = "room_price";
            room_price.ReadOnly = true;
            // 
            // partial_payment
            // 
            partial_payment.DataPropertyName = "partial_payment";
            partial_payment.HeaderText = "Payment";
            partial_payment.Name = "partial_payment";
            partial_payment.ReadOnly = true;
            // 
            // check_in_date
            // 
            check_in_date.DataPropertyName = "check_in_date";
            check_in_date.HeaderText = "Check - In Date";
            check_in_date.Name = "check_in_date";
            check_in_date.ReadOnly = true;
            check_in_date.Width = 200;
            // 
            // check_out_date
            // 
            check_out_date.DataPropertyName = "check_out_date";
            check_out_date.HeaderText = "Check - Out Date";
            check_out_date.Name = "check_out_date";
            check_out_date.ReadOnly = true;
            check_out_date.Width = 200;
            // 
            // tabPageAddReservation
            // 
            tabPageAddReservation.Controls.Add(groupBox3);
            tabPageAddReservation.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageAddReservation.Location = new Point(4, 4);
            tabPageAddReservation.Name = "tabPageAddReservation";
            tabPageAddReservation.Padding = new Padding(3);
            tabPageAddReservation.Size = new Size(1089, 504);
            tabPageAddReservation.TabIndex = 0;
            tabPageAddReservation.Text = "Add Reservation";
            tabPageAddReservation.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.BackColor = Color.DimGray;
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(groupBox1);
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(6, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1076, 492);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Add Reservation";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Silver;
            groupBox4.Controls.Add(txtPartialPayment);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(txtAddPrice);
            groupBox4.Controls.Add(cmbRoomDescription);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(dtpCheckOutDate);
            groupBox4.Controls.Add(dtpCheckInDate);
            groupBox4.Controls.Add(cmbRoomType);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label6);
            groupBox4.Location = new Point(506, 84);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(515, 326);
            groupBox4.TabIndex = 28;
            groupBox4.TabStop = false;
            groupBox4.Text = "Room, Price And Check In/Check Out";
            // 
            // txtPartialPayment
            // 
            txtPartialPayment.Location = new Point(326, 139);
            txtPartialPayment.Name = "txtPartialPayment";
            txtPartialPayment.Size = new Size(116, 23);
            txtPartialPayment.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(326, 110);
            label7.Margin = new Padding(3);
            label7.Name = "label7";
            label7.Size = new Size(113, 16);
            label7.TabIndex = 38;
            label7.Text = "Partial Payment:";
            // 
            // txtAddPrice
            // 
            txtAddPrice.Location = new Point(326, 63);
            txtAddPrice.Name = "txtAddPrice";
            txtAddPrice.ReadOnly = true;
            txtAddPrice.Size = new Size(116, 23);
            txtAddPrice.TabIndex = 37;
            // 
            // cmbRoomDescription
            // 
            cmbRoomDescription.Anchor = AnchorStyles.None;
            cmbRoomDescription.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoomDescription.FlatStyle = FlatStyle.Flat;
            cmbRoomDescription.FormattingEnabled = true;
            cmbRoomDescription.Location = new Point(54, 139);
            cmbRoomDescription.Name = "cmbRoomDescription";
            cmbRoomDescription.Size = new Size(142, 24);
            cmbRoomDescription.TabIndex = 14;
            cmbRoomDescription.SelectedIndexChanged += cmbRoomDescription_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(54, 115);
            label5.Margin = new Padding(3);
            label5.Name = "label5";
            label5.Size = new Size(124, 16);
            label5.TabIndex = 2;
            label5.Text = "Room Description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(131, 247);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(123, 16);
            label1.TabIndex = 13;
            label1.Text = "Check - Out Date:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(326, 39);
            label12.Margin = new Padding(3);
            label12.Name = "label12";
            label12.Size = new Size(43, 16);
            label12.TabIndex = 26;
            label12.Text = "Price:";
            // 
            // dtpCheckOutDate
            // 
            dtpCheckOutDate.Location = new Point(131, 271);
            dtpCheckOutDate.Name = "dtpCheckOutDate";
            dtpCheckOutDate.Size = new Size(274, 23);
            dtpCheckOutDate.TabIndex = 12;
            // 
            // dtpCheckInDate
            // 
            dtpCheckInDate.Location = new Point(131, 206);
            dtpCheckInDate.Name = "dtpCheckInDate";
            dtpCheckInDate.Size = new Size(274, 23);
            dtpCheckInDate.TabIndex = 10;
            // 
            // cmbRoomType
            // 
            cmbRoomType.Anchor = AnchorStyles.None;
            cmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoomType.FlatStyle = FlatStyle.Flat;
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(54, 63);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(142, 24);
            cmbRoomType.TabIndex = 9;
            cmbRoomType.SelectedIndexChanged += cmbRoomType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(131, 185);
            label2.Margin = new Padding(3);
            label2.Name = "label2";
            label2.Size = new Size(112, 16);
            label2.TabIndex = 6;
            label2.Text = "Check - In Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(54, 39);
            label6.Margin = new Padding(3);
            label6.Name = "label6";
            label6.Size = new Size(82, 16);
            label6.TabIndex = 0;
            label6.Text = "Room Type:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Silver;
            groupBox1.Controls.Add(cmbCustomerType);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtPhoneNumber);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(71, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 326);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information";
            // 
            // cmbCustomerType
            // 
            cmbCustomerType.Anchor = AnchorStyles.None;
            cmbCustomerType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomerType.FlatStyle = FlatStyle.Flat;
            cmbCustomerType.FormattingEnabled = true;
            cmbCustomerType.Location = new Point(277, 172);
            cmbCustomerType.Name = "cmbCustomerType";
            cmbCustomerType.Size = new Size(85, 24);
            cmbCustomerType.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(267, 150);
            label11.Margin = new Padding(3);
            label11.Name = "label11";
            label11.Size = new Size(107, 16);
            label11.TabIndex = 24;
            label11.Text = "Customer Type:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(35, 205);
            label10.Margin = new Padding(3);
            label10.Name = "label10";
            label10.Size = new Size(64, 16);
            label10.TabIndex = 21;
            label10.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(35, 229);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(339, 48);
            txtAddress.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(35, 67);
            label8.Margin = new Padding(3);
            label8.Name = "label8";
            label8.Size = new Size(79, 16);
            label8.TabIndex = 17;
            label8.Text = "First Name:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(35, 172);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(207, 23);
            txtPhoneNumber.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(35, 139);
            label9.Margin = new Padding(3);
            label9.Name = "label9";
            label9.Size = new Size(106, 16);
            label9.TabIndex = 19;
            label9.Text = "Phone Number:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(35, 100);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(163, 23);
            txtFirstName.TabIndex = 18;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(211, 100);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(163, 23);
            txtLastName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(211, 67);
            label3.Margin = new Padding(3);
            label3.Name = "label3";
            label3.Size = new Size(79, 16);
            label3.TabIndex = 4;
            label3.Text = "Last Name:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Silver;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(473, 438);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 27);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add Reservation";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // tabControlReservation
            // 
            tabControlReservation.Alignment = TabAlignment.Bottom;
            tabControlReservation.Controls.Add(tabPageAddReservation);
            tabControlReservation.Controls.Add(tabPageSearchReservation);
            tabControlReservation.Controls.Add(tabPageUpdateAndCancelReservation);
            tabControlReservation.Location = new Point(3, 0);
            tabControlReservation.Name = "tabControlReservation";
            tabControlReservation.SelectedIndex = 0;
            tabControlReservation.Size = new Size(1097, 535);
            tabControlReservation.TabIndex = 0;
            // 
            // UserControlReservation
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlReservation);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "UserControlReservation";
            Size = new Size(1116, 538);
            tabPageUpdateAndCancelReservation.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            tabPageSearchReservation.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVReservation).EndInit();
            tabPageAddReservation.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControlReservation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPageUpdateAndCancelReservation;
        private GroupBox groupBox5;
        private TextBox txtUpdatePrice;
        private Button btnCancel;
        private Button btnReservationUpdate;
        private ComboBox cmbUpdateRoomType;
        private Label label13;
        private Label label14;
        private Label label15;
        private DateTimePicker dtpUpdateCheckOut;
        private DateTimePicker dtpUpdateCheckIn;
        private ComboBox cmbUpdateRoomDescription;
        private Label label16;
        private Label label17;
        private TabPage tabPageSearchReservation;
        private GroupBox groupBox2;
        private TextBox txtSearchReservationID;
        private Label label4;
        private DataGridView dataGVReservation;
        private TabPage tabPageAddReservation;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox txtPartialPayment;
        private Label label7;
        private TextBox txtAddPrice;
        private ComboBox cmbRoomDescription;
        private Label label5;
        private Label label1;
        private Label label12;
        private DateTimePicker dtpCheckOutDate;
        private DateTimePicker dtpCheckInDate;
        private ComboBox cmbRoomType;
        private Label label2;
        private Label label6;
        private GroupBox groupBox1;
        private Label label11;
        private Label label10;
        private TextBox txtAddress;
        private Label label8;
        private TextBox txtPhoneNumber;
        private Label label9;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label3;
        private Button btnAdd;
        private TabControl tabControlReservation;
        private DataGridViewTextBoxColumn reservation_id;
        private DataGridViewTextBoxColumn room_description;
        private DataGridViewTextBoxColumn room_type;
        private DataGridViewTextBoxColumn room_price;
        private DataGridViewTextBoxColumn partial_payment;
        private DataGridViewTextBoxColumn check_in_date;
        private DataGridViewTextBoxColumn check_out_date;
        private ComboBox cmbCustomerType;
    }
}
