using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MathsGenius
{
    class scores //stores score values and methods
    {
        //data members
        public int score_id { get; set; }
        public int score { get; set; }
        public int high_score { get; set; }
        public string date_achieved { get; set; }
        public string time_achieved { get; set; }
        public int u_id_fk { get; set; }
        public int quiz_id_fk { get; set; }

        //connection string
        private string connstring = ConfigurationManager.ConnectionStrings["mathsGenius"].ConnectionString;
        
        //constructor
        public scores()
        {
            score_id = 0;
            score = 0;
            high_score = 0;
            date_achieved="";
            time_achieved="";
            u_id_fk=0;
            quiz_id_fk = 0;
        }

        public string insert_score() //insert score into score table
        {
            string msg = ""; //empty string
            SqlConnection conn = new SqlConnection(connstring); //create new sqlconnection object

            try //run this
            {
                SqlCommand cmd = new SqlCommand("[insert_score]", conn); //create new sql command
                cmd.CommandType = CommandType.StoredProcedure; //use stored procedure in SQL Server
                //bind the parameters between the data members of score class and temporary variables
                cmd.Parameters.Add("@score", SqlDbType.Int).Value = score;
                cmd.Parameters.Add("@high_score", SqlDbType.Int).Value = high_score;
                cmd.Parameters.Add("@dateAchieved", SqlDbType.NVarChar, 200).Value = date_achieved;
                cmd.Parameters.Add("@timeAchieved", SqlDbType.NVarChar, 200).Value = time_achieved;
                cmd.Parameters.Add("@u_id_fk", SqlDbType.Int).Value = u_id_fk;
                cmd.Parameters.Add("@quiz_id_fk", SqlDbType.Int).Value = quiz_id_fk;

                conn.Open(); //open connection
                cmd.ExecuteNonQuery(); //execute query
                msg = "score inserted successfully!"; //message successful appears
            }
            catch (Exception)//if try fails display following message
            {
                msg = "data is not successfully inserted!"; 
            }
            finally
            {
                conn.Close(); //close the connection
            }
            return msg;
        }
    }
}
