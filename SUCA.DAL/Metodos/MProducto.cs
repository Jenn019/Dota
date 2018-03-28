using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUCA.DATA;
using SUCA.DAL.Interfaces;
using System.Data;
using ServiceStack.OrmLite;


namespace SUCA.DAL.Metodos
{
    public class MProducto : IProducto
    {

        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MProducto()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public List<Producto> ListarProducto()
        {
            return _db.Select<Producto>();
        }

        public Producto BuscarProducto(int IdProducto)
        {

            return _db.Select<Producto>(x => x.IdProducto == IdProducto).FirstOrDefault();
        }

        public void InsertarProducto(Producto producto)
        {
            _db.Insert(producto);
        }

        public void ActualizarProducto(Producto producto)
        {
            _db.Update(producto);
        }

        public void EliminarProducto(int IdProducto)
        {
            _db.Delete<Producto>(x => x.IdProducto == IdProducto);
        }
    }
}
