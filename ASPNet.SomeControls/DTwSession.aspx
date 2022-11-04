<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DTwSession.aspx.cs" Inherits="ASPNet.SomeControls.DTwSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>.: ASP.NET Some Controls - Data Transfer Between Pages with Cookies :.</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <b>Value1 :</b>&nbsp;<asp:TextBox ID="tboxValue1" runat="server"></asp:TextBox>
            <br />
            <br />
            <b>Value2 :</b>&nbsp;<asp:TextBox ID="tboxValue2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btonTestPage" Text="Session Test Page" runat="server" OnClientClick="window.document.forms[0].target='_blank';" OnClick="btonTestPage_Click"/>
        </div>
    </form>
</body>
</html>
