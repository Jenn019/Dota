﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MantenCliente.aspx.cs" Inherits="SUCA.UI.MantenCliente" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2>Mantenimiento de clientes</h2>
    <div class="form-inline">
        <div class="alert alert-success" visible="false" id="mensaje" runat="server">
            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
            <strong id="textoMensaje" runat="server"></strong>
        </div>
        <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
            <strong id="textoMensajeError" runat="server"></strong>
        </div>
        <asp:Label ID="lbCedula1" runat="server" Text="ID Cliente: "></asp:Label>
        <asp:TextBox ID="txtCedula1" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-success" OnClick="btnBuscar_Click" />
    </div>

    <br />

    <div class="form-group" id="divMantenimiento" runat="server" visible="false">
        <asp:Label ID="lbCedula" runat="server" Text="ID Cliente"></asp:Label>
        <asp:TextBox ID="txtCedula" runat="server" CssClass="form-control"></asp:TextBox>

        <br />

        <asp:Label ID="lbNombre" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>

        <br />

        <asp:Label ID="lbApellidos" runat="server" Text="Apellido"></asp:Label>
        <asp:TextBox ID="txtApellidos" runat="server" CssClass="form-control"></asp:TextBox>

        <br />

        <asp:Label ID="lblDireccion" runat="server" Text="Direccion:"></asp:Label>
        <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>

        <br />

        <asp:Label ID="lblTelefono" runat="server" Text="Telefono:"></asp:Label>
        <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>

        <br />
       
        <div class="form-horizontal">
            <br />
            <asp:Button ID="btnModificarc" runat="server" Text="Modificar" CssClass="btn btn-success" OnClick="btnModificarc_Click" />
            <asp:Button ID="btnEliminarc" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="btnEliminarc_Click" />
        </div>
    </div>
</asp:Content>
