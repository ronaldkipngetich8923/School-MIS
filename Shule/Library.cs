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
            panel5books.Visible = false;
            this.WindowState = FormWindowState.Maximized;
            Shelves.Visible = false;
            main.Visible = true;
            Books.Visible = false;
            Users.Visible = false;
            magazines.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Shelves.Visible = true;
            main.Visible = false;
            Books.Visible = false;
            Users.Visible = false;
            magazines.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Shelves.Visible = false;
            main.Visible = false;
            Books.Visible = true;
            Users.Visible = false;
            magazines.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Shelves.Visible = false;
            main.Visible = false;
            Books.Visible = false;
            Users.Visible = true;
            magazines.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Shelves.Visible = true;
            main.Visible = false;
            Books.Visible = false;
            Users.Visible = false;
            magazines.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Shelves.Visible = false;
            main.Visible = false;
            Books.Visible = true;
            Users.Visible = false;
            magazines.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Shelves.Visible = false;
            main.Visible = false;
            Books.Visible = false;
            Users.Visible = true;
            magazines.Visible = false;
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
                    String selectQuery = "SELECT Book_ISBN,Tittle,Class From Books where Book_ISBN='" + guna2TextBox6.Text + "' AND Status ='Available'";
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    SqlDataReader mdr = cmd.ExecuteReader();

                    if (mdr.Read())
                    {
                        guna2TextBox4.Text = mdr.GetValue(0).ToString();
                        guna2TextBox3.Text = mdr.GetValue(1).ToString();
                        guna2TextBox19.Text = mdr.GetValue(2).ToString();
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
            try
            {
                if (guna2TextBox1.Text != "" && guna2TextBox2.Text != "" && guna2TextBox4.Text != "" && guna2TextBox3.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("insert into Borrow_Books(AdmNo,Class,Reason,Book_ISBN,Tittle,Date_Borrow,Due_Date,Charges) values (@AdmNo,@Class,@Reason,@Book_ISBN,@Tittle,@Date_Borrow,@Due_Date,@Charges)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@AdmNo", guna2TextBox1.Text);
                    cmd.Parameters.AddWithValue("@Class", guna2TextBox19.Text);
                    cmd.Parameters.AddWithValue("@Reason", guna2TextBox2.Text);
                    cmd.Parameters.AddWithValue("@Book_ISBN", guna2TextBox4.Text);
                    cmd.Parameters.AddWithValue("@Tittle", guna2TextBox3.Text);
                    cmd.Parameters.AddWithValue("@Date_Borrow", guna2DateTimePicker2.Value);
                    cmd.Parameters.AddWithValue("@Due_Date", guna2DateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Charges", guna2TextBox7.Text);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    con.Open();

                    SqlCommand cmd1 = new SqlCommand("UPDATE Books SET Status='Borrowed' Where Book_ISBN='"+ guna2TextBox4.Text+ "'",con);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    
                    MessageBox.Show("Successfully Borrowed", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    guna2TextBox1.Text = "";
                    guna2TextBox4.Text = "";
                    guna2TextBox3.Text = "";
                    guna2DateTimePicker2.Value = DateTime.Now;
                    guna2DateTimePicker1.Value = DateTime.Now;
                    guna2TextBox6.Text = "";
                }
                else
                {
                    MessageBox.Show("Kindly Check Student Details !!");
                }              
            }
            catch(Exception ee2)
            {
                MessageBox.Show(ee2.Message);              
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
                if (guna2TextBox11.Text != "" && guna2TextBox9.Text != "" && guna2TextBox10.Text != "" && guna2TextBox13.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Borrow_Books Set Reason ='" + guna2TextBox5.Text + "',Charges =('" + guna2TextBox13.Text + "'- Charges) where Book_ISBN = '" + guna2TextBox9.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("Update Books SET Status='Available' Where Book_ISBN='" + guna2TextBox9.Text + "'",con);
                    cmd1.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Book Returned Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    guna2TextBox12.Text = "";
                    guna2TextBox11.Text = "";
                    guna2TextBox9.Text = "";
                    guna2TextBox10.Text = "";
                    guna2TextBox8.Text = 0.00.ToString();
                    guna2TextBox13.Text = "";
                }
                else
                {
                    MessageBox.Show("Search For a Book and Provide all Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                String status = "Available";
                SqlCommand cmd = new SqlCommand("insert into Books(Class,Subject,Tittle,Author,Edition,Publication_Year,Publisher,Date_Received,Shelf_No,Status) values (@Class,@Subject,@Tittle,@Author,@Edition,@Publication_Year,@Publisher,@Date_Received,@Shelf_No,@Status)", con);                               
                con.Open();
                cmd.Parameters.AddWithValue("@Class", guna2ComboBox2.Text);
                cmd.Parameters.AddWithValue("@Subject", guna2TextBox14.Text);
                cmd.Parameters.AddWithValue("@Tittle", guna2TextBox16.Text);
                cmd.Parameters.AddWithValue("@Author", guna2TextBox17.Text);
                cmd.Parameters.AddWithValue("@Edition", guna2TextBox15.Text);
                cmd.Parameters.AddWithValue("@Publication_Year", guna2TextBox18.Text);
                cmd.Parameters.AddWithValue("@Publisher", guna2TextBox21.Text);
                cmd.Parameters.AddWithValue("@Date_Received", guna2DateTimePicker5.Value);
                cmd.Parameters.AddWithValue("@Shelf_No", guna2TextBox20.Text);
                cmd.Parameters.AddWithValue("@Status", status);
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxShelfName.Text != "" && richTextBoxDescription.Text != "" && textBoxShelfLocation.Text != "" )
                {
                    SqlCommand cmd = new SqlCommand("insert into Shelf(Shelf_Name,Shelf_Description,Shelf_Location) values (@Shelf_Name,@Shelf_Description,@Shelf_Location)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@Shelf_Name", textBoxShelfName.Text);
                    cmd.Parameters.AddWithValue("@Shelf_Description", richTextBoxDescription.Text);
                    cmd.Parameters.AddWithValue("@Shelf_Location", textBoxShelfLocation.Text);                   
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("New Shelf Added  Successfully.");
                    textBoxShelfName.Text = "";
                    richTextBoxDescription.Text = "";
                    textBoxShelfLocation.Text = "";


                    con.Close();
                }
                else
                {
                    MessageBox.Show("Kindly check Shelf details.");
                }
            }
            catch (Exception ee3)
            {
                MessageBox.Show(ee3.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Shelf";
            SqlDataAdapter d = new SqlDataAdapter(query, con);
            DataTable t = new DataTable();
            d.Fill(t);
            dataGridView1.DataSource = t;
            con.Close();
        }

        private void ReturnBooks_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    con.Open();
                    String selectQuery = "SELECT Shelf_No,Shelf_Name,Shelf_Description,Shelf_Location From Shelf where Shelf_NO='" + textBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    SqlDataReader mdr = cmd.ExecuteReader();

                    if (mdr.Read())
                    {
                        textBox3.Text = mdr.GetValue(0).ToString();
                        textBox4.Text = mdr.GetValue(1).ToString();
                        richTextBox1.Text = mdr.GetValue(2).ToString();
                        textBox2.Text = mdr.GetValue(3).ToString();                                             
                    }
                    else
                    {
                        MessageBox.Show("Shelf does not Exists !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Enter Shelf Number to Search.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ee4)
            {
                MessageBox.Show(ee4.Message);
            }           
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text!="")
                {
                    con.Open();
                   SqlCommand cmd = new SqlCommand("DELETE FROM Shelf WHERE Shelf_NO='"+ textBox3.Text + "' ",con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Shelf Removed Successfully !!","Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    textBox3.Text = "";
                    textBox1.Text = "";
                    textBox4.Text ="";
                    richTextBox1.Text = "";
                    textBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("Please Provide Shelf Number!");
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
            con.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox1.Text = "";
            textBox4.Text = "";
            richTextBox1.Text = "";
            textBox2.Text = "";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            textBoxShelfName.Text="";
            richTextBoxDescription.Text="";
            textBoxShelfLocation.Text ="";
        }

        private void Books_Paint(object sender, PaintEventArgs e)
        {

        }

        private void assignTeachers_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {

            if (guna2TextBox25.Text != "")
            {
                // Calculate what day of the week is 14 days from Today.
                System.DateTime today = System.DateTime.Now;
                System.TimeSpan duration = new System.TimeSpan(60, 0, 0, 0);
                System.DateTime answer = today.Add(duration);
                guna2DateTimePicker7.Value = answer;
                guna2DateTimePicker6.Value = DateTime.Now;
                try
                {
                    con.Open();
                    String selectQuery = "SELECT Book_ISBN,Tittle,Class From Books where Book_ISBN='" + guna2TextBox25.Text + "' and Status = 'Available'";
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    SqlDataReader mdr = cmd.ExecuteReader();

                    if (mdr.Read())
                    {
                        guna2TextBox26.Text = mdr.GetValue(0).ToString();
                        guna2TextBox27.Text = mdr.GetValue(1).ToString();
                        guna2TextBox29.Text = mdr.GetValue(2).ToString();
                    }
                    else
                    {
                        MessageBox.Show("No such Book in Library");
                    }
                }
                catch (Exception emm)
                {
                    MessageBox.Show(emm.Message);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Enter Book Number To search.");
            }
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2TextBox28.Text != "" && guna2TextBox22.Text != "" && guna2TextBox29.Text != "" && guna2TextBox26.Text!="" && guna2TextBox27.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("insert into Assign_Books(Teacher_No,Teacher_Name,Class,Book_ISBN,Tittle,Reason,Date_Assign,Due_Date) values (@Teacher_No,@Teacher_Name,@Class,@Book_ISBN,@Tittle,@Reason,@Date_Assign,@Due_Date)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@Teacher_No", guna2TextBox28.Text);
                    cmd.Parameters.AddWithValue("@Teacher_Name", guna2TextBox22.Text);
                    cmd.Parameters.AddWithValue("@Class", guna2TextBox29.Text);
                    cmd.Parameters.AddWithValue("@Book_ISBN", guna2TextBox26.Text);
                    cmd.Parameters.AddWithValue("@Tittle", guna2TextBox27.Text);
                    cmd.Parameters.AddWithValue("@Reason", guna2TextBox23.Text);
                    cmd.Parameters.AddWithValue("@Date_Assign", guna2DateTimePicker6.Value);
                    cmd.Parameters.AddWithValue("@Due_Date", guna2DateTimePicker7.Value);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("Update Books SET Status='Available' Where Book_ISBN='" + guna2TextBox26.Text + "'", con);
                    cmd1.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Book Assign Successfully.");
                    guna2TextBox28.Text="";
                    guna2TextBox22.Text="";
                    guna2TextBox29.Text="";
                    guna2TextBox26.Text="";
                    guna2TextBox27.Text="";                   
                   
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Kindly check All details.");
                }
            }
            catch (Exception ee3)
            {
                MessageBox.Show(ee3.Message);
            }
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Assign_Books";
            SqlDataAdapter d = new SqlDataAdapter(query, con);
            DataTable t = new DataTable();
            d.Fill(t);
            dataGridView2.DataSource = t;
            con.Close();
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            guna2TextBox28.Text = "";
            guna2TextBox22.Text = "";
            guna2TextBox29.Text = "";
            guna2TextBox26.Text = "";
            guna2TextBox27.Text = "";
            guna2TextBox25.Text = "";
        }

        private void guna2PictureBox9_Click(object sender, EventArgs e)
        {
            Shelves.Visible = false;
            main.Visible = false;
            Books.Visible = false;
            Users.Visible = false;
            magazines.Visible = true;
        }

        private void label41_Click(object sender, EventArgs e)
        {
            Shelves.Visible = false;
            main.Visible = false;
            Books.Visible = false;
            Users.Visible = false;
            magazines.Visible = true;
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {
            try
            {
                if(guna2TextBox24.Text !="" && guna2TextBox30.Text!="")
                {
                    SqlCommand cmd = new SqlCommand("insert into Magazinne(Magazinne_Name,Magazinne_Description,Date_Received) values (@Magazinne_Name,@Magazinne_Description,@Date_Received)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@Magazinne_Name", guna2TextBox24.Text);
                    cmd.Parameters.AddWithValue("@Magazinne_Description", guna2TextBox30.Text);
                    cmd.Parameters.AddWithValue("@Date_Received", guna2DateTimePicker8.Value);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Magazinne Received Successfully","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    guna2TextBox24.Text = "";
                    guna2TextBox30.Text = "";
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Provide all Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception em3)
            {
                MessageBox.Show(em3.Message);
            }           
        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            guna2TextBox24.Text = "";
            guna2TextBox30.Text = "";
        }

        private void guna2Button22_Click(object sender, EventArgs e)
        {

            if (guna2TextBox31.Text != "")
            {
                // Calculate what day of the week is 14 days from Today.
                System.DateTime today = System.DateTime.Now;
                System.TimeSpan duration = new System.TimeSpan( 5, 0, 0);
                System.DateTime answer = today.Add(duration);
                guna2DateTimePicker10.Value = answer;
                guna2DateTimePicker9.Value = DateTime.Now;
                try
                {
                    con.Open();
                    String selectQuery = "SELECT Magazinne_NO,Magazinne_Name From Magazinne where Magazinne_NO='" + guna2TextBox31.Text + "' ";
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    SqlDataReader mdr = cmd.ExecuteReader();

                    if (mdr.Read())
                    {
                        guna2TextBox32.Text = mdr.GetValue(0).ToString();
                        guna2TextBox33.Text = mdr.GetValue(1).ToString();                      
                    }
                    else
                    {
                        MessageBox.Show("No such Magazinne in Library");
                    }
                }
                catch (Exception emm)
                {
                    MessageBox.Show(emm.Message);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Enter Magazinne Number in Library");
            }
        }

        private void guna2Button24_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2TextBox33.Text != "" && guna2TextBox32.Text != "")
                {
                    string status = "Borrowed";
                    SqlCommand cmd = new SqlCommand("insert into Magazinne_Borrow(Magazinne_Name,Magazinne_No,Date_Borrow,Due_Date,Status) values (@Magazinne_Name,@Magazinne_No,@Date_Borrow,@Due_Date,@Status)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@Magazinne_Name", guna2TextBox33.Text);
                    cmd.Parameters.AddWithValue("@Magazinne_NO", guna2TextBox32.Text);
                    cmd.Parameters.AddWithValue("@Date_Borrow", guna2DateTimePicker9.Value);
                    cmd.Parameters.AddWithValue("@Due_Date", guna2DateTimePicker10.Value);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Magazinne Borrowed Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    guna2TextBox31.Text = "";
                    guna2TextBox33.Text = "";
                    guna2TextBox32.Text = "";
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Provide all Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception em3)
            {
                MessageBox.Show(em3.Message);
            }
        }

        private void guna2Button25_Click(object sender, EventArgs e)
        {
            guna2TextBox31.Text = "";
            guna2TextBox33.Text = "";
            guna2TextBox32.Text = "";
        }

        private void guna2Button27_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Magazinne_Borrow Where Status='Borrowed'";
            SqlDataAdapter d = new SqlDataAdapter(query, con);
            DataTable t = new DataTable();
            d.Fill(t);
            dataGridView3.DataSource = t;
            con.Close();
        }

        private void guna2Button26_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Magazinne";
            SqlDataAdapter d = new SqlDataAdapter(query, con);
            DataTable t = new DataTable();
            d.Fill(t);
            dataGridView3.DataSource = t;
            con.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel5books.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel5books.Visible = false;
            con.Open();
            string query = "SELECT * FROM Borrow_Books Where Reason = 'Borrow'";
            SqlDataAdapter d = new SqlDataAdapter(query, con);
            DataTable t = new DataTable();
            d.Fill(t);
            dataGridView4.DataSource = t;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {           
            panel5books.Visible = false;
            con.Open();
            string query = "SELECT * FROM Books where Status='Available' ";
            SqlDataAdapter d = new SqlDataAdapter(query, con);
            DataTable t = new DataTable();
            d.Fill(t);
            dataGridView4.DataSource = t;
            con.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel5shelf.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel5shelf.Visible = false;
            con.Open();
            string query = "SELECT * FROM Shelf ";
            SqlDataAdapter d = new SqlDataAdapter(query, con);
            DataTable t = new DataTable();
            d.Fill(t);
            dataGridView4.DataSource = t;
            con.Close();
        }

        private void button1_CursorChanged(object sender, EventArgs e)
        {

        }
    }
}
