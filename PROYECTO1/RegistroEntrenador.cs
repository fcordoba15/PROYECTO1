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
    public partial class RegistroEntrenador : Form
    {
        conexionSQLN cn = new conexionSQLN();

        public RegistroEntrenador()
        {
            InitializeComponent();
        }

        private void Realizar_registro_cliente_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox13.Text == "" && textBox4.Text == ""
                 && textBox5.Text == "" && textBox6.Text == "" && textBox7.Text == "" && textBox8.Text == ""
                  && textBox9.Text == "" && textBox10.Text == "" && textBox11.Text == "" && textBox12.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos");
            }
            else
            {
                
                cn.Registrar_entrenadorUsuario(textBox1.Text, textBox2.Text, textBox3.Text);

                cn.Registrar_entrenador(textBox4.Text, textBox5.Text,textBox13.Text, textBox6.Text, textBox7.Text
                    , textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox1.Text);

                MessageBox.Show("Se realizó el registro");
                this.Hide();
                VentanaInicio v2 = new VentanaInicio();
                v2.Show();

            }
        }
    }
}
