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
        public grupo()
        {
            InitializeComponent();
        }

        private void lblmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menu = new menu();
            menu.lblcorreo.Visible = false;
            menu.Show();
        }
    }
}
