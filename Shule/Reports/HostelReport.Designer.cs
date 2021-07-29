namespace Shule.Reports
{
    partial class HostelReport
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
            this.crystalReportViewer1Hostels = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.HostelReportInfo2 = new Shule.Reports.HostelReportInfo();
            this.SuspendLayout();
            // 
            // crystalReportViewer1Hostels
            // 
            this.crystalReportViewer1Hostels.ActiveViewIndex = 0;
            this.crystalReportViewer1Hostels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1Hostels.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1Hostels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1Hostels.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1Hostels.Name = "crystalReportViewer1Hostels";
            this.crystalReportViewer1Hostels.ReportSource = this.HostelReportInfo2;
            this.crystalReportViewer1Hostels.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer1Hostels.TabIndex = 0;
            // 
            // HostelReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer1Hostels);
            this.Name = "HostelReport";
            this.Text = "HostelReport";
            this.ResumeLayout(false);

        }

        #endregion
        private HostelReportInfo HostelReportInfo1;
        private HostelReportInfo HostelReportInfo2;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1Hostels;
    }
}