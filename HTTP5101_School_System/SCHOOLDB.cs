using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace HTTP5101_School_System
{
    public class SCHOOLDB
    {
        //things that describe a database
        // - A connection (url, port)
        // - A username
        // - A password
        // - A database

        //do not expose these pieces of information!
        //how do I know these?
        //boot up MAMP, open start page
        //info is right below the PHPmyAdmin link
        private static string User { get { return "humber_student"; } }
        private static string Password { get { return "humberisgreat123"; } }
        private static string Database { get { return "humber_school"; } }
        private static string Server { get { return "107.180.41.170"; } }
        private static string Port { get { return "3306"; } }

        //ConnectionString is something that we use to connect to a database
        private static string ConnectionString {
            get {
                return "server = "+Server
                    +"; user = "+User
                    +"; database = "+Database
                    +"; port = "+Port
                    +"; password = "+Password;
            }
        }

        //returns a result set
        //is a list dictionaries
        //a dictionary is like a list but with Key:Value pairs
        //they are also known as "associative arrays"
        public List<Dictionary<String,String>> List_Query(string query)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);

            // INPUT -> (string) SELECT QUERY 
            // e.g. "select * from students";
            // OUTPUT -> (List<Dictionary<String,String>>) RESULT SET 
            // e.g. 
            //[
            //  {"STUDENTFNAME":"SARAH","STUDENTLNAME":"Valdez","STUDENTNUMBER":"N1678","ENROLMENTDATE":"2018-06-18"},
            //  {"STUDENTFNAME":"Jennifer","STUDENTLNAME":"FAULKNER","STUDENTNUMBER":"N1679","ENROLMENTDATE":"2018-08-02"},
            //  {"STUDENTFNAME":"Austin","STUDENTLNAME":"Simon","STUDENTNUMBER":"N1682","ENROLMENTDATE":"2018-06-14"},
            //  ...
            //] 
            List<Dictionary<String, String>> ResultSet = new List<Dictionary<String, String>>();

            // try{} catch{} will attempt to do everything inside try{}
            // if an error happens inside try{}, then catch{} will execute instead.
            // very useful for debugging without the whole program crashing!
            // this can be easily abused and should be used sparingly.
            try
            {
                Debug.WriteLine("Connection Initialized...");
                Debug.WriteLine("Attempting to execute query"+query);
                //open the db connection
                Connect.Open();
                //give the connection a query
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                //grab the result set
                MySqlDataReader resultset = cmd.ExecuteReader();

                
                //for every row in the result set
                while (resultset.Read())
                {
                    Dictionary<String,String> Row = new Dictionary<String, String>();
                    //for every column in the row
                    for(int i = 0; i < resultset.FieldCount; i++)
                    {
                        Row.Add(resultset.GetName(i), resultset.GetString(i));
                        
                    }
                    
                    ResultSet.Add(Row);
                }//end row
                resultset.Close();

                
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the List_Query method!");
                Debug.WriteLine(ex.ToString());
               
            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return ResultSet;
        }


        public Dictionary<String, String> FindStudent(int id)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            Dictionary<String, String> student = new Dictionary<String, String>();

            try
            {
                string query = "select * from STUDENTS where studentid = "+id;
                Debug.WriteLine("Connection Initialized...");
                //open the db connection
                Connect.Open();
                //give the connection a query
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                //grab the result set
                MySqlDataReader resultset = cmd.ExecuteReader();

               
                List<Dictionary<String, String>> Rows = new List<Dictionary<String, String>>();
  
                while (resultset.Read())
                {
                    Dictionary<String, String> Row = new Dictionary<String, String>();
                        
                    //for every column in the row
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        Debug.WriteLine("Attempting to transfer data of "+ resultset.GetName(i));
                        Debug.WriteLine("Attempting to transfer data of " + resultset.GetString(i));
                        Row.Add(resultset.GetName(i), resultset.GetString(i));

                    }
                    Rows.Add(Row);
                }
                
                student = Rows[0]; //get the first student

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the find Student method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return student;
        }



    }
}