
namespace PROYECTO1
{
    partial class GestionPokemonesEntrenador
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
            this.PokemonesEntrenadorDG = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id_entrenador_pokemon = new System.Windows.Forms.TextBox();
            this.txt_id_pokemon_entrenador = new System.Windows.Forms.TextBox();
            this.Estado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonesEntrenadorDG)).BeginInit();
            this.SuspendLayout();
            // 
            // PokemonesEntrenadorDG
            // 
            this.PokemonesEntrenadorDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PokemonesEntrenadorDG.Location = new System.Drawing.Point(0, 4);
            this.PokemonesEntrenadorDG.Name = "PokemonesEntrenadorDG";
            this.PokemonesEntrenadorDG.RowHeadersWidth = 82;
            this.PokemonesEntrenadorDG.RowTemplate.Height = 33;
            this.PokemonesEntrenadorDG.Size = new System.Drawing.Size(1190, 329);
            this.PokemonesEntrenadorDG.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 594);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(430, 594);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1016, 594);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "Regresar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Entrenador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID Pokemon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estado";
            // 
            // txt_id_entrenador_pokemon
            // 
            this.txt_id_entrenador_pokemon.Location = new System.Drawing.Point(44, 486);
            this.txt_id_entrenador_pokemon.Name = "txt_id_entrenador_pokemon";
            this.txt_id_entrenador_pokemon.Size = new System.Drawing.Size(100, 31);
            this.txt_id_entrenador_pokemon.TabIndex = 8;
            // 
            // txt_id_pokemon_entrenador
            // 
            this.txt_id_pokemon_entrenador.Location = new System.Drawing.Point(234, 485);
            this.txt_id_pokemon_entrenador.Name = "txt_id_pokemon_entrenador";
            this.txt_id_pokemon_entrenador.Size = new System.Drawing.Size(100, 31);
            this.txt_id_pokemon_entrenador.TabIndex = 9;
            // 
            // Estado
            // 
            this.Estado.FormattingEnabled = true;
            this.Estado.Items.AddRange(new object[] {
            "En equipo",
            "En reserva",
            "Liberado"});
            this.Estado.Location = new System.Drawing.Point(430, 483);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(155, 33);
            this.Estado.TabIndex = 11;
            // 
            // GestionPokemonesEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 675);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.txt_id_pokemon_entrenador);
            this.Controls.Add(this.txt_id_entrenador_pokemon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PokemonesEntrenadorDG);
            this.Name = "GestionPokemonesEntrenador";
            this.Text = "Gestion Pokemones Entrenador";
            ((System.ComponentModel.ISupportInitialize)(this.PokemonesEntrenadorDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PokemonesEntrenadorDG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id_entrenador_pokemon;
        private System.Windows.Forms.TextBox txt_id_pokemon_entrenador;
        private System.Windows.Forms.ComboBox Estado;
    }
}