using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.IO.Image;
//using iText.Kernel.Colors;
//using iText.Layout.Element;
using iText.Kernel.Pdf.Action;

namespace Shule
{
    public partial class Enter_Marks : Form
    {
        BackgroundWorker bw = new BackgroundWorker
        {
            WorkerReportsProgress = true,
            WorkerSupportsCancellation = true
        };

        public Enter_Marks()
        {
            InitializeComponent();
            InsertExcelRecords();
        }

        SqlConnection con = new SqlConnection("Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=shule;Integrated Security=True;");
        SqlCommand cmd;



        private void guna2Button2_Click(object sender, EventArgs e)
        {

            if (guna2TextBox1.Text!="" && guna2ComboBox1.Text!="" && guna2ComboBox2.Text!="")
            {
                cmd = new SqlCommand("insert into exam_results(AdmNo,Year,Term,Exam_Type,ENGLISH,KISWAHILI,MATHEMATICS,BIOLOGY,PHYSICS,CHEMISTRY,GEOGRAPHY,HISTORY,BUSINESS,COMPUTER_STUDIES,DARWING_AND_DESIGN,TOTAL_MARKS,GRADE) " +

               "values(@AdmNo,@Year,@Term,@Exam_Type,@ENGLISH,@KISWAHILI,@MATHEMATICS,@BIOLOGY,@PHYSICS,@CHEMISTRY,@GEOGRAPHY,@HISTORY,@BUSINESS,@COMPUTER_STUDIES,@DARWING_AND_DESIGN,@TOTAL_MARKS,@GRADE)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@AdmNo", guna2TextBox1.Text);
                cmd.Parameters.AddWithValue("@Year", guna2ComboBox1.Text);
                cmd.Parameters.AddWithValue("@Term", guna2ComboBox2.Text);
                cmd.Parameters.AddWithValue("@Exam_Type", guna2ComboBox3.Text);
                cmd.Parameters.AddWithValue("@ENGLISH", guna2TextBox2.Text);
                cmd.Parameters.AddWithValue("@KISWAHILI", guna2TextBox3.Text);
                cmd.Parameters.AddWithValue("@MATHEMATICS", guna2TextBox4.Text);
                cmd.Parameters.AddWithValue("@BIOLOGY", guna2TextBox7.Text);
                cmd.Parameters.AddWithValue("@PHYSICS", guna2TextBox5.Text);
                cmd.Parameters.AddWithValue("@CHEMISTRY", guna2TextBox6.Text);
                cmd.Parameters.AddWithValue("@GEOGRAPHY", guna2TextBox8.Text);
                cmd.Parameters.AddWithValue("@HISTORY", guna2TextBox10.Text);
                cmd.Parameters.AddWithValue("@BUSINESS", guna2TextBox12.Text);
                cmd.Parameters.AddWithValue("@COMPUTER_STUDIES", guna2TextBox11.Text);
                cmd.Parameters.AddWithValue("@DARWING_AND_DESIGN", guna2TextBox9.Text);
                cmd.Parameters.AddWithValue("@TOTAL_MARKS", guna2TextBox14.Text);
                cmd.Parameters.AddWithValue("@GRADE", guna2TextBox13.Text);



                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Marks Recorded Successfully");

                guna2TextBox1.Text = "";
                //guna2ComboBox1.Text="";
                // guna2ComboBox2.Text="";
                //guna2ComboBox3.Text="";
                guna2TextBox2.Text = "";
                guna2TextBox3.Text = "";
                guna2TextBox4.Text = "";
                guna2TextBox7.Text = "";
                guna2TextBox5.Text = "";
                guna2TextBox6.Text = "";
                guna2TextBox8.Text = "";
                guna2TextBox10.Text = "";
                guna2TextBox12.Text = "";
                guna2TextBox11.Text = "";
                guna2TextBox9.Text = "";
                guna2TextBox14.Text = "";
                guna2TextBox13.Text = "";
            }

            else
            {
                MessageBox.Show("Enter Admission No, Select Term and Year ");
            }

        }

