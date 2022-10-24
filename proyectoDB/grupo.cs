using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoDB
{
    public partial class grupo : Form
    {
        Conexion conexion = new Conexion();
        public grupo()
        {
            InitializeComponent();
            conexion.conectar();
        }

        private void lblmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menu = new menu();
            menu.lblcorreo.Visible = false;
            menu.Show();
        }

        private void btnlider_Click(object sender, EventArgs e)
        {
            string mensajeError = "";
            if (txtlider.Text == "")
            {
                mensajeError = mensajeError + "El correo electronico no puede estar vacio";
            }
            if (mensajeError == "")
            {
                MySqlCommand formulariocontacto = conexion.MyCon.CreateCommand();
                formulariocontacto.CommandText = "INSERT INTO grupo(fk_lider) VALUES" + "('" + txtlider.Text + "')";
                formulariocontacto.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show(mensajeError);
            }

        }

        private void btnmiembros_Click(object sender, EventArgs e)
        {
            string where = " where fk_lider like '%" + txtlider.Text + "%' ";
            string querry = "select g_id from grupo" + where + ";";
            MySqlCommand idgrupo = new MySqlCommand(querry, conexion.MyCon);
            idgrupo.CommandTimeout = 60;
            MySqlDataReader reader;
            int idg = 0;
            try
            {
                reader = idgrupo.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        idg = reader.GetInt32(0);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            try
            {
                MySqlCommand comentario = conexion.MyCon.CreateCommand();
                comentario.CommandText = "insert into comentario " + "(fk_estudiante,fk_grupo) values " + "('" + txtmiembros.Text + "','" + idg + "')";
                comentario.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroIniciativas registroIniciativas = new RegistroIniciativas();
            registroIniciativas.Show();
        }
    }
}
