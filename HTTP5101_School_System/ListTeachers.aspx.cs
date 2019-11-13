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
            var db = new SCHOOLDB();
            List<Dictionary<String, String>> rs = db.List_Query("select * from teachers");
            foreach (Dictionary<String, String> row in rs)
            {
                teachers_result.InnerHtml += "<div class=\"listitem\">";

                string teacherfirstname = row["TEACHERFNAME"];
                teachers_result.InnerHtml += "<div class=\"col5\">" + teacherfirstname + "</div>";

                string teacherlastname = row["TEACHERLNAME"];
                teachers_result.InnerHtml += "<div class=\"col5\">" + teacherlastname + "</div>";

                string employeenumber = row["EMPLOYEENUMBER"];
                teachers_result.InnerHtml += "<div class=\"col5\">" + employeenumber + "</div>";

                string salary = row["SALARY"];
                teachers_result.InnerHtml += "<div class=\"col5\">" + salary + "</div>";

                string hiredate = row["HIREDATE"];
                teachers_result.InnerHtml += "<div class=\"col5last\">" + hiredate + "</div>";

                teachers_result.InnerHtml += "</div>";

            }

        }
    }
}