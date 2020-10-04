<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2A.aspx.cs" Inherits="TP5_GRUPO3.Ejercicio2A" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 22px;
        }
        .auto-style3 {
            height: 22px;
            width: 124px;
        }
        .auto-style4 {
            width: 124px;
        }
        .auto-style5 {
            height: 22px;
            width: 142px;
        }
        .auto-style6 {
            width: 142px;
        }
        .auto-style7 {
            height: 22px;
            width: 336px;
        }
        .auto-style8 {
            width: 336px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <div>
            <strong>Seleccionar Productos:</strong><br />
            <asp:GridView ID="grdProductos" runat="server" AllowPaging="True" AutoGenerateColumns="False" AutoGenerateSelectButton="True" OnPageIndexChanging="grdProductos_PageIndexChanging" OnSelectedIndexChanged="grdProductos_SelectedIndexChanged" OnSelectedIndexChanging="grdProductos_SelectedIndexChanging" PageSize="14">
                <Columns>
                    <asp:TemplateField HeaderText="IdProducto">
                        <ItemTemplate>
                            <asp:Label ID="lbl_It_IdProducto" runat="server" Text='<%# Bind("IdProducto") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="NombreProducto">
                        <ItemTemplate>
                            <asp:Label ID="lbl_It_NombreProducto" runat="server" Text='<%# Bind("NombreProducto") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="IdProveedor"></asp:TemplateField>
                    <asp:TemplateField HeaderText="PrecioUnidad">
                        <ItemTemplate>
                            <asp:Label ID="lbl_It_PrecioUnidad" runat="server" Text='<%# Bind("PrecioUnidad") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="lblProductoSeleccionado" runat="server"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Ejercicio2.aspx">Volver al Inicio</asp:HyperLink>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
