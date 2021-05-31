//Biblioteca que se va a utilizar
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
            this.Hide();//Ocultar ventana actual

            LoginEntrenador v1 = new LoginEntrenador();//Crear ventana

            v1.Show();// Mostrar ventana
        }

        private void iniciar_cliente_Click(object sender, EventArgs e)
        {
            this.Hide();//Ocultar ventana actual

            LoginCliente v1 = new LoginCliente();//Crear ventana

            v1.Show();// Mostrar ventana
        }

        private void iniciar_administrador_Click(object sender, EventArgs e)
        {
            this.Hide();//Ocultar ventana actual

            LoginAdministrador v1 = new LoginAdministrador();//Crear ventana

            v1.Show();// Mostrar ventana
        }

        private void volver_Click(object sender, EventArgs e)
        {
            VentanaInicio v1 = new VentanaInicio();//Crear ventana
            this.Hide();//Ocultar ventana actual
            v1.Show();// Mostrar ventana
        }
    }
}
