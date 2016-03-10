using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication11
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["My site cookies"];
            if(cookie!=null)
            {
                lbl1.Text = cookie["Language"].ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("My site cookies");
            cookie["Language"] = "ru-ru";
            cookie["UserName"] = "Admin";
            cookie.Expires = DateTime.Now.AddDays(1);

            Response.Cookies.Add(cookie);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}