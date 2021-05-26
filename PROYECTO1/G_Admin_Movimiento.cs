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
    public partial class G_Admin_Movimiento : Form
    {
        conexionSQLN cn = new conexionSQLN();
        public G_Admin_Movimiento()
        {
            InitializeComponent();
            AdminConsultaMovDG.DataSource = cn.ConsultaMovimientosAdmin();
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            cn.InsertarMovimientoAdmin(txt_CodigoMovAdmi.Text, txt_DescripcionMovAdmi.Text, txt_NombreMovAdmi.Text,
             txt_TipoMovAdmi.Text);
            AdminConsultaMovDG.DataSource = cn.ConsultaMovimientosAdmin();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            cn.ModificarMovimientoAdmin(txt_CodigoMovAdmi.Text, txt_DescripcionMovAdmi.Text, txt_NombreMovAdmi.Text,
             txt_TipoMovAdmi.Text);
            AdminConsultaMovDG.DataSource = cn.ConsultaMovimientosAdmin();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            cn.EliminarMovimientoAdmin(txt_CodigoMovAdmi.Text);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloAdministrador v1 = new ModuloAdministrador();
            v1.Show();
            
        }
    }
}
