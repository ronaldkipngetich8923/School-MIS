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
    public partial class hostel : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=shule;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataReader sqlReader;
        public hostel()
        {
           InitializeComponent();
           comboBoxhostelvailableFill();
           comboBoxRoomsFill();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxAdmNo.Text != "" && textBoxStudname.Text != "" && textBoxhostelcode.Text !="" && comboBoxhostelvailable.Text != "" && dateTimePickerAssined.Text != "" && dateTimePickerClearence.Text != "" && comboBoxAssignRoom.Text != "")
            {
                cmd = new SqlCommand("insert into Assignedhostel(AdmNo,Studname,Hostelcode,HostelAssigned,DateAssigned,DateOfClearence,AssignedRoom) values(@AdmNo,@Studname,@Hostelcode,@HostelAssigned,@DateAssigned,@DateOfClearence,@AssignedRoom)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@AdmNo", textBoxAdmNo.Text);
                cmd.Parameters.AddWithValue("@Studname", textBoxStudname.Text);
                cmd.Parameters.AddWithValue("@Hostelcode", textBoxhostelcode.Text);
                cmd.Parameters.AddWithValue("@HostelAssigned", comboBoxhostelvailable.Text);
                cmd.Parameters.AddWithValue("@DateAssigned", dateTimePickerAssined.Value);
                cmd.Parameters.AddWithValue("@DateOfClearence", dateTimePickerClearence.Value);
                cmd.Parameters.AddWithValue("@AssignedRoom", comboBoxAssignRoom.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student Assigned Successfully");
                // DisplayData();
                // ClearData();
                textBoxAdmNo.Text = "";
                textBoxStudname.Text = "";
                comboBoxhostelvailable.Text = "";
                dateTimePickerAssined.Text = "";
                dateTimePickerClearence.Text = "";
                comboBoxAssignRoom.Text = "";
                textBoxhostelcode.Text = "";
                textBoxAvailableRooms.Text = "";
            }
            else
            {

                MessageBox.Show("Please Provide All Details!");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM hostel", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "hostel");
            dataGridView1.DataSource = ds.Tables["hostel"].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Reset Button 
            textBoxAvailableRooms.Text = "";
            textBoxAdmNo.Text = "";
            textBoxStudname.Text = "";
            comboBoxhostelvailable.Text = "";
            dateTimePickerAssined.Text = "";
            dateTimePickerClearence.Text = "";
            comboBoxAssignRoom.Text = "";
            textBoxhostelcode.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            hostelclearence f2 = new hostelclearence();
            f2.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void comboBoxhostelvailableFill()
        {

            cmd = new SqlCommand("SELECT * FROM hostel",con);

            try
            {
                con.Open();
                sqlReader = cmd.ExecuteReader();

                while(sqlReader.Read())
                {
                    String hName = sqlReader["Hostelname"].ToString();
                    comboBoxhostelvailable.Items.Add(hName);

                }
                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
           


        }

        public void comboBoxRoomsFill()
        {

            cmd = new SqlCommand("SELECT * FROM rooms", con);

            try
            {
                con.Open();
                sqlReader = cmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    String rName = sqlReader["RoomNo"].ToString();
                    comboBoxAssignRoom.Items.Add(rName);

                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }

        private void comboBoxhostelvailable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Newrooms nr = new Newrooms();
            nr.Show();
        }
    }
}
