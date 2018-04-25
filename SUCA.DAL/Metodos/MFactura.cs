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
    public class MFactura : IFactura
    {

        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MFactura()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public List<Factura> ListarFactura()
        {
            return _db.Select<Factura>();
        }

        public Factura BuscarFactura(int Codigo)
        {

            return _db.Select<Factura>(x => x.Codigo == Codigo).FirstOrDefault();
        }

        public void InsertarFactura(Factura factura)
        {
            _db.Insert(factura);
        }

        public void ActualizarFactura(Factura factura)
        {
            _db.Update(factura);
        }

        public void EliminarFactura(int Codigo)
        {
            _db.Delete<Factura>(x => x.Codigo == Codigo);
        }
    }
}
