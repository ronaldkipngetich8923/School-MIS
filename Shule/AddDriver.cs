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
    public partial class AddDriver : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=shule;Integrated Security=True;");
        SqlCommand cmd;
        //SqlConnection sqlConnection;
        SqlDataReader sqlDataReader;
        //SqlDataAdapter sqlDataAdapter;
        DataSet ds;

        public AddDriver()
        {
            InitializeComponent();
            
            ComboVehicleFill();
        }


        public void ComboVehicleFill()
        {
         //   string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
           // sqlConnection = new SqlConnection(connStr);
            string cmdStr = " SELECT *  FROM vehicles";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {

                sqlConnection.Open();

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["vnumber"].ToString();

                    comboVehicleAssigned.Items.Add(sName);




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboVehicleAssigned_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmd = new SqlCommand("Select * From vehicles Where vnumber='" + comboVehicleAssigned.SelectedItem + "'", sqlConnection);

            sqlConnection.Open();
            sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.Read())
            {
                txtroute.Text = sqlDataReader["route"].ToString();
                
            }

            //}

            else
            {
                //MessageBox.Show("Vehicle Not Available !!");
            }
            sqlConnection.Close();

        


    }

    private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtLicenceNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRouteSave_Click(object sender, EventArgs e)
        {
            if (txtDId.Text != "" && txtDfullName.Text != "" && txtLicenceNo.Text != "" && comboVehicleAssigned.SelectedIndex != 0 && txtroute.Text !="")
            {
                string qur = "INSERT INTO Drivers (idno,driver_name,licenceno,vnumber,route) VALUES ('" + txtDId.Text + "','" + txtDfullName.Text + "','" + txtLicenceNo.Text + "','" + comboVehicleAssigned.SelectedItem + "','" + txtroute.Text + "')";
                cmd = new SqlCommand(qur, sqlConnection);
                try
                {

                    sqlConnection.Open();
                    int rows = cmd.ExecuteNonQuery();

                    MessageBox.Show(" Driver added Successfully.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
            else
            {
                MessageBox.Show(" Field  Id No , Full Name  & Licence Number Cannot be Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);




            }
            sqlConnection.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddDriver_Load(object sender, EventArgs e)
        {
            comboVehicleAssigned.Items.Insert(0, "..Select Vehicle..");
            comboVehicleAssigned.SelectedIndex = 0;

            



        }

        private void comboRouteAssigned_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1ViewDrivers_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Drivers";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            griddrivers.DataSource = dt;

        }
    }
}
