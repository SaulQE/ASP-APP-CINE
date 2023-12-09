<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PeliculaEditar.aspx.cs" Inherits="UI.PeliculaEditar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h3>Película - Editar - Eliminar</h3>
    </div> <br />

    <div>
        <table style="width: 100%;">

             <tr>
                <td class="text-center" style="width: 213px; height: 38px">Película ID:</td>
                <td style="width: 259px; height: 38px">
                    <asp:TextBox ID="txtID" runat="server" Width="195px" ReadOnly="true"></asp:TextBox>
                </td>
                <td style="height: 38px">&nbsp;</td>
            </tr>

            <tr>
                <td class="text-center" style="width: 213px; height: 37px">Título:</td>
                <td style="width: 178px; height: 37px">
                    <asp:TextBox ID="txtTitulo" runat="server" Width="194px"></asp:TextBox>
                </td>
                <td style="height: 37px">
                    <asp:RequiredFieldValidator ID="rfvTitulo" runat="server" ControlToValidate="txtTitulo" ErrorMessage="Campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 213px; height: 37px">Director</td>
                <td style="width: 178px; height: 37px">
                    <asp:TextBox ID="txtDirector" runat="server" Width="196px"></asp:TextBox>
                </td>
                <td style="height: 37px">
                    <asp:RequiredFieldValidator ID="rfvDirector" runat="server" ControlToValidate="txtDirector" ErrorMessage="Campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 213px; height: 37px">Duración:</td>
                <td style="width: 178px; height: 37px">
                    <asp:TextBox ID="txtDurMInutos" runat="server" Width="198px"></asp:TextBox>
                </td>
                <td style="height: 37px">
                   <asp:RequiredFieldValidator ID="rfvDurMinutos" runat="server" ControlToValidate="txtDurMInutos" ErrorMessage="Campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 213px; height: 37px">Clasificación:</td>
                <td style="width: 178px; height: 37px">
                    <asp:TextBox ID="txtClasificacion" runat="server" Width="196px"></asp:TextBox>
                </td>
                <td style="height: 37px">
                   <asp:RequiredFieldValidator ID="rfvClasificacion" runat="server" ControlToValidate="txtClasificacion" ErrorMessage="Campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
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
