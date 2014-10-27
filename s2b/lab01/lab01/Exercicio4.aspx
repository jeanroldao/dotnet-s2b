<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercicio4.aspx.cs" Inherits="lab01.Exercicio4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="#cccccc">
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblUsuario" runat="server" AssociatedControlID="txtUsuario" 
            Text="Usuário:"></asp:Label>
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSenha" runat="server" AssociatedControlID="txtSenha" 
            Text="Senha:"></asp:Label>
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
