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
        <asp:Label ID="LabelTotal" runat="server" style="z-index: 1; left: 575px; top: 289px; position: absolute"></asp:Label>
        <p>
            &nbsp;</p>
        <div style="margin-left: 40px">
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 475px; top: 287px; position: absolute" Text="TOTAL:"></asp:Label>
    </form>
</body>
</html>
