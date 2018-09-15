using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SSD
{
    public partial class index : System.Web.UI.Page
    {
        string uname = "admin";
        string pass = "pass";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["authcookie"] != null)
            {
                if (Request.Cookies["authcookie"]["username"] == uname && Request.Cookies["authcookie"]["password"] == pass)
                {
                    Response.Redirect("~/mainpage.aspx");
                }
            }
            if (Session["username"] != null)
            {
                Response.Redirect("~/mainpage.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == uname && TextBox2.Text == pass)
            {
                if (CheckBox1.Checked)
                {
                    Response.Cookies["authcookie"]["username"] = TextBox1.Text;
                    Response.Cookies["authcookie"]["password"] = TextBox2.Text;
                    Response.Cookies["authcookie"].Expires = DateTime.Now.AddDays(2);
                }
                Session["username"] = TextBox1.Text;
                Response.Redirect("~/mainpage.aspx");
            }
        }
    }
}