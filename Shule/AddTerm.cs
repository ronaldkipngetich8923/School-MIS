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
    public partial class AddTerm : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True");
        SqlDataReader sqlDataReader;
        public AddTerm()
        {
            InitializeComponent();
            ComboYearFill();
        }
        public void ComboYearFill()
        {
            string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            sqlConnection = new SqlConnection(connStr);
            string cmdStr = " SELECT *  FROM Year";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {

                sqlConnection.Open();

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["Year"].ToString();

                    comboBoxTyear.Items.Add(sName);
                    


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }



        private void btnTermSave_Click(object sender, EventArgs e)
        {
            string cmdStr = "INSERT INTO Term(Term,Year) VALUES( '" + txtTermName.Text + "','" + comboBoxTyear.SelectedItem + "')";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {

                sqlConnection.Open();
                int rows = sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Current Term Added Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }

        private void AddTerm_Load(object sender, EventArgs e)
        {
            comboBoxTyear.Items.Insert(0, "..Select Year..");
            comboBoxTyear.SelectedIndex = 0;
        }

        private void comboBoxTyear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

