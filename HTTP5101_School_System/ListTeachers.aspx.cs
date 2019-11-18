using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Diagnostics;


namespace HTTP5101_School_System
{
    public partial class ListTeachers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //RESET RESULT SET
            teachers_result.InnerHtml = "";

            string searchkey = "";
            
            if (Page.IsPostBack)
            {
                searchkey = teacher_search.Text;
            }

            string query = "select * from TEACHERS";

            if (searchkey != "")
            {
                query += " WHERE LOWER(TEACHERFNAME) like '%" + searchkey + "%' ";
                query += " OR LOWER(TEACHERLNAME) like '%" + searchkey + "%' ";
                query += " OR LOWER(EMPLOYEENUMBER) like '%" + searchkey + "%' "; 
                query += " OR HIREDATE like '%" + searchkey + "%' "; 
                query += " OR SALARY like '%" + searchkey + "%' "; 
            }
            // sql_debugger.InnerHtml = query;
            // COMMENT OUT THE ABOVE LINE AFTER DEBUGGING COMPLETE



            var db = new SCHOOLDB();  // call a database to run the query on 
            List<Dictionary<String, String>> rs = db.List_Query(query) ;
                // running the query, running the List_Query function
                // can run List_Query function on a class (SCHOOLDB();)
                // rs is my result set
                // row is synonymous to TEACHER (for context)

            foreach (Dictionary<String, String> row in rs)
            {
                teachers_result.InnerHtml += "<div class=\"listitem\">";
                // \ escaping ; to ensure that the quotations are captured in the HTML; in this particular case, single quotations would also work

                string teacherid = row["TEACHERID"];

                string teacherfirstname = row["TEACHERFNAME"];
                teachers_result.InnerHtml += "<div class=\"col5\"><a href=\"ShowTeacher.aspx?teacherid="+teacherid+"\">" + teacherfirstname + "</a></div>";

                string teacherlastname = row["TEACHERLNAME"];
                teachers_result.InnerHtml += "<div class=\"col5\">" + teacherlastname + "</div>";

                string employeenumber = row["EMPLOYEENUMBER"];
                teachers_result.InnerHtml += "<div class=\"col5\">" + employeenumber + "</div>";

                string salary = row["SALARY"];
                teachers_result.InnerHtml += "<div class=\"col5\">" + salary + "</div>";

                string hiredate = row["HIREDATE"];
                DateTime hiredatetime = Convert.ToDateTime(hiredate);
                DateTime hiredateonly = hiredatetime.Date;
                teachers_result.InnerHtml += "<div class=\"col5last\">" + hiredateonly.ToString("d") + "</div>";
                // SRC: HOW TO REMOVE TIME STAMP
                // https://docs.microsoft.com/en-us/dotnet/api/system.datetime.date?redirectedfrom=MSDN&view=netframework-4.8#System_DateTime_Date


                teachers_result.InnerHtml += "</div>";

            }

        }

    }
}