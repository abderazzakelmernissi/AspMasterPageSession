using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspCookies1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
       // Label1.Text = Request.Cookies["Last Visite"].Value.ToString();
            if (Request.Cookies["nomcomplete"] != null)
            {

                Label1.Text = "Votre Nom: " + Server.HtmlEncode(Request.Cookies["nomcomplete"]["nom"].ToString()) + " et Votre Prenom: " + Server.HtmlEncode(Request.Cookies["nomcomplete"]["prenom"].ToString());
               // Label1.Text = "Votre Nom: t Votre Prenom: ";


                Calendar1.SelectedDate = DateTime.Parse(Request.Cookies["Last Visite"].Value.ToString());
                Calendar1.VisibleDate = DateTime.Parse(Request.Cookies["Last Visite"].Value.ToString());

            }
        }
    }
}