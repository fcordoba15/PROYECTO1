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
    public partial class Modificar_Entrenador : Form
    {
        conexionSQLN cn = new conexionSQLN(); //Llamar a las clases
        public Modificar_Entrenador()
        {
            InitializeComponent();
            cn.Cm_Identrenador(txt_ID_Entrenador);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //--------------------------------- VALIDACIONES DE ESCRITURA EN CAMPOS ---------------------------------
            int a = 0;
            while (a == 0)
            {
                //------------- VALIDACIONES DE COMILLAS -------------
                string p = "'";
                int validación_comilla = 0;
                foreach (char c in txt_Nombre_Entrenador.Text)
                {
                    if (c == p[0]) //Validar
                        validación_comilla++;
                }
                foreach (char c in txt_Correo_Entrenador.Text)
                {
                    if (c == p[0])//Validar
                        validación_comilla++;
                }
                foreach (char c in txt_SitioWeb_Entrenador.Text)
                {
                    if (c == p[0])//Validar
                        validación_comilla++;
                }
                foreach (char c in txt_Provincia_Entrenador.Text)
                {
                    if (c == p[0])//Validar
                        validación_comilla++;
                }
                foreach (char c in txt_Canton_Entrenador.Text)
                {
                    if (c == p[0])//Validar
                        validación_comilla++;
                }
                foreach (char c in txt_Distrito_Entrenador.Text)
                {
                    if (c == p[0])//Validar
                        validación_comilla++;
                }
                foreach (char c in txt_Ubicacion_Entrenador.Text)
                {
                    if (c == p[0])//Validar
                        validación_comilla++;
                }
                if (validación_comilla > 0)
                {
                    MessageBox.Show("¡Error! Los campos no deben tener comillas simples");//Mensaje
                    break;
                }

                //------------- VALIDACION DE ARROBA EN CORREO -------------
                string m = "@";
                int validación_arroba = 0;
                foreach (char c in txt_Correo_Entrenador.Text)
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
                if (txt_ID_Entrenador.Text.All(char.IsDigit) == false)//Validar
                {
                    MessageBox.Show("¡Error! El ID a modificar debe ser un dato numérico existente");//Mensaje
                    break;
                }
                if (txt_Calificacion_Entrenador.Text.All(char.IsDigit) == false)//Validar
                {
                    MessageBox.Show("¡Error! La calificación debe ser numérica");//Mensaje
                    break;
                }
                if (Clave.Text.All(char.IsDigit) == false)//Validar
                {
                    MessageBox.Show("¡Error! La llave de encriptación debe ser numérica");//Mensaje
                    break;
                }
                if (Cedula.Text.All(char.IsDigit) == false)//Validar
                {
                    MessageBox.Show("¡Error! La cédula debe ser numérica");//Mensaje
                    break;
                }
                if (txt_Telefono_Entrenador.Text.All(char.IsDigit) == false)//Validar
                {
                    MessageBox.Show("¡Error! El teléfono debe ser numérico");//Mensaje
                    break;
                }
                if (txt_Calificacion_Entrenador.Text.All(char.IsDigit) == false)//Validar
                {
                    MessageBox.Show("¡Error! La calificación debe ser numérica");//Mensaje
                    break;
                }

                //------------- VALIDACIONES DE VALOR DE CALIFICACION -------------
                double calificacion = Double.Parse(txt_Calificacion_Entrenador.Text);
                if (calificacion > 100 || calificacion < 0)//Validar
                {
                    MessageBox.Show("¡Error! La calificación debe ser un valor entre 0 y 100");//Mensaje
                    break;
                }

                //------------- VALIDACION SITIO WEB -------------
                string w = ".";
                string x = "c";
                string y = "o";
                string z = "m";
                int validación_SitioWeb = 0;
                foreach (char c in txt_SitioWeb_Entrenador.Text)
                {
                    if (c == w[0])//Validar
                        validación_SitioWeb++;
                }
                foreach (char c in txt_SitioWeb_Entrenador.Text)
                {
                    if (c == x[0])//Validar
                        validación_SitioWeb++;
                }
                foreach (char c in txt_SitioWeb_Entrenador.Text)
                {
                    if (c == y[0])//Validar
                        validación_SitioWeb++;
                }
                foreach (char c in txt_SitioWeb_Entrenador.Text)
                {
                    if (c == z[0])//Validar
                        validación_SitioWeb++;
                }
                if (validación_SitioWeb < 4)//Validar
                {
                    MessageBox.Show("¡Error! El sitio web debe ser de formato texto.com");//Mensaje
                    break;
                }

                //------------- REGISTRO EN LA BASE DE DATOS -------------
                cn.ModificarEntrenadorAdmin(txt_ID_Entrenador.Text, txt_Nombre_Entrenador.Text, txt_Calificacion_Entrenador.Text,
                txt_Telefono_Entrenador.Text, txt_Correo_Entrenador.Text, txt_SitioWeb_Entrenador.Text, txt_Provincia_Entrenador.Text,
                txt_Canton_Entrenador.Text, txt_Distrito_Entrenador.Text, txt_Ubicacion_Entrenador.Text);
                MessageBox.Show("Se modificó entrenador");//Mensaje
                this.Hide();//Ocultar ventana actual
                G_Admin_Entrenadores v2 = new G_Admin_Entrenadores();//Crear ventana
                v2.Show();// Mostrar ventana

                a++;
            }
        }

        private void txt_ID_Entrenador_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                if (txt_ID_Entrenador.SelectedIndex > 0)//Validar
            {


                    //cn.Imagen_Mostrar(picPokemon, i);
                    string[] valores = cn.Info_Entrenador(txt_ID_Entrenador.Text);

                    txt_Nombre_Entrenador.Text = valores[1];//Asignar valores
                    txt_Calificacion_Entrenador.Text = valores[2];
                    txt_Telefono_Entrenador.Text = valores[3];
                    txt_Correo_Entrenador.Text = valores[4];
                    txt_SitioWeb_Entrenador.Text = valores[5];
                    txt_Provincia_Entrenador.Text = valores[6];
                    txt_Canton_Entrenador.Text = valores[7];
                    txt_Distrito_Entrenador.Text = valores[8];
                    txt_Ubicacion_Entrenador.Text = valores[9];
                                            //.Text = valores[10];




            }
            
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Hide();//Ocultar ventana actual
            ModuloAdministrador v1 = new ModuloAdministrador();//Crear ventana
            v1.Show();// Mostrar ventana
        }
    }
}
