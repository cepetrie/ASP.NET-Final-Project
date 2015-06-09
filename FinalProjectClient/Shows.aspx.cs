using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceReference1;



public partial class Shows : System.Web.UI.Page
{
    FanLoginServiceClient fan = new FanLoginServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //Instantiate the service client so we have access to the serivce
        ServiceReference1.FanLoginServiceClient sc = new ServiceReference1.FanLoginServiceClient();
        //create an array and assign it the result of the service query
        ServiceReference1.ArtistInfo[] artists = sc.GetShowsByArtist(TextBox2.Text);
        //bind the array to the DataGrid
        GridView2.DataSource = artists;
        GridView2.DataBind();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Instantiate the service client so we have access to the serivce
        ServiceReference1.FanLoginServiceClient sc = new ServiceReference1.FanLoginServiceClient();
        //create an array and assign it the result of the service query
        ServiceReference1.ShowInfo[] shows = sc.GetShowsByVenue(TextBox1.Text);
        //bind the array to the DataGrid
        GridView1.DataSource = shows;
        GridView1.DataBind();

    }
}