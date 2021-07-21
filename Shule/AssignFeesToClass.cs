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
//using Microsoft.Reporting.WinForms;

namespace Shule
{
    public partial class AssignFeesToClass : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=shule;Integrated Security=True;");
        SqlCommand cmd;
       // SqlDataReader sqlReader;
       
      //  DataTable daTable1 = new DataTable();

        public AssignFeesToClass()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2ComboBoxform.Text != "" && guna2ComboBoxStream.Text != "" && guna2ComboBoxYear.Text != "" && guna2ComboBoxTerm.Text != "")
            {
                try
                {
                    con.Open();
                    
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student_Term Where Class='" + guna2ComboBoxform.Text + "' AND Stream ='" + guna2ComboBoxStream.Text + "' AND  Year='" + guna2ComboBoxYear.Text + "' AND Term ='" + guna2ComboBoxTerm.Text + "' order by StudSemID", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Student_Term");
                    dataGridView1.DataSource = ds.Tables["Student_Term"].DefaultView;
                    cmd.ExecuteNonQuery();
                    con.Close();
                 
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

        private void GenerateFeeStructure_Load(object sender, EventArgs e)
        {
                      ///this.WindowState = FormWindowState.Maximized;          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2ComboBoxform.Text != "" && guna2ComboBoxStream.Text != "" && guna2ComboBoxYear.Text != "" && guna2ComboBoxTerm.Text != "")
                {
                    con.Open();
                    cmd = new SqlCommand("Update Student_Term Set Term_Fees=(SELECT Total_Amount From fee_Structure Where Class='" + guna2ComboBoxform.Text + "' AND Stream ='" + guna2ComboBoxStream.Text + "' AND  Year='" + guna2ComboBoxYear.Text + "' AND Term ='" + guna2ComboBoxTerm.Text + "') Where Class='" + guna2ComboBoxform.Text + "' AND Stream ='" + guna2ComboBoxStream.Text + "' AND  Year='" + guna2ComboBoxYear.Text + "' AND Term ='" + guna2ComboBoxTerm.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                   // con.Close();
                    MessageBox.Show("Successfully Assigned.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student_Term Where Class='" + guna2ComboBoxform.Text + "' AND Stream ='" + guna2ComboBoxStream.Text + "' AND  Year='" + guna2ComboBoxYear.Text + "' AND Term ='" + guna2ComboBoxTerm.Text + "' order by StudSemID", con);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Student_Term");
                        dataGridView1.DataSource = ds.Tables["Student_Term"].DefaultView;
                        cmd.ExecuteNonQuery();
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
                    MessageBox.Show("Fields are Empty .", "Message Fail",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    con.Close();
                }                 
            }
            catch (Exception emm)
            {
                MessageBox.Show(emm.Message);
                con.Close();
            }         
        }
    }
}
