<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PeliculaRegistrar.aspx.cs" Inherits="UI.PeliculaRegistrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h3>Película - Registrar</h3>
    </div> <br />

    <div>
        <table style="width: 100%;">
            <tr>
                <td class="text-center" style="width: 213px; height: 37px">Título:</td>
                <td style="width: 178px; height: 37px">
                    <asp:TextBox ID="txtTitulo" runat="server" Width="161px"></asp:TextBox>
                </td>
                <td style="height: 37px">
                    <asp:RequiredFieldValidator ID="rfvTitulo" runat="server" ControlToValidate="txtTitulo" ErrorMessage="Campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 213px; height: 37px">Director</td>
                <td style="width: 178px; height: 37px">
                    <asp:TextBox ID="txtDirector" runat="server" Width="158px"></asp:TextBox>
                </td>
                <td style="height: 37px">
                    <asp:RequiredFieldValidator ID="rfvDirector" runat="server" ControlToValidate="txtDirector" ErrorMessage="Campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 213px; height: 37px">Duración:</td>
                <td style="width: 178px; height: 37px">
                    <asp:TextBox ID="txtDurMInutos" runat="server" Width="158px"></asp:TextBox>
                </td>
                <td style="height: 37px">
                   <asp:RequiredFieldValidator ID="rfvDurMinutos" runat="server" ControlToValidate="txtDurMInutos" ErrorMessage="Campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 213px; height: 37px">Clasificación:</td>
                <td style="width: 178px; height: 37px">
                    <asp:TextBox ID="txtClasificacion" runat="server" Width="158px"></asp:TextBox>
                </td>
                <td style="height: 37px">
                   <asp:RequiredFieldValidator ID="rfvClasificacion" runat="server" ControlToValidate="txtClasificacion" ErrorMessage="Campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>

            <tr>
                <td class="text-center" style="width: 213px; height: 78px"></td>
                <td style="height: 78px; width: 178px">
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Width="84px" OnClick="btnGuardar_Click" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CausesValidation="False" OnClick="btnCancelar_Click" />
                </td>
                <td style="height: 78px"></td>
            </tr>
        </table>
    </div>

</asp:Content>
