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
    public partial class GestionPokemonesEntrenador : Form
    {
        conexionSQLN cn = new conexionSQLN();
        public GestionPokemonesEntrenador()
        {
            InitializeComponent();
            PokemonesEntrenadorDG.DataSource = cn.ConsultaPokemonesEntrenador();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int i = Convert.ToInt32(Estado.SelectedItem);
            int i2 = Convert.ToInt32(txt_id_pokemon_entrenador.Text);
            cn.InsertarPokemonEntrenador(txt_id_entrenador_pokemon.Text, i2, Estado.GetItemText(Estado.SelectedItem));
            PokemonesEntrenadorDG.DataSource = cn.ConsultaPokemonesEntrenador();
            ModuloEntrenador v1 = new ModuloEntrenador();
            MessageBox.Show("¡Creado con éxito!");
            this.Hide();
            v1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i2 = Convert.ToInt32(txt_id_pokemon_entrenador.Text);
            cn.ModificarPokemonEntrenador(txt_id_entrenador_pokemon.Text, i2, Estado.GetItemText(Estado.SelectedItem));
            PokemonesEntrenadorDG.DataSource = cn.ConsultaPokemonesEntrenador();
            MessageBox.Show("¡Modificado!");
            ModuloEntrenador v1 = new ModuloEntrenador();
            this.Hide();
            v1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i2 = Convert.ToInt32(txt_id_pokemon_entrenador.Text);
            cn.EliminarPokemonEntrenador(txt_id_entrenador_pokemon.Text, i2);
            PokemonesEntrenadorDG.DataSource = cn.ConsultaPokemonesEntrenador();
            MessageBox.Show("¡Eliminado con éxito!");
            ModuloEntrenador v1 = new ModuloEntrenador();
            this.Hide();
            v1.Show();

        }

        private void GestionPokemonesEntrenador_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloEntrenador v1 = new ModuloEntrenador();
            v1.Show();
        }
    }
}

