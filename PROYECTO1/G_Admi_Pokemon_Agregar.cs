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
    public partial class G_Admi_Pokemon_Agregar : Form
    {
        conexionSQLN cn = new conexionSQLN();
        public G_Admi_Pokemon_Agregar()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fotografia = new OpenFileDialog();
                DialogResult rs = fotografia.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    picPokemon.Image = Image.FromFile(fotografia.FileName);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Error! Vuelva a intentar " + ex.Message);
                VentanaInicio m3 = new VentanaInicio();
                m3.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
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

                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    picPokemon.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                    cn.InsertarPokemonAdministrador(Nombre_Pokemon.Text, ID_Tipo.Text, Codigo_Tipo.Text, Total.Text,
                    Salud.Text, Ataque.Text, Defensa.Text, Ataque_Especial.Text, Defensa_Especial.Text,
                    Velocidad.Text, Generacion.Text, comboBox1.Text, ms.GetBuffer());
                    
                    MessageBox.Show("Pokemon creado correctamente");
                    
                    this.Hide();
                    ConsultaPokEnt m2 = new ConsultaPokEnt();
                    m2.Show();

                    a++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Error! Vuelva a intentar" + ex.Message);
                VentanaInicio m3 = new VentanaInicio();
                m3.Show();

            }
        }

        private void G_Admi_Pokemon_Agregar_Load(object sender, EventArgs e)
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
