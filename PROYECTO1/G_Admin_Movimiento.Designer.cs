﻿
namespace PROYECTO1
{
    partial class TipoMovAdmin
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
            this.Crear = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Regresar = new System.Windows.Forms.Button();
            this.AdminConsultaMovDG = new System.Windows.Forms.DataGridView();
            this.txt_DescripcionMovAdmi = new System.Windows.Forms.TextBox();
            this.txt_NombreMovAdmi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Id_Movimiento = new System.Windows.Forms.ComboBox();
            this.txt_CodigoMovAdmi = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.txt_TipoMovAdmi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AdminConsultaMovDG)).BeginInit();
            this.SuspendLayout();
            // 
            // Crear
            // 
            this.Crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Crear.Location = new System.Drawing.Point(23, 571);
            this.Crear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(83, 28);
            this.Crear.TabIndex = 0;
            this.Crear.Text = "Crear";
            this.Crear.UseVisualStyleBackColor = false;
            this.Crear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(125, 571);
            this.Modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(85, 28);
            this.Modificar.TabIndex = 1;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.Red;
            this.Eliminar.Location = new System.Drawing.Point(231, 571);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(91, 28);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Regresar
            // 
            this.Regresar.Location = new System.Drawing.Point(557, 571);
            this.Regresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(104, 28);
            this.Regresar.TabIndex = 3;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = true;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // AdminConsultaMovDG
            // 
            this.AdminConsultaMovDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminConsultaMovDG.Location = new System.Drawing.Point(15, 111);
            this.AdminConsultaMovDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminConsultaMovDG.Name = "AdminConsultaMovDG";
            this.AdminConsultaMovDG.RowHeadersWidth = 82;
            this.AdminConsultaMovDG.RowTemplate.Height = 33;
            this.AdminConsultaMovDG.Size = new System.Drawing.Size(557, 261);
            this.AdminConsultaMovDG.TabIndex = 4;
            // 
            // txt_DescripcionMovAdmi
            // 
            this.txt_DescripcionMovAdmi.Location = new System.Drawing.Point(227, 490);
            this.txt_DescripcionMovAdmi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DescripcionMovAdmi.Name = "txt_DescripcionMovAdmi";
            this.txt_DescripcionMovAdmi.Size = new System.Drawing.Size(95, 22);
            this.txt_DescripcionMovAdmi.TabIndex = 6;
            // 
            // txt_NombreMovAdmi
            // 
            this.txt_NombreMovAdmi.Location = new System.Drawing.Point(360, 490);
            this.txt_NombreMovAdmi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NombreMovAdmi.Name = "txt_NombreMovAdmi";
            this.txt_NombreMovAdmi.Size = new System.Drawing.Size(89, 22);
            this.txt_NombreMovAdmi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Codigo Movimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(187, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 51);
            this.label5.TabIndex = 13;
            this.label5.Text = "MOVIMIENTOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(8, 418);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(630, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "______________________________________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(8, 398);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Información";
            // 
            // Id_Movimiento
            // 
            this.Id_Movimiento.FormattingEnabled = true;
            this.Id_Movimiento.Location = new System.Drawing.Point(125, 66);
            this.Id_Movimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Id_Movimiento.Name = "Id_Movimiento";
            this.Id_Movimiento.Size = new System.Drawing.Size(271, 24);
            this.Id_Movimiento.TabIndex = 16;
            this.Id_Movimiento.SelectedIndexChanged += new System.EventHandler(this.Id_Movimiento_SelectedIndexChanged);
            // 
            // txt_CodigoMovAdmi
            // 
            this.txt_CodigoMovAdmi.Location = new System.Drawing.Point(91, 490);
            this.txt_CodigoMovAdmi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CodigoMovAdmi.Name = "txt_CodigoMovAdmi";
            this.txt_CodigoMovAdmi.Size = new System.Drawing.Size(84, 22);
            this.txt_CodigoMovAdmi.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(19, 70);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(21, 17);
            this.ID.TabIndex = 17;
            this.ID.Text = "ID";
            // 
            // txt_TipoMovAdmi
            // 
            this.txt_TipoMovAdmi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_TipoMovAdmi.FormattingEnabled = true;
            this.txt_TipoMovAdmi.Items.AddRange(new object[] {
            "Agua",
            "Fuego",
            "Hielo",
            "Veneno",
            "Planta",
            "Normal",
            "Lucha",
            "Electrico",
            "Roca"});
            this.txt_TipoMovAdmi.Location = new System.Drawing.Point(486, 490);
            this.txt_TipoMovAdmi.Name = "txt_TipoMovAdmi";
            this.txt_TipoMovAdmi.Size = new System.Drawing.Size(108, 24);
            this.txt_TipoMovAdmi.TabIndex = 18;
            // 
            // TipoMovAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(696, 613);
            this.Controls.Add(this.txt_TipoMovAdmi);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Id_Movimiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NombreMovAdmi);
            this.Controls.Add(this.txt_DescripcionMovAdmi);
            this.Controls.Add(this.txt_CodigoMovAdmi);
            this.Controls.Add(this.AdminConsultaMovDG);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Crear);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TipoMovAdmin";
            this.Text = "Gestion de Movimientos";
            ((System.ComponentModel.ISupportInitialize)(this.AdminConsultaMovDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Crear;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.DataGridView AdminConsultaMovDG;
        private System.Windows.Forms.TextBox txt_DescripcionMovAdmi;
        private System.Windows.Forms.TextBox txt_NombreMovAdmi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Id_Movimiento;
        private System.Windows.Forms.TextBox txt_CodigoMovAdmi;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.ComboBox txt_TipoMovAdmi;
    }
}