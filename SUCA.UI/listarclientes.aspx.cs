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
    public partial class listarclientes : System.Web.UI.Page
    {
        ICliente clie = new MCliente();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                     dgvCliente.DataSource = clie.ListarClientes();
                    dgvCliente.DataBind();
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


        protected void btnInsertarc_Click(object sender, EventArgs e)

        {
            Response.Redirect("InsertarClientes");
        }


        protected void btnMantenimientoc_Click(object sender, EventArgs e)
        {
            Response.Redirect("MantenCliente");

        }
    }
}