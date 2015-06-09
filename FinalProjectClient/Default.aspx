<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="StyleSheet.css" rel="stylesheet" />
<title>Fan Login</title>
</head>
<body>
<form id="form1" runat="server">
<h1>Fan Login</h1>

        <table>
                <tr>
                    <td>Enter User Name</td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                    </td>
                </tr>

                 <tr>
                     <td>Enter Password</td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>

                 <tr>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" Text="Login" OnClick="btnLogin_Click" />
                    </td>
                      <td>
                          <asp:Label ID="lbResult" runat="server" Text=""></asp:Label>
                    </td>
                </tr>

                     <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="Register.aspx" CausesValidation="false">Register</asp:LinkButton>
        </table>
    </form>
  </body>
</html>
