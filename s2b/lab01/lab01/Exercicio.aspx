<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercicio.aspx.cs" Inherits="lab01.Exercicio" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="btnValidar" runat="server" onclick="btnValidar_Click" 
            Text="Validar" />
        <br />
        <asp:Label ID="lblResultado" runat="server" Text="[lblResultado]"></asp:Label>
    
    </div>
    </form>
</body>
</html>
