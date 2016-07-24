<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DebuggingExercise._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Debugging</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Enter a number below to produce the factorial.<br />
        <asp:TextBox ID="txtInputValue" runat="server"></asp:TextBox>
        <br />
    <asp:Label ID="lblDisplay" runat="server"></asp:Label>
    </div>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    </form>
</body>
</html>
