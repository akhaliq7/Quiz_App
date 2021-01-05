using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MathsGenius
{
    public partial class frmAdminUser : Form
    {
        public frmAdminUser()
        {
            InitializeComponent();
        }
        //save the user details from the textboxes into the columns in the sql query
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var conn = database.GetDatabase()) //get method from database class
            {
                conn.Open(); //open the connection

                // Setup the command
                using (var cmd = new SqlCommand("INSERT INTO users (u_username, u_password, u_email) Values('" + txtUsername.Text + "', '" + txtPassword.Text + "','" + txtEmail.Text + "')", conn))
                {
                    // Run the qry
                    var reader = cmd.ExecuteReader();

                }
                conn.Close(); //colse the connection
                MessageBox.Show("Data saved successfully!"); //messagebox
            }
        }



        private void btnView_Click(object sender, EventArgs e)
        {
            search(); //display users in list box
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //close the application
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide the form
            frmIndex Home = new frmIndex(); //create new instance of frmIndex
            Home.Show(); //dispplay frmindex
        }

        public void search() //display username and email of users into listboxes provided
        {
            //clear the listboxes of any values
            lstUsername.Items.Clear();
            lstEmail.Items.Clear();


            using (var conn = database.GetDatabase()) //use database class method to connect
            {
                conn.Open(); //connection open
                //setup command
                using (var cmd = new SqlCommand("SELECT u_username, u_email FROM users", conn))
                {
                    //run the query
                    using (var reader = cmd.ExecuteReader())
                    {
                        //loop rows
                        while (reader.Read())
                        {
                            //inserts values i.e. u_username goes into lstUsername etc.
                            lstUsername.Items.Add(reader.GetString(0));
                            lstEmail.Items.Add(reader.GetString(1));
                        }
                    }
                }
                conn.Close(); //close the connection
            }
        }

        private void btnManageQuest_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide form
            frmAdminQuest AQ = new frmAdminQuest(); //create new instance of frmAdminQuest
            AQ.Show(); //display adminquest
        }



        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide form
            frmAdminLogin adLog = new frmAdminLogin(); //create new instance of frmAdminLogin
            adLog.Show(); //display adminlogin
        }
    }
}
