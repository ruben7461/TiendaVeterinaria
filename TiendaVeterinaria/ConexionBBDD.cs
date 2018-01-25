using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Odbc;
using MySql.Data.Types;
using MySql.Data.MySqlClient;

namespace TiendaVeterinaria
{
    class ConexionBBDD

    {

        public static MySqlConnection conectar()
        {
            MySqlConnection conexion = new MySqlConnection("Server = 127.0.0.1; Database = veterinario; Uid = root; Pwd = ; Port = 3306");
            return conexion;
        }
    }
}
