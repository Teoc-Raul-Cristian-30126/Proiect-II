<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Magazin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 29%;
            height: 191px;
        }
        .auto-style2 {
            width: 174px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table class="auto-style1" align="center" style="background-color: #5f98f3">
                <tr>
                    <td colspan="2" align="center">
                        <f2>Login Page</f2>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" align="center">
                        <b>Email:</b>
                    </td>
                    <td>
                        <asp:TextBox ID="emailText" runat="server" Height="25px" Width="221px" TextMode="Email"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" align="center">
                        <b>Password:</b>
                    </td>
                    <td>
                        <asp:TextBox ID="passwordText" runat="server" Height="25px" Width="220px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Button1" runat="server" Height="37px" Text="Login" Width="102px" Font-Bold="True" Font-Size="Larger" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
