<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="funciones.aspx.cs" Inherits="WEBGCCCine.funciones" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Funciones y Películas</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Funciones</h2>
            <asp:GridView ID="gvFunciones" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvFunciones_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="FuncionId" HeaderText="ID" />
                   <asp:BoundField DataField="Pelicula.Titulo" HeaderText="Película" />
                    <asp:BoundField DataField="FechaFuncion" HeaderText="Fecha" DataFormatString="{0:dd/MM/yyyy}" />       
                </Columns>
            </asp:GridView>


            <asp:Button ID="btnLoadData" runat="server" Text="Cargar Datos" OnClick="btnLoadData_Click" />
        </div>
    </form>
</body>
</html>