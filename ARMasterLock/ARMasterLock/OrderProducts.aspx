<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderProducts.aspx.cs" Inherits="ARMasterLock.OrderProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Place Your Order</h1>
    <asp:GridView ID="grdProduct" runat="server" AutoGenerateColumns="False">
            
            <Columns>
                <asp:BoundField HeaderText="ID" DataField="productId" />
                <asp:BoundField HeaderText="Description" DataField="productDetail" />
                <asp:BoundField HeaderText="Name" DataField="productName" />
                <asp:BoundField HeaderText="Type" DataField="productType" />
                <asp:BoundField HeaderText="Model Number" DataField="productMdlNum" />
                
                <asp:ImageField HeaderText="Image" DataImageUrlField="prodPic" DataImageUrlFormatString="~\images\{0}"  >
                </asp:ImageField>
                <asp:BoundField HeaderText="Price" DataField="productPrice" />
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
</asp:Content>
