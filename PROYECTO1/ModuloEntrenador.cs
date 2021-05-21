using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

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
            ConsultaPokEnt m1 = new ConsultaPokEnt();
            this.Hide();
            m1.ShowDialog();
            this.Show();
        }

        private void bitacora_Click(object sender, EventArgs e)
        {
            BitacoraEntrenador m1 = new BitacoraEntrenador();
            this.Hide();
            m1.ShowDialog();
            this.Show();
        }

        private void pokemonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionPokemonesEntrenador m1 = new GestionPokemonesEntrenador();
            this.Hide();
            m1.ShowDialog();
            this.Show();
        }

        private void usuariosAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            G_Admin_Usuarios m1 = new G_Admin_Usuarios();
            this.Hide();
            m1.ShowDialog();
            this.Show();

        }
    }
}
