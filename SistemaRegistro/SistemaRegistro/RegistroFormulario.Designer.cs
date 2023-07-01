using System.Windows.Forms;

namespace SistemaRegistro
{
    partial class RegistroFormulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroFormulario));
            tabControl1 = new TabControl();
            Identificación = new TabPage();
            panel1 = new Panel();
            ComboProducto = new ComboBox();
            ComboTecno = new ComboBox();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label18 = new Label();
            label12 = new Label();
            label17 = new Label();
            label16 = new Label();
            textCorreo = new Templates.TextBox();
            textAutor = new Templates.TextBox();
            label15 = new Label();
            label14 = new Label();
            textProceso = new Templates.TextBox();
            textOtro = new Templates.TextBox();
            label4 = new Label();
            comboSiete = new ComboBox();
            comboSeis = new ComboBox();
            comboCinco = new ComboBox();
            comboCuatro = new ComboBox();
            comboTres = new ComboBox();
            comboDos = new ComboBox();
            comboUno = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            labelUsuario = new Label();
            Referencia = new TabPage();
            panel4 = new Panel();
            label28 = new Label();
            textValor = new Templates.TextBox();
            btnEliminarImagen = new Button();
            label13 = new Label();
            label19 = new Label();
            label20 = new Label();
            textObjetivoR = new Templates.TextBox();
            textUnidadFuncional = new Templates.TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            comboLimitesSistema = new ComboBox();
            comboUnidadUno = new ComboBox();
            textBox7 = new Templates.TextBox();
            label3 = new Label();
            Tecnología = new TabPage();
            panel2 = new Panel();
            label21 = new Label();
            textCondicionesOpe = new Templates.TextBox();
            ComboTipoTecnologia = new ComboBox();
            label6 = new Label();
            TiempoVálido = new TabPage();
            panel3 = new Panel();
            FechaDatosValidos = new DateTimePicker();
            FechaReferencia = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            label22 = new Label();
            textDescripcionPeriodo = new Templates.TextBox();
            label7 = new Label();
            Geografía = new TabPage();
            panel5 = new Panel();
            panel6 = new Panel();
            txtlongitud = new Templates.TextBox();
            txtlatitud = new Templates.TextBox();
            gMapControl2 = new GMap.NET.WindowsForms.GMapControl();
            panel7 = new Panel();
            label11 = new Label();
            trackZoom = new TrackBar();
            buttonGuardarG = new Button();
            dataGridView1 = new DataGridView();
            comboArea = new ComboBox();
            comboEstado = new ComboBox();
            label10 = new Label();
            imageList1 = new ImageList(components);
            errorProvider1 = new ErrorProvider(components);
            timer1 = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            Identificación.SuspendLayout();
            panel1.SuspendLayout();
            Referencia.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Tecnología.SuspendLayout();
            panel2.SuspendLayout();
            TiempoVálido.SuspendLayout();
            panel3.SuspendLayout();
            Geografía.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackZoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(Identificación);
            tabControl1.Controls.Add(Referencia);
            tabControl1.Controls.Add(Tecnología);
            tabControl1.Controls.Add(TiempoVálido);
            tabControl1.Controls.Add(Geografía);
            tabControl1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.ImageList = imageList1;
            tabControl1.Location = new Point(1, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(750, 519);
            tabControl1.TabIndex = 1;
            tabControl1.Click += buttonsTabControl_Click;
            // 
            // Identificación
            // 
            Identificación.AutoScroll = true;
            Identificación.BackColor = Color.FromArgb(242, 230, 230);
            Identificación.Controls.Add(panel1);
            Identificación.Location = new Point(4, 26);
            Identificación.Name = "Identificación";
            Identificación.Padding = new Padding(3);
            Identificación.Size = new Size(742, 489);
            Identificación.TabIndex = 0;
            Identificación.Text = "Identificación";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(242, 230, 230);
            panel1.Controls.Add(ComboProducto);
            panel1.Controls.Add(ComboTecno);
            panel1.Controls.Add(label27);
            panel1.Controls.Add(label26);
            panel1.Controls.Add(label25);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(textCorreo);
            panel1.Controls.Add(textAutor);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(textProceso);
            panel1.Controls.Add(textOtro);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboSiete);
            panel1.Controls.Add(comboSeis);
            panel1.Controls.Add(comboCinco);
            panel1.Controls.Add(comboCuatro);
            panel1.Controls.Add(comboTres);
            panel1.Controls.Add(comboDos);
            panel1.Controls.Add(comboUno);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelUsuario);
            panel1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(736, 779);
            panel1.TabIndex = 76;
            // 
            // ComboProducto
            // 
            ComboProducto.FormattingEnabled = true;
            ComboProducto.Items.AddRange(new object[] { "Cemento", "Concreto", "Acero estructural", "Ladrillos", "Madera", "Vidrio", "Aislamiento térmico", "Pinturas y recubrimientos", "Azulejos y baldosas", "Adhesivos y selladores", "Impermeabilizantes", "Sistemas de fontanería", "Sistemas eléctricos", "Sistemas de climatización" });
            ComboProducto.Location = new Point(37, 70);
            ComboProducto.Name = "ComboProducto";
            ComboProducto.Size = new Size(222, 24);
            ComboProducto.TabIndex = 130;
            ComboProducto.Text = "Producto*";
            ComboProducto.Enter += ComboProducto_Enter;
            ComboProducto.Leave += ComboProducto_Leave;
            // 
            // ComboTecno
            // 
            ComboTecno.FormattingEnabled = true;
            ComboTecno.Items.AddRange(new object[] { "Cemento Portland", "Concreto reforzado", "Concreto premezclado", "Concreto de alto rendimiento", "Ladrillos cerámicos", "Ladrillos de hormigón", "Acero laminado en caliente", "Madera laminada encolada", "Madera tratada", "Vidrio de seguridad laminado", "Vidrio aislante", "Azulejos de cerámica esmaltada", "Baldosas de porcelana", "Espuma de poliestireno expandido (EPS)", "Lana mineral", "Membranas asfálticas", "Pinturas impermeabilizantes" });
            ComboTecno.Location = new Point(274, 70);
            ComboTecno.Name = "ComboTecno";
            ComboTecno.Size = new Size(219, 24);
            ComboTecno.TabIndex = 129;
            ComboTecno.Text = "Tecnología*";
            ComboTecno.Enter += ComboTecno_Enter;
            ComboTecno.Leave += ComboTecno_Leave;
            // 
            // label27
            // 
            label27.Anchor = AnchorStyles.None;
            label27.AutoSize = true;
            label27.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label27.ForeColor = Color.FromArgb(190, 31, 36);
            label27.Location = new Point(92, 445);
            label27.Name = "label27";
            label27.Size = new Size(99, 16);
            label27.TabIndex = 128;
            label27.Text = "Otros servicios";
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.None;
            label26.AutoSize = true;
            label26.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label26.ForeColor = Color.FromArgb(190, 31, 36);
            label26.Location = new Point(384, 378);
            label26.Name = "label26";
            label26.Size = new Size(102, 16);
            label26.TabIndex = 127;
            label26.Text = "Uso y consumo";
            // 
            // label25
            // 
            label25.Anchor = AnchorStyles.None;
            label25.AutoSize = true;
            label25.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = Color.FromArgb(190, 31, 36);
            label25.Location = new Point(91, 378);
            label25.Name = "label25";
            label25.Size = new Size(157, 16);
            label25.TabIndex = 126;
            label25.Text = "Servicios de transporte:";
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.None;
            label24.AutoSize = true;
            label24.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = Color.FromArgb(190, 31, 36);
            label24.Location = new Point(384, 317);
            label24.Name = "label24";
            label24.Size = new Size(222, 16);
            label24.TabIndex = 125;
            label24.Text = "Tratamiento al final de la vida útil";
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.None;
            label23.AutoSize = true;
            label23.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.FromArgb(190, 31, 36);
            label23.Location = new Point(91, 317);
            label23.Name = "label23";
            label23.Size = new Size(168, 16);
            label23.TabIndex = 124;
            label23.Text = "Materiales de producción";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.None;
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.FromArgb(190, 31, 36);
            label18.Location = new Point(384, 260);
            label18.Name = "label18";
            label18.Size = new Size(64, 16);
            label18.TabIndex = 123;
            label18.Text = "Sistemas";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(190, 31, 36);
            label12.Location = new Point(91, 260);
            label12.Name = "label12";
            label12.Size = new Size(235, 16);
            label12.TabIndex = 122;
            label12.Text = "Portadores de energía y tecnología ";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.None;
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.FromArgb(190, 31, 36);
            label17.Location = new Point(297, 639);
            label17.Name = "label17";
            label17.Size = new Size(130, 16);
            label17.TabIndex = 121;
            label17.Text = "Correo electrónico*";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(190, 31, 36);
            label16.Location = new Point(316, 571);
            label16.Name = "label16";
            label16.Size = new Size(77, 16);
            label16.TabIndex = 120;
            label16.Text = "Autor ACV*";
            // 
            // textCorreo
            // 
            textCorreo.Anchor = AnchorStyles.None;
            textCorreo.BackColor = SystemColors.Control;
            textCorreo.BorderColor = SystemColors.ControlDarkDark;
            textCorreo.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textCorreo.BorderSize = 2;
            textCorreo.ForeColor = Color.DimGray;
            textCorreo.Location = new Point(230, 663);
            textCorreo.Multiline = false;
            textCorreo.Name = "textCorreo";
            textCorreo.Padding = new Padding(8, 7, 8, 7);
            textCorreo.PasswordChar = false;
            textCorreo.Size = new Size(263, 31);
            textCorreo.TabIndex = 117;
            textCorreo.Texts = "Ejemplo: ejemplo@unam.gob.mx";
            textCorreo.UnderlinedStyle = true;
            textCorreo.Enter += textCorreo_Enter;
            textCorreo.Leave += textCorreo_Leave;
            // 
            // textAutor
            // 
            textAutor.Anchor = AnchorStyles.None;
            textAutor.BackColor = SystemColors.Control;
            textAutor.BorderColor = SystemColors.ControlDarkDark;
            textAutor.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textAutor.BorderSize = 2;
            textAutor.ForeColor = Color.DimGray;
            textAutor.Location = new Point(235, 593);
            textAutor.Multiline = true;
            textAutor.Name = "textAutor";
            textAutor.Padding = new Padding(8, 7, 8, 7);
            textAutor.PasswordChar = false;
            textAutor.Size = new Size(258, 32);
            textAutor.TabIndex = 115;
            textAutor.Texts = "Ejemplo: Centro Mario Molina";
            textAutor.UnderlinedStyle = true;
            textAutor.Enter += textAutor_Enter;
            textAutor.Leave += textAutor_Leave;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(190, 31, 36);
            label15.Location = new Point(52, 126);
            label15.Name = "label15";
            label15.Size = new Size(140, 16);
            label15.TabIndex = 113;
            label15.Text = "Nombre del proceso*";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(190, 31, 36);
            label14.Location = new Point(510, 44);
            label14.Name = "label14";
            label14.Size = new Size(39, 16);
            label14.TabIndex = 112;
            label14.Text = "Otro*";
            // 
            // textProceso
            // 
            textProceso.Anchor = AnchorStyles.None;
            textProceso.BackColor = SystemColors.Control;
            textProceso.BorderColor = SystemColors.ControlDarkDark;
            textProceso.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textProceso.BorderSize = 2;
            textProceso.ForeColor = Color.DimGray;
            textProceso.Location = new Point(53, 145);
            textProceso.Multiline = false;
            textProceso.Name = "textProceso";
            textProceso.Padding = new Padding(8, 7, 8, 7);
            textProceso.PasswordChar = false;
            textProceso.Size = new Size(305, 31);
            textProceso.TabIndex = 111;
            textProceso.Texts = "Ejemplo: Elaboración de concreto simple";
            textProceso.UnderlinedStyle = true;
            textProceso.Enter += textProceso_Enter;
            textProceso.Leave += textProceso_Leave;
            // 
            // textOtro
            // 
            textOtro.Anchor = AnchorStyles.None;
            textOtro.BackColor = SystemColors.Control;
            textOtro.BorderColor = SystemColors.ControlDarkDark;
            textOtro.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textOtro.BorderSize = 2;
            textOtro.ForeColor = Color.DimGray;
            textOtro.Location = new Point(510, 63);
            textOtro.Multiline = false;
            textOtro.Name = "textOtro";
            textOtro.Padding = new Padding(8, 7, 8, 7);
            textOtro.PasswordChar = false;
            textOtro.Size = new Size(207, 31);
            textOtro.TabIndex = 110;
            textOtro.Texts = "Ejemplo: grava y arena";
            textOtro.UnderlinedStyle = true;
            textOtro.Enter += textOtro_Enter;
            textOtro.Leave += textOtro_Leave;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(274, 224);
            label4.Name = "label4";
            label4.Size = new Size(209, 16);
            label4.TabIndex = 91;
            label4.Text = "Solo puede elegir una sola lista";
            // 
            // comboSiete
            // 
            comboSiete.Anchor = AnchorStyles.None;
            comboSiete.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSiete.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboSiete.FormattingEnabled = true;
            comboSiete.Items.AddRange(new object[] { "Limpieza", "Almacenamiento", "Salud, servicios sociales, belleza y bienestar", "Reparación y mantenimiento", "Venta y venta al por mayor", "Servicios de comunicación e información", "Financiero, jurídico y de seguros", "Administración y gobierno", "Defensa", "Alojamiento y gastronomía", "Educación", "Investigación y desarrollo", "Entretenimiento", "Alquiler", "Ingeniería y consultoría", "Otros servicios" });
            comboSiete.Location = new Point(91, 464);
            comboSiete.Name = "comboSiete";
            comboSiete.Size = new Size(266, 24);
            comboSiete.TabIndex = 90;
            comboSiete.SelectedIndexChanged += comboSiete_SelectedIndexChanged;
            // 
            // comboSeis
            // 
            comboSeis.Anchor = AnchorStyles.None;
            comboSeis.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSeis.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboSeis.FormattingEnabled = true;
            comboSeis.Items.AddRange(new object[] { "Consumo de productos", "Uso de productos que consumen energía", "Otros usos y consumos" });
            comboSeis.Location = new Point(384, 397);
            comboSeis.Name = "comboSeis";
            comboSeis.Size = new Size(265, 24);
            comboSeis.TabIndex = 89;
            comboSeis.SelectedIndexChanged += comboSeis_SelectedIndexChanged;
            // 
            // comboCinco
            // 
            comboCinco.Anchor = AnchorStyles.None;
            comboCinco.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCinco.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboCinco.FormattingEnabled = true;
            comboCinco.Items.AddRange(new object[] { "Carretera", "Ferrocarril", "Agua", "Aire", "Otros transportes" });
            comboCinco.Location = new Point(91, 397);
            comboCinco.Name = "comboCinco";
            comboCinco.Size = new Size(266, 24);
            comboCinco.TabIndex = 88;
            comboCinco.SelectedIndexChanged += comboCinco_SelectedIndexChanged;
            // 
            // comboCuatro
            // 
            comboCuatro.Anchor = AnchorStyles.None;
            comboCuatro.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCuatro.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboCuatro.FormattingEnabled = true;
            comboCuatro.Items.AddRange(new object[] { "Reutilización o utilización posterior", "Reciclaje de materiales", "Reciclaje de materias primas", "Reciclaje energético", "Vertedero", "Recogida de residuos", "Tratamiento de aguas residuales", "Tratamiento de gas bruto", "Otros servicios al final de la vida útil" });
            comboCuatro.Location = new Point(384, 336);
            comboCuatro.Name = "comboCuatro";
            comboCuatro.Size = new Size(265, 24);
            comboCuatro.TabIndex = 87;
            comboCuatro.SelectedIndexChanged += comboCuatro_SelectedIndexChanged;
            // 
            // comboTres
            // 
            comboTres.Anchor = AnchorStyles.None;
            comboTres.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTres.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboTres.FormattingEnabled = true;
            comboTres.Items.AddRange(new object[] { "Materias primas no energéticas", "Metales y semimetales", "Productos químicos orgánicos", "Productos químicos inorgánicos", "Vidrio y cerámica", "Otros materiales minerales", "Plásticos", "Papel y cartón", "Material agua", "Medios de producción agrícola", "Alimentos y materias primas renovables", "Madera", "Otros materiales" });
            comboTres.Location = new Point(91, 336);
            comboTres.Name = "comboTres";
            comboTres.Size = new Size(266, 24);
            comboTres.TabIndex = 87;
            comboTres.SelectedIndexChanged += comboTres_SelectedIndexChanged;
            // 
            // comboDos
            // 
            comboDos.Anchor = AnchorStyles.None;
            comboDos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboDos.FormattingEnabled = true;
            comboDos.Items.AddRange(new object[] { "Embalaje", "Electricidad y electrónica", "Vehículos", "Otras maquinas", "Construcción", "Electrodomésticos", "Textiles, muebles y otros interiores", "Partes no especificas", "Pinturas y preparados químicos", "Otros sistemas" });
            comboDos.Location = new Point(384, 279);
            comboDos.Name = "comboDos";
            comboDos.Size = new Size(265, 24);
            comboDos.TabIndex = 86;
            comboDos.SelectedIndexChanged += comboDos_SelectedIndexChanged;
            // 
            // comboUno
            // 
            comboUno.Anchor = AnchorStyles.None;
            comboUno.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUno.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboUno.FormattingEnabled = true;
            comboUno.Items.AddRange(new object[] { "Materias primas energéticas", "Electricidad", "Calor y vapor", "Energía mecánica", "Combustibles a base de hulla", "Combustibles a base de lignito", "Combustibles a base de petróleo crudo", "Combustibles a base de gas natural", "Combustibles nucleares", "Otros combustibles no renovables", "Combustibles renovables" });
            comboUno.Location = new Point(91, 279);
            comboUno.Name = "comboUno";
            comboUno.Size = new Size(266, 24);
            comboUno.TabIndex = 85;
            comboUno.SelectedIndexChanged += comboUno_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(314, 205);
            label2.Name = "label2";
            label2.Size = new Size(133, 19);
            label2.TabIndex = 84;
            label2.Text = "Tipo de proceso";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(294, 530);
            label1.Name = "label1";
            label1.Size = new Size(148, 19);
            label1.TabIndex = 82;
            label1.Text = "Datos de contacto";
            // 
            // labelUsuario
            // 
            labelUsuario.Anchor = AnchorStyles.Top;
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsuario.ForeColor = Color.Red;
            labelUsuario.Location = new Point(316, 9);
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
            Referencia.Location = new Point(4, 26);
            Referencia.Name = "Referencia";
            Referencia.Padding = new Padding(3);
            Referencia.Size = new Size(742, 489);
            Referencia.TabIndex = 1;
            Referencia.Text = "Referencia";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.AutoScroll = true;
            panel4.BackColor = Color.FromArgb(242, 230, 230);
            panel4.Controls.Add(label28);
            panel4.Controls.Add(textValor);
            panel4.Controls.Add(btnEliminarImagen);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(label20);
            panel4.Controls.Add(textObjetivoR);
            panel4.Controls.Add(textUnidadFuncional);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(comboLimitesSistema);
            panel4.Controls.Add(comboUnidadUno);
            panel4.Controls.Add(textBox7);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(-72, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(735, 990);
            panel4.TabIndex = 77;
            // 
            // label28
            // 
            label28.Anchor = AnchorStyles.None;
            label28.AutoSize = true;
            label28.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label28.ForeColor = Color.FromArgb(190, 31, 36);
            label28.Location = new Point(19, 56);
            label28.Name = "label28";
            label28.Size = new Size(688, 16);
            label28.TabIndex = 121;
            label28.Text = "Nota: Cantidad de PRODUCTO necesarios para cumplir la FUNCIÓN  en un determinado TIEMPO y ESPACIO";
            // 
            // textValor
            // 
            textValor.Anchor = AnchorStyles.None;
            textValor.BackColor = SystemColors.Control;
            textValor.BorderColor = SystemColors.ControlDarkDark;
            textValor.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textValor.BorderSize = 2;
            textValor.ForeColor = Color.DimGray;
            textValor.Location = new Point(203, 219);
            textValor.Multiline = true;
            textValor.Name = "textValor";
            textValor.Padding = new Padding(7, 9, 7, 9);
            textValor.PasswordChar = false;
            textValor.Size = new Size(348, 39);
            textValor.TabIndex = 120;
            textValor.Texts = "Ejemplo: 0";
            textValor.UnderlinedStyle = true;
            textValor.Enter += textValor_Enter;
            textValor.Leave += textValor_Leave;
            // 
            // btnEliminarImagen
            // 
            btnEliminarImagen.Anchor = AnchorStyles.None;
            btnEliminarImagen.BackColor = Color.FromArgb(190, 31, 36);
            btnEliminarImagen.FlatAppearance.BorderSize = 0;
            btnEliminarImagen.FlatStyle = FlatStyle.Flat;
            btnEliminarImagen.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarImagen.ForeColor = SystemColors.ButtonFace;
            btnEliminarImagen.Location = new Point(327, 925);
            btnEliminarImagen.Name = "btnEliminarImagen";
            btnEliminarImagen.Size = new Size(121, 36);
            btnEliminarImagen.TabIndex = 119;
            btnEliminarImagen.Text = "Eliminar imagen";
            btnEliminarImagen.UseVisualStyleBackColor = false;
            btnEliminarImagen.Click += btnEliminarImagen_Click;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(190, 31, 36);
            label13.Location = new Point(354, 200);
            label13.Name = "label13";
            label13.Size = new Size(45, 16);
            label13.TabIndex = 118;
            label13.Text = "Valor*";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.None;
            label19.AutoSize = true;
            label19.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(190, 31, 36);
            label19.Location = new Point(339, 278);
            label19.Name = "label19";
            label19.Size = new Size(60, 16);
            label19.TabIndex = 117;
            label19.Text = "Objetivo";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.None;
            label20.AutoSize = true;
            label20.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.FromArgb(190, 31, 36);
            label20.Location = new Point(264, 40);
            label20.Name = "label20";
            label20.Size = new Size(207, 16);
            label20.TabIndex = 116;
            label20.Text = "Nombre del flujo de referencia*";
            // 
            // textObjetivoR
            // 
            textObjetivoR.Anchor = AnchorStyles.None;
            textObjetivoR.BackColor = SystemColors.Control;
            textObjetivoR.BorderColor = SystemColors.ControlDarkDark;
            textObjetivoR.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textObjetivoR.BorderSize = 2;
            textObjetivoR.ForeColor = Color.DimGray;
            textObjetivoR.Location = new Point(203, 297);
            textObjetivoR.Multiline = true;
            textObjetivoR.Name = "textObjetivoR";
            textObjetivoR.Padding = new Padding(7, 8, 7, 8);
            textObjetivoR.PasswordChar = false;
            textObjetivoR.Size = new Size(348, 34);
            textObjetivoR.TabIndex = 115;
            textObjetivoR.Texts = "Ejemplo: Estimar la huella de carbono";
            textObjetivoR.UnderlinedStyle = true;
            textObjetivoR.Enter += textObjetivoR_Enter;
            textObjetivoR.Leave += textObjetivoR_Leave;
            // 
            // textUnidadFuncional
            // 
            textUnidadFuncional.Anchor = AnchorStyles.None;
            textUnidadFuncional.BackColor = SystemColors.Control;
            textUnidadFuncional.BorderColor = SystemColors.ControlDarkDark;
            textUnidadFuncional.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textUnidadFuncional.BorderSize = 2;
            textUnidadFuncional.ForeColor = Color.DimGray;
            textUnidadFuncional.Location = new Point(159, 84);
            textUnidadFuncional.Multiline = true;
            textUnidadFuncional.Name = "textUnidadFuncional";
            textUnidadFuncional.Padding = new Padding(7, 8, 7, 8);
            textUnidadFuncional.PasswordChar = false;
            textUnidadFuncional.Size = new Size(446, 34);
            textUnidadFuncional.TabIndex = 114;
            textUnidadFuncional.Texts = "Ejemplo: Producción de un kilogramo de arena y un kilogramo de grava";
            textUnidadFuncional.UnderlinedStyle = true;
            textUnidadFuncional.Enter += textUnidadFuncional_Enter;
            textUnidadFuncional.Leave += textUnidadFuncional_Leave;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(298, 426);
            label5.Name = "label5";
            label5.Size = new Size(155, 19);
            label5.TabIndex = 85;
            label5.Text = "Imagen del sistema";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.Location = new Point(91, 448);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(596, 474);
            pictureBox1.TabIndex = 82;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(97, 97, 96);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(480, 1176);
            button2.Name = "button2";
            button2.Size = new Size(115, 35);
            button2.TabIndex = 81;
            button2.Text = "Atras";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(97, 97, 96);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(683, 1176);
            button1.Name = "button1";
            button1.Size = new Size(115, 35);
            button1.TabIndex = 80;
            button1.Text = "Siguiente";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboLimitesSistema
            // 
            comboLimitesSistema.DropDownStyle = ComboBoxStyle.DropDownList;
            comboLimitesSistema.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboLimitesSistema.FormattingEnabled = true;
            comboLimitesSistema.Items.AddRange(new object[] { "Limitaciones presupuestarias", "Limitaciones de tiempo", "Limitaciones de recursos naturales", "Limitaciones de espacio", "Limitaciones ambientales", "Limitaciones de capacidad", "Limitaciones geotécnicas", "Limitaciones tecnológicas", "Limitaciones normativas y legales", "Limitaciones de seguridad" });
            comboLimitesSistema.Location = new Point(203, 373);
            comboLimitesSistema.Name = "comboLimitesSistema";
            comboLimitesSistema.Size = new Size(348, 25);
            comboLimitesSistema.TabIndex = 76;
            comboLimitesSistema.Enter += comboLimitesSistema_Enter;
            comboLimitesSistema.Leave += comboLimitesSistema_Leave;
            // 
            // comboUnidadUno
            // 
            comboUnidadUno.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUnidadUno.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboUnidadUno.FormattingEnabled = true;
            comboUnidadUno.Items.AddRange(new object[] { "Área (m²)", "Área (ha)", "Área*Tiempo (m²*año)", "Capacidad de peso (kg*s)", "Capacidad de volumen (l*hora)", "Capacidad de conversión de energía (MW)", "Densidad (kg*l)", "Masa (kg)", "Capacidad de peso (kg*s)", "Longitud (m)", "Servicio de transporte (ton*km)", "Servicio de transporte (persona*km)", "Metro*año (m*año)", "Unidad (item)", "Electricidad (kWh)", "Energía (MJ)", "Tiempo de uso del equipo (hora)", "Productos líquidos (l)", "Volumen (m³)", "Energia (KWh)", "Energía (kJ)" });
            comboUnidadUno.Location = new Point(203, 142);
            comboUnidadUno.Name = "comboUnidadUno";
            comboUnidadUno.Size = new Size(348, 25);
            comboUnidadUno.TabIndex = 74;
            comboUnidadUno.Enter += comboUnidadUno_Enter;
            comboUnidadUno.Leave += comboUnidadUno_Leave;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.None;
            textBox7.BackColor = SystemColors.Control;
            textBox7.BorderColor = SystemColors.ControlDarkDark;
            textBox7.BorderFocusColor = Color.Black;
            textBox7.BorderSize = 2;
            textBox7.Location = new Point(916, 776);
            textBox7.Multiline = false;
            textBox7.Name = "textBox7";
            textBox7.Padding = new Padding(7, 8, 7, 8);
            textBox7.PasswordChar = false;
            textBox7.Size = new Size(222, 32);
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
            label3.Location = new Point(326, 13);
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
            Tecnología.Location = new Point(4, 26);
            Tecnología.Name = "Tecnología";
            Tecnología.Size = new Size(742, 489);
            Tecnología.TabIndex = 2;
            Tecnología.Text = "Tecnología";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(242, 230, 230);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(textCondicionesOpe);
            panel2.Controls.Add(ComboTipoTecnologia);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(0, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(736, 468);
            panel2.TabIndex = 0;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.None;
            label21.AutoSize = true;
            label21.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.FromArgb(190, 31, 36);
            label21.Location = new Point(284, 159);
            label21.Name = "label21";
            label21.Size = new Size(173, 16);
            label21.TabIndex = 114;
            label21.Text = "Condiciones de operación";
            // 
            // textCondicionesOpe
            // 
            textCondicionesOpe.Anchor = AnchorStyles.None;
            textCondicionesOpe.BackColor = SystemColors.Control;
            textCondicionesOpe.BorderColor = SystemColors.ControlDarkDark;
            textCondicionesOpe.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textCondicionesOpe.BorderSize = 2;
            textCondicionesOpe.ForeColor = Color.DimGray;
            textCondicionesOpe.Location = new Point(193, 178);
            textCondicionesOpe.Multiline = true;
            textCondicionesOpe.Name = "textCondicionesOpe";
            textCondicionesOpe.Padding = new Padding(7, 8, 7, 8);
            textCondicionesOpe.PasswordChar = false;
            textCondicionesOpe.Size = new Size(360, 34);
            textCondicionesOpe.TabIndex = 113;
            textCondicionesOpe.Texts = "Ejemplo: En este estudio se considera una revolvedora";
            textCondicionesOpe.UnderlinedStyle = true;
            textCondicionesOpe.Enter += textCondicionesOpe_Enter;
            textCondicionesOpe.Leave += textCondicionesOpe_Leave;
            // 
            // ComboTipoTecnologia
            // 
            ComboTipoTecnologia.Anchor = AnchorStyles.None;
            ComboTipoTecnologia.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboTipoTecnologia.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ComboTipoTecnologia.FormattingEnabled = true;
            ComboTipoTecnologia.Items.AddRange(new object[] { "Innovación (Laboratorio, prototipo, piloto, demostración)", "Moderna", "Actual (más encontrada en operación)", "Antigua", "Mix.Tecnologías" });
            ComboTipoTecnologia.Location = new Point(208, 75);
            ComboTipoTecnologia.Name = "ComboTipoTecnologia";
            ComboTipoTecnologia.Size = new Size(323, 25);
            ComboTipoTecnologia.TabIndex = 75;
            ComboTipoTecnologia.Enter += ComboTipoTecnologia_Enter;
            ComboTipoTecnologia.Leave += ComboTipoTecnologia_Leave;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(335, 9);
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
            TiempoVálido.Location = new Point(4, 26);
            TiempoVálido.Name = "TiempoVálido";
            TiempoVálido.Size = new Size(742, 489);
            TiempoVálido.TabIndex = 3;
            TiempoVálido.Text = "TiempoVálido";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(242, 230, 230);
            panel3.Controls.Add(FechaDatosValidos);
            panel3.Controls.Add(FechaReferencia);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label22);
            panel3.Controls.Add(textDescripcionPeriodo);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(0, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(739, 470);
            panel3.TabIndex = 1;
            // 
            // FechaDatosValidos
            // 
            FechaDatosValidos.CustomFormat = "yyyy-MM-dd";
            FechaDatosValidos.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FechaDatosValidos.Format = DateTimePickerFormat.Custom;
            FechaDatosValidos.Location = new Point(240, 165);
            FechaDatosValidos.Name = "FechaDatosValidos";
            FechaDatosValidos.Size = new Size(264, 22);
            FechaDatosValidos.TabIndex = 105;
            // 
            // FechaReferencia
            // 
            FechaReferencia.CustomFormat = "yyyy-MM-dd";
            FechaReferencia.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FechaReferencia.Format = DateTimePickerFormat.Custom;
            FechaReferencia.Location = new Point(240, 96);
            FechaReferencia.Name = "FechaReferencia";
            FechaReferencia.Size = new Size(264, 22);
            FechaReferencia.TabIndex = 105;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(190, 31, 36);
            label8.Location = new Point(266, 249);
            label8.Name = "label8";
            label8.Size = new Size(226, 16);
            label8.TabIndex = 119;
            label8.Text = "Descripción del periodo de tiempo";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Crimson;
            label9.Location = new Point(299, 146);
            label9.Name = "label9";
            label9.Size = new Size(131, 16);
            label9.TabIndex = 118;
            label9.Text = "Datos Válidos hasta";
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.None;
            label22.AutoSize = true;
            label22.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.Crimson;
            label22.Location = new Point(266, 77);
            label22.Name = "label22";
            label22.Size = new Size(209, 16);
            label22.TabIndex = 117;
            label22.Text = "Fecha de referencia del estudio";
            // 
            // textDescripcionPeriodo
            // 
            textDescripcionPeriodo.Anchor = AnchorStyles.None;
            textDescripcionPeriodo.BackColor = SystemColors.Control;
            textDescripcionPeriodo.BorderColor = SystemColors.ControlDarkDark;
            textDescripcionPeriodo.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textDescripcionPeriodo.BorderSize = 2;
            textDescripcionPeriodo.ForeColor = Color.DimGray;
            textDescripcionPeriodo.Location = new Point(187, 277);
            textDescripcionPeriodo.Multiline = true;
            textDescripcionPeriodo.Name = "textDescripcionPeriodo";
            textDescripcionPeriodo.Padding = new Padding(7, 8, 7, 8);
            textDescripcionPeriodo.PasswordChar = false;
            textDescripcionPeriodo.Size = new Size(395, 34);
            textDescripcionPeriodo.TabIndex = 114;
            textDescripcionPeriodo.Texts = "Ejemplo: Se solicita este tiempo para el análisis del estudio";
            textDescripcionPeriodo.UnderlinedStyle = true;
            textDescripcionPeriodo.Enter += textDescripcionPeriodo_Enter;
            textDescripcionPeriodo.KeyPress += textDescripcionPeriodo_KeyPress;
            textDescripcionPeriodo.Leave += textDescripcionPeriodo_Leave;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(271, 13);
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
            Geografía.Location = new Point(4, 26);
            Geografía.Name = "Geografía";
            Geografía.Size = new Size(742, 489);
            Geografía.TabIndex = 4;
            Geografía.Text = "Geografía";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.BackColor = Color.FromArgb(242, 230, 230);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(txtlongitud);
            panel5.Controls.Add(txtlatitud);
            panel5.Controls.Add(gMapControl2);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(trackZoom);
            panel5.Controls.Add(buttonGuardarG);
            panel5.Controls.Add(dataGridView1);
            panel5.Controls.Add(comboArea);
            panel5.Controls.Add(comboEstado);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(-72, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(722, 1019);
            panel5.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Location = new Point(477, 60);
            panel6.Name = "panel6";
            panel6.Size = new Size(218, 194);
            panel6.TabIndex = 100;
            // 
            // txtlongitud
            // 
            txtlongitud.Anchor = AnchorStyles.None;
            txtlongitud.BackColor = SystemColors.Control;
            txtlongitud.BorderColor = SystemColors.ControlDarkDark;
            txtlongitud.BorderFocusColor = Color.FromArgb(190, 31, 36);
            txtlongitud.BorderSize = 2;
            txtlongitud.ForeColor = Color.DimGray;
            txtlongitud.Location = new Point(477, 206);
            txtlongitud.Multiline = true;
            txtlongitud.Name = "txtlongitud";
            txtlongitud.Padding = new Padding(7, 10, 7, 10);
            txtlongitud.PasswordChar = false;
            txtlongitud.Size = new Size(198, 36);
            txtlongitud.TabIndex = 117;
            txtlongitud.Texts = "Longitud";
            txtlongitud.UnderlinedStyle = true;
            // 
            // txtlatitud
            // 
            txtlatitud.Anchor = AnchorStyles.None;
            txtlatitud.BackColor = SystemColors.Control;
            txtlatitud.BorderColor = SystemColors.ControlDarkDark;
            txtlatitud.BorderFocusColor = Color.FromArgb(190, 31, 36);
            txtlatitud.BorderSize = 2;
            txtlatitud.ForeColor = Color.DimGray;
            txtlatitud.Location = new Point(477, 168);
            txtlatitud.Multiline = true;
            txtlatitud.Name = "txtlatitud";
            txtlatitud.Padding = new Padding(7, 9, 7, 9);
            txtlatitud.PasswordChar = false;
            txtlatitud.Size = new Size(198, 32);
            txtlatitud.TabIndex = 116;
            txtlatitud.Texts = "Latitud";
            txtlatitud.UnderlinedStyle = true;
            // 
            // gMapControl2
            // 
            gMapControl2.Bearing = 0F;
            gMapControl2.CanDragMap = true;
            gMapControl2.EmptyTileColor = Color.Navy;
            gMapControl2.GrayScaleMode = false;
            gMapControl2.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl2.LevelsKeepInMemory = 5;
            gMapControl2.Location = new Point(0, 293);
            gMapControl2.MarkersEnabled = true;
            gMapControl2.MaxZoom = 2;
            gMapControl2.MinZoom = 2;
            gMapControl2.MouseWheelZoomEnabled = true;
            gMapControl2.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl2.Name = "gMapControl2";
            gMapControl2.NegativeMode = false;
            gMapControl2.PolygonsEnabled = true;
            gMapControl2.RetryLoadTile = 0;
            gMapControl2.RoutesEnabled = true;
            gMapControl2.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gMapControl2.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gMapControl2.ShowTileGridLines = false;
            gMapControl2.Size = new Size(709, 385);
            gMapControl2.TabIndex = 105;
            gMapControl2.Zoom = 0D;
            gMapControl2.Load += RegistroFormulario_Load;
            gMapControl2.MouseDoubleClick += gMapControl2_MouseDoubleClick;
            // 
            // panel7
            // 
            panel7.Location = new Point(0, -25);
            panel7.Name = "panel7";
            panel7.Size = new Size(387, 23);
            panel7.TabIndex = 102;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(228, 235);
            label11.Name = "label11";
            label11.Size = new Size(233, 19);
            label11.TabIndex = 99;
            label11.Text = "Representatividad geográfica";
            // 
            // trackZoom
            // 
            trackZoom.Location = new Point(190, 708);
            trackZoom.Name = "trackZoom";
            trackZoom.Size = new Size(289, 45);
            trackZoom.TabIndex = 98;
            trackZoom.ValueChanged += trackZoom_ValueChanged;
            // 
            // buttonGuardarG
            // 
            buttonGuardarG.Anchor = AnchorStyles.None;
            buttonGuardarG.BackColor = Color.FromArgb(190, 31, 36);
            buttonGuardarG.FlatAppearance.BorderSize = 0;
            buttonGuardarG.FlatStyle = FlatStyle.Flat;
            buttonGuardarG.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGuardarG.ForeColor = SystemColors.ButtonFace;
            buttonGuardarG.Location = new Point(283, 841);
            buttonGuardarG.Name = "buttonGuardarG";
            buttonGuardarG.Size = new Size(115, 35);
            buttonGuardarG.TabIndex = 97;
            buttonGuardarG.Text = "Guardar datos";
            buttonGuardarG.UseVisualStyleBackColor = false;
            buttonGuardarG.Click += buttonGuardarG_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(496, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(121, 60);
            dataGridView1.TabIndex = 95;
            dataGridView1.CellMouseClick += SelecionarRegistro;
            // 
            // comboArea
            // 
            comboArea.Anchor = AnchorStyles.None;
            comboArea.DropDownStyle = ComboBoxStyle.DropDownList;
            comboArea.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboArea.FormattingEnabled = true;
            comboArea.Items.AddRange(new object[] { "Aguascalientes", "Tijuana", "La Paz", "Campeche", "Tuxtla Gutiérrez", "Chihuahua", "Zona centro", "Saltillo", "Colima", "Durango", "León", "Acapulco", "Pachuca", "Guadalajara", "Morelia", "Cuernavaca", "Tepic", "Monterrey", "Oaxaca", "Puebla-Tlaxcala", "Querétaro", "Cancún", "San Luis Potosí", "Culiacán", "Hermosillo", "Villahermosa", "Tampico", "Puebla-Tlaxcala", "Veracruz", "Mérida", "Zacatecas" });
            comboArea.Location = new Point(214, 168);
            comboArea.Name = "comboArea";
            comboArea.Size = new Size(230, 25);
            comboArea.TabIndex = 94;
            comboArea.Enter += comboArea_Enter;
            comboArea.Leave += comboArea_Leave;
            // 
            // comboEstado
            // 
            comboEstado.Anchor = AnchorStyles.None;
            comboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboEstado.FormattingEnabled = true;
            comboEstado.Items.AddRange(new object[] { "Aguascalientes", "Baja California", "Baja California Sur", "Campeche", "Chiapas", "Chihuahua", "Estado de México ", "Coahuila", "Colima", "Durango", "Guanajuato", "Guerrero", "Hidalgo", "Jalisco", "Michoacán", "Morelos", "Nayarit", "Nuevo León", "Oaxaca", "Puebla", "Querétaro ", "Quintana Roo", "San Luis Potosí ", "Sinaloa", "Sonora", "Tabasco", "Tamaulipas", "Tlaxcala", "Veracruz", "Yucatán", "Zacatecas" });
            comboEstado.Location = new Point(214, 89);
            comboEstado.Name = "comboEstado";
            comboEstado.Size = new Size(230, 25);
            comboEstado.TabIndex = 93;
            comboEstado.SelectedValueChanged += comboEstado_SelectedValueChanged;
            comboEstado.Enter += comboEstado_Enter;
            comboEstado.Leave += comboEstado_Leave;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(228, 25);
            label10.Name = "label10";
            label10.Size = new Size(204, 19);
            label10.TabIndex = 92;
            label10.Text = "Tiempo válido del estudio";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "circulo.png");
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // RegistroFormulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 230, 230);
            ClientSize = new Size(752, 500);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(500, 500);
            Name = "RegistroFormulario";
            Text = "RegistroFormulario";
            tabControl1.ResumeLayout(false);
            Identificación.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Referencia.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Identificación;
        private Panel panel1;
        private Label labelUsuario;
        private TabPage Referencia;
        private Panel panel4;
        private Button button2;
        private Button button1;
        private ComboBox comboLimitesSistema;
        private ComboBox comboUnidadUno;
        private SistemaRegistro.Templates.TextBox textBox7;
        private Label label3;
        private TabPage Tecnología;
        private TabPage TiempoVálido;
        private TabPage Geografía;
        private Label label1;
        private ComboBox comboTres;
        private ComboBox comboDos;
        private ComboBox comboUno;
        private ComboBox comboCuatro;
        private ComboBox comboCinco;
        private ComboBox comboSeis;
        private ComboBox comboSiete;
        private Label label4;
        private Label label2;
        private Label label5;
        private PictureBox pictureBox1;
        private Panel panel2;
        private ComboBox ComboTipoTecnologia;
        private Label label6;
        private Panel panel3;
        private Label label7;
        private Panel panel5;
        private Label label11;
        private TrackBar trackZoom;
        private Button buttonGuardarG;
        private DataGridView dataGridView1;
        private ComboBox comboArea;
        private ComboBox comboEstado;
        private Label label10;
        private Panel panel7;
        private Panel panel6;
        private Label label15;
        private Label label14;
        private SistemaRegistro.Templates.TextBox textProceso;
        private SistemaRegistro.Templates.TextBox textOtro;
        private Label label17;
        private Label label16;
        private SistemaRegistro.Templates.TextBox textCorreo;
        private SistemaRegistro.Templates.TextBox textAutor;
        private Label label13;
        private Label label19;
        private Label label20;
        private SistemaRegistro.Templates.TextBox textObjetivoR;
        private SistemaRegistro.Templates.TextBox textUnidadFuncional;
        private Button btnEliminarImagen;
        private Label label21;
        private SistemaRegistro.Templates.TextBox textCondicionesOpe;
        private Label label8;
        private Label label9;
        private Label label22;
        private SistemaRegistro.Templates.TextBox textDescripcionPeriodo;
        private Label label12;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label18;
        private ErrorProvider errorProvider1;
        private ComboBox ComboTecno;
        private ComboBox ComboProducto;
        private Templates.TextBox textValor;
        private System.Windows.Forms.Timer timer1;
        private GMap.NET.WindowsForms.GMapControl gMapControl2;
        private ImageList imageList1;
        private Label label28;
        private Templates.TextBox txtlatitud;
        private Templates.TextBox txtlongitud;
        private DateTimePicker FechaDatosValidos;
        private DateTimePicker FechaReferencia;
    }
}