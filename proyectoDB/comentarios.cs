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
                query = "insert into formulariocontacto " +
                    "(fc_nombres,fc_correo) values " +
                    "('" + txtNombre.Text + "','" + txtCorreoElectronico.Text + "')";
                MySqlCommand formulariocontacto = new MySqlCommand(query, conexion.MyCon);
                formulariocontacto.CommandTimeout = 60;
                string where = "where fc_correo like '%" + txtCorreoElectronico.Text + "%' ";
                string querry = "select fc_id from formulariocontacto" + where + ";";
                MySqlCommand idformulariocontacto = new MySqlCommand(querry, conexion.MyCon);
                idformulariocontacto.CommandTimeout = 60;
                MySqlDataReader reader;
                try
                {
                    reader = idformulariocontacto.ExecuteReader();
                    if (reader.HasRows)
                    {

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
