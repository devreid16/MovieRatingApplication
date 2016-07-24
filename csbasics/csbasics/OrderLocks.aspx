<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderLocks.aspx.cs" Inherits="csbasics.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

            <asp:Menu ID="MnuNavigation" runat="server" StaticSubMenuIndent="16px">
                <Items>
                    <asp:MenuItem NavigateUrl="~/CreateAccount.aspx" Text="Create Account" 
                        Value="Create Account"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/OrderLocks.aspx" Text="Order Locks" 
                        Value="Order Locks"></asp:MenuItem>
                </Items>
            </asp:Menu>
            
        <div>
            
        <h1>Order Form</h1>
        Lock Selection: <asp:ListBox ID="lkType" runat="server"></asp:ListBox>
        <br /> <br />
        Quantity: <asp:TextBox ID="qtyItem" runat="server" style="margin-bottom: 0px">
                  </asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server"  OnClick="submit_Click" Text="Submit" />
        <br />
        <br />
        <asp:Label ID="lblOutput" runat="server" Text="Order Info: "></asp:Label>
    
    </div>
    </form>
</body>
</html>
