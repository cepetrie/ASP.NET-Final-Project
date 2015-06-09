<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
        <head runat="server">
        <title>Register a fan</title>
      <link href="StyleSheet.css" rel="stylesheet" />
    </head>
<body>

   
    <form id="form1" runat="server">
    <div>

         <h1>Register a fan</h1>
    <table>
        <tr>
            <td>Fan name</td>
            <td class="auto-style1"><asp:TextBox ID="txtFanName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Email</td>
            <td class="auto-style1"><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>User Name</td>
            <td class="auto-style1"><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
             </td>
        </tr>
         <tr>
            <td>Password</td>
            <td class="auto-style1"><asp:TextBox ID="txtPassword" runat="server"  TextMode="Password"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Confirm Password</td>
            <td class="auto-style1"><asp:TextBox ID="txtPassword2" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
         <tr>
            <td>
                <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" /></td>
            <td>
                <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label></td>
        </tr>
       
    </table><br />


        <div>
        <p> Pls. check if you would like to join our Fan Club</p>
         <asp:CheckBox ID="FanClub" runat="server" Text="Join Fan Club" AutoPostBack="true" OnCheckedChanged="FanClub_CheckedChanged" CausesValidation="false"></asp:CheckBox><br/><br/>
             <asp:Label ID="Label2" runat="server" Text=""></asp:Label></td><br /><br />
        </div>


       <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="Default.aspx" CausesValidation="false">Login</asp:LinkButton>
       
         <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passwords must match" ControlToValidate="txtPassword" ControlToCompare="txtPassword2" Operator="Equal"></asp:CompareValidator>

        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Must enter valid email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtEmail"></asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="User name required" ControlToValidate="txtUserName" Display="None"></asp:RequiredFieldValidator>
    </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
