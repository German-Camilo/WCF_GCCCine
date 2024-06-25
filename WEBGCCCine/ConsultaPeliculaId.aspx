<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaPeliculaId.aspx.cs" Inherits="WEBGCCCine.ConsultaPeliculaId" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Se obtiene la pelicula por ID</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>BUSQUE LA PELICULA POR id</h2>
            <table>
                <tr>
                    <td>PeliculaID:</td>
                    <td><asp:TextBox ID="txtPeliculaID" runat="server" /></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnConsulta" runat="server" Text="ObtenerPelicula" OnClick="btnConsultar_Click" />
                    </td>
                </tr>
            </table>
            <h3>Datos de la pelicula:</h3>
            <table>
                <tr>
                    <td>Nombre:</td>
                    <td><asp:Label ID="lblNombre" runat="server" Text="" /></td>
                </tr>
                <tr>
                    <td>Genero:</td>
                    <td><asp:Label ID="lblGenero" runat="server" Text="" /></td>
                </tr>
                <tr>
                    <td>Duración:</td>
                    <td><asp:Label ID="lblDuracion" runat="server" Text="" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
