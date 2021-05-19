
namespace PROYECTO1
{
    partial class VentanaLogin
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
            this.texto_usuario = new System.Windows.Forms.Label();
            this.texto_contraseña = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texto_usuario
            // 
            this.texto_usuario.AutoSize = true;
            this.texto_usuario.BackColor = System.Drawing.Color.Transparent;
            this.texto_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.texto_usuario.ForeColor = System.Drawing.Color.Red;
            this.texto_usuario.Location = new System.Drawing.Point(43, 19);
            this.texto_usuario.Name = "texto_usuario";
            this.texto_usuario.Size = new System.Drawing.Size(79, 25);
            this.texto_usuario.TabIndex = 0;
            this.texto_usuario.Text = "Usuario";
            // 
            // texto_contraseña
            // 
            this.texto_contraseña.AutoSize = true;
            this.texto_contraseña.BackColor = System.Drawing.Color.Transparent;
            this.texto_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.texto_contraseña.ForeColor = System.Drawing.Color.Red;
            this.texto_contraseña.Location = new System.Drawing.Point(43, 98);
            this.texto_contraseña.Name = "texto_contraseña";
            this.texto_contraseña.Size = new System.Drawing.Size(114, 25);
            this.texto_contraseña.TabIndex = 1;
            this.texto_contraseña.Text = "Contraseña";
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(46, 55);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(286, 22);
            this.usuario.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(46, 130);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(286, 22);
            this.pass.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button1.Location = new System.Drawing.Point(48, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VentanaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTO1.Properties.Resources.Fondo_Login;
            this.ClientSize = new System.Drawing.Size(582, 281);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.texto_contraseña);
            this.Controls.Add(this.texto_usuario);
            this.Name = "VentanaLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label texto_usuario;
        private System.Windows.Forms.Label texto_contraseña;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button button1;
    }
}