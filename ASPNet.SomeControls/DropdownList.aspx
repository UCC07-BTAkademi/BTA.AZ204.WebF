<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropdownList.aspx.cs" Inherits="ASPNet.SomeControls.DropdownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>.: ASP.NET Some Controls - DropdownList :.</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Şehir
            <asp:DropDownList ID="ddlsCity" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlsCity_SelectedIndexChanged">
                <asp:ListItem Value="01">Adana</asp:ListItem>
                <asp:ListItem Value="06">Ankara</asp:ListItem>
                <asp:ListItem Value="10">Balıkesir</asp:ListItem>
                <asp:ListItem Value="21">Diyarbakır</asp:ListItem>
                <asp:ListItem Value="23">Elazığ</asp:ListItem>
                <asp:ListItem Value="33">Mersin</asp:ListItem>
                <asp:ListItem Value="44">Malatya</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lbelMessage" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
