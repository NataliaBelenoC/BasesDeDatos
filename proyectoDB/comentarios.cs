using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace proyectoDB
{
    public partial class comentarios : Form
    {
        Conexion conexion = new Conexion();
        public comentarios()
        {
            InitializeComponent();
            conexion.conectar();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string queryc = "";
            string mensajeError = "";
            if (txtCorreoElectronico.Text == "")
            {
                mensajeError = mensajeError + "El correo electronico no puede estar vacio";
            }
            if (txtNombre.Text == "")
            {
                mensajeError = mensajeError + "El nombre no puede estar vacio";
            }
            if (rtbDescripcion.Text == "")
            {
                mensajeError = mensajeError + "la decripcion no puede estar vacio";
            }
            if (mensajeError == "")
            {
                MySqlCommand formulariocontacto = conexion.MyCon.CreateCommand();
                formulariocontacto.CommandText = "INSERT INTO formulariocontacto(fc_nombres,fc_correo) VALUES" + "('" + txtNombre.Text + "','" + txtCorreoElectronico.Text + "')";
                formulariocontacto.ExecuteNonQuery();
                string wherefc = " where fc_correo like '%" + txtCorreoElectronico.Text + "%' ";
                string querryfc = "select fc_id from formulariocontacto" + wherefc + ";";
                MySqlCommand idformulariocontacto = new MySqlCommand(querryfc, conexion.MyCon);
                idformulariocontacto.CommandTimeout = 60;
                MySqlDataReader reader;
                int idfc = 0;
                try
                {
                    reader = idformulariocontacto.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            idfc = reader.GetInt32(0);
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
                try
                {
                    MySqlCommand comentario = conexion.MyCon.CreateCommand();
                    comentario.CommandText = "insert into comentario " + "(c_puntuacion,c_descripcion,fk_formulariocontacto) values " + "('" + numPuntuacion.Value + "','" + rtbDescripcion.Text + "','" + idfc + "','" + lbliniciativaid.Text + "')";
                    comentario.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                MessageBox.Show(mensajeError);
            }
        }
    }
}
