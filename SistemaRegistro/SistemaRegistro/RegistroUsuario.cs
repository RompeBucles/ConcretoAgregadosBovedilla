using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRegistro
{
    public partial class RegistroUsuario : Form
    {
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
                textPassword.ForeColor = Color.Black;
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
                textConfPassword.ForeColor = Color.Black;
            }
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            DialogResult resut = MessageBox.Show("Usuario registrado", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
