namespace Shule
{
    partial class Print_Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print_Receipt));
            this.Text_Receipt = new System.Windows.Forms.RichTextBox();
            this.guna2Buttonsearch = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBoxsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // Text_Receipt
            // 
            this.Text_Receipt.Location = new System.Drawing.Point(79, 131);
            this.Text_Receipt.Name = "Text_Receipt";
            this.Text_Receipt.ReadOnly = true;
            this.Text_Receipt.Size = new System.Drawing.Size(376, 430);
            this.Text_Receipt.TabIndex = 0;
            this.Text_Receipt.Text = "";
            this.Text_Receipt.Visible = false;
            // 
            // guna2Buttonsearch
            // 
            this.guna2Buttonsearch.BorderRadius = 20;
            this.guna2Buttonsearch.CheckedState.Parent = this.guna2Buttonsearch;
            this.guna2Buttonsearch.CustomImages.Parent = this.guna2Buttonsearch;
            this.guna2Buttonsearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Buttonsearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Buttonsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Buttonsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Buttonsearch.DisabledState.Parent = this.guna2Buttonsearch;
            this.guna2Buttonsearch.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.guna2Buttonsearch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Buttonsearch.ForeColor = System.Drawing.Color.White;
            this.guna2Buttonsearch.HoverState.Parent = this.guna2Buttonsearch;
            this.guna2Buttonsearch.Location = new System.Drawing.Point(246, 81);
            this.guna2Buttonsearch.Name = "guna2Buttonsearch";
            this.guna2Buttonsearch.ShadowDecoration.Parent = this.guna2Buttonsearch;
            this.guna2Buttonsearch.Size = new System.Drawing.Size(103, 35);
            this.guna2Buttonsearch.TabIndex = 23;
            this.guna2Buttonsearch.Text = "Search ";
            this.guna2Buttonsearch.Click += new System.EventHandler(this.guna2Buttonsearch_Click);
            // 
            // guna2TextBoxsearch
            // 
            this.guna2TextBoxsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxsearch.DefaultText = "";
            this.guna2TextBoxsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxsearch.DisabledState.Parent = this.guna2TextBoxsearch;
            this.guna2TextBoxsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxsearch.FocusedState.Parent = this.guna2TextBoxsearch;
            this.guna2TextBoxsearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxsearch.HoverState.Parent = this.guna2TextBoxsearch;
            this.guna2TextBoxsearch.Location = new System.Drawing.Point(100, 81);
            this.guna2TextBoxsearch.Name = "guna2TextBoxsearch";
            this.guna2TextBoxsearch.PasswordChar = '\0';
            this.guna2TextBoxsearch.PlaceholderText = "Search By AdmNo";
            this.guna2TextBoxsearch.SelectedText = "";
            this.guna2TextBoxsearch.ShadowDecoration.Parent = this.guna2TextBoxsearch;
            this.guna2TextBoxsearch.Size = new System.Drawing.Size(130, 35);
            this.guna2TextBoxsearch.TabIndex = 24;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.DarkGreen;
            this.guna2Button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(355, 81);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(100, 35);
            this.guna2Button1.TabIndex = 25;
            this.guna2Button1.Text = "Print";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Print Fees Receipt";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.DisabledState.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.guna2Button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = global::Shule.Properties.Resources.exit11;
            this.guna2Button2.Location = new System.Drawing.Point(509, 2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(47, 39);
            this.guna2Button2.TabIndex = 26;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // Print_Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(558, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2TextBoxsearch);
            this.Controls.Add(this.guna2Buttonsearch);
            this.Controls.Add(this.Text_Receipt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Print_Receipt";
            this.Text = "Print_Receipt";
            this.Load += new System.EventHandler(this.Print_Receipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Text_Receipt;
        private Guna.UI2.WinForms.Guna2Button guna2Buttonsearch;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxsearch;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}