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
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
  
            
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            ConsultaMovDG.DataSource = cn.ConsultaDT();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultaMovDG.DataSource = cn.ConsultaDT();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            ConsultaMovDG.DataSource = cn.ConsultaDT();
        }
    }
}
