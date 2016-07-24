<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="States.aspx.cs" Inherits="MasterSample.States" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="ddlStates" runat="server" DataTextField="StateAbbrev" DataValueField="StateAbbrev"></asp:DropDownList>
       <br/><br/> <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/knob.jpg"  /></div>
    </form>
</body>
</html>
