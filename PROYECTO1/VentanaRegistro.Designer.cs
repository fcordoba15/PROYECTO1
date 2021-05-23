
namespace PROYECTO1
{
    partial class VentanaRegistro
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
            this.Registrar_cliente = new System.Windows.Forms.Button();
            this.Registrar_administrador = new System.Windows.Forms.Button();
            this.Mensaje2 = new System.Windows.Forms.Label();
            this.Registrar_entrenador = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Registrar_cliente
            // 
            this.Registrar_cliente.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Registrar_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registrar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Registrar_cliente.Location = new System.Drawing.Point(798, 334);
            this.Registrar_cliente.Name = "Registrar_cliente";
            this.Registrar_cliente.Size = new System.Drawing.Size(219, 50);
            this.Registrar_cliente.TabIndex = 11;
            this.Registrar_cliente.Text = "Registrar Cliente";
            this.Registrar_cliente.UseVisualStyleBackColor = false;
            this.Registrar_cliente.Click += new System.EventHandler(this.Registrar_cliente_Click);
            // 
            // Registrar_administrador
            // 
            this.Registrar_administrador.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Registrar_administrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registrar_administrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Registrar_administrador.Location = new System.Drawing.Point(24, 321);
            this.Registrar_administrador.Name = "Registrar_administrador";
            this.Registrar_administrador.Size = new System.Drawing.Size(268, 50);
            this.Registrar_administrador.TabIndex = 10;
            this.Registrar_administrador.Text = "Registrar Administrador";
            this.Registrar_administrador.UseVisualStyleBackColor = false;
            this.Registrar_administrador.Click += new System.EventHandler(this.Registrar_administrador_Click);
            // 
            // Mensaje2
            // 
            this.Mensaje2.AutoSize = true;
            this.Mensaje2.Font = new System.Drawing.Font("Matura MT Script Capitals", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Mensaje2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Mensaje2.Location = new System.Drawing.Point(403, 9);
            this.Mensaje2.Name = "Mensaje2";
            this.Mensaje2.Size = new System.Drawing.Size(258, 50);
            this.Mensaje2.TabIndex = 9;
            this.Mensaje2.Text = "Registrar Rol";
            // 
            // Registrar_entrenador
            // 
            this.Registrar_entrenador.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Registrar_entrenador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registrar_entrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Registrar_entrenador.Location = new System.Drawing.Point(414, 529);
            this.Registrar_entrenador.Name = "Registrar_entrenador";
            this.Registrar_entrenador.Size = new System.Drawing.Size(247, 55);
            this.Registrar_entrenador.TabIndex = 12;
            this.Registrar_entrenador.Text = "Registrar Entrenador";
            this.Registrar_entrenador.UseVisualStyleBackColor = false;
            this.Registrar_entrenador.Click += new System.EventHandler(this.Registrar_entrenador_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::PROYECTO1.Properties.Resources.Entrenador2;
            this.pictureBox6.Location = new System.Drawing.Point(326, 334);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(399, 189);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PROYECTO1.Properties.Resources.Cliente1;
            this.pictureBox5.Location = new System.Drawing.Point(778, 70);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(239, 245);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::PROYECTO1.Properties.Resources.Administrador1;
            this.pictureBox4.Location = new System.Drawing.Point(37, 70);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(236, 245);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // VentanaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 621);
            this.Controls.Add(this.Registrar_entrenador);
            this.Controls.Add(this.Registrar_cliente);
            this.Controls.Add(this.Registrar_administrador);
            this.Controls.Add(this.Mensaje2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Name = "VentanaRegistro";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registrar_cliente;
        private System.Windows.Forms.Button Registrar_administrador;
        private System.Windows.Forms.Label Mensaje2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button Registrar_entrenador;
    }
}