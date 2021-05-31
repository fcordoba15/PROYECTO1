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
    public partial class G_Admin_Entrenador_Eliminar : Form
    {
        conexionSQLN cn = new conexionSQLN();  //Llamar a la clase
        public G_Admin_Entrenador_Eliminar()
        {
            InitializeComponent();
            cn.Cm_Identrenador(txt_ID_Entrenador);  //Eliminar datos
        }


        private void EliminarEntrenador_Click(object sender, EventArgs e)
        {
             int i = Convert.ToInt32(txt_ID_Entrenador.Text);
            cn.EliminarEntrenadorAdministrador(i);  //Eliminar datos
            MessageBox.Show("Eliminado correctamente");  // Mensaje
            this.Hide();                //Ocultar ventana actual
            G_Admin_Entrenadores v1 =  new G_Admin_Entrenadores();  //Crear ventana
            v1.Show(); //Mostrar ventana


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();   //Ocultar ventana actual
            ModuloAdministrador v1 = new ModuloAdministrador();  //Crear ventana
            v1.Show();              //Mostrar ventana
        }
    }
}
