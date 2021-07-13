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
    public partial class AddRoutes : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True");
        SqlCommand cmd;
        //SqlConnection sqlConnection;
        //SqlDataReader sqlDataReader;
        //SqlDataAdapter sqlDataAdapter;
        DataSet ds;
        public AddRoutes()
        {
            InitializeComponent();
        }

        private void AddRoutes_Load(object sender, EventArgs e)
        {

        }

        private void btnRouteSave_Click(object sender, EventArgs e)
        {
            if (txtRId.Text != "" && txtRouteName.Text != "" && txtPickTime.Text != "")
            {
                string qur = "INSERT INTO Routes (RouteId,RouteName,PickTime) VALUES ('" + txtRId.Text + "','" + txtRouteName.Text + "','" + txtPickTime.Text + "')";
              cmd = new SqlCommand(qur, sqlConnection);
                try
                {

                    sqlConnection.Open();
                    int rows = cmd.ExecuteNonQuery();

                    MessageBox.Show(" Route added Successfully.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    

                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                
            }
            else
            {
                MessageBox.Show(" Field Route Id & Route Name Cannot be Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);




            }
            sqlConnection.Close();

        }

        private void guna2Button1ViewRoutes_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Routes";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1Routes.DataSource = dt;

        }
    }
}

