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
    public partial class Newrooms : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=shule;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataReader sqlReader;
        public Newrooms()
        {
            InitializeComponent();
            comboBoxhostelvailableFill();
        }

        public void comboBoxhostelvailableFill()
        {

            cmd = new SqlCommand("SELECT * FROM hostel", con);

            try
            {
                con.Open();
                sqlReader = cmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    String hName = sqlReader["Hostelcode"].ToString();
                    comboBoxhostelvailable.Items.Add(hName);

                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBoxRoomNo.Text = "";
            textBoxOccupants.Text = "";
            comboBoxhostelvailable.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxRoomNo.Text != "" && comboBoxhostelvailable.Text != "" && textBoxOccupants.Text != ""  )
            {
                cmd = new SqlCommand("insert into rooms(RoomNo,hostelcode,Occupants) values(@RoomNo,@hostelcode,@Occupants)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@RoomNo", textBoxRoomNo.Text);
                cmd.Parameters.AddWithValue("@hostelcode", comboBoxhostelvailable.Text);
                cmd.Parameters.AddWithValue("@Occupants", textBoxOccupants.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Room Registered Successfully");
                // DisplayData();
                // ClearData();s
                textBoxRoomNo.Text = "";
                textBoxOccupants.Text = "";
                comboBoxhostelvailable.Text = "";
            }
            else
            {

                MessageBox.Show("Please Provide All Details!");

            }



        }

        private void textBoxRoomNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
