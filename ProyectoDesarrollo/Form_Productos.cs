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
    public partial class Form_Productos : Form
    {
        Producto productoGuardar = new Producto();
        List<Producto> listaProductos = new List<Producto>();
        Producto productoSeleccionado = new Producto();
        int idUsu;
        Usuario usuario;
        public Form_Productos()
        {
            
            InitializeComponent();
            idUsu = 1;
            CargarTabla();
            estadoBotones(false);
        }

        private void estadoBotones(bool v)
        {
            button_eliminar.Enabled = v;
            button_modificar.Enabled = v;
            button_cancelar.Enabled = true;
            button_insertar.Enabled = !v;

        }

        private void CargarTabla()
        {
           
       
            listaProductos = MetodosNegocio.CargarProductos(idUsu);
            dataGridView_productos.DataSource = null;
            dataGridView_productos.DataSource = listaProductos;
            //dataGridView_productos.Columns["Nombre"].DisplayIndex = 0;
            //dataGridView_productos.Columns["Descripcion"].DisplayIndex = 1;
            //dataGridView_productos.Columns["Precio"].DisplayIndex = 2;
            //dataGridView_productos.Columns["Stock"].DisplayIndex = 3;

            //dataGridView_productos.Columns["Estado"].Visible = false;
            //dataGridView_productos.Columns["IdUsuario"].Visible = false;
            //dataGridView_productos.Columns["Id"].Visible = false;


        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void Button_insertar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
            
            
        }

        private void ValidarCampos()
        {
            if (textBox_nombre.Text.Equals(""))
            {
                textBox_nombre.Focus();
            }
            else if (textBox_descripcion.Text.Equals(""))
            {
                textBox_descripcion.Focus();
            }
            else if (textBox_precio.Text.Equals(""))
            {
                textBox_precio.Focus();
            }
            else if (textBox_stock.Text.Equals(""))
            {
                textBox_stock.Focus();
            }
            else
            {
                GuararProducto();
                
            }
        }

        private void GuararProducto()
        {
            Producto productoGuardar = new Producto();
            
            productoGuardar.Nombre = textBox_nombre.Text;
            productoGuardar.Descripcion = textBox_descripcion.Text;
            productoGuardar.Precio = Convert.ToDouble(textBox_precio.Text);
            productoGuardar.Stock = Convert.ToInt32(textBox_stock.Text);
            productoGuardar.IdUsuario = idUsu;

            bool correcto = MetodosNegocio.GuardarProducto(productoGuardar);
            if (correcto)
            {
                MessageBox.Show("insercion correcta");
                CargarTabla();
                limpiarCampos();
                estadoBotones(false);
            }
            else
            {
                MessageBox.Show("Error: insercion incompleta");
            }
        }

        private void DataGridView_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CompletarCampos();
            estadoBotones(true); ;
        }

        private void CompletarCampos()
        {

            productoSeleccionado.Id = Convert.ToInt32(this.dataGridView_productos.CurrentRow.Cells[0].Value.ToString());
            productoSeleccionado.Nombre = this.dataGridView_productos.CurrentRow.Cells[1].Value.ToString();
            productoSeleccionado.Descripcion = this.dataGridView_productos.CurrentRow.Cells[2].Value.ToString();
            productoSeleccionado.Precio = Convert.ToDouble(this.dataGridView_productos.CurrentRow.Cells[3].Value.ToString());
            productoSeleccionado.Stock =Convert.ToInt32(this.dataGridView_productos.CurrentRow.Cells[4].Value.ToString());
            productoSeleccionado.IdUsuario = Convert.ToInt32(this.dataGridView_productos.CurrentRow.Cells[5].Value.ToString());


            textBox_nombre.Text = productoSeleccionado.Nombre;
            textBox_descripcion.Text = productoSeleccionado.Descripcion;
            textBox_precio.Text = productoSeleccionado.Precio.ToString();
            textBox_stock.Text = productoSeleccionado.Stock.ToString();
            
        }

        private void Button_modificar_Click(object sender, EventArgs e)
        {
            modificarProduto();
            
        }

        private void modificarProduto()
        {
            productoSeleccionado.Nombre = textBox_nombre.Text;
            productoSeleccionado.Descripcion = textBox_descripcion.Text;
            productoSeleccionado.Precio = Convert.ToDouble(textBox_precio.Text);
            productoSeleccionado.Stock = Convert.ToInt32(textBox_stock.Text);
            bool correcto = MetodosNegocio.ModificarProducto(productoSeleccionado);
            Console.WriteLine(correcto);
            if (correcto)
            {
                MessageBox.Show("modificacion exitosa");
                CargarTabla();
                limpiarCampos();
                estadoBotones(false);
            }
            else
            {
                MessageBox.Show("Error: actualizacion incompleta");
            }
        }

        private void Button_eliminar_Click(object sender, EventArgs e)
        {
            eliminarProducto();
        }

        private void eliminarProducto()
        {
            bool correcto = MetodosNegocio.EliminarProducto(productoSeleccionado);
            if (correcto)
            {
                MessageBox.Show("eliminacion exitosa");
                CargarTabla();
                limpiarCampos();
                estadoBotones(false);
            }
            else
            {
                MessageBox.Show("Error: eliminacion incompleta");
            }
        }

        private void Button_cancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            estadoBotones(false);
        }

        private void limpiarCampos()
        {
            textBox_nombre.Text = "";
            textBox_descripcion.Text = "";
            textBox_precio.Text = "";
            textBox_stock.Text = "";
        }

        private void DataGridView_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
