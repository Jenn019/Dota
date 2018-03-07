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
    public partial class MantenCliente : System.Web.UI.Page
    {
        ICliente clie = new MCliente();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnModificarc_Click(object sender, EventArgs e)
        {

            try
            {
                Cliente cliente = new Cliente
                {
                    Cedula = Convert.ToInt32(txtCedula.Text),
                    Nombre = txtNombre.Text,
                    Apellido = txtApellidos.Text,

                    Direccion = txtDireccion.Text,
                    Telefono = Convert.ToInt32(txtTelefono.Text),


                };
                ICliente clien = new MCliente();
                clien.ActualizarCliente(cliente);
                MostarMensaje("Cliente Modificado");
                divMantenimiento.Visible = false;
                txtCedula.Enabled = true;
                txtCedula.Text = string.Empty;
                txtCedula.Focus();
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
            }

        }

        protected void btnEliminarc_Click(object sender, EventArgs e)
        {
            try
            {
                clie.EliminarCliente(Convert.ToInt32(txtCedula1.Text));
                MostarMensaje("Cliente Eliminado");
                divMantenimiento.Visible = false;
                txtCedula1.ReadOnly = false;
                txtCedula1.Text = string.Empty;
                txtCedula1.Focus();
                txtCedula1.Enabled = true;
            }
            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = clie.BuscarCliente(Convert.ToInt32(txtCedula1.Text));
                if (cliente != null)
                {
                    txtCedula.Text = cliente.Cedula.ToString();
                    txtNombre.Text = cliente.Nombre;
                    txtApellidos.Text = cliente.Apellido.ToString();
                    txtDireccion.Text = cliente.Direccion.ToString();
                    txtTelefono.Text = cliente.Telefono.ToString();

                    divMantenimiento.Visible = true;
                    txtCedula1.Enabled = false;

                }
                else
                {
                    MostarMensajeError("El cliente no existe");
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