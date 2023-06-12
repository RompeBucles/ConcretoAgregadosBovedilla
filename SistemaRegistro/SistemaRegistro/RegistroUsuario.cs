using SistemaRegistro.ConexionBD;
using SistemaRegistro.Controladores;
using SistemaRegistro.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRegistro
{
    public partial class RegistroUsuario : Form
    {
        private Conexion ConexionBD = new Conexion();
        modeloUsuarios usu = new modeloUsuarios();
        private Usuarios usuarios = new Usuarios();
        ControladorUsuario controladorUsuario = new ControladorUsuario();
        bool retorno = true;
        DataSet dsTabla;
        private SqlDataReader LeerFilas;
        private int valorSeleccionadoPerfil;
        public RegistroUsuario()
        {
            InitializeComponent();
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
            Regex Nombre = new Regex(@"^[A-Za-züÜáéíóúáéíóúÁÉÍÓÚÑñ]{3,50}$");
            Match NombreValido = Nombre.Match(textNombre.Texts);

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
            string ApellidoPPattern = @"^[A-Za-züÜáéíóúáéíóúÁÉÍÓÚÑñ]{3,50}$";
            bool ApellidoPValido = Regex.IsMatch(textApellidoP.Texts, ApellidoPPattern);

            if (!ApellidoPValido)
            {
                errorProvider1.SetError(textApellidoP, "Apellido paterno no válido");
                
            }
            else
            {
                errorProvider1.SetError(textApellidoP, String.Empty);
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
            if (textCorreo.Texts == " ejemplo@unam.org.mx")
            {
                textCorreo.Texts = "";
                textCorreo.ForeColor = Color.Black;
            }
        }

        private void textCorreo_Leave(object sender, EventArgs e)
        {
            if (textCorreo.Texts == "")
            {
                textCorreo.Texts = " ejemplo@unam.org.mx";
                errorProvider1.SetError(textCorreo, "Se necesita ingresar un correo");
                textCorreo.ForeColor = Color.Gray;
            }
            string emailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            bool isEmailValid = Regex.IsMatch(textCorreo.Texts, emailPattern);

            if (!isEmailValid)
            {
                errorProvider1.SetError(textCorreo, "Correo no válido");
            
            }
            else
            {
                errorProvider1.SetError(textCorreo, String.Empty);
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
            string telefonoPattern = @"^[0-9]{10,10}$";
            bool isTelefonoValid = Regex.IsMatch(textTelefono.Texts, telefonoPattern);

            if (!isTelefonoValid)
            {
                errorProvider1.SetError(textTelefono, "Teléfono no válido");
              
            }
            else
            {
                errorProvider1.SetError(textTelefono, String.Empty);
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
            string UsuarioPPattern = @"^[A-Za-züÜáéíóúáéíóúÁÉÍÓÚÑñ]{3,50}$";
            bool UsuarioValido = Regex.IsMatch(textUsuario.Texts, UsuarioPPattern);

            if (!UsuarioValido)
            {
                errorProvider1.SetError(textUsuario, "Usuario no válido");
              
            }
            else
            {
                errorProvider1.SetError(textUsuario, String.Empty);
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
        private bool valiUserName(string username)
        {
            List<ModeloListaUsuarios> lUsers = new ControladorListaUsuarios().obtenerListaUsuarios();

            int pos = lUsers.FindIndex(x => x.usuario == username);

            if (pos == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
           
            string NombrePattern = @"^[A-Za-züÜáéíóúáéíóúÁÉÍÓÚÑñ]{3,50}$";
            bool NombreValido = Regex.IsMatch(textNombre.Texts, NombrePattern);

            string ApellidoPPattern = @"^[A-Za-züÜáéíóúáéíóúÁÉÍÓÚÑñ]{3,50}$";
            bool ApellidoPValido = Regex.IsMatch(textApellidoP.Texts, ApellidoPPattern);

            string ApellidoMPattern = @"^[A-Za-züÜáéíóúáéíóúÁÉÍÓÚÑñ]{0,50}$";
            bool ApellidoMValido = Regex.IsMatch(textApellidoM.Texts, ApellidoMPattern);

            string emailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            bool isEmailValid = Regex.IsMatch(textCorreo.Texts, emailPattern);

            string telefonoPattern = @"^[0-9]{10,10}$";
            bool isTelefonoValid = Regex.IsMatch(textTelefono.Texts, telefonoPattern);

            string UsuarioPPattern = @"^[A-Za-züÜáéíóúáéíóúÁÉÍÓÚÑñ]{3,50}$";
            bool UsuarioValido = Regex.IsMatch(textUsuario.Texts, UsuarioPPattern);

            
            if (textNombre.Texts == "Ejemplo: Juan" || textApellidoP.Texts == "Ejemplo: Pérez" || textApellidoM.Texts == "Ejemplo: Hernández" || textCorreo.Texts == " ejemplo@unam.org.mx"
                || textTelefono.Texts == "Ejemplo: 2281144037" || textUsuario.Texts == "Ejemplo: jperez" || textPassword.Texts == "Contraseña*" || textConfPassword.Texts == "Contraseña*")
            {
                MessageBox.Show("Hay datos que aún no se han proporcionado");
                retorno = false;
            }

            if (!usuarios.textBoxEvent.validadContrasena(textPassword.Texts) || !usuarios.textBoxEvent.validadContrasena(textConfPassword.Texts))
            {
                errorProvider1.SetError(textPassword, "Ingrese una contraseña valida nota: Debe tener almenos 8 caracteres, una mayúscula, un número, un carácter especial");
                errorProvider1.SetError(textConfPassword, "Ingrese una contraseña valida");
                retorno = false;
            }
            if (!textPassword.Texts.Equals(textConfPassword.Texts))
            {
                errorProvider1.SetError(textPassword, "Las contraseña no coinciden");
                errorProvider1.SetError(textConfPassword, "Las contraseña no coinciden");
                retorno = false;
            }
            if (!valiUserName(textUsuario.Texts))
            {
                errorProvider1.SetError(textUsuario, "El usuario ya existe, intente con otro");
                retorno = false;
            }

            if (radioBtnAdmin.Checked)
            {
                valorSeleccionadoPerfil = 1;
            }
            else if (radioBtnUser.Checked)
            {
                valorSeleccionadoPerfil = 2;
            }
           
          
          
            usu.apellidoP = textApellidoP.Texts;
            usu.apellidoM = textApellidoM.Texts;
            usu.correo = textCorreo.Texts;
            usu.telefono = textTelefono.Texts;
            usu.usuario = textUsuario.Texts;
            usu.perfil = valorSeleccionadoPerfil;
          

            if (retorno == true)
            {
                string cadenaEncriptada = Encrypt.GetSHA256(textPassword.Texts.Trim());
                usu.contrasena = cadenaEncriptada;
                //controladorUsuario.InsertarUsuario(usu);
                MessageBox.Show("Usuario guardado con éxito");
                Limpiar();
                pbOcultar.ResetText();
                errorProvider1.Clear();
            }
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
