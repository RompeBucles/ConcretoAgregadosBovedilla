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
    public partial class ListaEntradasSalidas : Form
    {
        public ListaEntradasSalidas()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("1", "Concreto simple,mecánico, f’c 200kg/cm2", "Cemento", "Elemento o Compuesto", "Emisiones - Emisiones al aire - Emisiones orgánicas al aire", "326", "Masa (kg)", "Calculado: basado en relaciones estequiométricos.", "Cuestionarios – Encuestas", "Bimsa Reports. Active cost Universe, Costos de construcción. Tecnhical Report, Mexico. 2", "MUY BIEN");
            dataGridView1.Rows.Add("1", "Concreto simple,mecánico, f’c 200kg/cm2", "agua", "Elemento o Compuesto", "Emisiones - Emisiones al aire - Emisiones orgánicas al aire", "900.8", "Masa (kg)", "Calculado: basado en relaciones estequiométricos.", "Cuestionarios – Encuestas", "Bimsa Reports. Active cost Universe, Costos de construcción. Tecnhical Report, Mexico. 2", "MUY BIEN");
            dataGridView1.Rows.Add("1", "Concreto simple,mecánico, f’c 200kg/cm2", "arena", "Elemento o Compuesto", "Emisiones - Emisiones al aire - Emisiones orgánicas al aire", "975", "Masa (kg)", "Calculado: basado en relaciones estequiométricos.", "Cuestionarios – Encuestas", "Bimsa Reports. Active cost Universe, Costos de construcción. Tecnhical Report, Mexico. 2", "MUY BIEN");
            dataGridView1.Rows.Add("1", "Concreto simple,mecánico, f’c 200kg/cm2", "Gasolina Magna", "Elemento o Compuesto", "Emisiones - Emisiones al aire - Emisiones orgánicas al aire", "242.4", "Masa (kg)", "Calculado: basado en relaciones estequiométricos.", "Cuestionarios – Encuestas", "Bimsa Reports. Active cost Universe, Costos de construcción. Tecnhical Report, Mexico. 2", "MUY BIEN");
            dataGridView1.Rows.Add("2", "Agregados, mina cielo abierto, grava y arena.", "Consumo eléctrico", "Elemento o Compuesto", "Emisiones - Emisiones al aire - Emisiones orgánicas al aire", "5.54", "Energia (kWh)", "Calculado: basado en relaciones estequiométricos.", "Cuestionarios – Encuestas", "Bimsa Reports. Active cost Universe, Costos de construcción. Tecnhical Report, Mexico. 2", "MUY BIEN");
            dataGridView1.Rows.Add("2", "Agregados, mina cielo abierto, grava y arena.", "Diesel", "Elemento o Compuesto", "Emisiones - Emisiones al aire - Emisiones orgánicas al aire", "454.54", "Volumen (m3)", "Calculado: basado en relaciones estequiométricos.", "Cuestionarios – Encuestas", "Bimsa Reports. Active cost Universe, Costos de construcción. Tecnhical Report, Mexico. 2", "MUY BIEN");
            dataGridView1.Rows.Add("2", "Agregados, mina cielo abierto, grava y arena.", "Dioxido de carbono", "Elemento o Compuesto", "Emisiones - Emisiones al aire - Emisiones orgánicas al aire", "484.54", "Masa (kg)", "Calculado: basado en relaciones estequiométricos.", "Cuestionarios – Encuestas", "Bimsa Reports. Active cost Universe, Costos de construcción. Tecnhical Report, Mexico. 2", "MUY BIEN");
            dataGridView1.Rows.Add("3", "Bovedilla, terminado en planta, 60x25x20cm", "Oxidos de nitrogeno", "Elemento o Compuesto", "Emisiones - Emisiones al aire - Emisiones orgánicas al aire", "582.54", "Masa (kg)", "Calculado: basado en relaciones estequiométricos.", "Cuestionarios – Encuestas", "Bimsa Reports. Active cost Universe, Costos de construcción. Tecnhical Report, Mexico. 2", "MUY BIEN");
            dataGridView1.Rows.Add("3", "Bovedilla, terminado en planta, 60x25x20cm", "PM10", "Elemento o Compuesto", "Emisiones - Emisiones al aire - Emisiones orgánicas al aire", "963", "Masa (kg)", "Calculado: basado en relaciones estequiométricos.", "Cuestionarios – Encuestas", "Bimsa Reports. Active cost Universe, Costos de construcción. Tecnhical Report, Mexico. 2", "MUY BIEN");
            dataGridView1.Rows.Add("3", "Bovedilla, terminado en planta, 60x25x20cm", "Dioxido de carbono", "Elemento o Compuesto", "Emisiones - Emisiones al aire - Emisiones orgánicas al aire", "952", "Masa (kg)", "Calculado: basado en relaciones estequiométricos.", "Cuestionarios – Encuestas", "Bimsa Reports. Active cost Universe, Costos de construcción. Tecnhical Report, Mexico. 2", "MUY BIEN");
            dataGridView1.Rows.Add("3", "Bovedilla, terminado en planta, 60x25x20cm2", "Transporte de materia prima", "Elemento o Compuesto", "Emisiones - Emisiones al aire - Emisiones orgánicas al aire", "12", "Masa (kg)", "Calculado: basado en relaciones estequiométricos.", "Cuestionarios – Encuestas", "Bimsa Reports. Active cost Universe, Costos de construcción. Tecnhical Report, Mexico. 2", "MUY BIEN");



        }

        private void btnSeleccionarT_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                row.Cells[11].Value = row.Cells[11].Value == null ? false : !(bool)row.Cells[11].Value;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
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
    }
}
