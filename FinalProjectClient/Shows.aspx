<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Shows.aspx.cs" Inherits="Shows" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link href="StyleSheet.css" rel="stylesheet" />
    <title>Search Shows</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Search for shows</h1><br />
       
        <asp:Image ID="Image2" runat="server"  ImageUrl="~/show.jpg"/><br/><br/><br/>

              
        <div>
            <h2>Search by artist:</h2><br/>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br/>
            <asp:GridView ID="GridView2" runat="server"></asp:GridView><br/>
            <asp:Button ID="Button2" runat="server" Text="Get Artist" OnClick="Button2_Click" /><br/><br/><br/>
        </div>
        
     
        
        <div>
            <h2>Search by venue:</h2><br/>
         
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView><br/>
            <asp:Button ID="Button1" runat="server" Text="Get Venue" OnClick="Button1_Click" />
        </div>
        
    </div>
    </form>
</body>
</html>