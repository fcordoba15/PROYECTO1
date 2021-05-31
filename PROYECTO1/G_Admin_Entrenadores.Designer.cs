
namespace PROYECTO1
{
    partial class G_Admin_Entrenadores
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
            this.GestionEntrenadoresAdminDG = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ModificarEntrenador = new System.Windows.Forms.Button();
            this.EliminarEntrenador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GestionEntrenadoresAdminDG)).BeginInit();
            this.SuspendLayout();
            // 
            // GestionEntrenadoresAdminDG
            // 
            this.GestionEntrenadoresAdminDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GestionEntrenadoresAdminDG.Location = new System.Drawing.Point(23, 63);
            this.GestionEntrenadoresAdminDG.Margin = new System.Windows.Forms.Padding(2);
            this.GestionEntrenadoresAdminDG.Name = "GestionEntrenadoresAdminDG";
            this.GestionEntrenadoresAdminDG.RowHeadersWidth = 82;
            this.GestionEntrenadoresAdminDG.RowTemplate.Height = 33;
            this.GestionEntrenadoresAdminDG.Size = new System.Drawing.Size(617, 281);
            this.GestionEntrenadoresAdminDG.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(23, 360);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModificarEntrenador
            // 
            this.ModificarEntrenador.Location = new System.Drawing.Point(115, 360);
            this.ModificarEntrenador.Margin = new System.Windows.Forms.Padding(2);
            this.ModificarEntrenador.Name = "ModificarEntrenador";
            this.ModificarEntrenador.Size = new System.Drawing.Size(77, 27);
            this.ModificarEntrenador.TabIndex = 2;
            this.ModificarEntrenador.Text = "Modificar";
            this.ModificarEntrenador.UseVisualStyleBackColor = true;
            this.ModificarEntrenador.Click += new System.EventHandler(this.ModificarEntrenador_Click_1);
            // 
            // EliminarEntrenador
            // 
            this.EliminarEntrenador.BackColor = System.Drawing.Color.Red;
            this.EliminarEntrenador.Location = new System.Drawing.Point(206, 361);
            this.EliminarEntrenador.Margin = new System.Windows.Forms.Padding(2);
            this.EliminarEntrenador.Name = "EliminarEntrenador";
            this.EliminarEntrenador.Size = new System.Drawing.Size(74, 26);
            this.EliminarEntrenador.TabIndex = 3;
            this.EliminarEntrenador.Text = "Eliminar";
            this.EliminarEntrenador.UseVisualStyleBackColor = false;
            this.EliminarEntrenador.Click += new System.EventHandler(this.EliminarEntrenador_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "ENTRENADORES";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(563, 360);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // G_Admin_Entrenadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(670, 401);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EliminarEntrenador);
            this.Controls.Add(this.ModificarEntrenador);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GestionEntrenadoresAdminDG);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "G_Admin_Entrenadores";
            this.Text = "Gestion de Entrenadores";
            ((System.ComponentModel.ISupportInitialize)(this.GestionEntrenadoresAdminDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GestionEntrenadoresAdminDG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ModificarEntrenador;
        private System.Windows.Forms.Button EliminarEntrenador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}