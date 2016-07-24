<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="ARMasterLock.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>

        <h1>Please Update Your Profile</h1>
    <p style="border-bottom-style:solid">

        <asp:TextBox ID="userName" runat="server" Visible="False"></asp:TextBox><br />
       First Name: <asp:TextBox ID="fName" runat="server"></asp:TextBox>&nbsp &nbsp &nbsp
        <asp:RequiredFieldValidator ID="first" runat="server" ErrorMessage="Please Enter First Name" 
            ControlToValidate="fName" CssClass="ErrorMessage" Text="*">*</asp:RequiredFieldValidator>
       
        Last Name: <asp:TextBox ID="lName" runat="server"></asp:TextBox><br />
        <asp:RequiredFieldValidator ID="last" runat="server" ErrorMessage="Please Enter Last Name" 
            CssClass="ErrorMessage" ControlToValidate="lName" ForeColor="Red">*</asp:RequiredFieldValidator>
       
        Address:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="address" runat="server" MaxLength="50">
         </asp:TextBox>&nbsp &nbsp &nbsp&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="address1" runat="server" ErrorMessage="Please Enter Street Address" 
            ControlToValidate="address" CssClass="ErrorMessage" Text="*">*</asp:RequiredFieldValidator>
       
        City:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="city" runat="server" 
            MaxLength="30"></asp:TextBox>&nbsp &nbsp &nbsp
        <asp:RequiredFieldValidator ID="city1" runat="server" ErrorMessage="Please Enter Your City" 
            ControlToValidate="city" CssClass="ErrorMessage" Text="*">*</asp:RequiredFieldValidator>
       
        State:     <asp:TextBox ID="state" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="state1" runat="server" 
            ErrorMessage="Please Enter The State." ControlToValidate="state" 
            CssClass="ErrorMessage" Text="*">*</asp:RequiredFieldValidator>
        
         Zip: <asp:TextBox ID="zipCode" runat="server" MaxLength="10"></asp:TextBox><br />
        <asp:RequiredFieldValidator ID="reqZip" runat="server" ErrorMessage="Please Enter Your Full Zip Code" 
            ControlToValidate="zipCode" CssClass="ErrorMessage" Text="*">*</asp:RequiredFieldValidator>        
      
         Phone:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="phone" runat="server">
         </asp:TextBox>&nbsp &nbsp &nbsp
        <asp:RequiredFieldValidator ID="reqPhone" runat="server" 
            ErrorMessage="Please Enter Your Phone Number" ControlToValidate="phone" 
            CssClass="ErrorMessage" Text="*">*</asp:RequiredFieldValidator>        
      
         Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="email" runat="server"></asp:TextBox>
        <br /><br />
        <asp:RequiredFieldValidator ID="reqEmail" runat="server" ErrorMessage="Please Enter Your Email Address" 
            ControlToValidate="email" CssClass="ErrorMessage" Text="*">*</asp:RequiredFieldValidator>
        
        <asp:TextBox ID="customerId" runat="server" Visible="False"></asp:TextBox>
                            
        <asp:Button ID="btnUpdateUser" runat="server" Text="Update User" 
            OnClick="btnUpdateUser_Click" /><br /><br />
                <asp:Label ID="lblOutput" runat="server" Text=""></asp:Label><br />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="ErrorMessage" />


    </div>
</asp:Content>
