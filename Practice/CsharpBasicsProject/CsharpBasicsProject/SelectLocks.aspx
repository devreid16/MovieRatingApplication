<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectLocks.aspx.cs" Inherits="CsharpBasicsProject.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Master Lock Inventory</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

       <h1>Order Form</h1>
       
       First Name: <asp:TextBox ID="FName" runat="server"></asp:TextBox> <br />
       Last Name:  <asp:TextBox ID="LName" runat="server"></asp:TextBox> <br />

       Locks:     <asp:ListBox ID="lkType" runat="server" > 
                  </asp:ListBox> <br />

       Price:     <asp:TextBox ID="lkPrice" runat="server" ReadOnly="True" value=""></asp:TextBox> <br />
       Quantity:  <asp:TextBox ID="qtyItem" runat="server"></asp:TextBox> <br />

        <asp:Label ID="selLock" runat="server" Text="Lock Selection"></asp:Label> <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <br />

        <asp:Button runat="server" ID="submit" Text="Submit" OnClick="submit_Click" Height="72px" Width="169px"/> <br />
        
        
       
    </div>
    </form>
</body>
</html>
