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
    public partial class Modificar_Entrenador : Form
    {
        conexionSQLN cn = new conexionSQLN();
        public Modificar_Entrenador()
        {
            InitializeComponent();
        }

        private void Modificar_Entrenador_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txt_Calificacion_Entrenador.Text);
           int i2 = Convert.ToInt32(txt_Telefono_Entrenador.Text);
           cn.ModificarEntrenadorAdmin(txt_ID_Entrenador.Text, txt_Nombre_Entrenador.Text, i,
               i2, txt_Correo_Entrenador.Text, txt_SitioWeb_Entrenador.Text, txt_Provincia_Entrenador.Text,
               txt_Canton_Entrenador.Text, txt_Distrito_Entrenador.Text, txt_Ubicacion_Entrenador.Text);
                MessageBox.Show("Se modificó entrenador");
            this.Hide();
            G_Admin_Entrenadores v2 = new G_Admin_Entrenadores();
            v2.Show();
        }
    }
}
