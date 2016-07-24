<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_24200_ClassDemo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <div> 
        
     Sections:  <asp:ListBox ID="sections" runat="server"></asp:ListBox> <br/>
       Qty Tickets <asp:TextBox ID="qtyTickets" runat="server"></asp:TextBox> <br/>

    <asp:Button runat="server" ID="submit" Text="Submit" OnClick="submit_Click"/> <br/>
        <asp:Label ID="lblOutput" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
