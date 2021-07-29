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
    public partial class Dispensary : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=shule;Integrated Security=True;");
        SqlCommand cmd;
        //SqlConnection sqlConnection;
        SqlDataReader sqlDataReader;
        SqlDataAdapter sqlDataAdapter;
        DataSet ds;
        public Dispensary()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Dispensary_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateHostel_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchMedic_Click(object sender, EventArgs e)
        {
            if (txtMedicAdm.Text != "")
            {
                //sqlConnection.Close();
                sqlConnection.Open();
                string query = "SELECT * FROM StudentMaster where AdmNo = '" + txtMedicAdm.Text+ "'";
                cmd = new SqlCommand(query, sqlConnection);
                sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    txtMedicAdmNo.Text = sqlDataReader.GetValue(0).ToString();
                    txtMedicName.Text = sqlDataReader.GetValue(1).ToString();
                    txtMedicForm.Text = sqlDataReader.GetValue(9).ToString();
                    txtMedicStream.Text = sqlDataReader.GetValue(10).ToString();
                }

                else
                {
                    MessageBox.Show("Student Not Registered.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
               
            }

            else
            {
                MessageBox.Show("Search Box Is Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            sqlConnection.Close();

        }

        private void txtMedicStream_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMedicSave_Click(object sender, EventArgs e)
        {
            if (txtMedicAdmNo.Text != "" && txtMedicAdm.Text != "")
            {
                string qur = "INSERT INTO Dispensary (AdmNo,DateOfAdmit,Complain,Medication) VALUES ('" + txtMedicAdmNo.Text + "','" + guna2DateTimePicker1.Text + "','" + richTextBoxComplain.Text + "','" + richTextBox2Medication.Text + "')";
                SqlCommand cmd = new SqlCommand(qur, sqlConnection);
                try
                {

                    sqlConnection.Open();
                    int rows = cmd.ExecuteNonQuery();

                    MessageBox.Show(" Record Added Successfully.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
            else
            {
                MessageBox.Show(" Field Admission Number Cannot be Empty.", "Warnig", MessageBoxButtons.OK, MessageBoxIcon.Warning);



            }
            sqlConnection.Close();
        }

            private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMedicReset_Click(object sender, EventArgs e)
        {
            txtMedicAdmNo.Clear();
            txtMedicName.Clear();
            txtMedicForm.Clear();
            txtMedicStream.Clear();
            richTextBoxComplain.Clear();
            richTextBox2Medication.Clear(); 
        }

        private void guna2Button1ViewMedicInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMedicAdmNo.Text!="")
                {
                    string query = "SELECT * FROM Dispensary where AdmNo='" + txtMedicAdmNo.Text + "'";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                    DataTable dt = new DataTable();
                    sqlDataAdapter.Fill(dt);
                    guna2DataGridView1ClinicSection.DataSource = dt;

                }
                else 
                {
                    string query = "SELECT * FROM Dispensary ";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                    DataTable dt = new DataTable();
                    sqlDataAdapter.Fill(dt);
                    guna2DataGridView1ClinicSection.DataSource = dt.DefaultView;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}
