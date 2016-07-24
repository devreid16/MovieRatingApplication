<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="_24200_ClassDemo.CreateAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
    <div>
       First Name:  <asp:TextBox ID="firstName" runat="server"></asp:TextBox> <br/>
        Last Name:  <asp:TextBox ID="lastName" runat="server"></asp:TextBox> <br/>
       User Name:   <asp:TextBox ID="userName" runat="server"></asp:TextBox> <br/><br />

      <asp:Button ID="btnCreateUser" runat="server" Text="Create User" OnClick="btnCreateUser_Click" />
    
    <asp:Menu ID="Menu1" runat="server">
        <Items>
            <asp:MenuItem NavigateUrl="~/OrderTickets.aspx" Text="Order Tickets" Value="Order Tickets"></asp:MenuItem>
        </Items>
    </asp:Menu>
        </div>
    </form>
    
    


</body>
</html>
    

