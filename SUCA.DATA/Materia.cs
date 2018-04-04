using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace SUCA.DATA
{
   public class Materia
    {
        [AutoIncrement]
        public int IdMateria { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public int Costo { get; set; }
        public int Codigo { get; set; }

    }
}
