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
    public class MMateriaPrima : IMateriaPrima
    {

        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MMateriaPrima()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public List<Materia> ListarMateria()
        {
            return _db.Select<Materia>();
        }

        public Materia BuscarMateria(int Codigo)
        {

            return _db.Select<Materia>(x => x.Codigo == Codigo).FirstOrDefault();
        }

        public void InsertarMateria(Materia materia)
        {
            _db.Insert(materia);
        }

        public void ActualizarMateria(Materia materia)
        {
            _db.Update(materia);
        }

        public void EliminarMateria(int Codigo)
        {
            _db.Delete<Materia>(x => x.Codigo == Codigo);
        }
    }
}
