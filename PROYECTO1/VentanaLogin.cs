using Negocios;
using System;
using System.Windows.Forms;


namespace PROYECTO1
{
    public partial class VentanaLogin : Form
    {


        conexionSQLN cn = new conexionSQLN();
        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cn.conSQL(usuario.Text, pass.Text) == 1)
            {
                MessageBox.Show("Se inició sesión");
            }
            else
            {
                MessageBox.Show("Error");
            }


        }
    }
}
