using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUCA.DATA;

namespace SUCA.BLL.Interfaces
{
    public interface IUsuario
    {
        Usuario BuscarUsuario(string username, string password);
        void insertarUsuario(DATA.Usuario usuario);
    }
}
