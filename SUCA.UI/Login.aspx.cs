using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SUCA.DATA;
using SUCA.BLL.Interfaces;
using SUCA.BLL.Metodos;

namespace SUCA.UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                IUsuario usu = new MUsuario();
                var usuario = usu.BuscarUsuario(txtUsuario.Text, Encriptacion.Encriptar(txtContra.Text));
                if (usuario != null)
                {
                    Session["Rol"] = usuario.Rol;
                    if (usuario.Rol == "Cliente")
                        Response.Redirect("MantenCliente.aspx");

                    if (usuario.Rol == "Administrador")
                        Response.Redirect("MantenCliente.aspx");
                }
                else
                {
                    MostarMensajeError("Usuario o contra incorrecto");
                }
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
            }
        }

        private void MostarMensaje(string texto)
        {
            mensaje.Visible = true;
            mensajeError.Visible = false;
            textoMensajeError.InnerHtml = string.Empty;
            textoMensaje.InnerHtml = texto;
        }

        private void MostarMensajeError(string texto)
        {
            mensaje.Visible = false;
            mensajeError.Visible = true;
            textoMensajeError.InnerHtml = texto;
            textoMensaje.InnerHtml = string.Empty;
        }
    }
}