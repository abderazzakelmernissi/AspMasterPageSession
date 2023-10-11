using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace AspMasterPageSession
{
    public partial class login2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["erreur"] != null)
            {
                Label1.Text = "Veuillez s'authentifier d'abord";
            }
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            
            SqlConnection cn = new SqlConnection("Data Source=user6eb4;Initial Catalog=test ;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from login1 where username = '" + Login1.UserName.ToString() + "' And MotDePas='" + Login1.Password.ToString() + "'";
            cn.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["User"] = dr[0].ToString(); //Login1.UserName.ToString();
                Response.Redirect("home1.aspx");

            }
            dr.Close();
            cn.Close();
        }
    }
}