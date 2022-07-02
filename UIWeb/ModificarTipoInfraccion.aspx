<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarTipoInfraccion.aspx.cs" Inherits="UIWeb.ModificarTipoInfraccion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="CODIGO"></asp:Label>
        <asp:TextBox ID="TextBoxCodigo" runat="server" style="z-index: 1; left: 10px; top: 54px; position: absolute" AutoPostBack="True"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 10px; top: 82px; position: absolute" Text="DESCRIPCION"></asp:Label>
        <asp:TextBox ID="TextBoxDescripcion" runat="server" style="z-index: 1; left: 10px; top: 109px; position: absolute; width: 212px"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 10px; top: 139px; position: absolute" Text="IMPORTE"></asp:Label>
        <asp:TextBox ID="TextBoxImporte" runat="server" style="z-index: 1; left: 10px; top: 165px; position: absolute"></asp:TextBox>
        <asp:Button ID="ButtonModificar" runat="server" OnClick="ButtonModificar_Click" style="z-index: 1; left: 14px; top: 208px; position: absolute" Text="MODIFICAR" />
        <asp:Button ID="ButtonCancelar" runat="server" style="z-index: 1; left: 154px; top: 208px; position: absolute" Text="CANCELAR" />
        <asp:RadioButton ID="RadioButtonGrave" runat="server" GroupName="categoria" style="z-index: 1; left: 303px; top: 65px; position: absolute" Text="Grave" />
        <asp:RadioButton ID="RadioButtonLeve" runat="server" GroupName="categoria" style="z-index: 1; left: 303px; top: 90px; position: absolute" Text="Leve" />
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 304px; top: 35px; position: absolute" Text="CATEGORIA"></asp:Label>
        <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 388px; top: 180px; position: absolute"></asp:Label>
    </form>
</body>
</html>
