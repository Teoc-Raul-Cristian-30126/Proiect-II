<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Magazin.Default1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>

    </table>
    <asp:DataList ID="DataList1" runat="server" DataKeyField="ProductId" DataSourceID="SqlDataSource1" Height="290px" Width="310px">
        <ItemTemplate>
            ProductId:
            <asp:Label ID="ProductIdLabel" runat="server" Text='<%# Eval("ProductId") %>' />
            <br />
            Pname:
            <asp:Label ID="PnameLabel" runat="server" Text='<%# Eval("Pname") %>' />
            <br />
            Pimage:
            <asp:Label ID="PimageLabel" runat="server" Text='<%# Eval("Pimage") %>' />
            <br />
            Pprice:
            <asp:Label ID="PpriceLabel" runat="server" Text='<%# Eval("Pprice") %>' />
            <br />
            <br />
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [ProductId], [Pname], [Pimage], [Pprice] FROM [Product1]">

    </asp:SqlDataSource>
</asp:Content>
