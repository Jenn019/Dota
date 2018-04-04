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
    public partial class InsertarMateria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                Materia materia = new Materia

                {
                    Codigo = Convert.ToInt32(txtCodigo.Text),
                    Nombre = txtNombre.Text,
                    Cantidad = Convert.ToInt32(txtCantidad.Text),
                    Costo = Convert.ToInt32(txtCosto.Text),
                   

                };
                IMateriaPrima mat = new MMateriaPrima();
                mat.InsertarMateria(materia);
                MostarMensaje("Materia Prima Insertada");
            }

            catch (Exception)
            {
                MostarMensajeError("Ocurrio un error");
            }

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListarMateria");

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