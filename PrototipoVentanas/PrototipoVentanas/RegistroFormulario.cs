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
    public partial class RegistroFormulario : Form
    {
        public RegistroFormulario()
        {
            InitializeComponent();
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

        private void buttonSiguienteP_Click(object sender, EventArgs e)
        {
            DialogResult resut = MessageBox.Show("Se necesita ingresar información en los campos obligatorios ", "Aviso", MessageBoxButtons.YesNo);
            if (resut == DialogResult.Yes)
            {

                tabControl1.SelectTab(Referencia);
            }
            else if (resut == DialogResult.No)
            {
                return;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

                // Establecer la imagen en el PictureBox
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }

        private void buttoAtrasP_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(Identificación);
        }

        private void buttonSiguenteS_Click(object sender, EventArgs e)
        {

            DialogResult resut = MessageBox.Show("Se necesita ingresar información en los campos obligatorios ", "Aviso", MessageBoxButtons.YesNo);
            if (resut == DialogResult.Yes)
            {
                tabControl1.SelectTab(Tecnología);
            }
            else if (resut == DialogResult.No)
            {
                return;
            }
        }

        private void buttonAtrasR_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(Referencia);
        }

        private void buttonSiguienteT_Click(object sender, EventArgs e)
        {

            DialogResult resut = MessageBox.Show("Se necesita ingresar información en los campos obligatorios ", "Aviso", MessageBoxButtons.YesNo);
            if (resut == DialogResult.Yes)
            {
                tabControl1.SelectTab(TiempoVálido);
            }
            else if (resut == DialogResult.No)
            {
                return;
            }
        }

        private void buttonAtrasTec_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(Tecnología);

        }

        private void buttonSiguienteC_Click(object sender, EventArgs e)
        {
            DialogResult resut = MessageBox.Show("Se necesita ingresar información en los campos obligatorios ", "Aviso", MessageBoxButtons.YesNo);
            if (resut == DialogResult.Yes)
            {
                tabControl1.SelectTab(Geografía);
            }
            else if (resut == DialogResult.No)
            {
                return;
            }
        }
    }
}
