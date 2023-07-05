using SistemaRegistro.Controladores;
using SistemaRegistro.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaRegistro
{
    public partial class RegistroEntradasSalidas : Form
    {
        //instancia del modelo {get; set;} 
        modeloEntrdasSalidas entradasSalidas = new modeloEntrdasSalidas();
        //instancia del modelo {get; set;} 
        modeloBitacora bitacora = new modeloBitacora();
        //Instacia del controlador
        controladorEntradasSalidas controladorEntradas = new controladorEntradasSalidas();
        //Instacia del controlador
        ControladorBitacora controladorBitacora = new ControladorBitacora();
        //Variable para registrar en la bitacora
        string operacionBi = "Alta";
        string descripcionBi = "Registro en entradas/salidas";
        public RegistroEntradasSalidas(string usuario)
        {
            InitializeComponent();
            listarProducto();
            textNusuario.Text = usuario;
            //Asigna opciones a la lista ComboTipoFlujo
            List<string> ListaTipoFlujo = new List<string>();
            ListaTipoFlujo.Add("Tipo de flujo*");
            ListaTipoFlujo.Add("Elemental");
            ListaTipoFlujo.Add("Producto");
            ListaTipoFlujo.Add("Residuo");
            comboTipoFlujo.DataSource = ListaTipoFlujo;

            //Asigna opciones a la lista ComboRecursos
            List<string> ListaRecursos = new List<string>();
            ListaRecursos.Add("Recursos*");
            ListaRecursos.Add("Elemento o Compuesto");
            ListaRecursos.Add("Grupo de químicos");
            ListaRecursos.Add("Mineral, metal o agregado.");
            ListaRecursos.Add("Biológico");
            ListaRecursos.Add("Agua");
            ListaRecursos.Add("Combustibles fósiles");
            ListaRecursos.Add("Combustibles nucleares.");
            ListaRecursos.Add("Energía");
            ListaRecursos.Add("Recurso – Recurso suelo");
            ListaRecursos.Add("Recurso – Recurso aire");
            ListaRecursos.Add("Recurso – Recurso agua");
            ListaRecursos.Add("Recursos – Recursos biótico");
            ListaRecursos.Add("Recursos – Recurso ocupación y transformación del suelo");
            ListaRecursos.Add("Recursos materiales no renovables del suelo");
            ListaRecursos.Add("Recursos de elementos no renovables del suelo");
            ListaRecursos.Add("Recursos de elementos renovables del suelo");
            ListaRecursos.Add("Recursos de energía renovable del suelo (por ejemplo, \"Energía eólica\", \"Energía hidráulica; funcionamiento\", etc.)");
            ListaRecursos.Add("Recursos materiales renovables del suelo");
            ListaRecursos.Add("Recursos renovables del suelo, no especificados");
            ListaRecursos.Add("Recursos no renovables del suelo, no especificados");
            ListaRecursos.Add("Uso del suelo - Transformación del suelo");
            ListaRecursos.Add("Uso del suelo - Ocupación del suelo");
            ListaRecursos.Add("Uso del suelo -  Cultivable");
            ListaRecursos.Add("Uso del suelo – No irrigado");
            ListaRecursos.Add("Uso del suelo – Diverso, intensivo.");
            comboRecursos.DataSource = ListaRecursos;

            //Asigna opciones a la lista ComboEmisiones
            List<string> ListaEmisiones = new List<string>();
            ListaEmisiones.Add("Emisiones");
            ListaEmisiones.Add("Emisiones - Emisiones al aire - Emisiones al aire sin especificar");
            ListaEmisiones.Add("Emisiones - Emisiones al aire - Emisiones sin especificar (a largo plazo)");
            ListaEmisiones.Add("Emisiones - Emisiones al aire - Emisiones al aire no urbano o de chimeneas altas (alturas mayo a 100 m)");
            ListaEmisiones.Add("Emisiones - Emisiones al aire - Emisiones a la baja estratosfera y a la alta troposfera");
            ListaEmisiones.Add("Emisiones - Emisiones al aire - Emisiones inorgánicas al aire");
            ListaEmisiones.Add("Emisiones - Emisiones al aire - Emisiones orgánicas al aire");
            ListaEmisiones.Add("Emisiones - Emisiones al aire - Emisiones radioactivas al aire");
            ListaEmisiones.Add("Emisiones - Emisiones al aire – Partículas");
            ListaEmisiones.Add("Emisiones - Emisiones al aire - Otras emisiones al aire");
            ListaEmisiones.Add("Emisiones - Emisiones al agua - Emisiones al agua, sin especificar.");
            ListaEmisiones.Add("Emisiones - Emisiones al agua – Emisiones inorgánicas al agua");
            ListaEmisiones.Add("Emisiones - Emisiones al agua – Emisiones orgánicas al agua");
            ListaEmisiones.Add("Emisiones - Emisiones al agua – Emisiones radioactivas al agua");
            ListaEmisiones.Add("Emisiones - Emisiones al agua – Emisiones de partículas al agua");
            ListaEmisiones.Add("Emisiones - Emisiones al agua – Otras Emisiones al agua");
            ListaEmisiones.Add("Emisiones - Emisiones al suelo - Emisiones al suelo, sin especificar");
            ListaEmisiones.Add("Emisiones - Emisiones al suelo - Emisiones al suelo agrícola");
            ListaEmisiones.Add("Emisiones - Emisiones al suelo - Emisiones al suelo no agrícola");
            ListaEmisiones.Add("Emisiones - Emisiones al suelo - Emisiones al suelo, sin especificar (a largo plazo)");
            ListaEmisiones.Add("Emisiones - Emisiones al suelo – Emisiones inorgánicas al suelo");
            ListaEmisiones.Add("Emisiones - Emisiones al suelo – Emisiones orgánicas al suelo");
            ListaEmisiones.Add("Emisiones - Emisiones al suelo – Emisiones radioactivas al suelo");
            ListaEmisiones.Add("Emisiones - Emisiones al suelo – Emisiones de partículas al suelo");
            ListaEmisiones.Add("Emisiones - Emisiones al suelo – Otras Emisiones al suelo");
            ListaEmisiones.Add("Otros flujos elementales");
            comboEmisiones.DataSource = ListaEmisiones;

            //Asigna opciones a la lista ComboUnidades
            List<string> ListaUnidad = new List<string>();
            ListaUnidad.Add("Unidad*");
            ListaUnidad.Add("Área (m²)");
            ListaUnidad.Add("Volumen(m³)");
            ListaUnidad.Add("Masa(kg)");
            ListaUnidad.Add("Radioactividad(kBq)");
            ListaUnidad.Add("Unidades(ítem)");
            ListaUnidad.Add("Longitud(m)");
            ListaUnidad.Add("Tiempo(s)");
            ListaUnidad.Add("Masa* Longitud(t* km)");
            ListaUnidad.Add("Volumen* Longitud(m³*km)");
            ListaUnidad.Add("Unidades de ítems* Longitud(Ítems* km)");
            ListaUnidad.Add("Área* tiempo(m²*año)");
            ListaUnidad.Add("Volumen* tiempo(m³*año)");
            ListaUnidad.Add("Energia(kWh)");
            ListaUnidad.Add("Energía(kJ)");
            comboUnidades.DataSource = ListaUnidad;

            //Asigna opciones a la lista ComboTratamiento
            List<string> ListaTratamiento = new List<string>();
            ListaTratamiento.Add("Tratamiento de dato*");
            ListaTratamiento.Add("Calculado: basado en relaciones estequiométricos.");
            ListaTratamiento.Add("Estimado: basado en el juicio cuantitativo de expertos.");
            ListaTratamiento.Add("Literatura: Derivación desconocida, no se ninguna otra indicación sobre el origen del valor.");
            ListaTratamiento.Add("Valor medido: utilice este término cuando el valor haya sido medido.");
            comboTratamiento.DataSource = ListaTratamiento;
            //Asigna opciones a la lista ComboAdquisicion
            List<string> ListaAdquisicion = new List<string>();
            ListaAdquisicion.Add("Adquisición de dato*");
            ListaAdquisicion.Add("Publicaciones y comunicaciones");
            ListaAdquisicion.Add("Reporte de entidades estatales");
            ListaAdquisicion.Add("Bases de datos");
            ListaAdquisicion.Add("Clasificaciones estadísticas");
            ListaAdquisicion.Add("Formatos de conjuntos de datos");
            ListaAdquisicion.Add("Sistemas de cumplimiento");
            ListaAdquisicion.Add("Cuestionarios – Encuestas");
            ListaAdquisicion.Add("Entrevistas");
            ListaAdquisicion.Add("Imágenes");
            ListaAdquisicion.Add("Mediciones in situ");
            ListaAdquisicion.Add("Otros tipos de fuentes");
            comboAdquisicion.DataSource = ListaAdquisicion;
        }
        private void listarProducto()
        {
            comboProductoT.DataSource = new controladorEntradasSalidas().obtenerListaProducto();
            comboProductoT.ValueMember = "producto";
        }
        private void comboProductoT_Enter(object sender, EventArgs e)
        {
            if (comboProductoT.Text == "Producto*")
            {
                comboProductoT.Text = "";
                comboProductoT.ForeColor = Color.Black;
            }
        }

        private void comboProducto_Leave(object sender, EventArgs e)
        {
            if (comboProductoT.Text == "")
            {
                comboProductoT.Text = "Producto*";
                errorProvider1.SetError(comboProductoT, "Se necesita seleccionar un producto");
                comboProductoT.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(comboProductoT, String.Empty);
            }
        }

        private void textNombreFlujo_Enter(object sender, EventArgs e)
        {
            if (textNombreFlujo.Texts == "Ejemplo: Grava 20mm")
            {
                textNombreFlujo.Texts = "";
                textNombreFlujo.ForeColor = Color.Black;
            }
        }

        private void textNombreFlujo_Leave(object sender, EventArgs e)
        {
            if (textNombreFlujo.Texts == "")
            {
                textNombreFlujo.Texts = "Ejemplo: Grava 20mm";
                errorProvider1.SetError(textNombreFlujo, "Se necesita ingresar nombre del flujo");
                textNombreFlujo.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(textNombreFlujo, String.Empty);
            }
        }

        private void comboTipoFlujo_Enter(object sender, EventArgs e)
        {
            if (comboTipoFlujo.Text == "Tipo de flujo*")
            {
                comboTipoFlujo.Text = "";
                comboTipoFlujo.ForeColor = Color.Black;
            }
        }

        private void comboTipoFlujo_Leave(object sender, EventArgs e)
        {
            if (comboProductoT.Text == "")
            {
                comboTipoFlujo.Text = "Tipo de flujo*";
                errorProvider1.SetError(comboTipoFlujo, "Se necesita seleccionar un tipo de flujo");
                comboTipoFlujo.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(comboTipoFlujo, String.Empty);
            }
        }

        private void comboRecursos_Enter(object sender, EventArgs e)
        {
            if (comboRecursos.Text == "Recursos*")
            {
                comboRecursos.Text = "";
                comboRecursos.ForeColor = Color.Black;
            }
        }

        private void comboRecursos_Leave(object sender, EventArgs e)
        {
            if (comboRecursos.Text == "")
            {
                comboRecursos.Text = "Recursos*";
                errorProvider1.SetError(comboRecursos, "Se necesita seleccionar algun recurso");
                comboRecursos.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(comboRecursos, String.Empty);
            }
        }

        private void comboEmisiones_Enter(object sender, EventArgs e)
        {
            if (comboEmisiones.Text == "Emisiones")
            {
                comboEmisiones.Text = "";
                comboEmisiones.ForeColor = Color.Black;
            }
        }

        private void comboEmisiones_Leave(object sender, EventArgs e)
        {
            if (comboEmisiones.Text == "")
            {
                comboEmisiones.Text = "Emisiones";
                errorProvider1.SetError(comboEmisiones, "Se necesita seleccionar alguna emisión");
                comboEmisiones.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(comboEmisiones, String.Empty);
            }
        }

        private void comboUnidades_Enter(object sender, EventArgs e)
        {
            if (comboUnidades.Text == "Unidad*")
            {
                comboUnidades.Text = "";
                comboUnidades.ForeColor = Color.Black;
            }
        }

        private void comboUnidades_Leave(object sender, EventArgs e)
        {
            if (comboUnidades.Text == "")
            {
                comboUnidades.Text = "Unidad*";
                errorProvider1.SetError(comboUnidades, "Se necesita seleccionar una unidad");
                comboUnidades.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(comboUnidades, String.Empty);
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

        private void comboTratamiento_Enter(object sender, EventArgs e)
        {
            if (comboTratamiento.Text == "Tratamiento de dato*")
            {
                comboTratamiento.Text = "";
                comboTratamiento.ForeColor = Color.Black;
            }
        }

        private void comboTratamiento_Leave(object sender, EventArgs e)
        {
            if (comboTratamiento.Text == "")
            {
                comboTratamiento.Text = "Tratamiento de dato*";
                errorProvider1.SetError(comboTratamiento, "Se necesita seleccionar un tratamiento de dato");
                comboTratamiento.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(comboTratamiento, String.Empty);
            }
        }

        private void comboAdquisicion_Enter(object sender, EventArgs e)
        {
            if (comboAdquisicion.Text == "Adquisición de dato*")
            {
                comboAdquisicion.Text = "";
                comboAdquisicion.ForeColor = Color.Black;
            }
        }

        private void comboAdquisicion_Leave(object sender, EventArgs e)
        {
            if (comboAdquisicion.Text == "")
            {
                comboAdquisicion.Text = "Adquisición de dato*";
                errorProvider1.SetError(comboAdquisicion, "Se necesita seleccionar alguna adquisición del dato");
                comboAdquisicion.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(comboAdquisicion, String.Empty);
            }
        }
        private void textCitas_Enter(object sender, EventArgs e)
        {
            if (textCitas.Texts == "Ejemplo: “Manual del Ingeniero civil”")
            {
                textCitas.Texts = "";
                textCitas.ForeColor = Color.Black;
            }
        }

        private void textCitas_Leave(object sender, EventArgs e)
        {
            if (textCitas.Texts == "")
            {
                textCitas.Texts = "Ejemplo: “Manual del Ingeniero civil”";
                textCitas.ForeColor = Color.Gray;
            }

        }
        private void textComentario_Enter(object sender, EventArgs e)
        {
            if (textComentario.Texts == "Ejemplo: Expreso este comentario")
            {
                textComentario.Texts = "";
                textComentario.ForeColor = Color.Black;
            }
        }

        private void textComentario_Leave(object sender, EventArgs e)
        {
            if (textComentario.Texts == "")
            {
                textComentario.Texts = "Ejemplo: Expreso este comentario";
                textComentario.ForeColor = Color.Gray;
            }
        }

        private void Limpiar()
        {
            comboProductoT.Text = "Producto*";
            comboProductoT.ForeColor = Color.Black;
            textNombreFlujo.Texts = "Ejemplo: Grava 20mm";
            textNombreFlujo.ForeColor = Color.Gray;
            comboTipoFlujo.Text = "Tipo de flujo*";
            comboTipoFlujo.ForeColor = Color.Black;
            comboRecursos.Text = "Recursos*";
            comboRecursos.ForeColor = Color.Black;
            comboEmisiones.Text = "Emisiones";
            comboEmisiones.ForeColor = Color.Black;
            comboUnidades.Text = "Unidad*";
            comboUnidades.ForeColor = Color.Black;
            textValor.Texts = "Ejemplo: 0";
            textValor.ForeColor = Color.Gray;
            comboTratamiento.Text = "Tratamiento de dato*";
            comboTratamiento.ForeColor = Color.Gray;
            comboAdquisicion.Text = "Adquisición de dato*";
            comboAdquisicion.ForeColor = Color.Black;
            textCitas.Texts = "Ejemplo: “Manual del Ingeniero civil”";
            textCitas.ForeColor = Color.Gray;
            textComentario.Texts = "Ejemplo: Expreso este comentario";
            textComentario.ForeColor = Color.Gray;

        }

        private bool guardar()
        {
            bool retorno = true;
            try
            {

                Regex NombreFlujo = new Regex(@"^(?!Ejemplo: Grava 20mm$).{3,200}$");
                Match NombreFlujoValido = NombreFlujo.Match(textNombreFlujo.Texts);
                Regex Valor = new Regex(@"^[0-9]+(?:\.[0-9]+)?$");
                Match ValorValido = Valor.Match(textValor.Texts);



                if (comboProductoT.Text == "Producto*" || textNombreFlujo.Texts == "Ejemplo: Grava 20mm" || comboTipoFlujo.Text == "Tipo de flujo*"
                   || comboRecursos.Text == "Recursos*" || comboUnidades.Text == "Unidad*" || textValor.Texts == "Ejemplo: 0" || comboTratamiento.Text == "Tratamiento de dato*"
                   || comboAdquisicion.Text == "Adquisición de dato*")

                {
                    MessageBox.Show("No se han proporcionado algunos datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    retorno = false;
                }

                modeloListaProducto Produc = (modeloListaProducto)comboProductoT.SelectedItem;
                if (comboProductoT.Text == "Producto*")
                {
                    errorProvider1.SetError(comboProductoT, "Se necesita seleccionar un producto");
                    retorno = false;
                }
                else
                {
                    entradasSalidas.id_producto = Convert.ToInt32(Produc.id);
                    errorProvider1.SetError(comboProductoT, String.Empty);
                }

                if (NombreFlujoValido.Success)
                {
                    entradasSalidas.nombreFlujo = textNombreFlujo.Texts;
                    errorProvider1.SetError(textNombreFlujo, String.Empty);
                }
                else
                {
                    errorProvider1.SetError(textNombreFlujo, "Se necesita ingresar nombre del flujo");
                    retorno = false;
                }

                if (comboTipoFlujo.Text == "Tipo de flujo*")
                {
                    errorProvider1.SetError(comboTipoFlujo, "Se necesita seleccionar un tipo de flujo");
                    retorno = false;
                }
                else
                {
                    entradasSalidas.tipoFlujo = comboTipoFlujo.Text;
                    errorProvider1.SetError(comboTipoFlujo, String.Empty);
                }

                if (comboRecursos.Text == "Recursos*")
                {
                    errorProvider1.SetError(comboRecursos, "Se necesita seleccionar algun recurso");
                    retorno = false;
                }
                else
                {
                    entradasSalidas.recursos = comboRecursos.Text;
                    errorProvider1.SetError(comboRecursos, String.Empty);
                }

                if (comboEmisiones.Text == "Emisiones")
                {
                    entradasSalidas.emisiones = null;
                }
                else
                {
                    entradasSalidas.emisiones = comboEmisiones.Text;
                }

                if (comboUnidades.Text == "Unidad*")
                {
                    errorProvider1.SetError(comboUnidades, "Se necesita seleccionar una unidad");
                    retorno = false;
                }
                else
                {
                    entradasSalidas.unidad = comboUnidades.Text;
                    errorProvider1.SetError(comboUnidades, String.Empty);
                }

                if (ValorValido.Success)
                {
                    entradasSalidas.valor = textValor.Texts;
                    errorProvider1.SetError(textValor, String.Empty);
                }
                else
                {
                    errorProvider1.SetError(textValor, "Se necesita ingresar un valor");
                    retorno = false;
                }

                if (comboTratamiento.Text == "Tratamiento de dato*")
                {
                    errorProvider1.SetError(comboTratamiento, "Se necesita seleccionar un tratamiento de dato");
                    retorno = false;
                }
                else
                {
                    entradasSalidas.tratamientoDato = comboTratamiento.Text;
                    errorProvider1.SetError(comboTratamiento, String.Empty);
                }

                if (comboAdquisicion.Text == "Adquisición de dato*")
                {
                    errorProvider1.SetError(comboAdquisicion, "Se necesita seleccionar alguna adquisición del dato");
                    retorno = false;
                }
                else
                {
                    entradasSalidas.adquisicionDato = comboAdquisicion.Text;
                    errorProvider1.SetError(comboAdquisicion, String.Empty);
                }
                if (textCitas.Texts == "Ejemplo: “Manual del Ingeniero civil”")
                {
                    entradasSalidas.citaReferencia = null;
                }
                else
                {
                    entradasSalidas.citaReferencia = textCitas.Texts;
                }

                if (textComentario.Texts == "Ejemplo: Expreso este comentario")
                {
                    entradasSalidas.comentario = null;
                }
                else
                {
                    entradasSalidas.comentario = textComentario.Texts;
                }
                //Estos son los registros para la bitacora
                bitacora.operacion = operacionBi;
                bitacora.descripcionEvento = descripcionBi;
                bitacora.usuario = textNusuario.Text;
                if (retorno == true)
                {
                    //Actualiza a la fecha y hora para insertar en la bitacora
                    DateTime fechaActual = DateTime.Now;
                    bitacora.fecha = fechaActual;
                    controladorEntradas.InsertarEntradasSalidas(entradasSalidas);
                    controladorBitacora.InsertBitacora(bitacora);
                    MessageBox.Show("Registro guardado con éxito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    errorProvider1.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Inténtelo de nuevo, {ex.Message}");
            }
            return retorno;
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            guardar();
        }
    }
}
