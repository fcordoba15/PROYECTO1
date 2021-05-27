
namespace PROYECTO1
{
    partial class G_Admin_Usuarios
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
            this.CrearUsuario = new System.Windows.Forms.Button();
            this.ModificarUsuario = new System.Windows.Forms.Button();
            this.EliminarUsuario = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.combo_Rol = new System.Windows.Forms.ComboBox();
            this.AdminUsuariosDG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AdminUsuariosDG)).BeginInit();
            this.SuspendLayout();
            // 
            // CrearUsuario
            // 
            this.CrearUsuario.Location = new System.Drawing.Point(16, 292);
            this.CrearUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CrearUsuario.Name = "CrearUsuario";
            this.CrearUsuario.Size = new System.Drawing.Size(52, 21);
            this.CrearUsuario.TabIndex = 0;
            this.CrearUsuario.Text = "Crear";
            this.CrearUsuario.UseVisualStyleBackColor = true;
            this.CrearUsuario.Click += new System.EventHandler(this.CrearUsuario_Click);
            // 
            // ModificarUsuario
            // 
            this.ModificarUsuario.Location = new System.Drawing.Point(130, 291);
            this.ModificarUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModificarUsuario.Name = "ModificarUsuario";
            this.ModificarUsuario.Size = new System.Drawing.Size(56, 22);
            this.ModificarUsuario.TabIndex = 1;
            this.ModificarUsuario.Text = "Modificar";
            this.ModificarUsuario.UseVisualStyleBackColor = true;
            this.ModificarUsuario.Click += new System.EventHandler(this.ModificarUsuario_Click);
            // 
            // EliminarUsuario
            // 
            this.EliminarUsuario.Location = new System.Drawing.Point(236, 291);
            this.EliminarUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EliminarUsuario.Name = "EliminarUsuario";
            this.EliminarUsuario.Size = new System.Drawing.Size(58, 22);
            this.EliminarUsuario.TabIndex = 2;
            this.EliminarUsuario.Text = "Eliminar";
            this.EliminarUsuario.UseVisualStyleBackColor = true;
            this.EliminarUsuario.Click += new System.EventHandler(this.EliminarUsuario_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(496, 292);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Regresar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rol";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(16, 240);
            this.txt_Usuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(52, 20);
            this.txt_Usuario.TabIndex = 7;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(130, 240);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(52, 20);
            this.txt_Password.TabIndex = 8;
            // 
            // combo_Rol
            // 
            this.combo_Rol.FormattingEnabled = true;
            this.combo_Rol.Items.AddRange(new object[] {
            "Administrador",
            "Entrenador",
            "Cliente"});
            this.combo_Rol.Location = new System.Drawing.Point(234, 239);
            this.combo_Rol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.combo_Rol.Name = "combo_Rol";
            this.combo_Rol.Size = new System.Drawing.Size(92, 21);
            this.combo_Rol.TabIndex = 9;
            // 
            // AdminUsuariosDG
            // 
            this.AdminUsuariosDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminUsuariosDG.Location = new System.Drawing.Point(1, 2);
            this.AdminUsuariosDG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdminUsuariosDG.Name = "AdminUsuariosDG";
            this.AdminUsuariosDG.RowHeadersWidth = 82;
            this.AdminUsuariosDG.RowTemplate.Height = 33;
            this.AdminUsuariosDG.Size = new System.Drawing.Size(580, 196);
            this.AdminUsuariosDG.TabIndex = 10;
            // 
            // G_Admin_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 335);
            this.Controls.Add(this.AdminUsuariosDG);
            this.Controls.Add(this.combo_Rol);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.EliminarUsuario);
            this.Controls.Add(this.ModificarUsuario);
            this.Controls.Add(this.CrearUsuario);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "G_Admin_Usuarios";
            this.Text = "G_Admin_Usuarios";
            this.Load += new System.EventHandler(this.G_Admin_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminUsuariosDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CrearUsuario;
        private System.Windows.Forms.Button ModificarUsuario;
        private System.Windows.Forms.Button EliminarUsuario;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.ComboBox combo_Rol;
        private System.Windows.Forms.DataGridView AdminUsuariosDG;
    }
}