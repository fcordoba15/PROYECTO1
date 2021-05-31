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
    public partial class TipoMovAdmin : Form
    {
        conexionSQLN cn = new conexionSQLN(); //Llamar a la clase
        public TipoMovAdmin()
        {
            InitializeComponent();
            AdminConsultaMovDG.DataSource = cn.ConsultaMovimientosAdmin(); //Consultar datos
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
                    if (c == p[0])  //Validar
                        validación_comilla++;
                }
                foreach (char c in txt_DescripcionMovAdmi.Text)
                {
                    if (c == p[0]) //Validar
                        validación_comilla++;
                }
                foreach (char c in txt_NombreMovAdmi.Text)
                {
                    if (c == p[0]) //Validar
                        validación_comilla++;
                }
                foreach (char c in txt_TipoMovAdmi.Text)
                {
                    if (c == p[0]) //Validar
                        validación_comilla++;
                }
                if (validación_comilla > 0)
                {
                    MessageBox.Show("¡Error! No debe ingresar información con comillas simples"); //Mensaje de error
                    break;
                }

                //------------- REGISTRO EN LA BASE DE DATOS -------------
                cn.InsertarMovimientoAdmin(txt_CodigoMovAdmi.Text, txt_DescripcionMovAdmi.Text, txt_NombreMovAdmi.Text,
                txt_TipoMovAdmi.Text);
                AdminConsultaMovDG.DataSource = cn.ConsultaMovimientosAdmin();  //Consultar datos

                MessageBox.Show("¡Movimiento creado!"); //Mensaje

                this.Hide(); //Ocultar ventana actual
                ModuloAdministrador v1 = new ModuloAdministrador(); //Crear ventana
                v1.Show(); // Mostrar ventana

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
                    if (c == p[0])  //Validar
                        validación_comilla++;
                }
                foreach (char c in txt_DescripcionMovAdmi.Text)
                {
                    if (c == p[0]) //Validar
                        validación_comilla++;
                }
                foreach (char c in txt_NombreMovAdmi.Text)
                {
                    if (c == p[0]) //Validar
                        validación_comilla++;
                }
                foreach (char c in txt_TipoMovAdmi.Text)
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
                cn.ModificarMovimientoAdmin(Id_Movimiento.Text, txt_DescripcionMovAdmi.Text, txt_NombreMovAdmi.Text, txt_TipoMovAdmi.Text);
                AdminConsultaMovDG.DataSource = cn.ConsultaMovimientosAdmin(); //Consultar datos

                MessageBox.Show("¡Movimiento creado con éxtio!"); //Mensaje

                this.Hide(); //Ocultar ventana actual
                ModuloAdministrador v1 = new ModuloAdministrador(); //Crear ventana
                v1.Show(); //Mostrar ventana
                a++;
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            cn.EliminarMovimientoAdmin(Id_Movimiento.Text);
            AdminConsultaMovDG.DataSource = cn.ConsultaMovimientosAdmin(); //Consultar datos
            MessageBox.Show("¡Eliminado correctamente!"); //Mensaje
            this.Hide(); //Ocultar ventana actual
            ModuloAdministrador v1 = new ModuloAdministrador(); //Crear ventana
            v1.Show(); // Mostrar ventana
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide(); //Ocultar ventana actual
            ModuloAdministrador v1 = new ModuloAdministrador(); //Crear ventana
            v1.Show(); // Mostrar ventana

        }


        private void Id_Movimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Id_Movimiento.SelectedIndex > 0)  //Validar
            {


                //cn.Imagen_Mostrar(picPokemon, i);
                string[] valores = cn.Info_movimiento(Id_Movimiento.Text);

                txt_CodigoMovAdmi.Text = valores[0];  //Asignar valores
                txt_DescripcionMovAdmi.Text = valores[1];
                txt_NombreMovAdmi.Text = valores[2];
                txt_TipoMovAdmi.Text = valores[3];


            }
        }
    }
}
