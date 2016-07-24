<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductSearch.aspx.cs" Inherits="MasterSample.ProductSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Sample product search (showing all products)
        <asp:GridView ID="grdProducts" runat="server"  AutoGenerateSelectButton="True" OnSelectedIndexChanged="grdProducts_SelectedIndexChanged" 
      ></asp:GridView>
         <br/>
        Quantity:
        <asp:DropDownList ID="ddlQuantity" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
             
            </asp:DropDownList>
        <br/>
        
    </div>
    </form>
</body>
</html>
