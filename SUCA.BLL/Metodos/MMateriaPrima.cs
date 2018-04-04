using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUCA.DATA;
using SUCA.BLL.Interfaces;

namespace SUCA.BLL.Metodos
{
    public class MMateriaPrima : IMateriaPrima
    {

        private DAL.Interfaces.IMateriaPrima c;
        public MMateriaPrima()
        {

            c = new DAL.Metodos.MMateriaPrima();
        }

        public List<Materia> ListarMateria()
        {
            return c.ListarMateria();
        }

        public Materia BuscarMateria(int IdMateria)
        {
            return c.BuscarMateria(IdMateria);
        }
        public void InsertarMateria(Materia materia)
        {
            c.InsertarMateria(materia);
        }

        public void ActualizarMateria(Materia materia)
        {
            c.ActualizarMateria(materia);
        }
        public void EliminarMateria(int IdMateria)
        {
            c.EliminarMateria(IdMateria);
        }
    }
    }
