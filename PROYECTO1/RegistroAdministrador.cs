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
    public partial class RegistroAdministrador : Form
    {

        conexionSQLN cn = new conexionSQLN();//Llamar a la clase

        public RegistroAdministrador()
        {
            InitializeComponent();
        }

        private void Realizar_registro_cliente_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")//Validar
            {
                MessageBox.Show("Ingrese todos los datos");//Mensaje
            }
            else
            {
                int a = 0;
                while (a==0)//Validar
                {
                    //------------- VALIDACIONES DE COMILLAS -------------
                    string p = "'";
                    int validación_comilla = 0;
                    foreach (char c in textBox1.Text)
                    {
                        if (c == p[0])//Validar
                            validación_comilla++;
                    }
                    foreach (char c in textBox2.Text)
                    {
                        if (c == p[0])//Validar
                            validación_comilla++;
                    }
                    if (validación_comilla > 0)//Validar
                    {
                        MessageBox.Show("¡Error! Los campos no debe tener comillas simples");//Mensaje
                        break;
                    }

                    //------------- VALIDACIONES DE DATOS NUMERICOS -------------
                    if (textBox3.Text.All(char.IsDigit) == false)//Validar
                    {
                        MessageBox.Show("¡Error! La llave de encriptación debe ser numérica");//Mensaje
                        break;
                    }
                    EresAdmin v1 = new EresAdmin();//Crear ventana
                    cn.Registrar_administradorUsuario(textBox1.Text, textBox2.Text, textBox3.Text);
                    this.Hide();//Ocultar ventana actual
                    v1.Show();// Mostrar ventana
                    a++;
                }    
            }
        }

        private void volver_Click(object sender, EventArgs e)
        {
            VentanaRegistro v1 = new VentanaRegistro();
            this.Hide();//Ocultar ventana actual
            v1.Show();// Mostrar ventana
        }

    }
}
