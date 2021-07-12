namespace Shule
{
    partial class tab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.rooms = new System.Windows.Forms.Label();
            this.comboHostelCode = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtComboStudname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboHosteAdmNo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2DateTimePicker1Hostel = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.UpdateHostel = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHostelCapacity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button1ViewHostels = new Guna.UI2.WinForms.Guna2Button();
            this.btnHostelSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnHostelReset = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1HostelsAssign = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtHostelName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1HostelsAssign)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Panel1.Controls.Add(this.label9);
            this.guna2Panel1.Controls.Add(this.rooms);
            this.guna2Panel1.Controls.Add(this.comboHostelCode);
            this.guna2Panel1.Controls.Add(this.groupBox1);
            this.guna2Panel1.Controls.Add(this.UpdateHostel);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.txtHostelCapacity);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.guna2Button1ViewHostels);
            this.guna2Panel1.Controls.Add(this.btnHostelSave);
            this.guna2Panel1.Controls.Add(this.btnHostelReset);
            this.guna2Panel1.Controls.Add(this.guna2DataGridView1HostelsAssign);
            this.guna2Panel1.Controls.Add(this.txtHostelName);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1203, 563);
            this.guna2Panel1.TabIndex = 4;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(464, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Rooms Available";
            // 
            // rooms
            // 
            this.rooms.AutoSize = true;
            this.rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms.ForeColor = System.Drawing.Color.Red;
            this.rooms.Location = new System.Drawing.Point(427, 223);
            this.rooms.Name = "rooms";
            this.rooms.Size = new System.Drawing.Size(13, 18);
            this.rooms.TabIndex = 27;
            this.rooms.Text = " ";
            // 
            // comboHostelCode
            // 
            this.comboHostelCode.BackColor = System.Drawing.Color.Transparent;
            this.comboHostelCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboHostelCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHostelCode.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboHostelCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboHostelCode.FocusedState.Parent = this.comboHostelCode;
            this.comboHostelCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboHostelCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboHostelCode.HoverState.Parent = this.comboHostelCode;
            this.comboHostelCode.ItemHeight = 30;
            this.comboHostelCode.ItemsAppearance.Parent = this.comboHostelCode;
            this.comboHostelCode.Location = new System.Drawing.Point(209, 98);
            this.comboHostelCode.Name = "comboHostelCode";
            this.comboHostelCode.ShadowDecoration.Parent = this.comboHostelCode;
            this.comboHostelCode.Size = new System.Drawing.Size(212, 36);
            this.comboHostelCode.TabIndex = 26;
            this.comboHostelCode.SelectedIndexChanged += new System.EventHandler(this.comboHostelCode_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtComboStudname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboHosteAdmNo);
            this.groupBox1.Controls.Add(this.guna2DateTimePicker1Hostel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(22, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 238);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assign Hostel ";
            // 
            // txtComboStudname
            // 
            this.txtComboStudname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComboStudname.DefaultText = "";
            this.txtComboStudname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtComboStudname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtComboStudname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComboStudname.DisabledState.Parent = this.txtComboStudname;
            this.txtComboStudname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComboStudname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComboStudname.FocusedState.Parent = this.txtComboStudname;
            this.txtComboStudname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtComboStudname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComboStudname.HoverState.Parent = this.txtComboStudname;
            this.txtComboStudname.Location = new System.Drawing.Point(197, 85);
            this.txtComboStudname.Name = "txtComboStudname";
            this.txtComboStudname.PasswordChar = '\0';
            this.txtComboStudname.PlaceholderText = "Student Name";
            this.txtComboStudname.SelectedText = "";
            this.txtComboStudname.ShadowDecoration.Parent = this.txtComboStudname;
            this.txtComboStudname.Size = new System.Drawing.Size(212, 36);
            this.txtComboStudname.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Student Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "AdmNo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Date Assigned";
            // 
            // comboHosteAdmNo
            // 
            this.comboHosteAdmNo.BackColor = System.Drawing.Color.Transparent;
            this.comboHosteAdmNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboHosteAdmNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHosteAdmNo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboHosteAdmNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboHosteAdmNo.FocusedState.Parent = this.comboHosteAdmNo;
            this.comboHosteAdmNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboHosteAdmNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboHosteAdmNo.HoverState.Parent = this.comboHosteAdmNo;
            this.comboHosteAdmNo.ItemHeight = 30;
            this.comboHosteAdmNo.ItemsAppearance.Parent = this.comboHosteAdmNo;
            this.comboHosteAdmNo.Location = new System.Drawing.Point(197, 24);
            this.comboHosteAdmNo.Name = "comboHosteAdmNo";
            this.comboHosteAdmNo.ShadowDecoration.Parent = this.comboHosteAdmNo;
            this.comboHosteAdmNo.Size = new System.Drawing.Size(212, 36);
            this.comboHosteAdmNo.TabIndex = 22;
            this.comboHosteAdmNo.SelectedIndexChanged += new System.EventHandler(this.comboHosteAdmNo_SelectedIndexChanged);
            // 
            // guna2DateTimePicker1Hostel
            // 
            this.guna2DateTimePicker1Hostel.CheckedState.Parent = this.guna2DateTimePicker1Hostel;
            this.guna2DateTimePicker1Hostel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1Hostel.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1Hostel.HoverState.Parent = this.guna2DateTimePicker1Hostel;
            this.guna2DateTimePicker1Hostel.Location = new System.Drawing.Point(197, 144);
            this.guna2DateTimePicker1Hostel.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1Hostel.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1Hostel.Name = "guna2DateTimePicker1Hostel";
            this.guna2DateTimePicker1Hostel.ShadowDecoration.Parent = this.guna2DateTimePicker1Hostel;
            this.guna2DateTimePicker1Hostel.Size = new System.Drawing.Size(212, 36);
            this.guna2DateTimePicker1Hostel.TabIndex = 20;
            this.guna2DateTimePicker1Hostel.Value = new System.DateTime(2021, 7, 6, 14, 32, 27, 366);
            // 
            // UpdateHostel
            // 
            this.UpdateHostel.CheckedState.Parent = this.UpdateHostel;
            this.UpdateHostel.CustomImages.Parent = this.UpdateHostel;
            this.UpdateHostel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateHostel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateHostel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateHostel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateHostel.DisabledState.Parent = this.UpdateHostel;
            this.UpdateHostel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UpdateHostel.ForeColor = System.Drawing.Color.White;
            this.UpdateHostel.HoverState.Parent = this.UpdateHostel;
            this.UpdateHostel.Location = new System.Drawing.Point(833, 500);
            this.UpdateHostel.Name = "UpdateHostel";
            this.UpdateHostel.ShadowDecoration.Parent = this.UpdateHostel;
            this.UpdateHostel.Size = new System.Drawing.Size(180, 45);
            this.UpdateHostel.TabIndex = 24;
            this.UpdateHostel.Text = "Update Hostel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(706, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(315, 31);
            this.label8.TabIndex = 21;
            this.label8.Text = "Occupancy Information";
            // 
            // txtHostelCapacity
            // 
            this.txtHostelCapacity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHostelCapacity.DefaultText = "";
            this.txtHostelCapacity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHostelCapacity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHostelCapacity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHostelCapacity.DisabledState.Parent = this.txtHostelCapacity;
            this.txtHostelCapacity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHostelCapacity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHostelCapacity.FocusedState.Parent = this.txtHostelCapacity;
            this.txtHostelCapacity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHostelCapacity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHostelCapacity.HoverState.Parent = this.txtHostelCapacity;
            this.txtHostelCapacity.Location = new System.Drawing.Point(209, 214);
            this.txtHostelCapacity.Name = "txtHostelCapacity";
            this.txtHostelCapacity.PasswordChar = '\0';
            this.txtHostelCapacity.PlaceholderText = "Capacity";
            this.txtHostelCapacity.SelectedText = "";
            this.txtHostelCapacity.ShadowDecoration.Parent = this.txtHostelCapacity;
            this.txtHostelCapacity.Size = new System.Drawing.Size(212, 36);
            this.txtHostelCapacity.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Capacity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hostel Code";
            // 
            // guna2Button1ViewHostels
            // 
            this.guna2Button1ViewHostels.CheckedState.Parent = this.guna2Button1ViewHostels;
            this.guna2Button1ViewHostels.CustomImages.Parent = this.guna2Button1ViewHostels;
            this.guna2Button1ViewHostels.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1ViewHostels.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1ViewHostels.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1ViewHostels.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1ViewHostels.DisabledState.Parent = this.guna2Button1ViewHostels;
            this.guna2Button1ViewHostels.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1ViewHostels.ForeColor = System.Drawing.Color.White;
            this.guna2Button1ViewHostels.HoverState.Parent = this.guna2Button1ViewHostels;
            this.guna2Button1ViewHostels.Location = new System.Drawing.Point(542, 500);
            this.guna2Button1ViewHostels.Name = "guna2Button1ViewHostels";
            this.guna2Button1ViewHostels.ShadowDecoration.Parent = this.guna2Button1ViewHostels;
            this.guna2Button1ViewHostels.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1ViewHostels.TabIndex = 10;
            this.guna2Button1ViewHostels.Text = "View Records";
            this.guna2Button1ViewHostels.Click += new System.EventHandler(this.guna2Button1ViewHostels_Click);
            // 
            // btnHostelSave
            // 
            this.btnHostelSave.CheckedState.Parent = this.btnHostelSave;
            this.btnHostelSave.CustomImages.Parent = this.btnHostelSave;
            this.btnHostelSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHostelSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHostelSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHostelSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHostelSave.DisabledState.Parent = this.btnHostelSave;
            this.btnHostelSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHostelSave.ForeColor = System.Drawing.Color.White;
            this.btnHostelSave.HoverState.Parent = this.btnHostelSave;
            this.btnHostelSave.Location = new System.Drawing.Point(293, 500);
            this.btnHostelSave.Name = "btnHostelSave";
            this.btnHostelSave.ShadowDecoration.Parent = this.btnHostelSave;
            this.btnHostelSave.Size = new System.Drawing.Size(180, 45);
            this.btnHostelSave.TabIndex = 8;
            this.btnHostelSave.Text = "Assign Hostel";
            this.btnHostelSave.Click += new System.EventHandler(this.btnHostelSave_Click);
            // 
            // btnHostelReset
            // 
            this.btnHostelReset.CheckedState.Parent = this.btnHostelReset;
            this.btnHostelReset.CustomImages.Parent = this.btnHostelReset;
            this.btnHostelReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHostelReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHostelReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHostelReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHostelReset.DisabledState.Parent = this.btnHostelReset;
            this.btnHostelReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHostelReset.ForeColor = System.Drawing.Color.White;
            this.btnHostelReset.HoverState.Parent = this.btnHostelReset;
            this.btnHostelReset.Location = new System.Drawing.Point(21, 500);
            this.btnHostelReset.Name = "btnHostelReset";
            this.btnHostelReset.ShadowDecoration.Parent = this.btnHostelReset;
            this.btnHostelReset.Size = new System.Drawing.Size(180, 45);
            this.btnHostelReset.TabIndex = 7;
            this.btnHostelReset.Text = "Reset Fields";
            this.btnHostelReset.Click += new System.EventHandler(this.btnHostelReset_Click);
            // 
            // guna2DataGridView1HostelsAssign
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1HostelsAssign.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.guna2DataGridView1HostelsAssign.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1HostelsAssign.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1HostelsAssign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1HostelsAssign.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1HostelsAssign.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1HostelsAssign.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.guna2DataGridView1HostelsAssign.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1HostelsAssign.DefaultCellStyle = dataGridViewCellStyle9;
            this.guna2DataGridView1HostelsAssign.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1HostelsAssign.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1HostelsAssign.Location = new System.Drawing.Point(597, 98);
            this.guna2DataGridView1HostelsAssign.Name = "guna2DataGridView1HostelsAssign";
            this.guna2DataGridView1HostelsAssign.RowHeadersVisible = false;
            this.guna2DataGridView1HostelsAssign.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1HostelsAssign.Size = new System.Drawing.Size(594, 382);
            this.guna2DataGridView1HostelsAssign.TabIndex = 6;
            this.guna2DataGridView1HostelsAssign.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1HostelsAssign.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1HostelsAssign.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1HostelsAssign.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1HostelsAssign.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1HostelsAssign.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1HostelsAssign.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1HostelsAssign.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1HostelsAssign.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1HostelsAssign.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1HostelsAssign.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1HostelsAssign.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1HostelsAssign.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1HostelsAssign.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1HostelsAssign.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1HostelsAssign.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1HostelsAssign.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1HostelsAssign.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1HostelsAssign.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1HostelsAssign.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1HostelsAssign.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txtHostelName
            // 
            this.txtHostelName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHostelName.DefaultText = "";
            this.txtHostelName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHostelName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHostelName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHostelName.DisabledState.Parent = this.txtHostelName;
            this.txtHostelName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHostelName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHostelName.FocusedState.Parent = this.txtHostelName;
            this.txtHostelName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHostelName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHostelName.HoverState.Parent = this.txtHostelName;
            this.txtHostelName.Location = new System.Drawing.Point(209, 158);
            this.txtHostelName.Name = "txtHostelName";
            this.txtHostelName.PasswordChar = '\0';
            this.txtHostelName.PlaceholderText = " Hostel Name";
            this.txtHostelName.SelectedText = "";
            this.txtHostelName.ShadowDecoration.Parent = this.txtHostelName;
            this.txtHostelName.Size = new System.Drawing.Size(212, 36);
            this.txtHostelName.TabIndex = 5;
            this.txtHostelName.TextChanged += new System.EventHandler(this.txtHostelName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hostel Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 57);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assign Hostel";
            // 
            // tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 563);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "tab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Hostel";
            this.Load += new System.EventHandler(this.AssignHostel_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1HostelsAssign)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox comboHosteAdmNo;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1Hostel;
        private Guna.UI2.WinForms.Guna2Button UpdateHostel;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtHostelCapacity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1ViewHostels;
        private Guna.UI2.WinForms.Guna2Button btnHostelSave;
        private Guna.UI2.WinForms.Guna2Button btnHostelReset;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1HostelsAssign;
        private Guna.UI2.WinForms.Guna2TextBox txtHostelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox comboHostelCode;
        private System.Windows.Forms.Label rooms;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtComboStudname;
    }
}