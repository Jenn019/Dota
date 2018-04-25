using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUCA.DATA;

namespace SUCA.DAL.Interfaces
{
    public interface IFactura
    {
        List<Factura> ListarFactura();
        Factura BuscarFactura(int IdFactura);
        void InsertarFactura(Factura factura);
        void ActualizarFactura(Factura factura);
        void EliminarFactura(int IdFactura);
    }
}
