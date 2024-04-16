namespace prySotoMariaLujan
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dibujarOFirmarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugarGálagaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dibujarOFirmarToolStripMenuItem,
            this.jugarGálagaToolStripMenuItem,
            this.estadísticasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dibujarOFirmarToolStripMenuItem
            // 
            this.dibujarOFirmarToolStripMenuItem.Image = global::prySotoMariaLujan.Properties.Resources.png_transparent_graphy_logo_palette_color_paint_black_and_white_line_symbol;
            this.dibujarOFirmarToolStripMenuItem.Name = "dibujarOFirmarToolStripMenuItem";
            this.dibujarOFirmarToolStripMenuItem.ShowShortcutKeys = false;
            this.dibujarOFirmarToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.dibujarOFirmarToolStripMenuItem.Text = "Dibujar o Firmar";
            this.dibujarOFirmarToolStripMenuItem.Click += new System.EventHandler(this.dibujarOFirmarToolStripMenuItem_Click);
            // 
            // jugarGálagaToolStripMenuItem
            // 
            this.jugarGálagaToolStripMenuItem.Image = global::prySotoMariaLujan.Properties.Resources.gratis_png_space_invaders_extreme_2_icono_de_videojuego_archivo_space_invaders;
            this.jugarGálagaToolStripMenuItem.Name = "jugarGálagaToolStripMenuItem";
            this.jugarGálagaToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.jugarGálagaToolStripMenuItem.Text = "Jugar Gálaga";
            this.jugarGálagaToolStripMenuItem.Click += new System.EventHandler(this.jugarGálagaToolStripMenuItem_Click);
            // 
            // estadísticasToolStripMenuItem
            // 
            this.estadísticasToolStripMenuItem.Image = global::prySotoMariaLujan.Properties.Resources.png_transparent_computer_icons_statistics_chart_statistics_miscellaneous_infographic_angle_thumbnail;
            this.estadísticasToolStripMenuItem.Name = "estadísticasToolStripMenuItem";
            this.estadísticasToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.estadísticasToolStripMenuItem.Text = "Estadísticas";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dibujarOFirmarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jugarGálagaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticasToolStripMenuItem;
    }
}

