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
    public partial class ModuloCliente : Form
    {

        conexionSQLN cn = new conexionSQLN();

        public ModuloCliente()
        {
            InitializeComponent();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (Elemento.Text == "Entrenadores")
            {
                Tipo_movimiento.Text = "NULL";

                Categoria_pokemon.Text = "NULL";

                Tipo_pokemon.Text = "NULL";

                Ubicacion_entrenador.Text = "Todas";

                Nombre_entrenador.Text = "Todos";
            }
            else if (Elemento.Text == "Movimientos")
            {
                Ubicacion_entrenador.Text = "NULL";

                Nombre_entrenador.Text = "NULL";

                Tipo_pokemon.Text = "NULL";

                Categoria_pokemon.Text = "NULL";

                Tipo_movimiento.Text = "Todos";
            }
            else if (Elemento.Text == "Pokémon")
            {
                Ubicacion_entrenador.Text = "NULL";

                Nombre_entrenador.Text = "NULL";

                Tipo_movimiento.Text = "NULL";

                Tipo_pokemon.Text = "Todos";

                Categoria_pokemon.Text = "Todas";

            }
            else
            {
                Ubicacion_entrenador.Text = "Todas";

                Nombre_entrenador.Text = "Todos";

                Tipo_movimiento.Text = "Todos";

                Tipo_pokemon.Text = "Todos";

                Categoria_pokemon.Text = "Todas";

            }

        }

        private void Busqueda_Click(object sender, EventArgs e)
        {
            if (Elemento.Text == "Entrenadores") {
                Ver_datos.DataSource = cn.Cliente_entrenador(Ubicacion_entrenador.Text,Nombre_entrenador.Text);
            }

            else if (Elemento.Text == "Movimientos") {
                Ver_datos.DataSource = cn.Cliente_movimiento(Tipo_movimiento.Text);
            }


            else if (Elemento.Text == "Pokémon") {
                Ver_datos.DataSource = cn.Cliente_pokemon(Categoria_pokemon.Text, Tipo_pokemon.Text);
            }

            else {
                MessageBox.Show("Debe seleccionar lo que quiere buscar");
            }                      
        }

        private void volver_Click(object sender, EventArgs e)
        {
            VentanaRoles v1 = new VentanaRoles();
            this.Hide();
            v1.Show();

        }
    }
}


