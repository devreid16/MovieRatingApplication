<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="csbasics.CreateAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Master Lock</title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:Menu ID="mnuNavigation" runat="server">
            <Items>
                <asp:MenuItem NavigateUrl="~/CreateAccount.aspx" Text="Create Account" 
                    Value="Create Account"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/OrderLocks.aspx" Text="Order Locks" 
                    Value="Order Locks"></asp:MenuItem>
            </Items>
            
        </asp:Menu>
    <div>
    <h1>Create Your User Account</h1>
    <p style="border-bottom-style:solid">
        <asp:Label ID="lblFname" runat="server" Text="First Name: "></asp:Label> 
        <asp:TextBox ID="fName" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Your Name" ControlToValidate="lName">Enter Your Name</asp:RequiredFieldValidator>

        <asp:Label ID="lblLname" runat="server" Text="Last Name: "></asp:Label>    
        <asp:TextBox ID="lName" runat="server"></asp:TextBox><br />

        <asp:Label ID="lblUserName" runat="server" Text="User Name: "></asp:Label>
        <asp:TextBox ID="userName" runat="server"></asp:TextBox><br /><br />

        <asp:Button ID="btnCreateUser" runat="server" Text="Create Username" 
            OnClick="btnCreateUser_Click" /><br /><br />
                <asp:Label ID="lblOutput" runat="server" Text=""></asp:Label><br />
        <br />
       </p>
    </div>
    </form>
</body>
</html>
