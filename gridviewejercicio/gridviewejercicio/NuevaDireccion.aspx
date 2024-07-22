<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="NuevaDireccion.aspx.cs" Inherits="gridviewejercicio.NuevoProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lbTitutlo" runat="server" Text="Nueva dirección" CssClass="fs-2"></asp:Label>
    <div class="row">
        <div class="col-6">
            <div class="mb-3 row">
                <label for="tbxId" class="col-sm-2 col-form-label">Id:</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="tbxId" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="mb-3 row">
                <label for="tbxCalle" class="col-sm-2 col-form-label">Calle:</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="tbxCalle" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="mb-3 row">
                <label for="tbxNumero" class="col-sm-2 col-form-label">Número:</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="tbxNumero" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="mb-3 row">
                <label for="tbxCodPos" class="col-sm-2 col-form-label">Código Postal:</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="tbxCodPos" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="mb-3 row">
                <label for="tbxDistrito" class="col-sm-2 col-form-label">Distrito:</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="tbxDistrito" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <%if (Request.QueryString["Id"] == null)
                { %>
            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" />

            <% } else
            { %>
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-primary" OnClick="btnModificar_Click" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click" />
            <br />

            <% } %>
            <a href="Default.aspx" class="link-opacity-100">Cancelar</a>
        </div>
    </div>
</asp:Content>
