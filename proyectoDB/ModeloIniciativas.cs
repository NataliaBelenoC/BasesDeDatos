using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoDB
{
    class ModeloIniciativas
    {
        Conexion conexion = new Conexion();
        public int registroiniciativa(Iniciativas iniciativa)
        {
            conexion.conectar();

            string sql = "INSERT INTO formularioiniciativa (fi_nombre, fi_situacionproblema, fi_marcoconceptual, fi_marcotecnologico, fi_estadoarte, fi_metodologia, fi_objetivos, fi_justificacion, fi_referencias) VALUES(@usuario, @password, @nombre, @apellido)";
            MySqlCommand comando = new MySqlCommand(sql, conexion.MyCon);
            comando.Parameters.AddWithValue("@nombrei", iniciativa.Nombrei);
            comando.Parameters.AddWithValue("@situacionproblema", iniciativa.SituacionProblema);
            comando.Parameters.AddWithValue("@marcoconceptual", iniciativa.MarcoConceptual);
            comando.Parameters.AddWithValue("@marcotecnologico", iniciativa.MarcoTecnologico);
            comando.Parameters.AddWithValue("@estadoarte", iniciativa.EstadoArte);
            comando.Parameters.AddWithValue("@metodología", iniciativa.Metodología);
            comando.Parameters.AddWithValue("@objetivos", iniciativa.Objetivos);
            comando.Parameters.AddWithValue("@justificacion", iniciativa.Justificacion);
            comando.Parameters.AddWithValue("@referencias", iniciativa.Referencias);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }

        public bool existeIniciativa(string iniciativa)
        {
            MySqlDataReader reader;
            conexion.conectar();

            string sql = "SELECT fi_nombre FROM formularioiniciativa WHERE fi_nombre LIKE @Nombrei";
            MySqlCommand comando = new MySqlCommand(sql, conexion.MyCon);
            comando.Parameters.AddWithValue("@Nombrei", iniciativa);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
