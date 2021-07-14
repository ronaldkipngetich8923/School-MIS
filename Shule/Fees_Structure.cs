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
    public partial class Fees_Structure : Form
    {
        public Fees_Structure()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=shule;Integrated Security=True;");

       public int i { get; set; }
        public decimal sum { get; set; }
        private void guna2Button1_Click(object sender, EventArgs e)
        {           
            if (guna2ComboBoxClass.Text!="" && guna2ComboBoxStream.Text != "" && guna2ComboBoxYear.Text != "" && guna2ComboBoxTerm.Text != "" )
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT Fees_vote,Fees_Vote_Amount FROM fees_SetUp Where Form='" + guna2ComboBoxClass.Text + "' AND Stream ='" + guna2ComboBoxStream.Text + "' AND  Year='" + guna2ComboBoxYear.Text + "' AND Term ='" + guna2ComboBoxTerm.Text + "'", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "fees_setUp");
                    dataGridView1.DataSource = ds.Tables["fees_setUp"].DefaultView;
                    guna2TextBoxTotalFee.Show();
                    labelFID.Show();
                    labelFIDL.Show();
                    sum = 0;
                    for (i = 0; i < dataGridView1.RowCount; i++)
                    {
                        sum = sum + decimal.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                        guna2TextBoxTotalFee.Text = sum.ToString();
                        labelFID.Text = guna2ComboBoxClass.Text + guna2ComboBoxStream.Text + guna2ComboBoxYear.Text + guna2ComboBoxTerm.Text;
                    }

                }
                catch (Exception em)
                {
                    MessageBox.Show(em.Message);
                }
               
            }
            else
            {
                MessageBox.Show("Kindly select Form, Term, Stream, Year !!");
            }


        }

        private void Fees_Structure_Load(object sender, EventArgs e)
        {
            Student_Promotion.Visible = false;
            // this.WindowState = FormWindowState.Maximized;
            labelFID.Hide();
            labelFIDL.Hide();
            guna2TextBoxTotalFee.Hide();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2ComboBoxClass.Text != "" && guna2ComboBoxStream.Text != "" && guna2ComboBoxYear.Text != "" && guna2ComboBoxTerm.Text != "" && guna2TextBoxTotalFee.Text!="")
                {
                    SqlCommand cmd = new SqlCommand("insert into fee_Structure(Fee_StructureID,Class,Stream,Year,Term,Total_Amount) values(@FeeID,@Class,@Stream,@Year,@Term,@TotalAmount)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@FeeID", labelFID.Text);
                    cmd.Parameters.AddWithValue("@Class", guna2ComboBoxClass.Text);
                    cmd.Parameters.AddWithValue("@Stream", guna2ComboBoxStream.Text);
                    cmd.Parameters.AddWithValue("@Year", guna2ComboBoxYear.Text);
                    cmd.Parameters.AddWithValue("@Term", guna2ComboBoxTerm.Text);
                    cmd.Parameters.AddWithValue("@TotalAmount", guna2TextBoxTotalFee.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Saved");
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    guna2TextBoxTotalFee.Hide();
                    guna2TextBoxTotalFee.Hide();
                    labelFID.Text = "";
                    guna2ComboBoxClass.Text = "";
                    guna2ComboBoxStream.Text = "";
                    guna2ComboBoxYear.Text = "";
                    guna2ComboBoxTerm.Text = "";                  
                    con.Close();
                }
                else
                {
                    MessageBox.Show(" Kindly Check if ALL fields are Filled !!");

                }
            }
            catch 
            {
                MessageBox.Show("Please Chemosi, Fees structure already Exist!!");
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                guna2TextBoxTotalFee.Hide();
                labelFID.Text="";
                guna2ComboBoxClass.Text="";
                guna2ComboBoxStream.Text="";
                guna2ComboBoxYear.Text="";
                guna2ComboBoxTerm.Text="";
                guna2TextBoxTotalFee.Text="";

            }
           
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFeeStructure frm = new AddFeeStructure();
            frm.Show();
            
        }
    }
}
