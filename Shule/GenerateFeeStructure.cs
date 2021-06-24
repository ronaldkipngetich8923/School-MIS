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
using Microsoft.Reporting.WinForms;

namespace Shule
{
    public partial class GenerateFeeStructure : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=shule;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataReader sqlReader;
       
      //  DataTable daTable1 = new DataTable();

        public GenerateFeeStructure()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           // this.fees_SetUpTableAdapter.Fill(this.DataSetFees.fees_SetUp);
            




            if (guna2ComboBoxform.Text != "" && guna2ComboBoxStream.Text != "" && guna2ComboBoxYear.Text != "" && guna2ComboBoxTerm.Text != "")
            {
                con.Open();

                String selectQuery = "SELECT Fees_Vote, Fees_Vote_Amount FROM fees_SetUp WHERE Form = '" + guna2ComboBoxform.Text + "' AND Stream = '" + guna2ComboBoxStream.Text + "' AND Year = '" + guna2ComboBoxYear.Text + "' AND Term = '" + guna2ComboBoxTerm.Text + "'";
                cmd = new SqlCommand(selectQuery, con);
                sqlReader = cmd.ExecuteReader();

                sqlReader.Read();

                this.fees_SetUpTableAdapter.Fill(this.DataSetFees.fees_SetUp);

                this.reportViewer1.RefreshReport();
                



            }
            else
            {
                MessageBox.Show("Please Selecet All Details");
            }
            sqlReader.Close();
            con.Close();

        }

        private void GenerateFeeStructure_Load(object sender, EventArgs e)
        {
           

            this.WindowState = FormWindowState.Maximized;

           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
