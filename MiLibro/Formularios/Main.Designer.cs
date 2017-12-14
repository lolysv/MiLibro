namespace MiLibro.Formularios
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otrosIngresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.descuentasToolStripMenuItem,
            this.otrosIngresosToolStripMenuItem,
            this.planillasToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // descuentasToolStripMenuItem
            // 
            this.descuentasToolStripMenuItem.Name = "descuentasToolStripMenuItem";
            this.descuentasToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.descuentasToolStripMenuItem.Text = "Descuentos";
            this.descuentasToolStripMenuItem.Click += new System.EventHandler(this.descuentasToolStripMenuItem_Click);
            // 
            // otrosIngresosToolStripMenuItem
            // 
            this.otrosIngresosToolStripMenuItem.Name = "otrosIngresosToolStripMenuItem";
            this.otrosIngresosToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.otrosIngresosToolStripMenuItem.Text = "OtrosIngresos";
            this.otrosIngresosToolStripMenuItem.Click += new System.EventHandler(this.otrosIngresosToolStripMenuItem_Click);
            // 
            // planillasToolStripMenuItem
            // 
            this.planillasToolStripMenuItem.Name = "planillasToolStripMenuItem";
            this.planillasToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.planillasToolStripMenuItem.Text = "Planillas";
            this.planillasToolStripMenuItem.Click += new System.EventHandler(this.planillasToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(0, 27);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(741, 448);
            this.MainPanel.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 475);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otrosIngresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planillasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.Panel MainPanel;
    }
}