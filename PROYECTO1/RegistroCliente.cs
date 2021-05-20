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
            Google_maps v1 = new Google_maps();

            v1.Show();


        }

        private void Realizar_registro_cliente_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == ""
                 && textBox5.Text == "" && textBox6.Text == "" && textBox7.Text == "" && textBox8.Text == ""
                  && textBox9.Text == "" && textBox10.Text == "" && textBox11.Text == "" && textBox12.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos");
            }
            else
            {
                cn.Registrar_clienteUsuario(textBox1.Text, textBox2.Text, textBox3.Text);

                MessageBox.Show("Se realizó el registro");

            }
        }
    }
}
