
namespace PROYECTO1
{
    partial class VentanaInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.boton_empezar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boton_empezar
            // 
            this.boton_empezar.BackColor = System.Drawing.Color.DeepPink;
            this.boton_empezar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.boton_empezar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.boton_empezar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.boton_empezar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.boton_empezar.Location = new System.Drawing.Point(247, 112);
            this.boton_empezar.Name = "boton_empezar";
            this.boton_empezar.Size = new System.Drawing.Size(258, 63);
            this.boton_empezar.TabIndex = 0;
            this.boton_empezar.Text = "Iniciar";
            this.boton_empezar.UseVisualStyleBackColor = false;
            this.boton_empezar.Click += new System.EventHandler(this.boton_empezar_Click);
            // 
            // VentanaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTO1.Properties.Resources.Fondo_inicial;
            this.ClientSize = new System.Drawing.Size(723, 409);
            this.Controls.Add(this.boton_empezar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VentanaInicio";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton_empezar;
    }
}

