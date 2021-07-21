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
    public partial class NewYear : Form
    {
        public NewYear()
        {
            InitializeComponent();
        }


        SqlConnection sqlConnection = new SqlConnection("Data Source = (localDB)\\MSSQLLocalDB;Initial Catalog = shule; Integrated Security = True");

        private void btnStreamsReset_Click(object sender, EventArgs e)
        {
            txtYearName.Text = "";
        }

        private void btnStreamsSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtYearName.Text != "")
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Year(Year) Values(@Year)", sqlConnection);
                    cmd.Parameters.AddWithValue("@Year", txtYearName.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Year added Successfully.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtYearName.Text = "";
                    sqlConnection.Close();
                }
                else
                {
                    MessageBox.Show("Enter Year to Save.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnection.Close();
            }
        }

        private void guna2Button1ViewClass_Click(object sender, EventArgs e)
        {
           
            string query = "SELECT * FROM Year";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            guna2DataGridView1Year.DataSource = dt;
            sqlConnection.Close();
        }

        private void btnClassesRefresh_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string query = "SELECT * FROM Year";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            guna2DataGridView1Year.DataSource = dt;
            sqlConnection.Close();
        }
    }
}
