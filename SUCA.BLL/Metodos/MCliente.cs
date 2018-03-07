using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUCA.DATA;
using SUCA.BLL.Interfaces;

namespace SUCA.BLL.Metodos
{
    public class MCliente : ICliente
    {

        private DAL.Interfaces.ICliente c;
        public MCliente()
        {

            c = new DAL.Metodos.MCliente();
        }

        public List<Cliente> ListarClientes()
        {
            return c.ListarClientes();
        }

        public Cliente BuscarCliente(int IdCliente)
        {
            return c.BuscarCliente(IdCliente);
        }
        public void InsertarCliente(Cliente cliente)
        {
            c.InsertarCliente(cliente);
        }

        public void ActualizarCliente(Cliente cliente)
        {
            c.ActualizarCliente(cliente);
        }
        public void EliminarCliente(int Cedula)
        {
            c.EliminarCliente(Cedula);
        }
    }
    }
