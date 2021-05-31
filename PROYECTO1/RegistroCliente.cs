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
    public partial class RegistroCliente : Form
    {

        conexionSQLN cn = new conexionSQLN();

        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void Seleccionar_ubicación_Click(object sender, EventArgs e)
        {
            Google_maps v1 = new Google_maps(); //Crear ventana

            v1.Show();// Mostrar ventana


        }

        private void Realizar_registro_cliente_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == ""
                 && textBox5.Text == "" && textBox6.Text == "" && textBox7.Text == "" && textBox8.Text == ""
                  && textBox9.Text == "" && textBox10.Text == "" && textBox11.Text == "")//Validar
            {
                MessageBox.Show("Ingrese todos los datos");//Mensaje
            }
            else
            {
                int a = 0;
                while (a == 0)//Validar
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
                    foreach (char c in textBox5.Text)
                    {
                        if (c == p[0])//Validar
                            validación_comilla++;
                    }
                    foreach (char c in textBox7.Text)
                    {
                        if (c == p[0])//Validar
                            validación_comilla++;
                    }
                    foreach (char c in textBox8.Text)
                    {
                        if (c == p[0])//Validar
                            validación_comilla++;
                    }
                    foreach (char c in textBox9.Text)
                    {
                        if (c == p[0])//Validar
                            validación_comilla++;
                    }
                    foreach (char c in textBox10.Text)
                    {
                        if (c == p[0])//Validar
                            validación_comilla++;
                    }
                    foreach (char c in textBox11.Text)
                    {
                        if (c == p[0])//Validar
                            validación_comilla++;
                    }
                    if (validación_comilla > 0)//Validar
                    {
                        MessageBox.Show("¡Error! Los campos no deben tener comillas simples");//Mensaje
                        break;
                    }

                    //------------- VALIDACION DE ARROBA EN CORREO -------------
                    string m = "@";
                    int validación_arroba = 0;
                    foreach (char c in textBox7.Text)
                    {
                        if (c == m[0])//Validar
                            validación_arroba++;
                    }
                    if (validación_arroba == 0)//Validar
                    {
                        MessageBox.Show("¡Error! El correo debe ser de formato usuario@.com");//Mensaje
                        break;
                    }

                    //------------- VALIDACIONES DE DATOS NUMERICOS -------------
                    if (textBox3.Text.All(char.IsDigit) == false)//Validar
                    {
                        MessageBox.Show("¡Error! La llave de encriptación debe ser numérica");
                        break;
                    }
                    if (textBox4.Text.All(char.IsDigit) == false)//Validar
                    {
                        MessageBox.Show("¡Error! La cédula debe ser numérica");
                        break;
                    }
                    if (textBox6.Text.All(char.IsDigit) == false)//Validar
                    {
                        MessageBox.Show("¡Error! El teléfono debe ser numérico");//Mensaje
                        break;
                    }

                    //------------- VALIDACION SITIO WEB -------------
                    string w = ".";
                    string x = "c";
                    string y = "o";
                    string z = "m";
                    int validación_SitioWeb = 0;
                    foreach (char c in textBox8.Text)
                    {
                        if (c == w[0])//Validar
                            validación_SitioWeb++;
                    }
                    foreach (char c in textBox8.Text)
                    {
                        if (c == x[0])//Validar
                            validación_SitioWeb++;
                    }
                    foreach (char c in textBox8.Text)
                    {
                        if (c == y[0])//Validar
                            validación_SitioWeb++;
                    }
                    foreach (char c in textBox8.Text)
                    {
                        if (c == z[0])//Validar
                            validación_SitioWeb++;
                    }
                    if (validación_SitioWeb < 4)
                    {
                        MessageBox.Show("¡Error! El sitio web debe ser de formato texto.com");//Mensaje
                        break;
                    }

                    cn.Registrar_clienteUsuario(textBox1.Text, textBox2.Text, textBox3.Text);
                    cn.Registrar_cliente(textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text
                        , textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox1.Text);
                 
                    Google_maps v1 = new Google_maps();//Crear ventana

                    v1.Show();// Mostrar ventana

                    a++;
                }
            }
        }

        private void volver_Click(object sender, EventArgs e)
        {
            VentanaRegistro v1 = new VentanaRegistro();//Crear ventana
            this.Hide();//Ocultar ventana actual
            v1.Show();// Mostrar ventana
        }

    }
}
