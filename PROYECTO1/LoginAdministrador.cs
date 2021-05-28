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

    public partial class LoginAdministrador : Form
    {

        conexionSQLN cn = new conexionSQLN();

        public LoginAdministrador()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {

            if (cn.conSQL_administrador(usuario.Text, pass.Text) == usuario.Text)
            {
                MessageBox.Show("Se inició sesión");

                this.Hide();
                ModuloAdministrador m1 = new ModuloAdministrador();
                m1.Show();


            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void LoginAdministrador_Load(object sender, EventArgs e)
        {

        }
    }
}
