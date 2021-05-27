
namespace PROYECTO1
{
    partial class G_EliminarPokAdmin
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
            this.EliminarPok = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Fotografia = new System.Windows.Forms.PictureBox();
            this.txt_EliminarPok = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Fotografia)).BeginInit();
            this.SuspendLayout();
            // 
            // EliminarPok
            // 
            this.EliminarPok.BackColor = System.Drawing.Color.Red;
            this.EliminarPok.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarPok.Location = new System.Drawing.Point(11, 338);
            this.EliminarPok.Margin = new System.Windows.Forms.Padding(2);
            this.EliminarPok.Name = "EliminarPok";
            this.EliminarPok.Size = new System.Drawing.Size(122, 25);
            this.EliminarPok.TabIndex = 0;
            this.EliminarPok.Text = "Eliminar";
            this.EliminarPok.UseVisualStyleBackColor = false;
            this.EliminarPok.Click += new System.EventHandler(this.EliminarPok_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 338);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Pokemon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Eliminar Pokemon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(408, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "__________________________________________________";
            // 
            // Fotografia
            // 
            this.Fotografia.Location = new System.Drawing.Point(60, 104);
            this.Fotografia.Name = "Fotografia";
            this.Fotografia.Size = new System.Drawing.Size(294, 202);
            this.Fotografia.TabIndex = 9;
            this.Fotografia.TabStop = false;
            // 
            // txt_EliminarPok
            // 
            this.txt_EliminarPok.FormattingEnabled = true;
            this.txt_EliminarPok.Location = new System.Drawing.Point(99, 67);
            this.txt_EliminarPok.Name = "txt_EliminarPok";
            this.txt_EliminarPok.Size = new System.Drawing.Size(121, 21);
            this.txt_EliminarPok.TabIndex = 10;
            this.txt_EliminarPok.SelectedIndexChanged += new System.EventHandler(this.txt_EliminarPok_SelectedIndexChanged);
            // 
            // G_EliminarPokAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 372);
            this.Controls.Add(this.txt_EliminarPok);
            this.Controls.Add(this.Fotografia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EliminarPok);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "G_EliminarPokAdmin";
            this.Text = "G_EliminarPokAdmin";
            this.Load += new System.EventHandler(this.G_EliminarPokAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Fotografia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EliminarPok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Fotografia;
        private System.Windows.Forms.ComboBox txt_EliminarPok;
    }
}