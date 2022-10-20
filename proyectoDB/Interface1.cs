using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace proyectoDB
{
    public interface Interface1
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
