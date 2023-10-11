<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="login2.aspx.cs" Inherits="AspMasterPageSession.login2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Login ID="Login1" runat="server" onauthenticate="Login1_Authenticate">
</asp:Login>
    <asp:Label ID="Label1" runat="server" Text="Veuillez ....."></asp:Label>
</asp:Content>
