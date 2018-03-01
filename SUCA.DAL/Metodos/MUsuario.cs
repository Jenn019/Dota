using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.OrmLite;
using SUCA.DATA;
using SUCA.DAL.Interfaces;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace SUCA.DAL.Metodos
{
    public class MUsuario : IUsuario
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MUsuario()
        {
            /*_conexion = new OrmLiteConnectionFactory(BD.Default.conexion,);
            _db = _conexion.Open();*/

            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;

            myConnectionString = "server=127.0.0.1;uid=root;" +
                "pwd=root123;database=zorro";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public Usuario BuscarUsuario(string usuario, string contra)
        {
            return _db.Select<Usuario>(x => x.Username == usuario && x.Password == contra).FirstOrDefault();
        }

        public void insertarUsuario(Usuario usuario)
        {
            _db.Insert(usuario);
        }
    }
}


/*MySql.Data.MySqlClient.MySqlConnection conn;
string myConnectionString;

myConnectionString = "server=127.0.0.1;uid=root;" +
    "pwd=12345;database=test";

try
{
    conn = new MySql.Data.MySqlClient.MySqlConnection();
    conn.ConnectionString = myConnectionString;
    conn.Open();
}
catch (MySql.Data.MySqlClient.MySqlException ex)
{
    MessageBox.Show(ex.Message);
}*/