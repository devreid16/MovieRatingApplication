<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MasterSample.Loginaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Login</h2>
    <asp:Login ID="lgnView" runat="server" OnAuthenticate="lgnView_Authenticate"></asp:Login>
</asp:Content>
