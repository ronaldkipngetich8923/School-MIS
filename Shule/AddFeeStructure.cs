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
    public partial class AddFeeStructure : Form
    {
        SqlConnection con = new SqlConnection("Data source = DESKTOP - AOUGB8E\\SQLEXPRESS; initial catalog = shule; integrated security = True");
        SqlCommand cmd;
        SqlDataReader sqlDataReader;
        DataTable Fee_Set = new DataTable();
        int indexRow;

        public AddFeeStructure()
        {
            InitializeComponent();
        }

        public void ComboYearFill()
        {
            
           
            string cmdStr = " SELECT *  FROM Year";
            cmd = new SqlCommand(cmdStr, con);
            try
            {

                con.Open();

                sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["Year"].ToString();

                    textBoxYear.Items.Add(sName);
                    


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }


        private void AddFeeStructure_Load(object sender, EventArgs e)
        {
            textBoxYear.Items.Insert(0, "..Select Year..");
            textBoxYear.SelectedIndex = 0;

            //this.WindowState = FormWindowState.Maximized;
            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM fees_SetUp", con);
            //DataSet ds = new DataSet();
            //da.Fill(ds, "fees_SetUp");
            //dataGridView1.DataSource = ds.Tables["fees_SetUp"].DefaultView;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            labelfees.Hide();
            textBoxId.Hide();
            checkBox1.Hide();
            checkBox2.Hide();

            if (textBoxYear.SelectedIndex != 0 && guna2ComboBoxForm.Text != "" && guna2ComboBoxStream.Text != "" && guna2ComboBoxTerm.Text != "" && guna2ComboBoxFvote.Text != "" && textBoxFeesDescr.Text != "" && textBoxAmount.Text != "")
            {
                cmd = new SqlCommand("insert into fees_SetUp(Fees_Vote,Fees_Vote_Description,Fees_Vote_Amount,Form,Stream,Year,Term) values (@Fees_Vote,@Fees_Vote_Description,@Fees_Vote_Amount,@Form,@Stream,@Year,@Term)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Year", textBoxYear.SelectedItem);
                cmd.Parameters.AddWithValue("@Form", guna2ComboBoxForm.Text);
                cmd.Parameters.AddWithValue("@Stream", guna2ComboBoxStream.Text);
                cmd.Parameters.AddWithValue("@Term", guna2ComboBoxTerm.Text);
                cmd.Parameters.AddWithValue("@Fees_Vote", guna2ComboBoxFvote.Text);
                cmd.Parameters.AddWithValue("@Fees_Vote_Description", textBoxFeesDescr.Text);
                cmd.Parameters.AddWithValue("@Fees_Vote_Amount", textBoxAmount.Text);               
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Fees Vote Created Successfully");

                textBoxYear.Text = "";
                guna2ComboBoxForm.SelectedItem = null;
                guna2ComboBoxStream.SelectedItem = null;
                guna2ComboBoxTerm.SelectedItem = null;
                guna2ComboBoxFvote.SelectedItem = null;
                textBoxFeesDescr.Text = "";
                textBoxAmount.Text = "";           
            }
            else
            {
                MessageBox.Show("Please Provide All Details!");
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM fees_SetUp order by Form", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "fees_SetUp");
            dataGridView1.DataSource = ds.Tables["fees_SetUp"].DefaultView;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxYear.Text != "" && guna2ComboBoxForm.Text != "" && guna2ComboBoxStream.Text != "" && guna2ComboBoxTerm.Text != "" && guna2ComboBoxFvote.Text != "" && textBoxFeesDescr.Text != "" && textBoxAmount.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE fees_SetUp SET Fees_Vote='" + guna2ComboBoxFvote.SelectedItem + "',Fees_Vote_Description='" + textBoxFeesDescr.Text + "',Fees_Vote_Amount='" + textBoxAmount.Text + "',Form='" + guna2ComboBoxForm.SelectedItem + "',Stream='" + guna2ComboBoxStream.SelectedItem + "',Year='" + textBoxYear.Text + "',Term='" + guna2ComboBoxTerm.SelectedItem + "' where Fees_Set_UpID='" + textBoxId.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fees Vote Updated Successfully");

                    textBoxYear.Text = "";
                    guna2ComboBoxForm.SelectedItem = null;
                    guna2ComboBoxStream.SelectedItem = null;
                    guna2ComboBoxTerm.SelectedItem = null;
                    guna2ComboBoxFvote.SelectedItem = null;
                    textBoxFeesDescr.Text = "";
                    textBoxAmount.Text = "";
                    labelfees.Hide();
                    textBoxId.Hide();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please Select Record to Update");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelfees.Show();
            textBoxId.Show();
            checkBox1.Show();
            checkBox2.Show();

            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            textBoxId.Text = row.Cells[0].Value.ToString();
            guna2ComboBoxFvote.Text = row.Cells[1].Value.ToString();
            textBoxFeesDescr.Text = row.Cells[2].Value.ToString();
            textBoxAmount.Text = row.Cells[3].Value.ToString();
            guna2ComboBoxForm.Text = row.Cells[4].Value.ToString();
            guna2ComboBoxStream.Text = row.Cells[5].Value.ToString();
            textBoxYear.Text = row.Cells[6].Value.ToString();
            guna2ComboBoxTerm.Text = row.Cells[7].Value.ToString();            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fees_Structure fs = new Fees_Structure();
            fs.Show();
        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
