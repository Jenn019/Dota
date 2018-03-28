
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MantenProductos.aspx.cs" Inherits="SUCA.UI.MantenProductos" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <h2>Mantenimiento de Productos</h2>
    <div class="form-inline">
        <div class="alert alert-success" visible="false" id="mensaje" runat="server">
            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
            <strong id="textoMensaje" runat="server"></strong>
        </div>
        <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
            <strong id="textoMensajeError" runat="server"></strong>
        </div>
        <asp:Label ID="lbCodigo1" runat="server" Text="ID Producto: "></asp:Label>
        <asp:TextBox ID="txtCodigo1" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-success" OnClick="btnBuscar_Click" />
    </div>

    <br />

    <div class="form-group" id="divMantenimiento" runat="server" visible="false">
 
        <asp:Label ID="lbNombre" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>

        <br />

        <asp:Label ID="lbCodigo" runat="server" Text="Codigo:"></asp:Label>
        <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control"></asp:TextBox>


        <asp:Label ID="lbProveedor" runat="server" Text="Telefono:"></asp:Label>
        <asp:TextBox ID="txtProveedor" runat="server" CssClass="form-control"></asp:TextBox>

        <br />
       
        <div class="form-horizontal">
            <br />
            <asp:Button ID="btnModificarc" runat="server" Text="Modificar" CssClass="btn btn-success" OnClick="btnModificarc_Click" />
            <asp:Button ID="btnEliminarc" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="btnEliminarc_Click" />
        </div>
    </div>
</asp:Content>
