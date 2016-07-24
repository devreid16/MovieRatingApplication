<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderTickets.aspx.cs" Inherits="MasterSample.OrderTickets" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div>
     Sections:  <asp:ListBox ID="sections" runat="server"></asp:ListBox> <br/>
       Qty Tickets <asp:TextBox ID="qtyTickets" runat="server"></asp:TextBox> <br/>

    <asp:Button runat="server" ID="submit" Text="Submit" OnClick="submit_Click"/> <br/>
        <asp:Label ID="lblOutput" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
