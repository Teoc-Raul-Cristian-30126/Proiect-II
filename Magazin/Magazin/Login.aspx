﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Magazin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
body {
  background-size: 100% 100%;
}
/* adaugăm margini și spațiere între elementele HTML */
table {
  margin-top: 50px;
  margin-bottom: 50px;
  margin-left: auto;
  margin-right: auto;
  border-collapse: separate;
  border-spacing: 10px 15px;
}

/* stilurile pentru antetul tabelului */
table th {
  color: white;
  text-align: center;
  padding: 10px;
}

/* stilurile pentru celulele tabelului */
table td {
  padding: 10px;
  text-align: center;
  background-color: #f2f2f2;
  border-radius: 5px;
}

/* stilurile pentru butonul de login */
#Button1 {
  background-color: #5f98f3;
  color: white;
  border-radius: 5px;
  padding: 10px;
  font-size: 16px;
}
.big_size{
    font-size: large;
    font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif
}

/* stilurile pentru inputurile de text */
input[type="text"],
input[type="password"],
input[type="email"] {
  padding: 10px;
  font-size: 16px;
  border-radius: 5px;
  border: 2px solid #ccc;
  width: 100%;
  box-sizing: border-box;
  margin-bottom: 10px;
}

/* stilurile pentru eticheta de eroare */
#errorLabel {
  color: red;
  font-weight: bold;
  font-size: 16px;
}
table {
  background-color: white;
  margin-top: 50px;
  margin-bottom: 50px;
  margin-left: auto;
  margin-right: auto;
  border-collapse: separate;
  border-spacing: 10px 15px;
  border-radius: 10px;
}

    </style>
</head>
<body style="background-image: url('Images/login_bg.jpg'); height: 100vh; width: 100vw; background-position: center center;">
    <form id="form1" runat="server">
        <div>

            <table class="auto-style1" align="center" >
                <tr>
                    <td colspan="2" align="center">
                        <f2 class="big_size">Login Page</f2>
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
                    <td colspan="2" id="last_td">
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>