//Biblioteca que se van a utilizar

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
        conexionSQLN cn = new conexionSQLN(); //Llamar a la clase
        public GestionPokemonesEntrenador()
        {
            InitializeComponent();
            PokemonesEntrenadorDG.DataSource = cn.ConsultaPokemonesEntrenador(); //Consultar datos
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int i = Convert.ToInt32(Estado.SelectedItem);
            int i2 = Convert.ToInt32(txt_id_pokemon_entrenador.Text);
            cn.InsertarPokemonEntrenador(txt_id_entrenador_pokemon.Text, i2, Estado.GetItemText(Estado.SelectedItem));
            PokemonesEntrenadorDG.DataSource = cn.ConsultaPokemonesEntrenador(); //Consultar datos
            ModuloEntrenador v1 = new ModuloEntrenador(); //Crear ventana
            MessageBox.Show("¡Creado con éxito!"); //Mensjae
            this.Hide(); //Ocultar ventana actual
            v1.Show(); // Mostrar ventana
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try //Validar
            {
                int i2 = Convert.ToInt32(txt_id_pokemon_entrenador.Text);
                cn.ModificarPokemonEntrenador(txt_id_entrenador_pokemon.Text, i2, Estado.GetItemText(Estado.SelectedItem));
                PokemonesEntrenadorDG.DataSource = cn.ConsultaPokemonesEntrenador(); //Consultar datos
                MessageBox.Show("¡Modificado!"); //Mensaje
                ModuloEntrenador v1 = new ModuloEntrenador(); //Crear ventana
                this.Hide();//Ocultar ventana actual
                v1.Show();// Mostrar ventana
            }
            catch (Exception ex)//Validar
            {

                MessageBox.Show("Error" + ex);//Mensaje
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try//Validar
            {
                int i2 = Convert.ToInt32(txt_id_pokemon_entrenador.Text);
                cn.EliminarPokemonEntrenador(txt_id_entrenador_pokemon.Text, i2);
                PokemonesEntrenadorDG.DataSource = cn.ConsultaPokemonesEntrenador();//Consultar datos
                MessageBox.Show("¡Eliminado con éxito!");//Mensaje
                ModuloEntrenador v1 = new ModuloEntrenador();//Crear ventana
                this.Hide();//Ocultar ventana actual
                v1.Show();// Mostrar ventana
            }
            catch (Exception ex)//Validar
            {
                MessageBox.Show("Error:"+ex);

            }

        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();//Ocultar ventana actual
            ModuloEntrenador v3 = new ModuloEntrenador();//Crear ventana
            v3.Show();// Mostrar ventana 
        }
    }
}

