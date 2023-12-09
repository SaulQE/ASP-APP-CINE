<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FuncionRegistrar.aspx.cs" Inherits="UI.FuncionRegistrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h3>Funciones - Registrar</h3>
    </div> <br />

    <div>
        <table style="width: 100%;">
            <tr>
                <td class="text-center" style="width: 213px; height: 37px">Película:</td>
                <td style="width: 178px; height: 37px">
                    <asp:DropDownList ID="ddlPeliculaID" runat="server" Height="35px" Width="224px" style="margin-top: 6">
                    </asp:DropDownList>
                </td>
                <td style="height: 37px"></td>
            </tr>

            <tr>
                <td class="text-center" style="width: 213px; height: 37px">Sala:</td>
                <td style="width: 178px; height: 37px">
                    <asp:DropDownList ID="ddlSalaID" runat="server" Height="35px" Width="223px" style="margin-top: 6">
                    </asp:DropDownList>
                </td>
                <td style="height: 37px"></td>
            </tr>

            <tr>
                <td class="text-center" style="width: 213px; height: 37px">Fecha:</td>
                <td style="width: 178px; height: 37px">
                    <asp:TextBox ID="txtFechaHora" runat="server" Width="218px"></asp:TextBox>
                </td>
                <td style="height: 37px">
                    <asp:RequiredFieldValidator ID="rfvFechaHora" runat="server" ControlToValidate="txtFechaHora" Display="Dynamic" ErrorMessage="Campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cvFechaHora" runat="server" ControlToValidate="txtFechaHora" Display="Dynamic" ErrorMessage="¡Formato incorrecto!" ForeColor="Red" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                </td>
            </tr>

            <tr>
                <td class="text-center" style="width: 213px; height: 78px"></td>
                <td style="height: 78px; width: 178px">
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Width="92px" OnClick="btnGuardar_Click" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CausesValidation="False" OnClick="btnCancelar_Click" Width="85px" />
                </td>
                <td style="height: 78px"></td>
            </tr>
        </table>
    </div>

</asp:Content>
