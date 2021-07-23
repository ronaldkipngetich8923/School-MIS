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
    public partial class Print_Receipt : Form
    {
        public Print_Receipt()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=shule;Integrated Security=True;");

        SqlCommand cmd = new SqlCommand();
        SqlDataReader sqldataReader;
        private void guna2Buttonsearch_Click(object sender, EventArgs e)
        {
            if (guna2TextBoxsearch.Text!="")
            {
                try
                {
                    Text_Receipt.Visible = true;
                    con.Open();
                    string querry = "Select * FROM fee_receipts where AdmNo='" + guna2TextBoxsearch.Text + "' AND ReceiptNo=(Select max(ReceiptNo)FROM fee_receipts where AdmNo='" + guna2TextBoxsearch.Text + "')";

                    cmd = new SqlCommand(querry, con);
                    // sqldataReader.
                    sqldataReader = cmd.ExecuteReader();

                    string str = "Thank You. Welcome Again.";
                    if (sqldataReader.Read())
                    {
                        Text_Receipt.Text = $"{"\nChebunyo High School\n\n FEES RECEIPT\n"}" +
                            $"{"..............................................................."}\r\n"+
                            $"{"Receipt No:"} {sqldataReader.GetInt32(sqldataReader.GetOrdinal("ReceiptNo")).ToString()}\r\n " +
                            $"{"Adm No:"} {sqldataReader.GetString(sqldataReader.GetOrdinal("AdmNo")).ToString()}\r\n" +
                            $"{"Form :"} {sqldataReader.GetString(sqldataReader.GetOrdinal("Form")).ToString()}\r\n" +
                            $"{"Stream :"} {sqldataReader.GetString(sqldataReader.GetOrdinal("Stream")).ToString()}\r\n " +
                            $"{"Amount Paid: Ksh."} {sqldataReader.GetDecimal(sqldataReader.GetOrdinal("AmountReceived")).ToString()}\r\n" +
                            $"{"Balance : Ksh."} {sqldataReader.GetDecimal(sqldataReader.GetOrdinal("Running_Balance")).ToString()}\r\n " +
                            $"{"Date Received No:"} {sqldataReader.GetDateTime(sqldataReader.GetOrdinal("DateReceived")).ToString()}\r\n " +
                            $"{"Received By:"} {sqldataReader.GetString(sqldataReader.GetOrdinal("ReceivedBy")).ToString()}\r\n" +
                            $"{""}\r\n" +
                            $"{"Signaturre: "} {".................."}\r\n" +
                            $"{"Printed on:"} {DateTime.Now.ToString()}\r\n" +
                            $"{""}\r\n" +
                            $"{""}\r\n" +
                            $"{ str}";
                        
                        Text_Receipt.SelectAll();
                        Text_Receipt.SelectionAlignment = HorizontalAlignment.Center;
                        Text_Receipt.SelectionColor = Color.Black;
                        Text_Receipt.SelectionFont = new Font("MS Reference Sans Serif", 12); ;
                        Text_Receipt.DeselectAll();
                        sqldataReader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Student has never paid any Fees Yet.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    sqldataReader.Close();
                    con.Close(); ;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Enter Admission No.","Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           
        }
        public new System.Windows.Forms.FormStartPosition StartPosition { get; set; }
        private void Print_Receipt_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            Text_Receipt.Text = "\nChebunyo Boys High School\n\n" +
                "Fees Receipt\n";

            Text_Receipt.SelectAll();
            Text_Receipt.SelectionAlignment = HorizontalAlignment.Center;
            Text_Receipt.SelectionColor = Color.Black;
            Text_Receipt.SelectionFont = new Font("MS Reference Sans Serif", 16); ;
            Text_Receipt.DeselectAll();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat formatLeft = new StringFormat(StringFormatFlags.NoClip);
            StringFormat formatCenter = new StringFormat(formatLeft);
            formatCenter.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(Text_Receipt.Text, new Font("Courier New", 12, FontStyle.Regular), Brushes.Black, new Point(10, 10));
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
