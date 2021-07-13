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
    public partial class HostelClearance : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True");
        SqlCommand cmd;
        //SqlConnection sqlConnection;
        SqlDataReader sqlDataReader;
        public HostelClearance()
        {
            InitializeComponent();
        }

        private void btnSearchCHostel_Click(object sender, EventArgs e)
        {
            if (txtHostelCAdm.Text != "")
            {
               

                //sqlConnection.Close();
                sqlConnection.Open();
                string query = "SELECT * FROM OccupiedHostel where AdmNo = '" + txtHostelCAdm.Text + "'";
                cmd = new SqlCommand(query, sqlConnection);
                // int UserExist = (int)cmd.ExecuteScalar;
                //if (UserExist > 0)
                //{
                //    //Username exist
                //}
                //else
                //{
                //    //Username doesn't exist.
                //}


                sqlDataReader = cmd.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    txtHostelClearAdmNo.Text = sqlDataReader.GetValue(3).ToString();
                    txtCHName.Text = sqlDataReader.GetValue(4).ToString();
                    txtHCode.Text = sqlDataReader.GetValue(1).ToString();
                    txtHostelName.Text = sqlDataReader.GetValue(2).ToString();
                }
               
                else
                {
                    MessageBox.Show("Student Not Registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }

            }

            else
            {
                MessageBox.Show("Search Box Is Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            sqlConnection.Close();

        }

        private void btnHostelCSave_Click(object sender, EventArgs e)
        {
            if (txtHostelClearAdmNo.Text != "" && txtHCode.Text != "" && currentstatus.SelectedIndex != 0)
            {

                string quer = "UPDATE OccupiedHostel SET Status = '" + currentstatus.SelectedItem + "'  where AdmNo = '" + txtHostelClearAdmNo.Text + "'";
                SqlCommand cmd = new SqlCommand(quer, sqlConnection);               
                try
                {
                    sqlConnection.Open();
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(" Student Cleared Successfully.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);






                    //string delete = "DELETE FROM OccupiedHostel WHERE AdmNo='"+ txtHostelClearAdmNo + "'";
                    //SqlCommand cmd1 = new SqlCommand(delete, sqlConnection);
                    //cmd1.ExecuteNonQuery();

                    //Update the new hostel capacity
                    string updat = "UPDATE Hostels SET Rooms = Rooms + 1  where HostelCode = '" + txtHCode.Text + "'";
                    SqlCommand cmdUpdate = new SqlCommand(updat, sqlConnection);
                    cmdUpdate.ExecuteNonQuery();



                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


              


               

            }
            else
            {
                MessageBox.Show(" Field HostelCode, AdmNo  & Status Cannot be Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);




            }
            sqlConnection.Close();

        }

        private void HostelClearance_Load(object sender, EventArgs e)
        {
            currentstatus.Items.Insert(0, "..Select Current Status..");
            currentstatus.SelectedIndex = 0;
        }

        private void guna2Button1ViewCHostels_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM OccupiedHostel where Status='CLEARED'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            GridHostelClearance.DataSource = dt;

        }
    }
}
