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
    public partial class MantenMateria : System.Web.UI.Page
    {
        IMateriaPrima mat = new MMateriaPrima();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var materia = mat.BuscarMateria(Convert.ToInt32(txtCodigo1.Text));
                if (materia != null)
                {
                    txtCodigo.Text = materia.Codigo.ToString();
                    txtNombre.Text = materia.Nombre;
                    txtCosto.Text = materia.Costo.ToString();
                    txtCantidad.Text = materia.Cantidad.ToString();
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

        protected void btnModificarc_Click(object sender, EventArgs e)
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
                mat.ActualizarMateria(materia);
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
                mat.EliminarMateria(Convert.ToInt32(txtCodigo1.Text));
                MostarMensaje("Materia Eliminada");
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