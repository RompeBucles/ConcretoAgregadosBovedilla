using SistemaRegistro.Controladores;
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
    public partial class Bitacora : Form
    {
        ControladorBitacora controladorBitacora = new ControladorBitacora();
        DataTable dsTabla;
        public Bitacora()
        {
            InitializeComponent();
            CargarDG();
        }
        private void CargarDG()
        {
            dsTabla = controladorBitacora.SeleccionarDatosBitacora(); //La tabla se recarga con el procedimiento almacenado

            //int p = panel2.Width;

            dataGridView1.DataSource = dsTabla;
            //dataGridView1.ScrollBars = ScrollBars.None; //Desactivar ScrollBar del DataGridView


            dataGridView1.Columns[0].HeaderText = "Operación";
            dataGridView1.Columns[1].HeaderText = "Fecha y hora";
            dataGridView1.Columns[2].HeaderText = "Descripción del evento";
            dataGridView1.Columns[3].HeaderText = "Registros";
            dataGridView1.Columns[4].HeaderText = "Usuario";

            dataGridView1.Columns[0].Visible = true;//Operación
            dataGridView1.Columns[1].Visible = true;//Fecha y hora
            dataGridView1.Columns[2].Visible = true;//Descripción
            dataGridView1.Columns[3].Visible = true;//Registros
            dataGridView1.Columns[4].Visible = true;//Usuario

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Ajusta el ancho de las columnas según el contenido de las celdas
            dataGridView1.AutoResizeColumns();

        }
    }
}
