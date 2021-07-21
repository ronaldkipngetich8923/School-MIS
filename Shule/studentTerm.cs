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
    public partial class studentTerm : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source = (localDB)\\MSSQLLocalDB;Initial Catalog = shule; Integrated Security = True");
        SqlDataReader sqlDataReader;

        public studentTerm()
        {
            InitializeComponent();
            ComboclassFill();
            ComboTermFill();
            ComboyearFill();
            ComboStreamFill();
        }
        
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void studentTerm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
           // ComboclassFill();
           // ComboTermFill();
           // ComboyearFill();
        }

        public void ComboclassFill()
        {
            string cmdStr = " SELECT *  FROM Classes";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {
                sqlConnection.Open();

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["ClassName"].ToString();

                    comboBoxclass.Items.Add(sName);
                    guna2ComboBox6.Items.Add(sName);
                    guna2ComboBox11.Items.Add(sName);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }

        public void ComboyearFill()
        {
            string cmdStr = " SELECT *  FROM Year";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {
                sqlConnection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["Year"].ToString();
                    guna2ComboBox1.Items.Add(sName);
                    guna2ComboBox5.Items.Add(sName);
                    guna2ComboBox13.Items.Add(sName);
                    guna2ComboBox10.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }

        public void ComboTermFill()
        {
            string cmdStr = " SELECT *  FROM Term";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {
                sqlConnection.Open();

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["Term"].ToString();

                    guna2ComboBox2.Items.Add(sName);
                    guna2ComboBox4.Items.Add(sName);
                    guna2ComboBox12.Items.Add(sName);
                    guna2ComboBox9.Items.Add(sName);
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }
        public void ComboStreamFill()
        {
            string cmdStr = " SELECT *  FROM Streams";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {
                sqlConnection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["StreamName"].ToString();

                    guna2ComboBox7.Items.Add(sName);
                    guna2ComboBox3.Items.Add(sName);
                    guna2ComboBox8.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }

        private void btnStreamsSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxclass.SelectedItem != null && guna2ComboBox7.SelectedItem != null && guna2ComboBox1.SelectedItem != null && guna2ComboBox4.SelectedItem != null)
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("Update Student_Term SET Term_Fees=Term_Fees+(Select sum(Fees_Vote_Amount)As Total_Amount From fees_SetUp Where Class='" + guna2ComboBox6.Text + "' AND Stream='" + guna2ComboBox3.Text + "' AND Year='" + guna2ComboBox5.Text + "' AND Term='" + guna2ComboBox2.Text + "'),Class='" + guna2ComboBox6.Text + "',Stream='" + guna2ComboBox3.Text + "',Year='" + guna2ComboBox5.Text + "',Term='" + guna2ComboBox2.Text + "' Where Class='" + comboBoxclass.Text + "' AND Stream='" + guna2ComboBox7.Text + "' AND Year='" + guna2ComboBox1.Text + "' AND Term='" + guna2ComboBox4.Text + "'", sqlConnection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Students Promoted Successfully.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlConnection.Close();

                    try
                    {
                        string query = "SELECT * FROM Student_Term";
                        SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                        DataTable dt = new DataTable();
                        SDA.Fill(dt);
                        guna2DataGridView1Streams.DataSource = dt;
                        sqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    comboBoxclass.SelectedItem = null;
                    guna2ComboBox7.SelectedItem = null;
                    guna2ComboBox1.SelectedItem = null;
                    guna2ComboBox4.SelectedItem = null;
                    guna2ComboBox6.SelectedItem = null;
                    guna2ComboBox3.SelectedItem = null;
                    guna2ComboBox5.SelectedItem = null;
                    guna2ComboBox2.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show("Kindly Select Formstream, year and Term.", "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void guna2Button1ViewClass_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Student_Term";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                guna2DataGridView1Streams.DataSource = dt;
                sqlConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClassesRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Student_Term";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                guna2DataGridView1Streams.DataSource = dt;
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
