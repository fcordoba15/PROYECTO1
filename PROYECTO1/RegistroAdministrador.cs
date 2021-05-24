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

        conexionSQLN cn = new conexionSQLN();

        public RegistroAdministrador()
        {
            InitializeComponent();
        }

        private void Realizar_registro_cliente_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" )
            {
                MessageBox.Show("Ingrese todos los datos");
            }
            else
            {
                int a = 0;
                while (a==0)
                {
                    string p = "'";
                    int validación_comilla = 0;
                    foreach (char c in textBox1.Text)
                    {
                        if (c == p[0])
                            validación_comilla++;
                    }
                    if (validación_comilla > 0)
                    {
                        MessageBox.Show("¡Error! El nombre no debe tener comillas simples");
                        break;
                    }
                    EresAdmin v1 = new EresAdmin();
                    cn.Registrar_administradorUsuario(textBox1.Text, textBox2.Text, textBox3.Text);
                    this.Hide();
                    v1.Show();
                    a++;
                }    
            }
        }
    }
}
