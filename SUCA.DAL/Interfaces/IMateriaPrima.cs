using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUCA.DATA;

namespace SUCA.DAL.Interfaces
{
    public interface IMateriaPrima
    {
        List<Materia> ListarMateria();
        Materia BuscarMateria(int IdMateria);
        void InsertarMateria(Materia materia);
        void ActualizarMateria(Materia materia);
        void EliminarMateria(int IdMateria);
    }
}
