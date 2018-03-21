using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUCA.DATA;

namespace SUCA.BLL.Interfaces
{
    public interface IProveedor
    {
        List<Proveedor> ListarProveedores();
        Proveedor BuscarProveedor(int IdProveedor);
        void InsertarProveedor(Proveedor proveedor);
        void ActualizarProveedor(Proveedor proveedor);
        void EliminarProveedor(int IdProveedor);
    }
}
