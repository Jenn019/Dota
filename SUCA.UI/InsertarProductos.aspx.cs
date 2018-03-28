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
    public partial class InsertarProductos : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {

            try
            {
                Producto producto = new Producto

                {
                    Nombre = txtNombre.Text,
                    Proveedor = txtProveedor.Text,
                    Codigo = Convert.ToInt32(txtCodigo.Text),
                };
                IProducto prod = new MProducto();
                prod.InsertarProducto(producto);
                MostarMensaje("Proveedor Insertado");
            }

            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
            }

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("listarProductos");
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