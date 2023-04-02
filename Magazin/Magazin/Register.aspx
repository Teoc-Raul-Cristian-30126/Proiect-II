<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Magazin.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 239px;
        }
        .auto-style2 {
            width: 137px;
        }
        .auto-style3 {
            width: 137px;
            height: 50px;
        }
        .auto-style4 {
            width: 239px;
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
                    <td class="auto-style2" align="center">
                        <b>First Name:</b>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="FirstNameText" runat="server" Height="31px" Width="335px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FirstNameText" ErrorMessage="First Name is empty" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" align="center">
                        <b>Last Name:</b>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="LastNameText" runat="server" Height="31px" Width="335px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="LastNameText" ErrorMessage="Last Name is empty" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" align="center">
                        <b>Email:</b>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="EmailText" runat="server" Height="31px" Width="336px" TextMode="Email"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="EmailText" ErrorMessage="Email is empty" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" align="center">
                        <b>Gender:</b>
                    </td>
                    <td class="auto-style1">
                        <asp:DropDownList ID="GenderSelect" runat="server" Height="35px" Width="343px">
                            <asp:ListItem>Select Gender</asp:ListItem>
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="GenderSelect" ErrorMessage="Gender is empty" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" align="center">
                        <b>Address:</b>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="AddressText" runat="server" Height="31px" Width="336px" TextMode="MultiLine"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="AddressText" ErrorMessage="Address is empty" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" align="center">
                        <b>Phone Number:</b>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="PhoneText" runat="server" Height="31px" Width="335px" TextMode="Number"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="PhoneText" ErrorMessage="Phone is empty" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="PhoneText" ErrorMessage="Invalid Phone Number" ForeColor="#CC0000" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" align="center">
                        <b>Password:</b>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="PasswordText" runat="server" Height="31px" Width="335px" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="PasswordText" ErrorMessage="Password is empty" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" align="center">
                        <b>Confirm Password:</b>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="ConfirmPasswordText" runat="server" Height="31px" Width="335px" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="ConfirmPasswordText" ErrorMessage="Password is empty" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="PasswordText" ControlToValidate="ConfirmPasswordText" ErrorMessage="Password is not the same" ForeColor="#CC0000"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#CC0000" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="registerButton" runat="server" Text="Register" Font-Bold="True" Font-Size="Larger" Height="36px" Width="157px" OnClick="Button1_Click" />
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
