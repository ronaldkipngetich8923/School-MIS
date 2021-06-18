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
    public partial class AddHostel : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=shule;Integrated Security=True;");
        SqlCommand cmd;
        public AddHostel()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxhostelcode.Text != "" && textBoxhostelname.Text != "" && textBoxhostelcapacity.Text != "" && comboBoxTeacherIncharge.Text != "" && comboBoxAssTeacher.Text != "" && comboBoxcaptainIncharge.Text != "" && comboBoxAssCaptain.Text != "" &&  dateTimePickerdateReg.Text != "")
            {
                cmd = new SqlCommand("insert into hostel(Hostelcode,Hostelname,Capacity,TeacherIncharge,AssTeacherIncharge,CaptainIncharge,AssCaptainIncharge,DateRegistered) values(@Hostelcode,@Hostelname,@Capacity,@TeacherIncharge,@AssTeacherIncharge,@CaptainIncharge,@AssCaptainIncharge,@DateRegistered)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Hostelcode", textBoxhostelcode.Text);
                cmd.Parameters.AddWithValue("@Hostelname", textBoxhostelname.Text);
                cmd.Parameters.AddWithValue("@Capacity", textBoxhostelcapacity.Text);
                cmd.Parameters.AddWithValue("@TeacherIncharge", comboBoxTeacherIncharge.Text);
                cmd.Parameters.AddWithValue("@AssTeacherIncharge", comboBoxAssTeacher.Text);
                cmd.Parameters.AddWithValue("@CaptainIncharge", comboBoxcaptainIncharge.Text);
                cmd.Parameters.AddWithValue("@AssCaptainIncharge", comboBoxAssCaptain.Text);
                cmd.Parameters.AddWithValue("@DateRegistered", dateTimePickerdateReg.Value);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Hostel Registered Successfully");
                // DisplayData();
                // ClearData();
                textBoxhostelcode.Text = "";
                textBoxhostelname.Text = "";
                textBoxhostelcapacity.Text = "";
                comboBoxTeacherIncharge.Text = "";
                comboBoxAssTeacher.Text = "";
                comboBoxcaptainIncharge.Text = "";
                comboBoxAssCaptain.Text = "";
                dateTimePickerdateReg.Text = "";
            }
            else
            {

                MessageBox.Show("Please Provide All Details For Hostel!");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddHostel_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM hostel",con);
            DataSet ds = new DataSet();
            da.Fill(ds, "hostel");
            dataGridView2.DataSource = ds.Tables["hostel"].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM hostel", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "hostel");
            dataGridView2.DataSource = ds.Tables["hostel"].DefaultView;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxhostelcode.Text = "";
            textBoxhostelname.Text = "";
            textBoxhostelcapacity.Text = "";
            comboBoxTeacherIncharge.Text = "";
            comboBoxAssTeacher.Text = "";
            comboBoxcaptainIncharge.Text = "";
            comboBoxAssCaptain.Text = "";
            dateTimePickerdateReg.Text = "";
        }
    }
}
