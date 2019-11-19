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
    public partial class ShowClasses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool valid = true;
            string classid = Request.QueryString["classid"];
            if (String.IsNullOrEmpty(classid)) valid = false;

            if (valid)
            {
                var db = new SCHOOLDB();
                Dictionary<String, String> class_record = db.FindClass(Int32.Parse(classid));

                if (class_record.Count > 0)
                {
                    class_title.InnerHtml = class_record["CLASSCODE"] + " " + class_record["CLASSNAME"];
                    class_code.InnerHtml = class_record["CLASSCODE"];
                    class_name.InnerHtml = class_record["CLASSNAME"];
                    class_start.InnerHtml = class_record["STARTDATE"];
                    class_finish.InnerHtml = class_record["FINISHDATE"];
                }
                else
                {
                    valid = false;
                }
            }

            if (!valid)
            {
                class_div.InnerHtml = "There was an error finding that class";
            }
        }
    }
}