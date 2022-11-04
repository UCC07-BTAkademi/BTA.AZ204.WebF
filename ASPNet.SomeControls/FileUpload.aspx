<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUpload.aspx.cs" Inherits="ASPNet.SomeControls.FileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>.: ASP.NET Some Controls - File Upload :.</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="fuplFile" runat="server" AllowMultiple="True" />
            <br />
            <br />
            <asp:Label ID="lbelUploadedFiles" runat="server" ></asp:Label>
            <br />
            <br />

            <asp:Button ID="btonUpload" runat="server" OnClick="btonUpload_Click" Text="Upload Files" />
        </div>
    </form>
</body>
</html>
