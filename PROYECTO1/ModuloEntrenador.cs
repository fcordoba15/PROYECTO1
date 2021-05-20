using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO1
{
    public partial class ModuloEntrenador : Form
    {
        public ModuloEntrenador()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            GestionMov m1 = new GestionMov();
            this.Hide();
            m1.ShowDialog();
            this.Show();
        }

        private void pokemonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            G_Pok_Ent m1 = new G_Pok_Ent();
            this.Hide();
            m1.ShowDialog();
            this.Show();
        }
    }
}
