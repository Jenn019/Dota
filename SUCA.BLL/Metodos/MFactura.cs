using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUCA.DATA;
using SUCA.BLL.Interfaces;

namespace SUCA.BLL.Metodos
{
    public class MFactura : IFactura
    {

        private DAL.Interfaces.IFactura c;
        public MFactura()
        {

            c = new DAL.Metodos.MFactura();
        }

        public List<Factura> ListarFactura()
        {
            return c.ListarFactura();
        }

        public Factura BuscarFactura(int IdFactura)
        {
            return c.BuscarFactura(IdFactura);
        }
        public void InsertarFactura(Factura factura)
        {
            c.InsertarFactura(factura);
        }

        public void ActualizarFactura(Factura factura)
        {
            c.ActualizarFactura(factura);
        }
        public void EliminarFactura(int IdFactura)
        {
            c.EliminarFactura(IdFactura);
        }
    }
}
