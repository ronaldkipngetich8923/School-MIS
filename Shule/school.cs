using Shule.Properties;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;




namespace Shule
{
    public partial class Home : Form
    {
       
     
        Function fn = new Function();
        String query;
        SqlConnection sqlConnection;
        SqlDataReader sqlDataReader;
        SqlDataAdapter sqlDataAdapter;
        DataSet ds;

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
            clearAl();


            // hideSubmenu();
        }
        int indexRow;

        //int Average;
        //int TotalScoreForCats;
        //int TotalScores;
        //int Grades;

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
                    guna2ComboBox5.Items.Add(sName);


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
                    comboboxFormOneResults.Items.Add(sName);
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
                    guna2ComboBox3.Items.Add(sName);


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
            FormResults.Visible = false;


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
            if (FormResults.Visible == true)
                FormResults.Visible = false;


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



            addUsers.Visible = false;
            Academic.Visible = true;
            AdmissionPanel.Visible = false;
            Finance.Visible = false;
            Library.Visible = false;
            Hostel.Visible = false;
            Transport.Visible = false;
            Dispensary.Visible = false;
            Dashboard.Visible = false;
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

            addUsers.Visible = false;
            Academic.Visible = false;
            AdmissionPanel.Visible = true;
            Finance.Visible = false;
            Dispensary.Visible = false;
            Library.Visible = false;
            Hostel.Visible = false;
            Transport.Visible = false;
            Dashboard.Visible = false;
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

