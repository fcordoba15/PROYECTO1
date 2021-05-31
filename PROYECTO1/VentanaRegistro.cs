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
            this.Hide();//Ocultar ventana actual

            RegistroCliente v1 = new RegistroCliente();//Crear ventana

            v1.Show();// Mostrar ventana
        }

        private void Registrar_entrenador_Click(object sender, EventArgs e)
        {
            RegistroEntrenador v1 = new RegistroEntrenador();//Crear ventana
            this.Hide();//Ocultar ventana actual
            v1.Show();// Mostrar ventana
        }

        private void Registrar_administrador_Click(object sender, EventArgs e)
        {
            LoginAdministrador2 v1 = new LoginAdministrador2();//Crear ventana

            this.Hide();//Ocultar ventana actual

            v1.Show();// Mostrar ventana
        }

        private void volver_Click(object sender, EventArgs e)
        {
            VentanaInicio v1 = new VentanaInicio();// Mostrar ventana
            this.Hide();//Ocultar ventana actual
            v1.Show();// Mostrar ventana
        }
    }
}
