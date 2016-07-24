<%@Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoginView.aspx.cs" Inherits="ARMasterLock.LoginView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Login in to AR MasterLock</h1>
    <p>
        <asp:Login ID="Login1" runat="server"  FailureText="There was an error logging in, please try again."
                 OnAuthenticate="lgnView_Authenticate">
               <FailureTextStyle ForeColor="Red" />
        </asp:Login>

       <asp:Button ID="ChgPw" runat="server" Text="Change Password"  OnClick="Password_Chg" /> 
        <asp:Button ID="viewPro" runat="server" Text="View Profile" OnClick="Profile_View" />
       
    </p>

    </asp:Content>

