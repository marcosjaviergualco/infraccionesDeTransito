<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuAdmin.aspx.cs" Inherits="UIWeb.MenuAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            font-size: small;
            font-style: normal;
            color: #000000;
            text-transform: none;
        }
        .newStyle2 {
            font-size: small;
            font-style: normal;
        }
        div {
            border: 3px;
            margin: 10px;
            padding: 5px;
        }
    </style>
</head>
<body style="height: 471px">
    <form id="form1" runat="server">
        <div><H3>MENU PRINCIPAL</H3></div>
        <div><asp:Button ID="ButtonRegistrarInfraccion" runat="server" Text="REGISTRAR NUEVA INFRACCIÓN" OnClick="ButtonRegistrarInfraccion_Click" /></div>
        <div><asp:Button ID="ButtonAgregarTipoInfraccion" runat="server" OnClick="ButtonAgregarTipoInfraccion_Click" Text="AGREGAR TIPO DE INFRACCION" /></div>
        <div>
            <div><p class="newStyle1">INGRESAR PATENTE</p><asp:TextBox ID="TextBoxDominio" runat="server" Style="width:150px;"></asp:TextBox></div>
            <div><asp:Button ID="ButtonConsultarInfracciones" runat="server" OnClick="ButtonConsultarInfracciones_Click" Text="CONSULTAR INFRACCIONES" /></div>
        </div>
        <div>
          <p class="newStyle2"> SELECCIONAR TIPO DE INFRACCIÓN A MODIFICAR</p><asp:ListBox ID="ListBoxTipoInfraccion" runat="server" OnSelectedIndexChanged="ListBoxTipoInfraccion_SelectedIndexChanged" AutoPostBack="True" ></asp:ListBox>
          <div><asp:Button ID="ButtonModificarTipoInfraccion" runat="server" Text="MODIFICAR" OnClick="ButtonModificarTipoInfraccion_Click" /></div>
          <asp:Label ID="LabelError" runat="server"></asp:Label>   
        </div>
     </form>
</body>
</html>
