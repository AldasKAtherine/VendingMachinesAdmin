using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace ProyectoDesarrollo
{
    public partial class Sesion : Form
    {
        public Sesion()
        {
            InitializeComponent();
        }

        private void IniciarSesion()
        {
            string cedula = textBox_cedula.Text;
            string contrasena = textBox_contrasena.Text;

            bool correcto = MetodosNegocio.IniciarSesion(cedula, contrasena);

            if (correcto)
            {

                Usuario usuario = MetodosNegocio.ObtenerUsuarioPorCedula(cedula);
                MessageBox.Show("Bien");
            }
            else
            {
                MessageBox.Show("Error al iniciar! Trata de nuevo");
            }

        }

        private void button_sesion_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }
    }
}
