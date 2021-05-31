//Bibliotecas que se van a utilizar

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
        conexionSQLN cn = new conexionSQLN();  //Llamar a la clase
        public ConsultaPokEnt()
        {
            InitializeComponent();
            ConsultaPokDG.DataSource = cn.ConsultaPokemonDT();  //Hacer consulta 
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            this.Hide();      //Ocultar ventana actual
            G_Admi_Pokemon_Agregar m1 = new G_Admi_Pokemon_Agregar();  // Crear ventana
            m1.Show();  //Mostrar ventana
         
           
        }

        private void EliminarPokEnt_Click_1(object sender, EventArgs e)
        {
            this.Hide();  //Ocultar ventana
            G_EliminarPokAdmin m1 = new G_EliminarPokAdmin();  //Crear ventana
            m1.Show();  // Mostrar ventana

        }

        private void ModificarPokEnt_Click_1(object sender, EventArgs e)
        {
            this.Hide();  // Ocultar ventana
            G_Admi_Pokemon_Modificar  m1 = new G_Admi_Pokemon_Modificar();  // Crear ventana
            m1.Show(); // Mostrar ventana
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();  // Ocultar ventana
            ModuloAdministrador m1 = new ModuloAdministrador(); // Crear ventana
            m1.Show(); // Mostrar ventana

        }

    }
}
