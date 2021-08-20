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
    public partial class RecargasPresentacion : Form
    {
        int idUsu;
        int idCompart;
        int idProd;
        int idEmple;
        int cant;
        public RecargasPresentacion(int idUsuario)
        {
            InitializeComponent();
            idUsu = idUsuario;
        }

        private void RecargasPresentacion_Load(object sender, EventArgs e)
        {
            CargarComboMaquina();
            CargarComboProductos();
            CargarComboEmpleado();
            CargarTabla(idUsu);

        }

        private void CargarComboEmpleado()
        {
            List<Empleado> empleados = new List<Empleado>();
            empleados = MetodosNegocio.listaEmpleados(idUsu);
            foreach (var item in empleados)
            {
                comboBox_empleado.Items.Add(item.Id+" "+item.Nombre);
            }
        }

        void CargarComboMaquina()
        {
            
            List<Maquina> maquinas = new List<Maquina>();
            maquinas = MetodosNegocio.ListarMaquinas2(idUsu);
            foreach (var item in maquinas)
            {
                comboBox_maquina.Items.Add(item.Id + " " + item.Nombre);
            }
            //comboBox_maquina.SelectedIndex = 0;
            
        }
        void CargarComboCompartimientos(int idMaquina)
        {
            List<Compartimento> compartimentos = new List<Compartimento>();
            compartimentos = MetodosNegocio.ListarCompartimiento2(idMaquina);
            comboBox_compartimiento.Items.Clear();
            foreach (var item in compartimentos)
            {
                comboBox_compartimiento.Items.Add(item.Id + " " + item.Posicion);
            }
        }

        void CargarComboProductos()
        {
            List<Producto> productos = new List<Producto>();
            productos = MetodosNegocio.ListarProductos2(idUsu);
            comboBox_producto.Items.Clear();
            foreach (var item in productos)
            {
                comboBox_producto.Items.Add(item.Id + " " + item.Nombre);
            }
        }

        private void comboBox_maquina_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox_maquina.Items.Clear();
            string []id=comboBox_maquina.SelectedItem.ToString().Split(' ');
            int idMaq = Convert.ToInt32(id[0]);
            
            CargarComboCompartimientos(idMaq);

        }

        private void comboBox_compartimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] IDc = comboBox_compartimiento.SelectedItem.ToString().Split(' ');

            idCompart = Convert.ToInt32(IDc[0].ToString());
           
            
        }

        private void comboBox_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] idP = comboBox_producto.SelectedItem.ToString().Split(' ');
            idProd = Convert.ToInt32(idP[0].ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            Recargas recarga = new Recargas();
            recarga.Cantidad=cant;
            recarga.FechaHora = date;
            recarga.id_compartimiento = idCompart;
            recarga.id_producto = idProd;
            recarga.id_Empleado = idEmple;
            MetodosNegocio.CrearRecargas(recarga);
            
        }

        private void comboBox_empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] idE = comboBox_empleado.SelectedItem.ToString().Split(' ');
            idEmple = Convert.ToInt32(idE[0].ToString());
        }

        private void numericUpDown_cantidad_ValueChanged(object sender, EventArgs e)
        {
            decimal val = numericUpDown_cantidad.Value;
            cant = Convert.ToInt32(val);
        }
        private void CargarTabla(int idU)
        {
            dataGridView_recargas.DataSource = null;
            List<Recargas> Listrecargas = new List<Recargas>();
            Listrecargas = MetodosNegocio.LeerRecargas(idU);
            dataGridView_recargas.DataSource = Listrecargas;
            dataGridView_recargas.Columns["id_compartimiento"].Visible = false;
        }
    }
}
