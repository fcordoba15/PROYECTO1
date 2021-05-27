
namespace PROYECTO1
{
    partial class ConsultaPokEnt
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
            this.ConsultaPokDG = new System.Windows.Forms.DataGridView();
            this.Regresar = new System.Windows.Forms.Button();
            this.ModificarPokEnt = new System.Windows.Forms.Button();
            this.CrearPok = new System.Windows.Forms.Button();
            this.EliminarPokEnt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaPokDG)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultaPokDG
            // 
            this.ConsultaPokDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaPokDG.Location = new System.Drawing.Point(11, 62);
            this.ConsultaPokDG.Margin = new System.Windows.Forms.Padding(2);
            this.ConsultaPokDG.Name = "ConsultaPokDG";
            this.ConsultaPokDG.RowHeadersWidth = 82;
            this.ConsultaPokDG.RowTemplate.Height = 33;
            this.ConsultaPokDG.Size = new System.Drawing.Size(686, 223);
            this.ConsultaPokDG.TabIndex = 0;
            this.ConsultaPokDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConsultaPokDG_CellContentClick);
            // 
            // Regresar
            // 
            this.Regresar.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regresar.Location = new System.Drawing.Point(623, 321);
            this.Regresar.Margin = new System.Windows.Forms.Padding(2);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(64, 26);
            this.Regresar.TabIndex = 1;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = true;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // ModificarPokEnt
            // 
            this.ModificarPokEnt.BackColor = System.Drawing.Color.White;
            this.ModificarPokEnt.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarPokEnt.Location = new System.Drawing.Point(100, 319);
            this.ModificarPokEnt.Margin = new System.Windows.Forms.Padding(2);
            this.ModificarPokEnt.Name = "ModificarPokEnt";
            this.ModificarPokEnt.Size = new System.Drawing.Size(78, 31);
            this.ModificarPokEnt.TabIndex = 2;
            this.ModificarPokEnt.Text = "Modificar";
            this.ModificarPokEnt.UseVisualStyleBackColor = false;
            this.ModificarPokEnt.Click += new System.EventHandler(this.ModificarPokEnt_Click_1);
            // 
            // CrearPok
            // 
            this.CrearPok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CrearPok.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CrearPok.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearPok.Location = new System.Drawing.Point(20, 319);
            this.CrearPok.Margin = new System.Windows.Forms.Padding(2);
            this.CrearPok.Name = "CrearPok";
            this.CrearPok.Size = new System.Drawing.Size(76, 31);
            this.CrearPok.TabIndex = 3;
            this.CrearPok.Text = "Crear";
            this.CrearPok.UseVisualStyleBackColor = false;
            this.CrearPok.Click += new System.EventHandler(this.Crear_Click);
            // 
            // EliminarPokEnt
            // 
            this.EliminarPokEnt.BackColor = System.Drawing.Color.Red;
            this.EliminarPokEnt.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarPokEnt.Location = new System.Drawing.Point(182, 319);
            this.EliminarPokEnt.Margin = new System.Windows.Forms.Padding(2);
            this.EliminarPokEnt.Name = "EliminarPokEnt";
            this.EliminarPokEnt.Size = new System.Drawing.Size(79, 31);
            this.EliminarPokEnt.TabIndex = 4;
            this.EliminarPokEnt.Text = "Eliminar";
            this.EliminarPokEnt.UseVisualStyleBackColor = false;
            this.EliminarPokEnt.Click += new System.EventHandler(this.EliminarPokEnt_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "POKEMON";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConsultaPokEnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 365);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EliminarPokEnt);
            this.Controls.Add(this.CrearPok);
            this.Controls.Add(this.ModificarPokEnt);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.ConsultaPokDG);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultaPokEnt";
            this.Text = "Gestion Pokemon Administrador";
            this.Load += new System.EventHandler(this.ConsultaPokEnt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaPokDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ConsultaPokDG;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Button ModificarPokEnt;
        private System.Windows.Forms.Button CrearPok;
        private System.Windows.Forms.Button EliminarPokEnt;
        private System.Windows.Forms.Label label1;
    }
}