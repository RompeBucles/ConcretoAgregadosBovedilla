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
using SistemaRegistro.Controladores;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SistemaRegistro.Modelo;
using GMap.NET.WindowsForms.Markers;
using System.Text.RegularExpressions;
using iTextSharp.text.pdf.qrcode;

namespace SistemaRegistro
{
    public partial class RegistroFormulario : Form
    {

        //Instacia de usuarios, para usar el motodo de validación 
        private Usuarios usuarios = new Usuarios();
        //Instacia del modelo ingreso datos
        modeloIngresoDatos modeloIngresoDatos = new modeloIngresoDatos();
        //Instancia del controlador ingreso datos
        ControladorDatosFormulario controladorDatosFormulario = new ControladorDatosFormulario();
        String? f1, f2;
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
            //Estado y Area
            llenarCombos();
            //asignamos una hora por defecto a los datetimepickers
            FechaReferencia.Value = new DateTime(2000, 01, 01);
            FechaDatosValidos.Value = new DateTime(2000, 01, 01);

            //Asigna opciones a la lista ComboProducto
            List<string> ListaProducto = new List<string>();
            ListaProducto.Add("Producto*");
            ListaProducto.Add("Cemento");
            ListaProducto.Add("Concreto");
            ListaProducto.Add("Acero estructural");
            ListaProducto.Add("Ladrillos");
            ListaProducto.Add("Madera");
            ListaProducto.Add("Vidrio");
            ListaProducto.Add("Aislamiento térmico");
            ListaProducto.Add("Pinturas y recubrimientos");
            ListaProducto.Add("Azulejos y baldosas");
            ListaProducto.Add("Adhesivos y selladores");
            ListaProducto.Add("Impermeabilizantes");
            ListaProducto.Add("Sistemas de fontanería");
            ComboProducto.DataSource = ListaProducto;

            //Asigna opciones a la lista ComboTecno
            List<string> ListaTecnologia = new List<string>();
            ListaTecnologia.Add("Tecnología*");
            ListaTecnologia.Add("Cemento Portland");
            ListaTecnologia.Add("Concreto reforzado");
            ListaTecnologia.Add("Concreto premezclado");
            ListaTecnologia.Add("Concreto de alto rendimiento");
            ListaTecnologia.Add("Ladrillos cerámicos");
            ListaTecnologia.Add("Ladrillos de hormigón");
            ListaTecnologia.Add("Acero laminado en caliente");
            ListaTecnologia.Add("Madera laminada encolada");
            ListaTecnologia.Add("Madera tratada");
            ListaTecnologia.Add("Vidrio de seguridad laminado");
            ListaTecnologia.Add("Azulejos de cerámica esmaltada");
            ListaTecnologia.Add("Baldosas de porcelana");
            ListaTecnologia.Add("Lana mineral");
            ListaTecnologia.Add("Membranas asfálticas");
            ListaTecnologia.Add("Pinturas impermeabilizantes");
            ComboTecno.DataSource = ListaTecnologia;

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
                    int pictureBoxWidth = pictureBox1.Width;
                    int pictureBoxHeight = pictureBox1.Height;

                    // Crear una versión en miniatura de la imagen con el tamaño deseado
                    Image resizedImage = originalImage.GetThumbnailImage(pictureBoxWidth, pictureBoxHeight, null, IntPtr.Zero);

