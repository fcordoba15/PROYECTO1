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

    public partial class LoginAdministrador : Form
    {

        conexionSQLN cn = new conexionSQLN(); //Llamar a la clase

        public LoginAdministrador()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {

            if (cn.conSQL_administrador(usuario.Text, pass.Text) == usuario.Text) //Validar
            {
                MessageBox.Show("Se inició sesión");//Mensaje

                this.Hide();//Ocultar ventana actual
                ModuloAdministrador m1 = new ModuloAdministrador();//Crear ventana
                m1.Show();// Mostrar ventana


            }
            else
            {
                MessageBox.Show("Error");//Validar
            }
        }
    }
}
