<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertarMateria.aspx.cs" Inherits="SUCA.UI.InsertarMateria" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
      <h2>Insertar Materia prima</h2>
    <div class="alert alert-success" visible="false" id="mensaje" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong id="textoMensaje" runat="server"></strong>
    </div>
    <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong id="textoMensajeError" runat="server"></strong>
    </div>
     <div class="form-group">
   
         <asp:Label ID="lblCodigo"  foreColor="black" runat="server" Text="Codigo:"></asp:Label>
        <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control"></asp:TextBox>

        <br />
        <asp:Label ID="lbNombre"  foreColor="black" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>

        <br />

        <asp:Label ID="lblCantidad"  foreColor="black" runat="server" Text="Cantidad:"></asp:Label>
        <asp:TextBox ID="txtCantidad" runat="server" CssClass="form-control"></asp:TextBox>

        <br />
        
        <asp:Label ID="lblCosto"  foreColor="black" runat="server" Text="Costo:"></asp:Label>
        <asp:TextBox ID="txtCosto" runat="server" CssClass="form-control"></asp:TextBox>

        <br />

        <asp:Button ID="btnInsertar" runat="server" Text="Insertar" CssClass="btn btn-primary" OnClick="btnInsertar_Click" />
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-primary" OnClick="btnCancelar_Click" />
        
    </div>

</asp:Content>
