﻿using System;
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
        public Bitacora()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("Alta", "28/05/2023:17:05:02", "Registro formulario", "MarcoB");
            dataGridView1.Rows.Add("Modificación", "28/05/2023:17:05:02", "Registro Entradas / Salidas", "MarcoB");
            dataGridView1.Rows.Add("Baja", "28/05/2023:17:05:02", "Registro usuario", "MarcoB");
            dataGridView1.Rows.Add("Alta", "28/05/2023:17:05:02", "Formulario", "PepeJ");
            dataGridView1.Rows.Add("Alta", "28/05/2023:17:05:02", "Registro formulario", "MarcoB");
            dataGridView1.Rows.Add("Modificación", "28/05/2023:17:05:02", "Registro Entradas / Salidas", "MarcoB");
            dataGridView1.Rows.Add("Baja", "28/05/2023:17:05:02", "Registro usuario", "PepeJ");
            dataGridView1.Rows.Add("Alta", "28/05/2023:17:05:02", "Registro formulario", "MarcoB");
            dataGridView1.Rows.Add("Modificación", "28/05/2023:17:05:02", "Registro Entradas / Salidas", "MarcoB");
            dataGridView1.Rows.Add("Baja", "28/05/2023:17:05:02", "Registro usuario", "MarcoB");
            dataGridView1.Rows.Add("Alta", "28/05/2023:17:05:02", "Registro formulario", "MarcoB");
            dataGridView1.Rows.Add("Modificación", "28/05/2023:17:05:02", "Registro Entradas / MarcoB", "OmarSC");
            dataGridView1.Rows.Add("Baja", "28/05/2023:17:05:02", "Registro usuario", "OmarSC");
            dataGridView1.Rows.Add("Alta", "28/05/2023:17:05:02", "Registro formulario", "OmarSC");
            dataGridView1.Rows.Add("Modificación", "28/05/2023:17:05:02", "Registro Entradas / Salidas", "JuanP");
            dataGridView1.Rows.Add("Baja", "28/05/2023:17:05:02", "Registro usuario", "PepeJ");

            dataGridView1.Rows.Add("Alta", "28/05/2023:17:05:02", "Registro formulario", "PepeJ");
        }
    }
}
