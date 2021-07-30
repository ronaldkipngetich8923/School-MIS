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
    public partial class Ranks : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True");
        SqlDataReader sqlDataReader;
        public Ranks()
        {
            InitializeComponent();
        }

        private void btnRankSave_Click(object sender, EventArgs e)
        {
            if (txtRankId.Text != "" && txtRankDescription.Text != "")
            {
                string qur = "INSERT INTO Ranks (RankCode,RankDescription) VALUES ('" + txtRankId.Text + "','" + txtRankDescription.Text + "')";
                SqlCommand cmd = new SqlCommand(qur, sqlConnection);
                try
                {

                    sqlConnection.Open();
                    int rows = cmd.ExecuteNonQuery();

                    MessageBox.Show(" Rank Description Added Successfully.", " Succeded", MessageBoxButtons.OK, MessageBoxIcon.Information);




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
