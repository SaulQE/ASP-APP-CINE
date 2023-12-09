<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SalaEditar.aspx.cs" Inherits="UI.SalaEditar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h3>Sala - Editar - Eliminar</h3>
    </div> <br />

    <div>
        <table style="width: 100%;">
            
            <tr>
                <td class="text-center" style="width: 213px; height: 38px">Sala ID:</td>
                <td style="width: 259px; height: 38px">
                    <asp:TextBox ID="txtID" runat="server" Width="161px" ReadOnly="true"></asp:TextBox>
                </td>
                <td style="height: 38px">&nbsp;</td>
            </tr>
            <tr>
                <td class="text-center" style="width: 213px; height: 38px">Nombre Sala:</td>
                <td style="width: 259px; height: 38px">
                    <asp:TextBox ID="txtNomSala" runat="server" Width="161px"></asp:TextBox>
                </td>
                <td style="height: 38px">&nbsp;</td>
            </tr>
            <tr>
                <td class="text-center" style="width: 213px; height: 38px">Capacidad:</td>
                <td style="width: 259px; height: 38px">
                    <asp:TextBox ID="txtCapacidad" runat="server" Width="161px"></asp:TextBox>
                </td>
                <td style="height: 38px"></td>
            </tr>

            <tr>
                <td class="text-center" style="width: 213px; height: 21px">&nbsp;</td>
                <td style="height: 21px; width: 259px">
                    <asp:Button ID="btnEditar" runat="server" Text="Editar" Width="84px" OnClick="btnEditar_Click"/>
                    <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="btnBorrar_Click"/>
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click"/>
                </td>
                <td style="height: 21px"></td>
            </tr>

        </table>
    </div>

</asp:Content>
