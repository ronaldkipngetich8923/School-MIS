namespace Shule
{
    partial class SetExam
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.comboExamType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2DateTimePicker2IssueDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2DateTimePickerSetDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.conboBoxSetBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWeight = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboSubjects = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYear = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubjectSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtExamCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetExamsSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnSubjectReset = new Guna.UI2.WinForms.Guna2Button();
            this.txtTerm = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1SetExam = new System.Windows.Forms.DataGridView();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1SetExam)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Panel1.Controls.Add(this.dataGridView1SetExam);
            this.guna2Panel1.Controls.Add(this.comboExamType);
            this.guna2Panel1.Controls.Add(this.comboCategory);
            this.guna2Panel1.Controls.Add(this.guna2DateTimePicker2IssueDate);
            this.guna2Panel1.Controls.Add(this.label11);
            this.guna2Panel1.Controls.Add(this.guna2DateTimePickerSetDate);
            this.guna2Panel1.Controls.Add(this.conboBoxSetBy);
            this.guna2Panel1.Controls.Add(this.label10);
            this.guna2Panel1.Controls.Add(this.label9);
            this.guna2Panel1.Controls.Add(this.txtWeight);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.comboSubjects);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.txtYear);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.btnSubjectSave);
            this.guna2Panel1.Controls.Add(this.txtExamCode);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.btnSetExamsSave);
            this.guna2Panel1.Controls.Add(this.btnSubjectReset);
            this.guna2Panel1.Controls.Add(this.txtTerm);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1189, 545);
            this.guna2Panel1.TabIndex = 6;
            // 
            // comboExamType
            // 
            this.comboExamType.BackColor = System.Drawing.Color.Transparent;
            this.comboExamType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboExamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboExamType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboExamType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboExamType.FocusedState.Parent = this.comboExamType;
            this.comboExamType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboExamType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboExamType.HoverState.Parent = this.comboExamType;
            this.comboExamType.ItemHeight = 30;
            this.comboExamType.Items.AddRange(new object[] {
            "CATS",
            "MID-EXAMS",
            "END-EXAMS"});
            this.comboExamType.ItemsAppearance.Parent = this.comboExamType;
            this.comboExamType.Location = new System.Drawing.Point(144, 239);
            this.comboExamType.Name = "comboExamType";
            this.comboExamType.ShadowDecoration.Parent = this.comboExamType;
            this.comboExamType.Size = new System.Drawing.Size(240, 36);
            this.comboExamType.TabIndex = 31;
            // 
            // comboCategory
            // 
            this.comboCategory.BackColor = System.Drawing.Color.Transparent;
            this.comboCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboCategory.FocusedState.Parent = this.comboCategory;
            this.comboCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboCategory.HoverState.Parent = this.comboCategory;
            this.comboCategory.ItemHeight = 30;
            this.comboCategory.Items.AddRange(new object[] {
            "CAT_1",
            "CAT_2",
            "MID_EXAMS",
            "END_EXAMS"});
            this.comboCategory.ItemsAppearance.Parent = this.comboCategory;
            this.comboCategory.Location = new System.Drawing.Point(144, 308);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.ShadowDecoration.Parent = this.comboCategory;
            this.comboCategory.Size = new System.Drawing.Size(240, 36);
            this.comboCategory.TabIndex = 30;
            // 
            // guna2DateTimePicker2IssueDate
            // 
            this.guna2DateTimePicker2IssueDate.CheckedState.Parent = this.guna2DateTimePicker2IssueDate;
            this.guna2DateTimePicker2IssueDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker2IssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker2IssueDate.HoverState.Parent = this.guna2DateTimePicker2IssueDate;
            this.guna2DateTimePicker2IssueDate.Location = new System.Drawing.Point(519, 251);
            this.guna2DateTimePicker2IssueDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker2IssueDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker2IssueDate.Name = "guna2DateTimePicker2IssueDate";
            this.guna2DateTimePicker2IssueDate.ShadowDecoration.Parent = this.guna2DateTimePicker2IssueDate;
            this.guna2DateTimePicker2IssueDate.Size = new System.Drawing.Size(240, 36);
            this.guna2DateTimePicker2IssueDate.TabIndex = 29;
            this.guna2DateTimePicker2IssueDate.Value = new System.DateTime(2021, 6, 19, 12, 47, 44, 682);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(397, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 24);
            this.label11.TabIndex = 28;
            this.label11.Text = "Issue Date";
            // 
            // guna2DateTimePickerSetDate
            // 
            this.guna2DateTimePickerSetDate.CheckedState.Parent = this.guna2DateTimePickerSetDate;
            this.guna2DateTimePickerSetDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePickerSetDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePickerSetDate.HoverState.Parent = this.guna2DateTimePickerSetDate;
            this.guna2DateTimePickerSetDate.Location = new System.Drawing.Point(519, 184);
            this.guna2DateTimePickerSetDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePickerSetDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePickerSetDate.Name = "guna2DateTimePickerSetDate";
            this.guna2DateTimePickerSetDate.ShadowDecoration.Parent = this.guna2DateTimePickerSetDate;
            this.guna2DateTimePickerSetDate.Size = new System.Drawing.Size(240, 36);
            this.guna2DateTimePickerSetDate.TabIndex = 27;
            this.guna2DateTimePickerSetDate.Value = new System.DateTime(2021, 6, 19, 12, 47, 44, 682);
            // 
            // conboBoxSetBy
            // 
            this.conboBoxSetBy.BackColor = System.Drawing.Color.Transparent;
            this.conboBoxSetBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.conboBoxSetBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conboBoxSetBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.conboBoxSetBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.conboBoxSetBy.FocusedState.Parent = this.conboBoxSetBy;
            this.conboBoxSetBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.conboBoxSetBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.conboBoxSetBy.HoverState.Parent = this.conboBoxSetBy;
            this.conboBoxSetBy.ItemHeight = 30;
            this.conboBoxSetBy.ItemsAppearance.Parent = this.conboBoxSetBy;
            this.conboBoxSetBy.Location = new System.Drawing.Point(144, 369);
            this.conboBoxSetBy.Name = "conboBoxSetBy";
            this.conboBoxSetBy.ShadowDecoration.Parent = this.conboBoxSetBy;
            this.conboBoxSetBy.Size = new System.Drawing.Size(240, 36);
            this.conboBoxSetBy.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 24);
            this.label10.TabIndex = 25;
            this.label10.Text = "Set By";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(397, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "Set Date";
            // 
            // txtWeight
            // 
            this.txtWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWeight.DefaultText = "";
            this.txtWeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWeight.DisabledState.Parent = this.txtWeight;
            this.txtWeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWeight.FocusedState.Parent = this.txtWeight;
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtWeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWeight.HoverState.Parent = this.txtWeight;
            this.txtWeight.Location = new System.Drawing.Point(519, 134);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.PasswordChar = '\0';
            this.txtWeight.PlaceholderText = "Exam Max Weight";
            this.txtWeight.SelectedText = "";
            this.txtWeight.ShadowDecoration.Parent = this.txtWeight;
            this.txtWeight.Size = new System.Drawing.Size(240, 36);
            this.txtWeight.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(397, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Weight";
            // 
            // comboSubjects
            // 
            this.comboSubjects.BackColor = System.Drawing.Color.Transparent;
            this.comboSubjects.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSubjects.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSubjects.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSubjects.FocusedState.Parent = this.comboSubjects;
            this.comboSubjects.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboSubjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboSubjects.HoverState.Parent = this.comboSubjects;
            this.comboSubjects.ItemHeight = 30;
            this.comboSubjects.ItemsAppearance.Parent = this.comboSubjects;
            this.comboSubjects.Location = new System.Drawing.Point(519, 81);
            this.comboSubjects.Name = "comboSubjects";
            this.comboSubjects.ShadowDecoration.Parent = this.comboSubjects;
            this.comboSubjects.Size = new System.Drawing.Size(240, 36);
            this.comboSubjects.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(397, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Subject";
            // 
            // txtYear
            // 
            this.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYear.DefaultText = "";
            this.txtYear.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYear.DisabledState.Parent = this.txtYear;
            this.txtYear.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYear.FocusedState.Parent = this.txtYear;
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYear.HoverState.Parent = this.txtYear;
            this.txtYear.Location = new System.Drawing.Point(144, 130);
            this.txtYear.Name = "txtYear";
            this.txtYear.PasswordChar = '\0';
            this.txtYear.PlaceholderText = "Specify Year";
            this.txtYear.SelectedText = "";
            this.txtYear.ShadowDecoration.Parent = this.txtYear;
            this.txtYear.Size = new System.Drawing.Size(240, 36);
            this.txtYear.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Exam Type";
            // 
            // btnSubjectSave
            // 
            this.btnSubjectSave.CheckedState.Parent = this.btnSubjectSave;
            this.btnSubjectSave.CustomImages.Parent = this.btnSubjectSave;
            this.btnSubjectSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubjectSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubjectSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubjectSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubjectSave.DisabledState.Parent = this.btnSubjectSave;
            this.btnSubjectSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSubjectSave.ForeColor = System.Drawing.Color.White;
            this.btnSubjectSave.HoverState.Parent = this.btnSubjectSave;
            this.btnSubjectSave.Location = new System.Drawing.Point(675, 489);
            this.btnSubjectSave.Name = "btnSubjectSave";
            this.btnSubjectSave.ShadowDecoration.Parent = this.btnSubjectSave;
            this.btnSubjectSave.Size = new System.Drawing.Size(180, 45);
            this.btnSubjectSave.TabIndex = 12;
            this.btnSubjectSave.Text = "View Records";
            this.btnSubjectSave.Click += new System.EventHandler(this.btnSubjectSave_Click);
            // 
            // txtExamCode
            // 
            this.txtExamCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExamCode.DefaultText = "";
            this.txtExamCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtExamCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtExamCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtExamCode.DisabledState.Parent = this.txtExamCode;
            this.txtExamCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtExamCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtExamCode.FocusedState.Parent = this.txtExamCode;
            this.txtExamCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtExamCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtExamCode.HoverState.Parent = this.txtExamCode;
            this.txtExamCode.Location = new System.Drawing.Point(144, 184);
            this.txtExamCode.Name = "txtExamCode";
            this.txtExamCode.PasswordChar = '\0';
            this.txtExamCode.PlaceholderText = "Enter the Exam Code";
            this.txtExamCode.SelectedText = "";
            this.txtExamCode.ShadowDecoration.Parent = this.txtExamCode;
            this.txtExamCode.Size = new System.Drawing.Size(240, 36);
            this.txtExamCode.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Exam Code";
            // 
            // btnSetExamsSave
            // 
            this.btnSetExamsSave.CheckedState.Parent = this.btnSetExamsSave;
            this.btnSetExamsSave.CustomImages.Parent = this.btnSetExamsSave;
            this.btnSetExamsSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSetExamsSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSetExamsSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSetExamsSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSetExamsSave.DisabledState.Parent = this.btnSetExamsSave;
            this.btnSetExamsSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSetExamsSave.ForeColor = System.Drawing.Color.White;
            this.btnSetExamsSave.HoverState.Parent = this.btnSetExamsSave;
            this.btnSetExamsSave.Location = new System.Drawing.Point(445, 489);
            this.btnSetExamsSave.Name = "btnSetExamsSave";
            this.btnSetExamsSave.ShadowDecoration.Parent = this.btnSetExamsSave;
            this.btnSetExamsSave.Size = new System.Drawing.Size(180, 45);
            this.btnSetExamsSave.TabIndex = 8;
            this.btnSetExamsSave.Text = "Save Records";
            this.btnSetExamsSave.Click += new System.EventHandler(this.btnSetExamsSave_Click);
            // 
            // btnSubjectReset
            // 
            this.btnSubjectReset.CheckedState.Parent = this.btnSubjectReset;
            this.btnSubjectReset.CustomImages.Parent = this.btnSubjectReset;
            this.btnSubjectReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubjectReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubjectReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubjectReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubjectReset.DisabledState.Parent = this.btnSubjectReset;
            this.btnSubjectReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSubjectReset.ForeColor = System.Drawing.Color.White;
            this.btnSubjectReset.HoverState.Parent = this.btnSubjectReset;
            this.btnSubjectReset.Location = new System.Drawing.Point(173, 489);
            this.btnSubjectReset.Name = "btnSubjectReset";
            this.btnSubjectReset.ShadowDecoration.Parent = this.btnSubjectReset;
            this.btnSubjectReset.Size = new System.Drawing.Size(180, 45);
            this.btnSubjectReset.TabIndex = 7;
            this.btnSubjectReset.Text = "Reset Fields";
            // 
            // txtTerm
            // 
            this.txtTerm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTerm.DefaultText = "";
            this.txtTerm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTerm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTerm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTerm.DisabledState.Parent = this.txtTerm;
            this.txtTerm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTerm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTerm.FocusedState.Parent = this.txtTerm;
            this.txtTerm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTerm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTerm.HoverState.Parent = this.txtTerm;
            this.txtTerm.Location = new System.Drawing.Point(144, 72);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.PasswordChar = '\0';
            this.txtTerm.PlaceholderText = "Specify Term";
            this.txtTerm.SelectedText = "";
            this.txtTerm.ShadowDecoration.Parent = this.txtTerm;
            this.txtTerm.Size = new System.Drawing.Size(240, 36);
            this.txtTerm.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Term ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 57);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set  Exams";
            // 
            // dataGridView1SetExam
            // 
            this.dataGridView1SetExam.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1SetExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1SetExam.Location = new System.Drawing.Point(780, 81);
            this.dataGridView1SetExam.Name = "dataGridView1SetExam";
            this.dataGridView1SetExam.Size = new System.Drawing.Size(397, 402);
            this.dataGridView1SetExam.TabIndex = 32;
            // 
            // SetExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 545);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "SetExam";
            this.Text = "SetExam";
            this.Load += new System.EventHandler(this.SetExam_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1SetExam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox comboExamType;
        private Guna.UI2.WinForms.Guna2ComboBox comboCategory;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2IssueDate;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePickerSetDate;
        private Guna.UI2.WinForms.Guna2ComboBox conboBoxSetBy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtWeight;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox comboSubjects;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnSubjectSave;
        private Guna.UI2.WinForms.Guna2TextBox txtExamCode;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnSetExamsSave;
        private Guna.UI2.WinForms.Guna2Button btnSubjectReset;
        private Guna.UI2.WinForms.Guna2TextBox txtTerm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1SetExam;
    }
}