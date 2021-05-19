using Negocios;
using System;
using System.Windows.Forms;


namespace PROYECTO1
{
    public partial class LoginEntrenador : Form
    {


        conexionSQLN cn = new conexionSQLN();
        public LoginEntrenador()
        {
            InitializeComponent();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            if (cn.conSQL(usuario.Text, pass.Text) == 1)
            {
                MessageBox.Show("Se inició sesión");

                this.Hide();

                ModuloEntrenador m1 = new ModuloEntrenador();
                m1.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }


        }


    }
}
