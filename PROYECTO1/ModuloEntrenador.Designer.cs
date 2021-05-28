
namespace PROYECTO1
{
    partial class ModuloEntrenador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloEntrenador));
            this.Cerrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.GestionEntrenador = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.pokemonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cerrar.Location = new System.Drawing.Point(308, 216);
            this.Cerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(50, 21);
            this.Cerrar.TabIndex = 0;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Cerrar.UseVisualStyleBackColor = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(373, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GestionEntrenador});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip2.Size = new System.Drawing.Size(373, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // GestionEntrenador
            // 
            this.GestionEntrenador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimientosToolStripMenuItem,
            this.pokemonToolStripMenuItem,
            this.bitacora,
            this.pokemonesToolStripMenuItem,
            this.usuariosAdminToolStripMenuItem});
            this.GestionEntrenador.Name = "GestionEntrenador";
            this.GestionEntrenador.Size = new System.Drawing.Size(70, 22);
            this.GestionEntrenador.Text = "Gestiones";
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            this.movimientosToolStripMenuItem.Click += new System.EventHandler(this.movimientosToolStripMenuItem_Click);
            // 
            // pokemonToolStripMenuItem
            // 
            this.pokemonToolStripMenuItem.Name = "pokemonToolStripMenuItem";
            this.pokemonToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.pokemonToolStripMenuItem.Text = "Pokemon";
            this.pokemonToolStripMenuItem.Click += new System.EventHandler(this.pokemonToolStripMenuItem_Click);
            // 
            // bitacora
            // 
            this.bitacora.Name = "bitacora";
            this.bitacora.Size = new System.Drawing.Size(158, 22);
            this.bitacora.Text = "Bitacora";
            this.bitacora.Click += new System.EventHandler(this.bitacora_Click);
            // 
            // pokemonesToolStripMenuItem
            // 
            this.pokemonesToolStripMenuItem.Name = "pokemonesToolStripMenuItem";
            this.pokemonesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.pokemonesToolStripMenuItem.Text = "Pokemones";
            this.pokemonesToolStripMenuItem.Click += new System.EventHandler(this.pokemonesToolStripMenuItem_Click);
            // 
            // usuariosAdminToolStripMenuItem
            // 
            this.usuariosAdminToolStripMenuItem.Name = "usuariosAdminToolStripMenuItem";
            this.usuariosAdminToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.usuariosAdminToolStripMenuItem.Text = "Usuarios Admin";
            this.usuariosAdminToolStripMenuItem.Click += new System.EventHandler(this.usuariosAdminToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 214);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ModuloEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 242);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModuloEntrenador";
            this.Text = "Modulo Entrenador";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem GestionEntrenador;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokemonToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem bitacora;
        private System.Windows.Forms.ToolStripMenuItem pokemonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosAdminToolStripMenuItem;
    }
}