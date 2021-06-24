using Shule.Properties;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;



namespace Shule
{
    public partial class Home : Form
    {
        SqlConnection sqlConnection;
        SqlDataReader sqlDataReader;
        SqlDataAdapter sqlDataAdapter;
        private bool isCollapsed;
        //  SetExam sr = new SetExam();



        public Home()
        {
            InitializeComponent();

            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AOUGB8E\SQLEXPRESS;Initial Catalog=shule;Integrated Security=True");

            customizeDesign();
            ComboclassFill();
            ComboStreamFill();
            ComboExamTypeFill();
            CombosubjectFill();
            ComboExamCodeFill();
            ComboYearFill();
            ComboTermFill();


            // hideSubmenu();
        }
        int indexRow;

        int Average;
        int TotalScoreForCats;
        int TotalScores;
        int Grades;

        public void ComboTermFill()
        {
            string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            sqlConnection = new SqlConnection(connStr);
            string cmdStr = " SELECT *  FROM SetExams";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {

                sqlConnection.Open();

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["Term"].ToString();

                    comboBoxTerm.Items.Add(sName);
                    RcomboBoxTerm.Items.Add(sName);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }






        public void ComboYearFill()
        {
            string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            sqlConnection = new SqlConnection(connStr);
            string cmdStr = " SELECT *  FROM SetExams";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {

                sqlConnection.Open();

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["Year"].ToString();

                    comboBoxYear.Items.Add(sName);
                    RcomboBoxYear.Items.Add(sName);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

                    comboBoxSubjects.Items.Add(sName);
                    RcomboBoxSubject.Items.Add(sName);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ComboExamCodeFill()
        {
            string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            sqlConnection = new SqlConnection(connStr);
            string cmdStr = " SELECT *  FROM SetExams";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {

                sqlConnection.Open();

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["ExamCode"].ToString();

                    comboBoxExamCode.Items.Add(sName);
                    RcomboBoxExamCode.Items.Add(sName);
                    comboBoxRExamCode.Items.Add(sName);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        public void ComboStreamFill()
        {
            string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            sqlConnection = new SqlConnection(connStr);
            string cmdStr = " SELECT *  FROM Streams";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);

            try
            {

                sqlConnection.Open();

                sqlDataReader = sqlCommand.ExecuteReader();


                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["StreamName"].ToString();


                    comboBoxStream.Items.Add(sName);

                    comboBoxStreams.Items.Add(sName);
                    comboBoxRstream.Items.Add(sName);
                    //  RcomboBoxStream.Items.Add(sName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ComboExamTypeFill()
        {
            string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            sqlConnection = new SqlConnection(connStr);
            string cmdStr = " SELECT *  FROM SetExams";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {

                sqlConnection.Open();

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["ExamType"].ToString();
                    string examcategory = sqlDataReader["Category"].ToString();



                    comboBoxExamType.Items.Add(sName);
                    comboBoxExamCategory.Items.Add(examcategory);
                    RcomboBoxExamCategory.Items.Add(examcategory);
                    ExamTypecombo.Items.Add(sName);



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ComboclassFill()
        {
            string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            sqlConnection = new SqlConnection(connStr);
            string cmdStr = " SELECT *  FROM Classes";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {

                sqlConnection.Open();

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string sName = sqlDataReader["ClassName"].ToString();

                    comboBoxClass.Items.Add(sName);
                    guna2ComboBox1.Items.Add(sName);
                    comboBoxForm.Items.Add(sName);
                    comboBoxRForm.Items.Add(sName);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        private void customizeDesign()
        {
            panelAcademic.Visible = false;
            panelDropFinance.Visible = false;
            panelmDropDown.Visible = false;
            panelDropDispensary.Visible = false;
            panelDropLibrary.Visible = false;
            panelDropHostel.Visible = false;
            panelDropTransport.Visible = false;


        }

        private void hideSubMenu()
        {
            if (panelAcademic.Visible == true)
                panelAcademic.Visible = false;
            if (panelDropFinance.Visible == true)
                panelDropFinance.Visible = false;
            if (panelmDropDown.Visible == true)
                panelmDropDown.Visible = false;
            if (panelDropDispensary.Visible == true)
                panelDropDispensary.Visible = false;
            if (panelDropLibrary.Visible == true)
                panelDropLibrary.Visible = false;
            if (panelDropHostel.Visible == true)
                panelDropHostel.Visible = false;
            if (panelDropTransport.Visible == true)
                panelDropTransport.Visible = false;

            //panelDropDown.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }







        private void button2_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAcademic);




            Academic.Visible = true;
            AdmissionPanel.Visible = false;
            Finance.Visible = false;
            Library.Visible = false;
            Hostel.Visible = false;
            Transport.Visible = false;
            Dispensary.Visible = false;
            Payroll.Visible = false;
            ExamsResults.Visible = false;
            SetupParameter.Visible = false;
            ManageStaff.Visible = false;
            subordinatestaff.Visible = false;
            Teachingstaff.Visible = false;
        }

        private void AdmissionBtn_Click(object sender, EventArgs e)
        {
            //showSubMenu(panel4AdmissionSubMenu);
            timer1.Start();


            Academic.Visible = false;
            AdmissionPanel.Visible = true;
            Finance.Visible = false;
            Dispensary.Visible = false;
            Library.Visible = false;
            Hostel.Visible = false;
            Transport.Visible = false;
            Payroll.Visible = false;
            ExamsResults.Visible = false;
            SetupParameter.Visible = false;
            ManageStaff.Visible = false;
            Teachingstaff.Visible = false;
            subordinatestaff.Visible = false;
            StudentsDetailsPanel.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDropFinance);


            Academic.Visible = false;
            AdmissionPanel.Visible = false;
            Finance.Visible = true;
            Library.Visible = false;
            Hostel.Visible = false;
            Dispensary.Visible = false;
            Transport.Visible = false;
            Payroll.Visible = false;
            ExamsResults.Visible = false;
            SetupParameter.Visible = false;
            ManageStaff.Visible = false;
            Teachingstaff.Visible = false;
            subordinatestaff.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDropLibrary);



            Academic.Visible = false;
            AdmissionPanel.Visible = false;
            Finance.Visible = false;
            Library.Visible = true;
            Hostel.Visible = false;
            Dispensary.Visible = false;
            Transport.Visible = false;
            Payroll.Visible = false;
            ExamsResults.Visible = false;
            SetupParameter.Visible = false;
            ManageStaff.Visible = false;
            Teachingstaff.Visible = false;
            subordinatestaff.Visible = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDropHostel);


            Academic.Visible = false;
            AdmissionPanel.Visible = false;
            Finance.Visible = false;
            Library.Visible = false;
            Hostel.Visible = true;
            Transport.Visible = false;
            Dispensary.Visible = false;
            Payroll.Visible = false;
            ExamsResults.Visible = false;
            SetupParameter.Visible = false;
            ManageStaff.Visible = false;
            Teachingstaff.Visible = false;
            subordinatestaff.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDropTransport);


            Academic.Visible = false;
            AdmissionPanel.Visible = false;
            Finance.Visible = false;
            Library.Visible = false;
            Hostel.Visible = false;
            Transport.Visible = true;
            Dispensary.Visible = false;
            Payroll.Visible = false;
            ExamsResults.Visible = false;
            SetupParameter.Visible = false;
            ManageStaff.Visible = false;
            subordinatestaff.Visible = false;
            Teachingstaff.Visible = false;

        }

        private void button9_Click(object sender, EventArgs e)
        {

            showSubMenu(panelDropDispensary);


            Academic.Visible = false;
            AdmissionPanel.Visible = false;
            Finance.Visible = false;
            Library.Visible = false;
            Hostel.Visible = false;
            Transport.Visible = false;
            Dispensary.Visible = true;
            Payroll.Visible = false;
            ExamsResults.Visible = false;
            SetupParameter.Visible = false;
            ManageStaff.Visible = false;
            Teachingstaff.Visible = false;
            subordinatestaff.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Academic.Visible = false;
            AdmissionPanel.Visible = false;
            Finance.Visible = false;
            Library.Visible = false;
            Hostel.Visible = false;
            Transport.Visible = false;
            Dispensary.Visible = false;
            Payroll.Visible = true;
            ExamsResults.Visible = false;
            SetupParameter.Visible = false;
            ManageStaff.Visible = false;
            subordinatestaff.Visible = false;
            Teachingstaff.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Academic.Visible = false;
            AdmissionPanel.Visible = false;
            Finance.Visible = false;
            Library.Visible = false;
            Hostel.Visible = false;
            Transport.Visible = false;
            Dispensary.Visible = false;
            Payroll.Visible = false;
            ExamsResults.Visible = true;
            SetupParameter.Visible = false;
            ManageStaff.Visible = false;
            Teachingstaff.Visible = false;
            subordinatestaff.Visible = false;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            ExamsResults.Visible = false;
            Academic.Visible = false;
            AdmissionPanel.Visible = false;
            Finance.Visible = false;
            Library.Visible = false;
            Hostel.Visible = false;
            Transport.Visible = false;
            Dispensary.Visible = false;
            Payroll.Visible = false;
            SetupParameter.Visible = true;
            ManageStaff.Visible = false;
            Teachingstaff.Visible = false;
            subordinatestaff.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            showSubMenu(panelmDropDown);



            ExamsResults.Visible = false;
            Academic.Visible = false;
            AdmissionPanel.Visible = false;
            Finance.Visible = false;
            Library.Visible = false;
            Hostel.Visible = false;
            Transport.Visible = false;
            Dispensary.Visible = false;
            Payroll.Visible = false;
            SetupParameter.Visible = false;
            ManageStaff.Visible = true;
            Teachingstaff.Visible = false;
            subordinatestaff.Visible = false;
        }

        private void ManageStaff_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ExamsResults.Visible = false;
            Academic.Visible = false;
            AdmissionPanel.Visible = false;
            Finance.Visible = false;
            Library.Visible = false;
            Hostel.Visible = false;
            Transport.Visible = false;
            Dispensary.Visible = false;
            Payroll.Visible = false;
            SetupParameter.Visible = false;
            ManageStaff.Visible = false;
            subordinatestaff.Visible = true;
            Teachingstaff.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ExamsResults.Visible = false;
            Academic.Visible = false;
            AdmissionPanel.Visible = false;
            Finance.Visible = false;
            Library.Visible = false;
            Hostel.Visible = false;
            Transport.Visible = false;
            Dispensary.Visible = false;
            Payroll.Visible = false;
            SetupParameter.Visible = false;
            ManageStaff.Visible = false;
            subordinatestaff.Visible = false;
            Teachingstaff.Visible = true;

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {
            AddClass cl = new AddClass();
            cl.Show();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Stream st = new Stream();
            st.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AddSubjects sr = new AddSubjects();
            sr.Show();


        }

        private void button32_Click(object sender, EventArgs e)
        {
            AddHostel hr = new AddHostel();
            hr.Show();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            AddSupplier sr = new AddSupplier();
            sr.Show();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            AddSchoolInfo sr = new AddSchoolInfo();
            sr.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddUsers sr = new AddUsers();
            sr.Show();

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddVehicle rs = new AddVehicle();
            rs.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddDriver rs = new AddDriver();
            rs.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddRoutes rs = new AddRoutes();
            rs.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddStudentTransport rs = new AddStudentTransport();
            rs.Show();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            AddFeeStructure sr = new AddFeeStructure();
            sr.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void guna2ButtonStudents_Click(object sender, EventArgs e)
        {

        }

        private void guna2ButtonPreviousAcademics_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                AdmissionBtn.Image = Resources.caretdown;

                panelDropDownForAdmission.Height += 10;

                if (panelDropDownForAdmission.Size == panelDropDownForAdmission.MaximumSize)

                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                AdmissionBtn.Image = Resources.caretside;

                panelDropDownForAdmission.Height -= 10;

                if (panelDropDownForAdmission.Size == panelDropDownForAdmission.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnTeachingStaff_Click(object sender, EventArgs e)
        {
            // hideSubMenu();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            //  hideSubMenu();
        }

        private void panelDropFinance_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            ExamsResults.Visible = false;
            Academic.Visible = false;
            AdmissionPanel.Visible = false;
            Finance.Visible = false;
            Library.Visible = false;
            Hostel.Visible = false;
            Transport.Visible = false;
            Dispensary.Visible = false;
            Payroll.Visible = false;
            SetupParameter.Visible = false;
            ManageStaff.Visible = false;
            subordinatestaff.Visible = false;
            Teachingstaff.Visible = false;
            AttendancePortal rs = new AttendancePortal();
            rs.Show();


        }

        private void studentsTab_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // SqlCommand cmd = new SqlCommand(qur, sqlConnection);
        // cmd.ExecuteNonQuery();
        // con.Close();
        // MessageBox.Show("Inserted sucessfully");
        //   textBoxstudent.Text = "";
        //textBox2.Text = "";
        // textBoxadmNo.Text = "";
        // textBox4.Text = "";
        //dateTimePickerDOB.Value = "";
        // comboBoxGender.SelectedValue = "";
        // comboBoxcounty.SelectedValue = "";
        // textBoxSchoolPrimary.Text = "";
        //textBoxKcpe.Text = "";
        //comboBoxDisabled.SelectedValue = "";
        // richTextBoxDescribeDis.Text = "";
        //comboBoxClass.SelectedValue = "";
        //comboBoxStream.SelectedValue = "";
        //textBoxParentName.Text = "";
        //textBoxPhoneNo.Text = "";
        // textBoxEmail.Text = "";
        // richTextBoxPostalAddress.Text = "";
        // textBoxTown.Text = "";



        private void Home_Load(object sender, EventArgs e)
        {
            string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            sqlConnection = new SqlConnection(connStr);

            //StudentScore GridView

            string query = "SELECT * FROM Exams";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1StudentsScores.DataSource = dt;

            comboBoxGender.SelectedIndex = 0;
            comboBoxCounty.SelectedIndex = 0;
            comboBoxDisability.SelectedIndex = 1;
            comboBoxClass.SelectedIndex = 0;
            comboBoxStream.SelectedIndex = 0;
            comboBoxExamType.SelectedIndex = 0;
            // comboBoxSubjects.SelectedIndex = 0;
            comboBoxForm.SelectedIndex = 0;
            comboBoxStreams.SelectedIndex = 0;


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
            string query = "SELECT * FROM StudentMaster";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            StudentGridView.DataSource = dt;

            sqlConnection.Open();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentGridView.Rows.Add(textBoxAdmNo.Text, textBoxStudname.Text, dateTimePickerDob.Text, comboBoxGender.SelectedItem, comboBoxCounty.SelectedItem, textBoxPrimarySch.Text, textBoxKCPEMarks.Text, comboBoxDisability.SelectedItem,
                richTextBoxDisabilityDescription.Text, comboBoxClass.SelectedItem, comboBoxStream.SelectedItem, dateTimePicker1AdmDate.Text, textBoxPhoneNo.Text, textBoxEmail.Text, richTextBoxPostalAddress.Text, textBoxTown.Text);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            StudentsDetailsPanel.Visible = true;
            StudentsDetailsPanel.BringToFront();


            sqlConnection.Close();
            string query = "SELECT * FROM StudentMaster";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView3StudentsDetails.DataSource = dt;

            sqlConnection.Open();

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            sqlConnection = new SqlConnection(connStr);
            string qur = "UPDATE StudentMaster SET Studname='" + textBoxStudname.Text + "',Dob='" + dateTimePickerDob.Text + "',Gender='" + comboBoxGender.SelectedItem + "',County='" + comboBoxCounty.SelectedItem + "',PrimarySch ='" + textBoxPrimarySch.Text + "',KCPEMarks='" + textBoxKCPEMarks.Text + "',Disability='" + comboBoxDisability.SelectedItem + "',DisabilityDescription='" + richTextBoxDisabilityDescription.Text + "',Class='" + comboBoxClass.SelectedItem + "',Stream='" + comboBoxStream.SelectedItem + "',AdmDate='" + dateTimePicker1AdmDate.Text + "',Parentname='" + textBoxParentname.Text + "',PhoneNo='" + textBoxPhoneNo.Text + "',Email='" + textBoxEmail.Text + "',PostalAddress='" + richTextBoxPostalAddress.Text + "',Town='" + textBoxTown.Text + "' WHERE AdmNo='" + textBoxAdmNo.Text + "' ";
            SqlDataAdapter sqlData = new SqlDataAdapter(qur, sqlConnection);

            try
            {
                sqlConnection.Close();

                sqlConnection.Open();

                sqlData.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Record Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button1TeachersRecords_Click(object sender, EventArgs e)
        {
            string qur = "INSERT INTO TeachersTable VALUES ('" + txtStaffId.Text + "','" + comboBoxStaffType.SelectedItem + "','" + txtFullName.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "'," +
                "'" + guna2DateTimePicker1DateOfRecruit.Text + "','" + txtPayrollNo.Text + "','" + txtSalary.Text + "','" + comboBoxDepartmentAssigned.Text + "')";
            SqlCommand cmd = new SqlCommand(qur, sqlConnection);
            try
            {
                sqlConnection.Close();
                sqlConnection.Open();
                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show(rows + " Staff Member inserted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxStream_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedIndex == 0)
            {
                sqlConnection.Close();
                string query = "SELECT * FROM StudentMaster WHERE Class='FORM 1'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView3StudentsDetails.DataSource = dt;

                sqlConnection.Open();
            }
            else if (guna2ComboBox1.SelectedIndex == 1)
            {
                sqlConnection.Close();
                string query = "SELECT * FROM StudentMaster WHERE Class='FORM 2'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView3StudentsDetails.DataSource = dt;

                sqlConnection.Open();

            }
            else if (guna2ComboBox1.SelectedIndex == 2)
            {
                sqlConnection.Close();
                string query = "SELECT * FROM StudentMaster WHERE Class='FORM 3'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView3StudentsDetails.DataSource = dt;

                sqlConnection.Open();

            }
            else if (guna2ComboBox1.SelectedIndex == 3)
            {
                sqlConnection.Close();
                string query = "SELECT * FROM StudentMaster WHERE Class='FORM 4'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView3StudentsDetails.DataSource = dt;

                sqlConnection.Open();

            }
        }

        private void btnSaveStudents_Click(object sender, EventArgs e)
        {
            string qur = "INSERT INTO StudentMaster VALUES ('" + textBoxAdmNo.Text + "','" + textBoxStudname.Text + "','" + dateTimePickerDob.Text + "','" + comboBoxGender.SelectedItem + "','" + comboBoxCounty.SelectedItem + "'," +
                "'" + textBoxPrimarySch.Text + "','" + textBoxKCPEMarks.Text + "','" + comboBoxDisability.SelectedItem + "','" + richTextBoxDisabilityDescription.Text + "'," +
                "'" + comboBoxClass.SelectedItem + "','" + comboBoxStream.SelectedItem + "','" + dateTimePicker1AdmDate.Text + "','" + textBoxParentname.Text + "'," +
                "'" + textBoxPhoneNo.Text + "','" + textBoxEmail.Text + "','" + richTextBoxPostalAddress.Text + "','" + textBoxTown.Text + "')";
            SqlCommand cmd = new SqlCommand(qur, sqlConnection);
            try
            {
                sqlConnection.Close();
                sqlConnection.Open();
                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show(rows + "  row inserted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxStudname.Clear();
            textBoxAdmNo.Clear();
            //dateTimePickerDob.MinimumDatetime();
            // comboBoxGender.Items.Clear();
            // comboBoxCounty.Items.Clear();
            textBoxPrimarySch.Clear();
            textBoxKCPEMarks.Clear();
            // comboBoxDisability.Items.Clear();
            richTextBoxDisabilityDescription.Clear();
            // comboBoxClass.Items.Clear();
            // comboBoxStream.Items.Clear();
            textBoxParentname.Clear();
            textBoxPhoneNo.Clear();
            textBoxEmail.Clear();
            richTextBoxPostalAddress.Clear();
            textBoxTown.Clear();










        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1Search_KeyPress(object sender, KeyPressEventArgs e)
        {

            sqlConnection.Close();
            string query = "SELECT * FROM StudentMaster";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView3StudentsDetails.DataSource = dt;

            sqlConnection.Open();
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("AdmNo like '%{0}%'", guna2TextBox1Search.Text);
                // dataGridView3StudentsDetails.DataSource = dv.ToTable();
            }
        }

        private void SetupParameter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStaffType_Click(object sender, EventArgs e)
        {
            // StaffType st = new StaffType();
            // st.Show();


        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
            string query = "SELECT * FROM TeachersTable";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView3StaffDetails.DataSource = dt;

            sqlConnection.Open();
        }

        private void comboBoxStaffType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSetExams_Click(object sender, EventArgs e)
        {
            SetExam sr = new SetExam();
            sr.Show();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            ExamsResults.Visible = true;
            ExamsResults.BringToFront();
            panelExamsResults.Visible = false;
        }

        private void button46_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxExamType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBoxExamCategory_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBoxExamCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            sqlConnection = new SqlConnection(connStr);
            string cmdStr = " SELECT *  FROM SetExams WHERE ExamCode  ='" + comboBoxExamCode.Text + "' ";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {

                sqlConnection.Open();

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string year = sqlDataReader["Year"].ToString();
                    string term = sqlDataReader["Term"].ToString();
                    string examtype = sqlDataReader["ExamType"].ToString();
                    string category = sqlDataReader["Category"].ToString();
                    string subject = sqlDataReader["Subject"].ToString();
                    string weight = sqlDataReader["Weight"].ToString();

                    comboBoxYear.Text = year;
                    comboBoxTerm.Text = term;
                    comboBoxExamType.Text = examtype;
                    comboBoxExamCategory.Text = category;
                    comboBoxSubjects.Text = subject;
                    txtWeight.Text = weight;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exam Not yet Set");
            }
        }

        private void btnExamsScores_Click(object sender, EventArgs e)
        {
            string qur = "INSERT INTO Exams VALUES ('" + txtAdmNo.Text + "','" + txtStudname.Text + "','" + comboBoxForm.SelectedItem + "','" + comboBoxStreams.SelectedItem + "','" + comboBoxTerm.SelectedItem + "','" + comboBoxYear.SelectedItem + "','" + comboBoxExamCode.SelectedItem + "','" + comboBoxExamType.SelectedItem + "','" + comboBoxExamCategory.SelectedItem + "','" + comboBoxSubjects.SelectedItem + "','" + txtStudentScore.Text + "','" + txtWeight.Text + "')";
            SqlCommand cmd = new SqlCommand(qur, sqlConnection);
            try
            {
                sqlConnection.Close();
                sqlConnection.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show(" Student Score Recorded successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtAdmNo_TextChanged(object sender, EventArgs e)
        {


            string qur = "SELECT *  FROM StudentMaster Where AdmNo =" + txtAdmNo.Text + " ";
            SqlCommand cmd = new SqlCommand(qur, sqlConnection);
            try
            {
                sqlConnection.Close();
                sqlConnection.Open();
                sqlDataReader = cmd.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    string Admno = sqlDataReader["AdmNo"].ToString();
                    string name = sqlDataReader["Studname"].ToString();
                    string form = sqlDataReader["Class"].ToString();
                    string strem = sqlDataReader["Stream"].ToString();

                    txtAdmNo.Text = Admno;
                    txtStudname.Text = name;
                    comboBoxForm.Text = form;
                    comboBoxStreams.Text = strem;




                    //    txtAdmNo.Text = sqlDataReader.GetValue(1).ToString();
                    // txtStudname.Text = sqlDataReader.GetValue(2).ToString();
                    // comboBoxClass.Text = sqlDataReader.GetValue(3).ToString();
                    //comboBoxStreams.Text = sqlDataReader.GetValue(4).ToString();


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                MessageBox.Show("Student does not Exist");

            }


        }

        private void btnViewRecords_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
            string query = "SELECT * FROM Exams";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1StudentsScores.DataSource = dt;

            sqlConnection.Open();
        }

        private void btnUpdateScore_Click(object sender, EventArgs e)
        {
            string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            sqlConnection = new SqlConnection(connStr);
            string qur = "UPDATE Exams SET Studname='" + txtStudname.Text + "',Class='" + comboBoxForm.SelectedItem + "',Stream='" + comboBoxStreams.SelectedItem + "',Term='" + comboBoxTerm.SelectedItem + "',Year='" + comboBoxYear.SelectedItem + "',ExamCode='" + comboBoxExamCode.SelectedItem + "',ExamType='" + comboBoxExamType.SelectedItem + "',Subject='" + comboBoxSubjects.SelectedItem + "',StudentScore='" + txtStudentScore.Text + "' WHERE AdmNo='" + txtAdmNo.Text + "' ";
            SqlDataAdapter sqlData = new SqlDataAdapter(qur, sqlConnection);

            try
            {
                sqlConnection.Close();

                sqlConnection.Open();

                sqlData.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Record Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1StudentsScores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1StudentsScores.Rows[indexRow];
            txtAdmNo.Text = row.Cells[1].Value.ToString();
            txtStudname.Text = row.Cells[2].Value.ToString();
            comboBoxForm.SelectedItem = row.Cells[3].Value.ToString();
            comboBoxStreams.SelectedItem = row.Cells[4].Value.ToString();
            comboBoxTerm.SelectedItem = row.Cells[5].Value.ToString();
            comboBoxYear.SelectedItem = row.Cells[6].Value.ToString();
            comboBoxExamCode.SelectedItem = row.Cells[7].Value.ToString();
            comboBoxExamType.SelectedItem = row.Cells[8].Value.ToString();
            comboBoxExamCategory.SelectedItem = row.Cells[9].Value.ToString();
            comboBoxSubjects.SelectedItem = row.Cells[10].Value.ToString();
            txtStudentScore.Text = row.Cells[11].Value.ToString();
            txtWeight.Text = row.Cells[12].Value.ToString();




        }

        private void RcomboBoxExamCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            sqlConnection = new SqlConnection(connStr);
            string cmdStr = " SELECT *  FROM Exams WHERE ExamCode  ='" + RcomboBoxExamCode.Text + "' ";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);

            SqlDataAdapter SDA = new SqlDataAdapter(cmdStr, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1ExamResults.DataSource = dt;

            try
            {
                sqlConnection.Close();
                sqlConnection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string year = sqlDataReader["Year"].ToString();
                    string term = sqlDataReader["Term"].ToString();
                    //string examtype = sqlDataReader["ExamType"].ToString();
                    string category = sqlDataReader["ExamCategory"].ToString();
                    string subject = sqlDataReader["Subject"].ToString();
                    // string weight = sqlDataReader["Weight"].ToString();

                    RcomboBoxYear.Text = year;
                    RcomboBoxTerm.Text = term;
                    // comboBoxExamType.Text = examtype;
                    RcomboBoxExamCategory.Text = category;
                    RcomboBoxSubject.Text = subject;
                    // txtWeight.Text = weight;





                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                MessageBox.Show("Exam Not Yet Recorded");

            }



        }

        private void comboBoxRExamCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRExamCode.SelectedItem !=null)
            {
                sqlConnection.Close();
                string query = "SELECT * FROM Exams WHERE ExamCode = '" + comboBoxRExamCode.Text + "' ";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1StudentsScores.DataSource = dt;

                sqlConnection.Open();

            }  
            else
            {
                MessageBox.Show("Subject Results Not Yet Recorded");
            }
           
        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxRForm_SelectedIndexChanged(object sender, EventArgs e)
        {
              if (comboBoxRForm.SelectedItem != null)
            {
                sqlConnection.Close();
                string query = "SELECT * FROM Exams WHERE Class = '" + comboBoxRForm.Text + "' ";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1StudentsScores.DataSource = dt;

                sqlConnection.Open();

            }
              else
            {
                MessageBox.Show("Form Results Not Yet Recorded");
            }

        }

        private void comboBoxRstream_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRstream.SelectedItem != null)
            {
                sqlConnection.Close();
                string query = "SELECT * FROM Exams WHERE Stream = '" + comboBoxRstream.Text + "' ";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1StudentsScores.DataSource = dt;

                sqlConnection.Open();

            }
            else
            {
                MessageBox.Show("Stream Results Not Yet Recorded");
            }

        }

        private void txtAllStudentMarks_TextChanged(object sender, EventArgs e)
        {
            string qur = "SELECT AdmNo,Studname,AGGREGATE_FUNCTION(Class),Stream,Term,Year,ExamCode,ExamType,ExamCategory,Subject,StudentScore  FROM Exams GROUP BY AdmNo,Studname  ";
            SqlCommand cmd = new SqlCommand(qur, sqlConnection);
            
            try
            {

                sqlConnection.Open();
                sqlConnection.Close();
                sqlDataReader = cmd.ExecuteReader();
                SqlDataAdapter SDA = new SqlDataAdapter(qur, sqlConnection);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1ExamResults.DataSource = dt;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                MessageBox.Show("Student Marks does not Exist");

            }


        }

        private void btnCats_Click(object sender, EventArgs e)
        {
            catsPanel.Visible = true;
            catsPanel.BringToFront();
            panelExamsResults.Visible = false;
        }

        private void btnExams_Click(object sender, EventArgs e)
        {
            panelExamsResults.Visible = true;
            panelExamsResults.BringToFront();
            catsPanel.Visible = false;
            ExamsResults.Visible = true;
            
        }

        private void comboExamType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelExamsResults_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGenerateScore_Click(object sender, EventArgs e)
        {


            string avg = "SELECT * FROM Exams WHERE AdmNo IN (SELECT AdmNo FROM Exams GROUP BY AdmNo HAVING COUNT (distinct ExamCategory) > 1)";
            // string exams = " SELECT AdmNo FROM  StudentMaster WHERE EXISTS (SELECT  Studname,Class,Stream,Category,Subject,StudentScore FROM Exams WHERE  ExamType='" + ExamTypecombo.SelectedItem + "'";
          //  SqlCommand exe = new SqlCommand(avg, sqlConnection);

            try
            {
                sqlConnection.Close();
                sqlConnection.Open();
               // sqlDataReader = exe.ExecuteReader();
                SqlDataAdapter SDA = new SqlDataAdapter(avg, sqlConnection);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
               GridExams.DataSource = dt;

            }

            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                MessageBox.Show("Student Marks does not Exist");



            }
           // for(int i =0;i<=20;i++)
           // {
           //     GridExams.Rows.Add("Total Score For Cats" +i.ToString),
           // }

        



        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //sqlConnection.Close();
            //
           // string avg= "SELECT AVG(StudentScore) From Exams where ExamType='CATS' AND AdmNo='"+ guna2TextBoxAdmNo.Text+ "'";
           // SqlCommand exe = new SqlCommand(avg, sqlConnection);

            //sqlDataReader = exe.ExecuteReader();
            //sqlDataReader.Read();
           // guna2TextBoxAVG.Text=

            //sqlDataReader = exe.ExecuteReader();
            //if (sqlDataReader.Read())
            //{
            //    guna2TextBoxAVG.Text = string,avg;

            //}
            //else
            //{

            //}



        }
    }
    }

    
    
    

   

    
    
    
   

