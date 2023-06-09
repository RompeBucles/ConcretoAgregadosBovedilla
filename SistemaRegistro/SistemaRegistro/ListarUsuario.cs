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
    public partial class ListarUsuario : Form
    {
        public ListarUsuario()
        {
            InitializeComponent();
            CargarDG();
            tabControl1.TabPages.Remove(VerUsuario);
        }
        private void CargarDG()
        {

            dataGridView1.Rows.Add("Omar Suárez Casas", "Administrador", "omar@gmail.com", "2281115", "OmarSC");
            dataGridView1.Rows.Add("Juan Ramirez Hernadez", "Usuario", "osdr@gmail.com", "22411755", "JuanSC");
            dataGridView1.Rows.Add("Pepe Ignacio Perez", "Usuario", "dsds@gmail.com", "78778", "PEPE");
            dataGridView1.Rows.Add("Mario Roberto Ochoa", "Usuario", "sfds@gmail.com", "7897252", "MarioR");
            dataGridView1.Rows.Add("Pedro Perez Hernadez", "Administrador", "sdf@gmail.com", "787778", "PedroPP");
            dataGridView1.Rows.Add("Ignacio Perez perez", "Usuario", "omar@gmail.com", "688686", "IgnacioPe");
            dataGridView1.Rows.Add("Omar Suárez Casas", "Usuario", "omar@gamail.com", "86868", "OmarSC");
            dataGridView1.Rows.Add("Pedro Perez Hernadez", "Administrador", "sdf@gmail.com", "787778", "PedroPP");
            dataGridView1.Rows.Add("Ignacio Perez perez", "Usuario", "omar@gmail.com", "688686", "IgnacioPe");
            dataGridView1.Rows.Add("Omar Suárez Casas", "Usuario", "omar@gamail.com", "86868", "OmarSC");
            dataGridView1.Rows.Add("Omar Suárez Casas", "Administrador", "omar@gmail.com", "2281115", "OmarSC");
            dataGridView1.Rows.Add("Juan Ramirez Hernadez", "Usuario", "osdr@gmail.com", "22411755", "JuanSC");
            dataGridView1.Rows.Add("Pepe Ignacio Perez", "Usuario", "dsds@gmail.com", "78778", "PEPE");
            dataGridView1.Rows.Add("Mario Roberto Ochoa", "Usuario", "sfds@gmail.com", "7897252", "MarioR");
            dataGridView1.Rows.Add("Omar Suárez Casas", "Administrador", "omar@gamail.com", "2281115", "OmarSC"); dataGridView1.Rows.Add("Omar Suárez Casas", "Administrador", "omar@gamail.com", "2281115", "OmarSC");
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

        private void button1_Click(object sender, EventArgs e)
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

        private void btnSeleccionT_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                row.Cells[6].Value = row.Cells[6].Value == null ? false : !(bool)row.Cells[6].Value;
            }
        }
    }
}