            addUsers.Visible = false;
            Academic.Visible = false;
            AdmissionPanel.Visible = false;
            Finance.Visible = true;
            Library.Visible = false;
            Hostel.Visible = false;
            Dispensary.Visible = false;
            Transport.Visible = false;
            Dashboard.Visible = false;
            ExamsResults.Visible = false;
            SetupParameter.Visible = false;
            ManageStaff.Visible = false;
            Teachingstaff.Visible = false;
            subordinatestaff.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDropLibrary);


            addUsers.Visible = false;
            Academic.Visible = false;
            AdmissionPanel.Visible = false;
            Finance.Visible = false;
            Library.Visible = true;
            Hostel.Visible = false;
            Dispensary.Visible = false;
            Transport.Visible = false;
            Dashboard.Visible = false;
            ExamsResults.Visible = false;
            SetupParameter.Visible = false;
            ManageStaff.Visible = false;
            Teachingstaff.Visible = false;
            subordinatestaff.Visible = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDropHostel);

            addUsers.Visible = false;
            Academic.Visible = false;
            AdmissionPanel.Visible = false;
            Finance.Visible = false;
            Library.Visible = false;
            Hostel.Visible = true;
            Transport.Visible = false;
            Dispensary.Visible = false;
            Dashboard.Visible = false;
            ExamsResults.Visible = false;
            SetupParameter.Visible = false;
            ManageStaff.Visible = false;
            Teachingstaff.Visible = false;
            subordinatestaff.Visible = false;
            HostelOccupancy.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDropTransport);

            addUsers.Visible = false;
            Academic.Visible = false;
            AdmissionPanel.Visible = false;
            Finance.Visible = false;
            Library.Visible = false;
            Hostel.Visible = false;
            Transport.Visible = true;
            Dispensary.Visible = false;
            Dashboard.Visible = false;
            ExamsResults.Visible = false;
            SetupParameter.Visible = false;
            ManageStaff.Visible = false;
            subordinatestaff.Visible = false;
            Teachingstaff.Visible = false;

        }

        private void button9_Click(object sender, EventArgs e)
        {

            showSubMenu(panelDropDispensary);
            panelMedicines.Visible = false;
            addUsers.Visible = false;
            Academic.Visible = false;
            AdmissionPanel.Visible = false;
            Finance.Visible = false;
            Library.Visible = false;
            Hostel.Visible = false;
            Transport.Visible = false;
            Dispensary.Visible = true;
            Dashboard.Visible = false;
            ExamsResults.Visible = false;
            SetupParameter.Visible = false;
            ManageStaff.Visible = false;
            Teachingstaff.Visible = false;
            subordinatestaff.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            addUsers.Visible = false;
            Academic.Visible = false;
            AdmissionPanel.Visible = false;
            Finance.Visible = false;
            Library.Visible = false;
            Hostel.Visible = false;
            Transport.Visible = false;
            Dispensary.Visible = false;
            Dashboard.Visible = false;
            ExamsResults.Visible = false;
            SetupParameter.Visible = false;
            ManageStaff.Visible = false;
            subordinatestaff.Visible = false;
            Teachingstaff.Visible = false;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            addUsers.Visible = false;
            Academic.Visible = false;
            AdmissionPanel.Visible = false;
            Finance.Visible = false;
            Library.Visible = false;
            Hostel.Visible = false;
            Transport.Visible = false;
            Dispensary.Visible = false;
            Dashboard.Visible = false;
            ExamsResults.Visible = true;
            SetupParameter.Visible = false;
            ManageStaff.Visible = false;
            Teachingstaff.Visible = false;
            subordinatestaff.Visible = false;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            addUsers.Visible = false;
            ExamsResults.Visible = false;
            Academic.Visible = false;
            AdmissionPanel.Visible = false;
            Finance.Visible = false;
            Library.Visible = false;
            Hostel.Visible = false;
            Transport.Visible = false;
            Dispensary.Visible = false;
            Dashboard.Visible = false;
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


            addUsers.Visible = false;
            ExamsResults.Visible = false;
            Academic.Visible = false;
            AdmissionPanel.Visible = false;
            Finance.Visible = false;
            Library.Visible = false;
            Hostel.Visible = false;
            Transport.Visible = false;
            Dispensary.Visible = false;
            Dashboard.Visible = false;
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
            addUsers.Visible = false;
            ExamsResults.Visible = false;
            Academic.Visible = false;
            AdmissionPanel.Visible = false;
            Finance.Visible = false;
            Library.Visible = false;
            Hostel.Visible = false;
            Transport.Visible = false;
            Dispensary.Visible = false;
            Dashboard.Visible = false;
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
            addUsers.Visible = false;
            ExamsResults.Visible = false;
            Academic.Visible = false;
            AdmissionPanel.Visible = false;
            Finance.Visible = false;
            Library.Visible = false;
            Hostel.Visible = false;
            Transport.Visible = false;
            Dispensary.Visible = false;
            Dashboard.Visible = false;
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

            addUsers.Visible = true;
            addUsers.BringToFront();
        }

        private void panelDropFinance_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            addUsers.Visible = false;
            ExamsResults.Visible = false;
            Academic.Visible = false;
            AdmissionPanel.Visible = false;
            Finance.Visible = false;
            Library.Visible = false;
            Hostel.Visible = false;
            Transport.Visible = false;
            Dispensary.Visible = false;
            Dashboard.Visible = false;
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
            Dashboard.Visible = true;
            addUsers.Visible = false;
            string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            sqlConnection = new SqlConnection(connStr);

            //Get number Of students
            string str = "select count(AdmNo) from StudentMaster";
            SqlDataAdapter da = new SqlDataAdapter(str, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            setLabel(ds, studentsLabel);

            //GET NUMBER OF TEACHING STAFF
            String teacher = "select count(StaffType) from TeachersTable where StaffType='TEACHING STAFF'";
            sqlDataAdapter = new SqlDataAdapter(teacher, sqlConnection);
            ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            setLabel(ds, labelTeachers);

            // get number of Classes

            String classes = "select count(ClassName) from Classes";
            sqlDataAdapter = new SqlDataAdapter(classes, sqlConnection);
            ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            setLabel(ds, labelClasses);

            // get number of Hostels

            String hostels = "select count(HostelCode) from Hostels";
            sqlDataAdapter = new SqlDataAdapter(hostels, sqlConnection);
            ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            setLabel(ds, labelHostel);
            //get Hostels Occupancy
            String Hoccupied = "select count(AdmNo) from OccupiedHostel";
            sqlDataAdapter = new SqlDataAdapter(Hoccupied, sqlConnection);
            ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            setLabel(ds, OccupiedLabel);

            //get Admitted Students

            String admit = "select count(AdmNo) from Dispensary";
            sqlDataAdapter = new SqlDataAdapter(admit, sqlConnection);
            ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            setLabel(ds, labelAdmitted);

            //get Number of Suppliers
            //String Supplier = "select count(SupplierName) from Suppliers";
            //sqlDataAdapter = new SqlDataAdapter(Supplier, sqlConnection);
            //ds = new DataSet();
            //sqlDataAdapter.Fill(ds);
            //setLabel(ds, labelSuppliers);





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
        private void setLabel(DataSet ds, Label lbl)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        //private void btnView_Click(object sender, EventArgs e)
        //{
        //    sqlConnection.Close();
        //    string query = "SELECT * FROM StudentMaster";
        //    SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
        //    DataTable dt = new DataTable();
        //    SDA.Fill(dt);
        //    StudentGridView.DataSource = dt;

        //    sqlConnection.Open();


        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //StudentGridView.Rows.Add(textBoxAdmNo.Text, textBoxStudname.Text, dateTimePickerDob.Text, comboBoxGender.SelectedItem, comboBoxCounty.SelectedItem, textBoxPrimarySch.Text, textBoxKCPEMarks.Text, comboBoxDisability.SelectedItem,
            //    richTextBoxDisabilityDescription.Text, comboBoxClass.SelectedItem, comboBoxStream.SelectedItem, dateTimePicker1AdmDate.Text, textBoxPhoneNo.Text, textBoxEmail.Text, richTextBoxPostalAddress.Text, textBoxTown.Text);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            StudentsDetailsPanel.Visible = true;
            StudentsDetailsPanel.BringToFront();

            sqlConnection.Open();
            
            string query = "SELECT * FROM StudentMaster";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView3StudentsDetails.DataSource = dt;
            sqlConnection.Close();


        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            //sqlConnection = new SqlConnection(connStr);
            //string qur = "UPDATE StudentMaster SET Studname='" + textBoxStudname.Text + "',Dob='" + dateTimePickerDob.Text + "',Gender='" + comboBoxGender.SelectedItem + "',County='" + comboBoxCounty.SelectedItem + "',PrimarySch ='" + textBoxPrimarySch.Text + "',KCPEMarks='" + textBoxKCPEMarks.Text + "',Disability='" + comboBoxDisability.SelectedItem + "',DisabilityDescription='" + richTextBoxDisabilityDescription.Text + "',Class='" + comboBoxClass.SelectedItem + "',Stream='" + comboBoxStream.SelectedItem + "',AdmDate='" + dateTimePicker1AdmDate.Text + "',Parentname='" + textBoxParentname.Text + "',PhoneNo='" + textBoxPhoneNo.Text + "',Email='" + textBoxEmail.Text + "',PostalAddress='" + richTextBoxPostalAddress.Text + "',Town='" + textBoxTown.Text + "' WHERE AdmNo='" + textBoxAdmNo.Text + "' ";
            //SqlDataAdapter sqlData = new SqlDataAdapter(qur, sqlConnection);

            //try
            //{
            //    sqlConnection.Close();

            //    sqlConnection.Open();

            //    sqlData.SelectCommand.ExecuteNonQuery();
            //    MessageBox.Show("Record Updated");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void guna2Button1TeachersRecords_Click(object sender, EventArgs e)
        {
            string qur = "INSERT INTO TeachersTable VALUES ('" + txtStaffId.Text + "','" + comboBoxStaffType.SelectedItem + "','" + txtFullName.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "'," +
                "'" + guna2DateTimePicker1DateOfRecruit.Text + "','" + txtPayrollNo.Text + "','" + txtSalary.Text + "','" + comboBoxDepartmentAssigned.Text + "')";
            SqlCommand cmd = new SqlCommand(qur, sqlConnection);
            try
            {
                sqlConnection.Open();
                sqlConnection.Close();
              ;
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
                sqlConnection.Open();
                
                string query = "SELECT * FROM StudentMaster WHERE Class='FORM 1'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView3StudentsDetails.DataSource = dt;
                sqlConnection.Close();


            }
            else if (guna2ComboBox1.SelectedIndex == 1)
            {
                sqlConnection.Open();
                
                string query = "SELECT * FROM StudentMaster WHERE Class='FORM 2'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView3StudentsDetails.DataSource = dt;
                sqlConnection.Close();



            }
            else if (guna2ComboBox1.SelectedIndex == 2)
            {
                sqlConnection.Open();

                string query = "SELECT * FROM StudentMaster WHERE Class='FORM 3'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView3StudentsDetails.DataSource = dt;

                
                sqlConnection.Close();

            }
            else if (guna2ComboBox1.SelectedIndex == 3)
            {
                sqlConnection.Open();
                
                string query = "SELECT * FROM StudentMaster WHERE Class='FORM 4'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView3StudentsDetails.DataSource = dt;
                sqlConnection.Close();



            }
        }

        //private void btnSaveStudents_Click(object sender, EventArgs e)
        //{
        //    string qur = "INSERT INTO StudentMaster VALUES ('" + textBoxAdmNo.Text + "','" + textBoxStudname.Text + "','" + dateTimePickerDob.Text + "','" + comboBoxGender.SelectedItem + "','" + comboBoxCounty.SelectedItem + "'," +
        //        "'" + textBoxPrimarySch.Text + "','" + textBoxKCPEMarks.Text + "','" + comboBoxDisability.SelectedItem + "','" + richTextBoxDisabilityDescription.Text + "'," +
        //        "'" + comboBoxClass.SelectedItem + "','" + comboBoxStream.SelectedItem + "','" + dateTimePicker1AdmDate.Text + "','" + textBoxParentname.Text + "'," +
        //        "'" + textBoxPhoneNo.Text + "','" + textBoxEmail.Text + "','" + richTextBoxPostalAddress.Text + "','" + textBoxTown.Text + "')";
        //    SqlCommand cmd = new SqlCommand(qur, sqlConnection);
        //    try
        //    {
        //        sqlConnection.Close();
        //        sqlConnection.Open();
        //        int rows = cmd.ExecuteNonQuery();

        //        MessageBox.Show(rows + "  row inserted successfully.");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

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
            guna2TextBox3.Clear();










        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            sqlConnection.Open();
            
            string query = "SELECT * FROM StudentMaster";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView3StudentsDetails.DataSource = dt;

            
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("AdmNo like '%{0}%'", guna2TextBox1Search.Text);
                // dataGridView3StudentsDetails.DataSource = dv.ToTable();
            }
            sqlConnection.Close();
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
            sqlConnection.Close();
        }

        private void btnExamsScores_Click(object sender, EventArgs e)
        {
            string qur = "INSERT INTO Exams VALUES ('" + txtAdmNo.Text + "','" + txtStudname.Text + "','" + comboBoxForm.SelectedItem + "','" + comboBoxStreams.SelectedItem + "','" + comboBoxTerm.SelectedItem + "','" + comboBoxYear.SelectedItem + "','" + comboBoxExamCode.SelectedItem + "','" + comboBoxExamType.SelectedItem + "','" + comboBoxExamCategory.SelectedItem + "','" + comboBoxSubjects.SelectedItem + "','" + txtStudentScore.Text + "','" + txtWeight.Text + "')";
            SqlCommand cmd = new SqlCommand(qur, sqlConnection);
            try
            {
                
                sqlConnection.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show(" Student Score Recorded successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }

        private void txtAdmNo_TextChanged(object sender, EventArgs e)
        {


            string qur = "SELECT *  FROM StudentMaster Where AdmNo =" + txtAdmNo.Text + " ";
            SqlCommand cmd = new SqlCommand(qur, sqlConnection);
            try
            {
              
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
            sqlConnection.Close();


        }

        private void btnViewRecords_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            
            string query = "SELECT * FROM Exams";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1StudentsScores.DataSource = dt;
            sqlConnection.Close();


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
            sqlConnection.Close();



        }

        private void comboBoxRExamCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRExamCode.SelectedItem != null)
            {
                sqlConnection.Open();
              
                string query = "SELECT * FROM Exams WHERE ExamCode = '" + comboBoxRExamCode.Text + "' ";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1StudentsScores.DataSource = dt;

                

            }
            else
            {
                MessageBox.Show("Subject Results Not Yet Recorded");
            }
            sqlConnection.Open();

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxRForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRForm.SelectedItem != null)
            {
                sqlConnection.Open();
               
                string query = "SELECT * FROM Exams WHERE Class = '" + comboBoxRForm.Text + "' ";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1StudentsScores.DataSource = dt;
               

                

            }
            else
            {
                MessageBox.Show("Form Results Not Yet Recorded");
            }
            sqlConnection.Close();

        }

        private void comboBoxRstream_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRstream.SelectedItem != null)
            {
               
                sqlConnection.Open();
                string query = "SELECT * FROM Exams WHERE Stream = '" + comboBoxRstream.Text + "' ";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1StudentsScores.DataSource = dt;



            }
            else
            {
                MessageBox.Show("Stream Results Not Yet Recorded");
            }
            sqlConnection.Close();
        }

        private void txtAllStudentMarks_TextChanged(object sender, EventArgs e)
        {
            string qur = "SELECT AdmNo,Studname,AGGREGATE_FUNCTION(Class),Stream,Term,Year,ExamCode,ExamType,ExamCategory,Subject,StudentScore  FROM Exams GROUP BY AdmNo,Studname  ";
            SqlCommand cmd = new SqlCommand(qur, sqlConnection);

            try
            {

                sqlConnection.Open();

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

            sqlConnection.Close();

        }

        private void btnCats_Click(object sender, EventArgs e)
        {
            catsPanel.Visible = true;
            catsPanel.BringToFront();
            panelExamsResults.Visible = false;
        }

        private void btnExams_Click(object sender, EventArgs e)
        {
            showSubMenu(FormResults);


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


        //string query = "SELECT ISNULL(StudentScore, 0 ) from Exams";
        //sqlConnection.Close();
        //sqlConnection.Open();

        //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
        //DataTable de = new DataTable();
        //sqlDataAdapter.Fill(de);
        //GridExams.DataSource = de;
        //string avg = "SELECT * FROM Exams  WHERE AdmNo  IN (SELECT  AdmNo FROM  Exams GROUP BY AdmNo  HAVING COUNT (distinct ExamCategory ) > 1";

        // string conn = "SELECT * FROM Exams WHERE AdmNo IN (SELECT AdmNo FROM Exams GROUP BY AdmNo SUM(StudentScore)";

        //string avg = "SELECT * FROM Exams WHERE AdmNo IN (SELECT AdmNo FROM Exams GROUP BY AdmNo HAVING COUNT (distinct ExamCategory) > 1)";
        // string exams = " SELECT AdmNo FROM  StudentMaster WHERE EXISTS (SELECT  Studname,Class,Stream,Category,Subject,StudentScore FROM Exams WHERE  ExamType='" + ExamTypecombo.SelectedItem + "'";
        //  SqlCommand exe = new SqlCommand(avg, sqlConnection);



        //dt.Columns.Add(new DataColumn("Total Cats Score", typeof(int)));
        //  Decimal TotalScore = Convert.ToDecimal(dt.Compute("SUM(StudentScore)", "StudentScore > 3"));
        // dt.Columns.Add(new DataColumn("Cat Average Score", typeof(int)));
        // dt.Columns.Add(new DataColumn("Total Score", typeof(int)));
        // GridExams.DataSource = dv;
        // DataTable dv = new DataTable();
        // sdc.Fill(dv);
        private void btnGenerateScore_Click(object sender, EventArgs e)
        {
            string avg = " select * from(select  AdmNo, Studname,Class,Stream,Subject,  TOTAL_SCORE  From  Results ) As P Pivot    (max([TOTAL_SCORE]) For Subject In([ENGLISH],[KISWAHILI],[MATHEMATICS],[GEOGRAPHY],[HISTORY],[BUSINESS],[BIOLOGY],[PHYSICS],[CHEMISTRY],[COMPUTER_STUDIES],[DRAWING_AND_DESIGN],[TOTAL_MARKS],[POINTS],[GRADE])  )As p order by AdmNo ";
            //string avg = " select * from(select  AdmNo, Studname,Class,Stream,Subject,ExamCategory, StudentScore  From  Exams ) As P  Pivot    (max([StudentScore]) For Subject In([ENGLISH],[KISWAHILI],[MATHEMATICS],[GEOGRAPHY],[HISTORY],[BUSINESS],[BIOLOGY],[PHYSICS],[CHEMISTRY],[COMPUTER_STUDIES],[DRAWING_AND_DESIGN],[TOTAL_MARKS],[POINTS],[GRADE])  )As p order by AdmNo ";

            try
            {
               
                sqlConnection.Open();

                SqlDataAdapter SDA = new SqlDataAdapter(avg, sqlConnection);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                GridExams.DataSource = dt;

                foreach (DataGridViewRow item in GridExams.Rows)
                {
                    int n = item.Index;

                    for (n = 0; n < GridExams.Rows.Count; n++)
                    {

                        if (GridExams.Rows[n].Cells[4].Value == DBNull.Value)
                        {
                            GridExams.Rows[n].Cells[4].Value = 0;
                        }


                        if (GridExams.Rows[n].Cells[5].Value == DBNull.Value)
                        {
                            GridExams.Rows[n].Cells[5].Value = 0;
                        }
                        if (GridExams.Rows[n].Cells[6].Value == DBNull.Value)
                        {
                            GridExams.Rows[n].Cells[6].Value = 0;
                        }

                        if (GridExams.Rows[n].Cells[7].Value == DBNull.Value)
                        {
                            GridExams.Rows[n].Cells[7].Value = 0;
                        }
                        if (GridExams.Rows[n].Cells[8].Value == DBNull.Value)
                        {
                            GridExams.Rows[n].Cells[8].Value = 0;
                        }

                        if (GridExams.Rows[n].Cells[9].Value == DBNull.Value)
                        {
                            GridExams.Rows[n].Cells[9].Value = 0;
                        }
                        if (GridExams.Rows[n].Cells[10].Value == DBNull.Value)
                        {
                            GridExams.Rows[n].Cells[9].Value = 0;
                        }
                        if (GridExams.Rows[n].Cells[10].Value == DBNull.Value)
                        {
                            GridExams.Rows[n].Cells[10].Value = 0;
                        }
                        if (GridExams.Rows[n].Cells[11].Value == DBNull.Value)
                        {
                            GridExams.Rows[n].Cells[11].Value = 0;
                        }
                        if (GridExams.Rows[n].Cells[12].Value == DBNull.Value)
                        {
                            GridExams.Rows[n].Cells[12].Value = 0;
                        }
                        if (GridExams.Rows[n].Cells[13].Value == DBNull.Value)
                        {
                            GridExams.Rows[n].Cells[13].Value = 0;
                        }

                        if (GridExams.Rows[n].Cells[14].Value == DBNull.Value)
                        {
                            GridExams.Rows[n].Cells[14].Value = 0;
                        }



                        Convert.ToDecimal(GridExams.Rows[n].Cells[15].Value = Convert.ToDecimal
                            (decimal.Parse(GridExams.Rows[n].Cells[4].Value.ToString()) +
                            decimal.Parse(GridExams.Rows[n].Cells[5].Value.ToString()) +
                            decimal.Parse(GridExams.Rows[n].Cells[6].Value.ToString()) +
                            decimal.Parse(GridExams.Rows[n].Cells[7].Value.ToString()) +
                            decimal.Parse(GridExams.Rows[n].Cells[8].Value.ToString()) +
                            decimal.Parse(GridExams.Rows[n].Cells[9].Value.ToString()) +
                            decimal.Parse(GridExams.Rows[n].Cells[10].Value.ToString()) +
                            decimal.Parse(GridExams.Rows[n].Cells[11].Value.ToString()) +
                            decimal.Parse(GridExams.Rows[n].Cells[12].Value.ToString()) +
                            decimal.Parse(GridExams.Rows[n].Cells[13].Value.ToString()) +
                            decimal.Parse(GridExams.Rows[n].Cells[14].Value.ToString())).ToString());

                        //column for total points

                        Convert.ToDecimal(GridExams.Rows[n].Cells[16].Value = (decimal.Parse(GridExams.Rows[n].Cells[15].Value.ToString())/700));

                        // dt.Columns.Add(new DataColumn("Points", typeof(int)));
                        // GridExams.Columns.Add(Points);
                        //int sp;
                        //string str = GridExams.Rows[n].Cells[16].Value.ToString();
                        //if (int.TryParse(str, out sp))
                      decimal sp = decimal.Parse(GridExams.Rows[n].Cells[16].Value.ToString());
                       //GridExams.Rows[n].Cells[17].ValueType = typeof(Char);
                        // string G = GridExams.Rows[n].Cells[17].Value;

                        if (sp >= 12 && sp >= 8)
                            {
                            GridExams.Rows[n].Cells[17].Value.ToString();
                             GridExams.Rows[n].Cells[17].Value= "A";
                            }
                            else if (sp < 8 && sp >= 6)
                            {
                            GridExams.Rows[n].Cells[17].Value.ToString();
                            GridExams.Rows[n].Cells[17].Value = "B";
                            }
                            else if (sp < 6 && sp >= 4)
                            {
                            GridExams.Rows[n].Cells[17].Value.ToString();
                            GridExams.Rows[n].Cells[17].Value = "C";
                            }
                            else if (sp < 4 && sp >= 2)
                            {
                            GridExams.Rows[n].Cells[17].Value.ToString();
                            GridExams.Rows[n].Cells[17].Value = "D";
                            }
                            else if (sp < 2 && sp >= 1)
                            {
                            GridExams.Rows[n].Cells[17].Value.ToString();
                            GridExams.Rows[n].Cells[17].Value = "E";
                            }
                        else if (sp < 1 && sp >= 0)
                        {
                            GridExams.Rows[n].Cells[17].Value.ToString();
                            GridExams.Rows[n].Cells[17].Value = "Y";
                        }
                        else
                            {
                            GridExams.Rows[n].Cells[17].Value.ToString();
                            GridExams.Rows[n].Cells[17].Value = "X";
                        }

                        

                        
                        //else
                        //{
                        //    GridExams.Rows[n].Cells[17].Value = "Y";
                        //}

                    }
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                // MessageBox.Show("Student Marks does not Exist");



            }


            sqlConnection.Close();



        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {


        }

        private void CATS_EXAMS_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox3.Text != "")
            {
               
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("Select CAT_1, CAT_2, FINALEXAM FROM examtest where AdmNo='" + guna2TextBoxAdmNoExam.Text + "' AND SUBJECTS='" + guna2ComboBox5.Text + "'", sqlConnection);



                sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    guna2TextBoxCAT1.Text = sqlDataReader["CAT_1"].ToString();
                    guna2TextBoxCat_2.Text = sqlDataReader["CAT_2"].ToString();
                    guna2TextBoxfinal.Text = sqlDataReader["FINALEXAM"].ToString();


                    if (guna2TextBoxCAT1.Text.Length > 0 && guna2TextBoxCat_2.Text.Length > 0)
                    {
                        guna2TextBoxavg.Text = Convert.ToString((Convert.ToDecimal(guna2TextBoxCAT1.Text) + Convert.ToDecimal(guna2TextBoxCat_2.Text)) / 2);

                    }
                    if (guna2TextBoxfinal.Text.Length > 0 && guna2TextBoxavg.Text.Length > 0)
                    {
                        guna2TextBoxresults.Text = Convert.ToString(Convert.ToDecimal(guna2TextBoxfinal.Text) + Convert.ToDecimal(guna2TextBoxavg.Text));
                        //txtt4.Text = Convert.ToString(Convert.ToInt32(txtt1.Text) * Convert.ToInt32(txtt2.Text));
                    }

                    decimal results = Convert.ToDecimal(guna2TextBoxresults.Text);

                    if (results >= 90 && results <= 100)
                    {
                        guna2TextBoxgrade.Text = "A";
                    }

                    else if (results >= 80)
                    {
                        guna2TextBoxgrade.Text = "A";
                    }

                    else if (results >= 70)
                    {
                        guna2TextBoxgrade.Text = "B";
                    }

                    else if (results >= 60)
                    {
                        guna2TextBoxgrade.Text = "C";
                    }

                    else if (results >= 50)
                    {
                        guna2TextBoxgrade.Text = "D";
                    }

                    else if (results >= 40)
                    {
                        guna2TextBoxgrade.Text = "E";

                    }

                    else
                    {
                        guna2TextBoxgrade.Text = "F";

                    }


                }
                else
                {
                    MessageBox.Show("Results Does Not Exist!");
                }



            }
            else
            {
                MessageBox.Show("Select Class !");
            }

            sqlDataReader.Close();
            sqlConnection.Close();
        }

        private void guna2TextBoxAdmNoExam_TextChanged(object sender, EventArgs e)
        {
            //sqlConnection.Open();
            //SqlCommand cmd = new SqlCommand("Select Studname,Stream FROM StudentMaster where AdmNo='" + guna2TextBoxAdmNoExam.Text + "'", sqlConnection);



            //sqlDataReader = cmd.ExecuteReader();
            //sqlDataReader.Read();
            //guna2TextBox1.Text = sqlDataReader["Studname"].ToString();
            //guna2ComboBox6.Text = sqlDataReader["Stream"].ToString();

            //sqlConnection.Close();


        }

        private void label68_Click(object sender, EventArgs e)
        {

        }

        private void label61_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("Select Studname, Stream FROM StudentMaster where AdmNo='" + guna2TextBoxAdmNoExam.Text + "' AND Class='" + guna2ComboBox3.SelectedItem + "'", sqlConnection);
            
            sqlConnection.Open();
            sqlDataReader = cmd1.ExecuteReader();
            if (sqlDataReader.Read())
            {
                guna2TextBox1.Text = sqlDataReader["Studname"].ToString();
                guna2TextBox2.Text = sqlDataReader["Stream"].ToString();



            }
            else
            {
                MessageBox.Show("Student Does Not exist in this Class !!");
            }

            sqlDataReader.Close();
            sqlConnection.Close();

        }

        private void label66_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveRecords_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("INSERT INTO Results VALUES ('" + guna2TextBoxAdmNoExam.Text + "','" + guna2TextBox1.Text + "', '" + guna2ComboBox3.SelectedItem + "', '" + guna2TextBox2.Text + "','" + guna2ComboBox5.SelectedItem + "','" + guna2TextBoxCAT1.Text + "','" + guna2TextBoxCat_2.Text + "'," +
                "'" + guna2TextBoxavg.Text + "','" + guna2TextBoxfinal.Text + "','" + guna2TextBoxresults.Text + "', '" + guna2TextBoxgrade.Text + "') ", sqlConnection);

            
            sqlConnection.Open();

            try
            {


                cmd2.ExecuteNonQuery();

                MessageBox.Show(" Student Results inserted successfully.");

                sqlConnection.Close();

                guna2TextBoxAdmNoExam.Text = "";
                guna2TextBox1.Text = "";
                // guna2ComboBox3.SelectedItem = null;
                guna2TextBox2.Text = "";
                // guna2ComboBox5.SelectedIndex = -1;
                guna2TextBoxCAT1.Text = "";
                guna2TextBoxCat_2.Text = "";
                guna2TextBoxavg.Text = "";
                guna2TextBoxfinal.Text = "";
                guna2TextBoxresults.Text = "";
                guna2TextBoxgrade.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            sqlConnection.Close();


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Results", sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "Results");
            dataGridView1.DataSource = ds.Tables["Results"].DefaultView;
            sqlConnection.Close();

        }

        private void labelHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard.Visible = true;
            Dashboard.BringToFront();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            String role = comboBoxUserRole.Text;
            String name = txtFullName.Text;
            String dob = guna2DateTimePicker1.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String email = txtEmailUser.Text;
            String username = txtUser.Text;
            String pass = txtPass.Text;


            try
            {
                

                query = "insert into users (UserRole,Fname,Dob,MobileNo,emailAddress,Uname,Pass) values ('" + role + "','" + name + "','" + dob + "','" + mobile + "','" + email + "','" + username + "','" + pass + "')";
                fn.setData(query, "SignUp Successful");

            }
            catch (Exception)
            {

            MessageBox.Show("Username Already Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }



        }

        private void btnSignUpReset_Click(object sender, EventArgs e)
        {
            clearAl();



        }
        public void clearAl()
        {
            txtFullName.Clear();
            guna2DateTimePicker1.ResetText();
            txtMobile.Clear();
            txtEmailUser.Clear();
            txtPass.Clear();
            comboBoxUserRole.SelectedIndex = -1;


        }
        //private void GridExams_CellFormating(object sender,DataGridViewCellFormattingEventArgs e)
        //{
        //    String Value = e.Value as String;
        //    if((Value != null)&& Value.Equals(e.CellStyle.DataSourceNullValue))
        //    {
        //        e.Value = e.CellStyle.NullValue;
        //        e.FormattingApplied = true;
        //    }
        //}

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
          
            foreach (DataGridViewRow g1 in GridExams.Rows)
            {

                if (g1.Cells[4].Value == DBNull.Value)
                {
                    g1.Cells[4].Value = 0;
                }


                if (g1.Cells[5].Value == DBNull.Value)
                {
                    g1.Cells[5].Value = 0;
                }
                if (g1.Cells[6].Value == DBNull.Value)
                {
                    g1.Cells[6].Value = 0;
                }

                if (g1.Cells[7].Value == DBNull.Value)
                {
                    g1.Cells[7].Value = 0;
                }
                if (g1.Cells[8].Value == DBNull.Value)
                {
                    g1.Cells[8].Value = 0;
                }

                if (g1.Cells[9].Value == DBNull.Value)
                {
                    g1.Cells[9].Value = 0;
                }
                if (g1.Cells[10].Value == DBNull.Value)
                {
                    g1.Cells[9].Value = 0;
                }
                if (g1.Cells[10].Value == DBNull.Value)
                {
                    g1.Cells[10].Value = 0;
                }
                if (g1.Cells[11].Value == DBNull.Value)
                {
                    g1.Cells[11].Value = 0;
                }
                if (g1.Cells[12].Value == DBNull.Value)
                {
                    g1.Cells[12].Value = 0;
                }
                if (g1.Cells[13].Value == DBNull.Value)
                {
                    g1.Cells[13].Value = 0;
                }

                if (g1.Cells[14].Value == DBNull.Value)
                {
                    g1.Cells[14].Value = 0;
                }

              
            }
            for (int i = 0; i < GridExams.RowCount; i++)
            {
                string Admno = GridExams.Rows[i].Cells["AdmNo"].Value?.ToString();
                string Eng = GridExams.Rows[i].Cells["ENGLISH"].Value?.ToString();
                string kisw = GridExams.Rows[i].Cells["KISWAHILI"].Value?.ToString();
                string MTH = GridExams.Rows[i].Cells["MATHEMATICS"].Value?.ToString();
                string geo = GridExams.Rows[i].Cells["GEOGRAPHY"].Value?.ToString();
                string hist = GridExams.Rows[i].Cells["HISTORY"].Value?.ToString();
                string Buss = GridExams.Rows[i].Cells["BUSINESS"].Value?.ToString();
                string Bio = GridExams.Rows[i].Cells["BIOLOGY"].Value?.ToString();
                string PHY = GridExams.Rows[i].Cells["PHYSICS"].Value?.ToString();
                string chem = GridExams.Rows[i].Cells["CHEMISTRY"].Value?.ToString();
                string comp = GridExams.Rows[i].Cells["COMPUTER_STUDIES"].Value?.ToString();
                string draw = GridExams.Rows[i].Cells["DRAWING_AND_DESIGN"].Value?.ToString();
                string total = GridExams.Rows[i].Cells["TOTAL_MARKS"].Value?.ToString();
                string points = GridExams.Rows[i].Cells["POINTS"].Value?.ToString();

                String connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
                sqlConnection = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("insert into processedResults(AdmNo,ENGLISH,KISWAHILI,MATHEMATICS,GEOGRAPHY,HISTORY,BUSINESS,BIOLOGY,PHYSICS,CHEMISTRY,COMPUTER_STUDIES,DRAWING_AND_DESIGN,TOTAL_MARKS,POINTS) values ('" + Admno + "','" + Eng + "','" + kisw + "','" + MTH + "','" + geo + "','" + hist + "','" + Buss + "','" + Bio + "','" + PHY + "','" + chem + "','" + comp + "','" + draw + "','" + total + "','" + points + "')", sqlConnection);
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            MessageBox.Show("Records Saved Successfully");
        }

        private void btnViewForm1Results_Click(object sender, EventArgs e)
        {
            

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM processedResults", sqlConnection);
            DataSet ds = new DataSet();         
            da.Fill(ds, "processedResults");
            GridProcessedResults.DataSource = ds.Tables["processedResults"].DefaultView;
        
        }

        private void btnRank_Click(object sender, EventArgs e)
        {



            try
            {
                SqlDataAdapter s = new SqlDataAdapter("SELECT I.AdmNo,T.Studname,T.Class,T.Stream,ENGLISH,KISWAHILI,MATHEMATICS,GEOGRAPHY,HISTORY,BUSINESS,BIOLOGY,PHYSICS,CHEMISTRY,COMPUTER_STUDIES,DRAWING_AND_DESIGN " +
                    ", ROW_NUMBER() OVER(ORDER BY Total_Marks) AS 'Row_Number' , RANK() OVER(ORDER BY Total_Marks desc) AS 'Rank' " +
                    ", DENSE_RANK() OVER(ORDER BY Total_Marks Desc) AS 'Dense_Rank'   , NTILE(4) OVER(ORDER BY Total_Marks desc) AS Quartile " +
                    "   , TOTAL_MARKS,POINTS FROM processedResults as I   JOIN StudentMaster as T    ON I.AdmNo = T.AdmNo  ", sqlConnection);
                DataSet ds = new DataSet();
                s.Fill(ds, "processedResults");
                GridProcessedResults.DataSource = ds.Tables["processedResults"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void comboboxFormOneResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                if (comboboxFormOneResults.Text != "")
                {
                   
                    sqlConnection.Open();                   
                    SqlDataAdapter frm1 = new SqlDataAdapter("Select * FROM processedResults as I   JOIN StudentMaster as T    ON I.AdmNo = T.AdmNo where T.Stream='" + comboboxFormOneResults.SelectedItem + "' ", sqlConnection);
                    DataSet ds = new DataSet();
                    frm1.Fill(ds, "processedResults");
                    GridProcessedResults.DataSource = ds.Tables["processedResults"].DefaultView;

            }
                else
            {
                MessageBox.Show("Stream Results Not Yet Available");
            }
            sqlConnection.Close();

        }

        private void BTNFORM1RESULTS_Click(object sender, EventArgs e)
        {
            ViewProcessedResults.Visible = true;
            ViewProcessedResults.BringToFront();
            ViewProcessedResultsForm2.Visible = false;
            ViewProcessedResultsForm3.Visible = false;
            ViewProcessedResultsForm4.Visible = false;
            CATS_EXAMS.Visible = false;
            catsPanel.Visible = false;
            panelExamsResults.Visible = false;

        }

        private void btnform2Results_Click(object sender, EventArgs e)
        {
            ViewProcessedResults.Visible = false;
            ViewProcessedResultsForm2.BringToFront();
            ViewProcessedResultsForm2.Visible = true;
            ViewProcessedResultsForm3.Visible = false;
            ViewProcessedResultsForm4.Visible = false;
            CATS_EXAMS.Visible = false;
            catsPanel.Visible = false;
            panelExamsResults.Visible = false;

        }

        private void btnForm3Results_Click(object sender, EventArgs e)
        {
            ViewProcessedResults.Visible = false;
            ViewProcessedResultsForm3.BringToFront();
            ViewProcessedResultsForm2.Visible = false;
            ViewProcessedResultsForm3.Visible = true;
            ViewProcessedResultsForm4.Visible = false;
            CATS_EXAMS.Visible = false;
            catsPanel.Visible = false;
            panelExamsResults.Visible = false;

        }

        private void btnForm4Results_Click(object sender, EventArgs e)
        {
            ViewProcessedResults.Visible = false;
            ViewProcessedResultsForm4.BringToFront();
            ViewProcessedResultsForm2.Visible = false;
            ViewProcessedResultsForm3.Visible = false;
            ViewProcessedResultsForm4.Visible = true;
            CATS_EXAMS.Visible = false;
            catsPanel.Visible = false;
            panelExamsResults.Visible = false;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            sqlConnection = new SqlConnection(connStr);
            string qur = "UPDATE Exams SET Studname='" + txtStudname.Text + "',Class='" + comboBoxForm.SelectedItem + "',Stream='" + comboBoxStreams.SelectedItem + "',Term='" + comboBoxTerm.SelectedItem + "',Year='" + comboBoxYear.SelectedItem + "',ExamCode='" + comboBoxExamCode.SelectedItem + "',ExamType='" + comboBoxExamType.SelectedItem + "',Subject='" + comboBoxSubjects.SelectedItem + "',StudentScore='" + txtStudentScore.Text + "' WHERE AdmNo='" + txtAdmNo.Text + "' ";
            SqlDataAdapter sqlData = new SqlDataAdapter(qur, sqlConnection);

            try
            {
                

                sqlConnection.Open();

                sqlData.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Record Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }

        private void btnSaveStudents_Click_1(object sender, EventArgs e)
        {
            if (textBoxAdmNo.Text == "")
            {
                string myStringVariable1 = string.Empty;
                MessageBox.Show("AdmNo Field is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxStudname.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Student Name Field is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateTimePickerDob.Text == "")
            {
                string myStringVariable3 = string.Empty;
                MessageBox.Show("DateOfBirth Field is Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxGender.Text == "--Choose--")
            {
                string myStringVariable4 = string.Empty;
                MessageBox.Show("Select Gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxCounty.Text == "--Choose--")
            {
                string myStringVariable5 = string.Empty;
                MessageBox.Show("Select County.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxCounty.Text == "--Choose--")
            {
                string myStringVariable6 = string.Empty;
                MessageBox.Show("Select County.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxPrimarySch.Text == " ")
            {
                string myStringVariable7 = string.Empty;
                MessageBox.Show("Primary School Field is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxKCPEMarks.Text == " ")
            {
                string myStringVariable8 = string.Empty;
                MessageBox.Show("Primary School Field is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                int temp;
                if (int.TryParse(textBoxKCPEMarks.Text, out temp))
                {
                    if (temp >= 0 && temp <= 500)
                    {
                        //valid number (int)
                    }
                    else
                    {
                        MessageBox.Show("Marks Should either be 0 OR Less Than 500", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Entered Value is not a Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxDisability.Text == "--Choose--")
            {
                string myStringVariable9 = string.Empty;
                MessageBox.Show("Disability Status Field is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (comboBoxDisability.SelectedIndex == 1)
                {
                    richTextBoxDisabilityDescription.Text = "NO COMPLICATIONS";

                }
            }
            else if (richTextBoxDisabilityDescription.Text == "")
            {
                string myStringVariable10 = string.Empty;
                MessageBox.Show("Disability Description Field is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxClass.Text == "--Choose--")
            {
                string myStringVariable11 = string.Empty;
                MessageBox.Show("Class Field is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxStream.Text == "--Choose--")
            {
                string myStringVariable12 = string.Empty;
                MessageBox.Show("Stream Field is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxStream.Text == "--Choose--")
            {
                string myStringVariable13 = string.Empty;
                MessageBox.Show("Stream Field is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateTimePicker1AdmDate.Text == "--Choose--")
            {
                string myStringVariable14 = string.Empty;
                MessageBox.Show("Admissin Date Field is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxParentname.Text == "")
            {
                string myStringVariable15 = string.Empty;
                MessageBox.Show("Parent Name Field is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxPhoneNo.Text == "")
            {
                string myStringVariable16 = string.Empty;
                MessageBox.Show("Phone No Field is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxParentname.Text == "")
            {
                string myStringVariable17 = string.Empty;
                MessageBox.Show("Parent Name Field is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxEmail.Text == "")
            {
                string myStringVariable18 = string.Empty;
                MessageBox.Show("Email Address  Field is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                try
                {
                    // Normalize the domain
                    textBoxEmail.Text = Regex.Replace(textBoxEmail.Text, @"(@)(.+)$", DomainMapper,
                                          RegexOptions.None, TimeSpan.FromMilliseconds(200));

                    // Examines the domain part of the email and normalizes it.
                    string DomainMapper(Match match)
                    {
                        // Use IdnMapping class to convert Unicode domain names.
                        var idn = new IdnMapping();

                        // Pull out and process domain name (throws ArgumentException on invalid)
                        string domainName = idn.GetAscii(match.Groups[2].Value);

                        return match.Groups[1].Value + domainName;
                    }
                }
                catch (RegexMatchTimeoutException)

                {

                    //return false;
                }
                catch (ArgumentException)
                {
                    //MessageBox.Show(ex.Message);
                    //return false;
                }

                try
                {
                    ////return Regex.IsMatch(textBoxEmail.Text,
                    ////    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    ////    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
                }
                catch (RegexMatchTimeoutException)
                {
                    //return false;
                }
            }
            else if (richTextBoxPostalAddress.Text == "")
            {
                string myStringVariable19 = string.Empty;
                MessageBox.Show("Postal Address  Field is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (guna2TextBox3.Text == "")
            {
                string myStringVariable20 = string.Empty;
                MessageBox.Show("Town Name  Field is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }










            else
            {
                string qur = "INSERT INTO StudentMaster VALUES ('" + textBoxAdmNo.Text + "','" + textBoxStudname.Text + "','" + dateTimePickerDob.Text + "','" + comboBoxGender.SelectedItem + "','" + comboBoxCounty.SelectedItem + "'," +
              "'" + textBoxPrimarySch.Text + "','" + textBoxKCPEMarks.Text + "','" + comboBoxDisability.SelectedItem + "','" + richTextBoxDisabilityDescription.Text + "'," +
              "'" + comboBoxClass.SelectedItem + "','" + comboBoxStream.SelectedItem + "','" + dateTimePicker1AdmDate.Text + "','" + textBoxParentname.Text + "'," +
              "'" + textBoxPhoneNo.Text + "','" + textBoxEmail.Text + "','" + richTextBoxPostalAddress.Text + "','" + guna2TextBox3.Text + "')";
                SqlCommand cmd = new SqlCommand(qur, sqlConnection);
                try
                {
                    
                    sqlConnection.Open();
                    int rows = cmd.ExecuteNonQuery();

                    MessageBox.Show(rows + "  Student Saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                sqlConnection.Close();
            }








           
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            string qur = "UPDATE StudentMaster SET Studname='" + textBoxStudname.Text + "',Dob='" + dateTimePickerDob.Text + "',Gender='" + comboBoxGender.SelectedItem + "',County='" + comboBoxCounty.SelectedItem + "',PrimarySch=" +
               "'" + textBoxPrimarySch.Text + "',KCPEMarks='" + textBoxKCPEMarks.Text + "',Disability='" + comboBoxDisability.SelectedItem + "',DisabilityDescription='" + richTextBoxDisabilityDescription.Text + "',Class=" +
               "'" + comboBoxClass.SelectedItem + "',Stream='" + comboBoxStream.SelectedItem + "',AdmDate='" + dateTimePicker1AdmDate.Text + "',Parentname='" + textBoxParentname.Text + "',PhoneNo=" +
               "'" + textBoxPhoneNo.Text + "',Email='" + textBoxEmail.Text + "',PostalAddress='" + richTextBoxPostalAddress.Text + "',Town='" + guna2TextBox3.Text + "'   WHERE AdmNo='" + textBoxAdmNo.Text + "'";
            SqlCommand cmd = new SqlCommand(qur, sqlConnection);
            try
            {
               
                sqlConnection.Open();
                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show("Student Record Updated Successfully.", "Update Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }

        private void StudentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = StudentGridView.Rows[indexRow];
            textBoxAdmNo.Text = row.Cells[0].Value.ToString();
            textBoxStudname.Text = row.Cells[1].Value.ToString();
            dateTimePickerDob.Text = row.Cells[2].Value.ToString();
            comboBoxGender.SelectedItem = row.Cells[3].Value.ToString();
            comboBoxCounty.SelectedItem = row.Cells[4].Value.ToString();
            textBoxPrimarySch.Text = row.Cells[5].Value.ToString();
            textBoxKCPEMarks.Text = row.Cells[6].Value.ToString();
            comboBoxDisability.SelectedItem = row.Cells[7].Value.ToString();
            richTextBoxDisabilityDescription.Text = row.Cells[8].Value.ToString();
            comboBoxClass.SelectedItem = row.Cells[9].Value.ToString();
            comboBoxStream.SelectedItem = row.Cells[10].Value.ToString();
            dateTimePicker1AdmDate.Text = row.Cells[11].Value.ToString();
            textBoxParentname.Text = row.Cells[12].Value.ToString();
            textBoxPhoneNo.Text = row.Cells[13].Value.ToString();
            textBoxEmail.Text = row.Cells[14].Value.ToString();
            richTextBoxPostalAddress.Text = row.Cells[15].Value.ToString();
            guna2TextBox3.Text = row.Cells[16].Value.ToString();
        }

        private void btnView_Click_1(object sender, EventArgs e)
        {
            sqlConnection.Open();
           
            string query = "SELECT * FROM StudentMaster";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            StudentGridView.DataSource = dt;

            
            sqlConnection.Close();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button51_Click(object sender, EventArgs e)
        {
            AddHostel host = new AddHostel();
            host.Show();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            HostelClearance hr = new HostelClearance();
            hr.Show();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            tab hos = new tab();
            hos.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HostelOccupancy.Visible = true;
            HostelOccupancy.BringToFront();

            string query = "SELECT Hostels.HostelCode,Hostels.HostelName,Hostels.Capacity,OccupiedHostel.AdmNo,OccupiedHostel.Studname,StudentMaster.AdmDate,StudentMaster.Class,StudentMaster.Stream,OccupiedHostel.DateAssigned FROM Hostels " +
                "INNER JOIN OccupiedHostel ON Hostels.HostelCode = OccupiedHostel.HostelCode " +
                "INNER JOIN StudentMaster ON OccupiedHostel.AdmNo =StudentMaster.AdmNo";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            GridHostelInfo.DataSource = dt;

//            SELECT Orders.OrderID, Customers.CustomerName, Orders.OrderDate
//FROM Orders
//INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID;






        }

        private void btnTriage_Click(object sender, EventArgs e)
        {
            Dispensary ds = new Dispensary();
            ds.Show();

        }

        private void button43_Click(object sender, EventArgs e)
        {
            ReferralForm rf = new ReferralForm();
            rf.Show();
        }

        private void GridHostelInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HostelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }
        //protected void dataGridMedicines_RowDataBound(object sender, GridViewRowEventArgs e)
        //{
        //    if (e.Row.RowIndex >= 0)
        //    {
        //        var DrugMDate = DateTime.Parse(e.Row.Cells[7].Text);
        //        var DrugEDate = DateTime.Parse(e.Row.Cells[7].Text);

        //        if (DrugMDate > DrugEDate)
        //        {
        //            e.Row.Cells[7].BackColor = Color.Red;
        //            e.Row.Cells[7].ForeColor = Color.White;
        //        }
        //    }
        //}

        private void button28_Click_1(object sender, EventArgs e)
        {


            panelMedicines.Visible = true;
            panelMedicines.BringToFront();
            string query = "SELECT * FROM Drugs";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridMedicines.DataSource = dt;
            


            dataGridMedicines.Columns.Add("newColumnName", "Days To Expiry");



            DateTime d1;
            DateTime d2;
            for (int i = 0; i < dataGridMedicines.RowCount; i++)
            {
                d1 = Convert.ToDateTime(dataGridMedicines.Rows[i].Cells[6].Value);
                d2 = Convert.ToDateTime(dataGridMedicines.Rows[i].Cells[5].Value);
                TimeSpan ts = d1 - d2;
                dataGridMedicines.Rows[i].Cells[7].Value = ts.Days;
            }

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click_1(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnMedicCategories_Click(object sender, EventArgs e)
        {
            NewDrugCategory dr = new NewDrugCategory();
            dr.Show();
        }

        private void btnNewMedicine_Click(object sender, EventArgs e)
        {
            NewMedicine nm = new NewMedicine();
            nm.Show();
        }
    }
    }

   

        //btnNext.Content = "Next";
        //// here is the problem
        //NewPage np = new NewPage();
        //this.NavigationService.Navigate(np);
 


    
    
    
    

   

    
    
    
   

