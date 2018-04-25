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
    public partial class MantenProductos : System.Web.UI.Page
    {
        IProducto prod = new MProducto();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnModificarc_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = new Producto
                {
                    IdProducto = Convert.ToInt32(txtCodigo1.Text),
                    Nombre = txtNombre.Text,
                    Codigo = Convert.ToInt32(txtCodigo.Text),
                    Proveedor = txtProveedor.Text,
                };
                IProducto prod = new MProducto();
                prod.ActualizarProducto(producto);
                MostarMensaje("Producto Modificado");
                divMantenimiento.Visible = false;
                txtCodigo.Enabled = true;
                txtCodigo.Text = string.Empty;
                txtCodigo.Focus();
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
                prod.EliminarProducto(Convert.ToInt32(txtCodigo1.Text));
                MostarMensaje("Cliente Eliminado");
                divMantenimiento.Visible = false;
                txtCodigo1.ReadOnly = false;
                txtCodigo1.Text = string.Empty;
                txtCodigo1.Focus();
                txtCodigo1.Enabled = true;
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
                var producto = prod.BuscarProducto(Convert.ToInt32(txtCodigo1.Text));
                if (producto != null)

                {
                    txtCodigo1.Text = producto.IdProducto.ToString();
                    txtCodigo.Text = producto.Codigo.ToString();
                    txtNombre.Text = producto.Nombre;
                    txtProveedor.Text = producto.Proveedor;
                  

                    divMantenimiento.Visible = true;
                    txtCodigo1.Enabled = false;

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
