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
        conexionSQLN cn = new conexionSQLN();
        public G_Admin_Entrenadores()
        {
            InitializeComponent();
            GestionEntrenadoresAdminDG.DataSource = cn.ConsultaEntrenadoresAdmin();
        }




        private void ModificarEntrenador_Click_1(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txt_Calificacion_Entrenador.Text);
            int i2 = Convert.ToInt32(txt_Telefono_Entrenador.Text);
            cn.ModificarEntrenadorAdmin(txt_ID_Entrenador.Text, txt_Nombre_Entrenador.Text, i,
                i2, txt_Correo_Entrenador.Text, txt_SitioWeb_Entrenador.Text, txt_Provincia_Entrenador.Text,
                txt_Canton_Entrenador.Text, txt_Distrito_Entrenador.Text, txt_Ubicacion_Entrenador.Text);
            GestionEntrenadoresAdminDG.DataSource = cn.ConsultaEntrenadoresAdmin();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloAdministrador m1 = new ModuloAdministrador();
            m1.Show();
        }

        private void EliminarEntrenador_Click_1(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txt_ID_Entrenador.Text);
            cn.EliminarEntrenadorAdministrador(i);
            GestionEntrenadoresAdminDG.DataSource = cn.ConsultaEntrenadoresAdmin();
        }
    }
}
