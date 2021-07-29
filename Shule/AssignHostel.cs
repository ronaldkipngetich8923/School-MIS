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
    public partial class tab : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=shule;Integrated Security=True;");
       // SqlCommand cmd;
        //SqlConnection sqlConnection;
        SqlDataReader sqlDataReader;
      //  SqlDataAdapter sqlDataAdapter;
       // DataSet ds;
        int indexRow;
        public tab()
        {
            InitializeComponent();
            HostelCodeFill();
            FillcomboHosteAdmNo();
        }
        public void FillcomboHosteAdmNo()
        {
            string cmdStr = " SELECT *  FROM StudentMaster";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {
                sqlConnection.Open();

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["AdmNo"].ToString();

                    comboHosteAdmNo.Items.Add(sName);
                    
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }

        public void HostelCodeFill()
        { 
            string cmdStr = " SELECT *  FROM Hostels";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {

                sqlConnection.Open();

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["HostelCode"].ToString();

                    comboHostelCode.Items.Add(sName);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }


        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtHostelName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboHostelCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboHostelCode.SelectedItem != null)
            {
                SqlCommand cmd1 = new SqlCommand("Select * From Hostels Where HostelCode='" + comboHostelCode.SelectedItem + "'", sqlConnection);

                sqlConnection.Open();
                sqlDataReader = cmd1.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    txtHostelName.Text = sqlDataReader["HostelName"].ToString();
                    txtHostelCapacity.Text = sqlDataReader["Capacity"].ToString();
                    rooms.Text = sqlDataReader["Rooms"].ToString();

                }
                sqlDataReader.Close();
            }

            else
            {
                MessageBox.Show("Hostel Not Available !!");
            }
            sqlConnection.Close();

        }

        private void AssignHostel_Load(object sender, EventArgs e)
        {
            currentstatus.Items.Insert(0, "..Select Current Status..");
            currentstatus.SelectedIndex = 0;
        }

        private void comboHosteAdmNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(comboHosteAdmNo.Text !="")
            //{
                String  qur="Select * From StudentMaster where AdmNo ='"+ comboHosteAdmNo.SelectedItem+ "' ";
                SqlCommand cmd = new SqlCommand(qur, sqlConnection);
                sqlConnection.Open();
                sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    txtComboStudname.Text = sqlDataReader["Studname"].ToString();
                
                }
                
            else
            {
                MessageBox.Show("Student Not Available !!");
            }
            sqlConnection.Close();
        }

        private void btnHostelSave_Click(object sender, EventArgs e)
        {

            if (comboHostelCode.Text != "" && comboHosteAdmNo.Text != "" && currentstatus.SelectedIndex != 0)
            {
                string qur = "INSERT INTO OccupiedHostel (HostelCode,HostelName,AdmNo,Studname,DateAssigned,Status) VALUES ('" + comboHostelCode.SelectedItem + "','" + txtHostelName.Text + "','" + comboHosteAdmNo.SelectedItem + "','" + txtComboStudname.Text + "','" + guna2DateTimePicker1Hostel.Text + "','" + currentstatus.SelectedItem + "')";
                SqlCommand cmd = new SqlCommand(qur, sqlConnection);
                try
                {
                    sqlConnection.Open();
                    int rows = cmd.ExecuteNonQuery();

                    MessageBox.Show(" Hostel Assigned Successfully.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Update the new hostel capacity
                    string quer = "UPDATE Hostels SET Rooms = Rooms - 1  where HostelCode = '" + comboHostelCode.SelectedItem + "'";
                    SqlCommand cmdUpdate = new SqlCommand(quer,sqlConnection);
                    cmdUpdate.ExecuteNonQuery();
                    
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

               
                //string query = "UPDATE Hostels SET Capacity = Capacity - 1  where HostelCode = '" + comboHostelCode.SelectedItem + "'";
                //SqlDataAdapter sqlData = new SqlDataAdapter(query, sqlConnection);
                //SqlCommand cmd2 = new SqlCommand("Select  Capacity From Hostels ", sqlConnection);

                //sqlDataReader = cmd.ExecuteReader();
                //if (sqlDataReader.Read())
                //{
                //    rooms.Text = sqlDataReader["Capacity"].ToString();
                
                //}
            }
            else
            {
                MessageBox.Show(" Field HostelCode & AdmNo Cannot be Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                

            }
            sqlConnection.Close();

        }

        private void guna2Button1ViewHostels_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM OccupiedHostel where Status='ASSIGNED'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            gridhostels.DataSource = dt;

            //string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";

            //string query = "SELECT o.HostelCode,h.Hostel I.AdmNo,T.Studname,T.Class,T.Stream FROM OcuppiedHostel as o  JOIN Hostels as h    ON o.HostelCode = h.HostelCode    JOIN StudentMaster as T    ON I.AdmNo = h.AdmNo ";
            //sqlDataAdapter  = new SqlDataAdapter(query, connStr);

            //DataTable dsx = new DataTable();
            //sqlDataAdapter.Fill(dsx);
            //guna2DataGridView1HostelsAssign.DataSource = dsx;

            //sqlConnection.Open();

            //string query = "SELECT * FROM Subject  ";

            //SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            //DataTable dt = new DataTable();
            //SDA.Fill(dt);
            //guna2DataGridView1HostelsAssign.DataSource = dt;


            //sqlConnection.Close();

        }

        private void btnHostelReset_Click(object sender, EventArgs e)
        {
            //txtHostelName.Clear();
            comboHosteAdmNo.SelectedIndex = -1;
            txtComboStudname.Clear();
        }

        private void gridhostels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = gridhostels.Rows[indexRow];
            comboHostelCode.Text = row.Cells[1].Value.ToString();
            txtHostelName.Text = row.Cells[2].Value.ToString();
            comboHosteAdmNo.SelectedItem = row.Cells[3].Value.ToString();
            txtComboStudname.Text = row.Cells[4].Value.ToString();
            guna2DateTimePicker1Hostel.Text = row.Cells[5].Value.ToString();
            currentstatus.Text = row.Cells[6].Value.ToString();



        }

        private void UpdateHostel_Click(object sender, EventArgs e)
        {
            string qur = "UPDATE OccupiedHostel SET HostelName='" + txtHostelName.Text + "',AdmNo='" + comboHosteAdmNo.SelectedItem + "',Studname='" + txtComboStudname.Text + "' WHERE HostelCode='" + comboHostelCode.SelectedItem + "'";
            SqlCommand cmd = new SqlCommand(qur, sqlConnection);
            try
            {

                sqlConnection.Open();
                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show("Student Record Updated Successfully.", "Update Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();

        }
    }
    }
 

