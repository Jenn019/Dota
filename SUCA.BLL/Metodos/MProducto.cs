using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUCA.DATA;
using SUCA.BLL.Interfaces;

namespace SUCA.BLL.Metodos
{
    public class MProducto : IProducto
    {

        private DAL.Interfaces.IProducto c;
        public MProducto()
        {

            c = new DAL.Metodos.MProducto();
        }

        public List<Producto> ListarProducto()
        {
            return c.ListarProducto();
        }

        public Producto BuscarProducto(int IdProducto)
        {
            return c.BuscarProducto(IdProducto);
        }
        public void InsertarProducto(Producto producto)
        {
            c.InsertarProducto(producto);
        }

        public void ActualizarProducto(Producto producto)
        {
            c.ActualizarProducto(producto);
        }
        public void EliminarProducto(int IdProducto)
        {
            c.EliminarProducto(IdProducto);
        }
    }
}
