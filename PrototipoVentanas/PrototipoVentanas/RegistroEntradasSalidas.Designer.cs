namespace PrototipoVentanas
{
    partial class RegistroEntradasSalidas
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
            panel1 = new Panel();
            button1 = new Button();
            textBox3 = new Sistema_de_sanciones.Templates.TextBox();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label12 = new Label();
            button8 = new Button();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            textProceso = new Sistema_de_sanciones.Templates.TextBox();
            comboSeis = new ComboBox();
            comboDos = new ComboBox();
            comboUno = new ComboBox();
            buttonSiguienteP = new Button();
            textBox1 = new Sistema_de_sanciones.Templates.TextBox();
            ComboTecno = new ComboBox();
            textOtro = new Sistema_de_sanciones.Templates.TextBox();
            labelUsuario = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label5);
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
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 747);
            panel1.TabIndex = 77;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(97, 97, 96);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(305, 660);
            button1.Name = "button1";
            button1.Size = new Size(115, 35);
            button1.TabIndex = 104;
            button1.Text = "Guardar datos";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.BackColor = SystemColors.Control;
            textBox3.BorderColor = SystemColors.ControlDarkDark;
            textBox3.BorderFocusColor = Color.Black;
            textBox3.BorderSize = 2;
            textBox3.Location = new Point(141, 556);
            textBox3.Multiline = false;
            textBox3.Name = "textBox3";
            textBox3.Padding = new Padding(7);
            textBox3.PasswordChar = false;
            textBox3.Size = new Size(451, 30);
            textBox3.TabIndex = 101;
            textBox3.Texts = "Comentario*";
            textBox3.UnderlinedStyle = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(80, 282);
            label5.Name = "label5";
            label5.Size = new Size(48, 19);
            label5.TabIndex = 100;
            label5.Text = "Valor";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(11, 304);
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
            label3.Location = new Point(288, 19);
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
            label12.Location = new Point(344, -319);
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
            button8.Location = new Point(546, 1005);
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
            comboBox5.Location = new Point(255, 175);
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
            comboBox6.Location = new Point(491, 175);
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
            textProceso.BorderFocusColor = Color.Black;
            textProceso.BorderSize = 2;
            textProceso.Location = new Point(347, 424);
            textProceso.Multiline = false;
            textProceso.Name = "textProceso";
            textProceso.Padding = new Padding(7);
            textProceso.PasswordChar = false;
            textProceso.Size = new Size(324, 30);
            textProceso.TabIndex = 95;
            textProceso.Texts = "Citas-Referencias*";
            textProceso.UnderlinedStyle = true;
            // 
            // comboSeis
            // 
            comboSeis.Anchor = AnchorStyles.None;
            comboSeis.FormattingEnabled = true;
            comboSeis.Items.AddRange(new object[] { "Producto_tecnología_otroEntSal", "Concreto simple,mecánico, f’c 200kg/cm2", "Agregados, mina cielo abierto, grava y arena.", "Bovedilla, terminado en planta, 60x25x20cm" });
            comboSeis.Location = new Point(243, 80);
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
            comboDos.Location = new Point(28, 431);
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
            comboUno.Location = new Point(495, 304);
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
            // ComboTecno
            // 
            ComboTecno.Anchor = AnchorStyles.None;
            ComboTecno.FormattingEnabled = true;
            ComboTecno.Items.AddRange(new object[] { "Área (m²)", "Área (ha)", "Área*Tiempo (m²*año)", "Capacidad de peso (kg*s)", "Capacidad de volumen (l*hora)", "Capacidad de conversión de energía (MW)", "Densidad (kg*l)", "Masa (kg)", "Capacidad de peso (kg*s)", "Longitud (m)", "Servicio de transporte (ton*km)", "Servicio de transporte (persona*km)", "Metro*año (m*año)", "Unidad (item)", "Electricidad (kWh)", "Energía (MJ)", "Tiempo de uso del equipo (hora)", "Productos líquidos (l)", "Volumen (m³)", "Energia (KWh)", "Energía (kJ)" });
            ComboTecno.Location = new Point(253, 304);
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
            textOtro.BorderFocusColor = Color.Black;
            textOtro.BorderSize = 2;
            textOtro.Location = new Point(11, 168);
            textOtro.Multiline = false;
            textOtro.Name = "textOtro";
            textOtro.Padding = new Padding(7);
            textOtro.PasswordChar = false;
            textOtro.Size = new Size(222, 30);
            textOtro.TabIndex = 69;
            textOtro.Texts = "Nombre de flujo*";
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
            // RegistroEntradasSalidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(736, 500);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(500, 500);
            Name = "RegistroEntradasSalidas";
            Text = "RegistroEntradasSalidas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label12;
        private Button button8;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private Sistema_de_sanciones.Templates.TextBox textProceso;
        private ComboBox comboSeis;
        private ComboBox comboDos;
        private ComboBox comboUno;
        private Button buttonSiguienteP;
        private Sistema_de_sanciones.Templates.TextBox textBox1;
        private ComboBox ComboTecno;
        private Sistema_de_sanciones.Templates.TextBox textOtro;
        private Label labelUsuario;
        private Label label3;
        private Sistema_de_sanciones.Templates.TextBox textBox3;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private Button button1;
    }
}