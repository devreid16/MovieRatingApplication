<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="chgPassword.aspx.cs" Inherits="ARMasterLock.chgPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Enter your new password</h1>

    <asp:Label ID="lbloldPassword" runat="server" Text="Current Password:"></asp:Label>&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;
    <asp:TextBox ID="currPassword" runat="server" TextMode="Password"></asp:TextBox><br />

    <asp:Label ID="lblnewPassword" runat="server" Text="New Password:"></asp:Label>&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="newPassword" runat="server" TextMode="Password"></asp:TextBox><br />
    
    <asp:Label ID="lblconfirmPassword" runat="server" Text="Confirm New Password:"></asp:Label>&nbsp; &nbsp;
    <asp:TextBox ID="confPassword" runat="server" TextMode="Password"></asp:TextBox><br />
    <br />
     <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" /><br />

     <asp:Label ID="lblOutput1" runat="server" Text=""></asp:Label><br />

    <asp:CompareValidator ID="CompareValidator1" runat="server" 
       ErrorMessage="Your Passwords Don't Match" ControlToCompare="newPassword" ControlToValidate="confPassword" CssClass="ErrorMessage"></asp:CompareValidator>
    <asp:RequiredFieldValidator ID="oldPassword" runat="server" ErrorMessage="Please Enter Your Old Password" ControlToValidate="currPassword" CssClass="ErrorMessage"></asp:RequiredFieldValidator>
        
    <asp:RequiredFieldValidator ID="nPassword" runat="server" ErrorMessage="Please Enter Your New Password" ControlToValidate="newPassword" CssClass="ErrorMessage"></asp:RequiredFieldValidator>
        
    <asp:RequiredFieldValidator ID="cPassword" runat="server" ErrorMessage="Please ReEnter Your New Password" ControlToValidate="confPassword" CssClass="ErrorMessage"></asp:RequiredFieldValidator>
    
    <asp:TextBox ID="uName" runat="server" Visible="False"></asp:TextBox>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    
   
</asp:Content>
