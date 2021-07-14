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
    public partial class AddVehicle : Form
    {
       
        SqlConnection sqlConnection = new SqlConnection("Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True");
        SqlCommand cmd;
        //SqlConnection sqlConnection;
        SqlDataReader sqlDataReader;
        //SqlDataAdapter sqlDataAdapter;
        DataSet ds;

        public AddVehicle()
        {
            InitializeComponent();
            ComboRouteFill();
            
        }

        public void ComboRouteFill()
        {
            string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            sqlConnection = new SqlConnection(connStr);
            string cmdStr = " SELECT *  FROM Routes";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {

                sqlConnection.Open();

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["RouteName"].ToString();

                    ComboVRoutes.Items.Add(sName);
                    



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }
        private void AddVehicle_Load(object sender, EventArgs e)
        {
            ComboVRoutes.Items.Insert(0, "..Select Route..");
            ComboVRoutes.SelectedIndex = 0;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRouteName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPickTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRouteReset_Click(object sender, EventArgs e)
        {
            txtVmodel.Clear();
            txtVehicleName.Clear();
            txtCapacity.Clear();
            txtMaitanance.Clear();
        }

        private void btnRouteSave_Click(object sender, EventArgs e)
        {
            if (txtVmodel.Text != "" && txtVehicleName.Text != "" && txtCapacity.Text != "" && txtMaitanance.Text != ""  && ComboVRoutes.SelectedIndex != 0 )
            {
                string qur = "INSERT INTO vehicles (vmodel,vnumber,capacity,maintanance_period,route,idate,edate) VALUES ('" + txtVmodel.Text + "','" + txtVehicleName.Text + "','" + txtCapacity.Text + "','" + txtMaitanance.Text + "', '" + ComboVRoutes.SelectedItem + "','" + guna2DateTimePicker1.Text + "','" + guna2DateTimePicker2.Text + "')";
                cmd = new SqlCommand(qur, sqlConnection);
                try
                {

                    sqlConnection.Open();
                    int rows = cmd.ExecuteNonQuery();

                    MessageBox.Show(" Vehicle added Successfully.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
            else
            {
                MessageBox.Show(" Field  VehicleModel ,Capacity,Maitanance Period, VehicleName & Route Cannot be Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);




            }
            sqlConnection.Close();

        }
    

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ComboVRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboVRoutes.SelectedIndex < 0)
            {
                ComboVRoutes.Text = "..Select Route..";
            }
            else
            {
                ComboVRoutes.Text = ComboVRoutes.SelectedText;
            }
        }

        private void guna2DataGridView1Vehicle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1ViewVehicles_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM vehicles";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            gridvehicles.DataSource = dt;

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCapacity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
