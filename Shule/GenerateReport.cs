using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;


namespace Shule
{
    public partial class GenerateReport : Form
    {
        public GenerateReport()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=shule;Integrated Security=True;");
        SqlCommand cmd;

        public object Application { get; private set; }

        // PrintDialog prnDialog;
        // PrintPreviewDialog prnPreview;
        // PrintDocument prnDocument;



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM exam_Results where Exam_Type='" + guna2ComboBox1.Text + "'", con);

                //DataTable dt = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda1.Fill(ds, "exam_Results");
                dataGridView1.DataSource = ds.Tables["exam_Results"].DefaultView;
                con.Close();

            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
             
        }

        private void GenerateReport_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // this.Application.Documents.Add(@"D:\\Test|\SampleTemplate.dotx");
            //
            CreatePrintPreviewControl();

        }
        public void ExportPDF()
        {
          
        }

        private PrintPreviewControl ppc;
        Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);
        private PrintDocument docToPrint = new PrintDocument();

        private void CreatePrintPreviewControl()
        {
            this.docToPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintPage);
            ppc = new PrintPreviewControl();
            ppc.Name = "PrintPreviewControl1";
            ppc.Dock = DockStyle.Fill;
            ppc.Location = new Point(88, 80);
            ppc.Document = docToPrint;
            ppc.Zoom = 0.25;
            ppc.Document.DocumentName = "c:\\";
            ppc.UseAntiAlias = true;

            // Add PrintPreviewControl to Form  
            Controls.Add(this.ppc);
        }

       
  
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            //string text = "This text to be printed. ";
            //e.Graphics.DrawString(text, new System.Drawing.Font("Georgia", 35, FontStyle.Bold),
            //    Brushes.Black, 10, 10);
            

            try
            {

               

               // PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("C:\\Users\\benja\\Desktop\\test.pdf", FileMode.Create, FileAccess.ReadWrite));
                doc.Open();

                System.Drawing.Image img = System.Drawing.Image.FromFile("C:\\Users\\benja\\Desktop\\pd.jpg");
                iTextSharp.text.Image itextimage = iTextSharp.text.Image.GetInstance(img, System.Drawing.Imaging.ImageFormat.Jpeg);
                itextimage.ScalePercent(30f);
                itextimage.Alignment = Element.ALIGN_CENTER;
                doc.Add(itextimage);

                Paragraph para2 = new Paragraph(" \n");
                para2.Alignment = Element.ALIGN_CENTER;
                doc.Add(para2);
                Paragraph para = new Paragraph("Examination Results. \n");
                para.Alignment = Element.ALIGN_CENTER;
                doc.Add(para);
                Paragraph para1 = new Paragraph(" \n");
                para2.Alignment = Element.ALIGN_CENTER;
                doc.Add(para1);

                PdfPTable table1 = new PdfPTable(14);
                table1.AddCell("AdmNo");
                table1.AddCell("Eng");
                table1.AddCell("Kisw");
                table1.AddCell("Maths");
                table1.AddCell("Bio");
                table1.AddCell("Phys");
                table1.AddCell("Chem");
                table1.AddCell("Geo");
                table1.AddCell("Hist");
                table1.AddCell("Business ");
                table1.AddCell("Computer");
                table1.AddCell("Drawing & Design");
                table1.AddCell("Total Marks");
                table1.AddCell("Grade");


                table1.TotalWidth = 550f;
                table1.LockedWidth = true;
                //relative col widths in proportions - 1/3 and 2/3

                float[] widths = new float[] { 1 / 43f, 1 / 43f, 1 / 43f, 1 / 43f, 1 / 43f, 1 / 43f, 1 / 43f, 1 / 43f, 1 / 43f, 1 / 43f, 1 / 43f, 1 / 43f, 1 / 43f, 1 / 43f };

                table1.SetWidths(widths);

                table1.HorizontalAlignment = 0;

                //leave a gap before and after the table

                // table1.SpacingBefore = 20f;

                //table1.SpacingAfter = 30f;

                string query = "SELECT AdmNo,English,Kiswahili,Mathematics,BIOLOGY,Physics,Chemistry,Geography,History,Business,Computer_Studies,Darwing_and_Design,Total_Marks,Grade  FROM exam_Results ORDER BY Total_Marks Desc ";
                SqlCommand cmd = new SqlCommand(query, con);
                try

                {
                    con.Open();
                    using (SqlDataReader rdr = cmd.ExecuteReader())

                    {
                        while (rdr.Read())

                        {
                            table1.AddCell(rdr[0].ToString());
                            table1.AddCell(rdr[1].ToString());
                            table1.AddCell(rdr[2].ToString());
                            table1.AddCell(rdr[3].ToString());
                            table1.AddCell(rdr[4].ToString());
                            table1.AddCell(rdr[5].ToString());
                            table1.AddCell(rdr[6].ToString());
                            table1.AddCell(rdr[7].ToString());
                            table1.AddCell(rdr[8].ToString());
                            table1.AddCell(rdr[9].ToString());
                            table1.AddCell(rdr[10].ToString());
                            table1.AddCell(rdr[11].ToString());
                            table1.AddCell(rdr[12].ToString());
                            table1.AddCell(rdr[13].ToString());

                        }

                    }
                    con.Close();

                    MessageBox.Show("Successfully Genarated");

                    doc.Add(table1);
                    doc.Close();
                }
                catch (Exception ex)

                {

                    MessageBox.Show(ex.Message);
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1Adm.Text!="" && guna2ComboBox1.Text!="")
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("SELECT * FROM exam_Results where AdmNo='" + guna2TextBox1Adm.Text + "' AND Exam_Type='" + guna2ComboBox1.Text + "'", con);

                    //DataTable dt = new DataTable();
                    SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda1.Fill(ds, "exam_Results");
                    dataGridView1.DataSource = ds.Tables["exam_Results"].DefaultView;
                    con.Close();

                }
                catch (Exception me)
                {
                    MessageBox.Show(me.Message);
                }
                
            }
          
            else
            {
                MessageBox.Show("Admission Number and Exam Type is Empty");
            }
           
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }
    }  
}
