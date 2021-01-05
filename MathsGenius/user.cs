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
    class user
    {
        //member attributes
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string userdb { get; set; }
        public string passworddb { get; set; }

        private string connstring = ConfigurationManager.ConnectionStrings["mathsGenius"].ConnectionString;

        //costructor
        public user()
        {
            username = "";
            password = "";
            email = "";
            userdb = "";
            passworddb = "";
        }
        //add user into user table
        public string insert_user()
        {

            string msg = "";
            SqlConnection conn = new SqlConnection(connstring); //create new sqlconnection

            try //run this
            {
                SqlCommand cmd = new SqlCommand("[insert_user]", conn); //create new sql command
                cmd.CommandType = CommandType.StoredProcedure; //use procedure from SQL server
                //bind the parameters with temporary local variables
                cmd.Parameters.Add("@u_username", SqlDbType.NVarChar, 200).Value = username;
                cmd.Parameters.Add("@u_password", SqlDbType.NVarChar, 200).Value = password;
                cmd.Parameters.Add("@u_email", SqlDbType.NVarChar, 200).Value = email;

                conn.Open(); //open the connection
                cmd.ExecuteNonQuery();//execute query
                msg = "New user created!"; //message box user created
            }
            catch (Exception) //if try fails "try again"
            {
                msg = "Try Again!";
            }
            finally
            {
                conn.Close(); //close connection
            }
            return msg; 
        }
    }

}





