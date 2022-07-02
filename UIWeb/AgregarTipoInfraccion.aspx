<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarTipoInfraccion.aspx.cs" Inherits="UIWeb.AgregarTipoInfraccion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="CODIGO"></asp:Label>
        <asp:TextBox ID="TextBoxIdTipo" runat="server" style="z-index: 1; left: 10px; top: 57px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 10px; top: 88px; position: absolute" Text="DESCRIPCION"></asp:Label>
        <asp:TextBox ID="TextBoxDescripcion" runat="server" style="z-index: 1; left: 10px; top: 116px; position: absolute; width: 241px"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 10px; top: 149px; position: absolute" Text="IMPORTE"></asp:Label>
        <asp:TextBox ID="TextBoxImporte" runat="server" style="z-index: 1; left: 10px; top: 180px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 300px; top: 34px; position: absolute" Text="CATEGORIA"></asp:Label>
        <asp:RadioButton ID="RadioButtonGrave" runat="server" style="z-index: 1; left: 305px; top: 54px; position: absolute" Text="Grave" GroupName="categoria" />
        <asp:RadioButton ID="RadioButtonLeve" runat="server" style="z-index: 1; left: 305px; top: 74px; position: absolute" Text="Leve" GroupName="categoria" />
        <asp:Button ID="ButtonAgregar" runat="server" OnClick="ButtonAgregar_Click1" style="z-index: 1; left: 10px; top: 238px; position: absolute" Text="AGREGAR" />
        <asp:Button ID="ButtonCancelar" runat="server" OnClick="ButtonCancelar_Click1" style="z-index: 1; left: 143px; top: 238px; position: absolute" Text="CANCELAR" />
        <asp:Label ID="LabelError" runat="server" style="z-index: 1; left: 294px; top: 149px; position: absolute"></asp:Label>
    </form>
</body>
</html>
