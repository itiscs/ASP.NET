using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication11
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "http://code.jquery.com/jquery-1.7.2.min.js",

            });

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            int k = Convert.ToInt32(args.Value);
            
            args.IsValid = (k % 2 == 0);
                      
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
                Response.Redirect("WebForm2.aspx");
        }
    }
}