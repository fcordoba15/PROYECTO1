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
            int i = Convert.ToInt32(Estado.SelectedItem);
            int i2 = Convert.ToInt32(txt_id_pokemon_entrenador);
           // cn.InsertarPokemonEntrenador(txt_id_entrenador_pokemon.Text, i2, Estado);
            PokemonesEntrenadorDG.DataSource = cn.ConsultaPokemonesEntrenador();
        }
    }
}
