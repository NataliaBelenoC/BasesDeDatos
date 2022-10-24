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
    public partial class TablaIniciativas : Form
    {
        Conexion conexion = new Conexion();
        public TablaIniciativas()
        {
            InitializeComponent();
            conexion.conectar();
            recargartabla();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            recargartabla();
        }

        private void TablaIniciativas_Load(object sender, EventArgs e)
        {

        }

        private void recargartabla()
        {
            string query = "SELECT fi_id, fi_nombre FROM formularioiniciativa;";
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
                        int n = dginiciativas.Rows.Add();
                        dginiciativas.Rows[n].Cells[0].Value = reader.GetString(0);
                        dginiciativas.Rows[n].Cells[1].Value = reader.GetString(1);
                        //MessageBox.Show(reader.GetString(0));
                    }
                }
                else
                {
                    Console.WriteLine("No hay iniciativas");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            listacomentarios listacomentarios = new listacomentarios();
            listacomentarios.iniciativaid.Text = Convert.ToString(numericUpDown1.Value);
            listacomentarios.iniciativaid.Visible = false;
            listacomentarios.Show();
        }
    }
}