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
    public partial class ListClasses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // resets the result window
            classes_result.InnerHtml = "";

            string searchkey = "";

            if (Page.IsPostBack)
            {
                searchkey = class_search.Text;
            }

            string query = "select CLASSCODE, concat(teachers.teacherfname, ' ', teachers.teacherlname) as TEACHERFULLNAME, STARTDATE, FINISHDATE, CLASSNAME from classes join teachers on classes.TEACHERID = teachers.TEACHERID ";
            //"select * from CLASSES LEFT JOIN TEACHERS ON classes.TEACHERID = teachers.TEACHERID )";


            if (searchkey != "")
            {
                query += " WHERE LOWER(CLASSCODE) like '%" + searchkey + "%' ";
                query += " OR LOWER(CLASSNAME) like '%" + searchkey + "%' ";
                query += " OR LOWER(Concat(teachers.teacherfname, ' ', teachers.teacherlname)) like '%" + searchkey + "%' ";
            }

            //sql_debugger.InnerHtml = query;
            // COMMENT OUT THE ABOVE LINE AFTER DEBUGGING COMPLETE


            var db = new SCHOOLDB();
            List<Dictionary<String, String>> rs = db.List_Query(query);
           
            foreach(Dictionary<String, String> row in rs)
            {
                classes_result.InnerHtml += "<div class=\"listitem\">";

                // string classid = row["CLASSID"];

                string classcode = row["CLASSCODE"];
                classes_result.InnerHtml += "<div class=\"col7\">" + classcode + "</div>";

                // classes_result.InnerHtml += "<div class=\"col7\"><a href=\"ShowClasses.aspx?classid="+classid+">" + classcode + "</a></div>";

                string classname = row["CLASSNAME"];
                classes_result.InnerHtml += "<div class=\"col7\">" + classname + "</div>";

                string teacher = row["TEACHERFULLNAME"];
                classes_result.InnerHtml += "<div class=\"col7\">" + teacher + "</div>";

                string startdate = row["STARTDATE"];
                DateTime startdatetime = Convert.ToDateTime(startdate);
                DateTime startdateonly = startdatetime.Date;
                classes_result.InnerHtml += "<div class=\"col7\">" + startdateonly.ToString("d") + "</div>";

                string finishdate = row["FINISHDATE"];
                DateTime finishdatetime = Convert.ToDateTime(finishdate);
                DateTime finishdateonly = finishdatetime.Date;
                classes_result.InnerHtml += "<div class=\"col7\">" + finishdateonly.ToString("d") + "</div>";
                // SRC: HOW TO REMOVE TIME STAMP
                // https://docs.microsoft.com/en-us/dotnet/api/system.datetime.date?redirectedfrom=MSDN&view=netframework-4.8#System_DateTime_Date
                
                classes_result.InnerHtml += "<div class=\"col7\"><div class=\"editbutton\">Edit</div></div>";

                classes_result.InnerHtml += "<div class=\"col7last\"><div class=\"deletebutton\">Delete</div></div>";

                classes_result.InnerHtml += "</div>";


            }
        }
    }
}