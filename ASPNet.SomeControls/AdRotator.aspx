<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdRotator.aspx.cs" Inherits="ASPNet.SomeControls.AdRotator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>.: ASP.NET Some Controls - AdRotator :.</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:AdRotator ID="adroAdvert" runat="server" AdvertisementFile="~/Data/Reklam.xml" Target="_blank"/>
        </div>
    </form>
</body>
</html>
