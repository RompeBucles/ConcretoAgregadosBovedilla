﻿namespace SistemaRegistro
{
    partial class ListaFormulario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tabControl2 = new TabControl();
            ListaDatos = new TabPage();
            btnExportarCSV = new Button();
            dataGridView1 = new DataGridView();
            btnSeleccionarT = new Button();
            btnExportarPDF = new Button();
            btnBorrar = new Button();
            Identificación = new TabPage();
            panel1 = new Panel();
            comboEstatus = new ComboBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            textBox5 = new Templates.TextBox();
            label12 = new Label();
            button8 = new Button();
            textProceso = new Templates.TextBox();
            label4 = new Label();
            comboSeis = new ComboBox();
            comboCinco = new ComboBox();
            comboCuatro = new ComboBox();
            comboTres = new ComboBox();
            comboDos = new ComboBox();
            comboUno = new ComboBox();
            label2 = new Label();
            buttonSiguienteP = new Button();
            textBox1 = new Templates.TextBox();
            label1 = new Label();
            textBox2 = new Templates.TextBox();
            ComboProducto = new ComboBox();
            ComboTecno = new ComboBox();
            textOtro = new Templates.TextBox();
            labelUsuario = new Label();
            Referencia = new TabPage();
            panel4 = new Panel();
            button2 = new Button();
            label13 = new Label();
            label19 = new Label();
            label18 = new Label();
            button7 = new Button();
            button6 = new Button();
            buttoAtrasP = new Button();
            buttonSiguenteS = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button5 = new Button();
            comboLimitesSistema = new ComboBox();
            textObjetivoR = new Templates.TextBox();
            comboUnidadUno = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            textUnidadFuncional = new Templates.TextBox();
            textBox7 = new Templates.TextBox();
            label3 = new Label();
            Tecnología = new TabPage();
            panel2 = new Panel();
            label20 = new Label();
            buttonAtrasR = new Button();
            buttonSiguienteT = new Button();
            textBox3 = new Templates.TextBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            TiempoVálido = new TabPage();
            panel3 = new Panel();
            label21 = new Label();
            label9 = new Label();
            label8 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            buttonAtrasTec = new Button();
            buttonSiguienteC = new Button();
            textBox4 = new Templates.TextBox();
            label7 = new Label();
            Geografía = new TabPage();
            panel5 = new Panel();
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            button1 = new Button();
            panel7 = new Panel();
            panel6 = new Panel();
            label11 = new Label();
            trackZoom = new TrackBar();
            buttonGuardarG = new Button();
            dataGridView2 = new DataGridView();
            comboBox4 = new ComboBox();
            comboBox2 = new ComboBox();
            label10 = new Label();
            VerImagen = new TabPage();
            panel8 = new Panel();
            btnAtrasIma = new Button();
            pictureBox2 = new PictureBox();
            label22 = new Label();
            tabControl2.SuspendLayout();
            ListaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Identificación.SuspendLayout();
            panel1.SuspendLayout();
            Referencia.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            Tecnología.SuspendLayout();
            panel2.SuspendLayout();
            TiempoVálido.SuspendLayout();
            panel3.SuspendLayout();
            Geografía.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackZoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            VerImagen.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl2
            // 
            tabControl2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl2.Controls.Add(ListaDatos);
            tabControl2.Controls.Add(Identificación);
            tabControl2.Controls.Add(Referencia);
            tabControl2.Controls.Add(Tecnología);
            tabControl2.Controls.Add(TiempoVálido);
            tabControl2.Controls.Add(Geografía);
            tabControl2.Controls.Add(VerImagen);
            tabControl2.Location = new Point(6, 5);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(763, 518);
            tabControl2.TabIndex = 24;
            // 
            // ListaDatos
            // 
            ListaDatos.BackColor = Color.FromArgb(242, 230, 230);
            ListaDatos.Controls.Add(btnExportarCSV);
            ListaDatos.Controls.Add(dataGridView1);
            ListaDatos.Controls.Add(btnSeleccionarT);
            ListaDatos.Controls.Add(btnExportarPDF);
            ListaDatos.Controls.Add(btnBorrar);
            ListaDatos.Location = new Point(4, 24);
            ListaDatos.Name = "ListaDatos";
            ListaDatos.Size = new Size(755, 490);
            ListaDatos.TabIndex = 5;
            ListaDatos.Text = "Lista Datos";
            // 
            // btnExportarCSV
            // 
            btnExportarCSV.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExportarCSV.BackColor = Color.FromArgb(190, 31, 36);
            btnExportarCSV.FlatAppearance.BorderSize = 0;
            btnExportarCSV.FlatStyle = FlatStyle.Flat;
            btnExportarCSV.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportarCSV.ForeColor = SystemColors.ButtonFace;
            btnExportarCSV.Location = new Point(258, 445);
            btnExportarCSV.Name = "btnExportarCSV";
            btnExportarCSV.Size = new Size(151, 39);
            btnExportarCSV.TabIndex = 74;
            btnExportarCSV.Text = "Exportar como CSV";
            btnExportarCSV.UseVisualStyleBackColor = false;
            btnExportarCSV.Click += btnExportarCSV_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.FromArgb(242, 230, 230);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(756, 420);
            dataGridView1.TabIndex = 73;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            dataGridView1.RowPostPaint += dataGridView1_RowPostPaint;
            // 
            // btnSeleccionarT
            // 
            btnSeleccionarT.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSeleccionarT.BackColor = Color.FromArgb(190, 31, 36);
            btnSeleccionarT.FlatAppearance.BorderSize = 0;
            btnSeleccionarT.FlatStyle = FlatStyle.Flat;
            btnSeleccionarT.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSeleccionarT.ForeColor = SystemColors.ButtonFace;
            btnSeleccionarT.Location = new Point(427, 445);
            btnSeleccionarT.Name = "btnSeleccionarT";
            btnSeleccionarT.Size = new Size(151, 39);
            btnSeleccionarT.TabIndex = 72;
            btnSeleccionarT.Text = "Seleccionar todo";
            btnSeleccionarT.UseVisualStyleBackColor = false;
            btnSeleccionarT.Click += btnSeleccionarT_Click;
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExportarPDF.BackColor = Color.FromArgb(190, 31, 36);
            btnExportarPDF.FlatAppearance.BorderSize = 0;
            btnExportarPDF.FlatStyle = FlatStyle.Flat;
            btnExportarPDF.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportarPDF.ForeColor = SystemColors.ButtonFace;
            btnExportarPDF.Location = new Point(92, 445);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(151, 39);
            btnExportarPDF.TabIndex = 71;
            btnExportarPDF.Text = "Exportar como PDF";
            btnExportarPDF.UseVisualStyleBackColor = false;
            btnExportarPDF.Visible = false;
            btnExportarPDF.Click += btnExportarPDF_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBorrar.BackColor = Color.FromArgb(190, 31, 36);
            btnBorrar.FlatAppearance.BorderSize = 0;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrar.ForeColor = SystemColors.ButtonFace;
            btnBorrar.Location = new Point(600, 445);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(151, 39);
            btnBorrar.TabIndex = 70;
            btnBorrar.Text = "Borra Selección";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Identificación
            // 
            Identificación.AutoScroll = true;
            Identificación.BackColor = Color.FromArgb(242, 230, 230);
            Identificación.Controls.Add(panel1);
            Identificación.Location = new Point(4, 24);
            Identificación.Name = "Identificación";
            Identificación.Padding = new Padding(3);
            Identificación.Size = new Size(755, 490);
            Identificación.TabIndex = 0;
            Identificación.Text = "Identificación";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(242, 230, 230);
            panel1.Controls.Add(comboEstatus);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(textProceso);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboSeis);
            panel1.Controls.Add(comboCinco);
            panel1.Controls.Add(comboCuatro);
            panel1.Controls.Add(comboTres);
            panel1.Controls.Add(comboDos);
            panel1.Controls.Add(comboUno);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonSiguienteP);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(ComboProducto);
            panel1.Controls.Add(ComboTecno);
            panel1.Controls.Add(textOtro);
            panel1.Controls.Add(labelUsuario);
            panel1.Location = new Point(-192, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 747);
            panel1.TabIndex = 76;
            // 
            // comboEstatus
            // 
            comboEstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEstatus.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboEstatus.ForeColor = Color.FromArgb(97, 97, 96);
            comboEstatus.FormattingEnabled = true;
            comboEstatus.Items.AddRange(new object[] { "Vigente", "No vigente" });
            comboEstatus.Location = new Point(-14, 58);
            comboEstatus.Name = "comboEstatus";
            comboEstatus.Size = new Size(172, 24);
            comboEstatus.TabIndex = 112;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.None;
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.FromArgb(190, 31, 36);
            label17.Location = new Point(525, 934);
            label17.Name = "label17";
            label17.Size = new Size(130, 16);
            label17.TabIndex = 111;
            label17.Text = "Correo electrónico*";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(190, 31, 36);
            label16.Location = new Point(268, 591);
            label16.Name = "label16";
            label16.Size = new Size(77, 16);
            label16.TabIndex = 110;
            label16.Text = "Autor ACV*";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(190, 31, 36);
            label15.Location = new Point(18, 150);
            label15.Name = "label15";
            label15.Size = new Size(140, 16);
            label15.TabIndex = 109;
            label15.Text = "Nombre del proceso*";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(190, 31, 36);
            label14.Location = new Point(504, 83);
            label14.Name = "label14";
            label14.Size = new Size(39, 16);
            label14.TabIndex = 108;
            label14.Text = "Otro*";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.BackColor = SystemColors.Control;
            textBox5.BorderColor = SystemColors.ControlDarkDark;
            textBox5.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textBox5.BorderSize = 2;
            textBox5.ForeColor = Color.DimGray;
            textBox5.Location = new Point(525, 951);
            textBox5.Multiline = false;
            textBox5.Name = "textBox5";
            textBox5.Padding = new Padding(7);
            textBox5.PasswordChar = false;
            textBox5.Size = new Size(191, 30);
            textBox5.TabIndex = 98;
            textBox5.Texts = "ejemplo@unam.gob.mx";
            textBox5.UnderlinedStyle = true;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(249, 22);
            label12.Name = "label12";
            label12.Size = new Size(111, 19);
            label12.TabIndex = 97;
            label12.Text = "Identificación";
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.None;
            button8.BackColor = Color.FromArgb(190, 31, 36);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ButtonFace;
            button8.Location = new Point(565, 1002);
            button8.Name = "button8";
            button8.Size = new Size(115, 35);
            button8.TabIndex = 96;
            button8.Text = "Siguiente";
            button8.UseVisualStyleBackColor = false;
            // 
            // textProceso
            // 
            textProceso.Anchor = AnchorStyles.None;
            textProceso.BackColor = SystemColors.Control;
            textProceso.BorderColor = SystemColors.ControlDarkDark;
            textProceso.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textProceso.BorderSize = 2;
            textProceso.ForeColor = Color.DimGray;
            textProceso.Location = new Point(18, 169);
            textProceso.Multiline = false;
            textProceso.Name = "textProceso";
            textProceso.Padding = new Padding(7);
            textProceso.PasswordChar = false;
            textProceso.Size = new Size(219, 30);
            textProceso.TabIndex = 95;
            textProceso.Texts = "Ejemplo: Elaboración de concreto simple";
            textProceso.UnderlinedStyle = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(263, 301);
            label4.Name = "label4";
            label4.Size = new Size(214, 16);
            label4.TabIndex = 91;
            label4.Text = "Solo puede elegir una sola lista*";
            // 
            // comboSeis
            // 
            comboSeis.Anchor = AnchorStyles.None;
            comboSeis.FormattingEnabled = true;
            comboSeis.Items.AddRange(new object[] { "Consumo de productos", "Uso de productos que consumen energía", "Otros usos y consumos" });
            comboSeis.Location = new Point(488, 400);
            comboSeis.Name = "comboSeis";
            comboSeis.Size = new Size(232, 23);
            comboSeis.TabIndex = 89;
            comboSeis.Text = "Uso y consumo*";
            // 
            // comboCinco
            // 
            comboCinco.Anchor = AnchorStyles.None;
            comboCinco.FormattingEnabled = true;
            comboCinco.Items.AddRange(new object[] { "Carretera", "Ferrocarril", "Agua", "Aire", "Otros transportes" });
            comboCinco.Location = new Point(243, 400);
            comboCinco.Name = "comboCinco";
            comboCinco.Size = new Size(228, 23);
            comboCinco.TabIndex = 88;
            comboCinco.Text = "Servicios de transporte*";
            // 
            // comboCuatro
            // 
            comboCuatro.Anchor = AnchorStyles.None;
            comboCuatro.FormattingEnabled = true;
            comboCuatro.Items.AddRange(new object[] { "Reutilización o utilización posterior", "Reciclaje de materiales", "Reciclaje de materias primas", "Reciclaje energético", "Vertedero", "Recogida de residuos", "Tratamiento de aguas residuales", "Tratamiento de gas bruto", "Otros servicios al final de la vida útil" });
            comboCuatro.Location = new Point(5, 400);
            comboCuatro.Name = "comboCuatro";
            comboCuatro.Size = new Size(213, 23);
            comboCuatro.TabIndex = 87;
            comboCuatro.Text = "Tratamiento al final de la vida útil*";
            // 
            // comboTres
            // 
            comboTres.Anchor = AnchorStyles.None;
            comboTres.FormattingEnabled = true;
            comboTres.Items.AddRange(new object[] { "Materias primas no energéticas", "Metales y semimetales", "Productos químicos orgánicos", "Productos químicos inorgánicos", "Vidrio y cerámica", "Otros materiales minerales", "Plásticos", "Papel y cartón", "Agua", "Medios de producción agrícola", "Alimentos y materias primas renovables", "Madera", "Otros materiales" });
            comboTres.Location = new Point(494, 335);
            comboTres.Name = "comboTres";
            comboTres.Size = new Size(232, 23);
            comboTres.TabIndex = 87;
            comboTres.Text = "Materiales de producción*";
            // 
            // comboDos
            // 
            comboDos.Anchor = AnchorStyles.None;
            comboDos.FormattingEnabled = true;
            comboDos.Items.AddRange(new object[] { "Embalaje", "Electricidad y electrónica", "Vehículos", "Otras maquinas", "Construcción", "Electrodomésticos", "Textiles, muebles y otros interiores", "Partes no especificas", "Pinturas y preparados químicos", "Otros sistemas" });
            comboDos.Location = new Point(249, 335);
            comboDos.Name = "comboDos";
            comboDos.Size = new Size(228, 23);
            comboDos.TabIndex = 86;
            comboDos.Text = "Sistemas*";
            // 
            // comboUno
            // 
            comboUno.Anchor = AnchorStyles.None;
            comboUno.FormattingEnabled = true;
            comboUno.Items.AddRange(new object[] { "Materias primas energéticas", "Electricidad", "Calor y vapor", "Energía mecánica", "Combustibles a base de hulla", "Combustibles a base de lignito", "Combustibles a base de petróleo crudo", "Combustibles a base de gas natural", "Combustibles nucleares", "Otros combustibles no renovables", "Combustibles renovables" });
            comboUno.Location = new Point(11, 335);
            comboUno.Name = "comboUno";
            comboUno.Size = new Size(214, 23);
            comboUno.TabIndex = 85;
            comboUno.Text = "Portadores de energía y tecnología *";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(303, 282);
            label2.Name = "label2";
            label2.Size = new Size(133, 19);
            label2.TabIndex = 84;
            label2.Text = "Tipo de proceso";
            // 
            // buttonSiguienteP
            // 
            buttonSiguienteP.Anchor = AnchorStyles.None;
            buttonSiguienteP.BackColor = Color.FromArgb(97, 97, 96);
            buttonSiguienteP.FlatAppearance.BorderSize = 0;
            buttonSiguienteP.FlatStyle = FlatStyle.Flat;
            buttonSiguienteP.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSiguienteP.ForeColor = SystemColors.ButtonFace;
            buttonSiguienteP.Location = new Point(846, 1329);
            buttonSiguienteP.Name = "buttonSiguienteP";
            buttonSiguienteP.Size = new Size(115, 35);
            buttonSiguienteP.TabIndex = 83;
            buttonSiguienteP.Text = "Siguiente";
            buttonSiguienteP.UseVisualStyleBackColor = false;
            buttonSiguienteP.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderColor = SystemColors.ControlDarkDark;
            textBox1.BorderFocusColor = Color.Black;
            textBox1.BorderSize = 2;
            textBox1.Location = new Point(811, 1249);
            textBox1.Multiline = false;
            textBox1.Name = "textBox1";
            textBox1.Padding = new Padding(7);
            textBox1.PasswordChar = false;
            textBox1.Size = new Size(191, 30);
            textBox1.TabIndex = 81;
            textBox1.Texts = "Correo*";
            textBox1.UnderlinedStyle = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(288, 453);
            label1.Name = "label1";
            label1.Size = new Size(148, 19);
            label1.TabIndex = 82;
            label1.Text = "Datos de contacto";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderColor = SystemColors.ControlDarkDark;
            textBox2.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textBox2.BorderSize = 2;
            textBox2.ForeColor = Color.DimGray;
            textBox2.Location = new Point(216, 624);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Padding = new Padding(7);
            textBox2.PasswordChar = false;
            textBox2.Size = new Size(191, 30);
            textBox2.TabIndex = 80;
            textBox2.Texts = "Ejemplo: Centro Mario Molina";
            textBox2.UnderlinedStyle = true;
            // 
            // ComboProducto
            // 
            ComboProducto.Anchor = AnchorStyles.None;
            ComboProducto.FormattingEnabled = true;
            ComboProducto.Items.AddRange(new object[] { "Cemento", "Concreto", "Acero estructural", "Ladrillos", "Madera", "Vidrio", "Aislamiento térmico", "Pinturas y recubrimientos", "Azulejos y baldosas", "Adhesivos y selladores", "Impermeabilizantes", "Sistemas de fontanería", "Sistemas eléctricos", "Sistemas de climatización" });
            ComboProducto.Location = new Point(13, 109);
            ComboProducto.Name = "ComboProducto";
            ComboProducto.Size = new Size(214, 23);
            ComboProducto.TabIndex = 0;
            ComboProducto.Text = "Producto*";
            // 
            // ComboTecno
            // 
            ComboTecno.Anchor = AnchorStyles.None;
            ComboTecno.FormattingEnabled = true;
            ComboTecno.Items.AddRange(new object[] { "Cemento Portland", "Concreto reforzado", "Concreto premezclado", "Concreto de alto rendimiento", "Ladrillos cerámicos", "Ladrillos de hormigón", "Acero laminado en caliente", "Madera laminada encolada", "Madera tratada", "Vidrio de seguridad laminado", "Vidrio aislante", "Azulejos de cerámica esmaltada", "Baldosas de porcelana", "Espuma de poliestireno expandido (EPS)", "Lana mineral", "Membranas asfálticas", "Pinturas impermeabilizantes" });
            ComboTecno.Location = new Point(247, 109);
            ComboTecno.Name = "ComboTecno";
            ComboTecno.Size = new Size(232, 23);
            ComboTecno.TabIndex = 30;
            ComboTecno.Text = "Tecnología*";
            // 
            // textOtro
            // 
            textOtro.Anchor = AnchorStyles.None;
            textOtro.BackColor = SystemColors.Control;
            textOtro.BorderColor = SystemColors.ControlDarkDark;
            textOtro.BorderFocusColor = Color.Black;
            textOtro.BorderSize = 2;
            textOtro.ForeColor = Color.DimGray;
            textOtro.Location = new Point(504, 102);
            textOtro.Multiline = false;
            textOtro.Name = "textOtro";
            textOtro.Padding = new Padding(7);
            textOtro.PasswordChar = false;
            textOtro.Size = new Size(222, 30);
            textOtro.TabIndex = 69;
            textOtro.Texts = "Ejemplo: grava y arena";
            textOtro.UnderlinedStyle = true;
            // 
            // labelUsuario
            // 
            labelUsuario.Anchor = AnchorStyles.Top;
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsuario.ForeColor = Color.Red;
            labelUsuario.Location = new Point(587, -183);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(111, 19);
            labelUsuario.TabIndex = 29;
            labelUsuario.Text = "Identificación";
            // 
            // Referencia
            // 
            Referencia.AutoScroll = true;
            Referencia.BackColor = Color.FromArgb(242, 230, 230);
            Referencia.Controls.Add(panel4);
            Referencia.Location = new Point(4, 24);
            Referencia.Name = "Referencia";
            Referencia.Padding = new Padding(3);
            Referencia.Size = new Size(755, 490);
            Referencia.TabIndex = 1;
            Referencia.Text = "Referencia";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.AutoScroll = true;
            panel4.BackColor = Color.FromArgb(242, 230, 230);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(button7);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(buttoAtrasP);
            panel4.Controls.Add(buttonSiguenteS);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(comboLimitesSistema);
            panel4.Controls.Add(textObjetivoR);
            panel4.Controls.Add(comboUnidadUno);
            panel4.Controls.Add(numericUpDown1);
            panel4.Controls.Add(textUnidadFuncional);
            panel4.Controls.Add(textBox7);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(-192, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(738, 747);
            panel4.TabIndex = 77;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(190, 31, 36);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(575, 935);
            button2.Name = "button2";
            button2.Size = new Size(121, 36);
            button2.TabIndex = 114;
            button2.Text = "Eliminar imagen";
            button2.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(190, 31, 36);
            label13.Location = new Point(507, 213);
            label13.Name = "label13";
            label13.Size = new Size(45, 16);
            label13.TabIndex = 113;
            label13.Text = "Valor*";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.None;
            label19.AutoSize = true;
            label19.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(190, 31, 36);
            label19.Location = new Point(533, 170);
            label19.Name = "label19";
            label19.Size = new Size(65, 16);
            label19.TabIndex = 112;
            label19.Text = "Objetivo*";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.None;
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.FromArgb(190, 31, 36);
            label18.Location = new Point(310, 42);
            label18.Name = "label18";
            label18.Size = new Size(207, 16);
            label18.TabIndex = 111;
            label18.Text = "Nombre del flujo de referencia*";
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.BackColor = Color.FromArgb(190, 31, 36);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ButtonFace;
            button7.Location = new Point(469, 1015);
            button7.Name = "button7";
            button7.Size = new Size(115, 35);
            button7.TabIndex = 90;
            button7.Text = "Atrás";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.BackColor = Color.FromArgb(190, 31, 36);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(700, 1014);
            button6.Name = "button6";
            button6.Size = new Size(115, 35);
            button6.TabIndex = 89;
            button6.Text = "Siguiente";
            button6.UseVisualStyleBackColor = false;
            // 
            // buttoAtrasP
            // 
            buttoAtrasP.Anchor = AnchorStyles.None;
            buttoAtrasP.BackColor = Color.FromArgb(97, 97, 96);
            buttoAtrasP.FlatAppearance.BorderSize = 0;
            buttoAtrasP.FlatStyle = FlatStyle.Flat;
            buttoAtrasP.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttoAtrasP.ForeColor = SystemColors.ButtonFace;
            buttoAtrasP.Location = new Point(724, 1329);
            buttoAtrasP.Name = "buttoAtrasP";
            buttoAtrasP.Size = new Size(115, 35);
            buttoAtrasP.TabIndex = 87;
            buttoAtrasP.Text = "Atras";
            buttoAtrasP.UseVisualStyleBackColor = false;
            // 
            // buttonSiguenteS
            // 
            buttonSiguenteS.Anchor = AnchorStyles.None;
            buttonSiguenteS.BackColor = Color.FromArgb(97, 97, 96);
            buttonSiguenteS.FlatAppearance.BorderSize = 0;
            buttonSiguenteS.FlatStyle = FlatStyle.Flat;
            buttonSiguenteS.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSiguenteS.ForeColor = SystemColors.ButtonFace;
            buttonSiguenteS.Location = new Point(965, 1328);
            buttonSiguenteS.Name = "buttonSiguenteS";
            buttonSiguenteS.Size = new Size(115, 35);
            buttonSiguenteS.TabIndex = 86;
            buttonSiguenteS.Text = "Siguiente";
            buttonSiguenteS.UseVisualStyleBackColor = false;
            buttonSiguenteS.Visible = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(202, 238);
            label5.Name = "label5";
            label5.Size = new Size(155, 19);
            label5.TabIndex = 85;
            label5.Text = "Imagen del sistema";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.Location = new Point(108, 272);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 174);
            pictureBox1.TabIndex = 82;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.FromArgb(97, 97, 96);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(689, 1143);
            button4.Name = "button4";
            button4.Size = new Size(115, 35);
            button4.TabIndex = 81;
            button4.Text = "Atras";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.BackColor = Color.FromArgb(97, 97, 96);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(892, 1143);
            button5.Name = "button5";
            button5.Size = new Size(115, 35);
            button5.TabIndex = 80;
            button5.Text = "Siguiente";
            button5.UseVisualStyleBackColor = false;
            // 
            // comboLimitesSistema
            // 
            comboLimitesSistema.FormattingEnabled = true;
            comboLimitesSistema.Items.AddRange(new object[] { "Limitaciones presupuestarias", "Limitaciones de tiempo", "Limitaciones de recursos naturales", "Limitaciones de espacio", "Limitaciones ambientales", "Limitaciones de capacidad", "Limitaciones geotécnicas", "Limitaciones tecnológicas", "Limitaciones normativas y legales", "Limitaciones de seguridad" });
            comboLimitesSistema.Location = new Point(215, 206);
            comboLimitesSistema.Name = "comboLimitesSistema";
            comboLimitesSistema.Size = new Size(230, 23);
            comboLimitesSistema.TabIndex = 76;
            comboLimitesSistema.Text = "Limites del sistema*";
            // 
            // textObjetivoR
            // 
            textObjetivoR.Anchor = AnchorStyles.None;
            textObjetivoR.BackColor = SystemColors.Control;
            textObjetivoR.BorderColor = SystemColors.ControlDarkDark;
            textObjetivoR.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textObjetivoR.BorderSize = 2;
            textObjetivoR.ForeColor = Color.DimGray;
            textObjetivoR.Location = new Point(287, 170);
            textObjetivoR.Multiline = true;
            textObjetivoR.Name = "textObjetivoR";
            textObjetivoR.Padding = new Padding(7);
            textObjetivoR.PasswordChar = false;
            textObjetivoR.Size = new Size(230, 30);
            textObjetivoR.TabIndex = 75;
            textObjetivoR.Texts = "Ejemplo: Estimar la huella de carbono";
            textObjetivoR.UnderlinedStyle = true;
            // 
            // comboUnidadUno
            // 
            comboUnidadUno.FormattingEnabled = true;
            comboUnidadUno.Items.AddRange(new object[] { "Área (m²)", "Área (ha)", "Área*Tiempo (m²*año)", "Capacidad de peso (kg*s)", "Capacidad de volumen (l*hora)", "Capacidad de conversión de energía (MW)", "Densidad (kg*l)", "Masa (kg)", "Capacidad de peso (kg*s)", "Longitud (m)", "Servicio de transporte (ton*km)", "Servicio de transporte (persona*km)", "Metro*año (m*año)", "Unidad (item)", "Electricidad (kWh)", "Energía (MJ)", "Tiempo de uso del equipo (hora)", "Productos líquidos (l)", "Volumen (m³)", "Energia (KWh)", "Energía (kJ)" });
            comboUnidadUno.Location = new Point(322, 126);
            comboUnidadUno.Name = "comboUnidadUno";
            comboUnidadUno.Size = new Size(230, 23);
            comboUnidadUno.TabIndex = 74;
            comboUnidadUno.Text = "Unidad*";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(300, 97);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(230, 23);
            numericUpDown1.TabIndex = 72;
            // 
            // textUnidadFuncional
            // 
            textUnidadFuncional.Anchor = AnchorStyles.None;
            textUnidadFuncional.BackColor = SystemColors.Control;
            textUnidadFuncional.BorderColor = SystemColors.ControlDarkDark;
            textUnidadFuncional.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textUnidadFuncional.BorderSize = 2;
            textUnidadFuncional.ForeColor = Color.DimGray;
            textUnidadFuncional.Location = new Point(307, 51);
            textUnidadFuncional.Multiline = true;
            textUnidadFuncional.Name = "textUnidadFuncional";
            textUnidadFuncional.Padding = new Padding(7);
            textUnidadFuncional.PasswordChar = false;
            textUnidadFuncional.Size = new Size(230, 30);
            textUnidadFuncional.TabIndex = 71;
            textUnidadFuncional.Texts = "Ejemplo: Elaboración de concreto simple";
            textUnidadFuncional.UnderlinedStyle = true;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.None;
            textBox7.BackColor = SystemColors.Control;
            textBox7.BorderColor = SystemColors.ControlDarkDark;
            textBox7.BorderFocusColor = Color.Black;
            textBox7.BorderSize = 2;
            textBox7.Location = new Point(923, 400);
            textBox7.Multiline = false;
            textBox7.Name = "textBox7";
            textBox7.Padding = new Padding(7);
            textBox7.PasswordChar = false;
            textBox7.Size = new Size(222, 30);
            textBox7.TabIndex = 69;
            textBox7.Texts = "Otro*";
            textBox7.UnderlinedStyle = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(421, 23);
            label3.Name = "label3";
            label3.Size = new Size(91, 19);
            label3.TabIndex = 29;
            label3.Text = "Referencia";
            // 
            // Tecnología
            // 
            Tecnología.AutoScroll = true;
            Tecnología.BackColor = Color.FromArgb(242, 230, 230);
            Tecnología.Controls.Add(panel2);
            Tecnología.Location = new Point(4, 24);
            Tecnología.Name = "Tecnología";
            Tecnología.Size = new Size(755, 490);
            Tecnología.TabIndex = 2;
            Tecnología.Text = "Tecnología";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(242, 230, 230);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(buttonAtrasR);
            panel2.Controls.Add(buttonSiguienteT);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(736, 468);
            panel2.TabIndex = 0;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.None;
            label20.AutoSize = true;
            label20.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.FromArgb(190, 31, 36);
            label20.Location = new Point(245, 131);
            label20.Name = "label20";
            label20.Size = new Size(178, 16);
            label20.TabIndex = 112;
            label20.Text = "Condiciones de operación*";
            // 
            // buttonAtrasR
            // 
            buttonAtrasR.Anchor = AnchorStyles.None;
            buttonAtrasR.BackColor = Color.FromArgb(190, 31, 36);
            buttonAtrasR.FlatAppearance.BorderSize = 0;
            buttonAtrasR.FlatStyle = FlatStyle.Flat;
            buttonAtrasR.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAtrasR.ForeColor = SystemColors.ButtonFace;
            buttonAtrasR.Location = new Point(165, 283);
            buttonAtrasR.Name = "buttonAtrasR";
            buttonAtrasR.Size = new Size(115, 35);
            buttonAtrasR.TabIndex = 89;
            buttonAtrasR.Text = "Atrás";
            buttonAtrasR.UseVisualStyleBackColor = false;
            // 
            // buttonSiguienteT
            // 
            buttonSiguienteT.Anchor = AnchorStyles.None;
            buttonSiguienteT.BackColor = Color.FromArgb(190, 31, 36);
            buttonSiguienteT.FlatAppearance.BorderSize = 0;
            buttonSiguienteT.FlatStyle = FlatStyle.Flat;
            buttonSiguienteT.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSiguienteT.ForeColor = SystemColors.ButtonFace;
            buttonSiguienteT.Location = new Point(403, 283);
            buttonSiguienteT.Name = "buttonSiguienteT";
            buttonSiguienteT.Size = new Size(115, 35);
            buttonSiguienteT.TabIndex = 88;
            buttonSiguienteT.Text = "Siguiente";
            buttonSiguienteT.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.BackColor = SystemColors.Control;
            textBox3.BorderColor = SystemColors.ControlDarkDark;
            textBox3.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textBox3.BorderSize = 2;
            textBox3.ForeColor = Color.DimGray;
            textBox3.Location = new Point(245, 150);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Padding = new Padding(7);
            textBox3.PasswordChar = false;
            textBox3.Size = new Size(230, 30);
            textBox3.TabIndex = 76;
            textBox3.Texts = "Ejemplo: En este estudio se considera una revolvedora";
            textBox3.UnderlinedStyle = true;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Innovación (Laboratorio, prototipo, piloto, demostración)", "Moderna", "Actual (más encontrada en operación)", "Antigua", "Mix.Tecnologías" });
            comboBox1.Location = new Point(245, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 23);
            comboBox1.TabIndex = 75;
            comboBox1.Text = "Tipo de tecnología*";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(320, 11);
            label6.Name = "label6";
            label6.Size = new Size(93, 19);
            label6.TabIndex = 30;
            label6.Text = "Tecnología";
            // 
            // TiempoVálido
            // 
            TiempoVálido.AutoScroll = true;
            TiempoVálido.BackColor = Color.FromArgb(242, 230, 230);
            TiempoVálido.Controls.Add(panel3);
            TiempoVálido.Location = new Point(4, 24);
            TiempoVálido.Name = "TiempoVálido";
            TiempoVálido.Size = new Size(755, 490);
            TiempoVálido.TabIndex = 3;
            TiempoVálido.Text = "TiempoVálido";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(242, 230, 230);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(dateTimePicker2);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(buttonAtrasTec);
            panel3.Controls.Add(buttonSiguienteC);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(739, 470);
            panel3.TabIndex = 1;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.None;
            label21.AutoSize = true;
            label21.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.FromArgb(190, 31, 36);
            label21.Location = new Point(153, 273);
            label21.Name = "label21";
            label21.Size = new Size(231, 16);
            label21.TabIndex = 113;
            label21.Text = "Descripción del periodo de tiempo*";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Crimson;
            label9.Location = new Point(273, 247);
            label9.Name = "label9";
            label9.Size = new Size(131, 16);
            label9.TabIndex = 93;
            label9.Text = "Datos Válidos hasta";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Crimson;
            label8.Location = new Point(273, 178);
            label8.Name = "label8";
            label8.Size = new Size(209, 16);
            label8.TabIndex = 92;
            label8.Text = "Fecha de referencia del estudio";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(218, 152);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(329, 23);
            dateTimePicker2.TabIndex = 91;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(248, 82);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(329, 23);
            dateTimePicker1.TabIndex = 90;
            // 
            // buttonAtrasTec
            // 
            buttonAtrasTec.Anchor = AnchorStyles.None;
            buttonAtrasTec.BackColor = Color.FromArgb(190, 31, 36);
            buttonAtrasTec.FlatAppearance.BorderSize = 0;
            buttonAtrasTec.FlatStyle = FlatStyle.Flat;
            buttonAtrasTec.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAtrasTec.ForeColor = SystemColors.ButtonFace;
            buttonAtrasTec.Location = new Point(225, 354);
            buttonAtrasTec.Name = "buttonAtrasTec";
            buttonAtrasTec.Size = new Size(115, 35);
            buttonAtrasTec.TabIndex = 89;
            buttonAtrasTec.Text = "Atrás";
            buttonAtrasTec.UseVisualStyleBackColor = false;
            // 
            // buttonSiguienteC
            // 
            buttonSiguienteC.Anchor = AnchorStyles.None;
            buttonSiguienteC.BackColor = Color.FromArgb(190, 31, 36);
            buttonSiguienteC.FlatAppearance.BorderSize = 0;
            buttonSiguienteC.FlatStyle = FlatStyle.Flat;
            buttonSiguienteC.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSiguienteC.ForeColor = SystemColors.ButtonFace;
            buttonSiguienteC.Location = new Point(462, 354);
            buttonSiguienteC.Name = "buttonSiguienteC";
            buttonSiguienteC.Size = new Size(115, 35);
            buttonSiguienteC.TabIndex = 88;
            buttonSiguienteC.Text = "Siguiente";
            buttonSiguienteC.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.BackColor = SystemColors.Control;
            textBox4.BorderColor = SystemColors.ControlDarkDark;
            textBox4.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textBox4.BorderSize = 2;
            textBox4.ForeColor = Color.DimGray;
            textBox4.Location = new Point(225, 214);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Padding = new Padding(7);
            textBox4.PasswordChar = false;
            textBox4.Size = new Size(329, 30);
            textBox4.TabIndex = 76;
            textBox4.Texts = "Ejemplo: Se solicita este tiempo para el análisis del estudio";
            textBox4.UnderlinedStyle = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(343, 119);
            label7.Name = "label7";
            label7.Size = new Size(204, 19);
            label7.TabIndex = 30;
            label7.Text = "Tiempo válido del estudio";
            // 
            // Geografía
            // 
            Geografía.AutoScroll = true;
            Geografía.BackColor = Color.FromArgb(242, 230, 230);
            Geografía.Controls.Add(panel5);
            Geografía.Location = new Point(4, 24);
            Geografía.Name = "Geografía";
            Geografía.Size = new Size(755, 490);
            Geografía.TabIndex = 4;
            Geografía.Text = "Geografía";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.BackColor = Color.FromArgb(242, 230, 230);
            panel5.Controls.Add(gMapControl1);
            panel5.Controls.Add(button1);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(trackZoom);
            panel5.Controls.Add(buttonGuardarG);
            panel5.Controls.Add(dataGridView2);
            panel5.Controls.Add(comboBox4);
            panel5.Controls.Add(comboBox2);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(-194, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(719, 1019);
            panel5.TabIndex = 2;
            // 
            // gMapControl1
            // 
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(0, 247);
            gMapControl1.MarkersEnabled = true;
            gMapControl1.MaxZoom = 2;
            gMapControl1.MinZoom = 2;
            gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.Name = "gMapControl1";
            gMapControl1.NegativeMode = false;
            gMapControl1.PolygonsEnabled = true;
            gMapControl1.RetryLoadTile = 0;
            gMapControl1.RoutesEnabled = true;
            gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gMapControl1.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Size = new Size(712, 387);
            gMapControl1.TabIndex = 96;
            gMapControl1.Zoom = 0D;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(190, 31, 36);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(277, 689);
            button1.Name = "button1";
            button1.Size = new Size(115, 35);
            button1.TabIndex = 103;
            button1.Text = "Guardar datos";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.Location = new Point(0, -25);
            panel7.Name = "panel7";
            panel7.Size = new Size(387, 23);
            panel7.TabIndex = 102;
            // 
            // panel6
            // 
            panel6.Location = new Point(505, 141);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 100);
            panel6.TabIndex = 100;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(227, 794);
            label11.Name = "label11";
            label11.Size = new Size(233, 19);
            label11.TabIndex = 99;
            label11.Text = "Representatividad geografica";
            // 
            // trackZoom
            // 
            trackZoom.Location = new Point(197, 740);
            trackZoom.Name = "trackZoom";
            trackZoom.Size = new Size(289, 45);
            trackZoom.TabIndex = 98;
            // 
            // buttonGuardarG
            // 
            buttonGuardarG.Anchor = AnchorStyles.None;
            buttonGuardarG.BackColor = Color.FromArgb(97, 97, 96);
            buttonGuardarG.FlatAppearance.BorderSize = 0;
            buttonGuardarG.FlatStyle = FlatStyle.Flat;
            buttonGuardarG.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGuardarG.ForeColor = SystemColors.ButtonFace;
            buttonGuardarG.Location = new Point(799, 1759);
            buttonGuardarG.Name = "buttonGuardarG";
            buttonGuardarG.Size = new Size(115, 35);
            buttonGuardarG.TabIndex = 97;
            buttonGuardarG.Text = "Guardar datos";
            buttonGuardarG.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(496, 36);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(121, 60);
            dataGridView2.TabIndex = 95;
            // 
            // comboBox4
            // 
            comboBox4.Anchor = AnchorStyles.None;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Aguascalientes", "Tijuana", "La Paz", "Campeche", "Tuxtla Gutiérrez", "Chihuahua", "Zona centro", "Saltillo", "Colima", "Durango", "León", "Acapulco", "Pachuca", "Guadalajara", "Morelia", "Cuernavaca", "Tepic", "Monterrey", "Oaxaca", "Puebla-Tlaxcala", "Querétaro", "Cancún", "San Luis Potosí", "Culiacán", "Hermosillo", "Villahermosa", "Tampico", "Puebla-Tlaxcala", "Veracruz", "Mérida", "Zacatecas" });
            comboBox4.Location = new Point(163, 124);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(230, 23);
            comboBox4.TabIndex = 94;
            comboBox4.Text = "Nombre del área*";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.None;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Aguascalientes", "Baja California", "Baja California Sur", "Campeche", "Chiapas", "Chihuahua", "Estado de México ", "Coahuila", "Colima", "Durango", "Guanajuato", "Guerrero", "Hidalgo", "Jalisco", "Michoacán", "Morelos", "Nayarit", "Nuevo León", "Oaxaca", "Puebla", "Querétaro ", "Quintana Roo", "San Luis Potosí ", "Sinaloa", "Sonora", "Tabasco", "Tamaulipas", "Tlaxcala", "Veracruz", "Yucatán", "Zacatecas" });
            comboBox2.Location = new Point(151, 95);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(230, 23);
            comboBox2.TabIndex = 93;
            comboBox2.Text = "Estado*";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(189, 25);
            label10.Name = "label10";
            label10.Size = new Size(204, 19);
            label10.TabIndex = 92;
            label10.Text = "Tiempo válido del estudio";
            // 
            // VerImagen
            // 
            VerImagen.AutoScroll = true;
            VerImagen.BackColor = Color.FromArgb(242, 230, 230);
            VerImagen.Controls.Add(panel8);
            VerImagen.Location = new Point(4, 24);
            VerImagen.Name = "VerImagen";
            VerImagen.Size = new Size(755, 490);
            VerImagen.TabIndex = 6;
            VerImagen.Text = "Ver imagen";
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top;
            panel8.BackColor = Color.FromArgb(242, 230, 230);
            panel8.Controls.Add(btnAtrasIma);
            panel8.Controls.Add(pictureBox2);
            panel8.Controls.Add(label22);
            panel8.Location = new Point(-16, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(737, 675);
            panel8.TabIndex = 97;
            // 
            // btnAtrasIma
            // 
            btnAtrasIma.Anchor = AnchorStyles.None;
            btnAtrasIma.BackColor = Color.FromArgb(190, 31, 36);
            btnAtrasIma.FlatAppearance.BorderSize = 0;
            btnAtrasIma.FlatStyle = FlatStyle.Flat;
            btnAtrasIma.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtrasIma.ForeColor = SystemColors.ButtonFace;
            btnAtrasIma.Location = new Point(304, 575);
            btnAtrasIma.Name = "btnAtrasIma";
            btnAtrasIma.Size = new Size(115, 35);
            btnAtrasIma.TabIndex = 99;
            btnAtrasIma.Text = "Atrás";
            btnAtrasIma.UseVisualStyleBackColor = false;
            btnAtrasIma.Click += btnAtrasIma_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Gray;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(12, 62);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(715, 488);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 98;
            pictureBox2.TabStop = false;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top;
            label22.AutoSize = true;
            label22.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.Red;
            label22.Location = new Point(304, 12);
            label22.Name = "label22";
            label22.Size = new Size(155, 19);
            label22.TabIndex = 97;
            label22.Text = "Imagen del sistema";
            // 
            // ListaFormulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 230, 230);
            ClientSize = new Size(768, 522);
            Controls.Add(tabControl2);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(500, 500);
            Name = "ListaFormulario";
            Text = "ListaFormulario";
            Load += ListaFormulario_Load;
            tabControl2.ResumeLayout(false);
            ListaDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Identificación.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Referencia.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            Tecnología.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            TiempoVálido.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            Geografía.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackZoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            VerImagen.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl2;
        private TabPage ListaDatos;
        private Button btnExportarCSV;
        private DataGridView dataGridView1;
        private Button btnSeleccionarT;
        private Button btnExportarPDF;
        private Button btnBorrar;
        private TabPage Identificación;
        private Panel panel1;
        private ComboBox comboEstatus;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Templates.TextBox textBox5;
        private Label label12;
        private Button button8;
        private Templates.TextBox textProceso;
        private Label label4;
        private ComboBox comboSeis;
        private ComboBox comboCinco;
        private ComboBox comboCuatro;
        private ComboBox comboTres;
        private ComboBox comboDos;
        private ComboBox comboUno;
        private Label label2;
        private Button buttonSiguienteP;
        private Templates.TextBox textBox1;
        private Label label1;
        private Templates.TextBox textBox2;
        private ComboBox ComboTecno;
        private Templates.TextBox textOtro;
        private Label labelUsuario;
        private TabPage Referencia;
        private Panel panel4;
        private Button button2;
        private Label label13;
        private Label label19;
        private Label label18;
        private Button button7;
        private Button button6;
        private Button buttoAtrasP;
        private Button buttonSiguenteS;
        private Label label5;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button5;
        private ComboBox comboLimitesSistema;
        private Templates.TextBox textObjetivoR;
        private ComboBox comboUnidadUno;
        private NumericUpDown numericUpDown1;
        private Templates.TextBox textUnidadFuncional;
        private Templates.TextBox textBox7;
        private Label label3;
        private TabPage Tecnología;
        private Panel panel2;
        private Label label20;
        private Button buttonAtrasR;
        private Button buttonSiguienteT;
        private Templates.TextBox textBox3;
        private ComboBox comboBox1;
        private Label label6;
        private TabPage TiempoVálido;
        private Panel panel3;
        private Label label21;
        private Label label9;
        private Label label8;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button buttonAtrasTec;
        private Button buttonSiguienteC;
        private Templates.TextBox textBox4;
        private Label label7;
        private TabPage Geografía;
        private Panel panel5;
        private Button button1;
        private Panel panel7;
        private Panel panel6;
        private Label label11;
        private TrackBar trackZoom;
        private Button buttonGuardarG;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private DataGridView dataGridView2;
        private ComboBox comboBox4;
        private ComboBox comboBox2;
        private Label label10;
        private TabPage VerImagen;
        private ComboBox ComboProducto;
        private Panel panel8;
        private Button btnAtrasIma;
        private PictureBox pictureBox2;
        private Label label22;
    }
}