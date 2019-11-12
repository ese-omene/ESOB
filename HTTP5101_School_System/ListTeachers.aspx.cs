using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class ListTeachers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string query = "select * from teachers";
            //string query = "select * from students where studentfname like 'C%'";

            var db = new SCHOOLDB();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                teachers_list.InnerHtml += "<div class=\"listitem\">";

                string teacherfirstname = row["TEACHERFNAME"];
                teachers_list.InnerHtml += "<div class=\"col4\">" + teacherfirstname + "</div>";


                teachers_list.InnerHtml += "</div>";
            }


        }
    }
}