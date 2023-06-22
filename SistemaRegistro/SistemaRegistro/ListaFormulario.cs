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
using SistemaRegistro.Controladores;
using SistemaRegistro.Modelo;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data.SqlClient;
using Image = System.Drawing.Image;
using Rectangle = System.Drawing.Rectangle;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaRegistro
{
    public partial class ListaFormulario : Form
    {
        //instacia controlador formualario
        ControladorDatosFormulario controladorDatosFormulario = new ControladorDatosFormulario();
        //instacia modelo formulario
        modeloIngresoDatos modeloDatos = new modeloIngresoDatos();
        DataTable dsTabla;
        //se declaro el id del ingresoDatos para guardar y posteriormente usarlo en procedimiento almacenado de modificar
        private int id;

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
            CargarDG();
        }

        private void CargarDG()
        {
            dsTabla = controladorDatosFormulario.SeleccionarDatosFormulario(); //La tabla se recarga con el procedimiento almacenado Seleccionar_Datos_User.

            //int p = panel2.Width;

            dataGridView1.DataSource = dsTabla;
            //dataGridView1.ScrollBars = ScrollBars.None; //Desactivar ScrollBar del DataGridView


            dataGridView1.Columns[1].HeaderText = "Producto_Tecnología_otro";
            dataGridView1.Columns[5].HeaderText = "Nombre del proceso";
            dataGridView1.Columns[6].HeaderText = "Tipo del proceso";
            dataGridView1.Columns[7].HeaderText = "Autor";
            dataGridView1.Columns[8].HeaderText = "Correo";
            dataGridView1.Columns[9].HeaderText = "Nombre del flujo de referencia";
            dataGridView1.Columns[10].HeaderText = "Unidad";
            dataGridView1.Columns[11].HeaderText = "Valor referencia";
            dataGridView1.Columns[12].HeaderText = "Objetivo";
            dataGridView1.Columns[13].HeaderText = "Limites del sistema";
            dataGridView1.Columns[15].HeaderText = "Tipo de tecnología";
            dataGridView1.Columns[16].HeaderText = "Condiciones de operacíon";
            dataGridView1.Columns[17].HeaderText = "Fecha de referencia del estudio";
            dataGridView1.Columns[18].HeaderText = "Datos válidos hasta";
            dataGridView1.Columns[19].HeaderText = "Descripción";
            dataGridView1.Columns[20].HeaderText = "Nombre del estado";
            dataGridView1.Columns[21].HeaderText = "Nombre del área";
            dataGridView1.Columns[22].HeaderText = "Representatividad geografíca";


            dataGridView1.Columns[0].Visible = false;//ID no visible
            dataGridView1.Columns[1].Visible = true;//producto, tecnología, otro
            dataGridView1.Columns[1].ReadOnly = true;//producto, tecnología, otro
            dataGridView1.Columns[2].Visible = false;//Producto
            dataGridView1.Columns[3].Visible = false;//Tecnología
            dataGridView1.Columns[4].Visible = false;//otro
            dataGridView1.Columns[5].Visible = true;//Nombre proceso
            dataGridView1.Columns[5].ReadOnly = true;//Nombre proceso
            dataGridView1.Columns[6].Visible = true;//tipoProceso 
            dataGridView1.Columns[6].ReadOnly = true;//tipoProceso
            dataGridView1.Columns[7].Visible = true;//autor 
            dataGridView1.Columns[7].ReadOnly = true;//autor
            dataGridView1.Columns[8].Visible = true;//correo 
            dataGridView1.Columns[8].ReadOnly = true;//correo
            dataGridView1.Columns[9].Visible = true;//nombreFlujoR 
            dataGridView1.Columns[9].ReadOnly = true;//nombreFlujoR
            dataGridView1.Columns[10].Visible = true;//unidad 
            dataGridView1.Columns[10].ReadOnly = true;//unidad
            dataGridView1.Columns[11].Visible = true;//valorR 
            dataGridView1.Columns[11].ReadOnly = true;//valorR
            dataGridView1.Columns[12].Visible = true;//objetivo 
            dataGridView1.Columns[12].ReadOnly = true;//objetivo
            dataGridView1.Columns[13].Visible = true;//limitesSistema 
            dataGridView1.Columns[13].ReadOnly = true;//limitesSistema
            dataGridView1.Columns[14].Visible = false;//imagen
            dataGridView1.Columns[15].Visible = true;//tipoTecnologia 
            dataGridView1.Columns[15].ReadOnly = true;//tipoTecnologia
            dataGridView1.Columns[16].Visible = true;//condicionesOperacion 
            dataGridView1.Columns[16].ReadOnly = true;//condicionesOperacion 
            dataGridView1.Columns[17].Visible = true;//fechaReferencia 
            dataGridView1.Columns[17].ReadOnly = true;//fechaReferencia 
            dataGridView1.Columns[18].Visible = true;//datosValidos 
            dataGridView1.Columns[18].ReadOnly = true;//datosValidos 
            dataGridView1.Columns[19].Visible = true;//descripcion 
            dataGridView1.Columns[19].ReadOnly = true;//descripcion 
            dataGridView1.Columns[20].Visible = true;//valorEstado
            dataGridView1.Columns[20].ReadOnly = true;//valorEstado
            dataGridView1.Columns[21].Visible = true;//valorArea
            dataGridView1.Columns[21].ReadOnly = true;//valorArea
            dataGridView1.Columns[22].Visible = true;//representacionGeografica
            dataGridView1.Columns[22].ReadOnly = true;//representacionGeografica
            dataGridView1.Columns[23].Visible = false;//latitud
            dataGridView1.Columns[24].Visible = false;//longitud

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Ajusta el ancho de las columnas según el contenido de las celdas
            dataGridView1.AutoResizeColumns();

        }

        private void CargarBotones()
        {

            DataGridViewButtonColumn editar = new DataGridViewButtonColumn();
            editar.HeaderText = "Editar";
            editar.Name = "Editar";
            editar.Width = 90;
            editar.FlatStyle = FlatStyle.Flat;
            dataGridView1.Columns.Add(editar);

            DataGridViewButtonColumn verImagen = new DataGridViewButtonColumn();
            verImagen.HeaderText = "Ver imagen";
            verImagen.Name = "Ver imagen";
            verImagen.Width = 90;
            verImagen.FlatStyle = FlatStyle.Flat;
            dataGridView1.Columns.Add(verImagen);

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.HeaderText = "Eliminar";
            checkColumn.Name = "Eliminar";
            checkColumn.ReadOnly = false; // Permitir interacción del usuario
            dataGridView1.Columns.Add(checkColumn);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Index == 0)
                {
                    row.Cells["Eliminar"].ReadOnly = true;
                }
                else
                {
                    row.Cells["Eliminar"].ReadOnly = false;
                }
            }

        }
        private void ListaFormulario_Load(object sender, EventArgs e)
        {
            //Se genera 3 nuevas columas con botones.
            CargarBotones();
            tabControl2.SetBounds(tabControl2.Left, tabControl2.Top, 768, 519);
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

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {


            if (e.ColumnIndex == 25 && e.RowIndex != -1)  // Se verifica que sea la columna 10 y no sea el encabezado
            {
                Image someImage = Properties.Resources.lapiz;

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.lapiz.Width;
                var h = Properties.Resources.lapiz.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(someImage, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            if (e.ColumnIndex == 26 && e.RowIndex != -1)  // Se verifica que sea la columna 10 y no sea el encabezado
            {
                Image someImage = Properties.Resources.ojo;

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.ojo.Width;
                var h = Properties.Resources.ojo.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(someImage, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            /*

            if (e.ColumnIndex == 7 && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var checkboxSize = 14;
                var x = e.CellBounds.Left + (e.CellBounds.Width - checkboxSize) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - checkboxSize) / 2;

                bool isChecked = e.Value != null && (bool)e.Value;
                CheckBoxState state = isChecked ? CheckBoxState.CheckedNormal : CheckBoxState.UncheckedNormal;
                CheckBoxRenderer.DrawCheckBox(e.Graphics, new Point(x, y), state);

                e.Handled = true;

                // Cambiar el valor de la casilla de verificación cuando se hace clic en la celda
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Button == MouseButtons.Left)
                {
                    var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                    if (cell != null)
                    {
                        bool currentValue = (bool)cell.Value;
                        cell.Value = !currentValue;
                        dataGridView1.EndEdit(); // Finalizar la edición de la celda
                    }
                }
            }
            */
        }
        //pinta los numeros de cada registro
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brs = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brs, e.RowBounds.Location.X + 10, e.RowBounds.Y + 10);
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
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                row.Cells[27].Value = row.Cells[27].Value == null ? false : !(bool)row.Cells[27].Value;
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

        private void btnExportarCSV_Click(object sender, EventArgs e)
        {
            try
            {


                //declara el filedialog
                using (var fd = new SaveFileDialog())
                {
                    //en casi de dar aceptar
                    if (fd.ShowDialog() == DialogResult.OK)
                    {
                        //genera el csv y lo guarda en la direccion dada por el filedialog
                        controladorDatosFormulario.aCSV(dataGridView1, @"" + fd.FileName + ".csv");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Intentelo de nuevo o mas tarde");
            }
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    SaveFileDialog save = new SaveFileDialog();
                    save.Filter = "PDF (*.pdf)|*.pdf";
                    save.FileName = "Result.pdf";
                    bool ErrorMessage = false;
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(save.FileName))
                        {
                            try
                            {
                                File.Delete(save.FileName);
                            }
                            catch (Exception ex)
                            {
                                ErrorMessage = true;
                                MessageBox.Show("No se pueden escribir datos en el disco" + ex.Message);
                            }
                        }
                        if (!ErrorMessage)
                        {
                            try
                            {
                                PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);
                                pTable.DefaultCell.Padding = 2;
                                pTable.WidthPercentage = 200;
                                pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                                foreach (DataGridViewColumn col in dataGridView1.Columns)
                                {
                                    PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                    pTable.AddCell(pCell);
                                }

                                foreach (DataGridViewRow viewRow in dataGridView1.Rows)
                                {
                                    foreach (DataGridViewCell dcell in viewRow.Cells)
                                    {
                                        if (dcell.Value != null)
                                        {
                                            pTable.AddCell(dcell.Value.ToString());
                                        }
                                        else
                                        {
                                            pTable.AddCell(string.Empty);
                                        }
                                    }
                                }

                                using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

                                {

                                    Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                    PdfWriter.GetInstance(document, fileStream);
                                    document.Open();
                                    document.Add(pTable);
                                    document.Close();
                                    fileStream.Close();
                                }
                                MessageBox.Show("Exportación de datos con éxito", "info");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al exportar datos" + ex.Message);
                            }
                        }
                    }
                }
                else

                {
                    MessageBox.Show("ningún record fue encontrado", "Info");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Intentelo de nuevo o mas tarde");
            }
        }
    }
}
