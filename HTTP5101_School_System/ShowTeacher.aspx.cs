using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class ShowTeacher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool valid = true; 
            string teacherid = Request.QueryString["teacherid"]; //QueryString is pulled from the GET(url)
            if (String.IsNullOrEmpty(teacherid)) valid = false;

            if (valid)
            {
                var db = new SCHOOLDB();
                Dictionary<String, String> teacher_record = db.FindTeacher(Int32.Parse(teacherid));

                if (teacher_record.Count >0)
                {
                    teacher_title_fname.InnerHtml = teacher_record["TEACHERFNAME"] + " " + teacher_record["TEACHERLNAME"];
                    teacher_fname.InnerHtml = teacher_record["TEACHERFNAME"];
                    teacher_lname.InnerHtml = teacher_record["TEACHERLNAME"];
                    employee_number.InnerHtml = teacher_record["EMPLOYEENUMBER"];
                    salary.InnerHtml = teacher_record["SALARY"];
                    hire_date.InnerHtml = teacher_record["HIREDATE"];
                }
                else
                {
                    valid = false;
                }


            }
            if (!valid)
            {
                teacher.InnerHtml = "There was an error finding that teacher"; 
            }
        }
    }
}