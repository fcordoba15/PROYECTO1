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
    public partial class VentanaRoles : Form
    {
        public VentanaRoles()
        {
            InitializeComponent();
        }

        private void iniciar_entrenador_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginEntrenador v1 = new LoginEntrenador();

            v1.Show();
        }

        private void iniciar_cliente_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginCliente v1 = new LoginCliente();

            v1.Show();
        }

        private void iniciar_administrador_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginAdministrador v1 = new LoginAdministrador();

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
