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

        private void ButtonGuardar_Mod_Click(object sender, EventArgs e)
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
        /*
        private void ComboBoxUno_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDos.Enabled = false;
            comboBoxTres.Enabled = false;
            comboBoxCuatro.Enabled = false;
            comboBoxCinco.Enabled = false;
            comboBoxSeis.Enabled = false;
            comboBoxSiete.Enabled = false;
        }

        private void ComboBoxDos_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxUno.Enabled = false;
            comboBoxTres.Enabled = false;
            comboBoxCuatro.Enabled = false;
            comboBoxCinco.Enabled = false;
            comboBoxSeis.Enabled = false;
            comboBoxSiete.Enabled = false;
        }

        private void ComboBoxTres_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxUno.Enabled = false;
            comboBoxDos.Enabled = false;
            comboBoxCuatro.Enabled = false;
            comboBoxCinco.Enabled = false;
            comboBoxSeis.Enabled = false;
            comboBoxSiete.Enabled = false;
        }

        private void ComboBoxCuatro_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxUno.Enabled = false;
            comboBoxDos.Enabled = false;
            comboBoxTres.Enabled = false;
            comboBoxCinco.Enabled = false;
            comboBoxSeis.Enabled = false;
            comboBoxSiete.Enabled = false;
        }

        private void ComboBoxCinco_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxUno.Enabled = false;
            comboBoxDos.Enabled = false;
            comboBoxTres.Enabled = false;
            comboBoxCuatro.Enabled = false;
            comboBoxSeis.Enabled = false;
            comboBoxSiete.Enabled = false;
        }

        private void ComboBoxSeis_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxUno.Enabled = false;
            comboBoxDos.Enabled = false;
            comboBoxTres.Enabled = false;
            comboBoxCuatro.Enabled = false;
            comboBoxCinco.Enabled = false;
            comboBoxSiete.Enabled = false;
        }

        private void ComboBoxSiete_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxUno.Enabled = false;
            comboBoxDos.Enabled = false;
            comboBoxTres.Enabled = false;
            comboBoxCuatro.Enabled = false;
            comboBoxCinco.Enabled = false;
            comboBoxSeis.Enabled = false;
        }
        */
        
        private void Button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(Identificación);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(Tecnología);
        }
    }
}

