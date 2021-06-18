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
    public partial class Streams : Form
    {
        SqlConnection sqlConnection;
        SqlDataReader sqlDataReader;
        public Streams()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cmdStr = "INSERT INTO Streams VALUES( '" + txtStreamName.Text + "')";
            SqlCommand sqlCommand = new SqlCommand(cmdStr, sqlConnection);
            try
            {
                sqlConnection.Close();
                sqlConnection.Open();
                int rows = sqlCommand.ExecuteNonQuery();

                MessageBox.Show(rows + " Stream inserted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Streams_Load(object sender, EventArgs e)
        {
            string connStr = "Data source=DESKTOP-AOUGB8E\\SQLEXPRESS;initial catalog=shule;integrated security=True";
            sqlConnection = new SqlConnection(connStr);
        }
    }
    }


