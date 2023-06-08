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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resut = MessageBox.Show("Usuario registrado", "Aviso", MessageBoxButtons.YesNo);
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
