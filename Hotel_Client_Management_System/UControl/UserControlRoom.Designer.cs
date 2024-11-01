namespace Hotel_Client_Management_System.UControl
{
    partial class UserControlRoom
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
            tabControlRooms = new TabControl();
            tabPageAvailableRooms = new TabPage();
            groupBox2 = new GroupBox();
            txtSearchtRoomID = new TextBox();
            label1 = new Label();
            dataGVRooms = new DataGridView();
            room_id = new DataGridViewTextBoxColumn();
            room_description = new DataGridViewTextBoxColumn();
            room_type = new DataGridViewTextBoxColumn();
            room_price = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            tabPageAddRoom = new TabPage();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            txtRoomDescription = new TextBox();
            txtAddRoomPrice = new TextBox();
            btnAddRoom = new Button();
            cmbAddRoomType = new ComboBox();
            label13 = new Label();
            label15 = new Label();
            label17 = new Label();
            tabControlRooms.SuspendLayout();
            tabPageAvailableRooms.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVRooms).BeginInit();
            tabPageAddRoom.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRooms
            // 
            tabControlRooms.Alignment = TabAlignment.Bottom;
            tabControlRooms.Anchor = AnchorStyles.None;
            tabControlRooms.Controls.Add(tabPageAvailableRooms);
            tabControlRooms.Controls.Add(tabPageAddRoom);
            tabControlRooms.Location = new Point(3, 3);
            tabControlRooms.Name = "tabControlRooms";
            tabControlRooms.SelectedIndex = 0;
            tabControlRooms.Size = new Size(1096, 535);
            tabControlRooms.TabIndex = 0;
            // 
            // tabPageAvailableRooms
            // 
            tabPageAvailableRooms.Controls.Add(groupBox2);
            tabPageAvailableRooms.Location = new Point(4, 4);
            tabPageAvailableRooms.Name = "tabPageAvailableRooms";
            tabPageAvailableRooms.Padding = new Padding(3);
            tabPageAvailableRooms.Size = new Size(1088, 504);
            tabPageAvailableRooms.TabIndex = 0;
            tabPageAvailableRooms.Text = "Available Room";
            tabPageAvailableRooms.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.BackColor = Color.DimGray;
            groupBox2.Controls.Add(txtSearchtRoomID);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dataGVRooms);
            groupBox2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1076, 492);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rooms Available";
            // 
            // txtSearchtRoomID
            // 
            txtSearchtRoomID.Location = new Point(312, 25);
            txtSearchtRoomID.Name = "txtSearchtRoomID";
            txtSearchtRoomID.Size = new Size(195, 26);
            txtSearchtRoomID.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(232, 31);
            label1.Name = "label1";
            label1.Size = new Size(74, 18);
            label1.TabIndex = 1;
            label1.Text = "Room ID:";
            // 
            // dataGVRooms
            // 
            dataGVRooms.AllowUserToAddRows = false;
            dataGVRooms.AllowUserToDeleteRows = false;
            dataGVRooms.BorderStyle = BorderStyle.None;
            dataGVRooms.CausesValidation = false;
            dataGVRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVRooms.Columns.AddRange(new DataGridViewColumn[] { room_id, room_description, room_type, room_price, status });
            dataGVRooms.Location = new Point(15, 71);
            dataGVRooms.Name = "dataGVRooms";
            dataGVRooms.ReadOnly = true;
            dataGVRooms.Size = new Size(1045, 402);
            dataGVRooms.TabIndex = 0;
            dataGVRooms.CellClick += dataGVRooms_CellClick;
            // 
            // room_id
            // 
            room_id.DataPropertyName = "room_id";
            room_id.HeaderText = "Room ID";
            room_id.Name = "room_id";
            room_id.ReadOnly = true;
            // 
            // room_description
            // 
            room_description.DataPropertyName = "room_description";
            room_description.HeaderText = "Room Description";
            room_description.Name = "room_description";
            room_description.ReadOnly = true;
            room_description.Width = 200;
            // 
            // room_type
            // 
            room_type.DataPropertyName = "room_type";
            room_type.HeaderText = "Room Type";
            room_type.Name = "room_type";
            room_type.ReadOnly = true;
            room_type.Width = 250;
            // 
            // room_price
            // 
            room_price.DataPropertyName = "room_price";
            room_price.HeaderText = "Room Price";
            room_price.Name = "room_price";
            room_price.ReadOnly = true;
            room_price.Width = 200;
            // 
            // status
            // 
            status.DataPropertyName = "status";
            status.HeaderText = "Status";
            status.Name = "status";
            status.ReadOnly = true;
            status.Width = 200;
            // 
            // tabPageAddRoom
            // 
            tabPageAddRoom.BackColor = Color.Transparent;
            tabPageAddRoom.Controls.Add(groupBox1);
            tabPageAddRoom.Location = new Point(4, 4);
            tabPageAddRoom.Name = "tabPageAddRoom";
            tabPageAddRoom.Padding = new Padding(3);
            tabPageAddRoom.Size = new Size(1088, 507);
            tabPageAddRoom.TabIndex = 1;
            tabPageAddRoom.Text = "Add Rooms";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DimGray;
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(6, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1076, 495);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Rooms";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Silver;
            groupBox3.Controls.Add(txtRoomDescription);
            groupBox3.Controls.Add(txtAddRoomPrice);
            groupBox3.Controls.Add(btnAddRoom);
            groupBox3.Controls.Add(cmbAddRoomType);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label17);
            groupBox3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(49, 44);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(980, 426);
            groupBox3.TabIndex = 35;
            groupBox3.TabStop = false;
            groupBox3.Text = "Room";
            // 
            // txtRoomDescription
            // 
            txtRoomDescription.Location = new Point(537, 135);
            txtRoomDescription.Name = "txtRoomDescription";
            txtRoomDescription.Size = new Size(116, 26);
            txtRoomDescription.TabIndex = 39;
            // 
            // txtAddRoomPrice
            // 
            txtAddRoomPrice.Location = new Point(457, 230);
            txtAddRoomPrice.Name = "txtAddRoomPrice";
            txtAddRoomPrice.Size = new Size(116, 26);
            txtAddRoomPrice.TabIndex = 38;
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.DimGray;
            btnAddRoom.Cursor = Cursors.Hand;
            btnAddRoom.FlatAppearance.BorderSize = 0;
            btnAddRoom.FlatStyle = FlatStyle.System;
            btnAddRoom.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            btnAddRoom.ForeColor = Color.White;
            btnAddRoom.Location = new Point(457, 323);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(116, 40);
            btnAddRoom.TabIndex = 8;
            btnAddRoom.Text = "Add Room";
            btnAddRoom.UseVisualStyleBackColor = false;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // cmbAddRoomType
            // 
            cmbAddRoomType.Anchor = AnchorStyles.None;
            cmbAddRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAddRoomType.FlatStyle = FlatStyle.Flat;
            cmbAddRoomType.FormattingEnabled = true;
            cmbAddRoomType.Items.AddRange(new object[] { "Fan", "Aircondition" });
            cmbAddRoomType.Location = new Point(332, 135);
            cmbAddRoomType.Name = "cmbAddRoomType";
            cmbAddRoomType.Size = new Size(128, 26);
            cmbAddRoomType.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(537, 102);
            label13.Margin = new Padding(3);
            label13.Name = "label13";
            label13.Size = new Size(138, 18);
            label13.TabIndex = 28;
            label13.Text = "Room Description";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(457, 206);
            label15.Margin = new Padding(3);
            label15.Name = "label15";
            label15.Size = new Size(49, 18);
            label15.TabIndex = 32;
            label15.Text = "Price:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(332, 102);
            label17.Margin = new Padding(3);
            label17.Name = "label17";
            label17.Size = new Size(94, 18);
            label17.TabIndex = 27;
            label17.Text = "Room Type:";
            // 
            // UserControlRoom
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlRooms);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "UserControlRoom";
            Size = new Size(1102, 538);
            tabControlRooms.ResumeLayout(false);
            tabPageAvailableRooms.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVRooms).EndInit();
            tabPageAddRoom.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlRooms;
        private TabPage tabPageAvailableRooms;
        private TabPage tabPageAddRoom;
        private GroupBox groupBox2;
        private TextBox txtSearchtRoomID;
        private Label label1;
        private DataGridView dataGVRooms;
        private GroupBox groupBox1;
        private Button btnAddRoom;
        private GroupBox groupBox3;
        private ComboBox cmbAddRoomType;
        private Label label13;
        private Label label15;
        private Label label17;
        private DataGridViewTextBoxColumn room_id;
        private DataGridViewTextBoxColumn room_description;
        private DataGridViewTextBoxColumn room_type;
        private DataGridViewTextBoxColumn room_price;
        private DataGridViewTextBoxColumn status;
        private TextBox txtAddRoomPrice;
        private TextBox txtRoomDescription;
    }
}
