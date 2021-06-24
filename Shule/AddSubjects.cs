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
    public partial class AddSubjects : Form
    {
        SqlConnection sqlConnection;
        SqlDataReader sqlDataReader;
        public AddSubjects()
        {
            InitializeComponent();
            CombosubjectFill();

        }
        public void CombosubjectFill()
        {
            string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            sqlConnection = new SqlConnection(connStr);
            string cmdStr = " SELECT *  FROM Subject";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {

                sqlConnection.Open();

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["SubjectDescription"].ToString();

                  //  conboBoxSetBy.Items.Add(sName);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSubjectCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubjectInfoSave_Click(object sender, EventArgs e)
        {
            string cmdStr = "INSERT INTO Subject VALUES( '" + txtSubjectCode.Text + "','" + txtSubjectDescription.Text + "')";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {
                sqlConnection.Close();
                sqlConnection.Open();
                int rows = sqlCommand.ExecuteNonQuery();

                MessageBox.Show(rows + " Subject inserted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddSubjects_Load(object sender, EventArgs e)
        {
            string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            sqlConnection = new SqlConnection(connStr);
        }

        private void btnSubjectSave_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
            string query = "SELECT * FROM Subject";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            guna2DataGridView1SubjectType.DataSource = dt;

            sqlConnection.Open();
        }
    }
}
