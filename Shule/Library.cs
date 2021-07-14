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
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=shule;Integrated Security=True;");


        private void Header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MainDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Library_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Shelves.Visible = false;
            main.Visible = true;
            Books.Visible = false;
            Users.Visible = false;
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Shelves.Visible = true;
            main.Visible = false;
            Books.Visible = false;
            Users.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Shelves.Visible = false;
            main.Visible = false;
            Books.Visible = true;
            Users.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Shelves.Visible = false;
            main.Visible = false;
            Books.Visible = false;
            Users.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Shelves.Visible = true;
            main.Visible = false;
            Books.Visible = false;
            Users.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Shelves.Visible = false;
            main.Visible = false;
            Books.Visible = true;
            Users.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Shelves.Visible = false;
            main.Visible = false;
            Books.Visible = false;
            Users.Visible = true;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void guna2Button7_Click(object sender, EventArgs e)
        {
            if (guna2TextBox6.Text!="")
            {
                // Calculate what day of the week is 14 days from Today.
                System.DateTime today = System.DateTime.Now;
                System.TimeSpan duration = new System.TimeSpan(14, 0, 0, 0);
                System.DateTime answer = today.Add(duration);
                guna2DateTimePicker1.Value = answer;
                guna2DateTimePicker2.Value = DateTime.Now;
                try
                {
                    con.Open();
                    String selectQuery = "SELECT Book_ISBN,Tittle From Books where Book_ISBN='" + guna2TextBox6.Text + "'";
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    SqlDataReader mdr = cmd.ExecuteReader();

                    if (mdr.Read())
                    {
                        guna2TextBox4.Text = mdr.GetValue(0).ToString();
                        guna2TextBox3.Text = mdr.GetValue(1).ToString();
                    }
                    else
                    {
                        MessageBox.Show("No such Book in Library");
                    }
                    
                }
                catch(Exception emm)
                {
                    MessageBox.Show(emm.Message);
                }
                con.Close();
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text != "" && guna2TextBox2.Text != "" && guna2TextBox4.Text != "" && guna2TextBox3.Text != "")
            {
               SqlCommand cmd = new SqlCommand("insert into Borrow_Books(AdmNo,Reason,Book_ISBN,Tittle,Date_Borrow,Due_Date,Charges) values (@AdmNo,@Reason,@Book_ISBN,@Tittle,@Date_Borrow,@Due_Date,@Charges)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@AdmNo", guna2TextBox1.Text);
                cmd.Parameters.AddWithValue("@Reason", guna2TextBox2.Text);
                cmd.Parameters.AddWithValue("@Book_ISBN", guna2TextBox4.Text);
                cmd.Parameters.AddWithValue("@Tittle", guna2TextBox3.Text);
                cmd.Parameters.AddWithValue("@Date_Borrow", guna2DateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@Due_Date", guna2DateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Charges", guna2TextBox7.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully Borrowed","Success Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                guna2TextBox1.Text="";
                guna2TextBox4.Text="";
                guna2TextBox3.Text = "";
                guna2DateTimePicker2.Value = DateTime.Now;
                guna2DateTimePicker1.Value = DateTime.Now;
                guna2TextBox6.Text = "";
            }
            else
            {
                MessageBox.Show("Kindly Check Student Details !!");
            }
            con.Close();
        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            System.DateTime today = guna2DateTimePicker2.Value;
            System.TimeSpan duration = new System.TimeSpan(14, 0, 0, 0);
            System.DateTime answer = today.Add(duration);
            guna2DateTimePicker1.Value = answer;
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Borrow_Books Where Reason='Borrow'";
            SqlDataAdapter d = new SqlDataAdapter(query, con);
            DataTable t = new DataTable();
            d.Fill(t);
            dataGridView2.DataSource = t;
            con.Close();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

            try
            {
                if (guna2TextBox12.Text != "")
                {
                    con.Open();
                    String selectQuery = "SELECT AdmNo,Book_ISBN,Tittle,Date_Borrow,Due_Date From Borrow_Books where Book_ISBN='" + guna2TextBox12.Text + "'AND Reason='Borrow'";
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    SqlDataReader mdr = cmd.ExecuteReader();

                    if (mdr.Read())
                    {
                        guna2TextBox11.Text = mdr.GetValue(0).ToString();
                        guna2TextBox9.Text = mdr.GetValue(1).ToString();
                        guna2TextBox10.Text = mdr.GetValue(2).ToString();
                        guna2DateTimePicker3.Text = mdr.GetValue(3).ToString();
                        guna2DateTimePicker4.Text = mdr.GetValue(4).ToString();
                       // guna2TextBox8.Text = mdr.GetValue(5).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Book has not Been Borrowed Yet !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    con.Close();

                    if (guna2DateTimePicker4.Value > DateTime.Now)
                    {
                        guna2TextBox8.Text = 0.00.ToString();
                    }
                    else
                    {
                        //var time = guna2DateTimePicker4.Value - DateTime.Now.To();
                        DateTime StartTime = guna2DateTimePicker4.Value;
                        DateTime datenow = DateTime.Now;
                        TimeSpan span = datenow.Subtract(StartTime);
                        int totaldays;
                        totaldays = span.Days;
                        guna2TextBox8.Text = (5 * totaldays).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Enter Book ISBNto Search.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }           
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2TextBox11.Text != "" && guna2TextBox9.Text != "" && guna2TextBox10.Text != ""&& guna2TextBox13.Text!="")
                {
                     con.Open();              
                SqlCommand cmd = new SqlCommand("UPDATE Borrow_Books Set Reason ='" + guna2TextBox5.Text + "',Charges =('" + guna2TextBox13.Text + "'- Charges) where Book_ISBN = '" + guna2TextBox9.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Book Returned Successfully.","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                guna2TextBox12.Text = "";
                guna2TextBox11.Text = "";
                guna2TextBox9.Text = "";
                guna2TextBox10.Text = "";
                guna2TextBox8.Text = 0.00.ToString();
                guna2TextBox13.Text = "";
                }
                else
                {
                    MessageBox.Show("Search For a Book and Provide all Details","Message",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                }
               
            }
            catch (Exception ee1)
            {
                MessageBox.Show(ee1.Message);
                con.Close();
            }
           
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Borrow_Books Where Reason='Return'";
            SqlDataAdapter d = new SqlDataAdapter(query, con);
            DataTable t = new DataTable();
            d.Fill(t);
            dataGridView2.DataSource = t;
            con.Close();
        }

        private void New_Books_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            if (guna2TextBox14.Text != "" && guna2TextBox16.Text != "" && guna2TextBox17.Text != "" && guna2TextBox20.Text != "" && guna2TextBox15.Text != "" && guna2TextBox18.Text != "")
            {
                SqlCommand cmd = new SqlCommand("insert into Books(Subject,Tittle,Author,Edition,Publication_Year,Publisher,Date_Received,Shelf_No) values (@Subject,@Tittle,@Author,@Edition,@Publication_Year,@Publisher,@Date_Received,@Shelf_No)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Subject", guna2TextBox14.Text);
                cmd.Parameters.AddWithValue("@Tittle", guna2TextBox16.Text);
                cmd.Parameters.AddWithValue("@Author", guna2TextBox17.Text);
                cmd.Parameters.AddWithValue("@Edition", guna2TextBox15.Text);
                cmd.Parameters.AddWithValue("@Publication_Year", guna2TextBox18.Text);
                cmd.Parameters.AddWithValue("@Publisher", guna2TextBox21.Text);
                cmd.Parameters.AddWithValue("@Date_Received", guna2DateTimePicker5.Value);
                cmd.Parameters.AddWithValue("@Shelf_No", guna2TextBox20.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("New Book Added to Shelf Successfully.");
                con.Close();
            }
            else
            {
                MessageBox.Show("Kindly check Books details.");

            }
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Books";
            SqlDataAdapter d = new SqlDataAdapter(query, con);
            DataTable t = new DataTable();
            d.Fill(t);
            dataGridView2.DataSource = t;
            con.Close();
        }

        private void guna2TextBox9_TextChanged(object sender, EventArgs e)
        {
            //con.Open();

            //SqlCommand cmd2 = new SqlCommand("IF Exists (Select Book_ISBN From Borrow_Books Where Book_ISBN ='" + guna2TextBox9.Text+ "' AND Reason = 'Borrow' )",con);
            //cmd2.ExecuteNonQuery();
            //MessageBox.Show("Book has not Been Returned");
            //con.Close();
        }
    }
}
