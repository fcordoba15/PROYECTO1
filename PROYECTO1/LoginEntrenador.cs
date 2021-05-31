//Bibliotecas que se van a utilizar
using Negocios;
using System;
using System.Windows.Forms;


namespace PROYECTO1
{
    public partial class LoginEntrenador : Form
    {


        conexionSQLN cn = new conexionSQLN();//Llamar a la clase
        public LoginEntrenador()
        {
            InitializeComponent();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            if (cn.conSQL_entrenador(usuario.Text, pass.Text) == usuario.Text)//Validar
            {
                MessageBox.Show("Se inició sesión");//Mensaje

                this.Hide();//Ocultar ventana actual

                ModuloEntrenador m1 = new ModuloEntrenador();//Crear ventana
                m1.Show();// Mostrar ventana
            }
            else
            {
                MessageBox.Show("Error");//Mensaje
            }


        }

    }
}
