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
    public partial class InsertarProveedores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedor proveedor = new Proveedor

                {
                    Empresa = txtEmpresa.Text,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = Convert.ToInt32(txtTelefono.Text),
                };
                IProveedor prove = new MProveedor();
                prove.InsertarProveedor(proveedor);
                MostarMensaje("Proveedor Insertado");
            }

            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("listarProveedores");
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