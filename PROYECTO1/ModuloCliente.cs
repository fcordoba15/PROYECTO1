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

        
        private void PDF_Click(object sender, EventArgs e)
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

            var Guardar_Archivo = new SaveFileDialog();
            string nombre_archivo = DateTime.Now.ToString("dddd, dd MMMM yyyy HH-mm-ss");
            Guardar_Archivo.FileName = nombre_archivo;
            Guardar_Archivo.DefaultExt = ".pdf";
            if (Guardar_Archivo.ShowDialog() == DialogResult.OK)
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


