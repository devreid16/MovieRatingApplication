<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication2._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      First Name: <asp:TextBox ID="firstName" runat="server"></asp:TextBox>

      Last Name: <asp:TextBox ID="lastName" runat="server"></asp:TextBox>

      Sections:  <asp:ListBox ID="sections" runat="server"></asp:ListBox>

      <asp:Button ID="submit" runat="server" OnClick="Submit" Text="Submit" />

      <asp:Label ID="Submit" runat="server" Text="submitButton"></asp:Label>

    </div>

    </form>
</body>
</html>
