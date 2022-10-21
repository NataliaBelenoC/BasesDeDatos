using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoDB
{
    public class Conexion
    {
        public MySqlConnection MyCon;
        public void conectar()
        {
            string server = "localhost";
            string database = "proyectodb";
            string user = "root";
            string port = "3306";
            string pwd = "jagua123456";
            string cadenaConexion = "server=" + server + ";database=" + database + ";" + "Uid=" + user + ";pwd=" + pwd + ";port=" + port + ";";
            MyCon = new MySqlConnection(cadenaConexion);
            MyCon.Open();
        }
    }
}
