namespace ProyectoDesarrollo
{
    partial class Form_RepoMaquina
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Estado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_ver = new System.Windows.Forms.Button();
            this.reportViewer_maquinas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reportes Maquinas";
            // 
            // comboBox_Estado
            // 
            this.comboBox_Estado.FormattingEnabled = true;
            this.comboBox_Estado.Items.AddRange(new object[] {
            "INACTIVO",
            "ACTIVO",
            "TODAS",
            "PRODUCTOS MAQUINAS"});
            this.comboBox_Estado.Location = new System.Drawing.Point(120, 55);
            this.comboBox_Estado.Name = "comboBox_Estado";
            this.comboBox_Estado.Size = new System.Drawing.Size(182, 21);
            this.comboBox_Estado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado:";
            // 
            // button_ver
            // 
            this.button_ver.Location = new System.Drawing.Point(308, 53);
            this.button_ver.Name = "button_ver";
            this.button_ver.Size = new System.Drawing.Size(75, 23);
            this.button_ver.TabIndex = 3;
            this.button_ver.Text = "Vizualizar";
            this.button_ver.UseVisualStyleBackColor = true;
            this.button_ver.Click += new System.EventHandler(this.Button_ver_Click_1);
            // 
            // reportViewer_maquinas
            // 
            this.reportViewer_maquinas.Location = new System.Drawing.Point(12, 111);
            this.reportViewer_maquinas.Name = "reportViewer_maquinas";
            this.reportViewer_maquinas.ServerReport.BearerToken = null;
            this.reportViewer_maquinas.Size = new System.Drawing.Size(675, 408);
            this.reportViewer_maquinas.TabIndex = 4;
            // 
            // Form_RepoMaquina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 531);
            this.Controls.Add(this.reportViewer_maquinas);
            this.Controls.Add(this.button_ver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Estado);
            this.Controls.Add(this.label1);
            this.Name = "Form_RepoMaquina";
            this.Text = "Form_Reportes";
            this.Load += new System.EventHandler(this.Form_RepoMaquina_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_ver;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_maquinas;
    }
}