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
    public partial class frmMenu : Form
    {
        public static int quizid;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            database db = new database(); //database class is instantiated and object is created
            //if add button is selected then 
            if (rdoAdd.Checked == true)
            {
                //insert the quiz_id number of add quiz into the public static varible of quiz_id
                quizid = Convert.ToInt32(db.scalar("select quiz_id from quiz where quiz_id =" + 1));
                this.Hide(); //hides current form
                frmQuiz quiz = new frmQuiz (); //create new instance of frmQuiz
                quiz.Show(); //display new instance of frmQuiz
            }
            else if (rdoMinus.Checked == true) //if minus button is selected then insert 2 into static variable quiz id
            {
                quizid = Convert.ToInt32(db.scalar("select quiz_id from quiz where quiz_id =" + 2));
                this.Hide(); //hides current form
                frmQuiz quiz = new frmQuiz(); //create new instance of frmQuiz
                quiz.Show(); //display new instance of frmQuiz
            }
            else if (rdoMultiply.Checked == true) //if multiply button is selected then insert 3 into static variable quiz id
            {
                quizid = Convert.ToInt32(db.scalar("select quiz_id from quiz where quiz_id =" + 3));
                this.Hide(); //hides current form
                frmQuiz quiz = new frmQuiz(); //create new instance of frmQuiz
                quiz.Show(); //display new instance of frmQuiz
            }
            else if (rdoDivide.Checked == true) //if divide button is selected then insert 8 into static variable quiz id
            {
                quizid = Convert.ToInt32(db.scalar("select quiz_id from quiz where quiz_id =" + 8));
                this.Hide(); //hides current form
                frmQuiz quiz = new frmQuiz(); //create new instance of frmQuiz
                quiz.Show(); //display new instance of frmQuiz
            }
            else
            {
                MessageBox.Show("Please choose a quiz!"); //if nothing is selected then error message is displayed!
            }
        }
        //if home button is clicked
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

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblUsername.Text = user2.username; //load menu form and display the logged in users username
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //application exits
        }
    }
}
