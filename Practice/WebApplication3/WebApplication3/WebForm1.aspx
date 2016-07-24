<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Lock No. 3</asp:ListItem>
            <asp:ListItem>Lock No. 5</asp:ListItem>
            <asp:ListItem>Lock No. 7</asp:ListItem>
        </asp:DropDownList>

        <div style="margin-left: 160px">
&nbsp;&nbsp;&nbsp;
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" Width="135px" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
                <asp:ListItem Value="Lock No. 3">Lock No. 3</asp:ListItem>
                <asp:ListItem Value="Lock No. 5">Lock No. 5</asp:ListItem>
                <asp:ListItem Value="Lock No. 7">Lock No. 7</asp:ListItem>
            </asp:CheckBoxList>
            <br />
        </div>
        <br />

        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Submit" />

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <div style="margin-left: 120px">
    

        <br />

        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    

    </div>
    </form>
</body>
</html>
