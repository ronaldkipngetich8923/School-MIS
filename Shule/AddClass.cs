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
    public partial class AddClass : Form
    {
        SqlConnection sqlConnection;
        public AddClass()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClassesSave_Click(object sender, EventArgs e)
        {
            string cmdStr = "INSERT INTO Classes VALUES( '" + txtClassName.Text + "')";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {
                sqlConnection.Close();
                sqlConnection.Open();
                int rows = sqlCommand.ExecuteNonQuery();

                MessageBox.Show(rows + " Class inserted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddClass_Load(object sender, EventArgs e)
        {
            string connStr = "Data Source = (localDB)\\MSSQLLocalDB;Initial Catalog = shule; Integrated Security = True";
            sqlConnection = new SqlConnection(connStr);
        }

        private void btnClassesReset_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1ViewRecords_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
            string query = "SELECT * FROM Classes";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            guna2DataGridView1Classes.DataSource = dt;

            sqlConnection.Open();

        }
    }
}

