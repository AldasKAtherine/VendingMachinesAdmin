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
    public partial class Maquinas : Form
    {
        Usuario usuario;
        List<Maquina> maquinas = new List<Maquina>();
        int filaSelecciona = 0;
        public Maquinas()
        {
            InitializeComponent();
            usuario = new Usuario();
            usuario.Id = 1;
            BloquearTodosLosCampos(true);
            BloquearBotones();
            button_nuevo.Enabled = true;
        }

        void BloquearTodosLosCampos(bool con) {
            textBox_nombre.ReadOnly = con;
            textBox_descripcion.ReadOnly = con;
            textBox_ubicacion.ReadOnly = con;
            textBox_compartimentos.ReadOnly = con;
        }

        void LimpiarCampos()
        {
            textBox_nombre.Text = "";
            textBox_descripcion.Text = "";
            textBox_ubicacion.Text = "";
            textBox_compartimentos.Text = "";
        }

        void BloquearBotones() {
            button_insertar.Enabled = false;
            button_modificar.Enabled = false;
            button_cancelar.Enabled = false;
            button_eliminar.Enabled = false;
            button_nuevo.Enabled = false;
        }

        void CargarMaquinasEnGrid() {

            dataGrid_maquinas.DataSource = null;

            maquinas = MetodosNegocio.ListarMaquinas(usuario.Id);
            dataGrid_maquinas.DataSource = maquinas;

            dataGrid_maquinas.Columns["Id"].Visible = false;
            dataGrid_maquinas.Columns["IdUsuario"].Visible = false;
            dataGrid_maquinas.Columns["Nombre"].DisplayIndex = 0;
        }

        private void InsertarMaquina() {
            Maquina maquina = new Maquina();

            maquina.Nombre = textBox_nombre.Text;
            maquina.Descripcion = textBox_descripcion.Text;
            maquina.Ubicacion = textBox_ubicacion.Text;
            maquina.IdUsuario = usuario.Id;
            try {
                maquina.NumCompartimentos = Convert.ToInt32(textBox_compartimentos.Text);
            }
            catch (Exception) {
                MessageBox.Show("Inserte numeros en compartimentos");
            }

            bool correcto =  MetodosNegocio.InsertarMaquina(maquina);

            if (correcto)
            {
                MessageBox.Show("Insercion coreecta");
                BloquearTodosLosCampos(true);
                BloquearBotones();
                LimpiarCampos();
                button_nuevo.Enabled = true;
            }
            else {
                MessageBox.Show("Hubo un error");
            }
            

        }


        private void Maquinas_Load(object sender, EventArgs e)
        {
            CargarMaquinasEnGrid();
        }

        private void button_nuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BloquearBotones();
            button_insertar.Enabled = true;
            button_cancelar.Enabled = true;
            BloquearTodosLosCampos(false);
        }

        private void button_insertar_Click(object sender, EventArgs e)
        {
            InsertarMaquina();
            CargarMaquinasEnGrid();
        }

        private void dataGrid_maquinas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGrid_maquinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGrid_maquinas.MultiSelect = false;
            int indice = e.RowIndex;
            filaSelecciona = indice;
            Maquina maquina = maquinas.ElementAt(indice);

            textBox_nombre.Text = maquina.Nombre;
            textBox_descripcion.Text = maquina.Descripcion;
            textBox_ubicacion.Text = maquina.Ubicacion;
            textBox_compartimentos.Text = maquina.NumCompartimentos.ToString();
            BloquearBotones();
            button_cancelar.Enabled = true;
            button_eliminar.Enabled = true;
            button_modificar.Enabled = true;
            BloquearTodosLosCampos(false);
            textBox_compartimentos.Enabled = false;
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            BloquearTodosLosCampos(true);
            BloquearBotones();
            button_nuevo.Enabled = true;
            LimpiarCampos();
            dataGrid_maquinas.ClearSelection();
        }

        void EliminarMaquina()
        {
            Maquina maquina = maquinas.ElementAt(filaSelecciona);
            bool correcto = MetodosNegocio.EliminarMaquina(maquina);
            if (correcto) {
                MessageBox.Show("Eliminado Correctamente");
                CargarMaquinasEnGrid();
                BloquearTodosLosCampos(true);
                BloquearBotones();
                LimpiarCampos();
                button_nuevo.Enabled = true;
               
                dataGrid_maquinas.ClearSelection();
            }
            else
            {
                MessageBox.Show("Hubo un error");
            }
        }

        void ModificarMaquina() {

            Maquina maquina = maquinas.ElementAt(filaSelecciona);
            maquina.Nombre = textBox_nombre.Text;
            maquina.Descripcion = textBox_descripcion.Text;
            maquina.Ubicacion = textBox_ubicacion.Text;
            maquina.IdUsuario = usuario.Id;
            maquina.NumCompartimentos = Convert.ToInt32(textBox_compartimentos.Text);

            bool corecto = MetodosNegocio.ModificarMaquina(maquina);

            if (corecto) {
                MessageBox.Show("Correcto");
                BloquearTodosLosCampos(true);
                BloquearBotones();
                LimpiarCampos();
                button_nuevo.Enabled = true;
                dataGrid_maquinas.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void button_modificar_Click(object sender, EventArgs e)
        {
            ModificarMaquina();
            CargarMaquinasEnGrid();
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            EliminarMaquina();
        }

        private void dataGrid_maquinas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Maquina maquina = maquinas.ElementAt(filaSelecciona);
            Form interfazMaquina = new ControlMaquina(maquina);
            interfazMaquina.Show();
        }

        private void textBox_ubicacion_MouseClick(object sender, MouseEventArgs e)
        {
            if (!textBox_ubicacion.ReadOnly) {
                double lat;
                double lng;
                string[] datos = textBox_ubicacion.Text.Split(':');
                if (datos.Length > 1)
                {
                    lat = double.Parse(datos[0]);
                    lng = double.Parse(datos[1]);
                }
                else
                {
                    lat = 0;
                    lng = 0;
                }

                SeleccionarUbicacion form = new SeleccionarUbicacion(lat, lng);
                form.ShowDialog();
                Console.WriteLine("Lat:" + form.lat);
                if (form.lat != 0)
                {
                    textBox_ubicacion.Text = form.lat + ":" + form.lng;
                }
                else
                {
                    textBox_ubicacion.Text = "";
                }

            }

        }

        private void textBox_ubicacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