        private void InsertExcelRecords()
        {
           // string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
           // string constr = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\benja\Documents\EmployeeList.xlsx;Extended Properties=""Excel 12.0 Xml; HDR = YES;""", path);
           //OleDbConnection Econ = new OleDbConnection(constr);

           // string Query = string.Format("Select [Employee Name],[DOB],[Email],[Mobile] FROM [{0}]", "EmployeeList");
           // OleDbCommand Ecom = new OleDbCommand(Query, Econ);
           // Econ.Open();

           // DataSet ds = new DataSet();
           // OleDbDataAdapter oda = new OleDbDataAdapter(Query, Econ);
           // Econ.Close();//close Excel connection after adding to data set 
            
           // oda.Fill(ds);
           // DataTable Exceldt = ds.Tables[0]; //copy data set to datatable  

           // for (int i = Exceldt.Rows.Count - 1; i >= 0; i--)
           // {
           //     if (Exceldt.Rows[i]["Employee Name"] == DBNull.Value || Exceldt.Rows[i]["Email"] == DBNull.Value)
           //     {
           //         Exceldt.Rows[i].Delete();
           //     }
           // }
           // Exceldt.AcceptChanges();


           // //creating object of SqlBulkCopy      
           // SqlBulkCopy objbulk = new SqlBulkCopy(con);
           // //assigning Destination table name      
           // objbulk.DestinationTableName = "Student";
           // //Mapping Table column    
           // objbulk.ColumnMappings.Add("[Employee Name]", "Name");
           // objbulk.ColumnMappings.Add("DOB", "DOB");
           // objbulk.ColumnMappings.Add("Email", "Email");
           // objbulk.ColumnMappings.Add("Mobile", "Mob");

           //con = new SqlConnection();

           //// con.ConnectionString = "server = VSBS01; database = dbHRVeniteck; User ID = sa; Password = veniteck@2016"; //Create DataBase Connection Details   

           // con.Open(); //Open DataBase conection  

           // objbulk.WriteToServer(Exceldt); //inserting Datatable Records to DataBase con.Close(); //Close DataBase conection  

           // con.Close();

           // MessageBox.Show("Data has been Imported successfully.", "Imported", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            decimal sum= Convert.ToDecimal(Convert.ToInt32(guna2TextBox2.Text) + Convert.ToInt32(guna2TextBox3.Text) + Convert.ToInt32(guna2TextBox4.Text) + Convert.ToInt32(guna2TextBox7.Text) + Convert.ToInt32(guna2TextBox5.Text) + Convert.ToInt32(guna2TextBox6.Text) + Convert.ToInt32(guna2TextBox8.Text) + Convert.ToInt32(guna2TextBox10.Text) + Convert.ToInt32(guna2TextBox12.Text) + Convert.ToInt32(guna2TextBox11.Text) + Convert.ToInt32(guna2TextBox9.Text) + Convert.ToInt32(guna2TextBox10.Text));
            guna2TextBox14.Text = sum.ToString();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            ////To where your opendialog box get starting location. My initial directory location is desktop.
            //openFileDialog1.InitialDirectory = "C://Desktop";
            ////Your opendialog box title name.
            //openFileDialog1.Title = "Select file to be upload.";
            ////which type file format you want to upload in database. just add them.
            //openFileDialog1.Filter = "Select Valid Document(*.xlsx;)|*.xlsx;";
            ////FilterIndex property represents the index of the filter currently selected in the file dialog box.
            //openFileDialog1.FilterIndex = 1;
            //try
            //{
            //    if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        if (openFileDialog1.CheckFileExists)
            //        {
            //            string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
            //            guna2TextBox15.Text = path;
            //            guna2Button4.Visible = true;
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please Upload document.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}


