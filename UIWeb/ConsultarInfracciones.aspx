<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultarInfracciones.aspx.cs" Inherits="UIWeb.ConsultarInfracciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            INFRACCIONES A PAGAR PARA EL VEHICULO :
            <asp:Label ID="Label_vehiculo" runat="server"></asp:Label>
        </div>
        <asp:Button ID="ButtonVolver" runat="server" style="z-index: 1; left: 34px; top: 414px; position: absolute; height: 42px; width: 402px;" Text="VOLVER AL MENU PRINCIPAL" OnClick="ButtonVolver_Click" />
        <asp:Button ID="ButtonGenerarPago" runat="server" OnClick="ButtonGenerarPago_Click" style="z-index: 1; left: 35px; top: 355px; position: absolute; height: 39px; width: 399px;" Text="GENERAR ORDEN DE PAGO" />
        <asp:ListBox ID="ListBoxInfracciones" runat="server" style="z-index: 1; left: 13px; top: 47px; position: absolute; height: 207px; width: 1275px"></asp:ListBox>
        <div style="margin-left: 80px">
        </div>
        <asp:Label ID="LabelTotal" runat="server" style="z-index: 1; left: 134px; top: 294px; position: absolute"></asp:Label>
        <p>
            &nbsp;</p>
        <div style="margin-left: 40px">
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 60px; top: 295px; position: absolute" Text="TOTAL:"></asp:Label>
        <asp:ListBox ID="ListBoxPagas" runat="server" style="z-index: 1; left: 539px; top: 330px; position: absolute; height: 131px; width: 416px"></asp:ListBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 544px; top: 308px; position: absolute" Text="Infracciones pagas"></asp:Label>
    </form>
</body>
</html>
