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
                textBoxhostelcode.Text = mdr.GetValue(3).ToString();
                textBoxhostel.Text = mdr.GetValue(4).ToString();
                textBoxroomNo.Text = mdr.GetValue(5).ToString();

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

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxhostelcode.Text != "" && textBoxhostel.Text != "" && textBoxAdmNo.Text !="" && textBoxStudname.Text != "" && textBoxroomNo.Text != "" && dateTimePickerClearence.Text != "") 
            {


                try
                {
                    con.Open();
                    String Query = "DELETE FROM Assignedhostel where AdmNo='" + this.textBoxAdmNo.Text + "'";
                    cmd = new SqlCommand(Query, con);

                    mdr = cmd.ExecuteReader();
                    MessageBox.Show("Student Has Been Cleared Successfully");

                 


                    if (mdr != null)
                    {
                        while (mdr.Read())
                        {
                            //do something
                            cmd = new SqlCommand("insert into hostelclearence(Hostelcode,Hostelname,RoomNo,AdmNo,Studname,DateOfClearence) values(@Hostelcode,@Hostelname,@RoomNo,@AdmNo,@Studname,@DateOfClearence)", con);
                            //con.Open();
                            cmd.Parameters.AddWithValue("@Hostelcode", textBoxhostelcode.Text);
                            cmd.Parameters.AddWithValue("@Hostelname", textBoxhostel.Text);
                            cmd.Parameters.AddWithValue("@RoomNo", textBoxroomNo.Text);
                            cmd.Parameters.AddWithValue("@AdmNo", textBoxAdmNo.Text);
                            cmd.Parameters.AddWithValue("@Studname", textBoxStudname.Text);
                            cmd.Parameters.AddWithValue("@DateOfClearence", dateTimePickerClearence.Value);

                            //cmd.ExecuteNonQuery();
                        }
                    }
                    mdr.Close(); // closing SqlDataReader
                    mdr.Dispose();



                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }

            else
            {

            }


        }
    }
}
