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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resut = MessageBox.Show("¿Desea eliminar los elementos seleccionados?", "Aviso", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
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
                row.Cells[6].Value = row.Cells[6].Value == null? false : !(bool)row.Cells[6].Value;
            }
        }
    }
}
