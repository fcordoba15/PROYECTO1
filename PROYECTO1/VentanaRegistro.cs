﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO1
{
    public partial class VentanaRegistro : Form
    {
        public VentanaRegistro()
        {
            InitializeComponent();
        }

        private void Registrar_cliente_Click(object sender, EventArgs e)
        {
            this.Hide();

            RegistroCliente v1 = new RegistroCliente();

            v1.Show();
        }
    }
}