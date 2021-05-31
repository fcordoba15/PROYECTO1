//Bibliotecas que se van a utilizar

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
        conexionSQLN cn = new conexionSQLN(); //Llamar a la clase
        public G_Admin_Usuarios()
        {
            InitializeComponent();
            AdminUsuariosDG.DataSource = cn.ConsultaUsuariosMADT(); //Consultar datos
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
                    if (c == p[0]) //Validar
                        validación_comilla++;
                }
                foreach (char c in txt_Password.Text)
                {
                    if (c == p[0]) //Validar
                        validación_comilla++;
                }
                if (validación_comilla > 0)
                {
                    MessageBox.Show("¡Error! No debe ingresar información con comillas simples"); //Mensaje
                    break;
                }

                //------------- REGISTRO EN LA BASE DE DATOS -------------
                cn.InsertarUsuarioAdmin(txt_Usuario.Text, txt_Password.Text, combo_Rol.Text); //Insertar datos
                AdminUsuariosDG.DataSource = cn.ConsultaUsuariosMADT();
                
                MessageBox.Show("¡Usuario creado!"); //Mensaje
                
                this.Hide(); //Ocultar ventana actual
                ModuloAdministrador v1 = new ModuloAdministrador(); //Crear ventana
                v1.Show(); // Mostrar ventana

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
                    if (c == p[0]) //Validar
                        validación_comilla++;
                }
                foreach (char c in txt_Password.Text)
                {
                    if (c == p[0]) //Validar
                        validación_comilla++;
                }
                if (validación_comilla > 0)
                {
                    MessageBox.Show("¡Error! No debe ingresar información con comillas simples"); //Mensaje
                    break;
                }

                //------------- REGISTRO EN LA BASE DE DATOS -------------
                cn.ModificarUsuarioAdmin(txt_Usuario.Text, txt_Password.Text, combo_Rol.Text); //Modificar datos
                AdminUsuariosDG.DataSource = cn.ConsultaUsuariosMADT();
                
                MessageBox.Show("¡Usuario modificado!"); //Mensaje
                
                this.Hide(); //Ocultar ventana actual
                ModuloAdministrador v1 = new ModuloAdministrador(); //Crear ventana
                v1.Show(); // Mostrar ventana

                a++;
            }
        }

        private void EliminarUsuario_Click(object sender, EventArgs e)
        {
            cn.EliminarUsuarioAdmin(txt_Usuario.Text);
            AdminUsuariosDG.DataSource = cn.ConsultaUsuariosMADT(); //Consultar datos
            MessageBox.Show("¡Eliminado con éxito!"); //Mensaje
            this.Hide(); //Ocultar ventana actual
            ModuloAdministrador v1 = new ModuloAdministrador(); //Crear ventana
            v1.Show(); // Mostrar ventana
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ModuloAdministrador v4 = new ModuloAdministrador(); //Crear ventana
            v4.Show(); // Mostrar ventana
            this.Hide(); //Ocultar ventana actual
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex > 0) //Validar
            {
                

                //cn.Imagen_Mostrar(picPokemon, i);
                string[] valores = cn.Info_usuarios(comboBox1.Text); //Asignar valores
                txt_Usuario.Text = valores[0];
                txt_Password.Text = valores[2];
                
                
            }
        }
    }
}
