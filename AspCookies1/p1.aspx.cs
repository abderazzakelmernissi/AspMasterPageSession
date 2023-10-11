using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspCookies1
{
    public partial class p1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["AcceptsCookies"] == null)
                {
                    Response.Cookies["TestCookie"].Value = "ok";
                    Response.Cookies["TestCookie"].Expires =
                        DateTime.Now.AddMinutes(1);
                    Response.Redirect("TestDeCookies.aspx?redirect=" +
                        Server.UrlEncode(Request.Url.ToString()));
                    
                }
                else 
                {
                    Label1.Text = "Accept cookies = " +
                    Server.UrlEncode(Request.QueryString["AcceptsCookies"]);
                
                }
            }


        }
    }
}