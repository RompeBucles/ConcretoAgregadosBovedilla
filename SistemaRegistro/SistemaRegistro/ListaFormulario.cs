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
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SistemaRegistro
{
    public partial class ListaFormulario : Form
    {

        //Instacia del modelo ingreso datos
        modeloIngresoDatos modeloIngresoDatos = new modeloIngresoDatos();
        //instancia del modelo {get; set;} 
        modeloBitacora bitacora = new modeloBitacora();
        //Instacia del controlador
        ControladorBitacora controladorBitacora = new ControladorBitacora();
        //instacia controlador formualario
        ControladorDatosFormulario controladorDatosFormulario = new ControladorDatosFormulario();
        //Ver imagen variable
        string repositorioDos;
        String f1, f2;
        DataTable dsTabla;
        //se declaro el id del ingresoDatos para guardar y posteriormente usarlo en procedimiento almacenado de modificar
        private int id;
        //Variables que se usan para el mapa
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

        public ListaFormulario(string usuario)
        {
            InitializeComponent();
            TabControlBotones();
            CargarDG();
            textNusuario.Text = usuario;
            //Estado y Area
            llenarCombos();
            //asignamos una hora por defecto a los datetimepickers
            //FechaReferencia.Value = new DateTime(1900, 01, 01);
            //FechaDatosValidos.Value = new DateTime(1900, 01, 01);
            /*

            //Asigna opciones a la lista comboUnidadUno
            List<string> ListaUnidadUno = new List<string>();
            ListaUnidadUno.Add("Unidad*");
            ListaUnidadUno.Add("Área (m²)");
            ListaUnidadUno.Add("Área (ha)");
            ListaUnidadUno.Add("Área*Tiempo (m²*año)");
            ListaUnidadUno.Add("Capacidad de peso (kg*s)");
            ListaUnidadUno.Add("Capacidad de volumen (l*hora)");
            ListaUnidadUno.Add("Capacidad de conversión de energía (MW)");
            ListaUnidadUno.Add("Densidad (kg*l)");
            ListaUnidadUno.Add("Masa (kg)");
            ListaUnidadUno.Add("Capacidad de peso (kg*s)");
            ListaUnidadUno.Add("Longitud (m)");
            ListaUnidadUno.Add("Servicio de transporte (ton*km)");
            ListaUnidadUno.Add("Servicio de transporte (persona*km)");
            ListaUnidadUno.Add("Metro*año (m*año)");
            ListaUnidadUno.Add("Unidad (item)");
            ListaUnidadUno.Add("Energía (MJ)");
            ListaUnidadUno.Add("Tiempo de uso del equipo (hora)");
            ListaUnidadUno.Add("Productos líquidos (l)");
            ListaUnidadUno.Add("Energia (KWh)");
            ListaUnidadUno.Add("Energía (kJ)");
            comboUnidadUno.DataSource = ListaUnidadUno;

            //Asigna opciones a la lista ListaLimiteSistema
            List<string> ListaLimiteSistema = new List<string>();
            ListaLimiteSistema.Add("Limites del sistema");
            ListaLimiteSistema.Add("Limitaciones presupuestarias");
            ListaLimiteSistema.Add("Limitaciones de tiempo");
            ListaLimiteSistema.Add("Limitaciones de recursos naturales");
            ListaLimiteSistema.Add("Limitaciones de espacio");
            ListaLimiteSistema.Add("Limitaciones ambientales");
            ListaLimiteSistema.Add("Limitaciones de capacidad");
            ListaLimiteSistema.Add("Limitaciones geotécnicas");
            ListaLimiteSistema.Add("Limitaciones tecnológicas");
            ListaLimiteSistema.Add("Limitaciones normativas y legales");
            ListaLimiteSistema.Add("Limitaciones de seguridad");
            comboLimitesSistema.DataSource = ListaLimiteSistema;

            //Asigna opciones a la lista ListaLimiteSistema
            List<string> ListaTipoTecnologia = new List<string>();
            ListaTipoTecnologia.Add("Tipo de tecnología*");
            ListaTipoTecnologia.Add("Innovación (Laboratorio, prototipo, piloto, demostración)");
            ListaTipoTecnologia.Add("Moderna");
            ListaTipoTecnologia.Add("Actual (más encontrada en operación)");
            ListaTipoTecnologia.Add("Antigua");
            ListaTipoTecnologia.Add("Mix.Tecnologías");
            ComboTipoTecnologia.DataSource = ListaTipoTecnologia;
            */

        }
        //Comente estas lineas de codigo, al parecer impedian que se llenara el comboEstado y Area
        private void TabControlBotones()
        {
            //lo que hace esta linea de codigo es desabilitar todos los componentes que se encuentren en esa pestaña
            tabControl2.TabPages["ListaDatos"].Enabled = true;
            tabControl2.TabPages["Identificación"].Enabled = false;
            tabControl2.TabPages["Referencia"].Enabled = false;
            tabControl2.TabPages["Tecnología"].Enabled = false;
            tabControl2.TabPages["TiempoVálido"].Enabled = false;
            tabControl2.TabPages["Geografía"].Enabled = false;
            //tabControl2.TabPages["VerImagen"].Enabled = false;
            VerImagen.Parent = null;
            /*
            Identificación.Parent = null;
            Referencia.Parent = null;
            Tecnología.Parent = null;
            TiempoVálido.Parent = null;
            Geografía.Parent = null;
            VerImagen.Parent = null;
            */
        }
        private void CargarDG()
        {
            dataGridView1.Columns.Clear();
            dsTabla = controladorDatosFormulario.SeleccionarDatosFormulario(); //La tabla se recarga con el procedimiento almacenado Seleccionar_Datos_User.
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
            dataGridView1.Columns[16].HeaderText = "URL repositorio";
            dataGridView1.Columns[17].HeaderText = "Tipo de tecnología";
            dataGridView1.Columns[18].HeaderText = "Condiciones de operacíon";
            dataGridView1.Columns[19].HeaderText = "Fecha de referencia del estudio";
            dataGridView1.Columns[20].HeaderText = "Datos válidos hasta";
            dataGridView1.Columns[21].HeaderText = "Descripción";
            dataGridView1.Columns[22].HeaderText = "Nombre del estado";
            dataGridView1.Columns[23].HeaderText = "Nombre del área";
            dataGridView1.Columns[24].HeaderText = "Representatividad geografíca";
            dataGridView1.Columns[25].HeaderText = "Observaciones";


            dataGridView1.Columns[0].Visible = false;//ID 
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
            dataGridView1.Columns[15].Visible = false;//imagenDos
            dataGridView1.Columns[16].Visible = true;//URL repositorio
            dataGridView1.Columns[16].ReadOnly = true;//URL repositorio
            dataGridView1.Columns[16].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;//URL repositorio                                       //
            dataGridView1.Columns[17].Visible = true;//tipoTecnologia 
            dataGridView1.Columns[17].ReadOnly = true;//tipoTecnologia
            dataGridView1.Columns[18].Visible = true;//condicionesOperacion 
            dataGridView1.Columns[18].ReadOnly = true;//condicionesOperacion 
            dataGridView1.Columns[19].Visible = true;//fechaReferencia 
            dataGridView1.Columns[19].ReadOnly = true;//fechaReferencia 
            dataGridView1.Columns[20].Visible = true;//datosValidos 
            dataGridView1.Columns[20].ReadOnly = true;//datosValidos 
            dataGridView1.Columns[21].Visible = true;//descripcion 
            dataGridView1.Columns[21].ReadOnly = true;//descripcion 
            dataGridView1.Columns[22].Visible = true;//valorEstado
            dataGridView1.Columns[22].ReadOnly = true;//valorEstado
            dataGridView1.Columns[23].Visible = true;//valorArea
            dataGridView1.Columns[23].ReadOnly = true;//valorArea
            dataGridView1.Columns[24].Visible = true;//representacionGeografica
            dataGridView1.Columns[24].ReadOnly = true;//representacionGeografica
            dataGridView1.Columns[25].Visible = false;//latitud
            dataGridView1.Columns[26].Visible = false;//longitud
            dataGridView1.Columns[27].Visible = true;//observaciones
            dataGridView1.Columns[27].ReadOnly = true;//observaciones

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Ajusta el ancho de las columnas según el contenido de las celdas
            dataGridView1.AutoResizeColumns();

        }

        private void CargarBotones()
        {
            DataGridViewCheckBoxColumn checkColumnE = new DataGridViewCheckBoxColumn();
            checkColumnE.HeaderText = "Seleccionar";
            checkColumnE.Name = "Seleccionar";
            checkColumnE.ReadOnly = false; // Permitir interacción del usuario
            dataGridView1.Columns.Add(checkColumnE);

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

        }
        private void ListaFormulario_Load(object sender, EventArgs e)
        {
            CargarBotones();
            //CargarDG();
            tabControl2.SetBounds(tabControl2.Left, tabControl2.Top, 768, 519);

            try
            {
                // dt = new DataTable();
                // dt.Columns.Add(new DataColumn("Descripción", typeof(string)));
                // dt.Columns.Add(new DataColumn("Lat", typeof(double)));
                // dt.Columns.Add(new DataColumn("Long", typeof(double)));

                //insertando datos al dt para mostrar en la lista
                //dt.Rows.Add("Ubicación", LatInicial, LngInicial);
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
            catch (Exception ex)
            {
                MessageBox.Show("Inténtelo de nuevo o mas tarde");
            }

        }
        private void ComboProducto_Enter(object sender, EventArgs e)
        {
            if (ComboProducto.Text == "Producto*")
            {
                ComboProducto.Text = "";
                ComboProducto.ForeColor = Color.Black;
            }
        }

        private void ComboProducto_Leave(object sender, EventArgs e)
        {
            if (ComboProducto.Text == "")
            {
                ComboProducto.Text = "Producto*";
                errorProvider1.SetError(ComboProducto, "Se necesita ingresar un producto");
                ComboProducto.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(ComboProducto, String.Empty);
            }
        }

        private void ComboTecno_Enter(object sender, EventArgs e)
        {
            if (ComboTecno.Text == "Tecnología*")
            {
                ComboTecno.Text = "";
                ComboTecno.ForeColor = Color.Black;
            }
        }

        private void ComboTecno_Leave(object sender, EventArgs e)
        {
            if (ComboTecno.Text == "")
            {
                ComboTecno.Text = "Tecnología*";
                errorProvider1.SetError(ComboTecno, "Se necesita ingresar una tecnología");
                ComboTecno.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(ComboTecno, String.Empty);
            }
        }

        private void textOtro_Enter(object sender, EventArgs e)
        {
            if (textOtro.Texts == "Ejemplo: grava y arena")
            {
                textOtro.Texts = "";
                textOtro.ForeColor = Color.Black;
            }
        }

        private void textOtro_Leave(object sender, EventArgs e)
        {
            if (textOtro.Texts == "")
            {
                textOtro.Texts = "Ejemplo: grava y arena";
                errorProvider1.SetError(textOtro, "Se necesita ingresar un dato a este campo");
                textOtro.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(textOtro, String.Empty);
            }
        }
        private void textProceso_Enter(object sender, EventArgs e)
        {
            if (textProceso.Texts == "Ejemplo: Elaboración de concreto simple")
            {
                textProceso.Texts = "";
                textProceso.ForeColor = Color.Black;
            }
        }

        private void textProceso_Leave(object sender, EventArgs e)
        {
            if (textProceso.Texts == "")
            {
                textProceso.Texts = "Ejemplo: Elaboración de concreto simple";
                errorProvider1.SetError(textProceso, "Se necesita ingresar un nombre del proceso");
                textProceso.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(textProceso, String.Empty);
            }
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

        private void textAutor_Enter(object sender, EventArgs e)
        {
            if (textAutor.Texts == "Ejemplo: Centro Mario Molina")
            {
                textAutor.Texts = "";
                textAutor.ForeColor = Color.Black;
            }
        }

        private void textAutor_Leave(object sender, EventArgs e)
        {
            if (textAutor.Texts == "")
            {
                textAutor.Texts = "Ejemplo: Centro Mario Molina";
                errorProvider1.SetError(textAutor, "Se necesita ingresar un autor");
                textAutor.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(textAutor, String.Empty);
            }
        }
        private void textCorreo_Enter(object sender, EventArgs e)
        {
            if (textCorreo.Texts == "Ejemplo: ejemplo@unam.gob.mx")
            {
                textCorreo.Texts = "";
                textCorreo.ForeColor = Color.Black;
            }
        }

        private void textCorreo_Leave(object sender, EventArgs e)
        {
            if (textCorreo.Texts == "")
            {
                textCorreo.Texts = "Ejemplo: ejemplo@unam.gob.mx";
                errorProvider1.SetError(textCorreo, "Se necesita ingresar un correo");
                textCorreo.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(textCorreo, String.Empty);
            }
        }

        private void textUnidadFuncional_Enter(object sender, EventArgs e)
        {
            if (textUnidadFuncional.Texts == "Ejemplo: Producción de un kilogramo de arena y un kilogramo de grava")
            {
                textUnidadFuncional.Texts = "";
                textUnidadFuncional.ForeColor = Color.Black;
            }
        }

        private void textUnidadFuncional_Leave(object sender, EventArgs e)
        {
            if (textUnidadFuncional.Texts == "")
            {
                textUnidadFuncional.Texts = "Ejemplo: Producción de un kilogramo de arena y un kilogramo de grava";
                errorProvider1.SetError(textUnidadFuncional, "Se necesita ingresar un nombre del flujo");
                textUnidadFuncional.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(textUnidadFuncional, String.Empty);
            }
        }

        private void comboUnidadUno_Enter(object sender, EventArgs e)
        {
            if (comboUnidadUno.Text == "Unidad*")
            {
                comboUnidadUno.Text = "";
                comboUnidadUno.ForeColor = Color.Black;
            }
        }

        private void comboUnidadUno_Leave(object sender, EventArgs e)
        {
            if (comboUnidadUno.Text == "")
            {
                comboUnidadUno.Text = "Unidad*";
                errorProvider1.SetError(comboUnidadUno, "Se necesita ingresar una unidad de medida");
                comboUnidadUno.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(comboUnidadUno, String.Empty);
            }
        }
        private void textValor_Enter(object sender, EventArgs e)
        {
            if (textValor.Texts == "Ejemplo: 0")
            {
                textValor.Texts = "";
                textValor.ForeColor = Color.Black;
            }
        }

        private void textValor_Leave(object sender, EventArgs e)
        {
            if (textValor.Texts == "")
            {
                textValor.Texts = "Ejemplo: 0";
                errorProvider1.SetError(textValor, "Se necesita ingresar un valor");
                textValor.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(textValor, String.Empty);
            }
        }

        private void textObjetivoR_Enter(object sender, EventArgs e)
        {
            if (textObjetivoR.Texts == "Ejemplo: Estimar la huella de carbono")
            {
                textObjetivoR.Texts = "";
                textObjetivoR.ForeColor = Color.Black;
            }
        }

        private void textObjetivoR_Leave(object sender, EventArgs e)
        {
            if (textObjetivoR.Texts == "")
            {
                textObjetivoR.Texts = "Ejemplo: Estimar la huella de carbono";
                textObjetivoR.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(textObjetivoR, String.Empty);
            }
        }

        private void comboLimitesSistema_Enter(object sender, EventArgs e)
        {
            if (comboLimitesSistema.Text == "Limites del sistema")
            {
                comboLimitesSistema.Text = "";
                comboLimitesSistema.ForeColor = Color.Black;
            }
        }

        private void comboLimitesSistema_Leave(object sender, EventArgs e)
        {
            if (comboLimitesSistema.Text == "")
            {
                comboLimitesSistema.Text = "Limites del sistema";
                comboLimitesSistema.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(comboLimitesSistema, String.Empty);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
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

                    // Cargar la imagen original
                    Image originalImage = Image.FromFile(imagePath);

                    // Definir el tamaño deseado para el PictureBox
                    int pictureBoxWidth = pictureBoxUno.Width;
                    int pictureBoxHeight = pictureBoxUno.Height;

                    // Crear una versión en miniatura de la imagen con el tamaño deseado
                    Image resizedImage = originalImage.GetThumbnailImage(pictureBoxWidth, pictureBoxHeight, null, IntPtr.Zero);

                    // Asignar la imagen ajustada al control PictureBox
                    pictureBoxUno.Image = resizedImage;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Inténtelo de nuevo o mas tarde");
            }
        }
        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            pictureBoxUno.Image = null;
        }
        private void radioBtnImagenUno_CheckedChanged(object sender, EventArgs e)
        {
            //si el radio button de imagen es desseleccionado
            if (!radioBtnImagenUno.Checked)
            {
                //el panel de otra imagen deja de ser visible
                panelOtraImaUno.Visible = false;
                pictureBoxDos.Image = null;
            }
            else
            {
                //de lo contrario el panel otra imagen es visible y el repositorio desaparece
                panelOtraImaUno.Visible = true;
                panelRepoUno.Visible = false;
            }

        }
        //acciones al cambiar la seleccion del boton repositorio
        private void radioBtnRepoUno_CheckedChanged(object sender, EventArgs e)
        {
            //si el radio button de repositorio es desselccionado
            if (!radioBtnRepoUno.Checked)
            {
                //el panel de repositorio deja de ser visible
                panelRepoUno.Visible = false;
                textRepositorio.Texts = "Ejemplo: https://drive.google.com/file/imagen/view";
                textRepositorio.ForeColor = Color.Gray;
            }
            else
            {
                //de lo contrario el panel repositorio es visible y otra imagen deja de ser visible
                panelRepoUno.Visible = true;
                panelOtraImaUno.Visible = false;
            }
        }
        //Estos dos eventos radioBtnImagenDos_CheckedChanged y radioBtnRepoDos_CheckedChanged Los estoy usuando para el boton "Ver Imagen"
        private void radioBtnImagenDos_CheckedChanged(object sender, EventArgs e)
        {
            //si el radio button de imagen es desseleccionado
            if (!radioBtnImagenDos.Checked)
            {
                //el panel de otra imagen deja de ser visible
                panelOtraImaDos.Visible = false;
                pictureBoxCuatro.Image = null;
            }
            else
            {
                //de lo contrario el panel otra imagen es visible y el repositorio desaparece
                panelOtraImaDos.Visible = true;
                panelRepoDos.Visible = false;
            }

        }
        //acciones al cambiar la seleccion del boton repositorio
        private void radioBtnRepoDos_CheckedChanged(object sender, EventArgs e)
        {
            //si el radio button de repositorio es desselccionado
            if (!radioBtnRepoDos.Checked)
            {
                //el panel de repositorio deja de ser visible
                panelRepoDos.Visible = false;
                textRepositorioDos.Texts = "Ejemplo: https://drive.google.com/file/imagen/view";
                textRepositorioDos.ForeColor = Color.Gray;
            }
            else
            {
                //de lo contrario el panel repositorio es visible y otra imagen deja de ser visible
                panelRepoDos.Visible = true;
                panelOtraImaDos.Visible = false;
            }
        }
        private void pictureBoxDos_Click(object sender, EventArgs e)
        {
            try
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

                    // Cargar la imagen original
                    Image originalImage = Image.FromFile(imagePath);

                    // Definir el tamaño deseado para el PictureBox
                    int pictureBoxWidth = pictureBoxDos.Width;
                    int pictureBoxHeight = pictureBoxDos.Height;

                    // Crear una versión en miniatura de la imagen con el tamaño deseado
                    Image resizedImage = originalImage.GetThumbnailImage(pictureBoxWidth, pictureBoxHeight, null, IntPtr.Zero);

                    // Asignar la imagen ajustada al control PictureBox
                    pictureBoxDos.Image = resizedImage;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Inténtelo de nuevo o mas tarde");
            }
        }
        private void btnEliminarImagenDos_Click(object sender, EventArgs e)
        {
            pictureBoxDos.Image = null;
        }

        private void textRepositorio_Enter(object sender, EventArgs e)
        {
            if (textRepositorio.Texts == "Ejemplo: https://drive.google.com/file/imagen/view")
            {
                textRepositorio.Texts = "";
                textRepositorio.ForeColor = Color.Black;
            }
        }

        private void textRepositorio_Leave(object sender, EventArgs e)
        {
            if (textRepositorio.Texts == "")
            {
                textRepositorio.Texts = "Ejemplo: https://drive.google.com/file/imagen/view";
                textRepositorio.ForeColor = Color.Gray;
            }
        }

        private void ComboTipoTecnologia_Enter(object sender, EventArgs e)
        {
            if (ComboTipoTecnologia.Text == "Tipo de tecnología*")
            {
                ComboTipoTecnologia.Text = "";
                ComboTipoTecnologia.ForeColor = Color.Black;
            }
        }

        private void ComboTipoTecnologia_Leave(object sender, EventArgs e)
        {
            if (ComboTipoTecnologia.Text == "")
            {
                ComboTipoTecnologia.Text = "Tipo de tecnología*";
                errorProvider1.SetError(ComboTipoTecnologia, "Se necesita ingresar un tipo de tecnología");
                ComboTipoTecnologia.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(ComboTipoTecnologia, String.Empty);
            }
        }

        private void textCondicionesOpe_Enter(object sender, EventArgs e)
        {
            if (textCondicionesOpe.Texts == "Ejemplo: En este estudio se considera una revolvedora")
            {
                textCondicionesOpe.Texts = "";
                textCondicionesOpe.ForeColor = Color.Black;
            }
        }

        private void textCondicionesOpe_Leave(object sender, EventArgs e)
        {
            if (textCondicionesOpe.Texts == "")
            {
                textCondicionesOpe.Texts = "Ejemplo: En este estudio se considera una revolvedora";
                textCondicionesOpe.ForeColor = Color.Gray;
            }
        }
        private void FechaReferencia_Enter(object sender, EventArgs e)
        {
            if (FechaReferencia.Text == "2000-01-01")
            {
                FechaReferencia.ForeColor = Color.Black;
            }
        }

        private void FechaReferencia_Leave(object sender, EventArgs e)
        {
            if (FechaReferencia.Text == "2000-01-01")
            {
                errorProvider1.SetError(FechaReferencia, "Debe ingresar una fecha de referencia válida");
                FechaReferencia.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(FechaReferencia, String.Empty);
            }
        }
        private void FechaDatosValidos_Enter(object sender, EventArgs e)
        {
            if (FechaDatosValidos.Text == "2000-01-01")
            {
                FechaDatosValidos.ForeColor = Color.Black;
            }
        }

        private void FechaDatosValidos_Leave(object sender, EventArgs e)
        {
            if (FechaDatosValidos.Text == "2000-01-01")
            {
                errorProvider1.SetError(FechaDatosValidos, "Se ingresar una fecha de datos válida");
                FechaDatosValidos.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(FechaDatosValidos, String.Empty);
            }
        }
        private void textDescripcionPeriodo_Enter(object sender, EventArgs e)
        {
            if (textDescripcionPeriodo.Texts == "Ejemplo: Se solicita este tiempo para el análisis del estudio")
            {
                textDescripcionPeriodo.Texts = "";
                textDescripcionPeriodo.ForeColor = Color.Black;
            }
        }
        private void textDescripcionPeriodo_Leave(object sender, EventArgs e)
        {
            if (textDescripcionPeriodo.Texts == "")
            {
                textDescripcionPeriodo.Texts = "Ejemplo: Se solicita este tiempo para el análisis del estudio";
                textDescripcionPeriodo.ForeColor = Color.Gray;
            }
        }
        /*
        private void textDescripcionPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            usuarios.textBoxEvent.textKeyPress(e);
        }
        */
        private void comboEstado_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                /*
                modeloEstado ef = comboEstado.SelectedItem as modeloEstado;

                if (ef != null)
                {
                    comboArea.DataSource = new controladorArea().obtenerListaArea(ef.id);
                    comboArea.ValueMember = "valor";

                }
                else
                {

                }
                */
                modeloEstado ef = (modeloEstado)comboEstado.SelectedItem;
                comboArea.DataSource = new controladorArea().obtenerListaArea(ef.id);
                comboArea.ValueMember = "valor";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Intentalo mas tarde");
            }

        }
        private void comboEstado_Enter(object sender, EventArgs e)
        {
            if (comboEstado.Text == "Estado*")
            {
                comboEstado.Text = "";
                comboEstado.ForeColor = Color.Black;
            }
        }

        private void comboEstado_Leave(object sender, EventArgs e)
        {
            if (comboEstado.Text == "")
            {
                comboEstado.Text = "Estado*";
                errorProvider1.SetError(comboEstado, "Selecciona un estado");
                comboEstado.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(comboLimitesSistema, String.Empty);
            }
        }

        private void comboArea_Enter(object sender, EventArgs e)
        {
            if (comboArea.Text == "Area*")
            {
                comboArea.Text = "";
                comboArea.ForeColor = Color.Black;
            }
        }

        private void comboArea_Leave(object sender, EventArgs e)
        {
            if (comboArea.Text == "")
            {
                comboArea.Text = "Area*";
                errorProvider1.SetError(comboArea, "Selecciona un area");
                comboArea.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(comboArea, String.Empty);
            }
        }
        private void textObservaciones_Enter(object sender, EventArgs e)
        {
            if (textObservaciones.Texts == "Ejemplo: Información puede ser usada en varios estados.")
            {
                textObservaciones.Texts = "";
                textObservaciones.ForeColor = Color.Black;
            }
        }

        private void textObservaciones_Leave(object sender, EventArgs e)
        {
            if (textObservaciones.Texts == "")
            {
                textObservaciones.Texts = "Ejemplo: Información puede ser usada en varios estados.";
                textObservaciones.ForeColor = Color.Gray;
            }
        }

        /*
        private void FechaReferencia_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                FechaReferencia.CustomFormat = " ";
            }
        }
        */
        private void llenarCombos()
        {

            //asigna la lista de estados a el combobox 3
            comboEstado.DataSource = new controladorEstado().obtenerListaEstado();
            comboEstado.ValueMember = "valor";

        }

        private void Limpiar()
        {
            ComboProducto.Text = "Producto*";
            ComboProducto.ForeColor = Color.Gray;
            ComboTecno.Text = "Tecnología*";
            ComboTecno.ForeColor = Color.Gray;
            textOtro.Texts = "Ejemplo: grava y arena";
            textOtro.ForeColor = Color.Gray;
            textProceso.Texts = "Ejemplo: Elaboración de concreto simple";
            textProceso.ForeColor = Color.Gray;
            comboUno.SelectedIndex = -1;
            comboDos.SelectedIndex = -1;
            comboTres.SelectedIndex = -1;
            comboCuatro.SelectedIndex = -1;
            comboCinco.SelectedIndex = -1;
            comboSeis.SelectedIndex = -1;
            comboSiete.SelectedIndex = -1;
            comboUno.Enabled = true;
            comboDos.Enabled = true;
            comboTres.Enabled = true;
            comboCuatro.Enabled = true;
            comboCinco.Enabled = true;
            comboSeis.Enabled = true;
            comboSiete.Enabled = true;
            textAutor.Texts = "Ejemplo: Centro Mario Molina";
            textAutor.ForeColor = Color.Gray;
            textCorreo.Texts = "Ejemplo: ejemplo@unam.gob.mx";
            textCorreo.ForeColor = Color.Gray;
            textUnidadFuncional.Texts = "Ejemplo: Producción de un kilogramo de arena y un kilogramo de grava";
            textUnidadFuncional.ForeColor = Color.Gray;
            comboUnidadUno.Text = "Unidad*";
            comboUnidadUno.ForeColor = Color.Gray;
            textValor.Texts = "Ejemplo: 0";
            textValor.ForeColor = Color.Gray;
            textObjetivoR.Texts = "Ejemplo: Estimar la huella de carbono";
            textObjetivoR.ForeColor = Color.Gray;
            comboLimitesSistema.Text = "Limites del sistema";
            comboLimitesSistema.SelectedIndex = -1;
            comboLimitesSistema.ForeColor = Color.Gray;
            pictureBoxUno.Image = null;
            pictureBoxDos.Image = null;
            textRepositorio.Texts = "Ejemplo: https://drive.google.com/file/imagen/view";
            textRepositorio.ForeColor = Color.Gray;
            ComboTipoTecnologia.Text = "Tipo de tecnología*";
            ComboTipoTecnologia.ForeColor = Color.Gray;
            textCondicionesOpe.Texts = "Ejemplo: En este estudio se considera una revolvedora";
            textCondicionesOpe.ForeColor = Color.Gray;
            FechaReferencia.Value = new DateTime(2000, 01, 01);
            FechaReferencia.Value = new DateTime(2000, 01, 01);
            textDescripcionPeriodo.Texts = "Ejemplo: Se solicita este tiempo para el análisis del estudio";
            textDescripcionPeriodo.ForeColor = Color.Gray;
            comboEstado.Text = "Estado*";
            comboEstado.ForeColor = Color.Gray;
            comboArea.Text = "Area*";
            comboArea.ForeColor = Color.Gray;
            txtlatitud.Texts = "Latitud";
            txtlongitud.Texts = "Longitud";
            textObservaciones.Texts = "Ejemplo: Información puede ser usada en varios estados.";
            textObservaciones.ForeColor = Color.Gray;
            errorProvider1.Clear();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar") //Si la celda contiene el nombre Editar procedera a entrar en la condición.
                {
                    if (dataGridView1.SelectedRows.Count > 0) //Si hay mas de 0 filas entonces procedera a ejecutar el siguiente codigo.
                    {


                        //Manda a llamar todos los datos del registro para editar
                        id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                        ComboProducto.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        ComboTecno.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                        textOtro.Texts = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                        textProceso.Texts = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                        comboUno.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                        comboDos.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                        comboTres.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                        comboCuatro.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                        comboCinco.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                        comboSeis.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                        comboSiete.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                        textAutor.Texts = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                        textCorreo.Texts = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                        textUnidadFuncional.Texts = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                        comboUnidadUno.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                        textValor.Texts = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                        textObjetivoR.Texts = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                        comboLimitesSistema.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();

                        int imageColumnIndex = 14;
                        if (dataGridView1.CurrentRow.Cells.Count > imageColumnIndex)
                        {
                            byte[] imageData = dataGridView1.CurrentRow.Cells[imageColumnIndex].Value as byte[];

                            if (imageData != null && imageData.Length > 0)
                            {
                                // Convertir los datos de imagen en una instancia de Image
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    pictureBoxUno.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                pictureBoxUno.Image = null; // No hay datos de imagen
                            }
                        }
                        else
                        {
                            pictureBoxUno.Image = null; // No hay datos de imagen
                        }

                        int imageColumnIndexDos = 15;
                        if (dataGridView1.CurrentRow.Cells.Count > imageColumnIndexDos)
                        {
                            byte[] imageDataDos = dataGridView1.CurrentRow.Cells[imageColumnIndexDos].Value as byte[];

                            if (imageDataDos != null && imageDataDos.Length > 0)
                            {
                                radioBtnImagenUno.Checked = true;
                                // Convertir los datos de imagen en una instancia de Image
                                using (MemoryStream ms = new MemoryStream(imageDataDos))
                                {
                                    pictureBoxDos.Image = Image.FromStream(ms);

                                }

                            }
                            else
                            {
                                pictureBoxDos.Image = null; // No hay datos de imagen
                            }
                        }
                        else
                        {
                            pictureBoxUno.Image = null; // No hay datos de imagen
                        }

                        textRepositorio.Texts = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                        string repositorio = dataGridView1.CurrentRow.Cells[16].Value.ToString();

                        if (!string.IsNullOrEmpty(repositorio))
                        {
                            radioBtnRepoUno.Checked = true;
                        }
                        else
                        {
                            radioBtnRepoUno.Checked = false;
                        }

                        ComboTipoTecnologia.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
                        textCondicionesOpe.Texts = dataGridView1.CurrentRow.Cells[18].Value.ToString();

                        string fechaReferenciaValue = dataGridView1.CurrentRow.Cells[19].Value != null ? dataGridView1.CurrentRow.Cells[19].Value.ToString() : null;
                        string fechaDatosValidosValue = dataGridView1.CurrentRow.Cells[20].Value != null ? dataGridView1.CurrentRow.Cells[20].Value.ToString() : null;

                        //Asignar los valores a los DateTimePicker o reiniciarlos si son nulos
                        FechaReferencia.Value = !string.IsNullOrEmpty(fechaReferenciaValue) ? DateTime.Parse(fechaReferenciaValue) : new DateTime(2000, 01, 01);
                        FechaDatosValidos.Value = !string.IsNullOrEmpty(fechaDatosValidosValue) ? DateTime.Parse(fechaDatosValidosValue) : new DateTime(2000, 01, 01);
                        textDescripcionPeriodo.Texts = dataGridView1.CurrentRow.Cells[21].Value.ToString();

                        comboEstado.Text = dataGridView1.CurrentRow.Cells[22].Value.ToString();
                        comboArea.Text = dataGridView1.CurrentRow.Cells[23].Value.ToString();

                        txtlatitud.Texts = dataGridView1.CurrentRow.Cells[25].Value.ToString();
                        txtlongitud.Texts = dataGridView1.CurrentRow.Cells[26].Value.ToString();
                        textObservaciones.Texts = dataGridView1.CurrentRow.Cells[27].Value.ToString();

                        //tabControl2.TabPages["ListaDatos"].Enabled = false;
                        ListaDatos.Parent = null;
                        tabControl2.TabPages["Identificación"].Enabled = true;
                        tabControl2.TabPages["Referencia"].Enabled = true;
                        tabControl2.TabPages["Tecnología"].Enabled = true;
                        tabControl2.TabPages["TiempoVálido"].Enabled = true;
                        tabControl2.TabPages["Geografía"].Enabled = true;
                        // tabControl2.TabPages["VerImagen"].Enabled = false;
                        VerImagen.Parent = null;

                        tabControl2.SelectedTab = Identificación;

                    }
                }

                if (dataGridView1.Columns[e.ColumnIndex].Name == "Ver imagen")
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        //tabControl2.TabPages["VerImagen"].Enabled = true;
                        tabControl2.TabPages["ListaDatos"].Enabled = false;
                        VerImagen.Parent = tabControl2;
                        tabControl2.SelectedTab = VerImagen;

                        id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        int imageColumnIndexTres = 14;
                        if (dataGridView1.CurrentRow.Cells.Count > imageColumnIndexTres)
                        {
                            byte[] imageDataTres = dataGridView1.CurrentRow.Cells[imageColumnIndexTres].Value as byte[];

                            if (imageDataTres != null && imageDataTres.Length > 0)
                            {
                                // Convertir los datos de imagen en una instancia de Image
                                using (MemoryStream ms = new MemoryStream(imageDataTres))
                                {
                                    pictureBoxTres.Image = Image.FromStream(ms);
                                }

                            }
                            else
                            {
                                pictureBoxTres.Image = null; // No hay datos de imagen
                            }
                        }
                        else
                        {
                            pictureBoxTres.Image = null; // No hay datos de imagen
                        }

                        int imageColumnIndexCuatro = 15;
                        if (dataGridView1.CurrentRow.Cells.Count > imageColumnIndexCuatro)
                        {
                            byte[] imageDataCuatro = dataGridView1.CurrentRow.Cells[imageColumnIndexCuatro].Value as byte[];

                            if (imageDataCuatro != null && imageDataCuatro.Length > 0)
                            {
                                radioBtnImagenDos.Checked = true;
                                // Convertir los datos de imagen en una instancia de Image
                                using (MemoryStream ms = new MemoryStream(imageDataCuatro))
                                {
                                    pictureBoxCuatro.Image = Image.FromStream(ms);

                                }
                            }
                            else
                            {
                                pictureBoxCuatro.Image = null; // No hay datos de imagen
                            }
                        }
                        else
                        {
                            pictureBoxCuatro.Image = null; // No hay datos de imagen
                        }

                        textRepositorioDos.Texts = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                        repositorioDos = dataGridView1.CurrentRow.Cells[16].Value.ToString();

                        if (!string.IsNullOrEmpty(repositorioDos))
                        {
                            radioBtnRepoDos.Checked = true;
                        }
                        else
                        {
                            radioBtnRepoDos.Checked = false;
                        }

                        /*
                        // Obtener los datos de ese registro
                        id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                        // Verificar si la celda de la imagen contiene un valor nulo
                        if (!Convert.IsDBNull(dataGridView1.CurrentRow.Cells[14].Value))
                        {
                            byte[] imageData = (byte[])dataGridView1.CurrentRow.Cells[14].Value;
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pictureBoxTres.Image = Image.FromStream(ms);
                            }

                            //tabControl2.TabPages["VerImagen"].Enabled = true;
                            tabControl2.TabPages["ListaDatos"].Enabled = false;
                            VerImagen.Parent = tabControl2;
                            tabControl2.SelectedTab = VerImagen;
                        }
                        else
                        {
                            // Mostrar un MessageBox indicando que no hay imagen disponible
                            MessageBox.Show("Este registro no contiene una imagen");
                        }

                        */
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Columna{ex}");
            }
        }
        private void buttonCopiar_Click(object sender, EventArgs e)
        {
            try
            {
                // Copiar el texto al portapapeles
                Clipboard.SetText(repositorioDos);

                // Opcional: Mostrar un mensaje para indicar que se ha copiado el texto
                MessageBox.Show("Texto copiado al portapapeles ", "Copia exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay texto para copiar");
            }
        }

        private void RegresarL_Click(object sender, EventArgs e)
        {

            ListaDatos.Parent = tabControl2;
            //VerImagen.Parent = tabControl2;
            tabControl2.SelectedTab = ListaDatos;
            //Identificación.ImageIndex = null;
            Limpiar();
            Identificación.ImageIndex = -1;
            Referencia.ImageIndex = -1;
            TiempoVálido.ImageIndex = -1;
            Geografía.ImageIndex = -1;
            TabControlBotones();
            CargarDG();
            CargarBotones();
        }
        private void btnAtrasIma_Click(object sender, EventArgs e)
        {
            //tabControl2.TabPages["VerImagen"].Enabled = false;
            //   ListaDatos.Parent = tabControl2;

            tabControl2.SelectedTab = ListaDatos;
            pictureBoxTres.Image = null;
            pictureBoxCuatro.Image = null;
            textRepositorio.Texts = "Ejemplo: https://drive.google.com/file/imagen/view";
            textRepositorio.ForeColor = Color.Gray;
            TabControlBotones();
            CargarDG();
            CargarBotones();

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {


            if (e.ColumnIndex == 29 && e.RowIndex != -1)
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

            if (e.ColumnIndex == 30 && e.RowIndex != -1)
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


        private void SelecionarRegistro(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                filaSeleccionada = e.RowIndex;//Fila Seleccionada
                                              //Recuperamos los datos del grid y los asignamos a los texbox
                                              // txtDescripcion.Text = dataGridView1.Rows[filaSeleccionada].Cells[0].Value.ToString();
                                              // txtlatitud.Texts = dataGridView1.Rows[filaSeleccionada].Cells[1].Value.ToString();
                                              // txtlongitud.Texts = dataGridView1.Rows[filaSeleccionada].Cells[2].Value.ToString();

                //se asignan los valores del grid al macador
                //marker.Position = new PointLatLng(Convert.ToDouble(txtlatitud.Texts), Convert.ToDouble(txtlongitud.Texts));
                //se posiciona el foco del mapa en ese punto
                gMapControl1.Position = marker.Position;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Inténtelo de nuevo o mas tarde");
            }

        }
        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                //se obtiene los datos de lat y lng del mapa donde usuario presiono
                double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
                double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

                //se posicionan en el txt de la latitud y longitud
                txtlatitud.Texts = lat.ToString();
                txtlongitud.Texts = lng.ToString();

                //crearemos el marcador para moverlo al lugar indicado por el usuario
                marker.Position = new PointLatLng(lat, lng);
                //tambien se agregara el mensaje al marcador es decir el ToolTip
                marker.ToolTipText = string.Format("Ubicación:\n Latitud:{0}\n Longitud:{1}", lat, lng);

                //CrearDireccionTrazarRuta(lat, lng);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Inténtelo de nuevo o mas tarde");
            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            trackZoom.Value = Convert.ToInt32(gMapControl1.Zoom);

        }
        private void trackZoom_ValueChanged(object sender, EventArgs e)
        {
            gMapControl1.Zoom = trackZoom.Value;
        }

        private void btnSeleccionarT_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {
                    row.Cells[31].Value = row.Cells[31].Value == null ? false : !(bool)row.Cells[31].Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Intente de nuevo");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Variable para registrar en la bitácora
                string operacionBiE = "Baja";
                string descripcionBiE = "Eliminación de registro del formulario";

                DialogResult result = MessageBox.Show("¿Desea eliminar los elementos seleccionados?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    List<DataGridViewRow> filasEliminar = new List<DataGridViewRow>();
                    bool elementosSeleccionados = false;
                    bool relacionadoEntradaSalida = false; // Variable para verificar si hay algún registro relacionado con entradas/salidas

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        DataGridViewCheckBoxCell checkBoxCell = row.Cells[31] as DataGridViewCheckBoxCell;
                        if (checkBoxCell != null && checkBoxCell.Value != null)
                        {
                            bool isChecked = (bool)checkBoxCell.Value;

                            if (isChecked)
                            {
                                elementosSeleccionados = true;
                                int DatosID = Convert.ToInt32(row.Cells[0].Value); // Suponiendo que el ID del usuario está en la primera columna

                                // Verificar si se puede eliminar el registro
                                bool puedeEliminar = controladorDatosFormulario.VerificarEliminacionPermitida(DatosID);

                                if (puedeEliminar)
                                {
                                    controladorDatosFormulario.EliminarDatosFormulario(DatosID);
                                    filasEliminar.Add(row);
                                }
                                else
                                {
                                    relacionadoEntradaSalida = true;
                                }
                            }
                        }
                    }

                    if (elementosSeleccionados)
                    {
                        foreach (DataGridViewRow rowEliminar in filasEliminar)
                        {
                            dataGridView1.Rows.Remove(rowEliminar);
                        }

                        // Estos son los registros para la bitácora
                        bitacora.operacion = operacionBiE;
                        bitacora.descripcionEvento = descripcionBiE;
                        bitacora.usuario = textNusuario.Text;
                        // Actualiza a la fecha y hora para insertar en la bitácora
                        DateTime fechaActualE = DateTime.Now;
                        bitacora.fecha = fechaActualE;
                        controladorBitacora.InsertBitacora(bitacora);

                        if (relacionadoEntradaSalida)
                        {
                            MessageBox.Show("No se puede eliminar el registro seleccionado debido a que está relacionado con entradas/salidas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Registro(s) eliminado(s)", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha seleccionado ningún elemento para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Intente de nuevo");
            }
        }

        private void btnExportarCSV_Click(object sender, EventArgs e)
        {
            try
            {
                // Declara el filedialog
                using (var fd = new SaveFileDialog())
                {
                    // En caso de dar aceptar
                    if (fd.ShowDialog() == DialogResult.OK)
                    {
                        // Filtra y obtiene solo las filas seleccionadas por el usuario
                        var filasSeleccionadas = dataGridView1.Rows.Cast<DataGridViewRow>()
                            .Where(row => Convert.ToBoolean(row.Cells["Seleccionar"].Value) == true)
                            .ToList();

                        // Verifica si hay filas seleccionadas
                        if (filasSeleccionadas.Count > 0)
                        {
                            // Genera el CSV y lo guarda en la dirección dada por el filedialog
                            controladorDatosFormulario.aCSV(dataGridView1, filasSeleccionadas, @"" + fd.FileName + ".csv");
                        }
                        else
                        {
                            MessageBox.Show("No se han seleccionado filas para exportar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Intentelo de nuevo o mas tarde");
            }
        }

        private void btnSeleccionarE_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {
                    row.Cells[28].Value = row.Cells[28].Value == null ? false : !(bool)row.Cells[28].Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Intente de nuevo");
            }
        }

        void ActualizarIconosFaltantes()
        {
            try
            {
                //Variable para registrar en la bitacora
                string operacionBi = "Modificación";
                string descripcionBi = "Datos modificados de un registro del formulario";
                bool composFaltantes = false;
                for (int i = 0; i < tabControl2.TabPages.Count; i++)
                {
                    TabPage tabPage = tabControl2.TabPages[i];

                    // Verifica si hay campos faltantes en cada página y establece el índice de imagen del botón correspondiente
                    if (ValidadorCampos(tabPage))
                    {
                        tabPage.ImageIndex = 0; // Índice de imagen correspondiente al icono rojo en el ImageList
                        composFaltantes = true;
                    }
                    else
                    {
                        tabPage.ImageIndex = -1; // Si no hay campos faltantes, establece el índice de imagen como -1 (sin icono)
                    }
                }

                if (!composFaltantes)
                {
                    try
                    {
                        //Estos son los registros para la bitacora
                        bitacora.operacion = operacionBi;
                        bitacora.descripcionEvento = descripcionBi;
                        bitacora.usuario = textNusuario.Text;
                        //Actualiza a la fecha y hora para insertar en la bitacora
                        DateTime fechaActual = DateTime.Now;
                        bitacora.fecha = fechaActual;
                        controladorDatosFormulario.EditarDatosFormulario(modeloIngresoDatos, id);
                        controladorBitacora.InsertBitacora(bitacora);
                        MessageBox.Show("Datos modificados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ListaDatos.Parent = tabControl2;
                        // VerImagen.Parent = tabControl2;
                        tabControl2.SelectedTab = ListaDatos;
                        Limpiar();
                        TabControlBotones();
                        CargarDG();
                        CargarBotones();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar los campos: " + ex.Message);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Inténtelo de nuevo o mas tarde");
            }
        }

        bool ValidadorCampos(TabPage tabPage)
        {
            bool camposFaltantes = false;
            try
            {
                //validación regetx seccion identificación
                //Regex Productoo = new Regex(@"^[ A-Za-züÜáéíóúáéíóúÁÉÍÓÚÑñ.,]{3,100}$");
                //Match ProductoValido = Productoo.Match(ComboProducto.Text);
                //Regex Tecnologia = new Regex(@"^[ A-Za-züÜáéíóúáéíóúÁÉÍÓÚÑñ.,]{3,100}$");
                //Match TecnologiaValido = Tecnologia.Match(ComboTecno.Text);
                //Regex Otro = new Regex(@"^(?!Ejemplo: grava y arena$).{3,100}$");
                //Match OtroValido = Otro.Match(textOtro.Texts);
                Regex Proceso = new Regex(@"^(?!Ejemplo: Elaboración de concreto simple$).{3,200}$");
                Match ProcesoValido = Proceso.Match(textProceso.Texts);
                Regex Autor = new Regex(@"^[ A-Za-züÜáéíóúáéíóúÁÉÍÓÚÑñ.,]{3,50}$");
                Match AutorValido = Autor.Match(textAutor.Texts);
                Regex Email = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
                Match EmailValid = Email.Match(textCorreo.Texts);
                //validación regetx seccion identificación
                Regex NombreFlujoR = new Regex(@"^(?!Ejemplo: Producción de un kilogramo de arena y un kilogramo de grava$).{3,300}$");
                Match NombreFlujoRValido = NombreFlujoR.Match(textUnidadFuncional.Texts);
                Regex Valor = new Regex(@"^[0-9]+(?:\.[0-9]+)?$");
                Match ValorValido = Valor.Match(textValor.Texts);
                //Validación regetx seccion tecnología


                if (tabPage == Identificación)
                {
                    /*
                    if (ProductoValido.Success)
                    {
                        modeloIngresoDatos.producto = ComboProducto.Text;
                        errorProvider1.SetError(ComboProducto, String.Empty);
                    }
                    else
                    {
                        errorProvider1.SetError(ComboProducto, "Se necesita ingresar un producto válido");
                        camposFaltantes = true;
                    }

                    if (TecnologiaValido.Success)
                    {
                        modeloIngresoDatos.tecnologia = ComboTecno.Text;
                        errorProvider1.SetError(ComboTecno, String.Empty);
                    }
                    else
                    {
                        errorProvider1.SetError(ComboTecno, "Se necesita ingresar una tecnología válida");
                        camposFaltantes = true;
                    }
                    if (OtroValido.Success)
                    {
                        modeloIngresoDatos.otro = textOtro.Texts;
                        errorProvider1.SetError(textOtro, String.Empty);
                    }
                    else
                    {
                        errorProvider1.SetError(textOtro, "Se necesita ingresar un dato a este campo");
                        camposFaltantes = true;
                    }
                    */
                    if (ProcesoValido.Success)
                    {
                        modeloIngresoDatos.nombreProceso = textProceso.Texts;
                        errorProvider1.SetError(textProceso, String.Empty);
                    }
                    else
                    {
                        errorProvider1.SetError(textProceso, "Se necesita ingresar un nombre de proceso válido");
                        camposFaltantes = true;
                    }

                    modeloIngresoDatos.tipoProceso = null;

                    if (comboUno.SelectedIndex != -1)
                        modeloIngresoDatos.tipoProceso = comboUno.SelectedItem.ToString();
                    else if (comboDos.SelectedIndex != -1)
                        modeloIngresoDatos.tipoProceso = comboDos.SelectedItem.ToString();
                    else if (comboTres.SelectedIndex != -1)
                        modeloIngresoDatos.tipoProceso = comboTres.SelectedItem.ToString();
                    else if (comboCuatro.SelectedIndex != -1)
                        modeloIngresoDatos.tipoProceso = comboCuatro.SelectedItem.ToString();
                    else if (comboCinco.SelectedIndex != -1)
                        modeloIngresoDatos.tipoProceso = comboCinco.SelectedItem.ToString();
                    else if (comboSeis.SelectedIndex != -1)
                        modeloIngresoDatos.tipoProceso = comboSeis.SelectedItem.ToString();
                    else if (comboSiete.SelectedIndex != -1)
                        modeloIngresoDatos.tipoProceso = comboSiete.SelectedItem.ToString();

                    if (AutorValido.Success)
                    {
                        modeloIngresoDatos.autor = textAutor.Texts;
                        errorProvider1.SetError(textAutor, String.Empty);
                    }
                    else
                    {
                        errorProvider1.SetError(textAutor, "Se necesita ingresar un autor válido");
                        camposFaltantes = true;
                    }

                    if (EmailValid.Success)
                    {
                        modeloIngresoDatos.correo = textCorreo.Texts;
                        errorProvider1.SetError(textCorreo, String.Empty);
                    }
                    else
                    {
                        errorProvider1.SetError(textCorreo, "Se necesita ingresar un correo válido");
                        camposFaltantes = true;
                    }

                }
                if (tabPage == Referencia)
                {

                    if (NombreFlujoRValido.Success)
                    {
                        modeloIngresoDatos.nombreFlujoR = textUnidadFuncional.Texts;
                        errorProvider1.SetError(textUnidadFuncional, String.Empty);
                    }
                    else
                    {
                        errorProvider1.SetError(textUnidadFuncional, "Se necesita ingresar un nombre de flujo válido");
                        camposFaltantes = true;
                    }

                    if (comboUnidadUno.Text == "Unidad*")
                    {
                        errorProvider1.SetError(comboUnidadUno, "Se necesita seleccionar una unidad");
                        camposFaltantes = true;
                    }
                    else
                    {
                        modeloIngresoDatos.unidad = comboUnidadUno.Text;
                        errorProvider1.SetError(comboUnidadUno, String.Empty);
                    }

                    if (ValorValido.Success)
                    {
                        modeloIngresoDatos.valorR = textValor.Texts;
                        errorProvider1.SetError(textValor, String.Empty);
                    }
                    else
                    {
                        errorProvider1.SetError(textValor, "Se necesita ingresar un valor");
                        camposFaltantes = true;
                    }

                    if (comboLimitesSistema.Text == "Limites del sistema")
                    {
                        modeloIngresoDatos.limitesSistema = null;
                    }
                    else
                    {
                        modeloIngresoDatos.limitesSistema = comboLimitesSistema.Text;
                    }

                    if (textObjetivoR.Texts == "Ejemplo: Estimar la huella de carbono")
                    {
                        modeloIngresoDatos.objetivo = null;
                    }
                    else
                    {
                        modeloIngresoDatos.objetivo = textObjetivoR.Texts;
                    }

                    //guardar imagen al modelo
                    if (pictureBoxUno.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pictureBoxUno.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            modeloIngresoDatos.imagen = ms.ToArray();
                        }
                    }
                    else
                    {
                        modeloIngresoDatos.imagen = null;
                    }
                    //guardar imagenDos al modelo
                    if (pictureBoxDos.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pictureBoxDos.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            modeloIngresoDatos.imagenDos = ms.ToArray();
                        }
                    }
                    else
                    {
                        modeloIngresoDatos.imagenDos = null;
                    }

                    if (textRepositorio.Texts == "Ejemplo: https://drive.google.com/file/imagen/view")
                    {
                        modeloIngresoDatos.urlRepositorio = null;
                    }
                    else
                    {
                        modeloIngresoDatos.urlRepositorio = textRepositorio.Texts;
                    }
                }
                if (tabPage == Tecnología)
                {

                    if (ComboTipoTecnologia.Text == "Tipo de tecnología*")
                    {
                        errorProvider1.SetError(ComboTipoTecnologia, "Se necesita seleccionar un tipo de tecnología");
                        camposFaltantes = true;
                    }
                    else
                    {
                        modeloIngresoDatos.tipoTecnologia = ComboTipoTecnologia.Text;
                        errorProvider1.SetError(ComboTipoTecnologia, String.Empty);
                    }

                    if (textCondicionesOpe.Texts == "Ejemplo: En este estudio se considera una revolvedora")
                    {
                        modeloIngresoDatos.condicionesOperacion = null;
                    }
                    else
                    {
                        modeloIngresoDatos.condicionesOperacion = textCondicionesOpe.Texts;
                    }


                }
                if (tabPage == TiempoVálido)
                {
                    if (FechaReferencia.Value.Date == new DateTime(2000, 1, 1) || FechaReferencia.Value.Date == new DateTime(1900, 1, 1))
                    {
                        errorProvider1.SetError(FechaReferencia, "Se ingresar una fecha de referencia válida");
                        camposFaltantes = true;
                    }
                    else
                    {
                        f1 = FechaReferencia.Value.ToString("yyyy-MM-dd");
                    }

                    if (FechaDatosValidos.Value.Date == new DateTime(2000, 1, 1) || FechaDatosValidos.Value.Date == new DateTime(1900, 1, 1))
                    {
                        errorProvider1.SetError(FechaDatosValidos, "Se ingresar una fecha de datos válida");
                        camposFaltantes = true;
                    }
                    else
                    {
                        f2 = FechaDatosValidos.Value.ToString("yyyy-MM-dd");
                    }

                    modeloIngresoDatos.fechaReferencia = f1;
                    modeloIngresoDatos.datosValidos = f2;

                    if (textDescripcionPeriodo.Texts == "Ejemplo: Se solicita este tiempo para el análisis del estudio")
                    {
                        modeloIngresoDatos.descripcion = null;
                    }
                    else
                    {
                        modeloIngresoDatos.descripcion = textDescripcionPeriodo.Texts;
                    }


                }
                if (tabPage == Geografía)
                {
                    //se toman los valores de los combobox
                    modeloEstado ef = (modeloEstado)comboEstado.SelectedItem;
                    modeloArea mp = (modeloArea)comboArea.SelectedItem;

                    if (comboEstado.Text == "Estado*")
                    {
                        errorProvider1.SetError(comboEstado, "Se necesita seleccionar un estado");
                        camposFaltantes = true;
                    }
                    else
                    {


                        modeloIngresoDatos.id_estado = Convert.ToInt32(ef.id);
                        errorProvider1.SetError(comboEstado, String.Empty);
                    }

                    if (comboArea.Text == "Area*")
                    {
                        errorProvider1.SetError(comboArea, "Se necesita seleccionar un área");
                        camposFaltantes = true;
                    }
                    else
                    {
                        modeloIngresoDatos.id_area = Convert.ToInt32(mp.id);
                        errorProvider1.SetError(comboArea, String.Empty);
                    }

                    if (txtlatitud.Texts == "Latitud" && txtlongitud.Texts == "Longitud")
                    {
                        MessageBox.Show("Falta indicar representación geográfica", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        camposFaltantes = true;
                    }
                    else
                    {
                        modeloIngresoDatos.latitud = txtlatitud.Texts;
                        modeloIngresoDatos.longitud = txtlongitud.Texts;

                    }
                    if (textObservaciones.Texts == "Ejemplo: Información puede ser usada en varios estados.")
                    {
                        modeloIngresoDatos.observaciones = null;
                    }
                    else
                    {
                        modeloIngresoDatos.observaciones = textObservaciones.Texts;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Inténtelo de nuevo o mas tarde");
            }

            return camposFaltantes;
        }


        private void buttonsTabControl_Click(object sender, EventArgs e)
        {
            //ActualizarTabControl();
        }

        private void buttonGuardarG_Click(object sender, EventArgs e)
        {
            ActualizarIconosFaltantes();
        }
    }
}
