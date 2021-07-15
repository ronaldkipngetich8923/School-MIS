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
    public partial class Newshelf : Form
    {

        SqlConnection con = new SqlConnection("Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=shule;Integrated Security=True;");
        SqlCommand cmd;

        public Newshelf()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // this.WindowState = FormWindowState.Minimized;
            if (textBox1ShelfNo.Text != "" && textBoxShelfName.Text != "" && richTextBoxDescription.Text != "" && textBoxShelfLocation.Text != "")
            {
                cmd = new SqlCommand("insert into shelf(ShelfNo,ShelfName,ShelfDescription,ShelfLocation) values(@ShelfNo,@ShelfName,@ShelfDescription,@ShelfLocation", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ShelfNo", textBox1ShelfNo.Text);
                cmd.Parameters.AddWithValue("@ShelfName", textBoxShelfName.Text);
                cmd.Parameters.AddWithValue("@ShelfDescription", richTextBoxDescription.Text);
                cmd.Parameters.AddWithValue("@ShelfLocation", textBoxShelfLocation.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Shelf Added Successfully");
                // DisplayData();
                // ClearData();
            }
            else
            {

                MessageBox.Show("Please Provide All Details!");

            }
        }

        private void Newshelf_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
