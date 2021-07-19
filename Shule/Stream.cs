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
    public partial class Stream : Form
    {
        SqlConnection sqlConnection =new SqlConnection("Data Source = (localDB)\\MSSQLLocalDB;Initial Catalog = shule; Integrated Security = True");

        public Stream()
        {
            InitializeComponent();
        }

        private void btnStreamsSave_Click(object sender, EventArgs e)
        {

            string cmdStr = "INSERT INTO Streams  VALUES( '" + txtStreamCode.Text + "','" + txtStreamName.Text + "')";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {
                sqlConnection.Close();
                sqlConnection.Open();
                int rows = sqlCommand.ExecuteNonQuery();

                MessageBox.Show(rows + " Streams inserted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Stream_Load(object sender, EventArgs e)
        {
           // string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            //sqlConnection = new SqlConnection(connStr);
        }

        private void guna2Button1ViewClass_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
            string query = "SELECT * FROM Streams";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            guna2DataGridView1Streams.DataSource = dt;

            sqlConnection.Open();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
