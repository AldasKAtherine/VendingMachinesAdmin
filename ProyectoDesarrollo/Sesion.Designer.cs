namespace ProyectoDesarrollo
{
    partial class Sesion
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
            this.textBox_cedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_contrasena = new System.Windows.Forms.TextBox();
            this.button_sesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_cedula
            // 
            this.textBox_cedula.Location = new System.Drawing.Point(205, 498);
            this.textBox_cedula.Name = "textBox_cedula";
            this.textBox_cedula.Size = new System.Drawing.Size(390, 31);
            this.textBox_cedula.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 570);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contrasena";
            // 
            // textBox_contrasena
            // 
            this.textBox_contrasena.Location = new System.Drawing.Point(205, 563);
            this.textBox_contrasena.Name = "textBox_contrasena";
            this.textBox_contrasena.Size = new System.Drawing.Size(390, 31);
            this.textBox_contrasena.TabIndex = 3;
            // 
            // button_sesion
            // 
            this.button_sesion.Location = new System.Drawing.Point(254, 657);
            this.button_sesion.Name = "button_sesion";
            this.button_sesion.Size = new System.Drawing.Size(194, 44);
            this.button_sesion.TabIndex = 4;
            this.button_sesion.Text = "Iniciar Sesion";
            this.button_sesion.UseVisualStyleBackColor = true;
            this.button_sesion.Click += new System.EventHandler(this.button_sesion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoDesarrollo.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(151, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 390);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 738);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_sesion);
            this.Controls.Add(this.textBox_contrasena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_cedula);
            this.Name = "Sesion";
            this.Text = "Sesion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_cedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_contrasena;
        private System.Windows.Forms.Button button_sesion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}