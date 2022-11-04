<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DTwQueryString.aspx.cs" Inherits="ASPNet.SomeControls.DTwQueryString" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>.: ASP.NET Some Controls - Data Transfer Between Pages with Query String :.</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <b>Value :</b>&nbsp;<asp:TextBox ID="tboxValue" runat="server" Width="300px"></asp:TextBox>
            <br />
            <br />
            <div class="component">
                <asp:LinkButton ID="lnkbDTwTestQS" runat="server" CssClass="button" OnClick="lnkbDTwTestQS_Click" OnClientClick="window.document.forms[0].target='_blank';">Query String Test Page</asp:LinkButton>
            </div>
        </div>
    </form>
</body>
</html>
