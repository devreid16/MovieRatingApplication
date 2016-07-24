<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlaceOrder.aspx.cs" Inherits="MasterSample.PlaceOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Click below to place your order 
        <br/>
        <asp:GridView ID="grdCartContents" runat="server"></asp:GridView>
        
        <br/>
        

        <asp:Button ID="btnPlaceOrder" Text="Place Order" runat="server" OnClick="btnPlaceOrder_Click"/>
        
        
        <br/>
        <br/>
        <asp:Label ID="lblMessage" Text="" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
