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
    public partial class StaffType : Form
    {
        SqlConnection sqlConnection;
        SqlDataReader sqlDataReader;
        public StaffType()
        {
            InitializeComponent();
        }

        private void btnStaffInfoSave_Click(object sender, EventArgs e)
        {
            string cmdStr = "INSERT INTO StaffDescription(StaffCode,StaffDescription) VALUES('" + txtStaffCode.Text + "', '" + txtStaffDescription.Text + "')";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {
                sqlConnection.Close();
                sqlConnection.Open();
                int rows = sqlCommand.ExecuteNonQuery();

                MessageBox.Show(rows + " StaffType inserted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
            string query = "SELECT * FROM StaffDescription";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            guna2DataGridView1StaffType.DataSource = dt;

            sqlConnection.Open();

        }

        private void StaffType_Load(object sender, EventArgs e)
        {
            string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            sqlConnection = new SqlConnection(connStr);
        }
    }
}
