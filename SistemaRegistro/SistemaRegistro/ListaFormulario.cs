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
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace SistemaRegistro
{
    public partial class ListaFormulario : Form
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
        public ListaFormulario()
        {
            InitializeComponent();
            dataGridView3.Rows.Add("Concreto simple,mecánico, f’c 200kg/cm2", "Elaboración de concreto simple hecho en obra con medios mecánicos, con una resistencia de f'c 200 kg/cm2, usado en estructuras habitacionales.", "Materias primas no energeticas", "Omar", "omar_asd@gmail.com", "Elaboración de concreto simple de resistencia f’c 200kg/cm2, hecho en obra con revolvedora mecánica y medios manuales, con cemento Portland compuesto, agua tratada, y agregado máxim de 20mm; inlcuye desperdicios.", "MJ", "12", "Estimar la huella de carbono y la demanda acumulada de ", "e consideran las emisiones generadas por la combustión de combustibles fósiles en la maquinaría para la construcción. ", "1", "Actual (más encontrada en operación)", "ste estudio se considera una revolvedora de concreto Joper modelo R2 con capacidad de un saco, con motor a gasolina de 8hp Magnum Kolher con trompo 30/35 rpm.", "12/02/200", "12/15/2000", "Jalisco", "Guadalajara", "19.5701420282982, -96.888427734375");
            dataGridView3.Rows.Add("Concreto simple,mecánico, f’c 200kg/cm2", "Elaboración de concreto simple hecho en obra con medios mecánicos, con una resistencia de f'c 200 kg/cm2, usado en estructuras habitacionales.", "Materias primas no energeticas", "Omar", "omar_asd@gmail.com", "Elaboración de concreto simple de resistencia f’c 200kg/cm2, hecho en obra con revolvedora mecánica y medios manuales, con cemento Portland compuesto, agua tratada, y agregado máxim de 20mm; inlcuye desperdicios.", "MJ", "12", "Estimar la huella de carbono y la demanda acumulada de ", "e consideran las emisiones generadas por la combustión de combustibles fósiles en la maquinaría para la construcción. ", "1", "Actual (más encontrada en operación)", "ste estudio se considera una revolvedora de concreto Joper modelo R2 con capacidad de un saco, con motor a gasolina de 8hp Magnum Kolher con trompo 30/35 rpm.", "12/02/200", "12/15/2000", "Jalisco", "Guadalajara", "19.5701420282982, -96.888427734375");
            dataGridView3.Rows.Add("Concreto simple,mecánico, f’c 200kg/cm2", "Elaboración de concreto simple hecho en obra con medios mecánicos, con una resistencia de f'c 200 kg/cm2, usado en estructuras habitacionales.", "Materias primas no energeticas", "Omar", "omar_asd@gmail.com", "Elaboración de concreto simple de resistencia f’c 200kg/cm2, hecho en obra con revolvedora mecánica y medios manuales, con cemento Portland compuesto, agua tratada, y agregado máxim de 20mm; inlcuye desperdicios.", "MJ", "12", "Estimar la huella de carbono y la demanda acumulada de ", "e consideran las emisiones generadas por la combustión de combustibles fósiles en la maquinaría para la construcción. ", "1", "Actual (más encontrada en operación)", "ste estudio se considera una revolvedora de concreto Joper modelo R2 con capacidad de un saco, con motor a gasolina de 8hp Magnum Kolher con trompo 30/35 rpm.", "12/02/200", "12/15/2000", "Jalisco", "Guadalajara", "19.5701420282982, -96.888427734375");
            dataGridView3.Rows.Add("Concreto simple,mecánico, f’c 200kg/cm2", "Elaboración de concreto simple hecho en obra con medios mecánicos, con una resistencia de f'c 200 kg/cm2, usado en estructuras habitacionales.", "Materias primas no energeticas", "Omar", "omar_asd@gmail.com", "Elaboración de concreto simple de resistencia f’c 200kg/cm2, hecho en obra con revolvedora mecánica y medios manuales, con cemento Portland compuesto, agua tratada, y agregado máxim de 20mm; inlcuye desperdicios.", "MJ", "12", "Estimar la huella de carbono y la demanda acumulada de ", "e consideran las emisiones generadas por la combustión de combustibles fósiles en la maquinaría para la construcción. ", "1", "Actual (más encontrada en operación)", "ste estudio se considera una revolvedora de concreto Joper modelo R2 con capacidad de un saco, con motor a gasolina de 8hp Magnum Kolher con trompo 30/35 rpm.", "12/02/200", "12/15/2000", "Jalisco", "Guadalajara", "19.5701420282982, -96.888427734375");
            dataGridView3.Rows.Add("Concreto simple,mecánico, f’c 200kg/cm2", "Elaboración de concreto simple hecho en obra con medios mecánicos, con una resistencia de f'c 200 kg/cm2, usado en estructuras habitacionales.", "Materias primas no energeticas", "Omar", "omar_asd@gmail.com", "Elaboración de concreto simple de resistencia f’c 200kg/cm2, hecho en obra con revolvedora mecánica y medios manuales, con cemento Portland compuesto, agua tratada, y agregado máxim de 20mm; inlcuye desperdicios.", "MJ", "12", "Estimar la huella de carbono y la demanda acumulada de ", "e consideran las emisiones generadas por la combustión de combustibles fósiles en la maquinaría para la construcción. ", "1", "Actual (más encontrada en operación)", "ste estudio se considera una revolvedora de concreto Joper modelo R2 con capacidad de un saco, con motor a gasolina de 8hp Magnum Kolher con trompo 30/35 rpm.", "12/02/200", "12/15/2000", "Jalisco", "Guadalajara", "19.5701420282982, -96.888427734375");
            dataGridView3.Rows.Add("Concreto simple,mecánico, f’c 200kg/cm2", "Elaboración de concreto simple hecho en obra con medios mecánicos, con una resistencia de f'c 200 kg/cm2, usado en estructuras habitacionales.", "Materias primas no energeticas", "Omar", "omar_asd@gmail.com", "Elaboración de concreto simple de resistencia f’c 200kg/cm2, hecho en obra con revolvedora mecánica y medios manuales, con cemento Portland compuesto, agua tratada, y agregado máxim de 20mm; inlcuye desperdicios.", "MJ", "12", "Estimar la huella de carbono y la demanda acumulada de ", "e consideran las emisiones generadas por la combustión de combustibles fósiles en la maquinaría para la construcción. ", "1", "Actual (más encontrada en operación)", "ste estudio se considera una revolvedora de concreto Joper modelo R2 con capacidad de un saco, con motor a gasolina de 8hp Magnum Kolher con trompo 30/35 rpm.", "12/02/200", "12/15/2000", "Jalisco", "Guadalajara", "19.5701420282982, -96.888427734375");
            dataGridView3.Rows.Add("Concreto simple,mecánico, f’c 200kg/cm2", "Elaboración de concreto simple hecho en obra con medios mecánicos, con una resistencia de f'c 200 kg/cm2, usado en estructuras habitacionales.", "Materias primas no energeticas", "Omar", "omar_asd@gmail.com", "Elaboración de concreto simple de resistencia f’c 200kg/cm2, hecho en obra con revolvedora mecánica y medios manuales, con cemento Portland compuesto, agua tratada, y agregado máxim de 20mm; inlcuye desperdicios.", "MJ", "12", "Estimar la huella de carbono y la demanda acumulada de ", "e consideran las emisiones generadas por la combustión de combustibles fósiles en la maquinaría para la construcción. ", "1", "Actual (más encontrada en operación)", "ste estudio se considera una revolvedora de concreto Joper modelo R2 con capacidad de un saco, con motor a gasolina de 8hp Magnum Kolher con trompo 30/35 rpm.", "12/02/200", "12/15/2000", "Jalisco", "Guadalajara", "19.5701420282982, -96.888427734375");
            dataGridView3.Rows.Add("Concreto simple,mecánico, f’c 200kg/cm2", "Elaboración de concreto simple hecho en obra con medios mecánicos, con una resistencia de f'c 200 kg/cm2, usado en estructuras habitacionales.", "Materias primas no energeticas", "Omar", "omar_asd@gmail.com", "Elaboración de concreto simple de resistencia f’c 200kg/cm2, hecho en obra con revolvedora mecánica y medios manuales, con cemento Portland compuesto, agua tratada, y agregado máxim de 20mm; inlcuye desperdicios.", "MJ", "12", "Estimar la huella de carbono y la demanda acumulada de ", "e consideran las emisiones generadas por la combustión de combustibles fósiles en la maquinaría para la construcción. ", "1", "Actual (más encontrada en operación)", "ste estudio se considera una revolvedora de concreto Joper modelo R2 con capacidad de un saco, con motor a gasolina de 8hp Magnum Kolher con trompo 30/35 rpm.", "12/02/200", "12/15/2000", "Jalisco", "Guadalajara", "19.5701420282982, -96.888427734375");
            dataGridView3.Rows.Add("Concreto simple,mecánico, f’c 200kg/cm2", "Elaboración de concreto simple hecho en obra con medios mecánicos, con una resistencia de f'c 200 kg/cm2, usado en estructuras habitacionales.", "Materias primas no energeticas", "Omar", "omar_asd@gmail.com", "Elaboración de concreto simple de resistencia f’c 200kg/cm2, hecho en obra con revolvedora mecánica y medios manuales, con cemento Portland compuesto, agua tratada, y agregado máxim de 20mm; inlcuye desperdicios.", "MJ", "12", "Estimar la huella de carbono y la demanda acumulada de ", "e consideran las emisiones generadas por la combustión de combustibles fósiles en la maquinaría para la construcción. ", "1", "Actual (más encontrada en operación)", "ste estudio se considera una revolvedora de concreto Joper modelo R2 con capacidad de un saco, con motor a gasolina de 8hp Magnum Kolher con trompo 30/35 rpm.", "12/02/200", "12/15/2000", "Jalisco", "Guadalajara", "19.5701420282982, -96.888427734375");
            dataGridView3.Rows.Add("Concreto simple,mecánico, f’c 200kg/cm2", "Elaboración de concreto simple hecho en obra con medios mecánicos, con una resistencia de f'c 200 kg/cm2, usado en estructuras habitacionales.", "Materias primas no energeticas", "Omar", "omar_asd@gmail.com", "Elaboración de concreto simple de resistencia f’c 200kg/cm2, hecho en obra con revolvedora mecánica y medios manuales, con cemento Portland compuesto, agua tratada, y agregado máxim de 20mm; inlcuye desperdicios.", "MJ", "12", "Estimar la huella de carbono y la demanda acumulada de ", "e consideran las emisiones generadas por la combustión de combustibles fósiles en la maquinaría para la construcción. ", "1", "Actual (más encontrada en operación)", "ste estudio se considera una revolvedora de concreto Joper modelo R2 con capacidad de un saco, con motor a gasolina de 8hp Magnum Kolher con trompo 30/35 rpm.", "12/02/200", "12/15/2000", "Jalisco", "Guadalajara", "19.5701420282982, -96.888427734375");
            dataGridView3.Rows.Add("Concreto simple,mecánico, f’c 200kg/cm2", "Elaboración de concreto simple hecho en obra con medios mecánicos, con una resistencia de f'c 200 kg/cm2, usado en estructuras habitacionales.", "Materias primas no energeticas", "Omar", "omar_asd@gmail.com", "Elaboración de concreto simple de resistencia f’c 200kg/cm2, hecho en obra con revolvedora mecánica y medios manuales, con cemento Portland compuesto, agua tratada, y agregado máxim de 20mm; inlcuye desperdicios.", "MJ", "12", "Estimar la huella de carbono y la demanda acumulada de ", "e consideran las emisiones generadas por la combustión de combustibles fósiles en la maquinaría para la construcción. ", "1", "Actual (más encontrada en operación)", "ste estudio se considera una revolvedora de concreto Joper modelo R2 con capacidad de un saco, con motor a gasolina de 8hp Magnum Kolher con trompo 30/35 rpm.", "12/02/200", "12/15/2000", "Jalisco", "Guadalajara", "19.5701420282982, -96.888427734375");
            dataGridView3.Rows.Add("Concreto simple,mecánico, f’c 200kg/cm2", "Elaboración de concreto simple hecho en obra con medios mecánicos, con una resistencia de f'c 200 kg/cm2, usado en estructuras habitacionales.", "Materias primas no energeticas", "Omar", "omar_asd@gmail.com", "Elaboración de concreto simple de resistencia f’c 200kg/cm2, hecho en obra con revolvedora mecánica y medios manuales, con cemento Portland compuesto, agua tratada, y agregado máxim de 20mm; inlcuye desperdicios.", "MJ", "12", "Estimar la huella de carbono y la demanda acumulada de ", "e consideran las emisiones generadas por la combustión de combustibles fósiles en la maquinaría para la construcción. ", "1", "Actual (más encontrada en operación)", "ste estudio se considera una revolvedora de concreto Joper modelo R2 con capacidad de un saco, con motor a gasolina de 8hp Magnum Kolher con trompo 30/35 rpm.", "12/02/200", "12/15/2000", "Jalisco", "Guadalajara", "19.5701420282982, -96.888427734375");
            dataGridView3.Rows.Add("Concreto simple,mecánico, f’c 200kg/cm2", "Elaboración de concreto simple hecho en obra con medios mecánicos, con una resistencia de f'c 200 kg/cm2, usado en estructuras habitacionales.", "Materias primas no energeticas", "Omar", "omar_asd@gmail.com", "Elaboración de concreto simple de resistencia f’c 200kg/cm2, hecho en obra con revolvedora mecánica y medios manuales, con cemento Portland compuesto, agua tratada, y agregado máxim de 20mm; inlcuye desperdicios.", "MJ", "12", "Estimar la huella de carbono y la demanda acumulada de ", "e consideran las emisiones generadas por la combustión de combustibles fósiles en la maquinaría para la construcción. ", "1", "Actual (más encontrada en operación)", "ste estudio se considera una revolvedora de concreto Joper modelo R2 con capacidad de un saco, con motor a gasolina de 8hp Magnum Kolher con trompo 30/35 rpm.", "12/02/200", "12/15/2000", "Jalisco", "Guadalajara", "19.5701420282982, -96.888427734375");
            dataGridView3.Rows.Add("Concreto simple,mecánico, f’c 200kg/cm2", "Elaboración de concreto simple hecho en obra con medios mecánicos, con una resistencia de f'c 200 kg/cm2, usado en estructuras habitacionales.", "Materias primas no energeticas", "Omar", "omar_asd@gmail.com", "Elaboración de concreto simple de resistencia f’c 200kg/cm2, hecho en obra con revolvedora mecánica y medios manuales, con cemento Portland compuesto, agua tratada, y agregado máxim de 20mm; inlcuye desperdicios.", "MJ", "12", "Estimar la huella de carbono y la demanda acumulada de ", "e consideran las emisiones generadas por la combustión de combustibles fósiles en la maquinaría para la construcción. ", "1", "Actual (más encontrada en operación)", "ste estudio se considera una revolvedora de concreto Joper modelo R2 con capacidad de un saco, con motor a gasolina de 8hp Magnum Kolher con trompo 30/35 rpm.", "12/02/200", "12/15/2000", "Jalisco", "Guadalajara", "19.5701420282982, -96.888427734375");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resut = MessageBox.Show("¿Desea eliminar los elementos seleccionados?", "Aviso", MessageBoxButtons.YesNo);
            if (resut == DialogResult.Yes)
            {

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
            //dataGridView1.DataSource = dt;

            //desactivar las columnas de lat y long
            //dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns[2].Visible = false;

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

        private void btnSeleccionarT_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView3.Rows)
            {
                row.Cells[19].Value = row.Cells[19].Value == null ? false : !(bool)row.Cells[19].Value;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult resut = MessageBox.Show("¿Desea eliminar los elementos seleccionados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resut == DialogResult.Yes)
            {

            }
            else if (resut == DialogResult.No)
            {
                return;
            }
        }
    }
}
