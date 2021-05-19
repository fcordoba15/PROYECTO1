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
            this.Hide();

            LoginEntrenador v1 = new LoginEntrenador();

            v1.Show();
        }
    }
}
