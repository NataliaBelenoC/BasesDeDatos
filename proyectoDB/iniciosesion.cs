using MySql.Data.MySqlClient;

namespace proyectoDB
{
    public partial class iniciosesion : Form
    {
        Conexion conexion = new Conexion();

        public iniciosesion()
        {
            InitializeComponent();
            conexion.conectar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string where = "where";
            if (txtCorreoElectronico != null)
            {
                where += " e_correoelectronico like '%" + txtCorreoElectronico.Text + "%' ";
            }
            else
            {
                MessageBox.Show("hay almenos un campo vacio del correo y de la contraseña");
            }
            if (txtContrasena != null)
            {
                where += " and e_contrasena like '%" + txtContrasena.Text + "%' ";
            }
            else
            {
                MessageBox.Show("hay almenos un campo vacio del correo y de la contraseña");
            }
            string querry = "select e_correoelectronico, e_contrasena from estudiante" + where + ";";
            MySqlCommand estudiantes = new MySqlCommand(querry, conexion.MyCon);
            estudiantes.CommandTimeout = 60;
            string whereu = "where";
            if (txtCorreoElectronico != null)
            {
                whereu += " u_correoelectronico like '%" + txtCorreoElectronico.Text + "%' ";
            }
            else
            {
                MessageBox.Show("hay almenos un campo vacio del correo y de la contraseña");
            }
            if (txtContrasena != null)
            {
                whereu += " and u_contrasena like '%" + txtContrasena.Text + "%' ";
            }
            else
            {
                MessageBox.Show("hay almenos un campo vacio del correo y de la contraseña");
            }
            string querryu = "select u_correoelectronico, u_contrasena from usuario" + whereu + ";";
            MySqlCommand usuarios = new MySqlCommand(querryu, conexion.MyCon);
            usuarios.CommandTimeout = 60;
            if (estudiantes != null)
            {
                this.Hide();
                comentarios comentarios = new comentarios();
                comentarios.Show();
            }
            else
            {
               if(usuarios != null)
                {
                    this.Hide();
                    comentarios comentarios = new comentarios();
                    comentarios.Show();
                }
                else
                {
                    MessageBox.Show("hay almenos un campo incorrecto del correo y de la contraseña");
                }
            }
        }
    }
}