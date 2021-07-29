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
    public partial class StaffTypee : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True");
        SqlDataReader sqlDataReader;
        public StaffTypee()
        {
            InitializeComponent();
        }

        private void btnStaffSave_Click(object sender, EventArgs e)
        {
            if (txtStaffId.Text != "" && txtStaffDescription.Text != "" )
            {
                string qur = "INSERT INTO StaffDescription (StaffCode,StaffDescription) VALUES ('" + txtStaffId.Text + "','" + txtStaffDescription.Text + "')";
                SqlCommand cmd = new SqlCommand(qur, sqlConnection);
                try
                {

                    sqlConnection.Open();
                    int rows = cmd.ExecuteNonQuery();

                    MessageBox.Show(" Staff Description Added Successfully.", " Succeded", MessageBoxButtons.OK, MessageBoxIcon.Information);




                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show(" Fields Cannot Be Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);




            }
            sqlConnection.Close();


        }

        private void StaffTypee_Load(object sender, EventArgs e)
        {

        }
    }
}
