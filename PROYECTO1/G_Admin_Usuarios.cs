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
    public partial class G_Admin_Usuarios : Form
    {
        conexionSQLN cn = new conexionSQLN();
        public G_Admin_Usuarios()
        {
            InitializeComponent();
            AdminUsuariosDG.DataSource = cn.ConsultaUsuariosMADT();
        }

        private void CrearUsuario_Click(object sender, EventArgs e)
        {
            cn.InsertarUsuarioAdmin(txt_Usuario.Text, txt_Password.Text, combo_Rol.Text);
            AdminUsuariosDG.DataSource = cn.ConsultaUsuariosMADT();
            

        }


        private void ModificarUsuario_Click(object sender, EventArgs e)
        {
            cn.ModificarUsuarioAdmin(txt_Usuario.Text, txt_Password.Text, combo_Rol.Text);
            AdminUsuariosDG.DataSource = cn.ConsultaUsuariosMADT();

        }

        private void EliminarUsuario_Click(object sender, EventArgs e)
        {
            cn.EliminarUsuarioAdmin(txt_Usuario.Text);
            AdminUsuariosDG.DataSource = cn.ConsultaUsuariosMADT();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void G_Admin_Usuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
