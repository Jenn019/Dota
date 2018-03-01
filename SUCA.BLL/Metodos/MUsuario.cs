using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUCA.DATA;
using SUCA.BLL.Interfaces;

namespace SUCA.BLL.Metodos
{
    public class MUsuario : IUsuario
    {
        DAL.Interfaces.IUsuario usu;
        public MUsuario()
        {
            usu = new DAL.Metodos.MUsuario();
        }

        public Usuario BuscarUsuario(string username, string password)
        {
            return usu.BuscarUsuario(username, password);
        }

        public void insertarUsuario(Usuario usuario)
        {
            usu.insertarUsuario(usuario);
        }

    }
}
