using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUCA.DATA;
using SUCA.BLL.Interfaces;

namespace SUCA.BLL.Metodos
{
    public class MProveedor : IProveedor
    {

        private DAL.Interfaces.IProveedor c;
        public MProveedor()
        {

            c = new DAL.Metodos.MProveedor();
        }

        public List<Proveedor> ListarProveedores()
        {
            return c.ListarProveedores();
        }

        public Proveedor BuscarProveedor(int IdProveedor)
        {
            return c.BuscarProveedor(IdProveedor);
        }
        public void InsertarProveedor(Proveedor proveedor)
        {
            c.InsertarProveedor(proveedor);
        }

        public void ActualizarProveedor(Proveedor proveedor)
        {
            c.ActualizarProveedor(proveedor);
        }
        public void EliminarProveedor(int IdProveedor)
        {
            c.EliminarProveedor(IdProveedor);
        }

    }
}
