<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Magazin.Default1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>

    </table>
    <asp:DataList ID="DataList1" runat="server" DataKeyField="ProductId" DataSourceID="SqlDataSource1" Height="290px" Width="310px" RepeatColumns="3" RepeatDirection="Horizontal" align="center" >
        <ItemTemplate>
            <table>
                <tr>
                    <td style="text-align:center; background-color:lightblue">
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Pname") %>' Font-Bold="True" Font-Names="Arial"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="text-align:center">
                        <asp:Image ID="Image1" runat="server" BorderColor="#0099CC" BorderWidth="1px" Height="280px" Width="280px" 
                            ImageUrl='<%# Eval("Pimage") %>'/>
                    </td>
                </tr>
                <tr>
                    <td style="text-align:center; background-color:lightblue">
                        <asp:Label ID="Label2" runat="server" Text="Price: " Font-Bold="True" Font-Names="Arial" ForeColor="White"
                            style="text-align:center"></asp:Label>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("Pprice") %>' Font-Bold="True" Font-Names="Arial" ForeColor="White"
                            style="text-align:center"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center">Quantity
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td style="text-align:center">
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="40px" ImageUrl="~/Images/add_to_cart.jpg" 
                            CommandArgument='<%# Eval("ProductId") %>' CommandName="AddToCart"/>
                    </td>
                </tr>
            </table>
            <br />
            <br />
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [ProductId], [Pname], [Pimage], [Pprice] FROM [Product1]">

    </asp:SqlDataSource>
</asp:Content>
