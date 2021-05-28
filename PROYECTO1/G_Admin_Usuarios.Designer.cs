
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
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdminUsuariosDG)).BeginInit();
            this.SuspendLayout();
            // 
            // CrearUsuario
            // 
            this.CrearUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CrearUsuario.Location = new System.Drawing.Point(9, 420);
            this.CrearUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CrearUsuario.Name = "CrearUsuario";
            this.CrearUsuario.Size = new System.Drawing.Size(52, 21);
            this.CrearUsuario.TabIndex = 0;
            this.CrearUsuario.Text = "Crear";
            this.CrearUsuario.UseVisualStyleBackColor = false;
            this.CrearUsuario.Click += new System.EventHandler(this.CrearUsuario_Click);
            // 
            // ModificarUsuario
            // 
            this.ModificarUsuario.Location = new System.Drawing.Point(65, 420);
            this.ModificarUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModificarUsuario.Name = "ModificarUsuario";
            this.ModificarUsuario.Size = new System.Drawing.Size(56, 21);
            this.ModificarUsuario.TabIndex = 1;
            this.ModificarUsuario.Text = "Modificar";
            this.ModificarUsuario.UseVisualStyleBackColor = true;
            this.ModificarUsuario.Click += new System.EventHandler(this.ModificarUsuario_Click);
            // 
            // EliminarUsuario
            // 
            this.EliminarUsuario.BackColor = System.Drawing.Color.Red;
            this.EliminarUsuario.Location = new System.Drawing.Point(125, 420);
            this.EliminarUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EliminarUsuario.Name = "EliminarUsuario";
            this.EliminarUsuario.Size = new System.Drawing.Size(64, 22);
            this.EliminarUsuario.TabIndex = 2;
            this.EliminarUsuario.Text = "Eliminar";
            this.EliminarUsuario.UseVisualStyleBackColor = false;
            this.EliminarUsuario.Click += new System.EventHandler(this.EliminarUsuario_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(446, 419);
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
            this.label1.Location = new System.Drawing.Point(17, 352);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 352);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 352);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rol";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(20, 377);
            this.txt_Usuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(52, 20);
            this.txt_Usuario.TabIndex = 7;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(134, 377);
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
            this.combo_Rol.Location = new System.Drawing.Point(238, 376);
            this.combo_Rol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.combo_Rol.Name = "combo_Rol";
            this.combo_Rol.Size = new System.Drawing.Size(92, 21);
            this.combo_Rol.TabIndex = 9;
            // 
            // AdminUsuariosDG
            // 
            this.AdminUsuariosDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminUsuariosDG.Location = new System.Drawing.Point(9, 93);
            this.AdminUsuariosDG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdminUsuariosDG.Name = "AdminUsuariosDG";
            this.AdminUsuariosDG.RowHeadersWidth = 82;
            this.AdminUsuariosDG.RowTemplate.Height = 33;
            this.AdminUsuariosDG.Size = new System.Drawing.Size(441, 196);
            this.AdminUsuariosDG.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 42);
            this.label4.TabIndex = 11;
            this.label4.Text = "USUARIOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(6, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(504, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "______________________________________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(6, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Información";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Usuario";
            // 
            // G_Admin_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(522, 452);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}