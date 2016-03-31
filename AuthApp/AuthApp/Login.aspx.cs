using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AuthApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            Page.Validate();
            if (!Page.IsValid) return;

            if (Membership.ValidateUser(lgn.UserName, lgn.Password))
            {   
                // Создать билет, добавить cookie-набор к ответу и 
                // перенаправить на исходную запрошенную страницу
                FormsAuthentication.RedirectFromLoginPage(lgn.UserName, false);
            }
        }
    }
}