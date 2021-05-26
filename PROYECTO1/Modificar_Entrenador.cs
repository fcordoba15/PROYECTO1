﻿using System;
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
        conexionSQLN cn = new conexionSQLN();
        public Modificar_Entrenador()
        {
            InitializeComponent();
        }

        private void Modificar_Entrenador_Load(object sender, EventArgs e)
        {

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
                    if (c == p[0])
                        validación_comilla++;
                }
                foreach (char c in txt_Correo_Entrenador.Text)
                {
                    if (c == p[0])
                        validación_comilla++;
                }
                foreach (char c in txt_SitioWeb_Entrenador.Text)
                {
                    if (c == p[0])
                        validación_comilla++;
                }
                foreach (char c in txt_Provincia_Entrenador.Text)
                {
                    if (c == p[0])
                        validación_comilla++;
                }
                foreach (char c in txt_Canton_Entrenador.Text)
                {
                    if (c == p[0])
                        validación_comilla++;
                }
                foreach (char c in txt_Distrito_Entrenador.Text)
                {
                    if (c == p[0])
                        validación_comilla++;
                }
                foreach (char c in txt_Ubicacion_Entrenador.Text)
                {
                    if (c == p[0])
                        validación_comilla++;
                }
                if (validación_comilla > 0)
                {
                    MessageBox.Show("¡Error! Los campos no deben tener comillas simples");
                    break;
                }

                //------------- VALIDACION DE ARROBA EN CORREO -------------
                string m = "@";
                int validación_arroba = 0;
                foreach (char c in txt_Correo_Entrenador.Text)
                {
                    if (c == m[0])
                        validación_arroba++;
                }
                if (validación_arroba == 0)
                {
                    MessageBox.Show("¡Error! El correo debe ser de formato usuario@.com");
                    break;
                }

                //------------- VALIDACIONES DE DATOS NUMERICOS -------------
                if (txt_ID_Entrenador.Text.All(char.IsDigit) == false)
                {
                    MessageBox.Show("¡Error! El ID a modificar debe ser un dato numérico existente");
                    break;
                }
                if (txt_Calificacion_Entrenador.Text.All(char.IsDigit) == false)
                {
                    MessageBox.Show("¡Error! La calificación debe ser numérica");
                    break;
                }
                if (Clave.Text.All(char.IsDigit) == false)
                {
                    MessageBox.Show("¡Error! La llave de encriptación debe ser numérica");
                    break;
                }
                if (Cedula.Text.All(char.IsDigit) == false)
                {
                    MessageBox.Show("¡Error! La cédula debe ser numérica");
                    break;
                }
                if (txt_Telefono_Entrenador.Text.All(char.IsDigit) == false)
                {
                    MessageBox.Show("¡Error! El teléfono debe ser numérico");
                    break;
                }
                if (txt_Calificacion_Entrenador.Text.All(char.IsDigit) == false)
                {
                    MessageBox.Show("¡Error! La calificación debe ser numérica");
                    break;
                }

                //------------- VALIDACIONES DE VALOR DE CALIFICACION -------------
                double calificacion = Double.Parse(txt_Calificacion_Entrenador.Text);
                if (calificacion > 100 || calificacion < 0)
                {
                    MessageBox.Show("¡Error! La calificación debe ser un valor entre 0 y 100");
                    break;
                }

                

                   
                cn.ModificarEntrenadorAdmin(txt_ID_Entrenador.Text, txt_Nombre_Entrenador.Text, txt_Calificacion_Entrenador.Text,
                txt_Telefono_Entrenador.Text, txt_Correo_Entrenador.Text, txt_SitioWeb_Entrenador.Text, txt_Provincia_Entrenador.Text,
                txt_Canton_Entrenador.Text, txt_Distrito_Entrenador.Text, txt_Ubicacion_Entrenador.Text);
                MessageBox.Show("Se modificó entrenador");
                this.Hide();
                G_Admin_Entrenadores v2 = new G_Admin_Entrenadores();
                v2.Show();

                a++;
            }
        }
    }
}
