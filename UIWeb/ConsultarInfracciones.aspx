<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultarInfracciones.aspx.cs" Inherits="UIWeb.ConsultarInfracciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="ButtonVolver" runat="server" style="z-index: 1; left: 672px; top: 359px; position: absolute" Text="Volver" />
        <asp:Button ID="ButtonGenerarPago" runat="server" OnClick="ButtonGenerarPago_Click" style="z-index: 1; left: 442px; top: 360px; position: absolute" Text="Generar Orden de Pago" />
        <asp:ListBox ID="ListBoxInfracciones" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 352px; width: 358px"></asp:ListBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 415px; top: 89px; position: absolute" Text="TOTAL:"></asp:Label>
        <asp:Label ID="LabelTotal" runat="server" style="z-index: 1; left: 478px; top: 88px; position: absolute"></asp:Label>
    </form>
</body>
</html>
