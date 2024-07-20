<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="gridviewejercicio.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .oculto {
            display:none;
        }
    </style>
    <h2>GridView de Direcciones:</h2>
    <asp:GridView ID="gdvDirecciones" CssClass="table table-success table-striped" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Id" DataField="Id" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
            <asp:BoundField HeaderText="Calle" DataField="calle" />
            <asp:BoundField HeaderText="Número" DataField="numero" />
            <asp:BoundField HeaderText="Distrito" DataField="distrito" />
        </Columns>
    </asp:GridView>
    <asp:Button ID="btnNuevaDireccion" runat="server" Text="Agregar Dirección" CssClass="btn btn-primary" OnClick="btnNuevaDireccion_Click" />
</asp:Content>
