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
            this.Hide();
            Modificar_Entrenador v1 = new Modificar_Entrenador();
            v1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloAdministrador m1 = new ModuloAdministrador();
            m1.Show();
        }

        private void EliminarEntrenador_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            G_Admin_Entrenador_Eliminar v1 = new G_Admin_Entrenador_Eliminar();
            v1.Show();
        }

        private void G_Admin_Entrenadores_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroEntrenador v1 = new RegistroEntrenador();
            this.Hide();
            v1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloAdministrador v1 = new ModuloAdministrador();
            v1.Show();
        }
    }
}
