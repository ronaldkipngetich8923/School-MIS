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
            if (txtHostelClearAdmNo.Text != "" && txtHCode.Text != "")
            {
                string qur = "DELETE FROM OccupiedHostel WHERE AdmNo='"+ txtHostelClearAdmNo + "'";
                SqlCommand cmd = new SqlCommand(qur, sqlConnection);
                try
                {

                    sqlConnection.Open();
                    int rows = cmd.ExecuteNonQuery();

                    MessageBox.Show(" Student Cleared Successfullyl .", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Update the new hostel capacity
                    string quer = "UPDATE Hostels SET Rooms = Rooms + 1  where HostelCode = '" + txtHCode.Text + "'";
                    SqlCommand cmdUpdate = new SqlCommand(quer, sqlConnection);
                    cmdUpdate.ExecuteNonQuery();


                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


              


               

            }
            else
            {
                MessageBox.Show(" Field HostelCode & AdmNo Cannot be Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);




            }
            sqlConnection.Close();

        }
    }
}
