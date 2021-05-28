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
            cn.Cm_IdMovimiento(Id_Movimiento);
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            //--------------------------------- VALIDACIONES DE ESCRITURA EN CAMPOS ---------------------------------
            int a = 0;
            while (a == 0)
            {
                //------------- VALIDACIONES DE COMILLAS -------------
                string p = "'";
                int validación_comilla = 0;
                foreach (char c in txt_CodigoMovAdmi.Text)
                {
                    if (c == p[0])
                        validación_comilla++;
                }
                foreach (char c in txt_DescripcionMovAdmi.Text)
                {
                    if (c == p[0])
                        validación_comilla++;
                }
                foreach (char c in txt_NombreMovAdmi.Text)
                {
                    if (c == p[0])
                        validación_comilla++;
                }
                foreach (char c in txt_TipoMovAdmi.Text)
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
                cn.InsertarMovimientoAdmin(txt_CodigoMovAdmi.Text, txt_DescripcionMovAdmi.Text, txt_NombreMovAdmi.Text,
                txt_TipoMovAdmi.Text);
                AdminConsultaMovDG.DataSource = cn.ConsultaMovimientosAdmin();

                MessageBox.Show("¡Movimiento creado!");

                this.Hide();
                ModuloAdministrador v1 = new ModuloAdministrador();
                v1.Show();

                a++;
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            //--------------------------------- VALIDACIONES DE ESCRITURA EN CAMPOS ---------------------------------
            int a = 0;
            while (a == 0)
            {
                //------------- VALIDACIONES DE COMILLAS -------------
                string p = "'";
                int validación_comilla = 0;
                foreach (char c in txt_CodigoMovAdmi.Text)
                {
                    if (c == p[0])
                        validación_comilla++;
                }
                foreach (char c in txt_DescripcionMovAdmi.Text)
                {
                    if (c == p[0])
                        validación_comilla++;
                }
                foreach (char c in txt_NombreMovAdmi.Text)
                {
                    if (c == p[0])
                        validación_comilla++;
                }
                foreach (char c in txt_TipoMovAdmi.Text)
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
                cn.ModificarMovimientoAdmin(Id_Movimiento.Text, txt_DescripcionMovAdmi.Text, txt_NombreMovAdmi.Text, txt_TipoMovAdmi.Text);
                AdminConsultaMovDG.DataSource = cn.ConsultaMovimientosAdmin();

                MessageBox.Show("¡Movimiento creado con éxtio!");

                this.Hide();
                ModuloAdministrador v1 = new ModuloAdministrador();
                v1.Show();
                a++;
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            cn.EliminarMovimientoAdmin(Id_Movimiento.Text);
            AdminConsultaMovDG.DataSource = cn.ConsultaMovimientosAdmin();
            MessageBox.Show("¡Eliminado correctamente!");
            this.Hide();
            ModuloAdministrador v1 = new ModuloAdministrador();
            v1.Show();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloAdministrador v1 = new ModuloAdministrador();
            v1.Show();
            
        }

        private void G_Admin_Movimiento_Load(object sender, EventArgs e)
        {

        }

        private void Id_Movimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Id_Movimiento.SelectedIndex > 0)
            {


                //cn.Imagen_Mostrar(picPokemon, i);
                string[] valores = cn.Info_movimiento(Id_Movimiento.Text);

                txt_CodigoMovAdmi.Text = valores[0];
                txt_DescripcionMovAdmi.Text = valores[1];
                txt_NombreMovAdmi.Text = valores[2];
                txt_TipoMovAdmi.Text = valores[3];


            }
        }
    }
}
