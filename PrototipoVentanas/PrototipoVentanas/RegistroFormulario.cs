using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;

namespace PrototipoVentanas
{
    public partial class RegistroFormulario : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;

        //Ruta automatizada(dirección)
        bool trazarRuta = false;
        int ContadorIndicadoresRuta = 0;
        PointLatLng inicio;
        PointLatLng final;

        int filaSeleccionada = 0;
        double LatInicial = 19.6011941612631;
        double LngInicial = -99.140625;

        public RegistroFormulario()
        {
            InitializeComponent();
        }


        private void comboUno_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboDos.Enabled = false;
            comboTres.Enabled = false;
            comboCuatro.Enabled = false;
            comboCinco.Enabled = false;
            comboSeis.Enabled = false;
            comboSiete.Enabled = false;
        }

        private void comboDos_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboUno.Enabled = false;
            comboTres.Enabled = false;
            comboCuatro.Enabled = false;
            comboCinco.Enabled = false;
            comboSeis.Enabled = false;
            comboSiete.Enabled = false;
        }

        private void comboTres_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboUno.Enabled = false;
            comboDos.Enabled = false;
            comboCuatro.Enabled = false;
            comboCinco.Enabled = false;
            comboSeis.Enabled = false;
            comboSiete.Enabled = false;
        }

        private void comboCuatro_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboUno.Enabled = false;
            comboDos.Enabled = false;
            comboTres.Enabled = false;
            comboCinco.Enabled = false;
            comboSeis.Enabled = false;
            comboSiete.Enabled = false;
        }

        private void comboCinco_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboUno.Enabled = false;
            comboDos.Enabled = false;
            comboTres.Enabled = false;
            comboCuatro.Enabled = false;
            comboSeis.Enabled = false;
            comboSiete.Enabled = false;
        }

        private void comboSeis_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboUno.Enabled = false;
            comboDos.Enabled = false;
            comboTres.Enabled = false;
            comboCuatro.Enabled = false;
            comboCinco.Enabled = false;
            comboSiete.Enabled = false;
        }

        private void comboSiete_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboUno.Enabled = false;
            comboDos.Enabled = false;
            comboTres.Enabled = false;
            comboCuatro.Enabled = false;
            comboCinco.Enabled = false;
            comboSeis.Enabled = false;
        }

        private void buttonSiguienteP_Click(object sender, EventArgs e)
        {
            DialogResult resut = MessageBox.Show("Se necesita ingresar información en los campos obligatorios ", "Aviso", MessageBoxButtons.YesNo);
            if (resut == DialogResult.Yes)
            {

                tabControl1.SelectTab(Referencia);
            }
            else if (resut == DialogResult.No)
            {
                return;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Crear una instancia de OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Establecer las propiedades del OpenFileDialog
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif|Todos los archivos|*.*";
            openFileDialog.Title = "Seleccionar imagen";

            // Mostrar el cuadro de diálogo para seleccionar un archivo
            DialogResult result = openFileDialog.ShowDialog();

            // Verificar si se seleccionó un archivo y se hizo clic en "Aceptar"
            if (result == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string imagePath = openFileDialog.FileName;

                // Establecer la imagen en el PictureBox
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }

        private void buttoAtrasP_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(Identificación);
        }

        private void buttonSiguenteS_Click(object sender, EventArgs e)
        {

            DialogResult resut = MessageBox.Show("Se necesita ingresar información en los campos obligatorios ", "Aviso", MessageBoxButtons.YesNo);
            if (resut == DialogResult.Yes)
            {
                tabControl1.SelectTab(Tecnología);
            }
            else if (resut == DialogResult.No)
            {
                return;
            }
        }

        private void buttonAtrasR_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(Referencia);
        }

        private void buttonSiguienteT_Click(object sender, EventArgs e)
        {

            DialogResult resut = MessageBox.Show("Se necesita ingresar información en los campos obligatorios ", "Aviso", MessageBoxButtons.YesNo);
            if (resut == DialogResult.Yes)
            {
                tabControl1.SelectTab(TiempoVálido);
            }
            else if (resut == DialogResult.No)
            {
                return;
            }
        }

        private void buttonAtrasTec_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(Tecnología);

        }

        private void buttonSiguienteC_Click(object sender, EventArgs e)
        {
            DialogResult resut = MessageBox.Show("Se necesita ingresar información en los campos obligatorios ", "Aviso", MessageBoxButtons.YesNo);
            if (resut == DialogResult.Yes)
            {
                tabControl1.SelectTab(Geografía);
            }
            else if (resut == DialogResult.No)
            {
                return;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Descripción", typeof(string)));
            dt.Columns.Add(new DataColumn("Lat", typeof(double)));
            dt.Columns.Add(new DataColumn("Long", typeof(double)));

            //insertando datos al dt para mostrar en la lista
            dt.Rows.Add("Ubicación", LatInicial, LngInicial);
            dataGridView1.DataSource = dt;

            //desactivar las columnas de lat y long
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;

            //Creando las dimensiones del GMAPCONTROL(herramienta)
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 5;
            gMapControl1.AutoScroll = true;

            //Marcador
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.blue);
            markerOverlay.Markers.Add(marker);//Agregamos al mapa

            //agregamos un tooltip de texto a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicación:\n Latitud:{0}\n Longitud:{1}", LatInicial, LngInicial);

            //ahora agregamos el mapa y el marcador al control map

            gMapControl1.Overlays.Add(markerOverlay);

        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //se obtiene los datos de lat y lng del mapa donde usuario presiono
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            //se posicionan en el txt de la latitud y longitud
            //  txtlatitud.Text = lat.ToString();
            //txtlongitud.Text = lng.ToString();

            //crearemos el marcador para moverlo al lugar indicado por el usuario
            marker.Position = new PointLatLng(lat, lng);
            //tambien se agregara el mensaje al marcador es decir el ToolTip
            marker.ToolTipText = string.Format("Ubicación:\n Latitud:{0}\n Longitud:{1}", lat, lng);

            //CrearDireccionTrazarRuta(lat, lng);

        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
        }
        private void trackZoom_ValueChanged(object sender, EventArgs e)
        {
            gMapControl1.Zoom = trackZoom.Value;
        }

        private void buttonGuardarG_Click(object sender, EventArgs e)
        {
            DialogResult resut = MessageBox.Show("Los datos guardados correctamente", "Aviso", MessageBoxButtons.YesNo);
            if (resut == DialogResult.Yes)
            {
                tabControl1.SelectTab(Identificación);
            }
            else if (resut == DialogResult.No)
            {
                return;
            }
        }
    }
}
