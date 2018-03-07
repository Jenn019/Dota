<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertarClientes.aspx.cs" Inherits="SUCA.UI.InsertarClientes" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
 <div class="container">

    <h2>Insertar cliente</h2>
    <div class="alert alert-success" visible="false" id="mensaje" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong id="textoMensaje" runat="server"></strong>
    </div>
    <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong id="textoMensajeError" runat="server"></strong>
    </div>
     <div class="form-group">
        <asp:Label ID="lbCedula" foreColor="White" runat="server" Text="Cedula:"></asp:Label>
        <asp:TextBox ID="txtCedula" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>

        <br />
   
        <asp:Label ID="lbNombre"  foreColor="White" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>

        <br />

        <asp:Label ID="lblApellido"  foreColor="White" runat="server" Text="Apellido:"></asp:Label>
        <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>

        <br />
        
        <asp:Label ID="lblDireccion"  foreColor="White" runat="server" Text="Direccion:"></asp:Label>
        <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>

        <br />

        <asp:Label ID="lblTelefono"  foreColor="White" runat="server" Text="Telefono:"></asp:Label>
        <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>

        <br />
        <asp:Button ID="btnInsertar" runat="server" Text="Insertar" CssClass="btn btn-primary" OnClick="btnInsertar_Click" />
        &nbsp;&nbsp;
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-primary" OnClick="btnCancelar_Click" />
        
    </div>
</asp:Content>
