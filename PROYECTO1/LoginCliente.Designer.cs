﻿
namespace PROYECTO1
{
    partial class LoginCliente
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
            this.SuspendLayout();
            // 
            // Entrar
            // 
            this.Entrar.BackColor = System.Drawing.Color.Red;
            this.Entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Entrar.Location = new System.Drawing.Point(32, 151);
            this.Entrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(97, 34);
            this.Entrar.TabIndex = 9;
            this.Entrar.Text = "Ingresar";
            this.Entrar.UseVisualStyleBackColor = false;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(31, 106);
            this.pass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(216, 20);
            this.pass.TabIndex = 8;
            this.pass.UseSystemPasswordChar = true;
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(31, 46);
            this.usuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(216, 20);
            this.usuario.TabIndex = 7;
            // 
            // texto_contraseña
            // 
            this.texto_contraseña.AutoSize = true;
            this.texto_contraseña.BackColor = System.Drawing.Color.Transparent;
            this.texto_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.texto_contraseña.ForeColor = System.Drawing.Color.Red;
            this.texto_contraseña.Location = new System.Drawing.Point(28, 80);
            this.texto_contraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.texto_contraseña.Name = "texto_contraseña";
            this.texto_contraseña.Size = new System.Drawing.Size(92, 20);
            this.texto_contraseña.TabIndex = 6;
            this.texto_contraseña.Text = "Contraseña";
            // 
            // texto_usuario
            // 
            this.texto_usuario.AutoSize = true;
            this.texto_usuario.BackColor = System.Drawing.Color.Transparent;
            this.texto_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.texto_usuario.ForeColor = System.Drawing.Color.Red;
            this.texto_usuario.Location = new System.Drawing.Point(28, 16);
            this.texto_usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.texto_usuario.Name = "texto_usuario";
            this.texto_usuario.Size = new System.Drawing.Size(64, 20);
            this.texto_usuario.TabIndex = 5;
            this.texto_usuario.Text = "Usuario";
            // 
            // LoginCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTO1.Properties.Resources.Fondo_Login;
            this.ClientSize = new System.Drawing.Size(435, 233);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.texto_contraseña);
            this.Controls.Add(this.texto_usuario);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginCliente";
            this.Text = "LoginCliente";
            this.Load += new System.EventHandler(this.LoginCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label texto_contraseña;
        private System.Windows.Forms.Label texto_usuario;
    }
}