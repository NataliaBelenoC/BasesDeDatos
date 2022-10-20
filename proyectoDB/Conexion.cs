using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoDB
{
    internal class Conexion
    {
        MySqlConnection MyCon;
        public void conectar()
        {
            string server = "localhost";
            string database = "proyectodb";
            string user = "root";
            string pwd = "jagua123456";
            string cadenaConexion = "server=" + server + ";database=" + database + ";" + "Uid=" + user + ";pwd=" + pwd + ";";
            MyCon = new MySqlConnection(cadenaConexion);
            MyCon.Open();
        }
    }
}
