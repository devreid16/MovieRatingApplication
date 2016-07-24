<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="_24200_ClassDemo.CreateAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
    <div>
     <%--   <asp:Menu ID="mnuNavigation" runat="server">
            <Items>
                <asp:MenuItem NavigateUrl="~/CreateAccount.aspx" Text="Create Account" Value="Create Account"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/OrderTickets.aspx" Text="Order Tickets" Value="Order Tickets"></asp:MenuItem>
            </Items>
            
        </asp:Menu>--%>
        
        <asp:HyperLink ID="hlLink" runat="server" NavigateUrl="~/OrderTickets.aspx">Order tickets</asp:HyperLink>

      First Name:  <asp:TextBox ID="firstName" runat="server"></asp:TextBox> <br/>
        Last Name: <asp:TextBox ID="lastName" runat="server"></asp:TextBox> <br />
        User Name: <asp:TextBox ID="userName" runat="server"></asp:TextBox> <br />
        <asp:Button ID="btnCreateUser" runat="server" Text="Create User" OnClick="btnCreateUser_Click" /> <br/>
                <asp:Label ID="lblOutput" runat="server" Text=""></asp:Label>

    </div>
    </form>
</body>
</html>
