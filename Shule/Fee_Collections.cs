﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Shule
{
    public partial class Fee_Collections : Form
    {
        public Fee_Collections()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=shule;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataReader sqldataReader;

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Fees_Structure.Visible = true;
            feesadjustmentpanel.Visible = false;
            feesreceiptpanel.Visible = false;
            transferfeepanel.Visible = false;
            MainDashboard.Visible = false;
            menupanel.Visible = true;
        }

        private void Fees_Structure_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            AssignFeesToClass af = new AssignFeesToClass();
            af.Show();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Fees_Structure fs = new Fees_Structure();
            fs.Show();
        }

        private void Fee_Collections_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            feesreceiptpanel.Visible = false;
            Fees_Structure.Visible = false;
            feesadjustmentpanel.Visible = false;
            transferfeepanel.Visible = false;
            MainDashboard.Visible = true;
            menupanel.Visible = false;
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            AddFeeStructure afs = new AddFeeStructure();
            afs.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            feesadjustmentpanel.Visible = true;
            Fees_Structure.Visible = false;
            feesreceiptpanel.Visible = false;
            MainDashboard.Visible = false;
            transferfeepanel.Visible = false;
            menupanel.Visible = true;
        }

        private void guna2PictureBox9_Click(object sender, EventArgs e)
        {
            Fees_Structure.Visible = true;
            feesadjustmentpanel.Visible = false;
            feesreceiptpanel.Visible = false;
            transferfeepanel.Visible = false;
            MainDashboard.Visible = false;
            menupanel.Visible = true;

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            feesadjustmentpanel.Visible = true;
            Fees_Structure.Visible = false;
            feesreceiptpanel.Visible = false;
            transferfeepanel.Visible = false;
            MainDashboard.Visible = false;
            menupanel.Visible = true;
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            feesreceiptpanel.Visible = true;
            feesadjustmentpanel.Visible = false;
            Fees_Structure.Visible = false;
            transferfeepanel.Visible = false;
            MainDashboard.Visible = false;
            menupanel.Visible = true;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            feesreceiptpanel.Visible = false;
            Fees_Structure.Visible = false;
            feesadjustmentpanel.Visible = false;
            transferfeepanel.Visible = true;
            MainDashboard.Visible = false;
            menupanel.Visible = true;
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            feesreceiptpanel.Visible = false;
            Fees_Structure.Visible = false;
            feesadjustmentpanel.Visible = false;
            transferfeepanel.Visible = true;
            MainDashboard.Visible = false;
            menupanel.Visible = true;
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            feesreceiptpanel.Visible = true;
            feesadjustmentpanel.Visible = false;
            Fees_Structure.Visible = false;                     
            transferfeepanel.Visible = false;
            MainDashboard.Visible = false;
            menupanel.Visible = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Fees_Structure.Visible = false;
            feesadjustmentpanel.Visible = false;
            feesreceiptpanel.Visible = false;
            transferfeepanel.Visible = false;
            MainDashboard.Visible = true;
            menupanel.Visible = true;
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            Fees_Structure.Visible = true;
            feesadjustmentpanel.Visible = false;
            feesreceiptpanel.Visible = false;
            transferfeepanel.Visible = false;
            MainDashboard.Visible = false;
            menupanel.Visible = true;
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            feesadjustmentpanel.Visible = true;
            Fees_Structure.Visible = false;
            feesreceiptpanel.Visible = false;
            MainDashboard.Visible = false;
            transferfeepanel.Visible = false;
            menupanel.Visible = true;
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            feesreceiptpanel.Visible = false;
            Fees_Structure.Visible = false;
            feesadjustmentpanel.Visible = false;
            transferfeepanel.Visible = true;
            MainDashboard.Visible = false;
            menupanel.Visible = true;
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            feesreceiptpanel.Visible = true;
            feesadjustmentpanel.Visible = false;
            Fees_Structure.Visible = false;
            transferfeepanel.Visible = false;
            MainDashboard.Visible = false;
            menupanel.Visible = true;
        }

       // int ReceiptNo ;

        public void receiptNumber()
        {
            ////guna2TextBoxReceiptNo.Text = ReceiptNo.ToString("D8");
            //ReceiptNo = Convert.ToInt16(guna2TextBoxReceiptNo.Text);
            //ReceiptNo++;
            //guna2TextBoxReceiptNo.Text = ReceiptNo.ToString("D8");

            con.Open();
            String selectQuery = "SELECT Max(ReceiptNo) FROM fee_receipts";
            cmd = new SqlCommand(selectQuery, con);
            sqldataReader = cmd.ExecuteReader();

            if (sqldataReader.Read())
            {
                guna2TextBoxReceiptNo.Text = sqldataReader.GetValue(0).ToString() +1;
                
            }
            else
            {
                MessageBox.Show("No such student In School");
            }
            sqldataReader.Close();
            con.Close(); ;

        }

        private void guna2Buttonsearch_Click(object sender, EventArgs e)
        {
            receiptNumber();
            try
            {
                guna2TextBoxReceiptNo.Text = ReceiptNo.ToString("D8");
                ReceiptNo = Convert.ToInt16(guna2TextBoxReceiptNo.Text);
                ReceiptNo++;
                guna2TextBoxReceiptNo.Text = ReceiptNo.ToString("D8");

                con.Open();
                String selectQuery = "SELECT AdmNo,Class,Stream,Year,Term,Total_Amount FROM Student_Term Where AdmNo='" + guna2TextBoxsearch.Text + "'";                
                cmd = new SqlCommand(selectQuery, con);
                sqldataReader = cmd.ExecuteReader();

                if (sqldataReader.Read())
                {
                    guna2TextBoxAdmNo.Text = sqldataReader.GetValue(0).ToString();
                    guna2TextBoxform.Text = sqldataReader.GetValue(1).ToString();
                    guna2TextBoxstream.Text = sqldataReader.GetValue(2).ToString();
                    guna2TextBoxYear.Text = sqldataReader.GetValue(3).ToString();
                    guna2TextBoxTerm.Text = sqldataReader.GetValue(4).ToString();
                    guna2TextBoxbalance.Text = sqldataReader.GetValue(5).ToString();                  
                }
                else
                {
                    MessageBox.Show("No such student In School");
                }
                sqldataReader.Close();
               con.Close(); ;
            }
            catch (Exception emm1)
            {
                MessageBox.Show(emm1.Message);

            }
        }
    }
}
