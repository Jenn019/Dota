<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearCuenta.aspx.cs" Inherits="SUCA.UI.CrearCuenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainMenu" runat="server">
    <div class="container">
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" runat="server" href="Login.aspx">Inicio</a>
        </div>
        <div class="navbar-collapse collapse">
            <ul class="nav navbar-nav">
                <li><a runat="server" href="CrearCuenta.aspx">Crear Cuenta</a></li>
            </ul>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="alert alert-success" visible="false" id="mensaje" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong id="textoMensaje" runat="server"></strong>
    </div>
    <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong id="textoMensajeError" runat="server"></strong>
    </div>
    <div class="form-group">

        <asp:Label ID="lblUsuario" runat="server" Text="Usuario:"></asp:Label>
        <asp:TextBox ID="txtUsuario" runat="server" class="form-control"></asp:TextBox>

        <asp:Label ID="lblContra" runat="server" Text="Contraseña:"></asp:Label>
        <asp:TextBox ID="txtContra" runat="server" class="form-control" TextMode="Password"></asp:TextBox>

        <asp:Label ID="lblConfirmar" runat="server" Text="Confirmar:"></asp:Label>
        <asp:TextBox ID="txtConfirmar" runat="server" class="form-control" TextMode="Password"></asp:TextBox>

        <asp:Label ID="lblRol" runat="server" Text="Rol:"></asp:Label>
        <asp:ListBox ID="txtRol" runat="server" Rows="1" class="form-control">
            <asp:ListItem>Administrador</asp:ListItem>
            <asp:ListItem>Cliente</asp:ListItem>
            
        </asp:ListBox>
        <div class="form-horizontal">
            <br />
            <asp:Button ID="btnInsertar" runat="server" Text="Insertar" CssClass="btn btn-primary" OnClick="btnInsertar_Click"/>
        </div>
    </div>
</asp:Content>
