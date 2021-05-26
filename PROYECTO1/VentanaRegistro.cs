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
    public partial class VentanaRegistro : Form
    {
        public VentanaRegistro()
        {
            InitializeComponent();
        }

        private void Registrar_cliente_Click(object sender, EventArgs e)
        {
            this.Hide();

            RegistroCliente v1 = new RegistroCliente();

            v1.Show();
        }

        private void Registrar_entrenador_Click(object sender, EventArgs e)
        {
            RegistroEntrenador v1 = new RegistroEntrenador();
            this.Hide();
            v1.Show();
        }

        private void Registrar_administrador_Click(object sender, EventArgs e)
        {
            LoginAdministrador2 v1 = new LoginAdministrador2();

            this.Hide();

            v1.Show();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            VentanaInicio v1 = new VentanaInicio();
            this.Hide();
            v1.Show();
        }
    }
}
