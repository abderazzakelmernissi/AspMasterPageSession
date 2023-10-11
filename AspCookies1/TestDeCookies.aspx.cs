using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspCookies1
{
    public partial class TestDeCookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string redirect = Request.QueryString["redirect"];
            string acceptsCookies;
            if (Request.Cookies["TestCookie"] == null)
                acceptsCookies = "no";
            else
            {
                acceptsCookies = "yes";
                // Delete test cookie.
                Response.Cookies["TestCookie"].Expires = DateTime.Now.AddDays(-1);
            }
            Response.Redirect(redirect + "?AcceptsCookies=" + acceptsCookies, true);
        }
    }
}