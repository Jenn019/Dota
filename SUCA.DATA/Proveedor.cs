using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace SUCA.DATA
{
   public class Proveedor
    {
        [AutoIncrement]
        public int IdProveedor { get; set; }
        public string Empresa { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
    }
}
