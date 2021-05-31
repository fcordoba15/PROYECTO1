
// Bibliotecas a utilizar
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
        // Llamar la clase guardada
        conexionSQLN cn = new conexionSQLN();
        public BitacoraEntrenador()
        {
            InitializeComponent();
           cn. Cm_Identrenador(ID_Ent_Bitacora);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //--------------------------------- VALIDACIONES DE ESCRITURA EN CAMPOS ---------------------------------
            int a = 0;
            while (a == 0)
            {
                //------------- VALIDACIONES DE COMILLAS -------------
                string p = "'";
                int validación_comilla = 0;
                foreach (char c in Texto_Bitacora.Text)
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
                //int i = Convert.ToInt32(dateTimePicker1.Value.ToString());

                if (comboBox2.Text!= "" && comboBox3.Text != "" && comboBox4.Text !="")
                {
                    string Fecha = comboBox2.Text + "-";  //Poner el formato a la fecha
                    Fecha = Fecha + comboBox3.Text + "-"; //Poner el formato a la fecha
                    Fecha = Fecha + comboBox4.Text;       //Poner el formato a la fecha
                    cn.InsertarBitacora(Fecha, Texto_Bitacora.Text, ID_Ent_Bitacora.Text);  //Insertar datos

                    a++;

                }

            }
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();  //Ocultar ventana actual
            ModuloEntrenador m1 = new ModuloEntrenador();  //Crear ventana
            m1.Show();  //Mostrar ventana
        }

    }
}
