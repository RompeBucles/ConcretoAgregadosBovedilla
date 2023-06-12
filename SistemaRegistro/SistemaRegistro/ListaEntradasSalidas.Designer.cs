namespace SistemaRegistro
{
    partial class ListaEntradasSalidas
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
            tabControl1 = new TabControl();
            ListaUsuario = new TabPage();
            btnSeleccionarT = new Button();
            btnBorrar = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column11 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Column6 = new DataGridViewCheckBoxColumn();
            EditarUsuarios = new TabPage();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            textBox3 = new SistemaRegistro.Templates.TextBox();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label12 = new Label();
            button8 = new Button();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            textProceso = new SistemaRegistro.Templates.TextBox();
            comboSeis = new ComboBox();
            comboDos = new ComboBox();
            comboUno = new ComboBox();
            buttonSiguienteP = new Button();
            textBox1 = new SistemaRegistro.Templates.TextBox();
            ComboTecno = new ComboBox();
            textOtro = new SistemaRegistro.Templates.TextBox();
            labelUsuario = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            tabControl1.SuspendLayout();
            ListaUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            EditarUsuarios.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(ListaUsuario);
            tabControl1.Controls.Add(EditarUsuarios);
            tabControl1.Location = new Point(1, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(734, 498);
            tabControl1.TabIndex = 22;
            // 
            // ListaUsuario
            // 
            ListaUsuario.BackColor = Color.FromArgb(242, 230, 230);
            ListaUsuario.Controls.Add(btnSeleccionarT);
            ListaUsuario.Controls.Add(btnBorrar);
            ListaUsuario.Controls.Add(button1);
            ListaUsuario.Controls.Add(dataGridView1);
            ListaUsuario.Location = new Point(4, 24);
            ListaUsuario.Name = "ListaUsuario";
            ListaUsuario.Padding = new Padding(3);
            ListaUsuario.Size = new Size(726, 470);
            ListaUsuario.TabIndex = 0;
            ListaUsuario.Text = "ListaEntradas / Salidas";
            // 
            // btnSeleccionarT
            // 
            btnSeleccionarT.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSeleccionarT.BackColor = Color.FromArgb(190, 31, 36);
            btnSeleccionarT.FlatAppearance.BorderSize = 0;
            btnSeleccionarT.FlatStyle = FlatStyle.Flat;
            btnSeleccionarT.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSeleccionarT.ForeColor = SystemColors.ButtonFace;
            btnSeleccionarT.Location = new Point(383, 428);
            btnSeleccionarT.Name = "btnSeleccionarT";
            btnSeleccionarT.Size = new Size(151, 39);
            btnSeleccionarT.TabIndex = 72;
            btnSeleccionarT.Text = "Seleccionar todo";
            btnSeleccionarT.UseVisualStyleBackColor = false;
            btnSeleccionarT.Click += btnSeleccionarT_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBorrar.BackColor = Color.FromArgb(190, 31, 36);
            btnBorrar.FlatAppearance.BorderSize = 0;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrar.ForeColor = SystemColors.ButtonFace;
            btnBorrar.Location = new Point(569, 428);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(151, 39);
            btnBorrar.TabIndex = 71;
            btnBorrar.Text = "Borra Selección";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(97, 97, 96);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(1132, 816);
            button1.Name = "button1";
            button1.Size = new Size(151, 39);
            button1.TabIndex = 67;
            button1.Text = "Borra Selección";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.FromArgb(242, 230, 230);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column11, Column1, Column2, Column3, Column4, Column5, Column7, Column8, Column9, Column10, Editar, Column6 });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(719, 399);
            dataGridView1.TabIndex = 27;
            // 
            // Column11
            // 
            Column11.HeaderText = "Producto_tecnologia_otro";
            Column11.Name = "Column11";
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre de flujo ";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tipo de flujo ";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Recursos";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Emisiones ";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Valor";
            Column5.Name = "Column5";
            // 
            // Column7
            // 
            Column7.HeaderText = "Unidades";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Tratamiento de dato";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Citas-Referencias";
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "Comentario";
            Column10.Name = "Column10";
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Name = "Editar";
            Editar.Resizable = DataGridViewTriState.True;
            // 
            // Column6
            // 
            Column6.HeaderText = "Eliminar";
            Column6.Name = "Column6";
            // 
            // EditarUsuarios
            // 
            EditarUsuarios.AutoScroll = true;
            EditarUsuarios.BackColor = Color.FromArgb(242, 230, 230);
            EditarUsuarios.Controls.Add(panel1);
            EditarUsuarios.Location = new Point(4, 24);
            EditarUsuarios.Name = "EditarUsuarios";
            EditarUsuarios.Padding = new Padding(3);
            EditarUsuarios.Size = new Size(726, 470);
            EditarUsuarios.TabIndex = 1;
            EditarUsuarios.Text = "Editar Entradas / Salidas";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(comboBox5);
            panel1.Controls.Add(comboBox6);
            panel1.Controls.Add(textProceso);
            panel1.Controls.Add(comboSeis);
            panel1.Controls.Add(comboDos);
            panel1.Controls.Add(comboUno);
            panel1.Controls.Add(buttonSiguienteP);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(ComboTecno);
            panel1.Controls.Add(textOtro);
            panel1.Controls.Add(labelUsuario);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(723, 747);
            panel1.TabIndex = 78;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.FromArgb(190, 31, 36);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(301, 633);
            button4.Name = "button4";
            button4.Size = new Size(115, 35);
            button4.TabIndex = 105;
            button4.Text = "Guardar datos";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(97, 97, 96);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(566, 983);
            button3.Name = "button3";
            button3.Size = new Size(115, 35);
            button3.TabIndex = 104;
            button3.Text = "Guardar datos";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.BackColor = SystemColors.Control;
            textBox3.BorderColor = SystemColors.ControlDarkDark;
            textBox3.BorderFocusColor = Color.Black;
            textBox3.BorderSize = 2;
            textBox3.ForeColor = Color.DimGray;
            textBox3.Location = new Point(134, 512);
            textBox3.Multiline = false;
            textBox3.Name = "textBox3";
            textBox3.Padding = new Padding(7);
            textBox3.PasswordChar = false;
            textBox3.Size = new Size(451, 30);
            textBox3.TabIndex = 101;
            textBox3.Texts = "Ejemplo: \"Expreso este comentario\"";
            textBox3.UnderlinedStyle = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(10, 267);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(211, 23);
            numericUpDown1.TabIndex = 99;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(289, 20);
            label3.Name = "label3";
            label3.Size = new Size(146, 19);
            label3.TabIndex = 98;
            label3.Text = "Entradas / Salidas";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(605, -319);
            label12.Name = "label12";
            label12.Size = new Size(111, 19);
            label12.TabIndex = 97;
            label12.Text = "Identificación";
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.None;
            button8.BackColor = Color.FromArgb(97, 97, 96);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ButtonFace;
            button8.Location = new Point(807, 1328);
            button8.Name = "button8";
            button8.Size = new Size(115, 35);
            button8.TabIndex = 96;
            button8.Text = "Siguiente";
            button8.UseVisualStyleBackColor = false;
            // 
            // comboBox5
            // 
            comboBox5.Anchor = AnchorStyles.None;
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Elemental", "Producto", "Residuo", "Recursos", "Elemento o Compuesto", "Grupo de químicos", "Mineral, metal o agregado.", "Biológico", "Agua", "Combustibles fósiles", "Combustibles nucleares.", "Energía", "Recurso – Recurso suelo", "Recurso – Recurso aire", "Recurso – Recurso agua", "Recursos – Recursos biótico", "Recursos – Recurso ocupación y transformación del suelo", "Recursos materiales no renovables del suelo", "Recursos de elementos no renovables del suelo", "Recursos de elementos renovables del suelo", "Recursos de energía renovable del suelo (por ejemplo, \"Energía eólica\", \"Energía hidráulica; funcionamiento\", etc.)", "Recursos materiales renovables del suelo", "Recursos renovables del suelo, no especificados", "Recursos no renovables del suelo, no especificados", "Uso del suelo - Transformación del suelo", "Uso del suelo - Ocupación del suelo", "Uso del suelo -  Cultivable", "Uso del suelo – No irrigado", "Uso del suelo – Diverso, intensivo." });
            comboBox5.Location = new Point(257, 155);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(214, 23);
            comboBox5.TabIndex = 92;
            comboBox5.Text = "Tipo de flujo*";
            // 
            // comboBox6
            // 
            comboBox6.Anchor = AnchorStyles.None;
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "Emisiones - Emisiones al aire - Emisiones al aire sin especificar", "Emisiones - Emisiones al aire - Emisiones sin especificar (a largo plazo)", "Emisiones - Emisiones al aire - Emisiones al aire no urbano o de chimeneas altas (alturas mayo a 100 m)", "Emisiones - Emisiones al aire - Emisiones a la baja estratosfera y a la alta troposfera", "Emisiones - Emisiones al aire - Emisiones inorgánicas al aire", "Emisiones - Emisiones al aire - Emisiones orgánicas al aire", "Emisiones - Emisiones al aire - Emisiones radioactivas al aire", "Emisiones - Emisiones al aire – Partículas", "Emisiones - Emisiones al aire - Otras emisiones al aire", "Emisiones - Emisiones al agua - Emisiones al agua, sin especificar.", "Emisiones - Emisiones al agua – Emisiones inorgánicas al agua", "Emisiones - Emisiones al agua – Emisiones orgánicas al agua", "Emisiones - Emisiones al agua – Emisiones radioactivas al agua", "Emisiones - Emisiones al agua – Emisiones de partículas al agua", "Emisiones - Emisiones al agua – Otras Emisiones al agua", "Emisiones - Emisiones al suelo - Emisiones al suelo, sin especificar", "Emisiones - Emisiones al suelo - Emisiones al suelo agrícola", "Emisiones - Emisiones al suelo - Emisiones al suelo no agrícola", "Emisiones - Emisiones al suelo - Emisiones al suelo, sin especificar (a largo plazo)", "Emisiones - Emisiones al suelo – Emisiones inorgánicas al suelo", "Emisiones - Emisiones al suelo – Emisiones orgánicas al suelo", "Emisiones - Emisiones al suelo – Emisiones radioactivas al suelo", "Emisiones - Emisiones al suelo – Emisiones de partículas al suelo", "Emisiones - Emisiones al suelo – Otras Emisiones al suelo", "Otros flujos elementales" });
            comboBox6.Location = new Point(488, 155);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(232, 23);
            comboBox6.TabIndex = 93;
            comboBox6.Text = "Emisiones *";
            // 
            // textProceso
            // 
            textProceso.Anchor = AnchorStyles.None;
            textProceso.BackColor = SystemColors.Control;
            textProceso.BorderColor = SystemColors.ControlDarkDark;
            textProceso.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textProceso.BorderSize = 2;
            textProceso.ForeColor = Color.DimGray;
            textProceso.Location = new Point(362, 396);
            textProceso.Multiline = true;
            textProceso.Name = "textProceso";
            textProceso.Padding = new Padding(7);
            textProceso.PasswordChar = false;
            textProceso.Size = new Size(324, 30);
            textProceso.TabIndex = 95;
            textProceso.Texts = "Ejemplo: “Manual del Ingeniero civil”";
            textProceso.UnderlinedStyle = true;
            // 
            // comboSeis
            // 
            comboSeis.Anchor = AnchorStyles.None;
            comboSeis.FormattingEnabled = true;
            comboSeis.Items.AddRange(new object[] { "Producto_tecnología_otroEntSal", "Concreto simple,mecánico, f’c 200kg/cm2", "Agregados, mina cielo abierto, grava y arena.", "Bovedilla, terminado en planta, 60x25x20cm" });
            comboSeis.Location = new Point(257, 73);
            comboSeis.Name = "comboSeis";
            comboSeis.Size = new Size(232, 23);
            comboSeis.TabIndex = 89;
            comboSeis.Text = "Producto, tecnología*";
            // 
            // comboDos
            // 
            comboDos.Anchor = AnchorStyles.None;
            comboDos.FormattingEnabled = true;
            comboDos.Items.AddRange(new object[] { "Publicaciones y comunicaciones", "Reporte de entidades estatales", "Bases de datos", "Clasificaciones estadísticas", "Formatos de conjuntos de datos", "Sistemas de cumplimiento", "Cuestionarios – Encuestas", "Entrevistas", "Imágenes", "Mediciones in situ", "Otros tipos de fuentes" });
            comboDos.Location = new Point(43, 403);
            comboDos.Name = "comboDos";
            comboDos.Size = new Size(228, 23);
            comboDos.TabIndex = 86;
            comboDos.Text = "Adquisición de dato*";
            // 
            // comboUno
            // 
            comboUno.Anchor = AnchorStyles.None;
            comboUno.FormattingEnabled = true;
            comboUno.Items.AddRange(new object[] { "Calculado: basado en relaciones estequiométricos.", "Estimado: basado en el juicio cuantitativo de expertos.", "Literatura: Derivación desconocida, no se ninguna otra indicación sobre el origen del valor.", "Valor medido: utilice este término cuando el valor haya sido medido." });
            comboUno.Location = new Point(487, 267);
            comboUno.Name = "comboUno";
            comboUno.Size = new Size(231, 23);
            comboUno.TabIndex = 85;
            comboUno.Text = "Tratamiento de dato*";
            // 
            // buttonSiguienteP
            // 
            buttonSiguienteP.Anchor = AnchorStyles.None;
            buttonSiguienteP.BackColor = Color.FromArgb(97, 97, 96);
            buttonSiguienteP.FlatAppearance.BorderSize = 0;
            buttonSiguienteP.FlatStyle = FlatStyle.Flat;
            buttonSiguienteP.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSiguienteP.ForeColor = SystemColors.ButtonFace;
            buttonSiguienteP.Location = new Point(1107, 1652);
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
            textBox1.Location = new Point(1072, 1572);
            textBox1.Multiline = false;
            textBox1.Name = "textBox1";
            textBox1.Padding = new Padding(7);
            textBox1.PasswordChar = false;
            textBox1.Size = new Size(191, 30);
            textBox1.TabIndex = 81;
            textBox1.Texts = "Correo*";
            textBox1.UnderlinedStyle = true;
            // 
            // ComboTecno
            // 
            ComboTecno.Anchor = AnchorStyles.None;
            ComboTecno.FormattingEnabled = true;
            ComboTecno.Items.AddRange(new object[] { "Área (m²)", "Área (ha)", "Área*Tiempo (m²*año)", "Capacidad de peso (kg*s)", "Capacidad de volumen (l*hora)", "Capacidad de conversión de energía (MW)", "Densidad (kg*l)", "Masa (kg)", "Capacidad de peso (kg*s)", "Longitud (m)", "Servicio de transporte (ton*km)", "Servicio de transporte (persona*km)", "Metro*año (m*año)", "Unidad (item)", "Electricidad (kWh)", "Energía (MJ)", "Tiempo de uso del equipo (hora)", "Productos líquidos (l)", "Volumen (m³)", "Energia (KWh)", "Energía (kJ)" });
            ComboTecno.Location = new Point(255, 267);
            ComboTecno.Name = "ComboTecno";
            ComboTecno.Size = new Size(215, 23);
            ComboTecno.TabIndex = 30;
            ComboTecno.Text = "Unidades*";
            // 
            // textOtro
            // 
            textOtro.Anchor = AnchorStyles.None;
            textOtro.BackColor = SystemColors.Control;
            textOtro.BorderColor = SystemColors.ControlDarkDark;
            textOtro.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textOtro.BorderSize = 2;
            textOtro.ForeColor = Color.DimGray;
            textOtro.Location = new Point(11, 148);
            textOtro.Multiline = true;
            textOtro.Name = "textOtro";
            textOtro.Padding = new Padding(7);
            textOtro.PasswordChar = false;
            textOtro.Size = new Size(222, 30);
            textOtro.TabIndex = 69;
            textOtro.Texts = "Ejemplo: Cemento Portland";
            textOtro.UnderlinedStyle = true;
            // 
            // labelUsuario
            // 
            labelUsuario.Anchor = AnchorStyles.Top;
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsuario.ForeColor = Color.Red;
            labelUsuario.Location = new Point(848, -183);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(111, 19);
            labelUsuario.TabIndex = 29;
            labelUsuario.Text = "Identificación";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(190, 31, 36);
            label4.Location = new Point(11, 119);
            label4.Name = "label4";
            label4.Size = new Size(114, 16);
            label4.TabIndex = 106;
            label4.Text = "Nombre de flujo*";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(190, 31, 36);
            label1.Location = new Point(362, 377);
            label1.Name = "label1";
            label1.Size = new Size(122, 16);
            label1.TabIndex = 107;
            label1.Text = "Citas-Referencias*";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(190, 31, 36);
            label2.Location = new Point(133, 491);
            label2.Name = "label2";
            label2.Size = new Size(81, 16);
            label2.TabIndex = 108;
            label2.Text = "Comentario";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(190, 31, 36);
            label5.Location = new Point(10, 248);
            label5.Name = "label5";
            label5.Size = new Size(45, 16);
            label5.TabIndex = 109;
            label5.Text = "Valor*";
            // 
            // ListaEntradasSalidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 230, 230);
            ClientSize = new Size(736, 500);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(500, 500);
            Name = "ListaEntradasSalidas";
            Text = "ListaEntradasSalidas";
            tabControl1.ResumeLayout(false);
            ListaUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            EditarUsuarios.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage ListaUsuario;
        private Button button1;
        private DataGridView dataGridView1;
        private Button btnBorrar;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewButtonColumn Editar;
        private DataGridViewCheckBoxColumn Column6;
        private TabPage EditarUsuarios;
        private Panel panel1;
        private Button button3;
        private SistemaRegistro.Templates.TextBox textBox3;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label12;
        private Button button8;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private SistemaRegistro.Templates.TextBox textProceso;
        private ComboBox comboSeis;
        private ComboBox comboDos;
        private ComboBox comboUno;
        private Button buttonSiguienteP;
        private SistemaRegistro.Templates.TextBox textBox1;
        private ComboBox ComboTecno;
        private SistemaRegistro.Templates.TextBox textOtro;
        private Label labelUsuario;
        private Button button4;
        private Button btnSeleccionarT;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label5;
    }
}