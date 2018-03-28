using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUCA.DATA;

namespace SUCA.DAL.Interfaces
{
    public interface IProducto
    {
        List<Producto> ListarProducto();
        Producto BuscarProducto(int IdProducto);
        void InsertarProducto(Producto producto);
        void ActualizarProducto(Producto producto);
        void EliminarProducto(int IdProducto);
    }
}
