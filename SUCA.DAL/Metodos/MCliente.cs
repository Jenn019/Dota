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
    public class MCliente : ICliente
    {

        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MCliente()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public List<Cliente> ListarClientes()
        {
            return _db.Select<Cliente>();
        }

        public Cliente BuscarCliente(int Cedula)
        {

            return _db.Select<Cliente>(x => x.Cedula == Cedula).FirstOrDefault();
        }

        public void InsertarCliente(Cliente cliente)
        {
            _db.Insert(cliente);
        }

        public void ActualizarCliente(Cliente clientes)
        {
            _db.Update(clientes);
        }

        public void EliminarCliente(int Cedula)
        {
            _db.Delete<Cliente>(x => x.Cedula == Cedula);
        }
    }
}
