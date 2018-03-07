using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.OrmLite;
using SUCA.DATA;
using SUCA.DAL.Interfaces;
using System.Data;

namespace SUCA.DAL.Metodos
{
    public class MUsuario : IUsuario
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MUsuario()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public Usuario BuscarUsuario(string usuario, string contra)
        {
            return _db.Select<Usuario>(x => x.Username == usuario && x.Password == contra).FirstOrDefault();
        }

        public void insertarUsuario(Usuario usuario)
        {
            _db.Insert(usuario);
        }
    }
}
