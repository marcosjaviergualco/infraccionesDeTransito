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
        <asp:TextBox ID="TextBoxCodigo" runat="server" style="z-index: 1; left: 10px; top: 54px; position: absolute"></asp:TextBox>
        <asp:Button ID="ButtonModificar" runat="server" OnClick="ButtonModificar_Click" style="z-index: 1; left: 8px; top: 249px; position: absolute" Text="MODIFICAR" />
        <asp:Button ID="ButtonCancelar" runat="server" style="z-index: 1; left: 155px; top: 251px; position: absolute" Text="CANCELAR" OnClick="ButtonCancelar_Click" />
        <asp:RadioButton ID="RadioButtonGrave" runat="server" GroupName="categoria" style="z-index: 1; left: 303px; top: 65px; position: absolute" Text="Grave" />
        <asp:RadioButton ID="RadioButtonLeve" runat="server" GroupName="categoria" style="z-index: 1; left: 303px; top: 90px; position: absolute" Text="Leve" />
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 304px; top: 35px; position: absolute" Text="CATEGORIA"></asp:Label>
        <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 388px; top: 180px; position: absolute"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; top: 33px; position: absolute" Text="CODIGO"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
        <asp:TextBox ID="TextBoxDescripcion" runat="server" style="z-index: 1; left: 18px; top: 112px; position: absolute; width: 164px"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 15px; top: 89px; position: absolute; height: 21px; width: 142px;" Text="DESCRIPCION"></asp:Label>
        </p>
        <p>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 18px; top: 139px; position: absolute; width: 83px;" Text="IMPORTE"></asp:Label>
        </p>
        <p>
        <asp:TextBox ID="TextBoxImporte" runat="server" style="z-index: 1; left: 17px; top: 173px; position: absolute; height: 15px;"></asp:TextBox>
        </p>
        <asp:Label ID="lblValidacion" runat="server"></asp:Label>
    </form>
</body>
</html>
