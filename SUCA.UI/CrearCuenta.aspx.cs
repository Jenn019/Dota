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
    public partial class CrearCuenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                IUsuario usu = new MUsuario();
                var usuario = usu.BuscarUsuario(txtUsuario.Text, Encriptacion.Encriptar(txtContra.Text));
                if (txtContra.Text != txtConfirmar.Text)
                {
                    MostarMensajeError("Contraseñas no coinciden.");

                }
                else if (usuario != null)
                {
                    MostarMensajeError("Usuario ya existe, intentelo de nuevo.");
                }
                else
                {
                    var newusuario = new DATA.Usuario
                    {
                        Username = txtUsuario.Text,
                        Password = Encriptacion.Encriptar(txtContra.Text),
                        Rol = txtRol.Text,
                    };

                    usu.insertarUsuario(newusuario);
                    MostarMensaje("Usuario creado con exito.");
                    txtUsuario.Text = string.Empty;
                    txtContra.Text = string.Empty;
                    txtConfirmar.Text = string.Empty;

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