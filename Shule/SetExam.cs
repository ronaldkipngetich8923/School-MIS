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
    public partial class SetExam : Form
    {
        SqlConnection sqlConnection;
        SqlDataReader sqlDataReader;
        SqlDataAdapter sqlDataAdapter;
        public SetExam()
        {
            InitializeComponent();
            CombosubjectFill();
            ComboTeachersFill();
        }
        public void CombosubjectFill()
        {
            string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            sqlConnection = new SqlConnection(connStr);
            string cmdStr = " SELECT *  FROM Subject";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {

                sqlConnection.Open();

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["SubjectDescription"].ToString();

                    comboSubjects.Items.Add(sName);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ComboTeachersFill()
        {
            string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            sqlConnection = new SqlConnection(connStr);
            string cmdStr = " SELECT *  FROM TeachersTable";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {

                sqlConnection.Open();

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["FullName"].ToString();

                    conboBoxSetBy.Items.Add(sName);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void btnSetExamsSave_Click(object sender, EventArgs e)
        {
            string qur = "INSERT INTO SetExams VALUES ('" + txtYear.Text + "','" + txtTerm.Text + "','" + txtExamCode.Text + "','" + comboExamType.SelectedItem + "','" + comboCategory.SelectedItem + "'," +
              "'" + comboSubjects.SelectedItem + "','" + txtWeight.Text + "','" + conboBoxSetBy.SelectedItem + "','" + guna2DateTimePickerSetDate.Text + "','" + guna2DateTimePicker2IssueDate.Text + "')";
            SqlCommand cmd = new SqlCommand(qur, sqlConnection);
            try
            {
                sqlConnection.Close();
                sqlConnection.Open();
                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show(rows + " Exam added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetExam_Load(object sender, EventArgs e)
        {
            string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            sqlConnection = new SqlConnection(connStr);
            conboBoxSetBy.SelectedIndex = 0;
            comboSubjects.SelectedIndex = 0;

        }

        private void btnSubjectSave_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
            string query = "SELECT * FROM SetExams";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1SetExam.DataSource = dt;

            sqlConnection.Open();
        }

        private void btnSubjectReset_Click(object sender, EventArgs e)
        {

        }
    }


}


