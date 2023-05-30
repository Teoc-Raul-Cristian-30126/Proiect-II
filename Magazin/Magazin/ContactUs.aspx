<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="Magazin.ContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Contact Us</title>
    <!-- Adăugați stiluri CSS sau alte fișiere externe aici -->
     <style>
        body {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            flex-direction: column;
        }
        .contact-us {
            margin-bottom: 20px;
        }
        form {
            width: 400px;
            padding: 20px;
            background-color: #f2f2f2;
            border-radius: 5px;
        }
        h1 {
            text-align: center;
        }
        label {
            display: block;
            margin-top: 10px;
        }
        input[type="text"],
        textarea {
            width: 100%;
            padding: 5px;
        }
        button {
            margin-top: 10px;
            padding: 5px 10px;
        }
    </style>
</head>
  <body style="background-image: url('Images/login_bg.jpg'); background-repeat: no-repeat; background-position: center top; background-size: cover;">
    <h1>Contact Us</h1>
    <form runat="server">
        <label for="name">Name:</label>
        <asp:TextBox ID="name" runat="server" required></asp:TextBox>
        <br>
        <label for="email">Email:</label>
        <asp:TextBox ID="email" runat="server" required></asp:TextBox>
        <br>
        <label for="message">Message:</label>
        <asp:TextBox ID="message" runat="server" TextMode="MultiLine" Rows="4" required></asp:TextBox>
        <br>
        <asp:Button ID="btnSubmit" runat="server" Text="Send" OnClick="btnSubmit_Click" />
    </form>
</body>
</html>