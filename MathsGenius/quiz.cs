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
    public partial class frmQuiz : Form
    {
        public frmQuiz()
        {
            InitializeComponent();

        }
        //questions class
        questions q = new questions(); //questions class is instantiated and object is created
        //public static variable
        public static int score =0; //public static class will store score
        //array
        int[] x = new int[10]; //array will help increment the questions

        //global variables are used in more than one method so i have to make it global
        int index = 0; // index will also help increment the questions as they will be inserted in to array
        string selAnswer = "", dbanswer = ""; //selAnswer stores the selected answer and dbanswer stores the database answer
        int questionNumber = 1; // this is too show what question number the user is on.
        
        private void quiz2_Load(object sender, EventArgs e)
        {
            database db = new database(); //database class is instantiated and object is created
            //insert the minimum question id from quiz selected by user this can vary.
            q.i = Convert.ToInt32(db.scalar("Select min(q_id) from questions where quiz_id_fk=" + frmMenu.quizid));
            x[index] = q.q_id; //the q.q_id is inserted into the array
            displayquestions(); // display the questions into the labels and checkboxes provided
            lblScore.Text = "Score: " + score.ToString(); //insert the initial score of 0 into the label
            lblUsername.Text = user2.username; //insert the username of the user thats logged in into Username label
            lblQuestionNumber.Text = "Question " + questionNumber.ToString(); //insert question number into question number label
        }

        public void displayquestions() //this method will display the questions from the question table
        {
            q.view_questions(); //questons class is being used to  view questions
            lblQuestion.Text = q.q_question.ToString(); //question is inserted into Question label
            chkOpA.Text = q.q_optionA.ToString(); //option a is inserted into option a checkbox
            chkOpB.Text = q.q_optionB.ToString(); //option b is inserted into option b checkbox
            chkOpC.Text = q.q_optionC.ToString(); //option c is inserted into option c checkbox
            chkOpD.Text = q.q_optionD.ToString(); //option d is inserted into option d checkbox
            dbanswer = q.q_correctOption.ToString(); //correct option is inserted into dbanswer variable
        }

        public void checkanswer() //this method will check if the answer is right
        {
            int points = 2; //when each question is right the user will be assigned 2 points
            if (chkOpA.Checked == true)
            {
                selAnswer = chkOpA.Text; //if optiona is select then the text of the checkbox will be inserted into selected answer variable
            }
            else if (chkOpB.Checked == true)
            {
                selAnswer = chkOpB.Text; //if optionb is select then the text of the checkbox will be inserted into selected answer variable
            }
            else if (chkOpC.Checked == true)
            {
                selAnswer = chkOpC.Text; //if optionc is select then the text of the checkbox will be inserted into selected answer variable
            }
            else if (chkOpD.Checked == true)
            {
                selAnswer = chkOpD.Text; //if optiond is select then the text of the checkbox will be inserted into selected answer variable
            }
            else
            {
                MessageBox.Show("Please select one option!"); //if no answer is selected then the message box will show "Please select one option!"
            }

            if (selAnswer.Equals(q.q_correctOption)) //if the selected answer matches the correct option then do the following:
            {
                score += points; //increment the score by the value of points(2)
                lblScore.Text = "Score: " + score.ToString(); //schow the score in the score label
            }
        }
        public void clearcheckbox() //the checkboxes are to be cleared each time the submit button is clicked
        {
            chkOpA.Checked = false;
            chkOpB.Checked = false;
            chkOpC.Checked = false;
            chkOpD.Checked = false;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            questionNumber++; //increment question number
            lblQuestionNumber.Text = "Question " + questionNumber.ToString(); //insert question number into questionnumber label
            checkanswer(); //check your answer
            index++; //increment index
            labelColour(); //labels change colour regarding weather they get the answer right or wrong
            q.i++; //increment the min(q_id) of the quiz selected 
            q.q_id++; //increment the question id in the question class
            gameover2(); //game is over regarding weather or not the score is >=10 or less than 10 
            displayquestions(); //displays the questions
            clearcheckbox(); //clears all the check boxes
            insert_into_score(); //inserts the score into the score table
        }
        public void labelColour()//labels colours change depending on right question or wrong
        {
            /*
             if the correctoption is selected and it equals the selected answer then 
             change the colour of the label to green, if its wrong then change the
             colour to red. There are 10 instances of x[index] so as you hit submit the
             index goes up by one and will need to match the if condition.
             */
            if (index == 1 && q.q_correctOption == selAnswer)
            {
                lbl1.BackColor = Color.Green;
            }
            else if (index == 1)
            {
                lbl1.BackColor = Color.Red;
            }

            if (index == 2 && q.q_correctOption == selAnswer)
            {
                lbl2.BackColor = Color.Green;
            }
            else if (index == 2)
            {
                lbl2.BackColor = Color.Red;
            }

            if (index == 3 && q.q_correctOption == selAnswer)
            {
                lbl3.BackColor = Color.Green;
            }
            else if (index == 3)
            {
                lbl3.BackColor = Color.Red;
            }

            if (index == 4 && q.q_correctOption == selAnswer)
            {
                lbl4.BackColor = Color.Green;
            }
            else if (index == 4)
            {
                lbl4.BackColor = Color.Red;
            }


            if (index == 5 && q.q_correctOption == selAnswer)
            {
                lbl5.BackColor = Color.Green;
            }
            else if (index == 5)
            {
                lbl5.BackColor = Color.Red;
            }
            if (index == 6 && q.q_correctOption == selAnswer)
            {
                lbl6.BackColor = Color.Green;
            }
            else if (index == 6)
            {
                lbl6.BackColor = Color.Red;
            }

            if (index == 7 && q.q_correctOption == selAnswer)
            {
                lbl7.BackColor = Color.Green;
            }
            else if (index == 7)
            {
                lbl7.BackColor = Color.Red;
            }

            if (index == 8 && q.q_correctOption == selAnswer)
            {
                lbl8.BackColor = Color.Green;
            }
            else if (index == 8)
            {
                lbl8.BackColor = Color.Red;
            }

            if (index == 9 && q.q_correctOption == selAnswer)
            {
                lbl9.BackColor = Color.Green;
            }
            else if (index == 9)
            {
                lbl9.BackColor = Color.Red;
            }

            if (index == 10 && q.q_correctOption == selAnswer)
            {
                lbl10.BackColor = Color.Green;
            }
            else if (index == 10)
            {
                lbl10.BackColor = Color.Red;
            }

        } //label changed method................

        private void btnExit_Click(object sender, EventArgs e)//close application
        {
            Application.Exit(); //Aplication exits
        }

        private void btnFinish_Click(object sender, EventArgs e)//if user click on button then it will take him too winning message screen
        {
            gameover(); //displays interaction form only happens if you get score of >=10
        }

        public void gameover() //method used to determine if user passed or failed
        {
            this.Hide(); //hides current form
            frmInteraction inter = new frmInteraction(); //create new instance of frmInteraction
            inter.Show(); //display new instance of frmInteraction
        }

        public void gameover2() //used like a readkey method to pause the game in that screen if user passes quiz
        {
            if (index == 10 && score >= 10) //if this condition is met then it means you passed the quiz andd will hide the quiz and display the finish button
            {
                lblQuestionNumber.Visible = false;
                lblQuestion.Visible = false;
                chkOpA.Visible = false;
                chkOpB.Visible = false;
                chkOpC.Visible = false;
                chkOpD.Visible = false;
                btnFinish.Visible = true;
                btnSubmit.Visible = false;
            }
            else if (index == 10) //this mean you couldn't pass the quiz so the quiz is still hidden and the sorry message is displayed

            {
                lblQuestionNumber.Visible = false;
                lblQuestion.Visible = false;
                chkOpA.Visible = false;
                chkOpB.Visible = false;
                chkOpC.Visible = false;
                chkOpD.Visible = false;
                lblSorry.Visible = true;
                btnSubmit.Visible = false;

            }
        }
        //to go back once the quiz is over
        private void picGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();//this form is hidden
            frmMenu menu = new frmMenu(); //new instance of frmMenu appears
            menu.Show(); //displays menu
        }

        public void insert_into_score() //insert score method inserts the score and it's fields into the score table.
        {
            database db = new database(); //database class is instantiated and object is created
            int maxscore = 0; //this variable is required to retrive data on the high_score from the database
            int check_high_score_empty = 0; //this variable is to check if the high score field in the database is empty
            //sql query inserts result into check_high_score_empty variable
            check_high_score_empty = Convert.ToInt32(db.scalar("select count(score_id) from score where high_score > 0"));
            if (check_high_score_empty.Equals(null)) //if the variable is null then do the following:
            {
                try //try statement just runs all the code in the curly brackets and stops at the end of the curly brackets
                {
                    //maxscore variable gets result of query maximum score value gets inserted into maxscore variable
                    maxscore = Convert.ToInt32(db.scalar("select max(score) from score where u_id_fk=" + user2.userid));
                }
                catch (Exception) //if the user has not yet played a quiz then this exception will be called
                {
                    MessageBox.Show("No score records in database found!");
                }
            }
            else
            {
                maxscore = score; //otherwise put the score value in maxvalue
            }
            
            scores s = new scores(); //score class is instantiated and object is created
            s.score = score; //score value goes into score class data member score
            s.high_score= maxscore; //maxscore value goes into score class data member high_score
            s.date_achieved = DateTime.Now.ToShortDateString(); //system date goes into score class data member date_achieved
            s.time_achieved = DateTime.Now.ToShortTimeString(); //system time goes into score class data member time_achieved
            s.u_id_fk = user2.userid; //logged in user id is inserted into score variable data member u_id_fk
            s.quiz_id_fk=frmMenu.quizid; //the values from frmMenu static variable quiz id is inserted into score class data member quiz_id_fk
            string lastquestion = db.scalar("select max(q_id) from questions where quiz_id_fk=" + frmMenu.quizid); //variable last question will hold the last question of the quiz_id_fk column so that it can equal the value of q.q_id
            try //try statement just runs all the code in the curly brackets and stops at the end of the curly brackets
            {
                if (lastquestion.Equals(q.q_id.ToString())) //if condition is met last question equals question id in question class then:
                {
                    s.insert_score();//insert the score
                }
            }
            catch(Exception)//if the score couldn't be inserted then messagebox will display
            {
                MessageBox.Show("Score not registered!");
            }
    }
        
    }
}

