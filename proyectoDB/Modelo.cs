using MySql.Data.MySqlClient;
using proyectoDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoDB
{
    class Modelo
    {
        Conexion conexion = new Conexion();
        public int registro(Usuarios usuario)
        {
            conexion.conectar();

            string sql = "INSERT INTO usuario (u_correoelectronico, u_contrasena, u_nombres, u_apellidos) VALUES(@usuario, @password, @nombre, @apellido)";
            MySqlCommand comando = new MySqlCommand(sql, conexion.MyCon);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("@password", usuario.Password);
            comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@apellido", usuario.Apellido);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }

        public bool existeUsuario(string usuario)
        {
            MySqlDataReader reader;
            conexion.conectar();

            string sql = "SELECT u_correoelectronico FROM usuario WHERE u_correoelectronico LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion.MyCon);
            comando.Parameters.AddWithValue("@usuario", usuario);

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

        public Usuarios porUsuario(string usuario)
        {
            MySqlDataReader reader;
            conexion.conectar();

            string sql = "SELECT u_contrasena, u_nombres, u_apellidos FROM usuario WHERE u_correoelectronico LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion.MyCon);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            Usuarios usr = null;

            while (reader.Read())
            {
                usr = new Usuarios();
                usr.Password = reader["u_contrasena"].ToString();
                usr.Nombre = reader["u_nombres"].ToString();
                usr.Apellido = reader["u_apellidos"].ToString();
            }
            return usr;
        }
    }
}
