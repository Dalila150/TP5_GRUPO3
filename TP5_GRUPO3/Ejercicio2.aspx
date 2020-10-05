<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TP5_GRUPO3.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style5 {
            width: 70px;
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
        }
        .auto-style7 {
            width: 70px;
            height: 42px;
        }
        .auto-style8 {
            height: 42px;
        }
        .auto-style9 {
            width: 70px;
            height: 43px;
        }
        .auto-style10 {
            height: 43px;
        }
        .auto-style11 {
            width: 70px;
            height: 45px;
        }
        .auto-style12 {
            height: 45px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="lblInicio" runat="server" Text="Inicio"></asp:Label>
                    </td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style9"></td>
                    <td class="auto-style10">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Ejercicio2A.aspx">Seleccionar productos</asp:HyperLink>
                    </td>
                    <td class="auto-style10"></td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style8">
                        <asp:LinkButton ID="lbtEliminarProductos" runat="server" OnClick="lbtEliminarProductos_Click">Eliminar productos seleccionados</asp:LinkButton>
                    </td>
                    <td class="auto-style8"></td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td class="auto-style12">
                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Ejercicio2B.aspx">Mostrar productos</asp:HyperLink>
                    </td>
                    <td class="auto-style12"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
