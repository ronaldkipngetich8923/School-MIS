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
    public partial class AddStudentTransport : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=shule;Integrated Security=True;");
        SqlCommand cmd;
        //SqlConnection sqlConnection;
         SqlDataReader sqlDataReader;
        //SqlDataAdapter sqlDataAdapter;
        DataSet ds;
        public AddStudentTransport()
        {
            InitializeComponent();
            ComboAdmNo();
            ComboRouteFill();
        }
        public void ComboRouteFill()
        {
           // string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
           // sqlConnection = new SqlConnection(connStr);
            string cmdStr = " SELECT *  FROM Routes";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {

                sqlConnection.Open();

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["RouteName"].ToString();

                    comboRoute.Items.Add(sName);




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }
        public void ComboAdmNo()
        {
           // string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
           // sqlConnection = new SqlConnection(connStr);
            string cmdStr = " SELECT *  FROM StudentMaster";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {

                sqlConnection.Open();

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["AdmNo"].ToString();

                    ComboStudentTransport.Items.Add(sName);



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }

        private void btnTransSave_Click(object sender, EventArgs e)
        {
            if (ComboStudentTransport.Text != "" && comboRoute.Text != "" )
            {
                string qur = "INSERT INTO Transport (AdmNo,Route,DateOfRegistration) VALUES ('" + ComboStudentTransport.SelectedItem + "','" + comboRoute.SelectedItem + "','" + guna2DateTimePicker1Transport.Text + "')";
                cmd = new SqlCommand(qur, sqlConnection);
                try
                {

                    sqlConnection.Open();
                    int rows = cmd.ExecuteNonQuery();

                    MessageBox.Show(" Student added Successfully.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
            else
            {
                MessageBox.Show(" Field AdmNo & Route Cannot be Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);




            }
            sqlConnection.Close();

        }

        private void btnTransReset_Click(object sender, EventArgs e)
        {
            ComboStudentTransport.SelectedIndex = -1;
            comboRoute.SelectedIndex = -1;

        }

        private void guna2Button1ViewCTrans_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Transport";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            GridTransport.DataSource = dt;
        }

        private void AddStudentTransport_Load(object sender, EventArgs e)
        {
          //  comboRoute.SelectedIndex = 0;
           // ComboStudentTransport.SelectedIndex= 0;

        }
    }
}

