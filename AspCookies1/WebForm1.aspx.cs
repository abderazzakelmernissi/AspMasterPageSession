using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspCookies1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Cookies["username"].Value = "Ahmed";
            //Response.Cookies["username"].Expires = DateTime.Now.AddDays(1);

            //HttpCookie aCookies = new HttpCookie("Last Visite");
            //aCookies.Value = DateTime.Now.ToString();
            //aCookies.Expires = DateTime.Now.AddDays(1);

            Response.Cookies["Last Visite"].Value = DateTime.Now.ToString();
            Response.Cookies["Last Visite"].Expires = DateTime.Now.AddDays(1);


            Response.Cookies["nomcomplete"]["nom"] = "Mouiti";
            Response.Cookies["nomcomplete"]["prenom"] = "Ahmed";
            Response.Cookies["nomcomplete"].Expires = DateTime.Now.AddDays(2);

          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //if (Response.Cookies["username"].Value != null) {

            //    Label1.Text = Server.HtmlEncode(Request.Cookies["userName"].Value);
            //}


            //if (Response.Cookies["nomcoplete"].Values != null)
            //{

            //    Label1.Text = "Votre Nom: "+Server.HtmlEncode(Request.Cookies["nomcomplete"]["nom"].ToString()) + " et Votre Prenom: " + Server.HtmlEncode(Response.Cookies["nomcomplete"]["prenom"].ToString());
            //}
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }
    }
}