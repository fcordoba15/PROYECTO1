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
using Negocios;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data.SqlClient;

namespace PROYECTO1
{
    public partial class ModuloCliente : Form
    {

        conexionSQLN cn = new conexionSQLN();//Llamar a la clase

        public ModuloCliente()
        {
            InitializeComponent();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (Elemento.Text == "Entrenadores") //Validar
            {
                Tipo_movimiento.Hide();

                Categoria_pokemon.Hide();

                Tipo_pokemon.Hide();

                label1.Hide();

                label2.Hide();

                label5.Hide();

                Ubicacion_entrenador.Text = "Todas";

                Ubicacion_entrenador.Show();

                Nombre_entrenador.Text = "Todos";

                Nombre_entrenador.Show();

                label3.Show();

                label4.Show();

            }
            else if (Elemento.Text == "Movimientos")//Validar
            {
                Ubicacion_entrenador.Hide();

                Nombre_entrenador.Hide();

                Tipo_pokemon.Hide();

                Categoria_pokemon.Hide();

                label1.Hide();

                label2.Hide();

                label3.Hide();

                label4.Hide();

                Tipo_movimiento.Text = "Todos";

                Tipo_movimiento.Show();

                label5.Show();
            }
            else if (Elemento.Text == "Pokémon")//Validar
            {
                Ubicacion_entrenador.Hide();

                Nombre_entrenador.Hide();

                Tipo_movimiento.Hide();

                label3.Hide();

                label4.Hide();

                label5.Hide();

                Tipo_pokemon.Text = "Todos";

                Tipo_pokemon.Show();

                Categoria_pokemon.Text = "Todas";

                Categoria_pokemon.Show();

                label1.Show();

                label2.Show();
            }
            else//Validar
            {
                Ubicacion_entrenador.Text = "Todas";

                Ubicacion_entrenador.Show();

                Nombre_entrenador.Text = "Todos";

                Nombre_entrenador.Show();

                Tipo_movimiento.Text = "Todos";

                Tipo_movimiento.Show();

                Tipo_pokemon.Text = "Todos";

                Tipo_pokemon.Show();

                Categoria_pokemon.Text = "Todas";

                Categoria_pokemon.Show();

                label1.Show();

                label2.Show();

                label3.Show();

                label4.Show();

                label5.Show();

            }

        }

        private void Busqueda_Click(object sender, EventArgs e)
        {
            if (Elemento.Text == "Entrenadores") {
                Ver_datos.DataSource = cn.Cliente_entrenador(Ubicacion_entrenador.Text,Nombre_entrenador.Text); //Ver datos
            }

            else if (Elemento.Text == "Movimientos") {
                Ver_datos.DataSource = cn.Cliente_movimiento(Tipo_movimiento.Text);//Ver datos
            }


            else if (Elemento.Text == "Pokémon") {
                Ver_datos.DataSource = cn.Cliente_pokemon(Categoria_pokemon.Text, Tipo_pokemon.Text);//Ver datos
            }

            else {
                MessageBox.Show("Debe seleccionar lo que quiere buscar");//Ver datos
            }                      
        }

        private void volver_Click(object sender, EventArgs e)
        {
            VentanaRoles v1 = new VentanaRoles();//Crear ventana
            this.Hide();//Ocultar ventana actual
            v1.Show();// Mostrar ventana

        }

        
        private void PDF_Click(object sender, EventArgs e) //Crear PDF
        {
            BaseFont fuente = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable Tabla_PDF = new PdfPTable(Ver_datos.Columns.Count);
            Tabla_PDF.DefaultCell.Padding = 3;
            Tabla_PDF.WidthPercentage = 100;
            Tabla_PDF.HorizontalAlignment = Element.ALIGN_LEFT;
            Tabla_PDF.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font texto = new iTextSharp.text.Font(fuente, 10, iTextSharp.text.Font.NORMAL);

            foreach (DataGridViewColumn columna in Ver_datos.Columns)
            {
                PdfPCell celda = new PdfPCell(new Phrase(columna.HeaderText, texto));
                Tabla_PDF.AddCell(celda);
            }

            foreach (DataGridViewRow fila in Ver_datos.Rows)
            {
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    Tabla_PDF.AddCell(new Phrase(celda.Value.ToString(), texto));
                }
            }

            var Guardar_Archivo = new SaveFileDialog(); //Guadar PDF
            string nombre_archivo = DateTime.Now.ToString("dddd, dd MMMM yyyy HH-mm-ss"); //Formato de nombre
            Guardar_Archivo.FileName = nombre_archivo;
            Guardar_Archivo.DefaultExt = ".pdf";
            if (Guardar_Archivo.ShowDialog() == DialogResult.OK)//Validar
            {
                using (FileStream stream = new FileStream(Guardar_Archivo.FileName, FileMode.Create))
                {
                    Document documento = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(documento, stream);
                    documento.Open();
                    documento.Add(Tabla_PDF);
                    documento.Close();
                    stream.Close();
                }
            }
        }
    }
}


