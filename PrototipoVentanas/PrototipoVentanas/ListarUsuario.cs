using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoVentanas
{
    public partial class ListarUsuario : Form
    {
        public ListarUsuario()
        {
            InitializeComponent();
            CargarDG();
        }
        private void CargarDG()
        {
            dataGridView1.Columns.Add("nombre", "Nombre");
            dataGridView1.Columns.Add("apellido", "Apellido");
            dataGridView1.Columns.Add("direccion", "Direccion");
            dataGridView1.Columns.Add("email", "Email");
            dataGridView1.Columns.Add("telefono", "Telefono");


        }
    }
}
