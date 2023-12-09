<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SalaRegistrar.aspx.cs" Inherits="UI.SalaRegistrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h3>Sala - Registrar</h3>
    </div> <br />

    <div>
        <table style="width: 100%;">
            <tr>
                <td class="text-center" style="width: 213px; height: 37px">Nombre Sala:</td>
                <td style="width: 178px; height: 37px">
                    <asp:TextBox ID="txtNomSala" runat="server" Width="161px"></asp:TextBox>
                </td>
                <td style="height: 37px">
                    <asp:RequiredFieldValidator ID="rfvNomSala" runat="server" ControlToValidate="txtNomSala" ErrorMessage="Campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 213px; height: 37px">Capacidad</td>
                <td style="width: 178px; height: 37px">
                    <asp:TextBox ID="txtCapacidad" runat="server" Width="158px"></asp:TextBox>
                </td>
                <td style="height: 37px">
                    <asp:RequiredFieldValidator ID="rfvCapacidad" runat="server" ControlToValidate="txtCapacidad" ErrorMessage="Campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
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
