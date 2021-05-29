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
                int i2 = Convert.ToInt32(ID_Ent_Bitacora.Text);
                cn.InsertarBitacora(dateTimePicker1.Value.ToString(), Texto_Bitacora.Text, i2);

                a++;
            }
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloEntrenador m1 = new ModuloEntrenador();
            m1.Show();
        }
    }
}
