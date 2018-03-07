using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SUCA.DATA;
using SUCA.BLL.Interfaces;
using SUCA.BLL.Metodos;
using System.IO;

namespace SUCA.UI
{
    public partial class InsertarClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente

                {
                    Cedula = Convert.ToInt32(txtCedula.Text),
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = Convert.ToInt32(txtTelefono.Text),
                };
                ICliente clie = new MCliente();
                clie.InsertarCliente(cliente);
                MostarMensaje("Cliente Insertado");
            }

            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
            }

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListarCliente");
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