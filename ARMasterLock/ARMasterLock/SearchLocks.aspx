<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchLocks.aspx.cs" Inherits="ARMasterLock.SearchLocks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   
    <div> 
        <h1>Search Lock Products</h1>
<!--Search by Product Price Range Low and High Textbox, Button, and Grid -->
        <p style="border-bottom:solid black 1px;">
        
            Lowest Price: &nbsp; &nbsp;
        <asp:DropDownList ID="ddllowPrice" runat="server" AutoPostBack="True" 
            DataSourceID="SqlDataSource2" DataTextField="productPrice" DataValueField="productPrice" AppendDataBoundItems="True">
            <asp:ListItem>Select Low Range</asp:ListItem>
            </asp:DropDownList>    
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [productPrice] FROM [products] ORDER BY [productPrice] "></asp:SqlDataSource>
            
         Highest Price: &nbsp; &nbsp;  
            <asp:DropDownList ID="ddlhighPrice" runat="server" AutoPostBack="True" 
                DataSourceID="SqlDataSource3" DataTextField="productPrice" DataValueField="productPrice" AppendDataBoundItems="True">
             <asp:ListItem>Select High Range</asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [productPrice] FROM [products] ORDER BY [productPrice] DESC"></asp:SqlDataSource>
      
                    <asp:Button ID="Button1" runat="server" Text="Search by Price Range" onClick="btnsrcProductByPrice_Click"/><br />
        &nbsp; &nbsp;&nbsp; &nbsp;<br />
               
            <asp:GridView ID="GridView1" runat="server">                
            </asp:GridView>
      </p>


<!--Search by Product Textbox, Button, and Grid -->

      <p style="border-bottom:solid black 1px;">

        Search Product: &nbsp; <asp:TextBox ID="prodType" runat="server"></asp:TextBox>
         &nbsp; &nbsp;

        <asp:Button ID="Button2" runat="server" Text="Search By Product" onClick="btnsrcProductByType_Click"/><br />
        
        <br />
             
            <asp:GridView ID="GridView2" runat="server">                        
            </asp:GridView>
    </p>
              
    </div>
</asp:Content>
