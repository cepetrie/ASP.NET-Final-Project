using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceReference1;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //returns a key larger than zero if the login is successful

        ServiceReference1.FanLoginServiceClient fan = new FanLoginServiceClient();
        int key = fan.loginFan(txtUserName.Text, txtPassword.Text);
        if (key > 0)
        {
            Session["key"] = key;
            Response.Redirect("Shows.aspx");
        }
        else
        {
            lbResult.Text = "login failed";
        }
    }
}