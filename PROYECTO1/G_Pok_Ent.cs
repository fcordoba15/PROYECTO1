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
    public partial class G_Pok_Ent : Form
    {
        conexionSQLN cn = new conexionSQLN();
        public G_Pok_Ent()
        {
            InitializeComponent();
            ConsultaPokDG.DataSource = cn.ConsultaPok();
        }

        private void G_Pok_Ent_Load(object sender, EventArgs e)
        {

        }
    }
}
