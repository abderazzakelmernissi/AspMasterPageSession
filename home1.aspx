<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="home1.aspx.cs" Inherits="AspMasterPageSession.home1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
<asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Deconecter" />
<br/>
</asp:Content>
