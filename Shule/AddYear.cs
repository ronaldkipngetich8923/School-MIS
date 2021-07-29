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
    public partial class AddYear : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True");
        public AddYear()
        {
            InitializeComponent();
        }

        private void guna2Button1ViewRecords_Click(object sender, EventArgs e)
        {

        }

        private void btnClassesReset_Click(object sender, EventArgs e)
        {

        }

        private void btnYearSave_Click(object sender, EventArgs e)
        {

            string cmdStr = "INSERT INTO Year(Year) VALUES( '" + txtYearName.Text + "')";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {
                
                sqlConnection.Open();
                int rows = sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Current Year Added Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }


    }
}
