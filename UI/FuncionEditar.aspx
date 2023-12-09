<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FuncionEditar.aspx.cs" Inherits="UI.FuncionEditar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h3>Funciones - Editar - Borrar</h3>
    </div> <br />

    <div>
        <table style="width: 100%;">

            <tr>
                <td class="text-center" style="width: 213px; height: 38px">Función ID:</td>
                <td style="width: 259px; height: 38px">
                    <asp:TextBox ID="txtID" runat="server" Width="211px" ReadOnly="true"></asp:TextBox>
                </td>
                <td style="height: 38px">&nbsp;</td>
            </tr>
            <tr>
                <td class="text-center" style="width: 213px; height: 37px">Película:</td>
                <td style="width: 178px; height: 37px">
                    <asp:DropDownList ID="ddlPeliculaID" runat="server" Height="35px" Width="219px" style="margin-top: 6">
                    </asp:DropDownList>
                </td>
                <td style="height: 37px"></td>
            </tr>

            <tr>
                <td class="text-center" style="width: 213px; height: 37px">Sala:</td>
                <td style="width: 178px; height: 37px">
                    <asp:DropDownList ID="ddlSalaID" runat="server" Height="35px" Width="219px" style="margin-top: 6">
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
