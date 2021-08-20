namespace ProyectoDesarrollo
{
    partial class Maquinas
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
            this.dataGrid_maquinas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_descripcion = new System.Windows.Forms.TextBox();
            this.textBox_ubicacion = new System.Windows.Forms.TextBox();
            this.textBox_compartimentos = new System.Windows.Forms.TextBox();
            this.button_nuevo = new System.Windows.Forms.Button();
            this.button_insertar = new System.Windows.Forms.Button();
            this.button_modificar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_maquinas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_maquinas
            // 
            this.dataGrid_maquinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_maquinas.Location = new System.Drawing.Point(13, 491);
            this.dataGrid_maquinas.Name = "dataGrid_maquinas";
            this.dataGrid_maquinas.RowHeadersWidth = 82;
            this.dataGrid_maquinas.RowTemplate.Height = 33;
            this.dataGrid_maquinas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_maquinas.Size = new System.Drawing.Size(1077, 549);
            this.dataGrid_maquinas.TabIndex = 0;
            this.dataGrid_maquinas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_maquinas_CellClick);
            this.dataGrid_maquinas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_maquinas_CellContentClick);
            this.dataGrid_maquinas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_maquinas_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "MAQUINAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ubicacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Compartimentos";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(289, 115);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(476, 31);
            this.textBox_nombre.TabIndex = 6;
            // 
            // textBox_descripcion
            // 
            this.textBox_descripcion.Location = new System.Drawing.Point(289, 159);
            this.textBox_descripcion.Name = "textBox_descripcion";
            this.textBox_descripcion.Size = new System.Drawing.Size(476, 31);
            this.textBox_descripcion.TabIndex = 7;
            // 
            // textBox_ubicacion
            // 
            this.textBox_ubicacion.Location = new System.Drawing.Point(289, 229);
            this.textBox_ubicacion.Name = "textBox_ubicacion";
            this.textBox_ubicacion.ReadOnly = true;
            this.textBox_ubicacion.Size = new System.Drawing.Size(476, 31);
            this.textBox_ubicacion.TabIndex = 8;
            this.textBox_ubicacion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_ubicacion_MouseClick);
            this.textBox_ubicacion.TextChanged += new System.EventHandler(this.textBox_ubicacion_TextChanged);
            // 
            // textBox_compartimentos
            // 
            this.textBox_compartimentos.Location = new System.Drawing.Point(289, 282);
            this.textBox_compartimentos.Name = "textBox_compartimentos";
            this.textBox_compartimentos.Size = new System.Drawing.Size(100, 31);
            this.textBox_compartimentos.TabIndex = 9;
            // 
            // button_nuevo
            // 
            this.button_nuevo.Location = new System.Drawing.Point(957, 115);
            this.button_nuevo.Name = "button_nuevo";
            this.button_nuevo.Size = new System.Drawing.Size(133, 53);
            this.button_nuevo.TabIndex = 10;
            this.button_nuevo.Text = "Nuevo";
            this.button_nuevo.UseVisualStyleBackColor = true;
            this.button_nuevo.Click += new System.EventHandler(this.button_nuevo_Click);
            // 
            // button_insertar
            // 
            this.button_insertar.Location = new System.Drawing.Point(957, 183);
            this.button_insertar.Name = "button_insertar";
            this.button_insertar.Size = new System.Drawing.Size(133, 53);
            this.button_insertar.TabIndex = 11;
            this.button_insertar.Text = "Insertar";
            this.button_insertar.UseVisualStyleBackColor = true;
            this.button_insertar.Click += new System.EventHandler(this.button_insertar_Click);
            // 
            // button_modificar
            // 
            this.button_modificar.Location = new System.Drawing.Point(957, 242);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(133, 53);
            this.button_modificar.TabIndex = 12;
            this.button_modificar.Text = "Modificar";
            this.button_modificar.UseVisualStyleBackColor = true;
            this.button_modificar.Click += new System.EventHandler(this.button_modificar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(957, 372);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(133, 53);
            this.button_cancelar.TabIndex = 13;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.Location = new System.Drawing.Point(957, 301);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(133, 53);
            this.button_eliminar.TabIndex = 14;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // Maquinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1108, 1063);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_modificar);
            this.Controls.Add(this.button_insertar);
            this.Controls.Add(this.button_nuevo);
            this.Controls.Add(this.textBox_compartimentos);
            this.Controls.Add(this.textBox_ubicacion);
            this.Controls.Add(this.textBox_descripcion);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_maquinas);
            this.Name = "Maquinas";
            this.Text = "Maquinas";
            this.Load += new System.EventHandler(this.Maquinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_maquinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_maquinas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_descripcion;
        private System.Windows.Forms.TextBox textBox_ubicacion;
        private System.Windows.Forms.TextBox textBox_compartimentos;
        private System.Windows.Forms.Button button_nuevo;
        private System.Windows.Forms.Button button_insertar;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_eliminar;
    }
}