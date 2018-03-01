using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUCA.DATA;

namespace SUCA.DAL.Interfaces
{
    public interface IUsuario
    {

        DATA.Usuario BuscarUsuario(string usuario, string contra);

        void insertarUsuario(DATA.Usuario usuario);
    }
}
