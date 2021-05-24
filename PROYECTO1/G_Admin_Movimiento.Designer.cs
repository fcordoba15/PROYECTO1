
namespace PROYECTO1
{
    partial class G_Admin_Movimiento
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
            this.txt_CodigoMovAdmi = new System.Windows.Forms.TextBox();
            this.txt_DescripcionMovAdmi = new System.Windows.Forms.TextBox();
            this.txt_NombreMovAdmi = new System.Windows.Forms.TextBox();
            this.txt_TipoMovAdmi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdminConsultaMovDG)).BeginInit();
            this.SuspendLayout();
            // 
            // Crear
            // 
            this.Crear.Location = new System.Drawing.Point(51, 680);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(125, 45);
            this.Crear.TabIndex = 0;
            this.Crear.Text = "Crear";
            this.Crear.UseVisualStyleBackColor = true;
            this.Crear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(244, 681);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(128, 44);
            this.Modificar.TabIndex = 1;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(449, 685);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(123, 40);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Regresar
            // 
            this.Regresar.Location = new System.Drawing.Point(1056, 680);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(155, 45);
            this.Regresar.TabIndex = 3;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = true;
            // 
            // AdminConsultaMovDG
            // 
            this.AdminConsultaMovDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminConsultaMovDG.Location = new System.Drawing.Point(13, 2);
            this.AdminConsultaMovDG.Name = "AdminConsultaMovDG";
            this.AdminConsultaMovDG.RowHeadersWidth = 82;
            this.AdminConsultaMovDG.RowTemplate.Height = 33;
            this.AdminConsultaMovDG.Size = new System.Drawing.Size(1232, 407);
            this.AdminConsultaMovDG.TabIndex = 4;
            // 
            // txt_CodigoMovAdmi
            // 
            this.txt_CodigoMovAdmi.Location = new System.Drawing.Point(51, 553);
            this.txt_CodigoMovAdmi.Name = "txt_CodigoMovAdmi";
            this.txt_CodigoMovAdmi.Size = new System.Drawing.Size(125, 31);
            this.txt_CodigoMovAdmi.TabIndex = 5;
            // 
            // txt_DescripcionMovAdmi
            // 
            this.txt_DescripcionMovAdmi.Location = new System.Drawing.Point(233, 553);
            this.txt_DescripcionMovAdmi.Name = "txt_DescripcionMovAdmi";
            this.txt_DescripcionMovAdmi.Size = new System.Drawing.Size(139, 31);
            this.txt_DescripcionMovAdmi.TabIndex = 6;
            // 
            // txt_NombreMovAdmi
            // 
            this.txt_NombreMovAdmi.Location = new System.Drawing.Point(449, 553);
            this.txt_NombreMovAdmi.Name = "txt_NombreMovAdmi";
            this.txt_NombreMovAdmi.Size = new System.Drawing.Size(132, 31);
            this.txt_NombreMovAdmi.TabIndex = 7;
            // 
            // txt_TipoMovAdmi
            // 
            this.txt_TipoMovAdmi.Location = new System.Drawing.Point(673, 553);
            this.txt_TipoMovAdmi.Name = "txt_TipoMovAdmi";
            this.txt_TipoMovAdmi.Size = new System.Drawing.Size(128, 31);
            this.txt_TipoMovAdmi.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Codigo Movimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(698, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tipo";
            // 
            // G_Admin_Movimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 772);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TipoMovAdmi);
            this.Controls.Add(this.txt_NombreMovAdmi);
            this.Controls.Add(this.txt_DescripcionMovAdmi);
            this.Controls.Add(this.txt_CodigoMovAdmi);
            this.Controls.Add(this.AdminConsultaMovDG);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Crear);
            this.Name = "G_Admin_Movimiento";
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
        private System.Windows.Forms.TextBox txt_CodigoMovAdmi;
        private System.Windows.Forms.TextBox txt_DescripcionMovAdmi;
        private System.Windows.Forms.TextBox txt_NombreMovAdmi;
        private System.Windows.Forms.TextBox txt_TipoMovAdmi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}