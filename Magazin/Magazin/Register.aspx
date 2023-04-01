<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Magazin.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 292px;
        }
        .auto-style2 {
            width: 137px;
        }
        .auto-style3 {
            width: 137px;
            height: 50px;
        }
        .auto-style4 {
            width: 292px;
            height: 50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table align="center" style="width: 500px; height: 500px; background-color: #5f98f3" >
                <tr>
                    <td colspan="2" align="center">
                        <h2>Registration Page</h2>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <b>First Name:</b>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="FirstNameText" runat="server" Height="31px" Width="335px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <b>Last Name:</b>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="LastNameText" runat="server" Height="31px" Width="335px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <b>Email:</b>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="EmailText" runat="server" Height="31px" Width="336px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <b>Gender:</b>
                    </td>
                    <td class="auto-style1">
                        <asp:DropDownList ID="GenderSelect" runat="server" Height="35px" Width="343px">
                            <asp:ListItem>Select Gender</asp:ListItem>
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                            <asp:ListItem>Elicopter</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <b>Address:</b>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="AddressText" runat="server" Height="31px" Width="335px" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <b>Phone Number:</b>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="PhoneText" runat="server" Height="31px" Width="335px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <b>Password:</b>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="PasswordText" runat="server" Height="31px" Width="335px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <b>Confirm Password:</b>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="ConfirmPasswordText" runat="server" Height="31px" Width="335px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Button1" runat="server" Text="Register" Font-Bold="True" Font-Size="Larger" Height="36px" Width="157px" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
