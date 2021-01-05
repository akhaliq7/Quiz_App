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
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
        }
        //code runs when page loads
        private void profile2_Load(object sender, EventArgs e)
        {
            lblUsername.Text = user2.username; //static variable inserted into Username label
            search(); //search method will display score, users and quiz table in the listboxes

            
        }
        public void search()
        { 
            //listBox.clear clears the boxes of all text
            lstScoreId.Items.Clear();
            lstUsername.Items.Clear();
            lstQuiz.Items.Clear();

            try  //try statement just runs all the code in the curly brackets and stops at the end of the curly brackets

            {
                using (var conn = database.GetDatabase()) //uses the database class method to return a new instance of SQLConnection.
                {
                    conn.Open(); //opens the connection
                    //setup command
                    using (var cmd = new SqlCommand("SELECT s.score_id, s.score,s.high_score, s.dateAchieved, s.timeAchieved, u.u_username, q.quiz_name FROM users AS u INNER JOIN score AS s ON s.u_id_fk = u.u_id INNER JOIN quiz AS q ON s.quiz_id_fk = q.quiz_id where u.u_id=" + user2.userid, conn))
                    {
                        //run the query
                        using (var reader = cmd.ExecuteReader())
                        {
                            //loop rows
                            while (reader.Read())
                            {
                                //will insert each value from the sql query above into the listboxes as stated in the order 0 = s.score_id
                                //and so on, strings(nvarchar) need to be getString and integers need to be GetInt32
                                lstScoreId.Items.Add(reader.GetInt32(0));
                                lstScore.Items.Add(reader.GetInt32(1));
                                lstHighScore.Items.Add(reader.GetInt32(2));
                                lstDate.Items.Add(reader.GetString(3));
                                lstTime.Items.Add(reader.GetString(4));
                                lstUsername.Items.Add(reader.GetString(5));
                                lstQuiz.Items.Add(reader.GetString(6));
                            }
                        }
                    }
                    conn.Close(); //connection closes
                }
            }
            catch(Exception) //if try method fails to run then display error message "Error"
            {
                MessageBox.Show("Error");
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide(); //hides current form
            frmIndex home = new frmIndex(); //create new instance of frmIndex
            home.Show(); //display new instance of frmIndex
        }

        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            database db = new database(); //database class is instantiated and object is created
            //dialogue box appears showing "you want to delete user account" then another message "are you sure" with a yes or no button
            DialogResult dialogResult = MessageBox.Show("Are you sure", "you want to delete user account", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes) //if yes is clicked then delete user from database where u_id = logged in user
            {
                db.scalar("DELETE FROM users WHERE u_id = " + user2.userid);
            }
            else if (dialogResult == DialogResult.No)
            {
                //dialogue box closes if no is clicked
            }

            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //close the application
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide(); //hides current form
            frmMenu menu = new frmMenu(); //create new instance of frmMenu
            menu.Show(); //display new instance of frmMenu
        }
    }
}

