using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AuthApp
{
    public partial class AddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string hashed = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "SHA1");

            
            Configuration MyConfig = WebConfigurationManager.OpenWebConfiguration("./web.config");
            ConfigurationSectionGroup SystemWeb = MyConfig.SectionGroups["system.web"];
            AuthenticationSection AuthSec =
                (AuthenticationSection)SystemWeb.Sections["authentication"];

            AuthSec.Forms.Credentials.Users.Add(
                new FormsAuthenticationUser(txtUsername.Text, hashed));

            MyConfig.Save();
        }
    }
}