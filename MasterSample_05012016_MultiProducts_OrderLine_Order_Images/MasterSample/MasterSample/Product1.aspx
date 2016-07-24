<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product1.aspx.cs" Inherits="MasterSample.Product1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Sample Page for ordering a product
        <br/>
        Click the button to order a product in the grid
        <asp:GridView ID="grdProduct" runat="server" AutoGenerateColumns="False">
            
            <Columns>
                <asp:BoundField HeaderText="ID" DataField="Id" />
                <asp:BoundField HeaderText="Description" DataField="Description" />
                <asp:BoundField HeaderText="Size" DataField="Size" />
                <asp:BoundField HeaderText="Type" DataField="Type" />
                <asp:BoundField HeaderText="Model Number" DataField="ModelNumber" />
                
                <asp:ImageField HeaderText="Image" DataImageUrlField="Image" DataImageUrlFormatString="~\Images\{0}"  >
                </asp:ImageField>
                <asp:BoundField HeaderText="Price" DataField="Price" />
            </Columns>
            
        </asp:GridView>
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
        
        <asp:Button ID="btnSubmit" Text="Add to Cart" runat="server" OnClick="btnSubmit_Click"/>
    </div>
    </form>
</body>
</html>
