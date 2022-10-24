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
                formulariocontacto.CommandText = "INSERT INTO formulariocontacto(fc_nombres,fc_correo) VALUES" + "('" + txtlider.Text + "')";
                formulariocontacto.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show(mensajeError);
            }

        }
    }
}
