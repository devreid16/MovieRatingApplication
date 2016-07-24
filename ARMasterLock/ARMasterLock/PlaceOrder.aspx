<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlaceOrder.aspx.cs" Inherits="ARMasterLock.reviewOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    Click below to place your order 
        <br/>
        <asp:GridView ID="grdCartContents" runat="server"></asp:GridView>
        
        <br/>
        

        <asp:Button ID="btnPlaceOrder" Text="Place Order" runat="server" OnClick="btnPlaceOrder_Click"/>
        
        
        <br/>
        <br/>
        <asp:Label ID="lblMessage" Text="" runat="server"></asp:Label>
    
</asp:Content>
