using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace MathsGenius
{
    class questions //class to store questions and anything related to questions
    {
        //data members
        public int q_id { get; set; }
        public string q_question { get; set; }
        public string q_optionA { get; set; }
        public string q_optionB { get; set; }
        public string q_optionC { get; set; }
        public string q_optionD { get; set; }
        public string q_correctOption { get; set; }
        public int quiz_id_fk { get; set; }
        public int i { get; set; }

        //constructor
        public questions()
        {
            q_id = 1;
            q_question = "";
            q_optionA = "";
            q_optionB = "";
            q_optionC = "";
            q_optionD = "";
            q_correctOption = "";
            quiz_id_fk = 0;
            i = 0;

        }

        private string connstring = ConfigurationManager.ConnectionStrings["mathsGenius"].ConnectionString;

      
        //not used but kept for future reference
        public string add_questions()
        {

            using (var conn = database.GetDatabase())
            {
                string msg = "";
                

                    try
                    {
                        SqlCommand cmd = new SqlCommand("[insert_questions]", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@q_question", SqlDbType.NVarChar).Value = q_question;
                        cmd.Parameters.Add("@q_optionA", SqlDbType.NVarChar, 200).Value = q_optionA;
                        cmd.Parameters.Add("@q_optionB", SqlDbType.NVarChar, 200).Value = q_optionB;
                        cmd.Parameters.Add("@q_optionC", SqlDbType.NVarChar, 200).Value = q_optionC;
                        cmd.Parameters.Add("@q_optionD", SqlDbType.NVarChar, 200).Value = q_optionD;
                        cmd.Parameters.Add("@q_correctOption", SqlDbType.NVarChar, 200).Value = q_correctOption;
                        cmd.Parameters.Add("@quiz_id_fk", SqlDbType.Int).Value = quiz_id_fk;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        msg = "data successfully inserted!";
                    }
                    catch (Exception)
                    {
                        msg = "data is not successfully inserted!";
                    }
                    finally
                    {
                        conn.Close();
                    }
                    return msg;
                }  
        }

        public void view_questions() //display questions method
        {
            using (var conn = database.GetDatabase()) //database class method called
            {
                //run  query
                string sql = "select q_id, q_question, q_optionA, q_optionB, q_optionC, q_optionD, Q_CORRECTOPTION, quiz_id_fk from questions where q_id = " + i + "and quiz_id_fk = " + frmMenu.quizid;
                SqlConnection connection = new SqlConnection(connstring); //create new Sql connection
                try //run this
                {
                    connection.Open(); //ope connection
                    SqlCommand cmd = new SqlCommand(sql, connection); //create sql command
                    SqlDataReader reader = cmd.ExecuteReader(); //create data reader and execute reader
                    while (reader.Read()) //if there are any rows
                    {
                        //insert each column retrieved into the following data memebrs
                        q_id= Convert.ToInt32(reader.GetValue(0));
                        q_question = reader.GetValue(1).ToString();
                        q_optionA = reader.GetValue(2).ToString();
                        q_optionB = reader.GetValue(3).ToString();
                        q_optionC = reader.GetValue(4).ToString();
                        q_optionD = reader.GetValue(5).ToString();
                        q_correctOption = reader.GetValue(6).ToString();
                        quiz_id_fk = Convert.ToInt32(reader.GetValue(7));
                    }
                    connection.Close(); //close the connection
                }
                catch (Exception) //if try fails show messagebox
                {
                    Console.WriteLine("Error 202");
                }
            }
        }
       
    }
}
