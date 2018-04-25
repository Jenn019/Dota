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
    public partial class MantenFactura : System.Web.UI.Page
    {
        IFactura mat = new MFactura();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnModificarc_Click(object sender, EventArgs e)
        {

            try
            {
                Factura factura = new Factura
                {
                    IdFactura = Convert.ToInt32(txtCodigo1.Text),
                    Codigo = Convert.ToInt32(txtCodigo.Text),
                    Nombre = txtNombre.Text,
                    Total = Convert.ToInt32(txtTotal.Text),
                    Descuento = Convert.ToInt32(txtDescuento.Text),
                    Comentarios = txtComentarios.Text,
                };
                IFactura mat = new MFactura();
                mat.ActualizarFactura(factura);
                MostarMensaje("Materia Modificada");
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
                mat.EliminarFactura(Convert.ToInt32(txtCodigo1.Text));
                MostarMensaje("Factura Eliminada");
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
                var factura = mat.BuscarFactura(Convert.ToInt32(txtCodigo1.Text));
                if (factura != null)
                {
                    txtCodigo.Text = factura.Codigo.ToString();
                    txtNombre.Text = factura.Nombre;
                    txtTotal.Text = factura.Total.ToString();
                    txtDescuento.Text = factura.Descuento.ToString();
                    txtComentarios.Text = factura.Comentarios.ToString();
                    divMantenimiento.Visible = true;
                    txtCodigo1.Enabled = false;

                }
                else
                {
                    MostarMensajeError("La materia no existe");
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

        protected void txtCodigo1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}