using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication11
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(GridView1.SelectedIndex>=0)
            {
                string kod = GridView1.SelectedDataKey.Value.ToString();
                Response.Redirect($"WebForm4.aspx?kod={kod}");

            }
        }
    }
}