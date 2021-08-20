using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace ProyectoDesarrollo
{
    public partial class ControlMaquina : Form
    {
        List<Compartimento> compartimentos;
        Maquina maquina;

        public ControlMaquina(Maquina maquina)
        {
            InitializeComponent();
            label_nombreMaquina.Text = maquina.Nombre;
            label_descripcion.Text = maquina.Descripcion;
            this.maquina = maquina;
            CargarCompartimentos();
            listBox1.SelectedIndex = 0;
            MostarInfoCompartimento(0);
        }

        private void CargarCompartimentos()
        {
            listBox1.Items.Clear();
            compartimentos = MetodosNegocio.ListarCompoartimentoDeMauina(maquina.Id);
            foreach (var compartimento in compartimentos)
            {
                listBox1.Items.Add("Posicion: "+ compartimento.Posicion);
            }
        }

        private void ControlMaquina_Load(object sender, EventArgs e)
        {
            gMapControl1.CanDragMap = false;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            double lat;
            double lng;
            string[] datos = maquina.Ubicacion.Split(':');
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
            gMapControl1.Position = new PointLatLng(lat, lng);
            gMapControl1.MinZoom = 3;
            gMapControl1.MaxZoom = 19;
            gMapControl1.Zoom = 16 ;
            
        }

       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            MostarInfoCompartimento(listBox1.SelectedIndex);
        }

        private void MostarInfoCompartimento(int selectedIndex)
        {
            Compartimento compartimento = compartimentos.ElementAt(selectedIndex);
            label_capacidad.Text = compartimento.Capacidad.ToString();
            label_cantidad.Text = compartimento.Cantidad.ToString();
            if (compartimento.Producto.Nombre != null)
            {
                label_producto.Text = compartimento.Producto.Nombre;
            }
            else {
                label_producto.Text = "Sin Producto";
            }
 
        }


        void MostartCodigo() {
            printDocument1.DocumentName = maquina.Nombre;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void button_codigo_Click(object sender, EventArgs e)
        {
            MostartCodigo();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics pagina = e.Graphics;

            int lineaY = 20;

            Pen blackPen = new Pen(Color.Black, 3);
            Rectangle rect = new Rectangle(0, 0, 600, 300);
            pagina.DrawRectangle(blackPen, rect);

            Font fuenteTitulo = new Font("Arial", 12, FontStyle.Bold);
            Font fuenteSubtitulo = new Font("Arial", 10, FontStyle.Bold);
            Font fuenteCuerpo = new Font("Arial", 9);
            Font fuenteEncabezados = new Font("Arial", 9, FontStyle.Bold);

            pagina.DrawString(maquina.Nombre, fuenteTitulo, Brushes.Black, 20, lineaY);
            lineaY += 30;
            pagina.DrawString(maquina.Descripcion, fuenteSubtitulo, Brushes.Black, 20, lineaY);
            lineaY += 30;
            pagina.DrawString("Fecha de Impresion: " + DateTime.Now, fuenteSubtitulo, Brushes.Black, 20, lineaY);
            // Mapa 
            lineaY += 40;
            Image mapa = gMapControl1.ToImage();
            e.Graphics.DrawImage(mapa, new Rectangle(150, lineaY, 150, 150));
            // Codigo QR

            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            Image codigoQR = qrcode.Draw(maquina.Id.ToString(), 150);
            e.Graphics.DrawImage(codigoQR, new Rectangle(350, lineaY, 150, 150));

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
