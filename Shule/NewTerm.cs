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
    public partial class NewTerm : Form
    {
        public NewTerm()
        {
            InitializeComponent();
        }


        SqlConnection sqlConnection = new SqlConnection("Data Source = (localDB)\\MSSQLLocalDB;Initial Catalog = shule; Integrated Security = True");


        private void btnStreamsSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTermName.Text != "")
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Term(Term) Values(@Term)", sqlConnection);
                    cmd.Parameters.AddWithValue("@Term", txtTermName.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Term Saved Successfully.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTermName.Text = "";
                    sqlConnection.Close();
                }
                else
                {
                    MessageBox.Show("Enter Term to Save.","Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button1ViewClass_Click(object sender, EventArgs e)
        {

            string query = "SELECT * FROM Term";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            guna2DataGridView1Year.DataSource = dt;
            sqlConnection.Close();
        }

        private void btnClassesRefresh_Click(object sender, EventArgs e)
        {

            string query = "SELECT * FROM Term";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            guna2DataGridView1Year.DataSource = dt;
            sqlConnection.Close();
        }

        private void btnStreamsReset_Click(object sender, EventArgs e)
        {
            txtTermName.Text = "";
        }
    }
}
