<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_24200_ClassDemo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       First Name:  <asp:TextBox ID="firstName" runat="server"></asp:TextBox> <br/>
        Last Name: <asp:TextBox ID="lastName" runat="server"></asp:TextBox> <br />
        User Name: <asp:TextBox ID="userName" runat="server"></asp:TextBox> <br />
        <asp:Button ID="btnCreateUser" runat="server" Text="Create User" OnClick="btnCreateUser_Click" /> <br/>
        <br/>
        <hr/>
     Sections:  <asp:ListBox ID="sections" runat="server"></asp:ListBox> <br/>
       Qty Tickets <asp:TextBox ID="qtyTickets" runat="server"></asp:TextBox> <br/>

    <asp:Button runat="server" ID="submit" Text="Submit" OnClick="submit_Click"/> <br/>
        <asp:Label ID="lblOutput" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
