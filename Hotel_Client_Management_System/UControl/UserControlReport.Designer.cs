namespace Hotel_Client_Management_System.UControl
{
    partial class UserControlReport
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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DimGray;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.BlanchedAlmond;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1096, 538);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Report";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1043, 431);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(35, 497);
            button1.Name = "button1";
            button1.Size = new Size(74, 34);
            button1.TabIndex = 1;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UserControlReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "UserControlReport";
            Size = new Size(1102, 544);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button button1;
    }
}
