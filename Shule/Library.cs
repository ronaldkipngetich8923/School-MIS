using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shule
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }

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
            this.WindowState = FormWindowState.Maximized;
            Shelves.Visible = false;
            main.Visible = true;
            Books.Visible = false;
            Users.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Shelves.Visible = true;
            main.Visible = false;
            Books.Visible = false;
            Users.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Shelves.Visible = false;
            main.Visible = false;
            Books.Visible = true;
            Users.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Shelves.Visible = false;
            main.Visible = false;
            Books.Visible = false;
            Users.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Shelves.Visible = true;
            main.Visible = false;
            Books.Visible = false;
            Users.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Shelves.Visible = false;
            main.Visible = false;
            Books.Visible = true;
            Users.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Shelves.Visible = false;
            main.Visible = false;
            Books.Visible = false;
            Users.Visible = true;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
