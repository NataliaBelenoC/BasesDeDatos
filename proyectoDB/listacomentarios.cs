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
    public partial class listacomentarios : Form
    {
        Conexion conexion = new Conexion();
        public listacomentarios()
        {
            InitializeComponent();
            conexion.conectar();
            recargartabla();
        }

        private void listacomentarios_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void recargartabla()
        {
            string query = "SELECT c_id, fc_nombres, fc_correo, c_puntuacion, c_descripcion FROM comentario, formulariocontacto, iniciativa WHERE fK_formulariocontacto = fc_id and fk_iniciativa = i_id and fk_iniciativa = " + iniciativaid.Text + ";";
            MySqlCommand comandoDB = new MySqlCommand(query, conexion.MyCon);

            comandoDB.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = comandoDB.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = reader.GetString(0);
                        dataGridView1.Rows[n].Cells[1].Value = reader.GetString(1);
                        dataGridView1.Rows[n].Cells[2].Value = reader.GetString(2);
                        dataGridView1.Rows[n].Cells[3].Value = reader.GetString(3);
                        dataGridView1.Rows[n].Cells[4].Value = reader.GetString(4);
                        //MessageBox.Show(reader.GetString(0));
                    }
                }
                else
                {
                    Console.WriteLine("No hay comentarios");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            comentarios comentarios = new comentarios();
            comentarios.lbliniciativaid.Text = iniciativaid.Text;
            comentarios.lbliniciativaid.Visible = false;
            comentarios.Show();
        }
    }
}
