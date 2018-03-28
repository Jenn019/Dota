using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace SUCA.DATA
{
    public class Producto
    {
        [AutoIncrement]
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public string Proveedor { get; set; }
    }
}
