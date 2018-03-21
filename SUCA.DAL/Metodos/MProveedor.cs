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
    public class MProveedor : IProveedor
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MProveedor()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public List<Proveedor> ListarProveedores()
        {
            return _db.Select<Proveedor>();
        }

        public Proveedor BuscarProveedor(int IdProveedor)
        {

            return _db.Select<Proveedor>(x => x.IdProveedor == IdProveedor).FirstOrDefault();
        }

        public void InsertarProveedor(Proveedor proveedor)
        {
            _db.Insert(proveedor);
        }

        public void ActualizarProveedor(Proveedor proveedor)
        {
            _db.Update(proveedor);
        }

        public void EliminarProveedor(int IdProveedor)
        {
            _db.Delete<Proveedor>(x => x.IdProveedor == IdProveedor);
        }
    }
}
