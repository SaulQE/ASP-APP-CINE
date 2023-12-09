<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FuncionListar.aspx.cs" Inherits="UI.FuncionListar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style type="text/css">
        .custom-gridview {
            table-layout: fixed;
            border-collapse: collapse;
        }

        .custom-gridview th, .custom-gridview td {
            text-align: center;
            border: 1px solid #ccc;
            padding: 2px;
        }
    </style>
    
    <div>
        <h3>Función - Listar</h3>
    </div>

    <div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/default.aspx">Index</asp:HyperLink> |
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/FuncionRegistrar.aspx">Registrar</asp:HyperLink> |
        ID: <asp:TextBox ID="txtID" runat="server" Width="59px"></asp:TextBox> <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click"/>
    </div> <br />

    <asp:GridView ID="gvFunciones" runat="server" CssClass="custom-gridview" CellPadding="3" AllowPaging="True" PageSize="15" Width="974px" BackColor="White" BorderColor="#333333" BorderStyle="Solid" BorderWidth="1px" OnPageIndexChanging="gvFunciones_PageIndexChanging">
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#007DBB" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#00547E" />
    </asp:GridView>

</asp:Content>
