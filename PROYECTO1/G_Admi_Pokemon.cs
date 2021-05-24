using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Negocios;

namespace PROYECTO1
{
    public partial class ConsultaPokEnt : Form
    {
        conexionSQLN cn = new conexionSQLN();
        public ConsultaPokEnt()
        {
            InitializeComponent();
            ConsultaPokDG.DataSource = cn.ConsultaPokemonDT();
        }

        private void Crear_Click(object sender, EventArgs e)
        {

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            fotografia.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

            try
            {
                cn.InsertarPokemonAdministrador(Nombre_Pokemon.Text, ID_Tipo.Text, Codigo_Tipo.Text, Total.Text,
                Salud.Text, Ataque.Text, Defensa.Text, Ataque_Especial.Text, Defensa_Especial.Text,
                Velocidad.Text, Generacion.Text, comboBox1.Text, ms.GetBuffer());
                ConsultaPokDG.DataSource = cn.ConsultaPokemonDT();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Escoger True o False " + ex.Message);
                //AGREGAR CLOSE .Close();
            }
        }

        private void EliminarPokEnt_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            G_EliminarPokAdmin m1 = new G_EliminarPokAdmin();
            m1.Show();

        }

        private void ModificarPokEnt_Click_1(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(ID_Pokemon.Text);
            cn.ModificarPokemonAdministrador(i, Nombre_Pokemon.Text, ID_Tipo.Text, Codigo_Tipo.Text, Total.Text,
                Salud.Text, Ataque.Text, Defensa.Text, Ataque_Especial.Text, Defensa_Especial.Text,
                Velocidad.Text, Generacion.Text, comboBox1.Text);
            ConsultaPokDG.DataSource = cn.ConsultaPokemonDT();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fotografia = new OpenFileDialog();
            DialogResult rs = fotografia.ShowDialog();
            if(rs ==DialogResult.OK)
            {
                picPokemon.Image = Image.FromFile(fotografia.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
