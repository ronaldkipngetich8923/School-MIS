namespace Shule
{
    partial class viewbooksinshelf
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ShelfId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShelfName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShelfDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShelfLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(22, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 35);
            this.button2.TabIndex = 17;
            this.button2.Text = "Show Available Books";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShelfId,
            this.shelfNo,
            this.ShelfName,
            this.ShelfDescription,
            this.ShelfLocation});
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 393);
            this.dataGridView1.TabIndex = 18;
            // 
            // ShelfId
            // 
            this.ShelfId.HeaderText = "ShelfId";
            this.ShelfId.Name = "ShelfId";
            // 
            // shelfNo
            // 
            this.shelfNo.HeaderText = "ShelfNo";
            this.shelfNo.Name = "shelfNo";
            // 
            // ShelfName
            // 
            this.ShelfName.HeaderText = "ShelfName";
            this.ShelfName.Name = "ShelfName";
            // 
            // ShelfDescription
            // 
            this.ShelfDescription.HeaderText = "ShelfDescription";
            this.ShelfDescription.Name = "ShelfDescription";
            // 
            // ShelfLocation
            // 
            this.ShelfLocation.HeaderText = "ShelfLocation";
            this.ShelfLocation.Name = "ShelfLocation";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(414, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 27);
            this.button1.TabIndex = 19;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // viewbooksinshelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Name = "viewbooksinshelf";
            this.Text = "viewbooksinshelf";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShelfId;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShelfName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShelfDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShelfLocation;
        private System.Windows.Forms.Button button1;
    }
}