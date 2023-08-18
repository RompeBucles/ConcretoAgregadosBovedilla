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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            ListaEntradas = new TabPage();
            panel2 = new Panel();
            textNusuario = new TextBox();
            btnSeleccionarT = new Button();
            btnBorrar = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            EditarEntradas = new TabPage();
            panel1 = new Panel();
            btnRegresar = new Button();
            comboUnidades = new ComboBox();
            label6 = new Label();
            comboProductoT = new ComboBox();
            label5 = new Label();
            ComboTecno = new ComboBox();
            label14 = new Label();
            textOtro = new Templates.TextBox();
            label4 = new Label();
            comboRecursos = new ComboBox();
            textValor = new Templates.TextBox();
            label2 = new Label();
            label1 = new Label();
            textComentario = new Templates.TextBox();
            textCitas = new Templates.TextBox();
            label15 = new Label();
            btnGuardar = new Button();
            label3 = new Label();
            comboTipoFlujo = new ComboBox();
            comboEmisiones = new ComboBox();
            comboAdquisicion = new ComboBox();
            comboTratamiento = new ComboBox();
            buttonSiguienteP = new Button();
            textBox1 = new Templates.TextBox();
            textNombreFlujo = new Templates.TextBox();
            labelUsuario = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel3 = new Panel();
            tabControl1.SuspendLayout();
            ListaEntradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            EditarEntradas.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(ListaEntradas);
            tabControl1.Controls.Add(EditarEntradas);
            tabControl1.Location = new Point(1, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(765, 517);
            tabControl1.TabIndex = 22;
            // 
            // ListaEntradas
            // 
            ListaEntradas.BackColor = Color.FromArgb(242, 230, 230);
            ListaEntradas.Controls.Add(panel2);
            ListaEntradas.Controls.Add(textNusuario);
            ListaEntradas.Controls.Add(btnSeleccionarT);
            ListaEntradas.Controls.Add(btnBorrar);
            ListaEntradas.Controls.Add(dataGridView1);
            ListaEntradas.Controls.Add(button1);
            ListaEntradas.Location = new Point(4, 24);
            ListaEntradas.Name = "ListaEntradas";
            ListaEntradas.Padding = new Padding(3);
            ListaEntradas.Size = new Size(757, 489);
            ListaEntradas.TabIndex = 0;
            ListaEntradas.Text = "ListaEntradas / Salidas";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Location = new Point(17, 438);
            panel2.Name = "panel2";
            panel2.Size = new Size(199, 38);
            panel2.TabIndex = 84;
            panel2.Visible = false;
            // 
            // textNusuario
            // 
            textNusuario.Anchor = AnchorStyles.None;
            textNusuario.Location = new Point(69, 438);
            textNusuario.Name = "textNusuario";
            textNusuario.Size = new Size(100, 23);
            textNusuario.TabIndex = 83;
            textNusuario.Visible = false;
            // 
            // btnSeleccionarT
            // 
            btnSeleccionarT.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSeleccionarT.BackColor = Color.FromArgb(190, 31, 36);
            btnSeleccionarT.FlatAppearance.BorderSize = 0;
            btnSeleccionarT.FlatStyle = FlatStyle.Flat;
            btnSeleccionarT.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSeleccionarT.ForeColor = SystemColors.ButtonFace;
            btnSeleccionarT.Location = new Point(426, 443);
            btnSeleccionarT.Name = "btnSeleccionarT";
            btnSeleccionarT.Size = new Size(151, 39);
            btnSeleccionarT.TabIndex = 76;
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
            btnBorrar.Location = new Point(598, 443);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(151, 39);
            btnBorrar.TabIndex = 75;
            btnBorrar.Text = "Borra Selección";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(748, 429);
            dataGridView1.TabIndex = 74;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(97, 97, 96);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(1162, 835);
            button1.Name = "button1";
            button1.Size = new Size(151, 39);
            button1.TabIndex = 67;
            button1.Text = "Borra Selección";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            // 
            // EditarEntradas
            // 
            EditarEntradas.AutoScroll = true;
            EditarEntradas.BackColor = Color.FromArgb(242, 230, 230);
            EditarEntradas.Controls.Add(panel1);
            EditarEntradas.Location = new Point(4, 24);
            EditarEntradas.Name = "EditarEntradas";
            EditarEntradas.Padding = new Padding(3);
            EditarEntradas.Size = new Size(757, 489);
            EditarEntradas.TabIndex = 1;
            EditarEntradas.Text = "Editar Entradas / Salidas";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(242, 230, 230);
            panel1.Controls.Add(btnRegresar);
            panel1.Controls.Add(comboUnidades);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(comboProductoT);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(ComboTecno);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(textOtro);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboRecursos);
            panel1.Controls.Add(textValor);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textComentario);
            panel1.Controls.Add(textCitas);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboTipoFlujo);
            panel1.Controls.Add(comboEmisiones);
            panel1.Controls.Add(comboAdquisicion);
            panel1.Controls.Add(comboTratamiento);
            panel1.Controls.Add(buttonSiguienteP);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textNombreFlujo);
            panel1.Controls.Add(labelUsuario);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 1127);
            panel1.TabIndex = 78;
            // 
            // btnRegresar
            // 
            btnRegresar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRegresar.BackColor = Color.FromArgb(190, 31, 36);
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegresar.ForeColor = SystemColors.ButtonFace;
            btnRegresar.Location = new Point(195, 1042);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(122, 40);
            btnRegresar.TabIndex = 164;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // comboUnidades
            // 
            comboUnidades.Anchor = AnchorStyles.None;
            comboUnidades.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUnidades.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboUnidades.FormattingEnabled = true;
            comboUnidades.Items.AddRange(new object[] { "Área (m²)", "Volumen (m³)", "Masa (kg)", "Radioactividad (kBq)", "Unidades (ítem)", "Longitud (m)", "Tiempo (s)", "Masa*Longitud (t*km)", "Volumen*Longitud (m³*km)", "Unidades de ítems*Longitud (Ítems*km)", "Área*tiempo (m²*año)", "Volumen*tiempo (m³*año)", "Energia (kWh)", "Energía (kJ)" });
            comboUnidades.Location = new Point(243, 462);
            comboUnidades.Name = "comboUnidades";
            comboUnidades.Size = new Size(266, 25);
            comboUnidades.TabIndex = 163;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(190, 31, 36);
            label6.Location = new Point(37, 45);
            label6.Name = "label6";
            label6.Size = new Size(64, 16);
            label6.TabIndex = 162;
            label6.Text = "Producto";
            // 
            // comboProductoT
            // 
            comboProductoT.Enabled = false;
            comboProductoT.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboProductoT.FormattingEnabled = true;
            comboProductoT.Location = new Point(37, 64);
            comboProductoT.Name = "comboProductoT";
            comboProductoT.Size = new Size(220, 25);
            comboProductoT.TabIndex = 161;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(190, 31, 36);
            label5.Location = new Point(277, 45);
            label5.Name = "label5";
            label5.Size = new Size(69, 16);
            label5.TabIndex = 160;
            label5.Text = "Tecnolgía";
            // 
            // ComboTecno
            // 
            ComboTecno.Enabled = false;
            ComboTecno.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ComboTecno.FormattingEnabled = true;
            ComboTecno.Location = new Point(277, 64);
            ComboTecno.Name = "ComboTecno";
            ComboTecno.Size = new Size(211, 25);
            ComboTecno.TabIndex = 159;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(190, 31, 36);
            label14.Location = new Point(494, 36);
            label14.Name = "label14";
            label14.Size = new Size(34, 16);
            label14.TabIndex = 158;
            label14.Text = "Otro";
            // 
            // textOtro
            // 
            textOtro.Anchor = AnchorStyles.None;
            textOtro.BackColor = SystemColors.Control;
            textOtro.BorderColor = SystemColors.ControlDarkDark;
            textOtro.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textOtro.BorderSize = 2;
            textOtro.Enabled = false;
            textOtro.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textOtro.ForeColor = Color.DimGray;
            textOtro.Location = new Point(494, 55);
            textOtro.Multiline = false;
            textOtro.Name = "textOtro";
            textOtro.Padding = new Padding(8);
            textOtro.PasswordChar = false;
            textOtro.Size = new Size(209, 34);
            textOtro.TabIndex = 157;
            textOtro.Texts = "Ejemplo: grava y arena";
            textOtro.UnderlinedStyle = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(190, 31, 36);
            label4.Location = new Point(350, 523);
            label4.Name = "label4";
            label4.Size = new Size(45, 16);
            label4.TabIndex = 123;
            label4.Text = "Valor*";
            // 
            // comboRecursos
            // 
            comboRecursos.Anchor = AnchorStyles.None;
            comboRecursos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRecursos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboRecursos.FormattingEnabled = true;
            comboRecursos.Items.AddRange(new object[] { "Elemento o Compuesto", "Grupo de químicos", "Mineral, metal o agregado.", "Biológico", "Agua", "Combustibles fósiles", "Combustibles nucleares.", "Energía", "Recurso – Recurso suelo", "Recurso – Recurso aire", "Recurso – Recurso agua", "Recursos – Recursos biótico", "Recursos – Recurso ocupación y transformación del suelo", "Recursos materiales no renovables del suelo", "Recursos de elementos no renovables del suelo", "Recursos de elementos renovables del suelo", "Recursos de energía renovable del suelo (por ejemplo, \"Energía eólica\", \"Energía hidráulica; funcionamiento\", etc.)", "Recursos materiales renovables del suelo", "Recursos renovables del suelo, no especificados", "Recursos no renovables del suelo, no especificados", "Uso del suelo - Transformación del suelo", "Uso del suelo - Ocupación del suelo", "Uso del suelo -  Cultivable", "Uso del suelo – No irrigado", "Uso del suelo – Diverso, intensivo." });
            comboRecursos.Location = new Point(86, 329);
            comboRecursos.Name = "comboRecursos";
            comboRecursos.Size = new Size(564, 25);
            comboRecursos.TabIndex = 122;
            comboRecursos.Enter += comboRecursos_Enter;
            comboRecursos.Leave += comboRecursos_Leave;
            // 
            // textValor
            // 
            textValor.Anchor = AnchorStyles.None;
            textValor.BackColor = SystemColors.Control;
            textValor.BorderColor = SystemColors.ControlDarkDark;
            textValor.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textValor.BorderSize = 2;
            textValor.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textValor.ForeColor = Color.DimGray;
            textValor.Location = new Point(268, 547);
            textValor.Multiline = false;
            textValor.Name = "textValor";
            textValor.Padding = new Padding(7, 10, 7, 10);
            textValor.PasswordChar = false;
            textValor.Size = new Size(207, 41);
            textValor.TabIndex = 121;
            textValor.Texts = "Ejemplo: 0";
            textValor.UnderlinedStyle = true;
            textValor.Enter += textValor_Enter;
            textValor.Leave += textValor_Leave;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(190, 31, 36);
            label2.Location = new Point(327, 932);
            label2.Name = "label2";
            label2.Size = new Size(81, 16);
            label2.TabIndex = 114;
            label2.Text = "Comentario";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(190, 31, 36);
            label1.Location = new Point(311, 822);
            label1.Name = "label1";
            label1.Size = new Size(117, 16);
            label1.TabIndex = 113;
            label1.Text = "Citas-Referencias";
            // 
            // textComentario
            // 
            textComentario.Anchor = AnchorStyles.None;
            textComentario.BackColor = SystemColors.Control;
            textComentario.BorderColor = SystemColors.ControlDarkDark;
            textComentario.BorderFocusColor = Color.Black;
            textComentario.BorderSize = 2;
            textComentario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textComentario.ForeColor = Color.DimGray;
            textComentario.Location = new Point(172, 956);
            textComentario.Multiline = false;
            textComentario.Name = "textComentario";
            textComentario.Padding = new Padding(7, 8, 7, 8);
            textComentario.PasswordChar = false;
            textComentario.Size = new Size(400, 36);
            textComentario.TabIndex = 112;
            textComentario.Texts = "Ejemplo: Expreso este comentario";
            textComentario.UnderlinedStyle = true;
            textComentario.Enter += textComentario_Enter;
            textComentario.Leave += textComentario_Leave;
            // 
            // textCitas
            // 
            textCitas.Anchor = AnchorStyles.None;
            textCitas.BackColor = SystemColors.Control;
            textCitas.BorderColor = SystemColors.ControlDarkDark;
            textCitas.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textCitas.BorderSize = 2;
            textCitas.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textCitas.ForeColor = Color.DimGray;
            textCitas.Location = new Point(173, 855);
            textCitas.Multiline = false;
            textCitas.Name = "textCitas";
            textCitas.Padding = new Padding(7, 8, 7, 8);
            textCitas.PasswordChar = false;
            textCitas.Size = new Size(387, 36);
            textCitas.TabIndex = 111;
            textCitas.Texts = "Ejemplo: “Manual del Ingeniero civil”";
            textCitas.UnderlinedStyle = true;
            textCitas.Enter += textCitas_Enter;
            textCitas.Leave += textCitas_Leave;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(190, 31, 36);
            label15.Location = new Point(307, 120);
            label15.Name = "label15";
            label15.Size = new Size(114, 16);
            label15.TabIndex = 110;
            label15.Text = "Nombre de flujo*";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.FromArgb(190, 31, 36);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = SystemColors.ButtonFace;
            btnGuardar.Location = new Point(390, 1043);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(132, 38);
            btnGuardar.TabIndex = 104;
            btnGuardar.Text = "Guardar datos";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(298, 12);
            label3.Name = "label3";
            label3.Size = new Size(146, 19);
            label3.TabIndex = 98;
            label3.Text = "Entradas / Salidas";
            // 
            // comboTipoFlujo
            // 
            comboTipoFlujo.Anchor = AnchorStyles.None;
            comboTipoFlujo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoFlujo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboTipoFlujo.FormattingEnabled = true;
            comboTipoFlujo.Items.AddRange(new object[] { "Elemental", "Producto", "Residuo" });
            comboTipoFlujo.Location = new Point(86, 254);
            comboTipoFlujo.Name = "comboTipoFlujo";
            comboTipoFlujo.Size = new Size(564, 25);
            comboTipoFlujo.TabIndex = 92;
            comboTipoFlujo.Enter += comboTipoFlujo_Enter;
            comboTipoFlujo.Leave += comboTipoFlujo_Leave;
            // 
            // comboEmisiones
            // 
            comboEmisiones.Anchor = AnchorStyles.None;
            comboEmisiones.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEmisiones.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboEmisiones.FormattingEnabled = true;
            comboEmisiones.Items.AddRange(new object[] { "Emisiones - Emisiones al aire - Emisiones al aire sin especificar", "Emisiones - Emisiones al aire - Emisiones sin especificar (a largo plazo)", "Emisiones - Emisiones al aire - Emisiones al aire no urbano o de chimeneas altas (alturas mayo a 100 m)", "Emisiones - Emisiones al aire - Emisiones a la baja estratosfera y a la alta troposfera", "Emisiones - Emisiones al aire - Emisiones inorgánicas al aire", "Emisiones - Emisiones al aire - Emisiones orgánicas al aire", "Emisiones - Emisiones al aire - Emisiones radioactivas al aire", "Emisiones - Emisiones al aire – Partículas", "Emisiones - Emisiones al aire - Otras emisiones al aire", "Emisiones - Emisiones al agua - Emisiones al agua, sin especificar.", "Emisiones - Emisiones al agua – Emisiones inorgánicas al agua", "Emisiones - Emisiones al agua – Emisiones orgánicas al agua", "Emisiones - Emisiones al agua – Emisiones radioactivas al agua", "Emisiones - Emisiones al agua – Emisiones de partículas al agua", "Emisiones - Emisiones al agua – Otras Emisiones al agua", "Emisiones - Emisiones al suelo - Emisiones al suelo, sin especificar", "Emisiones - Emisiones al suelo - Emisiones al suelo agrícola", "Emisiones - Emisiones al suelo - Emisiones al suelo no agrícola", "Emisiones - Emisiones al suelo - Emisiones al suelo, sin especificar (a largo plazo)", "Emisiones - Emisiones al suelo – Emisiones inorgánicas al suelo", "Emisiones - Emisiones al suelo – Emisiones orgánicas al suelo", "Emisiones - Emisiones al suelo – Emisiones radioactivas al suelo", "Emisiones - Emisiones al suelo – Emisiones de partículas al suelo", "Emisiones - Emisiones al suelo – Otras Emisiones al suelo", "Otros flujos elementales" });
            comboEmisiones.Location = new Point(86, 392);
            comboEmisiones.Name = "comboEmisiones";
            comboEmisiones.Size = new Size(564, 25);
            comboEmisiones.TabIndex = 93;
            comboEmisiones.Enter += comboEmisiones_Enter;
            comboEmisiones.Leave += comboEmisiones_Leave;
            // 
            // comboAdquisicion
            // 
            comboAdquisicion.Anchor = AnchorStyles.None;
            comboAdquisicion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAdquisicion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboAdquisicion.FormattingEnabled = true;
            comboAdquisicion.Items.AddRange(new object[] { "Publicaciones y comunicaciones", "Reporte de entidades estatales", "Bases de datos", "Clasificaciones estadísticas", "Formatos de conjuntos de datos", "Sistemas de cumplimiento", "Cuestionarios – Encuestas", "Entrevistas", "Imágenes", "Mediciones in situ", "Otros tipos de fuentes" });
            comboAdquisicion.Location = new Point(139, 740);
            comboAdquisicion.Name = "comboAdquisicion";
            comboAdquisicion.Size = new Size(459, 25);
            comboAdquisicion.TabIndex = 86;
            comboAdquisicion.Enter += comboAdquisicion_Enter;
            comboAdquisicion.Leave += comboAdquisicion_Leave;
            // 
            // comboTratamiento
            // 
            comboTratamiento.Anchor = AnchorStyles.None;
            comboTratamiento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTratamiento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboTratamiento.FormattingEnabled = true;
            comboTratamiento.Items.AddRange(new object[] { "Calculado: basado en relaciones estequiométricos.", "Estimado: basado en el juicio cuantitativo de expertos.", "Literatura: Derivación desconocida, no se ninguna otra indicación sobre el origen del valor.", "Valor medido: utilice este término cuando el valor haya sido medido." });
            comboTratamiento.Location = new Point(103, 649);
            comboTratamiento.Name = "comboTratamiento";
            comboTratamiento.Size = new Size(518, 25);
            comboTratamiento.TabIndex = 85;
            comboTratamiento.Enter += comboTratamiento_Enter;
            comboTratamiento.Leave += comboTratamiento_Leave;
            // 
            // buttonSiguienteP
            // 
            buttonSiguienteP.Anchor = AnchorStyles.None;
            buttonSiguienteP.BackColor = Color.FromArgb(97, 97, 96);
            buttonSiguienteP.FlatAppearance.BorderSize = 0;
            buttonSiguienteP.FlatStyle = FlatStyle.Flat;
            buttonSiguienteP.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSiguienteP.ForeColor = SystemColors.ButtonFace;
            buttonSiguienteP.Location = new Point(1109, 2032);
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
            textBox1.Location = new Point(1074, 1952);
            textBox1.Multiline = false;
            textBox1.Name = "textBox1";
            textBox1.Padding = new Padding(7);
            textBox1.PasswordChar = false;
            textBox1.Size = new Size(191, 30);
            textBox1.TabIndex = 81;
            textBox1.Texts = "Correo*";
            textBox1.UnderlinedStyle = true;
            // 
            // textNombreFlujo
            // 
            textNombreFlujo.Anchor = AnchorStyles.None;
            textNombreFlujo.BackColor = SystemColors.Control;
            textNombreFlujo.BorderColor = SystemColors.ControlDarkDark;
            textNombreFlujo.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textNombreFlujo.BorderSize = 2;
            textNombreFlujo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textNombreFlujo.ForeColor = Color.DimGray;
            textNombreFlujo.Location = new Point(139, 152);
            textNombreFlujo.Multiline = false;
            textNombreFlujo.Name = "textNombreFlujo";
            textNombreFlujo.Padding = new Padding(7, 8, 7, 8);
            textNombreFlujo.PasswordChar = false;
            textNombreFlujo.Size = new Size(482, 36);
            textNombreFlujo.TabIndex = 69;
            textNombreFlujo.Texts = "Ejemplo: Grava 20mm";
            textNombreFlujo.UnderlinedStyle = true;
            textNombreFlujo.Enter += textNombreFlujo_Enter;
            textNombreFlujo.Leave += textNombreFlujo_Leave;
            // 
            // labelUsuario
            // 
            labelUsuario.Anchor = AnchorStyles.Top;
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsuario.ForeColor = Color.Red;
            labelUsuario.Location = new Point(850, -183);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(111, 19);
            labelUsuario.TabIndex = 29;
            labelUsuario.Text = "Identificación";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel3
            // 
            panel3.Location = new Point(2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(267, 24);
            panel3.TabIndex = 86;
            // 
            // ListaEntradasSalidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 230, 230);
            ClientSize = new Size(768, 522);
            Controls.Add(panel3);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(500, 500);
            Name = "ListaEntradasSalidas";
            Text = "ListaEntradasSalidas";
            Load += ListaEntradasSalidas_Load;
            tabControl1.ResumeLayout(false);
            ListaEntradas.ResumeLayout(false);
            ListaEntradas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            EditarEntradas.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage ListaEntradas;
        private Button button1;
        private TabPage EditarEntradas;
        private DataGridView dataGridView1;
        private Button btnSeleccionarT;
        private Button btnBorrar;
        private Panel panel1;
        private Label label4;
        private ComboBox comboRecursos;
        private Templates.TextBox textValor;
        private Label label2;
        private Label label1;
        private Templates.TextBox textComentario;
        private Templates.TextBox textCitas;
        private Label label15;
        private Button btnGuardar;
        private Label label3;
        private ComboBox comboTipoFlujo;
        private ComboBox comboEmisiones;
        private ComboBox comboAdquisicion;
        private ComboBox comboTratamiento;
        private Button buttonSiguienteP;
        private Templates.TextBox textBox1;
        private Templates.TextBox textNombreFlujo;
        private Label labelUsuario;
        private ErrorProvider errorProvider1;
        public ComboBox ComboTecno;
        private Label label14;
        private Templates.TextBox textOtro;
        private Label label5;
        private Label label6;
        public ComboBox comboProductoT;
        private ComboBox comboUnidades;
        private Button btnRegresar;
        private Panel panel2;
        private TextBox textNusuario;
        private Panel panel3;
    }
}