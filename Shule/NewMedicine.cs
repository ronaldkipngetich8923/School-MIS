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
    public partial class NewMedicine : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True");
        SqlCommand cmd;
        //SqlConnection sqlConnection;
        SqlDataReader sqlDataReader;
        SqlDataAdapter sqlDataAdapter;
        DataSet ds;
        public NewMedicine()
        {
            InitializeComponent();
            ComboMedicCategor();
        }
        public void ComboMedicCategor()
        {
            string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            sqlConnection = new SqlConnection(connStr);
            string cmdStr = " SELECT *  FROM DrugCategories";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);

            try
            {

                sqlConnection.Open();

                sqlDataReader = sqlCommand.ExecuteReader();


                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["DrugCategory"].ToString();


                    ComboMedicCategory.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }


        private void txtCHName_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewMedicine_Load(object sender, EventArgs e)
        {
            ComboMedicCategory.SelectedIndex = 0;
            
           


        }

        private void btnMedicSave_Click(object sender, EventArgs e)
        {
            if (ComboMedicCategory.Text != "" && txtMedicCode.Text != "" && txtMedicName.Text != "" && txtMedicQuantity.Text != "")
            {
                string qur = "INSERT INTO Drugs (MedicCode,DrugCategory,DrugName,DrugQuantity,DrugMDate,DrugEDate) VALUES ('" + txtMedicCode.Text + "','" + ComboMedicCategory.SelectedItem + "','" + txtMedicName.Text + "','" + txtMedicQuantity.Text + "','" + guna2DateTimePicker2.Text + "','" + guna2DateTimePicker1.Text + "')";
                SqlCommand cmd = new SqlCommand(qur, sqlConnection);
                try
                {

                    sqlConnection.Open();
                    int rows = cmd.ExecuteNonQuery();

                    MessageBox.Show(" Medicine Recorded Successfully.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);




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

        private void guna2Button1ViewCMedic_Click(object sender, EventArgs e)
        {
            
            string query = "SELECT * FROM Drugs";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            GridMedicines.DataSource = dt;


           
            
        }
    }
}

