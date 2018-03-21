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
    public partial class MantenProveedor : System.Web.UI.Page
    {
        IProveedor prove = new MProveedor();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnModificarc_Click(object sender, EventArgs e)
        {

            try
            {
                Proveedor proveedor = new Proveedor
                {
                    Empresa = txtEmpresa.Text,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellidos.Text,

                    Direccion = txtDireccion.Text,
                    Telefono = Convert.ToInt32(txtTelefono.Text),


                };
                IProveedor clien = new MProveedor();
                clien.ActualizarProveedor(proveedor);
                MostarMensaje("Proveedor Modificado");
                divMantenimiento.Visible = false;
                txtEmpresa.Enabled = true;
                txtEmpresa.Text = string.Empty;
                txtEmpresa.Focus();
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
                prove.EliminarProveedor(Convert.ToInt32(txtEmpresa1.Text));
                MostarMensaje("Proveedor Eliminado");
                divMantenimiento.Visible = false;
                txtEmpresa1.ReadOnly = false;
                txtEmpresa1.Text = string.Empty;
                txtEmpresa1.Focus();
                txtEmpresa1.Enabled = true;
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
                var proveedor = prove.BuscarProveedor(Convert.ToInt32(txtEmpresa1.Text));
                if (proveedor != null)
                {
                    txtEmpresa.Text = proveedor.Empresa;
                    txtNombre.Text = proveedor.Nombre;
                    txtApellidos.Text = proveedor.Apellido.ToString();
                    txtDireccion.Text = proveedor.Direccion.ToString();
                    txtTelefono.Text = proveedor.Telefono.ToString();

                    divMantenimiento.Visible = true;
                    txtEmpresa1.Enabled = false;

                }
                else
                {
                    MostarMensajeError("El Proveedor no existe");
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