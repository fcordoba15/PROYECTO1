
namespace PROYECTO1
{
    partial class ModuloCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tipo_movimiento = new System.Windows.Forms.ComboBox();
            this.Tipo_pokemon = new System.Windows.Forms.ComboBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.Fondo_ModuloCliente = new System.Windows.Forms.PictureBox();
            this.Elemento = new System.Windows.Forms.ComboBox();
            this.Categoria_pokemon = new System.Windows.Forms.ComboBox();
            this.Nombre_entrenador = new System.Windows.Forms.ComboBox();
            this.Ubicacion_entrenador = new System.Windows.Forms.ComboBox();
            this.Actualizar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ver_datos = new System.Windows.Forms.DataGridView();
            this.Busqueda = new System.Windows.Forms.Button();
            this.PDF = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Fondo_ModuloCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ver_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // Tipo_movimiento
            // 
            this.Tipo_movimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tipo_movimiento.FormattingEnabled = true;
            this.Tipo_movimiento.Items.AddRange(new object[] {
            "Todos",
            "Agua",
            "Fuego",
            "Hielo",
            "Veneno",
            "Planta",
            "Normal",
            "Lucha",
            "Electrico",
            "Roca"});
            this.Tipo_movimiento.Location = new System.Drawing.Point(113, 494);
            this.Tipo_movimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tipo_movimiento.Name = "Tipo_movimiento";
            this.Tipo_movimiento.Size = new System.Drawing.Size(121, 24);
            this.Tipo_movimiento.TabIndex = 0;
            // 
            // Tipo_pokemon
            // 
            this.Tipo_pokemon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tipo_pokemon.FormattingEnabled = true;
            this.Tipo_pokemon.Items.AddRange(new object[] {
            "Todos",
            "T-001",
            "T-002",
            "T-003",
            "T-004",
            "T-005",
            "T-006",
            "T-007",
            "T-008",
            "T-009",
            "T-010",
            "T-011",
            "T-012",
            "T-013",
            "T-014",
            "T-015",
            "T-016",
            "T-017",
            "T-018"});
            this.Tipo_pokemon.Location = new System.Drawing.Point(205, 283);
            this.Tipo_pokemon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tipo_pokemon.Name = "Tipo_pokemon";
            this.Tipo_pokemon.Size = new System.Drawing.Size(121, 24);
            this.Tipo_pokemon.TabIndex = 1;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Beige;
            this.Titulo.Font = new System.Drawing.Font("Matura MT Script Capitals", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Titulo.ForeColor = System.Drawing.Color.Gold;
            this.Titulo.Location = new System.Drawing.Point(341, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(265, 62);
            this.Titulo.TabIndex = 2;
            this.Titulo.Text = "Busquedas";
            // 
            // Fondo_ModuloCliente
            // 
            this.Fondo_ModuloCliente.BackColor = System.Drawing.Color.Cornsilk;
            this.Fondo_ModuloCliente.Image = global::PROYECTO1.Properties.Resources.Fondo_moduloCliente;
            this.Fondo_ModuloCliente.Location = new System.Drawing.Point(-1, 0);
            this.Fondo_ModuloCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fondo_ModuloCliente.Name = "Fondo_ModuloCliente";
            this.Fondo_ModuloCliente.Size = new System.Drawing.Size(1184, 542);
            this.Fondo_ModuloCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fondo_ModuloCliente.TabIndex = 3;
            this.Fondo_ModuloCliente.TabStop = false;
            // 
            // Elemento
            // 
            this.Elemento.BackColor = System.Drawing.SystemColors.Info;
            this.Elemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Elemento.FormattingEnabled = true;
            this.Elemento.Items.AddRange(new object[] {
            "Movimientos",
            "Entrenadores",
            "Pokémon"});
            this.Elemento.Location = new System.Drawing.Point(12, 117);
            this.Elemento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Elemento.Name = "Elemento";
            this.Elemento.Size = new System.Drawing.Size(313, 33);
            this.Elemento.TabIndex = 4;
            this.Elemento.Text = "Seleccione lo que quiere buscar";
            // 
            // Categoria_pokemon
            // 
            this.Categoria_pokemon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Categoria_pokemon.FormattingEnabled = true;
            this.Categoria_pokemon.Items.AddRange(new object[] {
            "Todas",
            "T-001",
            "T-002",
            "T-003",
            "T-004",
            "T-005",
            "T-006",
            "T-007",
            "T-008",
            "T-009",
            "T-010",
            "T-011",
            "T-012",
            "T-013",
            "T-014"});
            this.Categoria_pokemon.Location = new System.Drawing.Point(20, 278);
            this.Categoria_pokemon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Categoria_pokemon.Name = "Categoria_pokemon";
            this.Categoria_pokemon.Size = new System.Drawing.Size(121, 24);
            this.Categoria_pokemon.TabIndex = 5;
            // 
            // Nombre_entrenador
            // 
            this.Nombre_entrenador.FormattingEnabled = true;
            this.Nombre_entrenador.Items.AddRange(new object[] {
            "Todos",
            "<Escribir>"});
            this.Nombre_entrenador.Location = new System.Drawing.Point(205, 379);
            this.Nombre_entrenador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Nombre_entrenador.Name = "Nombre_entrenador";
            this.Nombre_entrenador.Size = new System.Drawing.Size(121, 24);
            this.Nombre_entrenador.TabIndex = 6;
            this.Nombre_entrenador.Text = "Todos";
            // 
            // Ubicacion_entrenador
            // 
            this.Ubicacion_entrenador.FormattingEnabled = true;
            this.Ubicacion_entrenador.Items.AddRange(new object[] {
            "Todos",
            "<Escribala si puede>"});
            this.Ubicacion_entrenador.Location = new System.Drawing.Point(12, 382);
            this.Ubicacion_entrenador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ubicacion_entrenador.Name = "Ubicacion_entrenador";
            this.Ubicacion_entrenador.Size = new System.Drawing.Size(121, 24);
            this.Ubicacion_entrenador.TabIndex = 7;
            this.Ubicacion_entrenador.Text = "Todas";
            // 
            // Actualizar
            // 
            this.Actualizar.BackColor = System.Drawing.Color.Beige;
            this.Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Actualizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Actualizar.Location = new System.Drawing.Point(12, 158);
            this.Actualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(315, 39);
            this.Actualizar.TabIndex = 8;
            this.Actualizar.Text = "Actualizar valores";
            this.Actualizar.UseVisualStyleBackColor = false;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightCoral;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(123, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 40);
            this.label5.TabIndex = 9;
            this.label5.Text = "   Tipo de \r\nmovimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(213, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 40);
            this.label2.TabIndex = 10;
            this.label2.Text = "    Tipo\r\n Pokémon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightCoral;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(213, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 40);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre\r\nEntrenador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(29, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Categoría \r\nPokémon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCoral;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(29, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 40);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ubicación\r\nEntrenador";
            // 
            // Ver_datos
            // 
            this.Ver_datos.AllowUserToAddRows = false;
            this.Ver_datos.BackgroundColor = System.Drawing.Color.Beige;
            this.Ver_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ver_datos.Location = new System.Drawing.Point(483, 158);
            this.Ver_datos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ver_datos.Name = "Ver_datos";
            this.Ver_datos.RowHeadersWidth = 51;
            this.Ver_datos.RowTemplate.Height = 24;
            this.Ver_datos.Size = new System.Drawing.Size(689, 322);
            this.Ver_datos.TabIndex = 14;
            // 
            // Busqueda
            // 
            this.Busqueda.BackColor = System.Drawing.Color.LightCoral;
            this.Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Busqueda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Busqueda.Location = new System.Drawing.Point(705, 111);
            this.Busqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(315, 39);
            this.Busqueda.TabIndex = 15;
            this.Busqueda.Text = "Realizar búsqueda";
            this.Busqueda.UseVisualStyleBackColor = false;
            this.Busqueda.Click += new System.EventHandler(this.Busqueda_Click);
            // 
            // PDF
            // 
            this.PDF.BackColor = System.Drawing.Color.LightCoral;
            this.PDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.PDF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PDF.Location = new System.Drawing.Point(705, 494);
            this.PDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PDF.Name = "PDF";
            this.PDF.Size = new System.Drawing.Size(315, 39);
            this.PDF.TabIndex = 16;
            this.PDF.Text = "Crear PDF";
            this.PDF.UseVisualStyleBackColor = false;
            this.PDF.Click += new System.EventHandler(this.PDF_Click);
            // 
            // volver
            // 
            this.volver.BackColor = System.Drawing.Color.LightCoral;
            this.volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volver.Location = new System.Drawing.Point(12, 9);
            this.volver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(83, 30);
            this.volver.TabIndex = 17;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = false;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // ModuloCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 544);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.PDF);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.Ver_datos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.Ubicacion_entrenador);
            this.Controls.Add(this.Nombre_entrenador);
            this.Controls.Add(this.Categoria_pokemon);
            this.Controls.Add(this.Elemento);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Tipo_pokemon);
            this.Controls.Add(this.Tipo_movimiento);
            this.Controls.Add(this.Fondo_ModuloCliente);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ModuloCliente";
            this.Text = "ModuloCliente";
            ((System.ComponentModel.ISupportInitialize)(this.Fondo_ModuloCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ver_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Tipo_movimiento;
        private System.Windows.Forms.ComboBox Tipo_pokemon;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.PictureBox Fondo_ModuloCliente;
        private System.Windows.Forms.ComboBox Elemento;
        private System.Windows.Forms.ComboBox Categoria_pokemon;
        private System.Windows.Forms.ComboBox Nombre_entrenador;
        private System.Windows.Forms.ComboBox Ubicacion_entrenador;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Ver_datos;
        private System.Windows.Forms.Button Busqueda;
        private System.Windows.Forms.Button PDF;
        private System.Windows.Forms.Button volver;
    }
}