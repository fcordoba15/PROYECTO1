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
            this.Hide();
            G_Admi_Pokemon_Agregar m1 = new G_Admi_Pokemon_Agregar();
            m1.Show();
         
           
        }

        private void EliminarPokEnt_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            G_EliminarPokAdmin m1 = new G_EliminarPokAdmin();
            m1.Show();

        }

        private void ModificarPokEnt_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            G_Admi_Pokemon_Modificar  m1 = new G_Admi_Pokemon_Modificar();
            m1.Show();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuloAdministrador m1 = new ModuloAdministrador();
            m1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
                   }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConsultaPokDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsultaPokEnt_Load(object sender, EventArgs e)
        {

        }
    }
}