            //// OpenFileDialog od = new OpenFileDialog();
            ////od.Filter = "Excell|*.xls;*.xlsx;";
            ////od.FileName = "EmployeeList.xlsx";
            ////DialogResult dr = od.ShowDialog();
            ////if (dr == DialogResult.Abort)
            ////    return;
            ////if (dr == DialogResult.Cancel)
            ////    return;
            ////guna2TextBox15.Text = od.FileName.ToString();
            ////guna2Button4.Visible = true;
            ////_path = guna2TextBox15.Text;

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
           // string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
           // guna2Button4.Visible = false;
           // path = guna2TextBox15.Text;
           // if (guna2TextBox15.Text == "" || !guna2TextBox15.Text.Contains("EmployeeList.xlsx"))
           // {
           //     MessageBox.Show("Please Browse EmployeeList.xlsx to upload", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
           //     guna2TextBox15.Text = "";
           //     guna2Button4.Visible = false;
           //     return;
           // }
           // if (bw.IsBusy)
           // {
           //     return;
           // }

           // System.Diagnostics.Stopwatch sWatch = new System.Diagnostics.Stopwatch();
           // bw.DoWork += (bwSender, bwArg) =>
           // {
           //     //what happens here must not touch the form  
           //     //as it's in a different thread          
           //     sWatch.Start();
           //     InsertExcelRecords();
           // };

           // bw.ProgressChanged += (bwSender, bwArg) =>
           // {
           //     //update progress bars here  
           // };

           // bw.RunWorkerCompleted += (bwSender, bwArg) =>
           // {
           //     //now you're back in the UI thread you can update the form  
           //     //remember to dispose of bw now                 

           //     sWatch.Stop();

           //     //work is done, no need for the stop button now...  
           //     //****pb1.Visible = false;
           //     guna2TextBox15.Text = "";
           //     guna2Button1.Enabled = true;
           //    // ****label1.Visible = false;
           //     bw.Dispose();
           // };

           // //lets allow the user to click stop  
           ////** pb1.Visible = true;
           // guna2HtmlLabel19.Visible = true;
           // MessageBox.Show("Uploading has been started !.\nyou are free to do any other tasks in this application,if you wish to close this screen  you can do it.but please don't close this application until upload message popups.", "Upload processing..", MessageBoxButtons.OK, MessageBoxIcon.Information);

           // guna2Button1.Enabled = false;

           // //Starts the actual work - triggerrs the "DoWork" event  
           // bw.RunWorkerAsync();

        }

        private void guna2TextBox14_TextChanged(object sender, EventArgs e)
        {
            

                decimal sm = Convert.ToDecimal(guna2TextBox14.Text);

                if (sm <= 700 && sm >= 550)
                {
                    guna2TextBox13.Text = "A";
                }
                else if (sm < 550 && sm >= 400)
                {
                    guna2TextBox13.Text = "B";

                }
                else if (sm < 400 && sm >= 350)
                {
                    guna2TextBox13.Text = "C";
                }
                else if (sm < 350 && sm >= 200)
                {
                    guna2TextBox13.Text = "D";
                }
                else
                {
                    guna2TextBox13.Text = "E";
                }

                MessageBox.Show("Successfully Processed Results");

            guna2TextBox14.Text = Convert.ToString(guna2TextBox14.Text);

          
        }

