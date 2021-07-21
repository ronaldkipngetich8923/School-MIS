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
    public partial class LoginForm : Form
    {
        //Function fn = new Function();
        String query;
        public LoginForm()
        {
            InitializeComponent();
        }
       SqlConnection con = new SqlConnection("Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True");

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsename.Clear();
            txtPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ////if (combBoxRole.SelectedIndex == 0)
            ////{
            ////    query = "select * from users where Uname='"+txtUsename+ "' AND pass='" + txtPassword + "'";
            ////}
            ////else if(combBoxRole.SelectedIndex == 0)
            //query = "select * from users";
            //DataSet ds = fn.getData(query);
            //if (ds.Tables[0].Rows.Count == 0)
            //{
            //    if (txtUsename.Text == "root" && txtPassword.Text == "root")
            //    {
            //        Home hs = new Home();
            //        hs.Show();
            //        this.Hide();
            //    }
            //}
            //else
            ////{
            ////    query = "select * from users where UserRole = '" + combBoxRole.SelectedItem + "'";
            //ds = fn.getData(query); 
            if (txtUsename.Text != "" && txtPassword.Text != "" && combBoxRole.SelectedIndex != 0)
            {
                try
                {
                    query = "select * from users where UserRole ='" + combBoxRole.SelectedItem + "' and Uname ='" + txtUsename.Text + "' and Pass ='" + txtPassword.Text + "'";
                   SqlDataAdapter sqlAdapter= new SqlDataAdapter(query, con);
                    Home hs = new Home();
                    hs.Show();
                    this.Hide();
                }
                catch (Exception)
                {

                    MessageBox.Show("User does not Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }
            }


            else
            {
                MessageBox.Show("Select user Type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                     
        
    }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            combBoxRole.Items.Insert(0, "..Select User Type..");
            combBoxRole.SelectedIndex = 0;
        }
    }
    }

