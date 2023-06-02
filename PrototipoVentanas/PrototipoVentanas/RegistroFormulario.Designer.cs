namespace PrototipoVentanas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Identificación = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSiguienteID = new System.Windows.Forms.Button();
            this.textCorreo = new Sistema_de_sanciones.Templates.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textAutor = new Sistema_de_sanciones.Templates.TextBox();
            this.textBox3 = new Sistema_de_sanciones.Templates.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComboProducto = new System.Windows.Forms.ComboBox();
            this.ComboTecno = new System.Windows.Forms.ComboBox();
            this.textOtro = new Sistema_de_sanciones.Templates.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.textProceso = new Sistema_de_sanciones.Templates.TextBox();
            this.Referencia = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboLimitesSistema = new System.Windows.Forms.ComboBox();
            this.textObjetivoR = new Sistema_de_sanciones.Templates.TextBox();
            this.comboUnidadUno = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textUnidadFuncional = new Sistema_de_sanciones.Templates.TextBox();
            this.textBox7 = new Sistema_de_sanciones.Templates.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tecnología = new System.Windows.Forms.TabPage();
            this.TiempoVálido = new System.Windows.Forms.TabPage();
            this.Geografía = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Identificación.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Referencia.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Identificación);
            this.tabControl1.Controls.Add(this.Referencia);
            this.tabControl1.Controls.Add(this.Tecnología);
            this.tabControl1.Controls.Add(this.TiempoVálido);
            this.tabControl1.Controls.Add(this.Geografía);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 517);
            this.tabControl1.TabIndex = 0;
            // 
            // Identificación
            // 
            this.Identificación.AutoScroll = true;
            this.Identificación.Controls.Add(this.panel3);
            this.Identificación.Controls.Add(this.panel2);
            this.Identificación.Controls.Add(this.panel1);
            this.Identificación.Location = new System.Drawing.Point(4, 24);
            this.Identificación.Name = "Identificación";
            this.Identificación.Padding = new System.Windows.Forms.Padding(3);
            this.Identificación.Size = new System.Drawing.Size(755, 489);
            this.Identificación.TabIndex = 0;
            this.Identificación.Text = "Identificación";
            this.Identificación.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.buttonSiguienteID);
            this.panel3.Controls.Add(this.textCorreo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textAutor);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Location = new System.Drawing.Point(-28, 483);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(711, 238);
            this.panel3.TabIndex = 80;
            // 
            // buttonSiguienteID
            // 
            this.buttonSiguienteID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSiguienteID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(96)))));
            this.buttonSiguienteID.FlatAppearance.BorderSize = 0;
            this.buttonSiguienteID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSiguienteID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSiguienteID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSiguienteID.Location = new System.Drawing.Point(307, 168);
            this.buttonSiguienteID.Name = "buttonSiguienteID";
            this.buttonSiguienteID.Size = new System.Drawing.Size(115, 35);
            this.buttonSiguienteID.TabIndex = 79;
            this.buttonSiguienteID.Text = "Siguiente";
            this.buttonSiguienteID.UseVisualStyleBackColor = false;
            this.buttonSiguienteID.Click += new System.EventHandler(this.ButtonGuardar_Mod_Click);
            // 
            // textCorreo
            // 
            this.textCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textCorreo.BackColor = System.Drawing.SystemColors.Control;
            this.textCorreo.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textCorreo.BorderFocusColor = System.Drawing.Color.Black;
            this.textCorreo.BorderSize = 2;
            this.textCorreo.Location = new System.Drawing.Point(272, 102);
            this.textCorreo.Multiline = false;
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Padding = new System.Windows.Forms.Padding(7);
            this.textCorreo.PasswordChar = false;
            this.textCorreo.Size = new System.Drawing.Size(191, 30);
            this.textCorreo.TabIndex = 72;
            this.textCorreo.Texts = "Correo*";
            this.textCorreo.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(284, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 78;
            this.label2.Text = "Datos de contacto";
            // 
            // textAutor
            // 
            this.textAutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textAutor.BackColor = System.Drawing.SystemColors.Control;
            this.textAutor.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textAutor.BorderFocusColor = System.Drawing.Color.Black;
            this.textAutor.BorderSize = 2;
            this.textAutor.Location = new System.Drawing.Point(272, 50);
            this.textAutor.Multiline = false;
            this.textAutor.Name = "textAutor";
            this.textAutor.Padding = new System.Windows.Forms.Padding(7);
            this.textAutor.PasswordChar = false;
            this.textAutor.Size = new System.Drawing.Size(191, 30);
            this.textAutor.TabIndex = 71;
            this.textAutor.Texts = "Auto ACV*";
            this.textAutor.UnderlinedStyle = true;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox3.BorderFocusColor = System.Drawing.Color.Black;
            this.textBox3.BorderSize = 2;
            this.textBox3.Location = new System.Drawing.Point(1084, 109);
            this.textBox3.Multiline = false;
            this.textBox3.Name = "textBox3";
            this.textBox3.Padding = new System.Windows.Forms.Padding(7);
            this.textBox3.PasswordChar = false;
            this.textBox3.Size = new System.Drawing.Size(191, 30);
            this.textBox3.TabIndex = 69;
            this.textBox3.Texts = "Otro*";
            this.textBox3.UnderlinedStyle = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-37, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 281);
            this.panel2.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(305, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 71;
            this.label1.Text = "Tipo de proceso";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.ComboProducto);
            this.panel1.Controls.Add(this.ComboTecno);
            this.panel1.Controls.Add(this.textOtro);
            this.panel1.Controls.Add(this.labelUsuario);
            this.panel1.Controls.Add(this.textProceso);
            this.panel1.Location = new System.Drawing.Point(-37, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 180);
            this.panel1.TabIndex = 76;
            // 
            // ComboProducto
            // 
            this.ComboProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboProducto.FormattingEnabled = true;
            this.ComboProducto.Items.AddRange(new object[] {
            "Cemento",
            "Concreto",
            "Acero estructural",
            "Ladrillos",
            "Madera",
            "Vidrio",
            "Aislamiento térmico",
            "Pinturas y recubrimientos",
            "Azulejos y baldosas",
            "Adhesivos y selladores",
            "Impermeabilizantes",
            "Sistemas de fontanería",
            "Sistemas eléctricos",
            "Sistemas de climatización"});
            this.ComboProducto.Location = new System.Drawing.Point(14, 44);
            this.ComboProducto.Name = "ComboProducto";
            this.ComboProducto.Size = new System.Drawing.Size(214, 23);
            this.ComboProducto.TabIndex = 0;
            this.ComboProducto.Text = "Producto*";
            // 
            // ComboTecno
            // 
            this.ComboTecno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboTecno.FormattingEnabled = true;
            this.ComboTecno.Items.AddRange(new object[] {
            "Cemento Portland",
            "Concreto reforzado",
            "Concreto premezclado",
            "Concreto de alto rendimiento",
            "Ladrillos cerámicos",
            "Ladrillos de hormigón",
            "Acero laminado en caliente",
            "Madera laminada encolada",
            "Madera tratada",
            "Vidrio de seguridad laminado",
            "Vidrio aislante",
            "Azulejos de cerámica esmaltada",
            "Baldosas de porcelana",
            "Espuma de poliestireno expandido (EPS)",
            "Lana mineral",
            "Membranas asfálticas",
            "Pinturas impermeabilizantes"});
            this.ComboTecno.Location = new System.Drawing.Point(258, 44);
            this.ComboTecno.Name = "ComboTecno";
            this.ComboTecno.Size = new System.Drawing.Size(232, 23);
            this.ComboTecno.TabIndex = 30;
            this.ComboTecno.Text = "Tecnología*";
            // 
            // textOtro
            // 
            this.textOtro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textOtro.BackColor = System.Drawing.SystemColors.Control;
            this.textOtro.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textOtro.BorderFocusColor = System.Drawing.Color.Black;
            this.textOtro.BorderSize = 2;
            this.textOtro.Location = new System.Drawing.Point(511, 37);
            this.textOtro.Multiline = false;
            this.textOtro.Name = "textOtro";
            this.textOtro.Padding = new System.Windows.Forms.Padding(7);
            this.textOtro.PasswordChar = false;
            this.textOtro.Size = new System.Drawing.Size(222, 30);
            this.textOtro.TabIndex = 69;
            this.textOtro.Texts = "Otro*";
            this.textOtro.UnderlinedStyle = true;
            // 
            // labelUsuario
            // 
            this.labelUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUsuario.ForeColor = System.Drawing.Color.Red;
            this.labelUsuario.Location = new System.Drawing.Point(318, 10);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(111, 19);
            this.labelUsuario.TabIndex = 29;
            this.labelUsuario.Text = "Identificación";
            // 
            // textProceso
            // 
            this.textProceso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textProceso.BackColor = System.Drawing.SystemColors.Control;
            this.textProceso.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textProceso.BorderFocusColor = System.Drawing.Color.Black;
            this.textProceso.BorderSize = 2;
            this.textProceso.Location = new System.Drawing.Point(15, 118);
            this.textProceso.Multiline = false;
            this.textProceso.Name = "textProceso";
            this.textProceso.Padding = new System.Windows.Forms.Padding(7);
            this.textProceso.PasswordChar = false;
            this.textProceso.Size = new System.Drawing.Size(214, 30);
            this.textProceso.TabIndex = 70;
            this.textProceso.Texts = "Nombre del proceso*";
            this.textProceso.UnderlinedStyle = true;
            // 
            // Referencia
            // 
            this.Referencia.AutoScroll = true;
            this.Referencia.Controls.Add(this.panel4);
            this.Referencia.Location = new System.Drawing.Point(4, 24);
            this.Referencia.Name = "Referencia";
            this.Referencia.Padding = new System.Windows.Forms.Padding(3);
            this.Referencia.Size = new System.Drawing.Size(755, 489);
            this.Referencia.TabIndex = 1;
            this.Referencia.Text = "Referencia";
            this.Referencia.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.comboLimitesSistema);
            this.panel4.Controls.Add(this.textObjetivoR);
            this.panel4.Controls.Add(this.comboUnidadUno);
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Controls.Add(this.textUnidadFuncional);
            this.panel4.Controls.Add(this.textBox7);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(-29, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(738, 747);
            this.panel4.TabIndex = 77;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(96)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(205, 692);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 35);
            this.button2.TabIndex = 81;
            this.button2.Text = "Atras";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(96)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(408, 692);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 35);
            this.button1.TabIndex = 80;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboLimitesSistema
            // 
            this.comboLimitesSistema.FormattingEnabled = true;
            this.comboLimitesSistema.Items.AddRange(new object[] {
            "Limitaciones presupuestarias",
            "Limitaciones de tiempo",
            "Limitaciones de recursos naturales",
            "Limitaciones de espacio",
            "Limitaciones ambientales",
            "Limitaciones de capacidad",
            "Limitaciones geotécnicas",
            "Limitaciones tecnológicas",
            "Limitaciones normativas y legales",
            "Limitaciones de seguridad"});
            this.comboLimitesSistema.Location = new System.Drawing.Point(248, 357);
            this.comboLimitesSistema.Name = "comboLimitesSistema";
            this.comboLimitesSistema.Size = new System.Drawing.Size(230, 23);
            this.comboLimitesSistema.TabIndex = 76;
            this.comboLimitesSistema.Text = "Limites del sistema*";
            // 
            // textObjetivoR
            // 
            this.textObjetivoR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textObjetivoR.BackColor = System.Drawing.SystemColors.Control;
            this.textObjetivoR.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textObjetivoR.BorderFocusColor = System.Drawing.Color.Black;
            this.textObjetivoR.BorderSize = 2;
            this.textObjetivoR.Location = new System.Drawing.Point(248, 269);
            this.textObjetivoR.Multiline = false;
            this.textObjetivoR.Name = "textObjetivoR";
            this.textObjetivoR.Padding = new System.Windows.Forms.Padding(7);
            this.textObjetivoR.PasswordChar = false;
            this.textObjetivoR.Size = new System.Drawing.Size(230, 30);
            this.textObjetivoR.TabIndex = 75;
            this.textObjetivoR.Texts = "Objetivo*";
            this.textObjetivoR.UnderlinedStyle = true;
            // 
            // comboUnidadUno
            // 
            this.comboUnidadUno.FormattingEnabled = true;
            this.comboUnidadUno.Items.AddRange(new object[] {
            "Área (m²)",
            "Área (ha)",
            "Área*Tiempo (m²*año)",
            "Capacidad de peso (kg*s)",
            "Capacidad de volumen (l*hora)",
            "Capacidad de conversión de energía (MW)",
            "Densidad (kg*l)",
            "Masa (kg)",
            "Capacidad de peso (kg*s)",
            "Longitud (m)",
            "Servicio de transporte (ton*km)",
            "Servicio de transporte (persona*km)",
            "Metro*año (m*año)",
            "Unidad (item)",
            "Electricidad (kWh)",
            "Energía (MJ)",
            "Tiempo de uso del equipo (hora)",
            "Productos líquidos (l)",
            "Volumen (m³)",
            "Energia (KWh)",
            "Energía (kJ)"});
            this.comboUnidadUno.Location = new System.Drawing.Point(248, 196);
            this.comboUnidadUno.Name = "comboUnidadUno";
            this.comboUnidadUno.Size = new System.Drawing.Size(230, 23);
            this.comboUnidadUno.TabIndex = 74;
            this.comboUnidadUno.Text = "Unidad*";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(303, 141);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 72;
            // 
            // textUnidadFuncional
            // 
            this.textUnidadFuncional.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textUnidadFuncional.BackColor = System.Drawing.SystemColors.Control;
            this.textUnidadFuncional.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textUnidadFuncional.BorderFocusColor = System.Drawing.Color.Black;
            this.textUnidadFuncional.BorderSize = 2;
            this.textUnidadFuncional.Location = new System.Drawing.Point(248, 75);
            this.textUnidadFuncional.Multiline = false;
            this.textUnidadFuncional.Name = "textUnidadFuncional";
            this.textUnidadFuncional.Padding = new System.Windows.Forms.Padding(7);
            this.textUnidadFuncional.PasswordChar = false;
            this.textUnidadFuncional.Size = new System.Drawing.Size(230, 30);
            this.textUnidadFuncional.TabIndex = 71;
            this.textUnidadFuncional.Texts = "Nombre de la unidad funcional*";
            this.textUnidadFuncional.UnderlinedStyle = true;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox7.BorderFocusColor = System.Drawing.Color.Black;
            this.textBox7.BorderSize = 2;
            this.textBox7.Location = new System.Drawing.Point(780, 360);
            this.textBox7.Multiline = false;
            this.textBox7.Name = "textBox7";
            this.textBox7.Padding = new System.Windows.Forms.Padding(7);
            this.textBox7.PasswordChar = false;
            this.textBox7.Size = new System.Drawing.Size(222, 30);
            this.textBox7.TabIndex = 69;
            this.textBox7.Texts = "Otro*";
            this.textBox7.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(307, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Referencia";
            // 
            // Tecnología
            // 
            this.Tecnología.AutoScroll = true;
            this.Tecnología.Location = new System.Drawing.Point(4, 24);
            this.Tecnología.Name = "Tecnología";
            this.Tecnología.Size = new System.Drawing.Size(755, 489);
            this.Tecnología.TabIndex = 2;
            this.Tecnología.Text = "Tecnología";
            this.Tecnología.UseVisualStyleBackColor = true;
            // 
            // TiempoVálido
            // 
            this.TiempoVálido.AutoScroll = true;
            this.TiempoVálido.Location = new System.Drawing.Point(4, 24);
            this.TiempoVálido.Name = "TiempoVálido";
            this.TiempoVálido.Size = new System.Drawing.Size(755, 489);
            this.TiempoVálido.TabIndex = 3;
            this.TiempoVálido.Text = "TiempoVálido";
            this.TiempoVálido.UseVisualStyleBackColor = true;
            // 
            // Geografía
            // 
            this.Geografía.AutoScroll = true;
            this.Geografía.Location = new System.Drawing.Point(4, 24);
            this.Geografía.Name = "Geografía";
            this.Geografía.Size = new System.Drawing.Size(755, 489);
            this.Geografía.TabIndex = 4;
            this.Geografía.Text = "Geografía";
            this.Geografía.UseVisualStyleBackColor = true;
            // 
            // RegistroFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(768, 519);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroFormulario";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Identificación.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Referencia.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage Identificación;
        private TabPage Referencia;
        private TabPage Tecnología;
        private ComboBox ComboProducto;
        private TabPage TiempoVálido;
        private TabPage Geografía;
        private ComboBox ComboTecno;
        private Label labelUsuario;
        private Panel panel1;
        private Sistema_de_sanciones.Templates.TextBox textOtro;
        private Sistema_de_sanciones.Templates.TextBox textProceso;
        private Label label1;
        private Panel panel3;
        private Sistema_de_sanciones.Templates.TextBox textBox3;
        private Label label2;
        private Panel panel2;
        private Sistema_de_sanciones.Templates.TextBox textCorreo;
        private Sistema_de_sanciones.Templates.TextBox textAutor;
        private Button buttonSiguienteID;
        private Panel panel4;
        private NumericUpDown numericUpDown1;
        private Sistema_de_sanciones.Templates.TextBox textUnidadFuncional;
        private Sistema_de_sanciones.Templates.TextBox textBox7;
        private Label label3;
        private ComboBox comboLimitesSistema;
        private Sistema_de_sanciones.Templates.TextBox textObjetivoR;
        private ComboBox comboUnidadUno;
        private Button button2;
        private Button button1;
    }
}