<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegisterForm.aspx.cs" Inherits="RegisterForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Nombres"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Apellido Paterno"></asp:Label>
            <asp:TextBox ID="txtApaterno" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Apellido Materno"></asp:Label>
        <asp:TextBox ID="txtAmaterno" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Usuario"></asp:Label>
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnRegistrar" runat="server" OnClick="btnRegistrar_Click" Text="Registrar" />
            <asp:Button ID="btnSalir" runat="server" Text="Salir" />
        </p>
    </form>
</body>
</html>
