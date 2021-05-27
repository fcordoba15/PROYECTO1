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
        conexionSQLN cn = new conexionSQLN();

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



                cn.EliminarPokemonAdministrador(i);
                MessageBox.Show("Pokemon Eliminado");
                this.Hide();
                ConsultaPokEnt v2 = new ConsultaPokEnt();
                v2.Show();
                                  
            }
            else
            {
                MessageBox.Show("Ingrese un numero positivo");
            }

            
        }

        private void txt_EliminarPok_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaPokEnt m2 = new ConsultaPokEnt();
            m2.Show();
        }

        private void G_EliminarPokAdmin_Load(object sender, EventArgs e)
        {

        }

        private void txt_EliminarPok_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
