<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASPNet.SomeControls.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>.: ASP.NET Some Controls - Main Page :.</title>
    <link href="Styles/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="component">
            <asp:LinkButton ID="lnkbAdRotator" runat="server" CssClass="button" OnClick="lnkbAdRotator_Click" OnClientClick="window.document.forms[0].target='_blank';">AdRotator Component</asp:LinkButton>
        </div>
        <div class="component">
            <asp:LinkButton ID="lnkbDropdownList" runat="server" CssClass="button" OnClick="lnkbDropdownList_Click" OnClientClick="window.document.forms[0].target='_blank';">DropdownList Component</asp:LinkButton>
        </div>
        <div class="component">
            <asp:LinkButton ID="lnkbDropdownListwCode" runat="server" CssClass="button" OnClick="lnkbDropdownListwCode_Click" OnClientClick="window.document.forms[0].target='_blank';">DropdownList Component (with Code)</asp:LinkButton>
        </div>
        <div class="component">
            <asp:LinkButton ID="lnkbDropdownListwClass" runat="server" CssClass="button" OnClick="lnkbDropdownListwClass_Click" OnClientClick="window.document.forms[0].target='_blank';">DropdownList Component (with Class)</asp:LinkButton>
        </div>
        <div class="component">
            <asp:LinkButton ID="lnkbFileUpload" runat="server" CssClass="button" OnClick="lnkbFileUpload_Click" OnClientClick="window.document.forms[0].target='_blank';">File Upload Component</asp:LinkButton>
        </div>
        <div class="component">
            <asp:LinkButton ID="lnkbDTwCookie" runat="server" CssClass="button" OnClick="lnkbDTwCookie_Click" OnClientClick="window.document.forms[0].target='_blank';">Data Transfer Between Pages with Cookies</asp:LinkButton>
        </div>
        <div class="component">
            <asp:LinkButton ID="lnkbDTwQueryString" runat="server" CssClass="button" OnClick="lnkbDTwQueryString_Click" OnClientClick="window.document.forms[0].target='_blank';">Data Transfer Between Pages with Query String</asp:LinkButton>
        </div>
        <div class="component">
            <asp:LinkButton ID="lnkbDTwSession" runat="server" CssClass="button" OnClick="lnkbDTwSession_Click" OnClientClick="window.document.forms[0].target='_blank';">Data Transfer Between Pages with Session</asp:LinkButton>
        </div>
        <div class="component">
            <asp:LinkButton ID="lnkbDGXML" runat="server" CssClass="button" OnClick="lnkbDGXML_Click" OnClientClick="window.document.forms[0].target='_blank';">Datagrid with XML</asp:LinkButton>
        </div>
    </form>
</body>
</html>
