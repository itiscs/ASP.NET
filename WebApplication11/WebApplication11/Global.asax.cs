using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication11
{
    public class Global : System.Web.HttpApplication
    {
        public static String strCon = System.Configuration.ConfigurationManager.
            ConnectionStrings["myBaseConnectionString1"].ConnectionString;

        protected void Application_Start(object sender, EventArgs e)
        {

        }
    }
}