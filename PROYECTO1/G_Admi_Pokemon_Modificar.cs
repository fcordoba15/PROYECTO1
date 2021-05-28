using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace PROYECTO1
{
    public partial class G_Admi_Pokemon_Modificar : Form
    {
        conexionSQLN cn = new conexionSQLN();
        public G_Admi_Pokemon_Modificar()
        {
            InitializeComponent();
            cn.Cm_IdPokemon(ID_pokemon);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fotografia = new OpenFileDialog();
            DialogResult rs = fotografia.ShowDialog();
            if (rs == DialogResult.OK)
            {
                picPokemon.Image = Image.FromFile(fotografia.FileName);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //--------------------------------- VALIDACIONES DE ESCRITURA EN CAMPOS ---------------------------------
            int a = 0;
            while (a == 0)
            {
                //------------- VALIDACIONES DE COMILLAS -------------
                string p = "'";
                int validación_comilla = 0;
                foreach (char c in ID_Tipo.Text)
                {
                    if (c == p[0])
                        validación_comilla++;
                }
                foreach (char c in Codigo_Tipo.Text)
                {
                    if (c == p[0])
                        validación_comilla++;
                }
                foreach (char c in Nombre_Pokemon.Text)
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
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                picPokemon.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                int i = Convert.ToInt32(ID_pokemon.Text);
                
                cn.ModificarPokemonAdministrador(i, Nombre_Pokemon.Text, ID_Tipo.Text, Codigo_Tipo.Text, Total.Text,
                Salud.Text, Ataque.Text, Defensa.Text, Ataque_Especial.Text, Defensa_Especial.Text,
                Velocidad.Text, Generacion.Text, comboBox1.Text, ms.GetBuffer());
                
                MessageBox.Show("Pokemon modificado correctamente");
               
                this.Hide();
                ConsultaPokEnt m2 = new ConsultaPokEnt();
                m2.Show();

                a++;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void ID_pokemon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ID_pokemon.SelectedIndex>0)
            {
                int i = Convert.ToInt32(ID_pokemon.Text);

                //cn.Imagen_Mostrar(picPokemon, i);
                string[] valores = cn.Info_pokemon(i);
                Nombre_Pokemon.Text = valores[1];
                ID_Tipo.Text = valores[2];
                Codigo_Tipo.Text = valores[3];
                Total.Text = valores[4];
                Salud.Text = valores[5];
                Ataque.Text = valores[6];
                Defensa.Text = valores[7];
                Ataque_Especial.Text = valores[8];
                Defensa_Especial.Text = valores[9];
                Velocidad.Text = valores[10];
                Generacion.Text = valores[11];
  
                
            }
        }

        private void Ataque_Especial_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void picPokemon_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloAdministrador v1 = new ModuloAdministrador();
            v1.Show();
        }
    }
}
