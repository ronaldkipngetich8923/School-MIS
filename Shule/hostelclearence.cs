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
    public partial class hostelclearence : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=shule;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataReader mdr;
        public hostelclearence()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            String selectQuery = "SELECT * FROM Assignedhostel where AdmNo=" + int.Parse(textBoxsearch.Text);
            cmd = new SqlCommand(selectQuery, con);
            mdr = cmd.ExecuteReader();

            if(mdr.Read())
            {
                textBoxAdmNo.Text = mdr.GetValue(1).ToString();
                textBoxStudname.Text = mdr.GetValue(2).ToString();
                textBoxhostelcode.Text = mdr.GetValue(0).ToString();
                textBoxhostel.Text = mdr.GetValue(0).ToString();
                textBoxroomNo.Text = mdr.GetValue(0).ToString();

            }
            else
            {
                MessageBox.Show("No such studentin hostel");
            }

            con.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
