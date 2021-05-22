
namespace PROYECTO1
{
    partial class VentanaRoles
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Mensaje = new System.Windows.Forms.Label();
            this.iniciar_administrador = new System.Windows.Forms.Button();
            this.iniciar_cliente = new System.Windows.Forms.Button();
            this.iniciar_entrenador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PROYECTO1.Properties.Resources.Entrenador2;
            this.pictureBox3.Location = new System.Drawing.Point(292, 341);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(399, 189);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PROYECTO1.Properties.Resources.Cliente1;
            this.pictureBox2.Location = new System.Drawing.Point(700, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(239, 245);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PROYECTO1.Properties.Resources.Administrador1;
            this.pictureBox1.Location = new System.Drawing.Point(28, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Mensaje
            // 
            this.Mensaje.AutoSize = true;
            this.Mensaje.Font = new System.Drawing.Font("Matura MT Script Capitals", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Mensaje.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Mensaje.Location = new System.Drawing.Point(321, 18);
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.Size = new System.Drawing.Size(321, 50);
            this.Mensaje.TabIndex = 3;
            this.Mensaje.Text = "Seleccione su Rol";
            // 
            // iniciar_administrador
            // 
            this.iniciar_administrador.BackColor = System.Drawing.SystemColors.HotTrack;
            this.iniciar_administrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iniciar_administrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.iniciar_administrador.Location = new System.Drawing.Point(56, 341);
            this.iniciar_administrador.Name = "iniciar_administrador";
            this.iniciar_administrador.Size = new System.Drawing.Size(159, 50);
            this.iniciar_administrador.TabIndex = 4;
            this.iniciar_administrador.Text = "Administrador";
            this.iniciar_administrador.UseVisualStyleBackColor = false;
            this.iniciar_administrador.Click += new System.EventHandler(this.iniciar_administrador_Click);
            // 
            // iniciar_cliente
            // 
            this.iniciar_cliente.BackColor = System.Drawing.SystemColors.HotTrack;
            this.iniciar_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iniciar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.iniciar_cliente.Location = new System.Drawing.Point(749, 341);
            this.iniciar_cliente.Name = "iniciar_cliente";
            this.iniciar_cliente.Size = new System.Drawing.Size(165, 50);
            this.iniciar_cliente.TabIndex = 5;
            this.iniciar_cliente.Text = "Cliente";
            this.iniciar_cliente.UseVisualStyleBackColor = false;
            this.iniciar_cliente.Click += new System.EventHandler(this.iniciar_cliente_Click);
            // 
            // iniciar_entrenador
            // 
            this.iniciar_entrenador.BackColor = System.Drawing.SystemColors.HotTrack;
            this.iniciar_entrenador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iniciar_entrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.iniciar_entrenador.Location = new System.Drawing.Point(434, 536);
            this.iniciar_entrenador.Name = "iniciar_entrenador";
            this.iniciar_entrenador.Size = new System.Drawing.Size(159, 55);
            this.iniciar_entrenador.TabIndex = 6;
            this.iniciar_entrenador.Text = "Entrenador";
            this.iniciar_entrenador.UseVisualStyleBackColor = false;
            this.iniciar_entrenador.Click += new System.EventHandler(this.iniciar_entrenador_Click);
            // 
            // VentanaRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(964, 621);
            this.Controls.Add(this.iniciar_entrenador);
            this.Controls.Add(this.iniciar_cliente);
            this.Controls.Add(this.iniciar_administrador);
            this.Controls.Add(this.Mensaje);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VentanaRoles";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Mensaje;
        private System.Windows.Forms.Button iniciar_administrador;
        private System.Windows.Forms.Button iniciar_cliente;
        private System.Windows.Forms.Button iniciar_entrenador;
    }
}