<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarInfraccion.aspx.cs" Inherits="UIWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="lblCodigo" runat="server" Text="Codigo"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
        </div>
        <p>
            &nbsp;<asp:Label ID="lblTipoInfraccion" runat="server" Text="Tipo de infracción"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddTipoInfraccion" runat="server" Height="16px" Width="168px">
            </asp:DropDownList>
        </p>
        <br />
        <asp:Label ID="lblDescripcion" runat="server" Text="Descripcion"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDescripcion" runat="server" Width="248px"></asp:TextBox>
        <br />
        <br />
        <br />
        .<asp:Label ID="Label1" runat="server" Text="Fecha registración"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Calendar ID="cFechaRegistracion" runat="server"></asp:Calendar>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Fecha del suceso"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <br />
        .<asp:Calendar ID="cFechaSuceso" runat="server"></asp:Calendar>
        <br />
        <br />
        <asp:Label ID="lblDominio" runat="server" Text="Dominio"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDominio" runat="server" Width="166px"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <br />
&nbsp;<asp:Button ID="btnVolver" runat="server" Height="46px" OnClick="btnVolver_Click" Text="Volver" Width="152px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnGuardar" runat="server" Height="47px" OnClick="btnGuardar_Click" Text="Guardar" Width="161px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="Manejo_error" runat="server" BackColor="Red"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
