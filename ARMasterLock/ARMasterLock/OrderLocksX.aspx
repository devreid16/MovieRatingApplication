<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderLocksX.aspx.cs" Inherits="ARMasterLock.OrderLocks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
        <div>
            
        <h1 aria-autocomplete="none">Order Form</h1>
        Lock Selection: <asp:ListBox ID="lkType" runat="server" DataSourceID="SqlDataSource1" DataTextField="productMdlNum"></asp:ListBox>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [productMdlNum] FROM [products]"></asp:SqlDataSource>
        <br /> <br />
            <asp:RequiredFieldValidator ID="lkNum" runat="server" ErrorMessage="Please Select Lock " ControlToValidate="lkType" CssClass="ErrorMessage" ForeColor="Red">*</asp:RequiredFieldValidator>
        Quantity: <asp:TextBox ID="qtyItem" runat="server" style="margin-bottom: 0px">
                  </asp:TextBox>
            <asp:RequiredFieldValidator ID="itmQty" runat="server" ErrorMessage="Please Enter the Quantity" ControlToValidate="qtyItem" CssClass="ErrorMessage" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="btnPurchase1" runat="server"  OnClick="btnPurchase_Click1" Text="Order Item" />
        <br />
            <asp:Button ID="btnPurchase2" runat="server"  OnClick="btnPurchase_Click2" Text="Complete Order" />
        <br />
        <br />
        
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    </div>
    
</asp:Content>
