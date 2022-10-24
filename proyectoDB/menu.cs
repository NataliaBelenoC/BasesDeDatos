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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void lblcerrarsesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            iniciosesion iniciosesion = new iniciosesion();
            iniciosesion.Show();
        }

        private void lbleditarperfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroUsuarios registroUsuarios = new RegistroUsuarios();
            registroUsuarios.lblcorreo.Text = this.lblcorreo.Text;
            registroUsuarios.lblcorreo.Visible = false;
            registroUsuarios.btnRegistrar.Visible = false;
            registroUsuarios.Show();
        }

        private void btnregistroiniciativa_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroIniciativas registroIniciativas = new RegistroIniciativas();
            registroIniciativas.Show();
        }

        private void btncreargrupo_Click(object sender, EventArgs e)
        {
            this.Hide();
            grupo grupo = new grupo();
            grupo.Show();
        }

        private void btnlistasiniciativa_Click(object sender, EventArgs e)
        {
            this.Hide();
            TablaIniciativas tablaIniciativas = new TablaIniciativas(); 
            tablaIniciativas.Show();
        }
    }
}
