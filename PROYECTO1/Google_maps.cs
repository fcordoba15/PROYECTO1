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

namespace PROYECTO1
{
    public partial class Google_maps : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;

        int filaSeleccionada = 0;
        double LatInicial = 20.96881328132813906;
        double LngInicial = -89.6250915527344;

        public Google_maps()
        {
            InitializeComponent();
        }

        

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Ubicación", typeof(string)));
            dt.Columns.Add(new DataColumn("Lat", typeof(double)));
            dt.Columns.Add(new DataColumn("Long", typeof(double)));

            //Insertar datos dt para mostrar pick up
            dt.Rows.Add("Ubicación 1", LatInicial, LngInicial);
            dataGridView1.DataSource = dt;

            //Desactivar columns
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            //MARCADOR
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.red);
            markerOverlay.Markers.Add(marker); //agregar al mapa

            //agregar un tooltip de texto a marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicación: \n Latitud: {0} Longitud: {1}", LatInicial, LngInicial);

            gMapControl1.Overlays.Add(markerOverlay);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SeleccionarRegistro(object sender, DataGridViewCellMouseEventArgs e)
        {
            filaSeleccionada = e.RowIndex; //Fila seleccionada
            //Recuperamos los datos del grid y asignarlos 
            txtUbicacion.Text = dataGridView1.Rows[filaSeleccionada].Cells[0].Value.ToString();
            txtLatitud.Text = dataGridView1.Rows[filaSeleccionada].Cells[1].Value.ToString();
            txtLongitud.Text = dataGridView1.Rows[filaSeleccionada].Cells[2].Value.ToString();

            //Se asignan los valores del grid al marcador
            marker.Position = new PointLatLng(Convert.ToDouble(txtLatitud.Text), Convert.ToDouble(txtLongitud.Text));
            //Posicionar Mapa
            gMapControl1.Position = marker.Position;



        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Obtener datos lat y log del cursor
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            //se posicionan en txt de lat y long
            txtLatitud.Text = lat.ToString();
            txtLongitud.Text = lng.ToString();

            //Mover maker
            marker.Position = new PointLatLng(lat, lng);
            //mensaje
            marker.ToolTipText = string.Format("Ubicación: \n Latitud: {0} \n Longitud: {1}", lat, lng);




        }

        private void guardar_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtUbicacion.Text, txtLatitud.Text, txtLongitud.Text);
           /* cn.Resgistar_GMaps(,txtUbicacion, txtLatitud, txtLongitud);*/

        }
    }
}
