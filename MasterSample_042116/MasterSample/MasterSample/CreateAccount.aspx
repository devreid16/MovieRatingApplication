﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="MasterSample.CreateAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <div>
     <%--   <asp:Menu ID="mnuNavigation" runat="server">
            <Items>
                <asp:MenuItem NavigateUrl="~/CreateAccount.aspx" Text="Create Account" Value="Create Account"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/OrderTickets.aspx" Text="Order Tickets" Value="Order Tickets"></asp:MenuItem>
            </Items>
            
        </asp:Menu>--%>
        
         

      First Name:  <asp:TextBox ID="firstName" runat="server"></asp:TextBox> <br/>
        Last Name: <asp:TextBox ID="lastName" runat="server"></asp:TextBox> <br />
        Address: <asp:TextBox ID="address" runat="server"></asp:TextBox> <br />
        City: <asp:TextBox ID="city" runat="server"></asp:TextBox> <br />
        State: <asp:TextBox ID="state" runat="server"></asp:TextBox> <br />
        Zip: <asp:TextBox ID="zip" runat="server"></asp:TextBox> <br />
        Phone: <asp:TextBox ID="phone" runat="server"></asp:TextBox> 
<%--     <asp:RegularExpressionValidator ID="PhoneValidator" runat="server"  ErrorMessage="Phone is required with area code" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>--%>
     <br />
        Email: <asp:TextBox ID="email" runat="server"></asp:TextBox> <br />
        Email: <asp:TextBox ID="email2" runat="server"></asp:TextBox> 
     <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="email2" ControlToValidate="email" ErrorMessage="Email must match"></asp:CompareValidator>
     <br />
        User Name: <asp:TextBox ID="userName" runat="server"></asp:TextBox>  <br/>
        Password: <asp:TextBox ID="password" runat="server"></asp:TextBox> 
<%--     <asp:RequiredFieldValidator ID="firstNameValidator" runat="server"  ErrorMessage="First Name is required" ForeColor="Red"></asp:RequiredFieldValidator>--%>
     <br />
        <asp:Button ID="btnCreateUser" runat="server" Text="Create User" OnClick="btnCreateUser_Click" /> 
      
     <br/>
                <asp:Label ID="lblOutput" runat="server" Text=""></asp:Label>

    </div>
</asp:Content>
