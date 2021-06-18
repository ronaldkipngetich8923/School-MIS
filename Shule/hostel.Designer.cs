namespace Shule
{
    partial class hostel
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
            this.hostelpanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxAssignRoom = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxAvailableRooms = new System.Windows.Forms.TextBox();
            this.dateTimePickerClearence = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAssined = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStudname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxAdmNo = new System.Windows.Forms.TextBox();
            this.comboBoxhostelvailable = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxhostelcode = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.hostelpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hostelpanel
            // 
            this.hostelpanel.Controls.Add(this.button4);
            this.hostelpanel.Controls.Add(this.button3);
            this.hostelpanel.Controls.Add(this.textBox1);
            this.hostelpanel.Controls.Add(this.dataGridView1);
            this.hostelpanel.Controls.Add(this.panel1);
            this.hostelpanel.Controls.Add(this.button8);
            this.hostelpanel.Controls.Add(this.button6);
            this.hostelpanel.Controls.Add(this.button5);
            this.hostelpanel.Controls.Add(this.groupBox1);
            this.hostelpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostelpanel.Location = new System.Drawing.Point(0, 0);
            this.hostelpanel.Name = "hostelpanel";
            this.hostelpanel.Size = new System.Drawing.Size(1186, 516);
            this.hostelpanel.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(619, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(555, 264);
            this.dataGridView1.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 70);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(370, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nairobi School Hostel";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(362, 446);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(116, 29);
            this.button8.TabIndex = 16;
            this.button8.Text = "Unoccupied Hostels";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(824, 446);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 29);
            this.button6.TabIndex = 14;
            this.button6.Text = "View Hostels ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(619, 446);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 29);
            this.button5.TabIndex = 13;
            this.button5.Text = "Clearance";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxhostelcode);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBoxAssignRoom);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBoxAvailableRooms);
            this.groupBox1.Controls.Add(this.dateTimePickerClearence);
            this.groupBox1.Controls.Add(this.dateTimePickerAssined);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxStudname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxAdmNo);
            this.groupBox1.Controls.Add(this.comboBoxhostelvailable);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 277);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assign Hostel To Student";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBoxAssignRoom
            // 
            this.comboBoxAssignRoom.FormattingEnabled = true;
            this.comboBoxAssignRoom.Location = new System.Drawing.Point(404, 83);
            this.comboBoxAssignRoom.Name = "comboBoxAssignRoom";
            this.comboBoxAssignRoom.Size = new System.Drawing.Size(131, 25);
            this.comboBoxAssignRoom.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(292, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 17);
            this.label13.TabIndex = 19;
            this.label13.Text = "Assign Room";
            // 
            // textBoxAvailableRooms
            // 
            this.textBoxAvailableRooms.Location = new System.Drawing.Point(409, 29);
            this.textBoxAvailableRooms.Name = "textBoxAvailableRooms";
            this.textBoxAvailableRooms.Size = new System.Drawing.Size(102, 25);
            this.textBoxAvailableRooms.TabIndex = 17;
            // 
            // dateTimePickerClearence
            // 
            this.dateTimePickerClearence.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerClearence.Location = new System.Drawing.Point(384, 181);
            this.dateTimePickerClearence.MinDate = new System.DateTime(2021, 6, 15, 0, 0, 0, 0);
            this.dateTimePickerClearence.Name = "dateTimePickerClearence";
            this.dateTimePickerClearence.Size = new System.Drawing.Size(187, 22);
            this.dateTimePickerClearence.TabIndex = 16;
            // 
            // dateTimePickerAssined
            // 
            this.dateTimePickerAssined.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAssined.Location = new System.Drawing.Point(384, 143);
            this.dateTimePickerAssined.MinDate = new System.DateTime(2021, 6, 15, 0, 0, 0, 0);
            this.dateTimePickerAssined.Name = "dateTimePickerAssined";
            this.dateTimePickerAssined.Size = new System.Drawing.Size(187, 22);
            this.dateTimePickerAssined.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "From Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "To Date";
            // 
            // textBoxStudname
            // 
            this.textBoxStudname.Location = new System.Drawing.Point(167, 83);
            this.textBoxStudname.Name = "textBoxStudname";
            this.textBoxStudname.Size = new System.Drawing.Size(102, 25);
            this.textBoxStudname.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Student Name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAdmNo
            // 
            this.textBoxAdmNo.Location = new System.Drawing.Point(167, 34);
            this.textBoxAdmNo.Name = "textBoxAdmNo";
            this.textBoxAdmNo.Size = new System.Drawing.Size(102, 25);
            this.textBoxAdmNo.TabIndex = 8;
            // 
            // comboBoxhostelvailable
            // 
            this.comboBoxhostelvailable.FormattingEnabled = true;
            this.comboBoxhostelvailable.Location = new System.Drawing.Point(167, 123);
            this.comboBoxhostelvailable.Name = "comboBoxhostelvailable";
            this.comboBoxhostelvailable.Size = new System.Drawing.Size(102, 25);
            this.comboBoxhostelvailable.TabIndex = 7;
            this.comboBoxhostelvailable.SelectedIndexChanged += new System.EventHandler(this.comboBoxhostelvailable_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Admission No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Available Rooms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Available Hostel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Hostel Code";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxhostelcode
            // 
            this.textBoxhostelcode.Location = new System.Drawing.Point(167, 158);
            this.textBoxhostelcode.Name = "textBoxhostelcode";
            this.textBoxhostelcode.Size = new System.Drawing.Size(102, 25);
            this.textBoxhostelcode.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(341, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 20);
            this.textBox1.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(484, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 30);
            this.button3.TabIndex = 25;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(138, 446);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 30);
            this.button4.TabIndex = 26;
            this.button4.Text = "New Hostel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // hostel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 516);
            this.Controls.Add(this.hostelpanel);
            this.Name = "hostel";
            this.Text = "hostelclearence";
            this.hostelpanel.ResumeLayout(false);
            this.hostelpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel hostelpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxAssignRoom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxAvailableRooms;
        private System.Windows.Forms.DateTimePicker dateTimePickerClearence;
        private System.Windows.Forms.DateTimePicker dateTimePickerAssined;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStudname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxAdmNo;
        private System.Windows.Forms.ComboBox comboBoxhostelvailable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxhostelcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
    }
}