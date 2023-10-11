using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace AspMasterPageSession
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (Session["User"] != null)
            {
                Label2.Text = "Bonjour Mr " + Session["User"];
            }
            else {
                Label2.Text = "Utilisateur introval";
           
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["User"] = null;
            Label2.Text = "AuRevoir";

            //Response.Redirect("WebForm1.aspx");
        }
    }
}