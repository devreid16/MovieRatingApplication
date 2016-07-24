<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReviewOrder.aspx.cs" Inherits="ARMasterLock.ReviewOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Review Your Order:
    </h1>
    
    <div>
        <asp:GridView ID="GridOrders" runat="server" AutoGenerateColumns="False">
             <columns>
                <asp:BoundField HeaderText="Order ID" DataField="orderId" />
                <asp:BoundField HeaderText="Date" DataField="orderDate" />
                <asp:BoundField HeaderText="Customer ID" DataField="customerId" />
                <asp:BoundField HeaderText="Order Total" DataField="orderTotal" />         

             </columns>
        </asp:GridView>
           
        <br />
        <asp:Label ID="lblOutput" runat="server" Text="Your Order Info. "></asp:Label>
        
        
    </div>
   
</asp:Content>
