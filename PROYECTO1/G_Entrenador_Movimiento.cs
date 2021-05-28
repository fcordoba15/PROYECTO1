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
    public partial class GestionMov : Form
    {
        conexionSQLN cn = new conexionSQLN();
        public GestionMov()
        {
            InitializeComponent();
            ConsultaMovDG.DataSource = cn.ConsultaDT();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            //--------------------------------- VALIDACIONES DE ESCRITURA EN CAMPOS ---------------------------------
            int a = 0;
            while (a == 0)
            {
                //------------- VALIDACIONES DE COMILLAS -------------
                string p = "'";
                int validación_comilla = 0;
                foreach (char c in textBox3.Text)
                {
                    if (c == p[0])
                        validación_comilla++;
                }
                if (validación_comilla > 0)
                {
                    MessageBox.Show("¡Error! El ID del movimiento no debe tener comillas simples");
                    break;
                }

                //------------- VALIDACIONES DE DATOS NUMERICOS -------------
                if (textBox1.Text.All(char.IsDigit) == false)
                {
                    MessageBox.Show("¡Error! El ID del entrenador debe ser numérico");
                    break;
                }
                if (textBox2.Text.All(char.IsDigit) == false)
                {
                    MessageBox.Show("¡Error! El ID del Pokemon debe ser numérico");
                    break;
                }

                //------------- REGISTRO EN LA BASE DE DATOS -------------
                int i = Convert.ToInt32(textBox2.Text);
                cn.InsertarMovimiento(textBox1.Text, i, textBox3.Text);
                ConsultaMovDG.DataSource = cn.ConsultaDT();
                a++;
            }
        }


        private void Modificar_Click(object sender, EventArgs e)
        {
            //--------------------------------- VALIDACIONES DE ESCRITURA EN CAMPOS ---------------------------------
            int a = 0;
            while (a == 0)
            {
                //------------- VALIDACIONES DE COMILLAS -------------
                string p = "'";
                int validación_comilla = 0;
                foreach (char c in textBox3.Text)
                {
                    if (c == p[0])
                        validación_comilla++;
                }
                if (validación_comilla > 0)
                {
                    MessageBox.Show("¡Error! El ID del movimiento no debe tener comillas simples");
                    break;
                }

                //------------- VALIDACIONES DE DATOS NUMERICOS -------------
                if (textBox1.Text.All(char.IsDigit) == false)
                {
                    MessageBox.Show("¡Error! El ID del entrenador debe ser numérico");
                    break;
                }
                if (textBox2.Text.All(char.IsDigit) == false)
                {
                    MessageBox.Show("¡Error! El ID del Pokemon debe ser numérico");
                    break;
                }

                //------------- REGISTRO EN LA BASE DE DATOS -------------
                int i = Convert.ToInt32(textBox2.Text);
                cn.ModificarMovimiento(textBox1.Text, i, textBox3.Text);
                ConsultaMovDG.DataSource = cn.ConsultaDT();
                a++;
            }
        }


        private void Eliminar_Click(object sender, EventArgs e)
        {
           int i = Convert.ToInt32(textBox2.Text);
           cn.EliminarMovimiento(textBox1.Text, i, textBox3.Text);
           ConsultaMovDG.DataSource = cn.ConsultaDT();

        }

        private void GestionMov_Load(object sender, EventArgs e)
        {

        }
    }
}
