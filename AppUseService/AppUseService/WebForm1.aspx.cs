using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppUseService.MyServiceReference;

namespace AppUseService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Service1Client client;
        public PersonType pers = new PersonType();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            client = new Service1Client();
            lblHello.Text = client.HelloFromService();
            Page.DataBind();
            
        }

        protected void btnSum_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            txtSum.Text = client.CalcSum(a, b).ToString();
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            pers = client.GetPersonByID(int.Parse(txtID.Text));
            //lblID.Text = pers?.PersonID.ToString();
            //lblName.Text = pers?.Name;
            //lblAge.Text = pers?.Age.ToString();
            Page.DataBind();
        }
    }
}





