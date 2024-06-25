<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarPelicula.aspx.cs" Inherits="WEBGCCCine.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Person</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Agregar nueva Pelicula</h2>
            <table>
                <tr>
                    <td>Nombre de la pelicula:</td>
                    <td><asp:TextBox ID="txtNombrePelicula" runat="server" /></td>
                </tr>
                <tr>
                    <td>Genero:</td>
                    <td><asp:TextBox ID="txtGenero" runat="server" /></td>
                </tr>
                <tr>
                    <td>Duracion:</td>
                    <td><asp:TextBox ID="txtDuracion" runat="server" /></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnAgregarPelicula" runat="server" Text="Agregar Pelicula" OnClick="btnAgregarPelicula_Click" />
                    </td>
                </tr>
            </table>
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
