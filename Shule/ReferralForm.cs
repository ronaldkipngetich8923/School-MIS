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
    public partial class ReferralForm : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True");
        SqlCommand cmd;
        //SqlConnection sqlConnection;
        SqlDataReader sqlDataReader;
        SqlDataAdapter sqlDataAdapter;
        DataSet ds;
        
        public ReferralForm()
        {
            InitializeComponent();
            FillcomboPatron();
        }

        public void FillcomboPatron()
        {
            //string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            //sqlConnection = new SqlConnection(connStr);
            string cmdStr = " SELECT *  FROM StaffDescription where StaffDescription='SURBOARDINATE STAFF'";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {

                sqlConnection.Open();

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["StaffDescription"].ToString();

                    comboPatronName.Items.Add(sName);



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }


        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMedicReset_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1ViewCategories_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btnReferalSave_Click(object sender, EventArgs e)
        {
            if (txtRAdmNo.Text != "" && richTextBoxReferal.Text != "" && txtReferTo.Text != "" && guna2DateTimePicker1Referal.Text != "")
            {
                string qur = "INSERT INTO Referals (AdmNo,Complain,ReferedTo,ReferedBy,DateOfReferal) VALUES ('" + txtRAdmNo.Text + "','" + richTextBoxReferal.Text + "','" + txtReferTo.Text + "','" + comboPatronName.SelectedItem + "','" + guna2DateTimePicker1Referal.Text + "')";
                SqlCommand cmd = new SqlCommand(qur, sqlConnection);
                try
                {

                    sqlConnection.Open();
                    int rows = cmd.ExecuteNonQuery();

                    MessageBox.Show(" Student Refered Successfully.", "Referal Succeded", MessageBoxButtons.OK, MessageBoxIcon.Information);




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

        
        private void guna2Button1ViewReferrals_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Referals";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            ReferalsGrid.DataSource = dt;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtSearchByReferalAdmNo.Text != "")
            {


                //sqlConnection.Close();
                sqlConnection.Open();
                string query = "SELECT * FROM Dispensary where AdmNo = '" + txtSearchByReferalAdmNo.Text + "'";
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
                    txtRAdmNo.Text = sqlDataReader.GetValue(1).ToString();
                    richTextBoxReferal.Text = sqlDataReader.GetValue(3).ToString();


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

        private void ReferralForm_Load(object sender, EventArgs e)
        {
            comboPatronName.Items.Insert(0, "..Select Matron..");
            comboPatronName.SelectedIndex = 0;
        }

        private void comboPatronName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

