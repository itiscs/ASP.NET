using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AuthApp
{
    public partial class SecurePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(Roles.IsUserInRole(User.Identity.Name,"Admin"))
                lblName.Text = $"Админ - {User.Identity.Name} ";
            else
                lblName.Text = $"Пользователь - {User.Identity.Name} ";

        }
    }
}