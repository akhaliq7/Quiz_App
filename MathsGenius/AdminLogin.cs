using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsGenius
{
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }
        //public static class
        public static string admin_fk;
        //login method to check if login works
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //assign textbox values string variables
            string ad_username = txtUsername.Text;
            string ad_password = txtPassword.Text;
            //create variables so they can store weather or not user id exists
            string ad_id_db, ad_password_db;

            database db = new database(); //database class is instantiated and object is created

            //get value for whether user exists
            ad_id_db = db.scalar("select count(ad_id) from admin_1 where ad_user = '" + ad_username + " ' ");
            try //run code
            {
                if (ad_id_db.Equals("0")) //if equals to 0
                {
                    MessageBox.Show("Invalid username!"); //show message box
                }
                else //if equals to >= 1
                {
                    //insert password from the user name selected
                    ad_password_db = db.scalar("select ad_password from admin_1 where ad_user = '" + ad_username + " ' ");

                    if (ad_password_db.Equals(ad_password)) //check whether the passwords match
                    {
                        //check to see whether or not the user exists
                        admin_fk = db.scalar("select ad_id from admin_1 where ad_user = '" + ad_username + " ' ");
                        this.Hide(); //hide form
                        frmAdminUser admin = new frmAdminUser(); //create new instance of frmAdminUser
                        admin.Show(); //show new adminUser form
                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password!");//wrong password entered
                    }
                }
            }
            catch (Exception) //display error message if the code fails to run because of an unhandled exception
            {
                MessageBox.Show("Error");
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //close the application
        }

        private void frmAdminLogin_Load(object sender, EventArgs e)
        {
            hide_login_form(); //if user is logged in then hide the login form and display the admin user button and the admin question button
        }

        public void hide_login_form()
        {
            database db = new database(); //create a new instance of the database class
            int check = 0; //variable to check whether or not the admin is logged in
            check = Convert.ToInt32(db.scalar("select count(ad_id) from admin_1 where ad_id='" + frmAdminLogin.admin_fk + "'"));
            if (check == 1) //if they are then hide login form and display the navigation buttons to adminUser and adminQuestion and display welcome label
            {
                lblUsername.Visible = false;
                lblPassword.Visible = false;
                txtUsername.Visible = false;
                txtPassword.Visible = false;
                btnLogin.Visible = false;
                lblWelcome.Visible = true;
                grpLogin.Text = "";
                btnQuestions.Visible = true;
                btnUser.Visible = true;
            }
        }

   

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide the form
            frmIndex home = new frmIndex(); //create new instance of frmIndex
            home.Show();//display frmindex
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide the form
            frmAdminUser admin = new frmAdminUser(); //create new instance of frmAdminUser
            admin.Show(); //display frmadminUser
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            Application.Exit(); //close the application
        }

        private void btnQuestions_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide the form
            frmAdminQuest questions = new frmAdminQuest(); //create a new instance of frmAdminQuest
            questions.Show(); //display adminQuest
        }
    }
}
