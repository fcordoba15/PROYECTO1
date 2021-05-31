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
    public partial class G_Admin_Entrenadores : Form
    {
        conexionSQLN cn = new conexionSQLN();  //Llamar a la clase
        public G_Admin_Entrenadores()
        {
            InitializeComponent();
            GestionEntrenadoresAdminDG.DataSource = cn.ConsultaEntrenadoresAdmin(); //Consultar datos
        }




        private void ModificarEntrenador_Click_1(object sender, EventArgs e)
        {
            this.Hide();    //Ocultar ventana actual
            Modificar_Entrenador v1 = new Modificar_Entrenador(); //Crear ventana
            v1.Show(); // Mostrar ventana
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide(); //Ocultar ventana actual
            ModuloAdministrador m1 = new ModuloAdministrador(); //Crear ventana
            m1.Show(); // Mostrar ventana
        }

        private void EliminarEntrenador_Click_1(object sender, EventArgs e)
        {
            this.Hide(); //Ocultar ventana actual
            G_Admin_Entrenador_Eliminar v1 = new G_Admin_Entrenador_Eliminar();//Crear ventana
            v1.Show(); // Mostrar ventana
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroEntrenador v1 = new RegistroEntrenador(); //Crear ventana
            this.Hide();//Ocultar ventana actual
            v1.Show(); // Mostrar ventana
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();//Ocultar ventana actual
            ModuloAdministrador v1 = new ModuloAdministrador();//Crear ventana
            v1.Show();// Mostrar ventana
        }
    }
}
