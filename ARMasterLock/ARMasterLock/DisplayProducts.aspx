<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayProducts.aspx.cs" Inherits="ARMasterLock.DisplayProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Lock Products Available

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="productId" DataSourceID="SqlDataSource1" AllowPaging="True">
            <Columns>
                <asp:BoundField DataField="productId" HeaderText="productId" InsertVisible="False" ReadOnly="True" SortExpression="productId" />
                <asp:BoundField DataField="productName" HeaderText="productName" SortExpression="productName" />
                <asp:BoundField DataField="productType" HeaderText="productType" SortExpression="productType" />
                <asp:BoundField DataField="productMdlNum" HeaderText="productMdlNum" SortExpression="productMdlNum" />
                <asp:BoundField DataField="productlkopt" HeaderText="productlkopt" SortExpression="productlkopt" />
                <asp:BoundField DataField="productPrice" HeaderText="productPrice" SortExpression="productPrice" />
                <asp:BoundField DataField="productDetail" HeaderText="productDetail" SortExpression="productDetail" />
                <asp:BoundField DataField="productSize" HeaderText="productSize" SortExpression="productSize" />
                <asp:BoundField DataField="productWeight" HeaderText="productWeight" SortExpression="productWeight" />
                <asp:BoundField DataField="productImage" HeaderText="productImage" SortExpression="productImage" />
                
            </Columns>
        </asp:GridView>

        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" DataKeyNames="productId" DataSourceID="SqlDataSource1">
            <EditItemTemplate>
                productId:
                <asp:Label ID="productIdLabel1" runat="server" Text='<%# Eval("productId") %>' />
                <br />
                productName:
                <asp:TextBox ID="productNameTextBox" runat="server" Text='<%# Bind("productName") %>' />
                <br />
                productType:
                <asp:TextBox ID="productTypeTextBox" runat="server" Text='<%# Bind("productType") %>' />
                <br />
                productMdlNum:
                <asp:TextBox ID="productMdlNumTextBox" runat="server" Text='<%# Bind("productMdlNum") %>' />
                <br />
                productlkopt:
                <asp:TextBox ID="productlkoptTextBox" runat="server" Text='<%# Bind("productlkopt") %>' />
                <br />
                productPrice:
                <asp:TextBox ID="productPriceTextBox" runat="server" Text='<%# Bind("productPrice") %>' />
                <br />
                productDetail:
                <asp:TextBox ID="productDetailTextBox" runat="server" Text='<%# Bind("productDetail") %>' />
                <br />
                productSize:
                <asp:TextBox ID="productSizeTextBox" runat="server" Text='<%# Bind("productSize") %>' />
                <br />
                productWeight:
                <asp:TextBox ID="productWeightTextBox" runat="server" Text='<%# Bind("productWeight") %>' />
                <br />
                imageName:
                <asp:TextBox ID="imageNameTextBox" runat="server" Text='<%# Bind("imageName") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <InsertItemTemplate>
                productName:
                <asp:TextBox ID="productNameTextBox" runat="server" Text='<%# Bind("productName") %>' />
                <br />
                productType:
                <asp:TextBox ID="productTypeTextBox" runat="server" Text='<%# Bind("productType") %>' />
                <br />
                productMdlNum:
                <asp:TextBox ID="productMdlNumTextBox" runat="server" Text='<%# Bind("productMdlNum") %>' />
                <br />
                productlkopt:
                <asp:TextBox ID="productlkoptTextBox" runat="server" Text='<%# Bind("productlkopt") %>' />
                <br />
                productPrice:
                <asp:TextBox ID="productPriceTextBox" runat="server" Text='<%# Bind("productPrice") %>' />
                <br />
                productDetail:
                <asp:TextBox ID="productDetailTextBox" runat="server" Text='<%# Bind("productDetail") %>' />
                <br />
                productSize:
                <asp:TextBox ID="productSizeTextBox" runat="server" Text='<%# Bind("productSize") %>' />
                <br />
                productWeight:
                <asp:TextBox ID="productWeightTextBox" runat="server" Text='<%# Bind("productWeight") %>' />
                <br />
                imageName:
                <asp:TextBox ID="imageNameTextBox" runat="server" Text='<%# Bind("imageName") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                productId:
                <asp:Label ID="productIdLabel" runat="server" Text='<%# Eval("productId") %>' />
                <br />
                productName:
                <asp:Label ID="productNameLabel" runat="server" Text='<%# Bind("productName") %>' />
                <br />
                productType:
                <asp:Label ID="productTypeLabel" runat="server" Text='<%# Bind("productType") %>' />
                <br />
                productMdlNum:
                <asp:Label ID="productMdlNumLabel" runat="server" Text='<%# Bind("productMdlNum") %>' />
                <br />
                productlkopt:
                <asp:Label ID="productlkoptLabel" runat="server" Text='<%# Bind("productlkopt") %>' />
                <br />
                productPrice:
                <asp:Label ID="productPriceLabel" runat="server" Text='<%# Bind("productPrice") %>' />
                <br />
                productDetail:
                <asp:Label ID="productDetailLabel" runat="server" Text='<%# Bind("productDetail") %>' />
                <br />
                productSize:
                <asp:Label ID="productSizeLabel" runat="server" Text='<%# Bind("productSize") %>' />
                <br />
                productWeight:
                <asp:Label ID="productWeightLabel" runat="server" Text='<%# Bind("productWeight") %>' />
                <br />
                imageName:
                <asp:Label ID="imageNameLabel" runat="server" Text='<%# Bind("imageName") %>' />
                <br />

            </ItemTemplate>
        </asp:FormView>
         
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [products]"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
