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
            cn.cm_Usuarios(comboBox1);
        }

        private void CrearUsuario_Click(object sender, EventArgs e)
        {
            //--------------------------------- VALIDACIONES DE ESCRITURA EN CAMPOS ---------------------------------
            int a = 0;
            while (a == 0)
            {
                //------------- VALIDACIONES DE COMILLAS -------------
                string p = "'";
                int validación_comilla = 0;
                foreach (char c in txt_Usuario.Text)
                {
                    if (c == p[0])
                        validación_comilla++;
                }
                foreach (char c in txt_Password.Text)
                {
                    if (c == p[0])
                        validación_comilla++;
                }
                if (validación_comilla > 0)
                {
                    MessageBox.Show("¡Error! No debe ingresar información con comillas simples");
                    break;
                }

                //------------- REGISTRO EN LA BASE DE DATOS -------------
                cn.InsertarUsuarioAdmin(txt_Usuario.Text, txt_Password.Text, combo_Rol.Text);
                AdminUsuariosDG.DataSource = cn.ConsultaUsuariosMADT();
                
                MessageBox.Show("¡Usuario creado!");
                
                this.Hide();
                ModuloAdministrador v1 = new ModuloAdministrador();
                v1.Show();

                a++;
            }
        }


        private void ModificarUsuario_Click(object sender, EventArgs e)
        {
            //--------------------------------- VALIDACIONES DE ESCRITURA EN CAMPOS ---------------------------------
            int a = 0;
            while (a == 0)
            {
                //------------- VALIDACIONES DE COMILLAS -------------
                string p = "'";
                int validación_comilla = 0;
                foreach (char c in txt_Usuario.Text)
                {
                    if (c == p[0])
                        validación_comilla++;
                }
                foreach (char c in txt_Password.Text)
                {
                    if (c == p[0])
                        validación_comilla++;
                }
                if (validación_comilla > 0)
                {
                    MessageBox.Show("¡Error! No debe ingresar información con comillas simples");
                    break;
                }

                //------------- REGISTRO EN LA BASE DE DATOS -------------
                cn.ModificarUsuarioAdmin(txt_Usuario.Text, txt_Password.Text, combo_Rol.Text);
                AdminUsuariosDG.DataSource = cn.ConsultaUsuariosMADT();
                
                MessageBox.Show("¡Usuario modificado!");
                
                this.Hide();
                ModuloAdministrador v1 = new ModuloAdministrador();
                v1.Show();

                a++;
            }
        }

        private void EliminarUsuario_Click(object sender, EventArgs e)
        {
            cn.EliminarUsuarioAdmin(txt_Usuario.Text);
            AdminUsuariosDG.DataSource = cn.ConsultaUsuariosMADT();
            MessageBox.Show("¡Eliminado con éxito!");
            this.Hide();
            ModuloAdministrador v1 = new ModuloAdministrador();
            v1.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ModuloEntrenador v4 = new ModuloEntrenador();
            v4.Show();
            this.Hide();
        }

        private void G_Admin_Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex > 0)
            {
                

                //cn.Imagen_Mostrar(picPokemon, i);
                string[] valores = cn.Info_usuarios(comboBox1.Text);
                txt_Usuario.Text = valores[0];
                txt_Password.Text = valores[2];
                
                
            }
        }
    }
}
