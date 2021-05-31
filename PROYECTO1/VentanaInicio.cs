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
    public partial class VentanaInicio : Form
    {
        public VentanaInicio()
        {
            InitializeComponent();

            
        }

        private void boton_empezar_Click(object sender, EventArgs e)
        {
            this.Hide();//Ocultar ventana actual

            VentanaRoles v1 = new VentanaRoles();//Crear ventana

            v1.Show();// Mostrar ventana
        }

        private void boton_registrarse_Click(object sender, EventArgs e)
        {
            this.Hide();//Ocultar ventana actual

            VentanaRegistro v1 = new VentanaRegistro();//Crear ventana

            v1.Show();// Mostrar ventana

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Salir
        }
    }
}