        private void guna2TextBox13_TextChanged(object sender, EventArgs e)
        {
           // guna2TextBox14.Text = Convert.ToString(guna2TextBox14.Text);
            
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            ExportToPDF();
        }
        private void ExportToPDF()
        {


            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.ShowDialog();
            SaveFileDialog1.InitialDirectory = @"C:\\users\\benja";
            SaveFileDialog1.RestoreDirectory = true;
            SaveFileDialog1.Title = "Browse Text Files";
            //SaveFileDialog1.DefaultExt = "txt";
            SaveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            SaveFileDialog1.FilterIndex = 2;
            SaveFileDialog1.CheckFileExists = true;
            SaveFileDialog1.CheckPathExists = true;
            saveFileDialog1.RestoreDirectory = true;

            string strng = "SELECT AdmNo, English,Kiswahili,Grade FROM exam_Results where AdmNo='30' AND EXAM_Type='Final Eaxm'";
            cmd = new SqlCommand(strng, con);
            con.Open();


            // Must have write permissions to the path folder
            PdfWriter writer = new PdfWriter("C:\\Users\\benja\\demo.pdf");
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            // Add image
            Image img = new Image(ImageDataFactory
               .Create(@"C:\Users\benja\Pictures\nature.jpg"))
               .SetTextAlignment(TextAlignment.CENTER);
            document.Add(img);



            // Header
            Paragraph header = new Paragraph("Student Results")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(20);

            // New line
            Paragraph newline = new Paragraph(new Text("\n"));

            document.Add(newline);
            document.Add(header);

            // Add sub-header
            Paragraph subheader = new Paragraph("Form 1")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(15);
            document.Add(subheader);

            // Line separator
            LineSeparator ls = new LineSeparator(new SolidLine());
            document.Add(ls);

            // Add paragraph1
            Paragraph paragraph1 = new Paragraph("Lorem ipsum " +
               "dolor sit amet, consectetur adipiscing elit, " +
               "sed do eiusmod tempor incididunt ut labore " +
               "et dolore magna aliqua.");
            document.Add(paragraph1);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            con.Close();

            //// Table
            //Table table = new Table(2,false);
            //Cell cell11 = new Cell(1, 1)
            //   .SetBackgroundColor(ColorConstants.GRAY)
            //   .SetTextAlignment(TextAlignment.CENTER)
            //   .Add(new Paragraph("State"));
            //Cell cell12 = new Cell(1, 1)
            //   .SetBackgroundColor(ColorConstants.GRAY)
            //   .SetTextAlignment(TextAlignment.CENTER)
            //   .Add(new Paragraph("Capital"));

            //Cell cell21 = new Cell(1, 1)
            //   .SetTextAlignment(TextAlignment.CENTER)
            //   .Add(new Paragraph("New York"));
            //Cell cell22 = new Cell(1, 1)
            //   .SetTextAlignment(TextAlignment.CENTER)
            //   .Add(new Paragraph("Albany"));

            //Cell cell31 = new Cell(1, 1)
            //   .SetTextAlignment(TextAlignment.CENTER)
            //   .Add(new Paragraph("New Jersey"));
            //Cell cell32 = new Cell(1, 1)
            //   .SetTextAlignment(TextAlignment.CENTER)
            //   .Add(new Paragraph("Trenton"));

            //Cell cell41 = new Cell(1, 1)
            //   .SetTextAlignment(TextAlignment.CENTER)
            //   .Add(new Paragraph("California"));
            //Cell cell42 = new Cell(1, 1)
            //   .SetTextAlignment(TextAlignment.CENTER)
            //   .Add(new Paragraph("Sacramento"));

            //table.AddCell(cell11);
            //table.AddCell(cell12);
            //table.AddCell(cell21);
            //table.AddCell(cell22);
            //table.AddCell(cell31);
            //table.AddCell(cell32);
            //table.AddCell(cell41);
            //table.AddCell(cell42);

            //document.Add(newline);
            //document.Add(table);

            //// Hyper link
            //Link link = new Link("click here",
            //   PdfAction.CreateURI("https://www.google.com"));
            //Paragraph hyperLink = new Paragraph("Please ")
            //   .Add(link.SetBold().SetUnderline()
            //   .SetItalic().SetFontColor(ColorConstants.BLUE))
            //   .Add(" to go www.google.com.");

            //document.Add(newline);
            //document.Add(hyperLink);

            //// Page numbers
            //int n = pdf.GetNumberOfPages();
            //for (int i = 1; i <= n; i++)
            //{
            //    document.ShowTextAligned(new Paragraph(String
            //       .Format("page" + i + " of " + n)),
            //       559, 806, i, TextAlignment.RIGHT,
            //       VerticalAlignment.TOP, 0);
            //}

            //// Close document
            //document.Close();

        }
    }
}
