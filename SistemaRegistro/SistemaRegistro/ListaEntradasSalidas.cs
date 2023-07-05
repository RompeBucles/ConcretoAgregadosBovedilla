using SistemaRegistro.Controladores;
using SistemaRegistro.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRegistro
{
    public partial class ListaEntradasSalidas : Form
    {
        DataTable dsTabla;
        //instancia de controldor entradas salidas
        controladorEntradasSalidas controladorEntradas = new controladorEntradasSalidas();
        //instancia del modelo {get; set;} 
        modeloBitacora bitacora = new modeloBitacora();
        //Instacia del controlador
        ControladorBitacora controladorBitacora = new ControladorBitacora();
        //instancia del modelo {get; set;} 
        modeloEntrdasSalidas entradasSalidas = new modeloEntrdasSalidas();
        private int id;

        public ListaEntradasSalidas(string usuario)
        {
            InitializeComponent();
            CargarDG();
            textNusuario.Text = usuario;
        }
        private void CargarDG()
        {
            dataGridView1.Columns.Clear();
            dsTabla = controladorEntradas.SeleccionarEntrasSalidas(); //La tabla se recarga con el procedimiento almacenado Seleccionar_Datos_User.
            dataGridView1.DataSource = dsTabla;
            //dataGridView1.ScrollBars = ScrollBars.None; //Desactivar ScrollBar del DataGridView

            dataGridView1.Columns[1].HeaderText = "Número de flujo";
            dataGridView1.Columns[2].HeaderText = "Producto Tecnología otro";
            dataGridView1.Columns[6].HeaderText = "Nombre de flujo";
            dataGridView1.Columns[7].HeaderText = "Tipo de flujo";
            dataGridView1.Columns[8].HeaderText = "Recursos";
            dataGridView1.Columns[9].HeaderText = "Emisiones";
            dataGridView1.Columns[10].HeaderText = "Valor";
            dataGridView1.Columns[11].HeaderText = "Unidades";
            dataGridView1.Columns[12].HeaderText = "Tratamiento del dato";
            dataGridView1.Columns[13].HeaderText = "Adquisición del dato";
            dataGridView1.Columns[14].HeaderText = "Citas-Referencias";
            dataGridView1.Columns[15].HeaderText = "Comentario";



            dataGridView1.Columns[0].Visible = false;//ID no visible
            dataGridView1.Columns[1].Visible = true;//Número de flujo
            dataGridView1.Columns[1].ReadOnly = true;//Número de flujo
            dataGridView1.Columns[2].Visible = true;//Producto Tecnología otro
            dataGridView1.Columns[2].ReadOnly = true;//Producto Tecnología otro
            dataGridView1.Columns[3].Visible = false;//producto
            dataGridView1.Columns[4].Visible = false;//tecnologia
            dataGridView1.Columns[5].Visible = false;//otro
            dataGridView1.Columns[6].Visible = true;//Nombre de flujo
            dataGridView1.Columns[6].ReadOnly = true;//Nombre de flujo
            dataGridView1.Columns[7].Visible = true;//Tipo de flujo 
            dataGridView1.Columns[7].ReadOnly = true;//Tipo de flujo
            dataGridView1.Columns[8].Visible = true;//Recursos 
            dataGridView1.Columns[8].ReadOnly = true;//Recursos
            dataGridView1.Columns[9].Visible = true;//Emisiones
            dataGridView1.Columns[9].ReadOnly = true;//Emisiones
            dataGridView1.Columns[10].Visible = true;//Valor 
            dataGridView1.Columns[10].ReadOnly = true;//Valor
            dataGridView1.Columns[11].Visible = true;//unidad 
            dataGridView1.Columns[11].ReadOnly = true;//unidad
            dataGridView1.Columns[12].Visible = true;//Unidades 
            dataGridView1.Columns[12].ReadOnly = true;//Unidades
            dataGridView1.Columns[13].Visible = true;//Tratamiento del dato 
            dataGridView1.Columns[13].ReadOnly = true;//Tratamiento del dato
            dataGridView1.Columns[14].Visible = true;//Citas-Referencias
            dataGridView1.Columns[14].ReadOnly = true;//Citas-Referencias 
            dataGridView1.Columns[15].Visible = true;//Comentario
            dataGridView1.Columns[15].ReadOnly = true;//Comentario 


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

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.HeaderText = "Eliminar";
            checkColumn.Name = "Eliminar";
            checkColumn.ReadOnly = false; // Permitir interacción del usuario
            dataGridView1.Columns.Add(checkColumn);

        }
        private void ListaEntradasSalidas_Load(object sender, EventArgs e)
        {
            CargarBotones();
            tabControl1.SetBounds(tabControl1.Left, tabControl1.Top, 768, 519);
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

                        comboProductoT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                        ComboTecno.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                        textOtro.Texts = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                        textNombreFlujo.Texts = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                        comboTipoFlujo.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                        comboRecursos.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                        comboEmisiones.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                        textValor.Texts = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                        comboUnidades.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                        comboTratamiento.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                        comboAdquisicion.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                        textCitas.Texts = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                        textComentario.Texts = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                        tabControl1.SelectedTab = EditarEntradas;

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Columna");
            }
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {

            tabControl1.SelectedTab = ListaEntradas;
            Limpiar();
            CargarDG();
            CargarBotones();
        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {


            if (e.ColumnIndex == 16 && e.RowIndex != -1)
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
        }
        private void btnSeleccionarT_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {
                    row.Cells[17].Value = row.Cells[17].Value == null ? false : !(bool)row.Cells[17].Value;
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
                //Variable para registrar en la bitacora
                string operacionBiE = "Baja";
                string descripcionBiE = "Eliminación de registro en estradas/salidas";
                DialogResult result = MessageBox.Show("¿Desea eliminar los elementos seleccionados?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    List<DataGridViewRow> filasEliminar = new List<DataGridViewRow>();
                    bool elementosSeleccionados = false;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        DataGridViewCheckBoxCell checkBoxCell = row.Cells[17] as DataGridViewCheckBoxCell;
                        if (checkBoxCell != null && checkBoxCell.Value != null)
                        {
                            bool isChecked = (bool)checkBoxCell.Value;

                            if (isChecked)
                            {
                                elementosSeleccionados = true;
                                int DatosID = Convert.ToInt32(row.Cells[0].Value); // Suponiendo que el ID del usuario está en la primera columna

                                controladorEntradas.EliminarEntradasSalidas(DatosID);                                                   // MessageBox.Show($"{usuarioID}");
                                // controladorUsuario.EliminarUsuario(usuarioID);
                                filasEliminar.Add(row);
                            }
                        }
                    }
                    //solcion 2
                    //this.Controls.Clear();
                    //this.InitializeComponent();
                    //CargarDG(); //Carga el DataGridView
                    //CargarBotones(); 

                    if (elementosSeleccionados)
                    {
                        foreach (DataGridViewRow rowEliminar in filasEliminar)
                        {
                            dataGridView1.Rows.Remove(rowEliminar);
                        }
                        //Estos son los registros para la bitacora
                        bitacora.operacion = operacionBiE;
                        bitacora.descripcionEvento = descripcionBiE;
                        bitacora.usuario = textNusuario.Text;
                        //Actualiza a la fecha y hora para insertar en la bitacora
                        DateTime fechaActualE = DateTime.Now;
                        bitacora.fecha = fechaActualE;
                        controladorBitacora.InsertBitacora(bitacora);
                        MessageBox.Show("Registro(s) elimado(s)", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Intenete de nuevo");

            }
        }

        private bool guardar()
        {
            //Variable para registrar en la bitacora
            string operacionBi = "Modificación";
            string descripcionBi = "Datos modificados en entradas/salidas";
            bool retorno = true;
            try
            {

                Regex NombreFlujo = new Regex(@"^(?!Ejemplo: Grava 20mm$).{3,200}$");
                Match NombreFlujoValido = NombreFlujo.Match(textNombreFlujo.Texts);
                Regex Valor = new Regex(@"^[0-9]+(?:\.[0-9]+)?$");
                Match ValorValido = Valor.Match(textValor.Texts);



                if (textNombreFlujo.Texts == "Ejemplo: Grava 20mm" || comboTipoFlujo.Text == "Tipo de flujo*"
                   || comboRecursos.Text == "Recursos*" || comboUnidades.Text == "Unidad*" || textValor.Texts == "Ejemplo: 0" || comboTratamiento.Text == "Tratamiento de dato*"
                   || comboAdquisicion.Text == "Adquisición de dato*")

                {
                    MessageBox.Show("No se han proporcionado algunos datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    retorno = false;
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
                    controladorEntradas.EditarEntradasSalidas(entradasSalidas, id);
                    controladorBitacora.InsertBitacora(bitacora);
                    MessageBox.Show("Registro modificado con éxito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    CargarDG();
                    CargarBotones(); //Se vuelven a generar los botónes.
                    errorProvider1.Clear();
                    tabControl1.SelectedTab = ListaEntradas;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Inténtelo de nuevo, {ex.Message}");
            }
            return retorno;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }
    }
}
