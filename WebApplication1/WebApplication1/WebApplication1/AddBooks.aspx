<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBooks.aspx.cs" Inherits="WebApplication1.AddBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            width: 674px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblIsbn" runat="server" Text="ISBN"></asp:Label>
&nbsp;&nbsp;&nbsp;<br />
&nbsp;<asp:TextBox ID="txtIsbn" runat="server" MaxLength="50"></asp:TextBox>
        <br />
        <asp:Label ID="lblMsgIsbn" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblTitulo" runat="server" Text="Titulo"></asp:Label>
&nbsp;&nbsp;&nbsp;<br />
&nbsp;<asp:TextBox ID="txtTitulo" runat="server" MaxLength="50"></asp:TextBox>
        <br />
        <asp:Label ID="lblMsgTitulo" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblNumEdicion" runat="server" Text="Numero de Edicion"></asp:Label>
&nbsp;&nbsp;<br />
        &nbsp;
        <asp:TextBox ID="txtNumEd" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblMsgEdicion" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblYearPub" runat="server" Text="Año de Publicacion"></asp:Label>
&nbsp;&nbsp;&nbsp;<br />
&nbsp;<asp:TextBox ID="txtYearPub" runat="server" MaxLength="4"></asp:TextBox>
        <br />
        <asp:Label ID="lblMsgPublicacion" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblNombreA" runat="server" Text="Autores"></asp:Label>
&nbsp;&nbsp;&nbsp;<br />
&nbsp;<asp:TextBox ID="txtAutores" runat="server" MaxLength="150"></asp:TextBox>
        <br />
        <asp:Label ID="lblMsgAutores" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblPaisPub" runat="server" Text="Pais de Publicacion"></asp:Label>
&nbsp;&nbsp;&nbsp;<br />
&nbsp;<asp:TextBox ID="txtPais" runat="server" MaxLength="50"></asp:TextBox>
        <br />
        <asp:Label ID="lblMsgPais" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblSinopsis" runat="server" Text="Sinopsis"></asp:Label>
&nbsp;&nbsp;<br />
        &nbsp;
        <asp:TextBox ID="txtSinopsis" runat="server" Height="57px" TextMode="MultiLine" Width="350px"></asp:TextBox>
        <br />
        <asp:Label ID="lblMsgSinopsis" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblCarrera" runat="server" Text="Carrera"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <br />
        <asp:TextBox ID="txtCarrera" runat="server" MaxLength="100"></asp:TextBox>
        <br />
        <asp:Label ID="lblMsgCarrera" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblMateria" runat="server" Text="Materia"></asp:Label>
&nbsp;&nbsp;&nbsp;<br />
&nbsp;<asp:TextBox ID="txtMateria" runat="server" MaxLength="100"></asp:TextBox>
        <br />
        <asp:Label ID="lblMsgMateria" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Aceptar" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver" />
    </form>
</body>
</html>
