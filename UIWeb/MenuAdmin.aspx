<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuAdmin.aspx.cs" Inherits="UIWeb.MenuAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="ButtonRegistrarInfraccion" runat="server" style="z-index: 1; left: 10px; top: 75px; position: absolute" Text="Registrar Nueva Infracción" />
        <asp:Button ID="ButtonAgregarTipoInfraccion" runat="server" OnClick="ButtonAgregarTipoInfraccion_Click" style="z-index: 1; left: 10px; top: 149px; position: absolute" Text="Agregar Tipo de Infracción" />
        <asp:Button ID="ButtonModificarTipoInfraccion" runat="server" style="z-index: 1; left: 10px; top: 226px; position: absolute" Text="Modificar Tipo de Infracción (escoger uno)" />
        <asp:ListBox ID="ListBoxTipoInfraccion" runat="server" style="z-index: 1; left: 11px; top: 259px; position: absolute; height: 126px; width: 359px"></asp:ListBox>
    </form>
</body>
</html>
