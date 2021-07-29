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
    public partial class Fees_Structure : Form
    {
        public Fees_Structure()
        {
            InitializeComponent();
            comboBoxYearFill();
            comboBoxClassFill();
            comboBoxStreamFill();
            comboBoxTermFill();
        }

        SqlConnection con = new SqlConnection("Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=shule;Integrated Security=True;");
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
           // decimal sum1; 
            //int i;
            if (guna2ComboBoxClass.SelectedItem!=null && guna2ComboBoxStream.SelectedItem!= null && guna2ComboBoxYear.SelectedItem != null && guna2ComboBoxTerm.SelectedItem != null && labelFID.Text!="")
            {
                try
                {
                    string query = "SELECT * FROM fees_SetUp Where Form = '" + guna2ComboBoxClass.SelectedItem + "' AND Stream = '" + guna2ComboBoxStream.SelectedItem + "' AND Year = '" + guna2ComboBoxYear.SelectedItem + "' AND Term = '" + guna2ComboBoxTerm.SelectedItem + "'";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    SDA.Fill(dt);
                    dataGridView1.DataSource = dt.DefaultView;

                    guna2TextBoxTotalFee.Show();
                    labelFID.Show();
                    labelFIDL.Show();

                    SqlCommand cmd = new SqlCommand("SELECT SUM(Fees_Vote_Amount) AS FEES_AMOUNT FROM fees_SetUp Where Form = '" + guna2ComboBoxClass.SelectedItem + "' AND Stream = '" + guna2ComboBoxStream.SelectedItem + "' AND Year = '" + guna2ComboBoxYear.SelectedItem + "' AND Term = '" + guna2ComboBoxTerm.SelectedItem + "'", con);
                    con.Open();

                    SqlDataReader sqlDataReader = cmd.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        string sName = sqlDataReader["FEES_AMOUNT"].ToString();

                        guna2TextBoxTotalFee.Text = sName.ToString();

                    }

                    labelFID.Text = guna2ComboBoxClass.Text + guna2ComboBoxStream.Text + guna2ComboBoxYear.Text + guna2ComboBoxTerm.Text;
                    con.Close();
                }
                catch (Exception em)
                {
                    MessageBox.Show(em.Message);
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Kindly select Form, Term, Stream, Year !!");
                con.Close();
            }
        }

        private void Fees_Structure_Load(object sender, EventArgs e)
        {
            // this.WindowState = FormWindowState.Maximized;
            labelFID.Hide();
            labelFIDL.Hide();
            guna2TextBoxTotalFee.Hide();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM fee_Structure", con);
                DataTable ds = new DataTable();
                da.Fill(ds);
                dataGridView1.DataSource = ds.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void comboBoxYearFill()
        {
            string cmdStr = " SELECT *  FROM Year";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, con);
            try
            {
                con.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["Year"].ToString();
                    guna2ComboBoxYear.Items.Add(sName);
                }
                sqlDataReader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void comboBoxTermFill()
        {
            string cmdStr = " SELECT *  FROM Term";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, con);
            try
            {
                con.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["Term"].ToString();
                    guna2ComboBoxTerm.Items.Add(sName);
                }
                sqlDataReader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void comboBoxClassFill()
        {
            string cmdStr = " SELECT *  FROM Classes";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, con);
            try
            {
                con.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["ClassName"].ToString();
                    guna2ComboBoxClass.Items.Add(sName);
                }
                sqlDataReader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void comboBoxStreamFill()
        {

            string cmdStr = " SELECT *  FROM Streams";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, con);
            try
            {
                con.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["StreamName"].ToString();
                    guna2ComboBoxStream.Items.Add(sName);
                }
                sqlDataReader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2ComboBoxClass.Text != "" && guna2ComboBoxStream.Text != "" && guna2ComboBoxYear.Text != "" && guna2ComboBoxTerm.Text != "" && guna2TextBoxTotalFee.Text!="" && labelFID.Text!="")
                {
                    SqlCommand cmd = new SqlCommand("insert into fee_Structure(Fee_StructureID,Class,Stream,Year,Term,Total_Amount) values(@FeeID,@Class,@Stream,@Year,@Term,@TotalAmount)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@FeeID", labelFID.Text);
                    cmd.Parameters.AddWithValue("@Class", guna2ComboBoxClass.Text);
                    cmd.Parameters.AddWithValue("@Stream", guna2ComboBoxStream.Text);
                    cmd.Parameters.AddWithValue("@Year", guna2ComboBoxYear.Text);
                    cmd.Parameters.AddWithValue("@Term", guna2ComboBoxTerm.Text);
                    cmd.Parameters.AddWithValue("@TotalAmount", guna2TextBoxTotalFee.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Saved");
                    guna2TextBoxTotalFee.Text = "";
                }
                else
                {
                    MessageBox.Show(" Kindly Check if ALL fields are Filled !!");
                }
            }
            catch 
            {
                MessageBox.Show("Please, Fees structure already Exist!!");
               //dataGridView1.DataSource = null;
               // dataGridView1.Rows.Clear();
                guna2TextBoxTotalFee.Hide();
                labelFID.Text="";
                guna2ComboBoxClass.Text="";
                guna2ComboBoxStream.Text="";
                guna2ComboBoxYear.Text="";
                guna2ComboBoxTerm.Text="";
                guna2TextBoxTotalFee.Text="";

            }
           
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFeeStructure frm = new AddFeeStructure();
            frm.Show();
            
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //AssignFeesToClass af = new AssignFeesToClass();
            //af.Show();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM fee_Structure", con);
                DataTable ds = new DataTable();
                da.Fill(ds);
                dataGridView1.DataSource = ds.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            int i;
            try
            {
                SqlCommand cmd = new SqlCommand();
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    i = dataGridView1.SelectedCells[0].ColumnIndex;
                    if (dataGridView1.Rows.Count > 1 && i != dataGridView1.Rows.Count - 1)
                    {
                        cmd.CommandText = "DELETE FROM fee_Structure WHERE FS_ID=" + dataGridView1.SelectedRows[i].Cells[0].Value.ToString() + "";
                        con.Open();
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[i].Index);

                        MessageBox.Show("Row Deleted","",MessageBoxButtons.OK,MessageBoxIcon.Information);

                        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM fee_Structure", con);
                        DataTable ds = new DataTable();
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.DefaultView;

                    }
                }
                else
                {
                    MessageBox.Show("Please select Fees to be Deleted."," MESSAGE ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM fee_Structure", con);
                DataTable ds = new DataTable();
                da.Fill(ds);
                dataGridView1.DataSource = ds.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
           
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE fee_Structure where Fee_structureID='"+ labelFID.Text+"' ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fees Structure Updated","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                guna2TextBoxTotalFee.Hide();
                labelFID.Text = "";
                guna2ComboBoxClass.Text = "";
                guna2ComboBoxStream.Text = "";
                guna2ComboBoxYear.Text = "";
                guna2ComboBoxTerm.Text = "";
                guna2TextBoxTotalFee.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"MESSAGE",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
