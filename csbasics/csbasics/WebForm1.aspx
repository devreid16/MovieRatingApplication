<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="csbasics.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

    <h1>Master Lock Order Inventory</h1>

        <asp:Label ID="lblFname" runat="server" Text="First Name: "></asp:Label>     
        <asp:TextBox ID="fName" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblLname" runat="server" Text="Last Name: "></asp:Label>    
        <asp:TextBox ID="lName" runat="server"></asp:TextBox>
        <br />
        <br />
        Lock Selection: <asp:ListBox ID="lkType" runat="server"></asp:ListBox>
        <br />

        <br />
        Quantity: <asp:TextBox ID="qtyItem" runat="server" OnTextChanged="TextBox1_TextChanged" style="margin-bottom: 0px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server"  OnClick="submit_Click" Text="Submit" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Order Info:"></asp:Label>

    
    </div>
    </form>
</body>
</html>
