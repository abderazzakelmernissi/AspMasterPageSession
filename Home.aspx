<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="AspMasterPageSession.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
</p>
<p>
    &nbsp;</p>
<p>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
</p>
</asp:Content>
