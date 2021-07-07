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
    public partial class AddHostel : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=shule;Integrated Security=True;");
        SqlCommand cmd;
        SqlConnection sqlConnection;
        SqlDataReader sqlDataReader;
        SqlDataAdapter sqlDataAdapter;
        DataSet ds;

        public AddHostel()
        {
            InitializeComponent();
            StudentFill();
            TeacherFill();
        }
        public void StudentFill()
        {
            string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            sqlConnection = new SqlConnection(connStr);
            string cmdStr = " SELECT *  FROM StudentMaster";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {

                sqlConnection.Open();

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["Studname"].ToString();

                    comboHostelSassigned.Items.Add(sName);



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }


        public void TeacherFill()
        {
            string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            sqlConnection = new SqlConnection(connStr);
            string cmdStr = " SELECT *  FROM TeachersTable";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {

                sqlConnection.Open();

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["StaffId"].ToString();

                    comboHostelTAssigned.Items.Add(sName);
                   


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }sqlConnection.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddHostel_Load(object sender, EventArgs e)
        {
            ////SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM hostel",con);
            ////DataSet ds = new DataSet();
            ////da.Fill(ds, "hostel");
            ////dataGridView2.DataSource = ds.Tables["hostel"].DefaultView;
            //comboHostelTAssigned.Text = "---Choose---";
            //comboHostelSassigned.Text = "---Choose---";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM hostel", con);
            //DataSet ds = new DataSet();
            //da.Fill(ds, "hostel");
            //dataGridView2.DataSource = ds.Tables["hostel"].DefaultView;
        }

       

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1Streams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtStreamName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStreamsReset_Click(object sender, EventArgs e)
        {

        }

        private void btnHostelSave_Click(object sender, EventArgs e)
        {
            string qur = "INSERT INTO Hostels (HostelCode,HostelName,Capacity,TeacherAssigned,HostelCaptain,DateRegistered) VALUES ('" + txtHostelCode.Text + "','" + txtHostelName.Text + "','" + txtHostelCapacity.Text + "','" + comboHostelTAssigned.SelectedItem + "','" + comboHostelSassigned.SelectedItem + "'," +
              "'" + guna2DateTimePicker1Hostel.Text + "')";
            SqlCommand cmd = new SqlCommand(qur, sqlConnection);
            try
            {
                
                sqlConnection.Open();
                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show("New Hostel Recorded Successfully.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();

        }
       

        private void guna2Button1ViewHostels_Click(object sender, EventArgs e)
        {

           
            sqlConnection.Open();
            string query = "SELECT * FROM Hostels";
            SqlDataAdapter d = new SqlDataAdapter(query, sqlConnection);
            DataTable t = new DataTable();
           d.Fill(t);
            guna2DataGridView1Hostels.DataSource = t;
            sqlConnection.Close();
        }
    }
}
