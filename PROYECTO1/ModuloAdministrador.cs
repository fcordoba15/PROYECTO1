//Biblioteca que se van a usar
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
    public partial class ModuloAdministrador : Form
    {
        public ModuloAdministrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();//Ocultar ventana actual
            ConsultaPokEnt m1 = new ConsultaPokEnt();//Crear ventana
            m1.Show();// Mostrar ventana
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();//Ocultar ventana actual
            TipoMovAdmin m1 = new TipoMovAdmin();//Crear ventana
            m1.Show();// Mostrar ventana
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();//Ocultar ventana actual
            G_Admin_Usuarios m1 = new G_Admin_Usuarios();//Crear ventana
            m1.Show();// Mostrar ventana
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();//Ocultar ventana actual
            G_Admin_Entrenadores m1 = new G_Admin_Entrenadores();//Crear ventana
            m1.Show();// Mostrar ventana
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();//Ocultar ventana actual
            VentanaInicio v4 = new VentanaInicio();//Crear ventana
            v4.Show();// Mostrar ventana
        }
    }
}
