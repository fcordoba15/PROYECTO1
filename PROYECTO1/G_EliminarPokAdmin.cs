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
    public partial class G_EliminarPokAdmin : Form
    {
        conexionSQLN cn = new conexionSQLN();

        public G_EliminarPokAdmin()
        {
            InitializeComponent();
            EliminarPokDG.DataSource = cn.ConsultaPokemonDT();

        }

        private void EliminarPok_Click(object sender, EventArgs e)
        {


            int i = Convert.ToInt32(txt_EliminarPok.Text);
            
            if (i >= 0)
            {
                cn.EliminarPokemonAdministrador(i);
                EliminarPokDG.DataSource = cn.ConsultaPokemonDT();
            }
            else
            {
                MessageBox.Show("Ingrese un numero positivo");
            }

            
        }

        private void txt_EliminarPok_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
