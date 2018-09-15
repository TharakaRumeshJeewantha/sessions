using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SSD
{
    public partial class mainpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("index.aspx");
            }
            else
            {
                Label1.Text = Session["username"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["authcookie"] != null)
            {
                Response.Cookies["authcookie"].Expires = DateTime.Now.AddDays(-2);
                Response.Redirect("index.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Cookies["authcookie"].Expires = DateTime.Now.AddDays(-2);
            Session.Clear();
            Response.Redirect("index.aspx");
        }
    }
}