namespace ProyectoDesarrollo
{
    partial class RecargasPresentacion
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
            this.comboBox_maquina = new System.Windows.Forms.ComboBox();
            this.comboBox_compartimiento = new System.Windows.Forms.ComboBox();
            this.comboBox_producto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_cantidad = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_empleado = new System.Windows.Forms.ComboBox();
            this.dataGridView_recargas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_recargas)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_maquina
            // 
            this.comboBox_maquina.FormattingEnabled = true;
            this.comboBox_maquina.Location = new System.Drawing.Point(92, 81);
            this.comboBox_maquina.Name = "comboBox_maquina";
            this.comboBox_maquina.Size = new System.Drawing.Size(121, 21);
            this.comboBox_maquina.TabIndex = 0;
            this.comboBox_maquina.Text = "Seleccione";
            this.comboBox_maquina.SelectedIndexChanged += new System.EventHandler(this.comboBox_maquina_SelectedIndexChanged);
            // 
            // comboBox_compartimiento
            // 
            this.comboBox_compartimiento.FormattingEnabled = true;
            this.comboBox_compartimiento.Location = new System.Drawing.Point(92, 123);
            this.comboBox_compartimiento.Name = "comboBox_compartimiento";
            this.comboBox_compartimiento.Size = new System.Drawing.Size(121, 21);
            this.comboBox_compartimiento.TabIndex = 1;
            this.comboBox_compartimiento.Text = "Seleccione";
            this.comboBox_compartimiento.SelectedIndexChanged += new System.EventHandler(this.comboBox_compartimiento_SelectedIndexChanged);
            // 
            // comboBox_producto
            // 
            this.comboBox_producto.FormattingEnabled = true;
            this.comboBox_producto.Location = new System.Drawing.Point(92, 162);
            this.comboBox_producto.Name = "comboBox_producto";
            this.comboBox_producto.Size = new System.Drawing.Size(121, 21);
            this.comboBox_producto.TabIndex = 2;
            this.comboBox_producto.Text = "Seleccione";
            this.comboBox_producto.SelectedIndexChanged += new System.EventHandler(this.comboBox_producto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Máquina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Compartimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Producto";
            // 
            // numericUpDown_cantidad
            // 
            this.numericUpDown_cantidad.Location = new System.Drawing.Point(92, 200);
            this.numericUpDown_cantidad.Name = "numericUpDown_cantidad";
            this.numericUpDown_cantidad.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_cantidad.TabIndex = 6;
            this.numericUpDown_cantidad.ValueChanged += new System.EventHandler(this.numericUpDown_cantidad_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Empleado";
            // 
            // comboBox_empleado
            // 
            this.comboBox_empleado.FormattingEnabled = true;
            this.comboBox_empleado.Location = new System.Drawing.Point(91, 242);
            this.comboBox_empleado.Name = "comboBox_empleado";
            this.comboBox_empleado.Size = new System.Drawing.Size(121, 21);
            this.comboBox_empleado.TabIndex = 9;
            this.comboBox_empleado.Text = "Seleccione";
            this.comboBox_empleado.SelectedIndexChanged += new System.EventHandler(this.comboBox_empleado_SelectedIndexChanged);
            // 
            // dataGridView_recargas
            // 
            this.dataGridView_recargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_recargas.Location = new System.Drawing.Point(271, 42);
            this.dataGridView_recargas.Name = "dataGridView_recargas";
            this.dataGridView_recargas.Size = new System.Drawing.Size(814, 396);
            this.dataGridView_recargas.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RecargasPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_recargas);
            this.Controls.Add(this.comboBox_empleado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_cantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_producto);
            this.Controls.Add(this.comboBox_compartimiento);
            this.Controls.Add(this.comboBox_maquina);
            this.Name = "RecargasPresentacion";
            this.Text = "RecargasPresentacion";
            this.Load += new System.EventHandler(this.RecargasPresentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_recargas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_maquina;
        private System.Windows.Forms.ComboBox comboBox_compartimiento;
        private System.Windows.Forms.ComboBox comboBox_producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_cantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_empleado;
        private System.Windows.Forms.DataGridView dataGridView_recargas;
        private System.Windows.Forms.Button button1;
    }
}