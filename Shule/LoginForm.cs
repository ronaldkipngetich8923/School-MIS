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
    public partial class LoginForm : Form
    {
        Function fn = new Function();
        String query;
        public LoginForm()
        {
            InitializeComponent();
        }

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
            query = "select * from users";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                if (txtUsename.Text == "root" && txtPassword.Text == "root")
                {
                    Home hs = new Home();
                    hs.Show();
                    this.Hide();
                }
            }
            //else
            ////{
            ////    query = "select * from users where UserRole = '" + combBoxRole.SelectedItem + "'";
            //ds = fn.getData(query);

            if (combBoxRole.SelectedIndex == 0)
                {
                    query = "select * from users where UserRole ='Admin' and username ='"+txtUsename.Text+ "' and Pass ='" + txtPassword.Text + "'";

                }
                else if (combBoxRole.SelectedIndex == 1)
                {
                    query = "select * from users where UserRole ='Teacher' and username ='" + txtUsename.Text + "' and Pass ='" + txtPassword.Text + "'";

                }
                else
                {
                    MessageBox.Show("User does not Exist");
                }
            }
        }
    }

