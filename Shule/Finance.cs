using System;
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
    public partial class Finance : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=shule;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataReader sqlReader;
        int ReceiptNo = 1;

        public Finance()
        {
            InitializeComponent();
        }

        private void guna2Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (guna2TextBoxAdmNo.Text != "" && guna2TextBoxStudname.Text != "" && guna2TextBoxform.Text != "" && guna2TextBoxstream.Text != "" && guna2TextBoxbalance.Text != "" && guna2TextBoxAmount.Text != "" && guna2TextBoxReceivedBy.Text != "" && guna2TextBoxReceiptNo.Text != "")
            {
                cmd = new SqlCommand("insert into fee_receipts(AdmNo,Studname,Form,Stream,Balance,AmountReceived,ReceivedBy,ReceiptNo,DateReceived) values(@AdmNo,@Studname,@Form,@Stream,@Balance,@AmountReceived,@ReceivedBy,@ReceiptNo,@DateReceived)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@AdmNo", guna2TextBoxAdmNo.Text);
                cmd.Parameters.AddWithValue("@Studname", guna2TextBoxStudname.Text);
                cmd.Parameters.AddWithValue("@Form", guna2TextBoxform.Text);
                cmd.Parameters.AddWithValue("@Stream", guna2TextBoxstream.Text);
                cmd.Parameters.AddWithValue("@Balance", guna2TextBoxbalance.Text);
                cmd.Parameters.AddWithValue("@AmountReceived", guna2TextBoxAmount.Text);
                cmd.Parameters.AddWithValue("@ReceivedBy", guna2TextBoxReceivedBy.Text);
                cmd.Parameters.AddWithValue("@ReceiptNo", guna2TextBoxReceiptNo.Text);
                cmd.Parameters.AddWithValue("@DateReceived", dateTimePickerReceipt.Value);


                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Fees Receipt Generated Successfully");

                guna2TextBoxsearch.Text = "";
                guna2TextBoxAdmNo.Text = "";
                guna2TextBoxStudname.Text = "";
                guna2TextBoxform.Text = "";
                guna2TextBoxstream.Text = "";
                guna2TextBoxbalance.Text ="";
                guna2TextBoxAmount.Text = "";
            }
            else
            {

                MessageBox.Show("Please Provide All Details!");

            }



        }

        private void Finance_Load(object sender, EventArgs e)
        {
            feesreceiptpanel.Visible = true;
            transferfeepanel.Visible = false; ;
            feesadjustmentpanel.Visible = false;
            this.WindowState = FormWindowState.Maximized;


            guna2TextBoxReceiptNo.Text = ReceiptNo.ToString("D5");
            ReceiptNo = Convert.ToInt16(guna2TextBoxReceiptNo.Text);
            ReceiptNo++;
            guna2TextBoxReceiptNo.Text = ReceiptNo.ToString("D5");



        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            feesreceiptpanel.Visible = true;
            transferfeepanel.Visible = false; ;
            feesadjustmentpanel.Visible = false;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            feesreceiptpanel.Visible = false;
            transferfeepanel.Visible = true;
            feesadjustmentpanel.Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            feesreceiptpanel.Visible = false;
            transferfeepanel.Visible = false;
            feesadjustmentpanel.Visible = true;

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //ReceiptNo++;

            if (guna2TextBoxAdmNoT.Text != "" && guna2TextBoxStudnameT.Text != "" && guna2TextBoxAmtAvaT.Text != "" && guna2TextBoxAmtTt.Text != "" && guna2TextBoxAdmNoTT.Text != "" && guna2TextBoxStudnameTT.Text != "" && textBoxAmtTt.Text != "" && richTextBoxReason.Text != "")
            {
                cmd = new SqlCommand("insert into fees_transfer(AdmNoTransferFrom,StudnameTransferFrom,Amt_available,Amt_transfer,AdmNoTransferTo,StudnameTransferTo,AmtTransfered,ReasonForFeesTransfer) values (@AdmNoTransferFrom,@StudnameTransferFrom,@Amt_available,@Amt_transfer,@AdmNoTransferTo,@StudnameTransferTo,@AmtTransfered,@ReasonForFeesTransfer)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@AdmNoTransferFrom", guna2TextBoxAdmNoT.Text);
                cmd.Parameters.AddWithValue("@StudnameTransferFrom", guna2TextBoxStudnameT.Text);
                cmd.Parameters.AddWithValue("@Amt_available", guna2TextBoxAmtAvaT.Text);
                cmd.Parameters.AddWithValue("@Amt_transfer", guna2TextBoxAmtTt.Text);
                cmd.Parameters.AddWithValue("@AdmNoTransferTo", guna2TextBoxAdmNoTT.Text);
                cmd.Parameters.AddWithValue("@StudnameTransferTo", guna2TextBoxStudnameTT.Text);
                cmd.Parameters.AddWithValue("@AmtTransfered", textBoxAmtTt.Text);
                cmd.Parameters.AddWithValue("@ReasonForFeesTransfer", richTextBoxReason.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Fees Has Been Transfered Successfully");

                guna2TextBoxAdmNoT.Text ="";
                guna2TextBoxStudnameT.Text = "";
                guna2TextBoxAmtAvaT.Text = "";
                guna2TextBoxAmtTt.Text = "";
                guna2TextBoxAdmNoTT.Text = "";
                guna2TextBoxStudnameTT.Text = "";
                textBoxAmtTt.Text = "";
                richTextBoxReason.Text = "";

            }
            else
            {

                MessageBox.Show("Please Provide All Details!");

            }


        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            AddFeeStructure fs = new AddFeeStructure();
            fs.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2TextBoxReceiptNo.Text = ReceiptNo.ToString("D5");
            ReceiptNo = Convert.ToInt16(guna2TextBoxReceiptNo.Text);
            ReceiptNo++;
            guna2TextBoxReceiptNo.Text = ReceiptNo.ToString("D5");

            con.Open();
            String selectQuery = "SELECT * FROM StudentMaster where AdmNo=" + int.Parse(guna2TextBoxsearch.Text);
            cmd = new SqlCommand(selectQuery, con);
            sqlReader = cmd.ExecuteReader();

            if (sqlReader.Read())
            {
                guna2TextBoxAdmNo.Text = sqlReader.GetValue(1).ToString();
                guna2TextBoxStudname.Text = sqlReader.GetValue(2).ToString();
                guna2TextBoxform.Text = sqlReader.GetValue(10).ToString();
                guna2TextBoxstream.Text = sqlReader.GetValue(11).ToString();

               // textBoxroomNo.Text = sqlReader.GetValue(5).ToString();

            }
            else
            {
                MessageBox.Show("No such student In School");
            }

            con.Close();
        }

        private void toppanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
