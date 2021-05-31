//Bliotecas que se van a utilizar
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
    public partial class G_EliminarPokAdmin : Form
    {
        conexionSQLN cn = new conexionSQLN(); //Llamar a la clase

        public G_EliminarPokAdmin()
        {
            InitializeComponent();
            cn.Cm_IdPokemon(txt_EliminarPok);


        }

        private void EliminarPok_Click(object sender, EventArgs e)
        {
            

            int i = Convert.ToInt32(txt_EliminarPok.Text);
            
            if (i >= 0)
            {

                /*byte[] datos = new byte[0];
         
                datos = (byte[])cn.Imagen_Mostrar(i)["foto"];

                System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                Fotografia.Image = System.Drawing.Bitmap.FromStream(ms);*/



                cn.EliminarPokemonAdministrador(i);   //Eliminar datos
                MessageBox.Show("Pokemon Eliminado");  //Mensaje
                this.Hide(); //Ocultar ventana actual
                ConsultaPokEnt v2 = new ConsultaPokEnt(); //Crear ventana
                v2.Show(); // Mostrar ventana

            }
            else
            {
                MessageBox.Show("Ingrese un numero positivo"); //Mensaje
            }

            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); //Ocultar ventana actual
            ConsultaPokEnt m2 = new ConsultaPokEnt(); //Crear ventana
            m2.Show(); // Mostrar ventana
        }
    }
}
