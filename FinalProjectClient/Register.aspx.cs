using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceReference1;

public partial class Register : System.Web.UI.Page
{

    FanLoginServiceClient fan = new FanLoginServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        //instantiating a fanLoginservice reference object, and the two datacontracts for fan and login
        ServiceReference1.FanLoginServiceClient fs = new ServiceReference1.FanLoginServiceClient();
        ServiceReference1.FanData fan = new ServiceReference1.FanData();
        ServiceReference1.FanLoginData login = new ServiceReference1.FanLoginData();

        fan.fanName = txtFanName.Text;
        fan.fanEmail = txtEmail.Text;
       

        login.fanLoginPlainPassword = txtPassword.Text;
        login.fanLoginUserName = txtUserName.Text;

        //registerFan returns true if user was added to database, otherwise returns false
        Boolean goodRegister = fs.registerFan(fan, login);
        if (goodRegister)
        {
            lblMessage.Text = "Registered Successfully";
        }
        else
        {
            lblMessage.Text = "Error in registration. Try again";
        }
    }
    protected void FanClub_CheckedChanged(object sender, EventArgs e)
    {
        if (FanClub.Checked)
        {
            Label2.Text = "Thank you for joining the Fan Club";
        }
        else
        {

            Label2.Text = " ";
        }
    }
}