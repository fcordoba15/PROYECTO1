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
    public partial class LoginAdministrador2 : Form
    {
        conexionSQLN cn = new conexionSQLN();//Llamar a la clase

        public LoginAdministrador2()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            if (cn.conSQL_administrador(usuario.Text, pass.Text) == usuario.Text) //Validar
            {
                MessageBox.Show("Se inició sesión");//Mensaje

                RegistroAdministrador v1 = new RegistroAdministrador();//Crear ventana

                this.Hide();//Ocultar ventana actual

                v1.Show();// Mostrar ventana


            }
            else
            {
                MessageBox.Show("Error");//Mensaje
            }
        }

    }
}
