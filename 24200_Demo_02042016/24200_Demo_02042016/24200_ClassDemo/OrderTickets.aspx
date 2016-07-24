<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderTickets.aspx.cs" Inherits="_24200_ClassDemo.OrderTickets" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Menu ID="mnuNavigation" runat="server">
            <Items>
                <asp:MenuItem NavigateUrl="~/CreateAccount.aspx" Text="Create Account" Value="Create Account"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/OrderTickets.aspx" Text="Order Tickets" Value="Order Tickets"></asp:MenuItem>
            </Items>
            
        </asp:Menu>
    <div>
     Sections:  <asp:ListBox ID="sections" runat="server"></asp:ListBox> <br/>
       Qty Tickets <asp:TextBox ID="qtyTickets" runat="server"></asp:TextBox> <br/>

    <asp:Button runat="server" ID="submit" Text="Submit" OnClick="submit_Click"/> <br/>
        <asp:Label ID="lblOutput" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
