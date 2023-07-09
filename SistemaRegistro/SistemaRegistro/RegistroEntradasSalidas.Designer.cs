namespace SistemaRegistro
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroEntradasSalidas));
            panel1 = new Panel();
            panel2 = new Panel();
            textNusuario = new TextBox();
            label4 = new Label();
            comboRecursos = new ComboBox();
            textValor = new Templates.TextBox();
            label2 = new Label();
            label1 = new Label();
            textComentario = new Templates.TextBox();
            textCitas = new Templates.TextBox();
            label15 = new Label();
            button1 = new Button();
            label3 = new Label();
            label12 = new Label();
            comboTipoFlujo = new ComboBox();
            comboEmisiones = new ComboBox();
            comboProductoT = new ComboBox();
            comboAdquisicion = new ComboBox();
            comboTratamiento = new ComboBox();
            buttonSiguienteP = new Button();
            textBox1 = new Templates.TextBox();
            comboUnidades = new ComboBox();
            textNombreFlujo = new Templates.TextBox();
            labelUsuario = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(242, 230, 230);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textNusuario);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboRecursos);
            panel1.Controls.Add(textValor);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textComentario);
            panel1.Controls.Add(textCitas);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(comboTipoFlujo);
            panel1.Controls.Add(comboEmisiones);
            panel1.Controls.Add(comboProductoT);
            panel1.Controls.Add(comboAdquisicion);
            panel1.Controls.Add(comboTratamiento);
            panel1.Controls.Add(buttonSiguienteP);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(comboUnidades);
            panel1.Controls.Add(textNombreFlujo);
            panel1.Controls.Add(labelUsuario);
            panel1.Location = new Point(-9, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 1127);
            panel1.TabIndex = 77;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Location = new Point(550, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(163, 38);
            panel2.TabIndex = 125;
            panel2.Visible = false;
            // 
            // textNusuario
            // 
            textNusuario.Anchor = AnchorStyles.None;
            textNusuario.Location = new Point(603, 32);
            textNusuario.Name = "textNusuario";
            textNusuario.Size = new Size(100, 23);
            textNusuario.TabIndex = 124;
            textNusuario.Visible = false;
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
            textValor.ForeColor = Color.DimGray;
            textValor.Location = new Point(265, 550);
            textValor.Multiline = true;
            textValor.Name = "textValor";
            textValor.Padding = new Padding(7, 9, 7, 9);
            textValor.PasswordChar = false;
            textValor.Size = new Size(207, 36);
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
            textComentario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textComentario.ForeColor = Color.DimGray;
            textComentario.Location = new Point(172, 956);
            textComentario.Multiline = false;
            textComentario.Name = "textComentario";
            textComentario.Padding = new Padding(7, 8, 7, 8);
            textComentario.PasswordChar = false;
            textComentario.Size = new Size(400, 34);
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
            textCitas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textCitas.ForeColor = Color.DimGray;
            textCitas.Location = new Point(173, 855);
            textCitas.Multiline = true;
            textCitas.Name = "textCitas";
            textCitas.Padding = new Padding(7, 8, 7, 8);
            textCitas.PasswordChar = false;
            textCitas.Size = new Size(387, 34);
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
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(190, 31, 36);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(308, 1042);
            button1.Name = "button1";
            button1.Size = new Size(115, 35);
            button1.TabIndex = 104;
            button1.Text = "Guardar datos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Guardar_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(297, 8);
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
            // comboProductoT
            // 
            comboProductoT.Anchor = AnchorStyles.None;
            comboProductoT.DropDownStyle = ComboBoxStyle.DropDownList;
            comboProductoT.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboProductoT.FormattingEnabled = true;
            comboProductoT.Location = new Point(214, 57);
            comboProductoT.Name = "comboProductoT";
            comboProductoT.Size = new Size(309, 25);
            comboProductoT.TabIndex = 89;
            comboProductoT.Enter += comboProductoT_Enter;
            comboProductoT.Leave += comboProducto_Leave;
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
            buttonSiguienteP.Location = new Point(846, 1519);
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
            textBox1.Location = new Point(811, 1439);
            textBox1.Multiline = false;
            textBox1.Name = "textBox1";
            textBox1.Padding = new Padding(7);
            textBox1.PasswordChar = false;
            textBox1.Size = new Size(191, 30);
            textBox1.TabIndex = 81;
            textBox1.Texts = "Correo*";
            textBox1.UnderlinedStyle = true;
            // 
            // comboUnidades
            // 
            comboUnidades.Anchor = AnchorStyles.None;
            comboUnidades.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUnidades.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboUnidades.FormattingEnabled = true;
            comboUnidades.Items.AddRange(new object[] { "Área (m²)", "Volumen (m³)", "Masa (kg)", "Radioactividad (kBq)", "Unidades (ítem)", "Longitud (m)", "Tiempo (s)", "Masa*Longitud (t*km)", "Volumen*Longitud (m³*km)", "Unidades de ítems*Longitud (Ítems*km)", "Área*tiempo (m²*año)", "Volumen*tiempo (m³*año)", "Energia (kWh)", "Energía (kJ)" });
            comboUnidades.Location = new Point(228, 462);
            comboUnidades.Name = "comboUnidades";
            comboUnidades.Size = new Size(266, 25);
            comboUnidades.TabIndex = 30;
            comboUnidades.Enter += comboUnidades_Enter;
            comboUnidades.Leave += comboUnidades_Leave;
            // 
            // textNombreFlujo
            // 
            textNombreFlujo.Anchor = AnchorStyles.None;
            textNombreFlujo.BackColor = SystemColors.Control;
            textNombreFlujo.BorderColor = SystemColors.ControlDarkDark;
            textNombreFlujo.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textNombreFlujo.BorderSize = 2;
            textNombreFlujo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textNombreFlujo.ForeColor = Color.DimGray;
            textNombreFlujo.Location = new Point(139, 152);
            textNombreFlujo.Multiline = false;
            textNombreFlujo.Name = "textNombreFlujo";
            textNombreFlujo.Padding = new Padding(7, 8, 7, 8);
            textNombreFlujo.PasswordChar = false;
            textNombreFlujo.Size = new Size(482, 34);
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
            labelUsuario.Location = new Point(587, -183);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(111, 19);
            labelUsuario.TabIndex = 29;
            labelUsuario.Text = "Identificación";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // RegistroEntradasSalidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(242, 230, 230);
            ClientSize = new Size(736, 500);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(500, 500);
            Name = "RegistroEntradasSalidas";
            Text = "RegistroEntradasSalidas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label12;
        private ComboBox comboTipoFlujo;
        private ComboBox comboEmisiones;
        private ComboBox comboProductoT;
        private ComboBox comboAdquisicion;
        private ComboBox comboTratamiento;
        private Button buttonSiguienteP;
        private SistemaRegistro.Templates.TextBox textBox1;
        private ComboBox comboUnidades;
        private SistemaRegistro.Templates.TextBox textNombreFlujo;
        private Label labelUsuario;
        private Label label3;
        private Button button1;
        private Label label15;
        private Label label2;
        private Label label1;
        private SistemaRegistro.Templates.TextBox textComentario;
        private SistemaRegistro.Templates.TextBox textCitas;
        private Templates.TextBox textValor;
        private ComboBox comboRecursos;
        private Label label4;
        private ErrorProvider errorProvider1;
        private Panel panel2;
        private TextBox textNusuario;
    }
}