<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HelloASPWebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" submitdisabledcontrols="False">
        <div>
            <asp:Label ID="labelImie" runat="server" Text="Imię: "></asp:Label>
            <asp:TextBox ID="TextBoxImie" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="labelNazwisko" runat="server" Text="Nazwisko:"></asp:Label>
            <asp:TextBox ID="TextBoxNazwisko" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="LabelWiek" runat="server" Text="Wiek: "></asp:Label>
            <asp:TextBox ID="TextBoxWiek" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="ButtonOK" runat="server" OnClick="ButtonOK_Click" Text="Wyślij" />
            <br />
            <asp:Label ID="LabelKomunikat1" runat="server"></asp:Label>
            <br />
            <asp:Label ID="LabelKomunika2" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
