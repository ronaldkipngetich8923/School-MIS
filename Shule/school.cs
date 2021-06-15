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
        private bool isCollapsed;

        public Home()
        {
            InitializeComponent();
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AOUGB8E\SQLEXPRESS;Initial Catalog=shule;Integrated Security=True");
            
            customizeDesign();

           // hideSubmenu();
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
            Discipline.Visible = false;
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
            Discipline.Visible = false;
            SetupParameter.Visible = false;
            ManageStaff.Visible = false;
            Teachingstaff.Visible = false;
            subordinatestaff.Visible = false;
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
            Discipline.Visible = false;
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
            Discipline.Visible = false;
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
            Discipline.Visible = false;
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
            Discipline.Visible = false;
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
            Discipline.Visible = false;
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
            Discipline.Visible = false;
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
            Discipline.Visible = true;
            SetupParameter.Visible = false;
            ManageStaff.Visible = false;
            Teachingstaff.Visible = false;
            subordinatestaff.Visible = false;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Discipline.Visible = false;
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



            Discipline.Visible = false;
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
            Discipline.Visible = false;
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
            Discipline.Visible = false;
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
            AddStream st = new AddStream();
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

                panelDropDown.Height += 10;
                
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                    
                        {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                AdmissionBtn.Image = Resources.caretside;
                
                panelDropDown.Height -= 10;
               
                if (panelDropDown.Size == panelDropDown.MinimumSize)
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
            Discipline.Visible = false;
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

        private void button14_Click(object sender, EventArgs e)
        {
          // SqlConnection con = new SqlConnection("server = DESKTOP-AOUGB8E/SQLEXPRESS; database = shule; UID = root; password = ");
          //  con.Open();
            string qur = "INSERT INTO StudentMaster VALUES ('" + textBoxAdmNo.Text + "','" + textBoxStudentname.Text + "','" + dateTimePickerDob.Value.Date.ToString() + "','" + comboBoxGender.SelectedValue + "','" + comboBoxCounty.SelectedValue + "'," +
                "'" + textBoxPrimarySch.Text + "','" + textBoxKCPEMarks.Text + "','" + comboBoxDisability.SelectedItem + "','" + richTextBoxDisabilityDescription.Text + "'," +
                "'" + comboBoxClass.SelectedItem + "','" + comboBoxStream.SelectedValue + "','" + dateTimePicker1AdmDate.Value.Date.ToString() + "','" + textBoxParentname.Text + "'," +
                "'" + textBoxPhoneNo.Text + "','" + textBoxEmail.Text + "','" + richTextBoxPostalAddress.Text + "','" + textBoxTown.Text + "')";
            SqlCommand cmd = new SqlCommand(qur, sqlConnection);
            try
            {
                sqlConnection.Close();
                sqlConnection.Open();
                int rows =cmd.ExecuteNonQuery();

                MessageBox.Show(rows + " 1 row inserted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM StudentMaster", "server = DESKTOP-AOUGB8E/SQLEXPRESS; database = shule; UID = root; password = ");
            //DataSet ds = new DataSet();
            //da.Fill(ds, "StudentMaster");
           // StudentClinicGridView.DataSource = ds.Tables["StudentMaster"].DefaultView;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
           
            }
           
        }
   
}
