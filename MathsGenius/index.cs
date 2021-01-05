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
    public partial class frmIndex : Form
    {
        public frmIndex()
        {
            InitializeComponent();
        }
        
        //login button checks login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            login_check();
        }
        //form loads hide login method
        private void frmIndex_Load(object sender, EventArgs e)
        {
            hide_login_form();
        }
        //application closes once exit button is clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //once admin button is clicked adminlogin page is shown
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminLogin adminL = new frmAdminLogin();
            adminL.Show();
        }
        //once register button clicked then the register form shows
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister reg = new frmRegister();
            reg.Show();
        }
        //login check method will be connecting to the database and looking for user details and retrieving data.
        public void login_check()
        {
            
            user u = new user();    //user class is instantiated and object is created
            u.username = txtUsername.Text; //value is taken from the text box and inserted into the user class data member u.username
            u.password = txtPassword.Text; //value is taken from the text box and inserted into the user class data member u.password
            database db = new database(); //database class is instantiated and object is created

            //u.userdb data member takes a value from users table as stated and compared with u.username to get a value of 1 or 0
            u.userdb = db.scalar("Select count(u_id) from users where u_username = '" + u.username + "'");
            try //try statement just runs all the code in the curly brackets and stops at the end of the curly brackets
            {
                if (u.userdb.Equals("0")) //if userdb equal to 0 then following statement will run messagebox ("invalid username")
                {
                    MessageBox.Show("Invalid Username!");
                }
                else //if userdb doesn't equal to  0 then following commands will run
                {
                    //u.passworddb will retrive the value of count(u_id) from users table where the passwords from password data member is the same as the value of u_password in the database
                    u.passworddb = db.scalar("Select count(u_id) from users where u_password = '" + u.password + "'");
                    if (u.passworddb.Equals("0")) //if the values equals to 0 then messagebox show "invalid password"
                    {
                        MessageBox.Show("Invalid Password!");
                    }
                    else
                    {
                        user2.username = txtUsername.Text; //public static class user2 and its data member username gets the value from the txtUsername.Text
                        //public static data member userid in user2 static class gets value from database users were the username from server is compared to the username from the user class
                        user2.userid = Convert.ToInt32(db.scalar("select u_id from users where u_username ='" + u.username + "'"));
                        this.Hide(); //hides the current form
                        frmMenu menu = new frmMenu(); //creates a new instance of frmMenu
                        menu.Show(); //shows that instance of form menu
                    }
                }
            }
            catch (Exception) //if the try statement doesn't run successfully then messagebox shows "Error"
            {
                MessageBox.Show("Error");
            }

        }
        public void hide_login_form() // hide login form appears only if the user has already logged in
        {
            database db = new database(); //create a new instance of database
            int check = 0; //new variable to check weather user is logged in
            //sql query is inserted into check variable count(u_id) will return a value of 0 or 1 where the u_id matches userid of public static class
            check = Convert.ToInt32(db.scalar("select count(u_id) from users where u_id=" + user2.userid));
            if (check == 1) //if check equal 1 then hide the login form and display the label welcome and button menu
            {
                lblUsername.Visible = false;
                lblPassword.Visible = false;
                txtUsername.Visible = false;
                txtPassword.Visible = false;
                btnLogin.Visible = false;
                lblWelcome.Visible = true;
                btnMenu.Visible = true;
            }
        }

        //menu button takes user to  frmmenuand hides current form
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }


    }
}