                    // Asignar la imagen ajustada al control PictureBox
                    pictureBox1.Image = resizedImage;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Inténtelo de nuevo o mas tarde");
            }
        }


        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
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
                errorProvider1.SetError(textCondicionesOpe, "Se necesita ingresar una condición de operación");
                textCondicionesOpe.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(textCondicionesOpe, String.Empty);
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
        private void textDescripcionPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            usuarios.textBoxEvent.textKeyPress(e);
        }
        private void comboEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            //al seleccionar la entidad federativa se toma su valor y se usa para llamar a la lista de municipios que se relacionan con esta
            modeloEstado ef = (modeloEstado)comboEstado.SelectedItem;
            comboArea.DataSource = new controladorArea().obtenerListaArea(ef.id);
            comboArea.ValueMember = "valor";

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
        private void llenarCombos()
        {

            //asigna la lista de entidades a el combobox 3
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
            comboLimitesSistema.ForeColor = Color.Gray;
            pictureBox1.Image = null;
            ComboTipoTecnologia.Text = "Tipo de tecnología*";
            ComboTipoTecnologia.ForeColor = Color.Gray;
            textCondicionesOpe.Texts = "Ejemplo: En este estudio se considera una revolvedora";
            textCondicionesOpe.ForeColor = Color.Gray;
            FechaReferencia.Value = new DateTime(2000, 01, 01);
            FechaDatosValidos.Value = new DateTime(2000, 01, 01);
            textDescripcionPeriodo.Texts = "Ejemplo: Se solicita este tiempo para el análisis del estudio";
            textDescripcionPeriodo.ForeColor = Color.Gray;
            comboEstado.Text = "Estado*";
            comboEstado.ForeColor = Color.Gray;
            comboArea.Text = "Area*";
            comboArea.ForeColor = Color.Gray;
            txtlatitud.Texts = "Latitud";
            txtlongitud.Texts = "Longitud";
        }




        private void RegistroFormulario_Load(object sender, EventArgs e)
        {
            try
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
                gMapControl2.DragButton = MouseButtons.Left;
                gMapControl2.CanDragMap = true;
                gMapControl2.MapProvider = GMapProviders.GoogleMap;
                gMapControl2.Position = new PointLatLng(LatInicial, LngInicial);
                gMapControl2.MinZoom = 0;
                gMapControl2.MaxZoom = 24;
                gMapControl2.Zoom = 5;
                gMapControl2.AutoScroll = true;

                //Marcador
                markerOverlay = new GMapOverlay("Marcador");
                marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.blue);
                markerOverlay.Markers.Add(marker);//Agregamos al mapa

                //agregamos un tooltip de texto a los marcadores
                marker.ToolTipMode = MarkerTooltipMode.Always;
                marker.ToolTipText = string.Format("Ubicación:\n Latitud:{0}\n Longitud:{1}", LatInicial, LngInicial);

                //ahora agregamos el mapa y el marcador al control map

                gMapControl2.Overlays.Add(markerOverlay);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Inténtelo de nuevo o mas tarde");
            }

        }
        private void SelecionarRegistro(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                filaSeleccionada = e.RowIndex;//Fila Seleccionada
                                              //Recuperamos los datos del grid y los asignamos a los texbox
                                              // txtDescripcion.Text = dataGridView1.Rows[filaSeleccionada].Cells[0].Value.ToString();
                txtlatitud.Texts = dataGridView1.Rows[filaSeleccionada].Cells[1].Value.ToString();
                txtlongitud.Texts = dataGridView1.Rows[filaSeleccionada].Cells[2].Value.ToString();

                //se asignan los valores del grid al macador
                marker.Position = new PointLatLng(Convert.ToDouble(txtlatitud.Texts), Convert.ToDouble(txtlongitud.Texts));
                //se posiciona el foco del mapa en ese punto
                gMapControl2.Position = marker.Position;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Inténtelo de nuevo o mas tarde");
            }

        }
        private void gMapControl2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                //se obtiene los datos de lat y lng del mapa donde usuario presiono
                double lat = gMapControl2.FromLocalToLatLng(e.X, e.Y).Lat;
                double lng = gMapControl2.FromLocalToLatLng(e.X, e.Y).Lng;

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
            trackZoom.Value = Convert.ToInt32(gMapControl2.Zoom);

        }
        private void trackZoom_ValueChanged(object sender, EventArgs e)
        {
            gMapControl2.Zoom = trackZoom.Value;
        }


        /*
        private void ActualizarTabControl()
        {
            try
            {
                //validación regetx seccion identificación
                Regex Productoo = new Regex(@"^[ A-Za-züÜáéíóúáéíóúÁÉÍÓÚÑñ.,]{3,100}$");
                Match ProductoValido = Productoo.Match(ComboProducto.Text);
                Regex Tecnologia = new Regex(@"^[ A-Za-züÜáéíóúáéíóúÁÉÍÓÚÑñ.,]{3,100}$");
                Match TecnologiaValido = Tecnologia.Match(ComboTecno.Text);
                Regex Otro = new Regex(@"^(?!Ejemplo: grava y arena$).{3,100}$");
                Match OtroValido = Otro.Match(textOtro.Texts);
                Regex Proceso = new Regex(@"^(?!Ejemplo: Elaboración de concreto simple$).{3,200}$");
                Match ProcesoValido = Proceso.Match(textProceso.Texts);
                Regex Autor = new Regex(@"^[ A-Za-züÜáéíóúáéíóúÁÉÍÓÚÑñ.,]{3,50}$");
                Match AutorValido = Autor.Match(textAutor.Texts);
                Regex Email = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
                Match EmailisValid = Email.Match(textCorreo.Texts);
                //validación regetx seccion identificación
                Regex NombreFlujoR = new Regex(@"^(?!Ejemplo: Producción de un kilogramo de arena y un kilogramo de grava$).{3,300}$");
                Match NombreFlujoRValido = NombreFlujoR.Match(textUnidadFuncional.Texts);
                Regex Valor = new Regex(@"^[0-9]+(?:\.[0-9]+)?$");
                Match ValorValido = Valor.Match(textValor.Texts);
                // Obtener el TabPage actualmente seleccionado en el TabControl
                TabPage paginaActual = tabControl1.SelectedTab;


                if (paginaActual == Referencia)
                {

                    if (ProductoValido.Success)
                    {
                        errorProvider1.SetError(ComboProducto, String.Empty);
                        // No hay campos faltantes, ocultar el icono rojo
                        Identificación.ImageIndex = -1;
                    }
                    else
                    {
                        errorProvider1.SetError(ComboProducto, "Se necesita ingresar un producto válido");
                        // Activar el icono rojo en los campos faltantes
                        Identificación.ImageIndex = 0;
                    }

                    if (TecnologiaValido.Success)
                    {
                        errorProvider1.SetError(ComboTecno, String.Empty);
                        Identificación.ImageIndex = -1;
                    }
                    else
                    {
                        errorProvider1.SetError(ComboTecno, "Se necesita ingresar una tecnología válida");
                        Identificación.ImageIndex = 0;
                    }
                    if (OtroValido.Success)
                    {
                        errorProvider1.SetError(textOtro, String.Empty);
                        Identificación.ImageIndex = -1;
                    }
                    else
                    {
                        errorProvider1.SetError(textOtro, "Se necesita ingresar un dato a este campo");
                        Identificación.ImageIndex = 0;
                    }

                    if (ProcesoValido.Success)
                    {
                        errorProvider1.SetError(textProceso, String.Empty);
                        Identificación.ImageIndex = -1;
                    }
                    else
                    {
                        errorProvider1.SetError(textProceso, "Se necesita ingresar un nombre de proceso válido");
                        Identificación.ImageIndex = 0;
                    }
                    if (AutorValido.Success)
                    {
                        errorProvider1.SetError(textAutor, String.Empty);
                        Identificación.ImageIndex = -1;
                    }
                    else
                    {
                        errorProvider1.SetError(textAutor, "Se necesita ingresar un autor válido");
                        Identificación.ImageIndex = 0;
                    }

                    if (EmailisValid.Success)
                    {
                        errorProvider1.SetError(textCorreo, String.Empty);
                        Identificación.ImageIndex = -1;
                    }
                    else
                    {
                        errorProvider1.SetError(textCorreo, "Se necesita ingresar un correo válido");
                        Identificación.ImageIndex = 0;
                    }

                }

                else if (paginaActual == Tecnología)
                {

                    if (NombreFlujoRValido.Success)
                    {
                        errorProvider1.SetError(textUnidadFuncional, String.Empty);
                        Referencia.ImageIndex = -1;
                    }
                    else
                    {
                        errorProvider1.SetError(textUnidadFuncional, "Se necesita ingresar un nombre de flujo válido");
                        Referencia.ImageIndex = 0;
                    }

                    if (comboUnidadUno.Text == "Unidad*")
                    {
                        errorProvider1.SetError(comboUnidadUno, "Se necesita seleccionar una unidad");
                        Referencia.ImageIndex = 0;
                    }
                    else
                    {
                        errorProvider1.SetError(comboUnidadUno, String.Empty);
                        Referencia.ImageIndex = -1;
                    }

                    if (ValorValido.Success)
                    {
                        errorProvider1.SetError(textValor, String.Empty);
                        Referencia.ImageIndex = -1;
                    }
                    else
                    {
                        errorProvider1.SetError(textValor, "Se necesita ingresar un valor");
                        Referencia.ImageIndex = 0;
                    }

                }
                else if (paginaActual == TiempoVálido)
                {

                    if (ComboTipoTecnologia.Text == "Tipo de tecnología*")
                    {
                        errorProvider1.SetError(ComboTipoTecnologia, "Se necesita seleccionar un tipo de tecnología");
                        Tecnología.ImageIndex = 0;
                    }
                    else
                    {
                        errorProvider1.SetError(ComboTipoTecnologia, String.Empty);
                        Tecnología.ImageIndex = -1;
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Inténtelo de nuevo o mas tarde");
            }
        }
        */
        void ActualizarIconosFaltantes()
        {
            try
            {
                bool composFaltantes = false;
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    TabPage tabPage = tabControl1.TabPages[i];

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
                        controladorDatosFormulario.InsertarDatosFormulario(modeloIngresoDatos);
                        MessageBox.Show("Todos los campos se han guardado correctamente");
                        Limpiar();
                        errorProvider1.Clear();
                        tabControl1.SelectedTab = Identificación;
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
                Regex Productoo = new Regex(@"^[ A-Za-züÜáéíóúáéíóúÁÉÍÓÚÑñ.,]{3,100}$");
                Match ProductoValido = Productoo.Match(ComboProducto.Text);
                Regex Tecnologia = new Regex(@"^[ A-Za-züÜáéíóúáéíóúÁÉÍÓÚÑñ.,]{3,100}$");
                Match TecnologiaValido = Tecnologia.Match(ComboTecno.Text);
                Regex Otro = new Regex(@"^(?!Ejemplo: grava y arena$).{3,100}$");
                Match OtroValido = Otro.Match(textOtro.Texts);
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
                    if (pictureBox1.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            modeloIngresoDatos.imagen = ms.ToArray();
                        }
                    }
                    else
                    {
                        modeloIngresoDatos.imagen = null;
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
                    if (FechaReferencia.Text == "2000-01-01" || FechaReferencia.Text == "1900-01-01")
                    {
                        f1 = null;
                    }
                    else
                    {
                        f1 = FechaReferencia.Text;
                    }
                    if (FechaDatosValidos.Text == "2000-01-01" || FechaReferencia.Text == "1900-01-01")
                    {
                        f2 = null;
                    }
                    else
                    {
                        f2 = FechaDatosValidos.Text;
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
                        MessageBox.Show("Falta indicar representación geográfica");
                        camposFaltantes = true;
                    }
                    else
                    {
                        modeloIngresoDatos.latitud = txtlatitud.Texts;
                        modeloIngresoDatos.longitud = txtlongitud.Texts;

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
