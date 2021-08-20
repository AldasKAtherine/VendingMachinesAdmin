using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace ProyectoDesarrollo
{
    public partial class SeleccionarUbicacion : Form
    {
        GMarkerGoogle marcador;
        GMapOverlay overlay;

        public double lat { get; set; }
        public double lng { get; set; }
        public SeleccionarUbicacion(double lat, double lng)
        {
            InitializeComponent();
            this.lat = lat;
            this.lng = lng;
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
            
            marcador.Position = new PointLatLng(lat, lng);
            marcador.ToolTipText = string.Format("Ubicacion: {0} \n {1}", lat, lng);

        }

        private void SeleccionarUbicacion_Load(object sender, EventArgs e)
        {
            PointLatLng posicionDefecto = new PointLatLng(-1.2691073, -78.625745);
            
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            
            gMapControl1.MinZoom = 3;
            gMapControl1.MaxZoom = 19;
            gMapControl1.Zoom = 17;

            overlay = new GMapOverlay("Marcador");
            Console.WriteLine("Hola: " + lat);
            if (lat != 0)
            {
                marcador = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.blue);
                gMapControl1.Position = new PointLatLng(lat, lng);
            }
            else {
                marcador = new GMarkerGoogle(posicionDefecto, GMarkerGoogleType.blue);
                gMapControl1.Position = posicionDefecto;
            }
            overlay.Markers.Add(marcador);

            marcador.ToolTipMode = MarkerTooltipMode.Always;
            gMapControl1.Overlays.Add(overlay);
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            lat = 0;
            lng = 0;
            Close();
        }
    }
}
