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
    public partial class InsertarFactura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                Factura factura = new Factura

                {
                    Codigo = Convert.ToInt32(txtCodigo.Text),
                    Nombre = txtNombre.Text,
                    Total = Convert.ToInt32(txtTotal.Text),
                    Descuento = Convert.ToInt32(txtDescuento.Text),
                    Comentarios = txtComentarios.Text,


                };
                IFactura mat = new MFactura();
                mat.InsertarFactura(factura);
                MostarMensaje("Factura Insertada");
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

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListarMateria");
        }
    }
}