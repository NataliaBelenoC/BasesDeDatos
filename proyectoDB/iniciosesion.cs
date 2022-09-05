namespace proyectoDB
{
    public partial class iniciosesion : Form
    {
        public iniciosesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comentarios comentarios = new comentarios();
            this.Hide();
            comentarios.Show();
        }
    }
}