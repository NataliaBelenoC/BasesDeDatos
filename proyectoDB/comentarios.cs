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
            string query = "";
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
                mensajeError = mensajeError + "La edad no puede estar vacio";
            }
            if (mensajeError == "")
            {
                string where = "where";
                if (txtCorreoElectronico.Text != null)
                {
                    where += " fc_correo like '%" + txtCorreoElectronico.Text + "%' ";
                }
                else
                {
                    MessageBox.Show("hay almenos un campo vacio del correo y de la contraseña");
                }
                if (txtNombre.Text != null)
                {
                    where += " and fc_nombres like '%" + txtNombre.Text + "%' ";
                }
                else
                {
                    MessageBox.Show("hay almenos un campo vacio del correo y de la contraseña");
                }
                string querry = "select fc_correo, fc_nombres from formulariocontacto" + where + ";";
                MySqlCommand busquedafc = new MySqlCommand(querry, conexion.MyCon);
                busquedafc.CommandTimeout = 60;
                if (busquedafc == null)
                {
                    query = "insert into formulariocontacto " +
                    "(fc_nombres,fc_correo) values " +
                    "('" + txtNombre.Text + "','" + txtCorreoElectronico.Text + "')";
                    MySqlCommand formulariocontacto = new MySqlCommand(query, conexion.MyCon);
                    formulariocontacto.CommandTimeout = 60;
                }
                string wherefc = "where fc_correo like '%" + txtCorreoElectronico.Text + "%' ";
                string querryfc = "select fc_id from formulariocontacto" + wherefc + ";";
                MySqlCommand idformulariocontacto = new MySqlCommand(querryfc, conexion.MyCon);
                idformulariocontacto.CommandTimeout = 60;
                MySqlDataReader reader;
                int idfc;
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
            }
            else
            {
                MessageBox.Show(mensajeError);
            }
        }
    }
}
