using SistemaRegistro.ConexionBD;
using SistemaRegistro.Controladores;
using SistemaRegistro.Modelo;
using System;
using SistemaRegistro.Properties;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Runtime.ConstrainedExecution;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Data.Common;

namespace SistemaRegistro
{
    public partial class ListarUsuario : Form
    {
        //instacia controlados usuario
        ControladorUsuario controladorUsuario = new ControladorUsuario();
        //Instacia del controlador
        ControladorBitacora controladorBitacora = new ControladorBitacora();
        //instacia modelo usuario
        modeloUsuarios usu = new modeloUsuarios();
        //instancia del modelo {get; set;} 
        modeloBitacora bitacora = new modeloBitacora();
        private Usuarios usuarios = new Usuarios();
        DataTable dsTabla;
        //variable para guadar la información seleccionada del radio button
        private int valorSeleccionadoPerfil;
        //se declaro el id del usuario para guardar y posteriormente usarlo en procedimiento almacenado de modificar
        private int id;
        public ListarUsuario(string usuario)
        {

            InitializeComponent();
            //Asigna opciones a la lista desplegable
            List<string> estatus = new List<string>();
            estatus.Add("Activo");
            estatus.Add("Inactivo");
            comboEstatus.DataSource = estatus;
            textNusuario.Text = usuario;
        }
        private void CargarDG()
        {
            //Esta linea codigo es indispensablec corrige a la hora de cargar los datos del grid, no desplaza las columnas 
            dataGridView1.Columns.Clear();
            dsTabla = controladorUsuario.SeleccionarDatosUsuario(); //La tabla se recarga con el procedimiento almacenado Seleccionar_Datos_User.
            dataGridView1.DataSource = dsTabla;
            //dataGridView1.ScrollBars = ScrollBars.None; //Desactivar ScrollBar del DataGridView

            dataGridView1.Columns[1].HeaderText = "Nombre completo";
            dataGridView1.Columns[5].HeaderText = "Perfil";
            dataGridView1.Columns[6].HeaderText = "Correo";
            dataGridView1.Columns[7].HeaderText = "Teléfono";
            dataGridView1.Columns[8].HeaderText = "Usuario";
            dataGridView1.Columns[9].HeaderText = "Estatus";


            dataGridView1.Columns[0].Visible = false;//ID no visible
            dataGridView1.Columns[1].Visible = true;//Nombre completo
            dataGridView1.Columns[1].ReadOnly = true;//Nombre completo
            dataGridView1.Columns[2].Visible = false;//Nombre
            dataGridView1.Columns[3].Visible = false;//ApellidoP
            dataGridView1.Columns[4].Visible = false;//ApellidoM
            dataGridView1.Columns[5].Visible = true;//Cargo
            dataGridView1.Columns[5].ReadOnly = true;//Cargo
            dataGridView1.Columns[6].Visible = true;//correo
            dataGridView1.Columns[6].ReadOnly = true;//correo
            dataGridView1.Columns[7].Visible = true;//telefono
            dataGridView1.Columns[7].ReadOnly = true;//telefono
            dataGridView1.Columns[8].Visible = true;//usuario
            dataGridView1.Columns[8].ReadOnly = true;//usuario
            dataGridView1.Columns[9].Visible = true;//Estatus
            dataGridView1.Columns[9].ReadOnly = true;//Estatus


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Ajusta el ancho de las columnas según el contenido de las celdas
            dataGridView1.AutoResizeColumns();

        }
        private void CargarBotones()
        {
            // int p = panel2.Width;
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

        private void ListarUsuarios_Load(object sender, EventArgs e)
        {
            CargarDG();
            CargarBotones();
            tabControl1.SetBounds(tabControl1.Left, tabControl1.Top, 768, 519);
        }

        private void textNombre_Enter(object sender, EventArgs e)
        {
            if (textNombre.Texts == "Ejemplo: Juan")
            {
                textNombre.Texts = "";
                textNombre.ForeColor = Color.Black;
            }
        }

        private void textNombre_Leave(object sender, EventArgs e)
        {
            if (textNombre.Texts == "")
            {
                textNombre.Texts = "Ejemplo: Juan";
                errorProvider1.SetError(textNombre, "Se necesita ingresar un nombre");
                textNombre.ForeColor = Color.Gray;
            }
        }

        private void textApellidoP_Enter(object sender, EventArgs e)
        {
            if (textApellidoP.Texts == "Ejemplo: Pérez")
            {
                textApellidoP.Texts = "";
                textApellidoP.ForeColor = Color.Black;
            }
        }

        private void textApellidoP_Leave(object sender, EventArgs e)
        {
            if (textApellidoP.Texts == "")
            {
                textApellidoP.Texts = "Ejemplo: Pérez";
                errorProvider1.SetError(textApellidoP, "Se necesita ingresar el apellido paterno");
                textApellidoP.ForeColor = Color.Gray;
            }
        }
        private void textApellidoM_Enter(object sender, EventArgs e)
        {
            if (textApellidoM.Texts == "Ejemplo: Hernández")
            {
                textApellidoM.Texts = "";
                textApellidoM.ForeColor = Color.Black;
            }
        }
        private void textApellidoM_Leave(object sender, EventArgs e)
        {
            if (textApellidoM.Texts == "")
            {
                textApellidoM.Texts = "Ejemplo: Hernández";
                textApellidoM.ForeColor = Color.Gray;
            }
        }
        private void textApelldioM_KeyPress(object sender, KeyPressEventArgs e)
        {
            usuarios.textBoxEvent.textKeyPress(e);
        }
        private void textCorreo_Enter(object sender, EventArgs e)
        {
            if (textCorreo.Texts == "ejemplo@unam.org.mx")
            {
                textCorreo.Texts = "";
                textCorreo.ForeColor = Color.Black;
            }
        }

        private void textCorreo_Leave(object sender, EventArgs e)
        {
            if (textCorreo.Texts == "")
            {
                textCorreo.Texts = "ejemplo@unam.org.mx";
                errorProvider1.SetError(textCorreo, "Se necesita ingresar un correo");
                textCorreo.ForeColor = Color.Gray;
            }
        }

        private void textTelefono_Enter(object sender, EventArgs e)
        {
            if (textTelefono.Texts == "Ejemplo: 2281144037")
            {
                textTelefono.Texts = "";
                textTelefono.ForeColor = Color.Black;
            }
        }

        private void textTelefono_Leave(object sender, EventArgs e)
        {
            if (textTelefono.Texts == "")
            {
                textTelefono.Texts = "Ejemplo: 2281144037";
                errorProvider1.SetError(textTelefono, "Se necesita ingresar un teléfono, nota: Debe de tener 10 dígitos");
                textTelefono.ForeColor = Color.Gray;
            }
        }

        private void textUsuario_Enter(object sender, EventArgs e)
        {
            if (textUsuario.Texts == "Ejemplo: jperez")
            {
                textUsuario.Texts = "";
                textUsuario.ForeColor = Color.Black;
            }
        }

        private void textUsuario_Leave(object sender, EventArgs e)
        {
            if (textUsuario.Texts == "")
            {
                textUsuario.Texts = "Ejemplo: jperez";
                errorProvider1.SetError(textUsuario, "Se necesita ingresar un usuario");
                textUsuario.ForeColor = Color.Gray;
            }
        }

        private void textPassword_Enter(object sender, EventArgs e)
        {
            if (textPassword.Texts == "Contraseña*")
            {
                textPassword.Texts = "";
                textPassword.ForeColor = Color.Black;
            }
        }

        private void textPassword_Leave(object sender, EventArgs e)
        {
            if (textPassword.Texts == "")
            {
                textPassword.Texts = "Contraseña*";
                textPassword.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(textPassword, String.Empty);
            }
        }

        private void textConfPassword_Enter(object sender, EventArgs e)
        {
            if (textConfPassword.Texts == "Contraseña*")
            {
                textConfPassword.Texts = "";
                textConfPassword.ForeColor = Color.Black;
            }
        }

        private void textConfPassword_Leave(object sender, EventArgs e)
        {
            if (textConfPassword.Texts == "")
            {
                textConfPassword.Texts = "Contraseña*";
                textConfPassword.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError(textConfPassword, String.Empty);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Variable para registrar en la bitacora
                string operacionBiE = "Baja";
                string descripcionBiE = "Inhabilitación de usuario";
                DialogResult result = MessageBox.Show("¿Desea eliminar los elementos seleccionados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    List<DataGridViewRow> filasEliminar = new List<DataGridViewRow>();
                    bool elementosSeleccionados = false;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        DataGridViewCheckBoxCell checkBoxCell = row.Cells[11] as DataGridViewCheckBoxCell;
                        if (checkBoxCell != null && checkBoxCell.Value != null)
                        {
                            bool isChecked = (bool)checkBoxCell.Value;

                            if (isChecked)
                            {
                                elementosSeleccionados = true;
                                int usuarioID = Convert.ToInt32(row.Cells[0].Value); // Suponiendo que el ID del usuario está en la primera columna

                                controladorUsuario.EliminarUsuario(usuarioID);
                                //MessageBox.Show($"{usuarioID}");
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
                            // dataGridView1.Rows.Remove(rowEliminar);
                            CargarDG(); //Carga el DataGridView
                            CargarBotones();
                        }
                        //Estos son los registros para la bitacora
                        bitacora.operacion = operacionBiE;
                        bitacora.descripcionEvento = descripcionBiE;
                        bitacora.usuario = textNusuario.Text;
                        //Actualiza a la fecha y hora para insertar en la bitacora
                        DateTime fechaActualE = DateTime.Now;
                        bitacora.fecha = fechaActualE;
                        controladorBitacora.InsertBitacora(bitacora);
                        MessageBox.Show("Registro(s) inhabilitado(s)", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnSeleccionT_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 1; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[11].Value = dataGridView1.Rows[i].Cells[11].Value == null ? false : !(bool)dataGridView1.Rows[i].Cells[11].Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Intente de nuevo");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar") //Si la celda contiene el nombre Editar procedera a entrar en la condición.
                {
                    if (dataGridView1.SelectedRows.Count > 0) //Si hay mas de 0 filas entonces procedera a ejecutar el siguiente codigo.
                    {
                        string perfil = dataGridView1.CurrentRow.Cells[5].Value.ToString();

                        if (perfil == "Administrador")
                        {
                            radioBtnAdmin.Checked = true;
                        }
                        else if (perfil == "Usuario")
                        {
                            radioBtnUser.Checked = true;
                        }
                        //Manda a llamar todos los datos del Usuario a la otra pantalla para proceder a su correspondiente edición
                        id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        textNombre.Texts = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        textApellidoP.Texts = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                        textApellidoM.Texts = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                        textCorreo.Texts = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                        textTelefono.Texts = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                        textUsuario.Texts = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                        comboEstatus.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

                        tabControl1.SelectedTab = EditarUsuarios;

                    }
                }
                if (e.ColumnIndex == 11 && e.RowIndex != 0)
                {
                    var cell = dataGridView1[e.ColumnIndex, e.RowIndex] as DataGridViewCheckBoxCell;
                    if (cell != null)
                    {
                        if (cell.Value != null && cell.Value is bool currentValue)
                        {
                            cell.Value = !currentValue;
                            dataGridView1.EndEdit(); // Finalizar la edición de la celda
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Columna");
            }
        }
        private void Limpiar()
        {
            textNombre.Texts = "Ejemplo: Juan";
            textNombre.ForeColor = Color.Gray;
            textApellidoP.Texts = "Ejemplo: Pérez";
            textApellidoP.ForeColor = Color.Gray;
            textApellidoM.Texts = "Ejemplo: Hernández";
            textApellidoM.ForeColor = Color.Gray;
            textCorreo.Texts = " ejemplo@unam.org.mx";
            textCorreo.ForeColor = Color.Gray;
            textTelefono.Texts = "Ejemplo: 2281144037";
            textTelefono.ForeColor = Color.Gray;
            textUsuario.Texts = "Ejemplo: jperez";
            textUsuario.ForeColor = Color.Gray;
            textPassword.Texts = "Contraseña*";
            textPassword.ForeColor = Color.Gray;
            textConfPassword.Texts = "Contraseña*";
            textConfPassword.ForeColor = Color.Gray;

        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {


            if (e.ColumnIndex == 10 && e.RowIndex != -1)  // Se verifica que sea la columna 10 y no sea el encabezado
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCancelar_Mod_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            tabControl1.SelectedTab = ListaUsuario;
            textNombre.ForeColor = Color.Black;
            textApellidoP.ForeColor = Color.Black;
            textApellidoM.ForeColor = Color.Black;
            textCorreo.ForeColor = Color.Black;
            textTelefono.ForeColor = Color.Black;
            textUsuario.ForeColor = Color.Black;
            comboEstatus.ForeColor = Color.Black;
        }

        private bool guardar()
        {
            //Variable para registrar en la bitacora
            string operacionBi = "Modificación";
            string descripcionBi = "Datos modificados de un usuario";
            bool retorno = true;

            try
            {

                Regex Nombre = new Regex(@"^[A-Za-züÜáéíóúáéíóúÁÉÍÓÚÑñ]{3,50}$");
                Match NombreValido = Nombre.Match(textNombre.Texts);
                Regex ApellidoP = new Regex(@"^[A-Za-züÜáéíóúáéíóúÁÉÍÓÚÑñ]{3,50}$");
                Match ApellidoPValido = ApellidoP.Match(textApellidoP.Texts);
                Regex email = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
                Match isEmailValid = email.Match(textCorreo.Texts);
                Regex telefono = new Regex(@"^[0-9]{10,10}$");
                Match isTelefonoValid = telefono.Match(textTelefono.Texts);
                Regex Usuario = new Regex(@"^[A-Za-züÜáéíóúáéíóúÁÉÍÓÚÑñ]{3,50}$");
                Match UsuarioValido = Usuario.Match(textUsuario.Texts);
                Regex Contra = new Regex(@"^(?=.*[A-Z])(?=.*\d)(?=.*[^A-Za-z0-9]).{8,}$");
                Match ContraValido = Contra.Match(textPassword.Texts);


                if (textNombre.Texts == "Ejemplo: Juan" || textApellidoP.Texts == "Ejemplo: Pérez" || textCorreo.Texts == " ejemplo@unam.org.mx"
                    || textTelefono.Texts == "Ejemplo: 2281144037")
                {
                    MessageBox.Show("Campos faltantes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    retorno = false;
                }
                if (NombreValido.Success)
                {
                    usu.nombre = textNombre.Texts;
                    errorProvider1.SetError(textNombre, String.Empty);
                }
                else
                {
                    errorProvider1.SetError(textNombre, "Nombre no válido");
                    retorno = false;
                }
                if (ApellidoPValido.Success)
                {
                    usu.apellidoP = textApellidoP.Texts;
                    errorProvider1.SetError(textApellidoP, String.Empty);
                }
                else
                {
                    errorProvider1.SetError(textApellidoP, "Apellido paterno no válido");
                    retorno = false;
                }
                if (textApellidoM.Texts == "Ejemplo: Hernández")
                {
                    usu.apellidoM = null;
                }
                else
                {
                    usu.apellidoM = textApellidoM.Texts;
                }
                if (isEmailValid.Success)
                {
                    usu.correo = textCorreo.Texts;
                    errorProvider1.SetError(textCorreo, String.Empty);
                }
                else
                {
                    errorProvider1.SetError(textCorreo, "Correo no válido");
                    retorno = false;
                }
                if (isTelefonoValid.Success)
                {
                    usu.telefono = textTelefono.Texts;
                    errorProvider1.SetError(textTelefono, String.Empty);
                }
                else
                {
                    errorProvider1.SetError(textTelefono, "Teléfono no válido");
                    retorno = false;
                }
                if (UsuarioValido.Success)
                {
                    usu.usuario = textUsuario.Texts;
                    errorProvider1.SetError(textUsuario, String.Empty);
                }
                else
                {
                    errorProvider1.SetError(textUsuario, "Usuario no válido");
                }

                if (textPassword.Texts == "Contraseña*")
                {

                }
                else
                {
                    // Verificar si se ha ingresado una nueva contraseña
                    if (textPassword.Texts != "Contraseña*")
                    {
                        if (ContraValido.Success)
                        {
                            usu.contrasena = textPassword.Texts;
                            errorProvider1.SetError(textPassword, String.Empty);
                        }
                        else
                        {
                            errorProvider1.SetError(textPassword, "Ingrese una contraseña válida nota: Debe tener al menos 8 caracteres, al menos una mayúscula, al menos número, al menos carácter especial");
                            retorno = false;
                        }

                        if (!textPassword.Texts.Equals(textConfPassword.Texts))
                        {
                            errorProvider1.SetError(textPassword, "Las contraseñas no coinciden");
                            errorProvider1.SetError(textConfPassword, "Las contraseñas no coinciden");
                            retorno = false;
                        }
                        else
                        {
                            usu.contrasena = Encrypt.GetSHA256(textPassword.Texts.Trim());
                            errorProvider1.SetError(textConfPassword, String.Empty);
                        }
                    }
                }

                if (radioBtnAdmin.Checked)
                {
                    valorSeleccionadoPerfil = 1;
                }
                else if (radioBtnUser.Checked)
                {
                    valorSeleccionadoPerfil = 2;
                }
                //son campos no obligatorios se asignan sin condicional
                usu.perfil = valorSeleccionadoPerfil;
                usu.estatus = comboEstatus.Text;
                //Estos son los registros para la bitacora
                bitacora.operacion = operacionBi;
                bitacora.descripcionEvento = descripcionBi;
                bitacora.usuario = textNusuario.Text;

                if (retorno == true)
                {
                    //Actualiza a la fecha y hora para insertar en la bitacora
                    DateTime fechaActual = DateTime.Now;
                    bitacora.fecha = fechaActual;
                    controladorUsuario.EditarUsuario(usu, id);
                    controladorBitacora.InsertBitacora(bitacora);
                    MessageBox.Show("Usuario modificado con éxito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabControl1.SelectedTab = ListaUsuario;
                    Limpiar();
                    CargarDG();
                    CargarBotones(); //Se vuelven a generar los botónes.



                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Inténtelo de nuevo, {ex.Message}");
            }
            return retorno;
        }

        private void buttonGuardar_Mod_Click(object sender, EventArgs e)
        {
            guardar();
        }
        private void pbMostrar_Click(object sender, EventArgs e)
        {
            pbOcultar.BringToFront();
            textPassword.PasswordChar = false;
        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            pbMostrar.BringToFront();
            textPassword.PasswordChar = true;
        }

        private void pbMostrar1_Click(object sender, EventArgs e)
        {
            pbOcultar1.BringToFront();
            textConfPassword.PasswordChar = false;
        }

        private void pbOcultar1_Click(object sender, EventArgs e)
        {
            pbMostrar1.BringToFront();
            textConfPassword.PasswordChar = true;
        }
    }
}
