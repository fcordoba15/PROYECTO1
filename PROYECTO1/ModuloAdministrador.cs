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
            this.Hide();
            ConsultaPokEnt m1 = new ConsultaPokEnt();
            m1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TipoMovAdmin m1 = new TipoMovAdmin();
            m1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            G_Admin_Usuarios m1 = new G_Admin_Usuarios();
            m1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            G_Admin_Entrenadores m1 = new G_Admin_Entrenadores();
            m1.Show();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaInicio v4 = new VentanaInicio();
            v4.Show();
        }
    }
}
