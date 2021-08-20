namespace ProyectoDesarrollo
{
    partial class Form_RepoProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RepoProduct));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_estado = new System.Windows.Forms.ComboBox();
            this.button_estados = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reportes Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado:";
            // 
            // comboBox_estado
            // 
            this.comboBox_estado.FormattingEnabled = true;
            this.comboBox_estado.Items.AddRange(new object[] {
            "Inactivo",
            "Activo",
            "Todos"});
            this.comboBox_estado.Location = new System.Drawing.Point(101, 60);
            this.comboBox_estado.Name = "comboBox_estado";
            this.comboBox_estado.Size = new System.Drawing.Size(178, 21);
            this.comboBox_estado.TabIndex = 3;
            // 
            // button_estados
            // 
            this.button_estados.Location = new System.Drawing.Point(319, 58);
            this.button_estados.Name = "button_estados";
            this.button_estados.Size = new System.Drawing.Size(106, 23);
            this.button_estados.TabIndex = 5;
            this.button_estados.Text = "Visualizar";
            this.button_estados.UseVisualStyleBackColor = true;
            this.button_estados.Click += new System.EventHandler(this.Button_estados_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 87);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(797, 650);
            this.reportViewer1.TabIndex = 7;
            // 
            // Form_RepoProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 749);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button_estados);
            this.Controls.Add(this.comboBox_estado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_RepoProduct";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.RepoProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_estado;
        private System.Windows.Forms.Button button_estados;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}