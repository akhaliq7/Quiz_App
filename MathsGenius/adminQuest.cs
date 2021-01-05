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
    public partial class frmAdminQuest : Form
    {
        public frmAdminQuest()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide the form
            frmAdminUser admin = new frmAdminUser(); //create new instance of frmadminuser
            admin.Show();//display frmadminUser
        }

        private void frmAddQuestions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mathsGeniusDataSet.questions' table. You can move, or remove it, as needed.
            this.questionsTableAdapter.Fill(this.mathsGeniusDataSet.questions);

        }

       
        //save the questions from the textboxes into the questions database
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var conn = database.GetDatabase()) //use getdatabase metho from database class
            {
                conn.Open(); //open connection

                // Setup the command
                using (var cmd = new SqlCommand("insert into questions(q_question, q_optionA, q_optionB, q_optionC, q_optionD, q_correctOption, quiz_id_fk)values('" + txtQuestion.Text + "', '" + txtOptionA.Text + "','" + txtOptionB.Text + "', '" + txtOptionC.Text + "', '" + txtOptionD.Text + "','" + txtCorrect.Text + "','" + txtQuiz.Text + "')", conn))
                {
                    // Run the qry
                    var reader = cmd.ExecuteReader();

                }
                conn.Close(); //close connection
                MessageBox.Show("Data saved successfully!"); //messagebox successful message
            }
            this.questionsTableAdapter.Fill(this.mathsGeniusDataSet.questions); //reload questions table
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide this form
            frmAdminLogin AdLogin = new frmAdminLogin(); //create new instance of frmAdminLogin
            AdLogin.Show(); //display adminLogin
        }

        private void btnAdminUsers_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide this form
            frmAdminUser AdUser = new frmAdminUser(); //create new instance of adminuser
            AdUser.Show(); //display adminUser
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //aplication exits
        }

        

        

        
    }
}
