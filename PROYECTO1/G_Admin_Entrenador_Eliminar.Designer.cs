
namespace PROYECTO1
{
    partial class G_Admin_Entrenador_Eliminar
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
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EliminarEntrenador = new System.Windows.Forms.Button();
            this.txt_ID_Entrenador = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 14);
            this.label15.TabIndex = 101;
            this.label15.Text = "ID Entrenador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 17);
            this.label2.TabIndex = 99;
            this.label2.Text = "________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 98;
            this.label1.Text = "Eliminar Entrenador";
            // 
            // EliminarEntrenador
            // 
            this.EliminarEntrenador.BackColor = System.Drawing.Color.Red;
            this.EliminarEntrenador.Location = new System.Drawing.Point(145, 109);
            this.EliminarEntrenador.Margin = new System.Windows.Forms.Padding(2);
            this.EliminarEntrenador.Name = "EliminarEntrenador";
            this.EliminarEntrenador.Size = new System.Drawing.Size(74, 26);
            this.EliminarEntrenador.TabIndex = 102;
            this.EliminarEntrenador.Text = "Eliminar";
            this.EliminarEntrenador.UseVisualStyleBackColor = false;
            this.EliminarEntrenador.Click += new System.EventHandler(this.EliminarEntrenador_Click);
            // 
            // txt_ID_Entrenador
            // 
            this.txt_ID_Entrenador.FormattingEnabled = true;
            this.txt_ID_Entrenador.Location = new System.Drawing.Point(93, 66);
            this.txt_ID_Entrenador.Name = "txt_ID_Entrenador";
            this.txt_ID_Entrenador.Size = new System.Drawing.Size(227, 21);
            this.txt_ID_Entrenador.TabIndex = 103;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(282, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 26);
            this.button3.TabIndex = 104;
            this.button3.Text = "Regresar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // G_Admin_Entrenador_Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 161);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_ID_Entrenador);
            this.Controls.Add(this.EliminarEntrenador);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "G_Admin_Entrenador_Eliminar";
            this.Text = "G_Admin_Entrenador_Eliminar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EliminarEntrenador;
        private System.Windows.Forms.ComboBox txt_ID_Entrenador;
        private System.Windows.Forms.Button button3;
    }
}