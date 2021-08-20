namespace ProyectoDesarrollo
{
    partial class Form_Menu
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
            this.maquinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recargasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesPorMaquinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesRecargasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maquinasToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.recargasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // maquinasToolStripMenuItem
            // 
            this.maquinasToolStripMenuItem.Name = "maquinasToolStripMenuItem";
            this.maquinasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.maquinasToolStripMenuItem.Text = "Maquinas";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.ProductosToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // recargasToolStripMenuItem
            // 
            this.recargasToolStripMenuItem.Name = "recargasToolStripMenuItem";
            this.recargasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.recargasToolStripMenuItem.Text = "Recargas";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesPorMaquinasToolStripMenuItem,
            this.reportesPorToolStripMenuItem,
            this.reportesRecargasToolStripMenuItem,
            this.reportesVentasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reportesPorMaquinasToolStripMenuItem
            // 
            this.reportesPorMaquinasToolStripMenuItem.Name = "reportesPorMaquinasToolStripMenuItem";
            this.reportesPorMaquinasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.reportesPorMaquinasToolStripMenuItem.Text = "Reportes por Maquinas";
            // 
            // reportesPorToolStripMenuItem
            // 
            this.reportesPorToolStripMenuItem.Name = "reportesPorToolStripMenuItem";
            this.reportesPorToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.reportesPorToolStripMenuItem.Text = "Reportes Productos";
            // 
            // reportesRecargasToolStripMenuItem
            // 
            this.reportesRecargasToolStripMenuItem.Name = "reportesRecargasToolStripMenuItem";
            this.reportesRecargasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.reportesRecargasToolStripMenuItem.Text = "Reportes Recargas";
            // 
            // reportesVentasToolStripMenuItem
            // 
            this.reportesVentasToolStripMenuItem.Name = "reportesVentasToolStripMenuItem";
            this.reportesVentasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.reportesVentasToolStripMenuItem.Text = "Reportes Ventas";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 508);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Menu";
            this.Text = "Form_Menu";
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesPorMaquinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesPorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesRecargasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maquinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recargasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}