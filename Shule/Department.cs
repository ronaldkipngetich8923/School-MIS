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
    public partial class Department : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True");
        SqlDataReader sqlDataReader;
        public Department()
        {
            InitializeComponent();
        }

        private void btnDepartmentSave_Click(object sender, EventArgs e)
        {
            if (txtDepartmentId.Text != "" && txtDepartmentDescription.Text != "")
            {
                string qur = "INSERT INTO Departments (DepartmentCode,DepartmentName) VALUES ('" + txtDepartmentId.Text + "','" + txtDepartmentDescription.Text + "')";
                SqlCommand cmd = new SqlCommand(qur, sqlConnection);
                try
                {

                    sqlConnection.Open();
                    int rows = cmd.ExecuteNonQuery();

                    MessageBox.Show(" Department Description Added Successfully.", " Succeded", MessageBoxButtons.OK, MessageBoxIcon.Information);




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
    }
}
