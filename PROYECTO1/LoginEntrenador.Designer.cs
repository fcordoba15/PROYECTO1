
namespace PROYECTO1
{
    partial class LoginEntrenador
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
            this.Entrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texto_usuario
            // 
            this.texto_usuario.AutoSize = true;
            this.texto_usuario.BackColor = System.Drawing.Color.Transparent;
            this.texto_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.texto_usuario.ForeColor = System.Drawing.Color.Red;
            this.texto_usuario.Location = new System.Drawing.Point(64, 30);
            this.texto_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.texto_usuario.Name = "texto_usuario";
            this.texto_usuario.Size = new System.Drawing.Size(128, 37);
            this.texto_usuario.TabIndex = 0;
            this.texto_usuario.Text = "Usuario";
            // 
            // texto_contraseña
            // 
            this.texto_contraseña.AutoSize = true;
            this.texto_contraseña.BackColor = System.Drawing.Color.Transparent;
            this.texto_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.texto_contraseña.ForeColor = System.Drawing.Color.Red;
            this.texto_contraseña.Location = new System.Drawing.Point(64, 153);
            this.texto_contraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.texto_contraseña.Name = "texto_contraseña";
            this.texto_contraseña.Size = new System.Drawing.Size(183, 37);
            this.texto_contraseña.TabIndex = 1;
            this.texto_contraseña.Text = "Contraseña";
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(69, 86);
            this.usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(427, 31);
            this.usuario.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(69, 203);
            this.pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(427, 31);
            this.pass.TabIndex = 3;
            // 
            // Entrar
            // 
            this.Entrar.BackColor = System.Drawing.Color.Red;
            this.Entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Entrar.Location = new System.Drawing.Point(72, 289);
            this.Entrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(194, 66);
            this.Entrar.TabIndex = 4;
            this.Entrar.Text = "Ingresar";
            this.Entrar.UseVisualStyleBackColor = false;
            this.Entrar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // VentanaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTO1.Properties.Resources.Fondo_Login;
            this.ClientSize = new System.Drawing.Size(873, 439);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.texto_contraseña);
            this.Controls.Add(this.texto_usuario);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button Entrar;
    }
}