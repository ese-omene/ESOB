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
            var db = new SCHOOLDB();
            List<Dictionary<String, String>> rs = db.List_Query("select CLASSCODE, concat(teachers.teacherfname, ' ' , teachers.teacherlname) as 'Teacher', STARTDATE, FINISHDATE, CLASSNAME from classes join teachers on classes.TEACHERID = teachers.TEACHERID ");
            foreach (Dictionary<String, String> row in rs)
            {
                classes_result.InnerHtml += "<div class=\"listitem\">";

                string classcode = row["CLASSCODE"];
                classes_result.InnerHtml += "<div class=\"col5\">" + classcode + "</div>";

                string classname = row["CLASSNAME"];
                classes_result.InnerHtml += "<div class=\"col5\">" + classname + "</div>";

                string teacher = row["Teacher"];
                classes_result.InnerHtml += "<div class=\"col5\">" + teacher + "</div>";

                string startdate = row["STARTDATE"];
                classes_result.InnerHtml += "<div class=\"col5\">" + startdate + "</div>";

                string finishdate = row["FINISHDATE"];
                classes_result.InnerHtml += "<div class=\"col5last\">" + finishdate + "</div>";


                classes_result.InnerHtml += "</div>";


            }
        }
    }
}