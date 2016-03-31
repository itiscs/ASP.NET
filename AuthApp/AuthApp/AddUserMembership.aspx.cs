using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AuthApp
{
    public partial class AddUserMembership : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {
            }

        protected void wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            Membership.CreateUser(wizard1.UserName, wizard1.Password, wizard1.Email);
            
        }
    }
}