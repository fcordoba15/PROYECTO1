
namespace PROYECTO1
{
    partial class RegistroAdministrador
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
            this.Realizar_registro_cliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Realizar_registro_cliente
            // 
            this.Realizar_registro_cliente.BackColor = System.Drawing.Color.RoyalBlue;
            this.Realizar_registro_cliente.Font = new System.Drawing.Font("Kristen ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Realizar_registro_cliente.Location = new System.Drawing.Point(168, 22);
            this.Realizar_registro_cliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Realizar_registro_cliente.Name = "Realizar_registro_cliente";
            this.Realizar_registro_cliente.Size = new System.Drawing.Size(308, 41);
            this.Realizar_registro_cliente.TabIndex = 32;
            this.Realizar_registro_cliente.Text = "Registrar";
            this.Realizar_registro_cliente.UseVisualStyleBackColor = false;
            this.Realizar_registro_cliente.Click += new System.EventHandler(this.Realizar_registro_cliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(106, 286);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Llave de encriptación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(106, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(106, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nombre de usuario";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(351, 286);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(277, 20);
            this.textBox3.TabIndex = 28;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(351, 213);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(277, 20);
            this.textBox2.TabIndex = 27;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(351, 147);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 20);
            this.textBox1.TabIndex = 26;
            // 
            // volver
            // 
            this.volver.BackColor = System.Drawing.SystemColors.HotTrack;
            this.volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volver.Location = new System.Drawing.Point(16, 10);
            this.volver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(62, 24);
            this.volver.TabIndex = 33;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = false;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // RegistroAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTO1.Properties.Resources.fondo_RegistroAdministratores;
            this.ClientSize = new System.Drawing.Size(657, 415);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.Realizar_registro_cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegistroAdministrador";
            this.Text = "RegistroAdministrador";
            this.Load += new System.EventHandler(this.RegistroAdministrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Realizar_registro_cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button volver;
    }
}