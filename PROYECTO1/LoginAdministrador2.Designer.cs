
namespace PROYECTO1
{
    partial class LoginAdministrador2
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
            this.Entrar = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.texto_contraseña = new System.Windows.Forms.Label();
            this.texto_usuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Entrar
            // 
            this.Entrar.BackColor = System.Drawing.Color.Red;
            this.Entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Entrar.Location = new System.Drawing.Point(43, 229);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(129, 42);
            this.Entrar.TabIndex = 14;
            this.Entrar.Text = "Ingresar";
            this.Entrar.UseVisualStyleBackColor = false;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(41, 174);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(286, 22);
            this.pass.TabIndex = 13;
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(41, 99);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(286, 22);
            this.usuario.TabIndex = 12;
            // 
            // texto_contraseña
            // 
            this.texto_contraseña.AutoSize = true;
            this.texto_contraseña.BackColor = System.Drawing.Color.Transparent;
            this.texto_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.texto_contraseña.ForeColor = System.Drawing.Color.Red;
            this.texto_contraseña.Location = new System.Drawing.Point(38, 142);
            this.texto_contraseña.Name = "texto_contraseña";
            this.texto_contraseña.Size = new System.Drawing.Size(114, 25);
            this.texto_contraseña.TabIndex = 11;
            this.texto_contraseña.Text = "Contraseña";
            // 
            // texto_usuario
            // 
            this.texto_usuario.AutoSize = true;
            this.texto_usuario.BackColor = System.Drawing.Color.Transparent;
            this.texto_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.texto_usuario.ForeColor = System.Drawing.Color.Red;
            this.texto_usuario.Location = new System.Drawing.Point(38, 63);
            this.texto_usuario.Name = "texto_usuario";
            this.texto_usuario.Size = new System.Drawing.Size(79, 25);
            this.texto_usuario.TabIndex = 10;
            this.texto_usuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Se necesita iniciar sesión";
            // 
            // LoginAdministrador2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTO1.Properties.Resources.Fondo_Login;
            this.ClientSize = new System.Drawing.Size(583, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.texto_contraseña);
            this.Controls.Add(this.texto_usuario);
            this.Name = "LoginAdministrador2";
            this.Text = "LoginAdministrador2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label texto_contraseña;
        private System.Windows.Forms.Label texto_usuario;
        private System.Windows.Forms.Label label1;
    }
}