<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Aplicacion1.aspx.cs" Inherits="TP5_GRUPO3.Aplicacion1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblGrupo" runat="server" Font-Bold="True" Font-Size="Larger" Text="Grupo N°3"></asp:Label>
            <br />
        </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Ejercicio1.aspx">Ejercicio1</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Ejercicio2.aspx">Ejercicio2</asp:HyperLink>
    </form>
</body>
</html>
