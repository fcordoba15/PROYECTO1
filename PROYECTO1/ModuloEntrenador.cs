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
            VentanaRoles v4 = new VentanaRoles();
            v4.Show();
            this.Hide();
        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            GestionMov m1 = new GestionMov();
            this.Hide();
            m1.Show();
        }

        private void bitacora_Click(object sender, EventArgs e)
        {
            BitacoraEntrenador m1 = new BitacoraEntrenador();
            this.Hide();
            m1.Show();
        }

        private void pokemonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionPokemonesEntrenador m1 = new GestionPokemonesEntrenador();
            this.Hide();
            m1.Show();
        }


    }
}
