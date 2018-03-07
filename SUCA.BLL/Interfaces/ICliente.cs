using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUCA.DATA;

namespace SUCA.BLL.Interfaces
{
    public interface ICliente
    {
        List<Cliente> ListarClientes();
        Cliente BuscarCliente(int IdCliente);
        void InsertarCliente(Cliente cliente);
        void ActualizarCliente(Cliente cliente);
        void EliminarCliente(int IdCliente);

    }
}
