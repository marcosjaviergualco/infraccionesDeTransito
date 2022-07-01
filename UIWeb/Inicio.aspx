<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="UIWeb.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            DNI<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Nombre<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Agregar Persona con datos ingresados aquí" OnClick="Button1_Click" />
            <br />
            <br />
&nbsp;&nbsp;
            <asp:ListBox ID="ListBox1" runat="server" Height="249px" Width="202px"></asp:ListBox>
            <asp:Button ID="Button2" runat="server" Text="Eliminar persona seleccionada" OnClick="Button2_Click" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Agregar Persona desde otra página" />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Salir" />
        </div>
    </form>
</body>
</html>
