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
        conexionSQLN cn = new conexionSQLN();
        public G_Admin_Entrenador_Eliminar()
        {
            InitializeComponent();
            cn.Cm_Identrenador(txt_ID_Entrenador);
        }

        private void G_Admin_Entrenador_Eliminar_Load(object sender, EventArgs e)
        {

        }

        private void EliminarEntrenador_Click(object sender, EventArgs e)
        {
             int i = Convert.ToInt32(txt_ID_Entrenador.Text);
            cn.EliminarEntrenadorAdministrador(i);
            MessageBox.Show("Eliminado correctamente");
            this.Hide();
            G_Admin_Entrenadores v1 =  new G_Admin_Entrenadores();
            v1.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloAdministrador v1 = new ModuloAdministrador();
            v1.Show();
        }
    }
}
