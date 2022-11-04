<%@ Page Title="Deneme Sayfası" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ornek01.WebF.WebForm1" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    Bu bir deneme sayfasıdır......
    <br />
    <br />
    <asp:Button ID="btonOK" runat="server" Text="İşlem Yap" OnClick="btonOK_Click" /><br /><br />
    <asp:Label ID="lbelMessage" CssClass="mesaj" runat="server"></asp:Label>

    <asp:Table ID="Table1" runat="server">
        <asp:TableRow>
            <asp:TableCell>Adı Soyadı : </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="tboxAdSoyad" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>E-Mail</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="tboxEMail" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="btonGonder" runat="server" Text="Mail Gönder" OnClick="btonGonder_Click" /></asp:TableCell>
        </asp:TableRow>
    </asp:Table>

</asp:Content>
