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
    public partial class EresAdmin : Form
    {
        public EresAdmin()
        {
            InitializeComponent();  //Iniciar ventana
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaInicio v1 = new VentanaInicio(); //Crear ventana
            this.Hide();  //Ocultar ventana actual

            v1.Show();  //Mostrar ventana

        }
    }
}
