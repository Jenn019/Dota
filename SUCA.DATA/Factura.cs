using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace SUCA.DATA
{
    public class Factura
    {
        [AutoIncrement]
        public int IdFactura { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Total { get; set; }
        public int Descuento { get; set; }
        public string Comentarios { get; set; }
    }
}
