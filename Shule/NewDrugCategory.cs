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
    public partial class NewDrugCategory : Form
    {

        SqlConnection sqlConnection = new SqlConnection("Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True");
        SqlCommand cmd;
        //SqlConnection sqlConnection;
        SqlDataReader sqlDataReader;
        SqlDataAdapter sqlDataAdapter;
        DataSet ds;
        public NewDrugCategory()
        {
            InitializeComponent();
        }

        private void btnMedicSave_Click(object sender, EventArgs e)
        {
            if (txtCategoryCode.Text != "" && txtCategoryType.Text != "")
            {
                string qur = "INSERT INTO DrugCategories (DrugCode,DrugCategory) VALUES ('" + txtCategoryCode.Text + "','" + txtCategoryType.Text + "')";
                SqlCommand cmd = new SqlCommand(qur, sqlConnection);
                try
                {

                    sqlConnection.Open();
                    int rows = cmd.ExecuteNonQuery();

                    MessageBox.Show(" Drug Category Added Successfully.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                
                //}

            }
            else
            {
                MessageBox.Show(" Field CategoryCode & CategoryType Cannot be Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);




            }
            sqlConnection.Close();

        }

        private void guna2Button1ViewCategories_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM DrugCategories";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            MedicineCategory.DataSource = dt;

        }
    }
}
