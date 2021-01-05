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
    class database
    {
        //connecting to sql server

            //connection data to connect to the database
        public static string connstring = ConfigurationManager.ConnectionStrings["mathsGenius"].ConnectionString;
        //string query;
        

        public string scalar(string query)
        {
            //Executes the query, and returns the first column of the first row in the result set returned by the query.
            //Additional columns or rows are ignored.
            string scalarmethod = "";
            SqlConnection conn = new SqlConnection(connstring); //connection object
            conn.Open(); //connection opens
            try //run this code
            {
                SqlCommand cmd = new SqlCommand(query, conn); //new sqlcommand object
                scalarmethod = cmd.ExecuteScalar().ToString(); //returs valuein scalarmethod string
            }
            catch (Exception) //if try fails then return nothing
            {
                scalarmethod = "";
            }
            finally
            {
                conn.Close(); //connection closes
            }
            return scalarmethod;
        }

        public static SqlConnection GetDatabase()
        {
            
       
            SqlConnection conn = new SqlConnection(connstring); //connection object

            return conn;
        }
    }
}
