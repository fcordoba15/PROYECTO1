//Bibliotecas que se van a utilizar
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
            VentanaRoles v4 = new VentanaRoles();//Crear ventana
            v4.Show();// Mostrar ventana
            this.Hide();//Ocultar ventana actual
        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            GestionMov m1 = new GestionMov();//Crear ventana
            this.Hide();//Ocultar ventana actual
            m1.Show();// Mostrar ventana
        }

        private void bitacora_Click(object sender, EventArgs e)
        {
            BitacoraEntrenador m1 = new BitacoraEntrenador();//Crear ventana
            this.Hide();//Ocultar ventana actual
            m1.Show();// Mostrar ventana
        }

        private void pokemonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionPokemonesEntrenador m1 = new GestionPokemonesEntrenador();//Crear ventana
            this.Hide();//Ocultar ventana actual
            m1.Show();// Mostrar ventana
        }


    }
}
