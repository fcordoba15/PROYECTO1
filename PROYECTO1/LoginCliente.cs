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
    public partial class LoginCliente : Form
    {

        conexionSQLN cn = new conexionSQLN();

        public LoginCliente()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            if (cn.conSQL_cliente(usuario.Text, pass.Text) == usuario.Text)
            {
                MessageBox.Show("Se inició sesión");

                this.Hide();

                ModuloEntrenador m1 = new ModuloEntrenador();
                m1.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}