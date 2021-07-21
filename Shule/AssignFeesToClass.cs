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
                    // guna2TextBoxTotalFee.Show();
                    // labelFID.Show();
                    // labelFIDL.Show();
                    //sum = 0;
                    //for (i = 0; i < dataGridView1.RowCount; i++)
                    //{
                    //    sum = sum + decimal.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    //    guna2TextBoxTotalFee.Text = sum.ToString();
                    //    labelFID.Text = guna2ComboBoxClass.Text + guna2ComboBoxStream.Text + guna2ComboBoxYear.Text + guna2ComboBoxTerm.Text;
                    //}

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
                    cmd = new SqlCommand("Update Student_Term Set Total_Amount=(SELECT Total_Amount From fee_Structure Where Class='" + guna2ComboBoxform.Text + "' AND Stream ='" + guna2ComboBoxStream.Text + "' AND  Year='" + guna2ComboBoxYear.Text + "' AND Term ='" + guna2ComboBoxTerm.Text + "'),Term_Fees=(SELECT Total_Amount From fee_Structure Where Class='" + guna2ComboBoxform.Text + "' AND Stream ='" + guna2ComboBoxStream.Text + "' AND  Year='" + guna2ComboBoxYear.Text + "' AND Term ='" + guna2ComboBoxTerm.Text + "') Where Class='" + guna2ComboBoxform.Text + "' AND Stream ='" + guna2ComboBoxStream.Text + "' AND  Year='" + guna2ComboBoxYear.Text + "' AND Term ='" + guna2ComboBoxTerm.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Assigned.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fields are Empty .", "Message Fail",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                  
            }
            catch (Exception emm)
            {
                MessageBox.Show(emm.Message);

            }
           
        }
    }
}
