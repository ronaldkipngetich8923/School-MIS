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
    public partial class DisciplineForm : Form
    {
        public DisciplineForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=shule;Integrated Security=True;");

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            try
            {

                if (guna2TextBox5.Text != "")
                {
                    con.Open();
                    String selectQuery = "SELECT AdmNO,Studname,Class,Stream,Term,Year From StudentMaster where AdmNO='" + guna2TextBox5.Text + "'";
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    SqlDataReader mdr = cmd.ExecuteReader();

                    if (mdr.Read())
                    {
                        guna2TextBox22.Text = mdr.GetValue(0).ToString();
                        guna2TextBox1.Text = mdr.GetValue(1).ToString();
                        guna2TextBox2.Text = mdr.GetValue(2).ToString();
                        guna2TextBox3.Text = mdr.GetValue(3).ToString();
                        guna2TextBox6.Text = mdr.GetValue(4).ToString();
                        guna2TextBox4.Text = mdr.GetValue(5).ToString();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("No such Student in this School");
                        con.Close();
                    }
                    
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Enter Adm No: to search.","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                con.Close();
            }
        }

        private void DisciplineForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            guna2DateTimePicker1.Text = DateTime.Now.ToString();
            guna2DateTimePicker2.Text = DateTime.Now.ToString();

            // Loads data from Discipline table
            string query = "SELECT * FROM Discipline";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2TextBox22.Text != "" && guna2TextBox1.Text != "" && richTextBox2.Text!="" && richTextBox1.Text!="" &&guna2TextBox2.Text != "" && guna2TextBox3.Text != "" && guna2TextBox6.Text!="" && guna2TextBox4.Text!="")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Discipline (AdmNo,Studname,Form,Stream,Term,Year,DateOfIssued,ReportingDate,Disc_Case,Penalty) Values(@AdmNo,@Studname,@Form,@Stream,@Term,@Year,@DateOfIssued,@ReportingDate,@Case,@Penalty)", con);
                    cmd.Parameters.AddWithValue("@AdmNo", guna2TextBox22.Text);
                    cmd.Parameters.AddWithValue("@Studname", guna2TextBox1.Text);
                    cmd.Parameters.AddWithValue("@Form", guna2TextBox2.Text);
                    cmd.Parameters.AddWithValue("@Stream", guna2TextBox3.Text);
                    cmd.Parameters.AddWithValue("@Term", guna2TextBox6.Text);
                    cmd.Parameters.AddWithValue("@Year", guna2TextBox4.Text);
                    cmd.Parameters.AddWithValue("@DateOfIssued", guna2DateTimePicker2.Value);
                    cmd.Parameters.AddWithValue("@ReportingDate", guna2DateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Case", richTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Penalty", richTextBox2.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Disciplinary action Successfully Served.","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    string query = "SELECT * FROM Discipline";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt.DefaultView;

                    guna2TextBox22.Text = "";
                    guna2TextBox1.Text = "";
                    richTextBox2.Text = "";
                    richTextBox1.Text = "";
                    guna2TextBox2.Text = "";
                    guna2TextBox3.Text = "";
                    guna2TextBox6.Text = "";
                    guna2TextBox4.Text = "";
                    guna2TextBox5.Text = "";
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Provide all Details.","Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                con.Close();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2TextBox22.Text = "";
            guna2TextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2TextBox3.Text = "";
            guna2TextBox6.Text = "";
            guna2TextBox4.Text = "";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Discipline";
                SqlDataAdapter sda = new SqlDataAdapter(query,con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            //textBoxId.Text = row.Cells[0].Value.ToString();
            
            guna2TextBox22.Text = row.Cells[1].Value.ToString();
            guna2TextBox1.Text = row.Cells[2].Value.ToString();
            richTextBox2.Text = row.Cells[10].Value.ToString();
            richTextBox1.Text = row.Cells[9].Value.ToString();
            guna2TextBox2.Text = row.Cells[3].Value.ToString();
            guna2TextBox3.Text = row.Cells[4].Value.ToString();
            guna2TextBox6.Text = row.Cells[5].Value.ToString();
            guna2TextBox4.Text = row.Cells[6].Value.ToString();
            guna2DateTimePicker1.Text = row.Cells[8].Value.ToString();
            guna2DateTimePicker2.Text = row.Cells[7].Value.ToString();
        }
    }
}
