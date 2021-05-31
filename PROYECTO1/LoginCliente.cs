//Biblioteca de clases
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
    public partial class LoginCliente : Form
    {

        conexionSQLN cn = new conexionSQLN(); //Llamar a la clase

        public LoginCliente()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            if (cn.conSQL_cliente(usuario.Text, pass.Text) == usuario.Text) //Validar
            {
                MessageBox.Show("Se inició sesión");//Mensaje

                this.Hide();//Ocultar ventana actual

                ModuloCliente m1 = new ModuloCliente();//Crear ventana
                m1.Show();// Mostrar ventana
            }
            else
            {
                MessageBox.Show("Error");//Mensaje
            }
        }

    }
}
