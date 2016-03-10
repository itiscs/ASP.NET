using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication11
{
    public partial class WebForm4 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["kod"] != null && !Page.IsPostBack)
            {
                string kod = Request.QueryString["kod"];        
                SqlConnection con = new SqlConnection(Global.strCon);
                SqlCommand cmd = new SqlCommand($"Select * from TOVARY where KOD_TOVAR={kod}", con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    txtTOVAR.Text = rdr.GetString(1);
                    txtED_IZM.Text = rdr.GetString(2);
                    txt_ZENA.Text = rdr[3].ToString();
                    txt_COUNT_TOV.Text = rdr[4].ToString();
                }
                con.Close();

            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["kod"] != null)
            {
                string kod = Request.QueryString["kod"];

                SqlConnection con = new SqlConnection(Global.strCon);
                SqlTransaction tran = con.BeginTransaction("Tran 1");
                string strCmd = "UPDATE TOVARY SET "+
                    $"COUNT_TOV={txt_COUNT_TOV.Text} WHERE KOD_TOVAR={kod}";

                SqlCommand cmd = new SqlCommand(strCmd, con, tran);
                

                con.Open();
                cmd.ExecuteNonQuery();               
                con.Close();

                Response.Redirect("WebForm3.aspx");
            }
            Trace.Write("Message 1");
            Trace.Warn("Warning 2"); 

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string tovar = txtTOVAR.Text;
            string edizm = txtED_IZM.Text;
            int zena = Convert.ToInt32(txt_ZENA.Text);
            int count_tov = Convert.ToInt32(txt_COUNT_TOV.Text); 

            SqlConnection con = new SqlConnection(Global.strCon);
            string strCmd = "INSERT INTO TOVARY(TOVAR,ED_IZM,ZENA,COUNT_TOV) " +
                "VALUES (@TOVAR,@ED_IZM,@ZENA,@COUNT);";
            
            SqlCommand cmd = new SqlCommand(strCmd, con);
            cmd.Parameters.AddWithValue("@TOVAR", tovar);
            cmd.Parameters.AddWithValue("@ED_IZM", edizm);
            cmd.Parameters.AddWithValue("@ZENA", zena);

            SqlParameter param = new SqlParameter("@COUNT", 
                System.Data.SqlDbType.Int);
            param.Direction = System.Data.ParameterDirection.Input;
            param.Value = count_tov;
            cmd.Parameters.Add(param);

            con.Open();
            int k = cmd.ExecuteNonQuery();
            con.Close();

            lblAdd.Text = $"Added {k} rows";



        }
    }
}