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
            menupanel.Visible = true;
            
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

        public void receiptNumber()
        {
           
        }

        private void guna2Buttonsearch_Click(object sender, EventArgs e)
        {
            if (guna2Buttonsearch.Text != "")
            {
                con.Open();

                String selectQuery = "SELECT AdmNo,Class,Stream,Year,Term,Total_Amount FROM Student_Term Where AdmNo='" + guna2TextBoxsearch.Text + "'";
                cmd = new SqlCommand(selectQuery, con);
               // sqldataReader.
                sqldataReader = cmd.ExecuteReader();

                if (sqldataReader.Read())
                {
                    guna2TextBoxAdmNo.Text = sqldataReader.GetValue(0).ToString();
                    guna2TextBoxform.Text = sqldataReader.GetValue(1).ToString();
                    guna2TextBoxstream.Text = sqldataReader.GetValue(2).ToString();
                    guna2TextBoxYear.Text = sqldataReader.GetValue(3).ToString();
                    guna2TextBoxTerm.Text = sqldataReader.GetValue(4).ToString();
                    guna2TextBoxbalance.Text = sqldataReader.GetValue(5).ToString();
                   // guna2TextBoxReceiptNo.Text = ;

                    sqldataReader.Close();
                }
                else
                {
                    MessageBox.Show("No such student In School");
                }
                sqldataReader.Close();
                con.Close(); ;
            }
            else
            {
                MessageBox.Show("Admission Number Cannot be empty.");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2TextBoxsearch.Text != "")
                {
                    decimal diff;
                    if (guna2TextBoxAdmNo.Text != "" && guna2TextBoxYear.Text != "" && guna2TextBoxform.Text != "" && guna2TextBoxstream.Text != "" && guna2TextBoxbalance.Text != "" && guna2TextBoxAmount.Text != "" && guna2TextBoxReceivedBy.Text != "")
                    {
                        cmd = new SqlCommand("insert into fee_receipts(AdmNo,Form,Stream,Year,Term,AmountReceived,Running_balance,DateReceived,ReceivedBy) values(@AdmNo,@Form,@Stream,@Year,@Term,@AmountReceived,@Running_balance,@DateReceived,@ReceivedBy)", con);
                        diff = Convert.ToDecimal(guna2TextBoxbalance.Text.ToString()) - Convert.ToDecimal(guna2TextBoxAmount.Text.ToString());

                        con.Open();
                        cmd.Parameters.AddWithValue("@AdmNo", guna2TextBoxAdmNo.Text);
                        cmd.Parameters.AddWithValue("@Form", guna2TextBoxform.Text);
                        cmd.Parameters.AddWithValue("@Stream", guna2TextBoxstream.Text);
                        cmd.Parameters.AddWithValue("@Year", guna2TextBoxform.Text);
                        cmd.Parameters.AddWithValue("@Term", guna2TextBoxstream.Text);
                        cmd.Parameters.AddWithValue("@AmountReceived", guna2TextBoxAmount.Text);
                        cmd.Parameters.AddWithValue("@Running_balance", diff);
                        cmd.Parameters.AddWithValue("@DateReceived", dateTimePickerReceipt.Value);
                        cmd.Parameters.AddWithValue("@ReceivedBy", guna2TextBoxReceivedBy.Text);
                        cmd.ExecuteNonQuery();

                        SqlCommand cmd6 = new SqlCommand("Update Student_Term SET Total_Amount= (Select Running_balance From fee_receipts  Where AdmNo ='" + guna2TextBoxAdmNo.Text + "' AND ReceiptNo =(Select Max(ReceiptNo) AS ReceiptNo From fee_receipts Where AdmNo='" + guna2TextBoxAdmNo.Text + "' ) ) Where AdmNo ='" + guna2TextBoxAdmNo.Text + "'", con);
                        cmd6.ExecuteNonQuery();

                        MessageBox.Show("Fees Received Successfully");
                        guna2TextBoxsearch.Text = "";
                        guna2TextBoxAdmNo.Text = "";
                        guna2TextBoxform.Text = "";
                        guna2TextBoxstream.Text = "";
                        guna2TextBoxbalance.Text = "";
                        guna2TextBoxTerm.Text = "";
                        guna2TextBoxAmount.Text = "";
                        guna2TextBoxYear.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Please Provide All Details!");
                    }
                    sqldataReader.Close();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Enter AdmNo and Search", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            guna2TextBoxsearch.Text = "";
            guna2TextBoxAdmNo.Text = "";
            guna2TextBoxform.Text = "";
            guna2TextBoxstream.Text = "";
            guna2TextBoxbalance.Text = "";
            guna2TextBoxAmount.Text = "";
        }
        

        private void transferfeepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2TextBoxsearch.Text!="")
                {
                    con.Open();
                   // SELECT Orders.OrderID, Customers.CustomerName FROM Orders INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID;

                    String selectQuery = "SELECT Running_balance FROM fee_receipts  Where AdmNo='" + guna2TextBoxAdmNo.Text + "' AND ReceiptNo =(Select Max(ReceiptNo) AS ReceiptNo From fee_Receipts Where AdmNo='" + guna2TextBoxsearch.Text + "')";
                    cmd = new SqlCommand(selectQuery, con);
                    sqldataReader = cmd.ExecuteReader();

                    if (sqldataReader.Read())
                    {
                        guna2TextBoxAdmNoT.Text = guna2TextBoxsearch.Text.ToString();
                        decimal val;
                        val =Convert.ToDecimal(sqldataReader.GetValue(0).ToString());
                        if (val<0)
                        {
                            val = val / -1;
                            guna2TextBoxAmtAvaT.Text = val.ToString();
                            con.Close();
                        }
                        else
                        {
                            guna2TextBoxAmtAvaT.Text = 0.ToString();
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No such student In School");
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("");
                    con.Close();
                }
            }
            catch (Exception ee1)
            {
                MessageBox.Show(ee1.Message);
                con.Close();
            }
        }

        private void guna2Button14_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM fee_receipts ORDER BY DateReceived Desc";
                SqlDataAdapter d = new SqlDataAdapter(query, con);
                DataTable t = new DataTable();
                d.Fill(t);
                gridReceipts.DataSource = t;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void guna2Buttonfeestransfer_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (guna2TextBoxAdmNoTT.Text != "" && richTextBoxReason.Text != "" && guna2TextBoxStudnameTT.Text != "" && textBoxAmtTt.Text != "" && guna2TextBoxAdmNoT.Text != "" && guna2TextBoxStudnameT.Text != "" && guna2TextBoxAmtAvaT.Text != "")
                {
                    decimal val1 = Convert.ToDecimal(guna2TextBoxAmtAvaT.Text.ToString());
                    decimal val2 = Convert.ToDecimal(textBoxAmtTt.Text.ToString());
                    if (val1 >= val2)
                    {
                        con.Open();
                        cmd = new SqlCommand("Insert into fees_transfer(AdmNoTransferFrom,StudnameTransferFrom,Amt_available,AdmNoTransferTo,StudnameTransferTo,AmtTransfered,ReasonForFeesTransfer,FeeTransferdate) values(@AdmNoTransferFrom,@StudnameTransferFrom,@Amt_available,@AdmNoTransferTo,@StudnameTransferTo,@AmtTransfered,@ReasonForFeesTransfer,@FeeTransferdate)", con);
                        cmd.Parameters.AddWithValue("@AdmNoTransferFrom", guna2TextBoxAdmNoT.Text);
                        cmd.Parameters.AddWithValue("@StudnameTransferFrom", guna2TextBoxStudnameT.Text);
                        cmd.Parameters.AddWithValue("@Amt_available", guna2TextBoxAmtAvaT.Text);
                        cmd.Parameters.AddWithValue("@AdmNoTransferTo", guna2TextBoxAdmNoTT.Text);
                        cmd.Parameters.AddWithValue("@StudnameTransferTo", guna2TextBoxStudnameTT.Text);
                        cmd.Parameters.AddWithValue("@AmtTransfered", textBoxAmtTt.Text);
                        cmd.Parameters.AddWithValue("@ReasonForFeesTransfer", richTextBoxReason.Text);
                        cmd.Parameters.AddWithValue("@FeeTransferdate", dateTimePickerReceipt.Value);
                        cmd.ExecuteNonQuery();

                        ////Update Fees Running Balances in fees Receipting for student transferred to

                        SqlCommand cmd1 = new SqlCommand("Update fee_receipts Set Running_balance=(Running_balance-'" + textBoxAmtTt.Text + "') Where AdmNo='" + guna2TextBoxAdmNoTT.Text + "' AND ReceiptNo=(Select Max(ReceiptNo)From fee_receipts Where AdmNo='" + guna2TextBoxAdmNoTT.Text + "')", con);
                        cmd1.ExecuteNonQuery();

                        ////Update Fees Running Balances in fees Receipting for student transfering fees
                        SqlCommand cmd3 = new SqlCommand("Update fee_receipts Set Running_balance=(Running_balance+'" + textBoxAmtTt.Text + "') Where AdmNo='" + guna2TextBoxAdmNoT.Text + "' AND ReceiptNo=(Select Max(ReceiptNo)From fee_receipts Where AdmNo='" + guna2TextBoxAdmNoT.Text + "')", con);
                        cmd3.ExecuteNonQuery();

                        // Update student_Term for a specific student registered for that term.
                        SqlCommand cmd2 = new SqlCommand("Update Student_Term SET Total_Amount= (Select Running_balance From fee_receipts  Where AdmNo ='" + guna2TextBoxAdmNoTT.Text + "' AND ReceiptNo =(Select Max(ReceiptNo) AS ReceiptNo From fee_Receipts Where AdmNo='" + guna2TextBoxAdmNoTT.Text + "') ) Where AdmNo ='" + guna2TextBoxAdmNoTT.Text + "'", con);
                        cmd2.ExecuteNonQuery();

                        // Update student_Term for a specific student registered for that term.
                        SqlCommand cmd4 = new SqlCommand("Update Student_Term SET Total_Amount= (Select Running_balance From fee_receipts  Where AdmNo ='" + guna2TextBoxAdmNoT.Text + "' AND ReceiptNo =(Select Max(ReceiptNo) AS ReceiptNo From fee_Receipts Where AdmNo='" + guna2TextBoxAdmNoT.Text + "') ) Where AdmNo ='" + guna2TextBoxAdmNoT.Text + "'", con);
                        cmd4.ExecuteNonQuery();

                        MessageBox.Show("Fees Transfered Successfully.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cannot Transfer Fees more than available Fees Amount", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Provide All Details.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                con.Close();
            }
        }

        private void guna2Button15_Click_1(object sender, EventArgs e)
        {
            dateTimePickerTrnasfer.Value = DateTime.Now;
            try
            {
                if (guna2TextBox1.Text != "")
                {
                    con.Open();
                    // SELECT Orders.OrderID, Customers.CustomerName FROM Orders INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID;

                    String selectQuery = "SELECT Running_balance FROM fee_receipts  Where AdmNo='" + guna2TextBox1.Text + "' AND ReceiptNo =(Select Max(ReceiptNo) AS ReceiptNo From fee_Receipts Where AdmNo='" + guna2TextBox1.Text + "')";
                    cmd = new SqlCommand(selectQuery, con);
                    sqldataReader = cmd.ExecuteReader();

                    if (sqldataReader.Read())
                    {
                        guna2TextBoxAdmNoT.Text = guna2TextBox1.Text.ToString();
                        decimal val;
                        val = Convert.ToDecimal(sqldataReader.GetValue(0).ToString());
                        if (val < 0)
                        {
                            val = val / -1;
                            guna2TextBoxAmtAvaT.Text = val.ToString();
                            con.Close();
                        }
                        else
                        {
                            guna2TextBoxAmtAvaT.Text = 0.ToString();
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No such student In School");
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("");
                    con.Close();
                }
            }
            catch (Exception ee1)
            {
                MessageBox.Show(ee1.Message);
                con.Close();
            }

        }

        private void guna2Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button16_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM fees_transfer ORDER BY FeeTransferdate Desc";
                SqlDataAdapter d = new SqlDataAdapter(query, con);
                DataTable t = new DataTable();
                d.Fill(t);
                gridtransferview.DataSource = t;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void toppanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
