<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SUCA.UI.Login" %>
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
    <div class="container">
        <div id="loginbox" style="margin-top: 50px;" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
            <div class="panel panel-info">
                <div class="panel-heading">
                    <div class="panel-title">Login</div>
                </div>
                <div style="padding-top: 30px" class="panel-body">
                    <div class="form-horizontal">
                        <div style="margin-bottom: 25px" class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                            <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div style="margin-bottom: 25px" class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
                            <asp:TextBox ID="txtContra" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                        </div>
                        <div style="margin-top:10px" class="form-group">
                            <div class="col-sm-12">

                                 <asp:Button id="btnLogin"
                                               Text="Login"
                                                 OnClick="btnLogin_Click"
                                                        runat="server"/>                   
                            </div>
                        </div>
                        
                        <div style="margin-top:10px" class="form-group">
                            <div class="col-sm-12">
                                <div style="border-top:1px solid#888; padding-top:15px; font-size:85%">
                                    No tiene cuenta ?
                                    <a href="CrearCuenta.aspx"> Crear cuenta aquí</a>
                                </div>    
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>