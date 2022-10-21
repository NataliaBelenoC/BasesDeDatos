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
    public partial class RegistroIniciativas : Form
    {
        public RegistroIniciativas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Iniciativas iniciativa = new Iniciativas();
            iniciativa.Nombrei = txtNombrei.Text;
            iniciativa.SituacionProblema = richTextSituacion.Text;
            iniciativa.MarcoConceptual = richTextMarcoConcep.Text;
            iniciativa.MarcoTecnologico = richTextMarcoTec.Text;
            iniciativa.EstadoArte = richTextEstadoArte.Text;
            iniciativa.Metodología = richTextMetodologia.Text;
            iniciativa.Objetivos = richTextObjetivos.Text;
            iniciativa.Justificacion = richTextJustificacion.Text;
            iniciativa.Referencias = richTextReferencias.Text;

            try
            {

                ControlIniciativas controlIniciativas = new ControlIniciativas();
                string respuesta = controlIniciativas.ctrlRegistro(iniciativa);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
