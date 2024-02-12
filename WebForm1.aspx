<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VisualizzaDati.aspx.cs" Inherits="NomeProgetto.VisualizzaDati" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Visualizza Dati</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnVisualizza" runat="server" Text="Visualizza" OnClick="btnVisualizza_Click" />
            <br />
            <asp:Label ID="lblDati" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
