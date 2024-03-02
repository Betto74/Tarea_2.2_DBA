<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="seeBooks.aspx.cs" Inherits="WebApplication1.seeBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvLibros" runat="server" Height="210px" Width="873px">
            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Agregar" />
        </div>
    </form>
</body>
</html>
