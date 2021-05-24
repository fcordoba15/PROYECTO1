
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
            this.EliminarPokDG = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_EliminarPok = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EliminarPokDG)).BeginInit();
            this.SuspendLayout();
            // 
            // EliminarPok
            // 
            this.EliminarPok.Location = new System.Drawing.Point(470, 634);
            this.EliminarPok.Name = "EliminarPok";
            this.EliminarPok.Size = new System.Drawing.Size(245, 49);
            this.EliminarPok.TabIndex = 0;
            this.EliminarPok.Text = "Eliminar";
            this.EliminarPok.UseVisualStyleBackColor = true;
            this.EliminarPok.Click += new System.EventHandler(this.EliminarPok_Click);
            // 
            // EliminarPokDG
            // 
            this.EliminarPokDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EliminarPokDG.Location = new System.Drawing.Point(-3, 2);
            this.EliminarPokDG.Name = "EliminarPokDG";
            this.EliminarPokDG.RowHeadersWidth = 82;
            this.EliminarPokDG.RowTemplate.Height = 33;
            this.EliminarPokDG.Size = new System.Drawing.Size(1298, 482);
            this.EliminarPokDG.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1133, 634);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Pokemon";
            // 
            // txt_EliminarPok
            // 
            this.txt_EliminarPok.Location = new System.Drawing.Point(530, 562);
            this.txt_EliminarPok.Name = "txt_EliminarPok";
            this.txt_EliminarPok.Size = new System.Drawing.Size(137, 31);
            this.txt_EliminarPok.TabIndex = 4;
            this.txt_EliminarPok.TextChanged += new System.EventHandler(this.txt_EliminarPok_TextChanged);
            // 
            // G_EliminarPokAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 719);
            this.Controls.Add(this.txt_EliminarPok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EliminarPokDG);
            this.Controls.Add(this.EliminarPok);
            this.Name = "G_EliminarPokAdmin";
            this.Text = "G_EliminarPokAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.EliminarPokDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EliminarPok;
        private System.Windows.Forms.DataGridView EliminarPokDG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_EliminarPok;
    }
}