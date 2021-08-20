using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDesarrollo
{
    public partial class CRUDEmpleados : Form
    {
        int idUsu = 0;
        Empleado empTemp = new Empleado();
        public CRUDEmpleados(int idUsuario)
        {
            InitializeComponent();
            idUsu = idUsuario;
        }

        private void CRUDEmpleados_Load(object sender, EventArgs e)
        {
            cargarEmpleados(idUsu);
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void cargarEmpleados(int idUsu)
        {
            dataGridView_Empleados.DataSource = null;
            dataGridView_Empleados.DataSource = MetodosNegocio.listaEmpleados(idUsu);
            dataGridView_Empleados.Columns["Id"].DisplayIndex = 0;
            dataGridView_Empleados.Columns["Cedula"].DisplayIndex = 1;
            dataGridView_Empleados.Columns["Nombre"].DisplayIndex = 2;
            dataGridView_Empleados.Columns["Apellido"].DisplayIndex = 3;
            dataGridView_Empleados.Columns["Contrasena"].DisplayIndex = 4;
            dataGridView_Empleados.Columns["Id_usuario"].Visible = false;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Cedula = textBox_cedula.Text;
            empleado.Nombre = textBox_nombre.Text;
            empleado.Apellido = textBox_apellido.Text;
            empleado.Contrasena = Encriptar(textBox_contrasena.Text);
            empleado.Id_usuario = idUsu;

            MetodosNegocio.CrearEmpleado(empleado);
            cargarEmpleados(idUsu);
            limpiarCajas();

        }

        private void limpiarCajas()
        {
            textBox_cedula.Text="";
            textBox_nombre.Text="";
            textBox_apellido.Text="";
            textBox_contrasena.Text="";
        }

        private void button3_Click(object sender, EventArgs e)

        {

            MetodosNegocio.BorrarEmpleado(empTemp);
            cargarEmpleados(idUsu);
            limpiarCajas();
            botnonesDefecto();



        }

        private void dataGridView_Empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
            {
                MessageBox.Show("Seleccione un empleado");
            }
            else
            {
                Empleado empleadoT = new Empleado();
                empleadoT.Id = Convert.ToInt32(dataGridView_Empleados.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                empleadoT.Cedula = dataGridView_Empleados.Rows[e.RowIndex].Cells["Cedula"].Value.ToString();
                empleadoT.Nombre = dataGridView_Empleados.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                empleadoT.Apellido = dataGridView_Empleados.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                empleadoT.Contrasena = dataGridView_Empleados.Rows[e.RowIndex].Cells["Contrasena"].Value.ToString();
                empleadoT.Id_usuario = idUsu;
                empTemp = empleadoT;
                textBox_cedula.Text = empTemp.Cedula;
                textBox_nombre.Text = empTemp.Nombre;
                textBox_apellido.Text = empTemp.Apellido;
                textBox_contrasena.Text = empTemp.Contrasena;
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado = empTemp;
            empleado.Cedula = textBox_cedula.Text;
            empleado.Nombre = textBox_nombre.Text;
            empleado.Apellido = textBox_apellido.Text;
            empleado.Contrasena = Encriptar(textBox_contrasena.Text);
            MetodosNegocio.ActualizarEmpleado(empleado);
            MessageBox.Show("Empleado con Id " + empleado.Id + " se actualizó");
            cargarEmpleados(idUsu);
            limpiarCajas();
            botnonesDefecto();


        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            botnonesDefecto();  
        }
        void botnonesDefecto()
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            limpiarCajas();

        }
        private string Encriptar(string cadena)
        {
            string result = string.Empty;
            byte[] encryted = Encoding.Unicode.GetBytes(cadena);
            result = Convert.ToBase64String(encryted);
            return result;
        }
    }
}
