<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DTwCookie.aspx.cs" Inherits="ASPNet.SomeControls.DTwCookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>.: ASP.NET Some Controls - Data Transfer Between Pages with Cookies :.</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <b>Cookie Value :</b>&nbsp;<asp:TextBox ID="tboxValue" runat="server" Width="200px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btonCreateCookie" Text="Create Cookies" runat="server" OnClick="btonCreateCookie_Click" Width="130px" />
            <br />
            <br />
            <asp:Label ID="lbelMessage" runat="server"></asp:Label>
            <br />
            <br />
            <div class="component">
                <asp:LinkButton ID="lnkbDTwTestCookie" runat="server" CssClass="button" OnClick="lnkbDTwTestCookie_Click" OnClientClick="window.document.forms[0].target='_blank';">Cookies Test Page</asp:LinkButton>
            </div>
        </div>
    </form>
</body>
</html>
