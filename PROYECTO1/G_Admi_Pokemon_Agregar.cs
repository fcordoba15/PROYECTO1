// Bibliotecas a utilizar
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
        conexionSQLN cn = new conexionSQLN();  // Llamar a la clase
        public G_Admi_Pokemon_Agregar()
        {
            InitializeComponent();  // Iniciar ventana


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try  //Intentar realizar lo siguiente
            {
                OpenFileDialog fotografia = new OpenFileDialog();  // Abrir para seleccionar fotografía
                DialogResult rs = fotografia.ShowDialog(); // Mostrar
                if (rs == DialogResult.OK)
                {
                    picPokemon.Image = Image.FromFile(fotografia.FileName); //Guardar la fotografía


                }
            }
            catch (Exception ex) //En caso de errores
            {
                MessageBox.Show("¡Error! Vuelva a intentar " + ex.Message); //Mostrar mensaje de error
                VentanaInicio m3 = new VentanaInicio(); //Crear ventana
                m3.Show(); //Mostrar ventana

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
                        if (c == p[0])                    //Validar
                            validación_comilla++;
                    }
                    foreach (char c in Codigo_Tipo.Text)
                    {
                        if (c == p[0])                       //Validar
                            validación_comilla++;
                    }
                    foreach (char c in Nombre_Pokemon.Text)
                    {
                        if (c == p[0])                          //Validar
                            validación_comilla++;
                    }
                    if (validación_comilla > 0)                  //Validar
                    {
                        MessageBox.Show("¡Error! No debe ingresar información con comillas simples"); //Mensaje de error
                        break;
                    }

                    //------------- REGISTRO EN LA BASE DE DATOS -------------
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    picPokemon.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);  

                    cn.InsertarPokemonAdministrador(Nombre_Pokemon.Text, ID_Tipo.Text, Codigo_Tipo.Text, Total.Text,
                    Salud.Text, Ataque.Text, Defensa.Text, Ataque_Especial.Text, Defensa_Especial.Text,
                    Velocidad.Text, Generacion.Text, comboBox1.Text, ms.GetBuffer());  //Insertar datos
                    
                    MessageBox.Show("Pokemon creado correctamente");  //Mensaje
                    
                    this.Hide();  //Ocultar ventana catual
                    ConsultaPokEnt m2 = new ConsultaPokEnt(); //Crear ventana
                    m2.Show();   // Mostrar ventana

                    a++;
                }
            }
            catch (Exception ex)   //Validar errores
            {
                MessageBox.Show("¡Error! Vuelva a intentar" + ex.Message);  //Mostrar mensaje de errores
                VentanaInicio m3 = new VentanaInicio();  //Crear ventana
                m3.Show();  //Mostrar ventana

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();       //Ocultar ventana
            ModuloAdministrador v1 = new ModuloAdministrador();  //Crear ventana
            v1.Show();  //Mostrar ventana
        }
    }
}
