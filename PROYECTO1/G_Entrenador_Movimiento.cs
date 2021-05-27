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
            int i = Convert.ToInt32(textBox2.Text);
            cn.InsertarMovimiento(textBox1.Text, i, textBox3.Text);
            ConsultaMovDG.DataSource = cn.ConsultaDT();
        }
        private void Modificar_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox2.Text);
            cn.ModificarMovimiento(textBox1.Text, i, textBox3.Text);
            ConsultaMovDG.DataSource = cn.ConsultaDT();
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
