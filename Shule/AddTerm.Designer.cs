namespace Shule
{
    partial class AddTerm
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
            this.comboBoxTyear = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTermSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnYearReset = new Guna.UI2.WinForms.Guna2Button();
            this.txtTermName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Snow;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.Controls.Add(this.comboBoxTyear);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.btnTermSave);
            this.guna2Panel1.Controls.Add(this.btnYearReset);
            this.guna2Panel1.Controls.Add(this.txtTermName);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(800, 299);
            this.guna2Panel1.TabIndex = 3;
            // 
            // comboBoxTyear
            // 
            this.comboBoxTyear.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxTyear.BorderColor = System.Drawing.Color.Gray;
            this.comboBoxTyear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxTyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTyear.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxTyear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxTyear.FocusedState.Parent = this.comboBoxTyear;
            this.comboBoxTyear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxTyear.ForeColor = System.Drawing.Color.Blue;
            this.comboBoxTyear.HoverState.Parent = this.comboBoxTyear;
            this.comboBoxTyear.ItemHeight = 30;
            this.comboBoxTyear.ItemsAppearance.Parent = this.comboBoxTyear;
            this.comboBoxTyear.Location = new System.Drawing.Point(212, 185);
            this.comboBoxTyear.Name = "comboBoxTyear";
            this.comboBoxTyear.ShadowDecoration.Parent = this.comboBoxTyear;
            this.comboBoxTyear.Size = new System.Drawing.Size(212, 36);
            this.comboBoxTyear.TabIndex = 25;
            this.comboBoxTyear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.comboBoxTyear.SelectedIndexChanged += new System.EventHandler(this.comboBoxTyear_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(50, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Year";
            // 
            // btnTermSave
            // 
            this.btnTermSave.BorderRadius = 16;
            this.btnTermSave.CheckedState.Parent = this.btnTermSave;
            this.btnTermSave.CustomImages.Parent = this.btnTermSave;
            this.btnTermSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTermSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTermSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTermSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTermSave.DisabledState.Parent = this.btnTermSave;
            this.btnTermSave.FillColor = System.Drawing.Color.LightBlue;
            this.btnTermSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTermSave.ForeColor = System.Drawing.Color.White;
            this.btnTermSave.HoverState.Parent = this.btnTermSave;
            this.btnTermSave.Location = new System.Drawing.Point(392, 241);
            this.btnTermSave.Name = "btnTermSave";
            this.btnTermSave.ShadowDecoration.Parent = this.btnTermSave;
            this.btnTermSave.Size = new System.Drawing.Size(180, 36);
            this.btnTermSave.TabIndex = 8;
            this.btnTermSave.Text = "Save Records";
            this.btnTermSave.Click += new System.EventHandler(this.btnTermSave_Click);
            // 
            // btnYearReset
            // 
            this.btnYearReset.BorderRadius = 16;
            this.btnYearReset.CheckedState.Parent = this.btnYearReset;
            this.btnYearReset.CustomImages.Parent = this.btnYearReset;
            this.btnYearReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYearReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYearReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYearReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYearReset.DisabledState.Parent = this.btnYearReset;
            this.btnYearReset.FillColor = System.Drawing.Color.LightBlue;
            this.btnYearReset.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearReset.ForeColor = System.Drawing.Color.White;
            this.btnYearReset.HoverState.Parent = this.btnYearReset;
            this.btnYearReset.Location = new System.Drawing.Point(129, 241);
            this.btnYearReset.Name = "btnYearReset";
            this.btnYearReset.ShadowDecoration.Parent = this.btnYearReset;
            this.btnYearReset.Size = new System.Drawing.Size(180, 36);
            this.btnYearReset.TabIndex = 7;
            this.btnYearReset.Text = "Reset Fields";
            // 
            // txtTermName
            // 
            this.txtTermName.BorderColor = System.Drawing.Color.Gray;
            this.txtTermName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTermName.DefaultText = "";
            this.txtTermName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTermName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTermName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTermName.DisabledState.Parent = this.txtTermName;
            this.txtTermName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTermName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTermName.FocusedState.Parent = this.txtTermName;
            this.txtTermName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTermName.ForeColor = System.Drawing.Color.Blue;
            this.txtTermName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTermName.HoverState.Parent = this.txtTermName;
            this.txtTermName.Location = new System.Drawing.Point(212, 117);
            this.txtTermName.Name = "txtTermName";
            this.txtTermName.PasswordChar = '\0';
            this.txtTermName.PlaceholderText = "";
            this.txtTermName.SelectedText = "";
            this.txtTermName.ShadowDecoration.Parent = this.txtTermName;
            this.txtTermName.Size = new System.Drawing.Size(212, 36);
            this.txtTermName.TabIndex = 5;
            this.txtTermName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(50, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Term";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 57);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Term";
            // 
            // AddTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 299);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "AddTerm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTerm";
            this.Load += new System.EventHandler(this.AddTerm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnTermSave;
        private Guna.UI2.WinForms.Guna2Button btnYearReset;
        private Guna.UI2.WinForms.Guna2TextBox txtTermName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxTyear;
    }
}