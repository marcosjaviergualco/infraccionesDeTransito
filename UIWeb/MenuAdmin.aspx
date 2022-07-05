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
        <asp:Button ID="ButtonRegistrarInfraccion" runat="server" style="z-index: 1; left: 10px; top: 75px; position: absolute" Text="Registrar Nueva Infracción" OnClick="ButtonRegistrarInfraccion_Click" />
        <asp:Button ID="ButtonAgregarTipoInfraccion" runat="server" OnClick="ButtonAgregarTipoInfraccion_Click" style="z-index: 1; left: 10px; top: 149px; position: absolute" Text="Agregar Tipo de Infracción" />
        <asp:Button ID="ButtonModificarTipoInfraccion" runat="server" style="z-index: 1; left: 10px; top: 226px; position: absolute" Text="Modificar Tipo de Infracción (escoger uno)" OnClick="ButtonModificarTipoInfraccion_Click" />
        <asp:ListBox ID="ListBoxTipoInfraccion" runat="server" style="z-index: 1; left: 11px; top: 259px; position: absolute; height: 126px; width: 359px"></asp:ListBox>
        <asp:Label ID="LabelError" runat="server" style="z-index: 1; left: 396px; top: 293px; position: absolute"></asp:Label>
        <asp:TextBox ID="TextBoxDominio" runat="server" style="z-index: 1; left: 551px; top: 77px; position: absolute; width: 195px"></asp:TextBox>
        <asp:Button ID="ButtonConsultarInfracciones" runat="server" OnClick="ButtonConsultarInfracciones_Click" style="z-index: 1; left: 554px; top: 113px; position: absolute; width: 197px" Text="Consultar infracciones" />
    </form>
</body>
</html>
