using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsGenius
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        //submit button does most of the work in order to register a new user
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            database db = new database(); //database class is instantiated and object is created
            user u = new user(); //user class is instantiated and object is created
            try //try statement just runs all the code in the curly brackets and stops at the end of the curly brackets
            {
                int userexists = 0; //new variable to check weather userexists
                //sql query is inserted into userexists variable count(u_id) will return a value of 0 or 1 where the u_username matches txtUsername.Text
                userexists = Convert.ToInt32(db.scalar("select count(u_id) from users where u_username='" + txtUsername.Text + "'"));
                if (userexists == 0) //if user doesn't exist then do this
                {
                    if (txtPassword.Text == txtReEnterPassword.Text) //if the two password textboxes do match then do this
                    {
                        u.username = txtUsername.Text; //insert the value of txtUsername.Text into user class data member username
                        u.password = txtPassword.Text; //insert the value of txtPassword.Text into user class data member password
                        u.email = txtEmail.Text; //insert the value of txtEmail.Text into user class data member email
                        u.insert_user(); //run the method in user class which inserts the user details into the database
                        after_register(); //this is the after register user interface changeover.
                    }
                    else // if password don't match then display "Passwords don't match, try again!"
                    {
                        MessageBox.Show("Passwords don't match, try again!");
                    }
                }
                else //if user exists then show message "user exists"
                {
                    MessageBox.Show("user exists");
                }
            }
            catch(Exception) //if the try statement doesn't run successfully then messagebox shows "Error"
            {
                MessageBox.Show("Error"); 
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Application exits once exit button is clicked
        }

        public void after_register() //code will run after user is registered
        {
            MessageBox.Show("User account created!"); //show message user is created
            txtUsername.Text = ""; //clear txtUsername text
            txtPassword.Text = ""; //clear text in txtPassword
            txtReEnterPassword.Text = ""; //clear text in txtReEnterPassword.text
            txtEmail.Text = ""; //clear text in txtEmail
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide(); //hides current form
            frmIndex home = new frmIndex(); //create new instance of frmIndex
            home.Show(); //display new instance of frmIndex
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide(); //hides current form
            frmProfile profile = new frmProfile(); //create new instance of frmProfile
            profile.Show(); //display new instance of frmProfile
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide(); //hides current form
            frmMenu menu = new frmMenu(); //create new instance of frmMenu
            menu.Show(); //display new instance of frmMenu
        }
    }
}
