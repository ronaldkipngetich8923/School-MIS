namespace Shule
{
    partial class AddDriver
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtroute = new Guna.UI2.WinForms.Guna2TextBox();
            this.griddrivers = new System.Windows.Forms.DataGridView();
            this.comboVehicleAssigned = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLicenceNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDfullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button1ViewDrivers = new Guna.UI2.WinForms.Guna2Button();
            this.btnClassesRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnRouteSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnRouteReset = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griddrivers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.guna2Panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1140, 450);
            this.panel2.TabIndex = 30;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Panel1.Controls.Add(this.txtroute);
            this.guna2Panel1.Controls.Add(this.griddrivers);
            this.guna2Panel1.Controls.Add(this.comboVehicleAssigned);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.txtLicenceNo);
            this.guna2Panel1.Controls.Add(this.txtDId);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.txtDfullName);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.guna2Button1ViewDrivers);
            this.guna2Panel1.Controls.Add(this.btnClassesRefresh);
            this.guna2Panel1.Controls.Add(this.btnRouteSave);
            this.guna2Panel1.Controls.Add(this.btnRouteReset);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1140, 450);
            this.guna2Panel1.TabIndex = 4;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // txtroute
            // 
            this.txtroute.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtroute.DefaultText = "";
            this.txtroute.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtroute.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtroute.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtroute.DisabledState.Parent = this.txtroute;
            this.txtroute.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtroute.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtroute.FocusedState.Parent = this.txtroute;
            this.txtroute.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtroute.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtroute.HoverState.Parent = this.txtroute;
            this.txtroute.Location = new System.Drawing.Point(177, 297);
            this.txtroute.Name = "txtroute";
            this.txtroute.PasswordChar = '\0';
            this.txtroute.PlaceholderText = "";
            this.txtroute.SelectedText = "";
            this.txtroute.ShadowDecoration.Parent = this.txtroute;
            this.txtroute.Size = new System.Drawing.Size(212, 36);
            this.txtroute.TabIndex = 21;
            this.txtroute.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // griddrivers
            // 
            this.griddrivers.BackgroundColor = System.Drawing.Color.White;
            this.griddrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griddrivers.Location = new System.Drawing.Point(541, 74);
            this.griddrivers.Name = "griddrivers";
            this.griddrivers.Size = new System.Drawing.Size(558, 247);
            this.griddrivers.TabIndex = 20;
            this.griddrivers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboVehicleAssigned
            // 
            this.comboVehicleAssigned.BackColor = System.Drawing.Color.Transparent;
            this.comboVehicleAssigned.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboVehicleAssigned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVehicleAssigned.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboVehicleAssigned.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboVehicleAssigned.FocusedState.Parent = this.comboVehicleAssigned;
            this.comboVehicleAssigned.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboVehicleAssigned.ForeColor = System.Drawing.Color.Orange;
            this.comboVehicleAssigned.HoverState.Parent = this.comboVehicleAssigned;
            this.comboVehicleAssigned.ItemHeight = 30;
            this.comboVehicleAssigned.ItemsAppearance.Parent = this.comboVehicleAssigned;
            this.comboVehicleAssigned.Location = new System.Drawing.Point(177, 243);
            this.comboVehicleAssigned.Name = "comboVehicleAssigned";
            this.comboVehicleAssigned.ShadowDecoration.Parent = this.comboVehicleAssigned;
            this.comboVehicleAssigned.Size = new System.Drawing.Size(212, 36);
            this.comboVehicleAssigned.TabIndex = 19;
            this.comboVehicleAssigned.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.comboVehicleAssigned.SelectedIndexChanged += new System.EventHandler(this.comboVehicleAssigned_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Vehicle assigned";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Route assigned";
            // 
            // txtLicenceNo
            // 
            this.txtLicenceNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLicenceNo.DefaultText = "";
            this.txtLicenceNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLicenceNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLicenceNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLicenceNo.DisabledState.Parent = this.txtLicenceNo;
            this.txtLicenceNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLicenceNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLicenceNo.FocusedState.Parent = this.txtLicenceNo;
            this.txtLicenceNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLicenceNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLicenceNo.HoverState.Parent = this.txtLicenceNo;
            this.txtLicenceNo.Location = new System.Drawing.Point(177, 184);
            this.txtLicenceNo.Name = "txtLicenceNo";
            this.txtLicenceNo.PasswordChar = '\0';
            this.txtLicenceNo.PlaceholderText = "Licence Number";
            this.txtLicenceNo.SelectedText = "";
            this.txtLicenceNo.ShadowDecoration.Parent = this.txtLicenceNo;
            this.txtLicenceNo.Size = new System.Drawing.Size(212, 36);
            this.txtLicenceNo.TabIndex = 15;
            this.txtLicenceNo.TextChanged += new System.EventHandler(this.txtLicenceNo_TextChanged);
            // 
            // txtDId
            // 
            this.txtDId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDId.DefaultText = "";
            this.txtDId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDId.DisabledState.Parent = this.txtDId;
            this.txtDId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDId.FocusedState.Parent = this.txtDId;
            this.txtDId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDId.HoverState.Parent = this.txtDId;
            this.txtDId.Location = new System.Drawing.Point(177, 74);
            this.txtDId.Name = "txtDId";
            this.txtDId.PasswordChar = '\0';
            this.txtDId.PlaceholderText = "Id No";
            this.txtDId.SelectedText = "";
            this.txtDId.ShadowDecoration.Parent = this.txtDId;
            this.txtDId.Size = new System.Drawing.Size(212, 36);
            this.txtDId.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Id No";
            // 
            // txtDfullName
            // 
            this.txtDfullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDfullName.DefaultText = "";
            this.txtDfullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDfullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDfullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDfullName.DisabledState.Parent = this.txtDfullName;
            this.txtDfullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDfullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDfullName.FocusedState.Parent = this.txtDfullName;
            this.txtDfullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDfullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDfullName.HoverState.Parent = this.txtDfullName;
            this.txtDfullName.Location = new System.Drawing.Point(177, 129);
            this.txtDfullName.Name = "txtDfullName";
            this.txtDfullName.PasswordChar = '\0';
            this.txtDfullName.PlaceholderText = "Full Name";
            this.txtDfullName.SelectedText = "";
            this.txtDfullName.ShadowDecoration.Parent = this.txtDfullName;
            this.txtDfullName.Size = new System.Drawing.Size(212, 36);
            this.txtDfullName.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Full Name";
            // 
            // guna2Button1ViewDrivers
            // 
            this.guna2Button1ViewDrivers.CheckedState.Parent = this.guna2Button1ViewDrivers;
            this.guna2Button1ViewDrivers.CustomImages.Parent = this.guna2Button1ViewDrivers;
            this.guna2Button1ViewDrivers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1ViewDrivers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1ViewDrivers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1ViewDrivers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1ViewDrivers.DisabledState.Parent = this.guna2Button1ViewDrivers;
            this.guna2Button1ViewDrivers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1ViewDrivers.ForeColor = System.Drawing.Color.White;
            this.guna2Button1ViewDrivers.HoverState.Parent = this.guna2Button1ViewDrivers;
            this.guna2Button1ViewDrivers.Location = new System.Drawing.Point(541, 355);
            this.guna2Button1ViewDrivers.Name = "guna2Button1ViewDrivers";
            this.guna2Button1ViewDrivers.ShadowDecoration.Parent = this.guna2Button1ViewDrivers;
            this.guna2Button1ViewDrivers.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1ViewDrivers.TabIndex = 10;
            this.guna2Button1ViewDrivers.Text = "View Records";
            this.guna2Button1ViewDrivers.Click += new System.EventHandler(this.guna2Button1ViewDrivers_Click);
            // 
            // btnClassesRefresh
            // 
            this.btnClassesRefresh.CheckedState.Parent = this.btnClassesRefresh;
            this.btnClassesRefresh.CustomImages.Parent = this.btnClassesRefresh;
            this.btnClassesRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClassesRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClassesRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClassesRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClassesRefresh.DisabledState.Parent = this.btnClassesRefresh;
            this.btnClassesRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClassesRefresh.ForeColor = System.Drawing.Color.White;
            this.btnClassesRefresh.HoverState.Parent = this.btnClassesRefresh;
            this.btnClassesRefresh.Location = new System.Drawing.Point(763, 355);
            this.btnClassesRefresh.Name = "btnClassesRefresh";
            this.btnClassesRefresh.ShadowDecoration.Parent = this.btnClassesRefresh;
            this.btnClassesRefresh.Size = new System.Drawing.Size(180, 45);
            this.btnClassesRefresh.TabIndex = 9;
            this.btnClassesRefresh.Text = "Update Route";
            // 
            // btnRouteSave
            // 
            this.btnRouteSave.CheckedState.Parent = this.btnRouteSave;
            this.btnRouteSave.CustomImages.Parent = this.btnRouteSave;
            this.btnRouteSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRouteSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRouteSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRouteSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRouteSave.DisabledState.Parent = this.btnRouteSave;
            this.btnRouteSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRouteSave.ForeColor = System.Drawing.Color.White;
            this.btnRouteSave.HoverState.Parent = this.btnRouteSave;
            this.btnRouteSave.Location = new System.Drawing.Point(291, 355);
            this.btnRouteSave.Name = "btnRouteSave";
            this.btnRouteSave.ShadowDecoration.Parent = this.btnRouteSave;
            this.btnRouteSave.Size = new System.Drawing.Size(180, 45);
            this.btnRouteSave.TabIndex = 8;
            this.btnRouteSave.Text = "Save Records";
            this.btnRouteSave.Click += new System.EventHandler(this.btnRouteSave_Click);
            // 
            // btnRouteReset
            // 
            this.btnRouteReset.CheckedState.Parent = this.btnRouteReset;
            this.btnRouteReset.CustomImages.Parent = this.btnRouteReset;
            this.btnRouteReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRouteReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRouteReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRouteReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRouteReset.DisabledState.Parent = this.btnRouteReset;
            this.btnRouteReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRouteReset.ForeColor = System.Drawing.Color.White;
            this.btnRouteReset.HoverState.Parent = this.btnRouteReset;
            this.btnRouteReset.Location = new System.Drawing.Point(16, 355);
            this.btnRouteReset.Name = "btnRouteReset";
            this.btnRouteReset.ShadowDecoration.Parent = this.btnRouteReset;
            this.btnRouteReset.Size = new System.Drawing.Size(180, 45);
            this.btnRouteReset.TabIndex = 7;
            this.btnRouteReset.Text = "Reset Fields";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Licence Number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 57);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Driver";
            // 
            // AddDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 450);
            this.Controls.Add(this.panel2);
            this.Name = "AddDriver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDriver";
            this.Load += new System.EventHandler(this.AddDriver_Load);
            this.panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griddrivers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox comboVehicleAssigned;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtLicenceNo;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtDfullName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1ViewDrivers;
        private Guna.UI2.WinForms.Guna2Button btnClassesRefresh;
        private Guna.UI2.WinForms.Guna2Button btnRouteSave;
        private Guna.UI2.WinForms.Guna2Button btnRouteReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView griddrivers;
        private Guna.UI2.WinForms.Guna2TextBox txtroute;
        private Guna.UI2.WinForms.Guna2TextBox txtDId;
    }
}