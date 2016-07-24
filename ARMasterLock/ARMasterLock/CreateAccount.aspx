<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="ARMasterLock.CreateAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>

        <h1>Please Create Your User Account</h1>
    <p style="border-bottom-style:solid">
       First Name: <asp:TextBox ID="fName" runat="server"></asp:TextBox>&nbsp &nbsp &nbsp
        <asp:RequiredFieldValidator ID="first" runat="server" ErrorMessage="Please Enter First Name" ControlToValidate="fName" CssClass="ErrorMessage" Text="*">*</asp:RequiredFieldValidator>
       
        Last Name: <asp:TextBox ID="lName" runat="server"></asp:TextBox><br />
        <asp:RequiredFieldValidator ID="last" runat="server" ErrorMessage="Please Enter Last Name" CssClass="ErrorMessage" ControlToValidate="lName" ForeColor="Red">*</asp:RequiredFieldValidator>
       
        Address:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="address" runat="server" MaxLength="50"></asp:TextBox>&nbsp &nbsp &nbsp&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="address1" runat="server" ErrorMessage="Please Enter Street Address" ControlToValidate="address" CssClass="ErrorMessage" Text="*">*</asp:RequiredFieldValidator>
       
        City:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="city" runat="server" MaxLength="30"></asp:TextBox>&nbsp &nbsp &nbsp
        <asp:RequiredFieldValidator ID="city1" runat="server" ErrorMessage="Please Enter Your City" ControlToValidate="city" CssClass="ErrorMessage" Text="*">*</asp:RequiredFieldValidator>
       
        State: <asp:DropDownList ID="ddlStateList" runat="server" 
            AppendDataBoundItems="True" DataSourceID="SqlDataSource1" 
            DataTextField="StateAbbrev" DataValueField="StateAbbrev" AutoPostBack="True">
            <asp:ListItem Value="">Select State</asp:ListItem>             </asp:DropDownList>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT [StateAbbrev] FROM [StateLookup1]"></asp:SqlDataSource>
        &nbsp &nbsp
        
        
         Zip: <asp:TextBox ID="zipCode" runat="server" MaxLength="10"></asp:TextBox><br />
        <asp:RequiredFieldValidator ID="reqZip" runat="server" ErrorMessage="Please Enter Your Full Zip Code" ControlToValidate="zipCode" CssClass="ErrorMessage" Text="*">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="zipPlus" runat="server" ErrorMessage="Please Enter Valid Zip Code" ControlToValidate="zipCode" CssClass="ErrorMessage" ValidationExpression="\d{5}(-\d{4})?">*</asp:RegularExpressionValidator>
      
         Phone:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="phone" runat="server"></asp:TextBox>&nbsp &nbsp &nbsp
        <asp:RequiredFieldValidator ID="reqPhone" runat="server" ErrorMessage="Please Enter Your Phone Number" ControlToValidate="phone" CssClass="ErrorMessage" Text="*">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="phone1" runat="server" ErrorMessage="Please Enter Valid Phone Number" ControlToValidate="phone" CssClass="ErrorMessage" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}" Text="*">*</asp:RegularExpressionValidator>
      
         Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="email" runat="server"></asp:TextBox><br /><br />
        <asp:RequiredFieldValidator ID="reqEmail" runat="server" ErrorMessage="Please Enter Your Email Address" ControlToValidate="email" CssClass="ErrorMessage" Text="*">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="email1" runat="server" ErrorMessage="Enter Valid Email Address" ControlToValidate="email" CssClass="ErrorMessage" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Text="*">*</asp:RegularExpressionValidator>
        
       User Name: <asp:TextBox ID="userName" runat="server"></asp:TextBox><br /><br />
        <asp:RequiredFieldValidator ID="uname" runat="server" ErrorMessage="Please enter a username" ControlToValidate="userName" CssClass="ErrorMessage">*</asp:RequiredFieldValidator>

        Password: <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox><br /><br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter your passwowrd" ControlToValidate="password" CssClass="ErrorMessage">*</asp:RequiredFieldValidator>
        
        <asp:TextBox ID="customerId" runat="server" Visible="False"></asp:TextBox>

        <asp:Button ID="btnCreateUser" runat="server" Text="Create Username" 
            OnClick="btnCreateUser_Click" /><br /><br />
                <asp:Label ID="lblOutput" runat="server" Text=""></asp:Label><br />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="ErrorMessage" />


    </div>
</asp:Content>
