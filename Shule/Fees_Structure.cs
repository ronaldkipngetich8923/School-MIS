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

        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            decimal sum1; 
            int i;
            if (guna2ComboBoxClass.SelectedItem!=null && guna2ComboBoxStream.SelectedItem!= null && guna2ComboBoxYear.SelectedItem != null && guna2ComboBoxTerm.SelectedItem != null && labelFID.Text!="")
            {
                try
                {
                    string query = "SELECT Fees_vote, Fees_Vote_Amount FROM fees_SetUp Where Form = '" + guna2ComboBoxClass.Text + "' AND Stream = '" + guna2ComboBoxStream.Text + "' AND Year = '" + guna2ComboBoxYear.Text + "' AND Term = '" + guna2ComboBoxTerm.Text + "'";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    SDA.Fill(dt);
                    dataGridView1.DataSource = dt;
                    guna2TextBoxTotalFee.Show();
                    labelFID.Show();
                    labelFIDL.Show();
                    decimal sum = 0;
                    for (i = 0; i <= dataGridView1.RowCount; i++)
                    {
                        sum1 = sum + decimal.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                        guna2TextBoxTotalFee.Text = sum1.ToString();
                        labelFID.Text = guna2ComboBoxClass.Text + guna2ComboBoxStream.Text + guna2ComboBoxYear.Text + guna2ComboBoxTerm.Text;
                    }
                    con.Close();
                }
                catch (Exception em)
                {
                    MessageBox.Show(em.Message);
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Kindly select Form, Term, Stream, Year !!");
                con.Close();
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
                if (guna2ComboBoxClass.Text != "" && guna2ComboBoxStream.Text != "" && guna2ComboBoxYear.Text != "" && guna2ComboBoxTerm.Text != "" && guna2TextBoxTotalFee.Text!="" && labelFID.Text!="")
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

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssignFeesToClass af = new AssignFeesToClass();
            af.Show();
           
        }
    }
}
