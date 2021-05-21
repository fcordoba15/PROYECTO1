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
    
    public partial class BitacoraEntrenador : Form
    {
        conexionSQLN cn = new conexionSQLN();
        public BitacoraEntrenador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int i = Convert.ToInt32(dateTimePicker1.Value.ToString());
            int i2 = Convert.ToInt32(ID_Ent_Bitacora.Text);
            cn.InsertarBitacora(dateTimePicker1.Value.ToString(), Texto_Bitacora.Text, i2);
        }
    }
}
