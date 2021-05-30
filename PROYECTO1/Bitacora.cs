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
                    string Fecha = comboBox2.Text + "-";
                    Fecha = Fecha + comboBox3.Text + "-";
                    Fecha = Fecha + comboBox4.Text; 
                    cn.InsertarBitacora(Fecha, Texto_Bitacora.Text, ID_Ent_Bitacora.Text);
                   
                    MessageBox.Show("¡La bitácora ha sido creada con éxito!");

                    ModuloEntrenador v1 = new ModuloEntrenador();
                    this.Hide();
                    v1.Show();

                    a++;
                }

            }
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloEntrenador m1 = new ModuloEntrenador();
            m1.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
