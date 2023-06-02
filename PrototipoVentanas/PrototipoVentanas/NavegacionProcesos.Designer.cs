namespace PrototipoVentanas
{
    partial class NavegacionProcesos
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
            label3 = new Label();
            label8 = new Label();
            ComboTecno = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textOtro = new Sistema_de_sanciones.Templates.TextBox();
            textBox1 = new Sistema_de_sanciones.Templates.TextBox();
            textBox2 = new Sistema_de_sanciones.Templates.TextBox();
            textBox3 = new Sistema_de_sanciones.Templates.TextBox();
            textBox4 = new Sistema_de_sanciones.Templates.TextBox();
            textBox5 = new Sistema_de_sanciones.Templates.TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(255, 19);
            label3.Name = "label3";
            label3.Size = new Size(197, 19);
            label3.TabIndex = 99;
            label3.Text = "Navegación por proceso";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(26, 76);
            label8.Name = "label8";
            label8.Size = new Size(197, 19);
            label8.TabIndex = 100;
            label8.Text = "Navegación por proceso";
            // 
            // ComboTecno
            // 
            ComboTecno.Anchor = AnchorStyles.None;
            ComboTecno.FormattingEnabled = true;
            ComboTecno.Items.AddRange(new object[] { "Elaboración de concreto simple hecho en obra con medios mecánicos, con una resistencia de f'c 200 kg/cm2, usado en estructuras habitacionales.", "Obtención de grava y arena en mina a cielo abierto.", "Construcción de una bovedilla fabricado a partir de cemento, tepecil, arena y agua." });
            ComboTecno.Location = new Point(291, 72);
            ComboTecno.Name = "ComboTecno";
            ComboTecno.Size = new Size(371, 23);
            ComboTecno.TabIndex = 101;
            ComboTecno.Text = "proceso*";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 146);
            label1.Name = "label1";
            label1.Size = new Size(164, 19);
            label1.TabIndex = 102;
            label1.Text = "Nombre del proceso";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 202);
            label2.Name = "label2";
            label2.Size = new Size(207, 19);
            label2.TabIndex = 103;
            label2.Text = "Producto, tecnología, otro";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 255);
            label4.Name = "label4";
            label4.Size = new Size(237, 19);
            label4.TabIndex = 104;
            label4.Text = "Nombre del flujo de referencia";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 304);
            label5.Name = "label5";
            label5.Size = new Size(128, 19);
            label5.TabIndex = 105;
            label5.Text = "Valor referencia";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(26, 361);
            label6.Name = "label6";
            label6.Size = new Size(64, 19);
            label6.TabIndex = 106;
            label6.Text = "Unidad";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(26, 420);
            label7.Name = "label7";
            label7.Size = new Size(63, 19);
            label7.TabIndex = 107;
            label7.Text = "Estado";
            // 
            // textOtro
            // 
            textOtro.Anchor = AnchorStyles.None;
            textOtro.BackColor = SystemColors.Control;
            textOtro.BorderColor = SystemColors.ControlDarkDark;
            textOtro.BorderFocusColor = Color.Black;
            textOtro.BorderSize = 2;
            textOtro.Location = new Point(291, 244);
            textOtro.Multiline = false;
            textOtro.Name = "textOtro";
            textOtro.Padding = new Padding(7);
            textOtro.PasswordChar = false;
            textOtro.Size = new Size(412, 30);
            textOtro.TabIndex = 108;
            textOtro.Texts = "Producción de un kilogramo de bovedilla, terminado en planta, en la zona centro de México.";
            textOtro.UnderlinedStyle = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderColor = SystemColors.ControlDarkDark;
            textBox1.BorderFocusColor = Color.Black;
            textBox1.BorderSize = 2;
            textBox1.Location = new Point(291, 135);
            textBox1.Multiline = false;
            textBox1.Name = "textBox1";
            textBox1.Padding = new Padding(7);
            textBox1.PasswordChar = false;
            textBox1.Size = new Size(412, 30);
            textBox1.TabIndex = 109;
            textBox1.Texts = "Construcción de una bovedilla fabricado a partir de cemento, tepecil, arena y agua.";
            textBox1.UnderlinedStyle = true;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderColor = SystemColors.ControlDarkDark;
            textBox2.BorderFocusColor = Color.Black;
            textBox2.BorderSize = 2;
            textBox2.Location = new Point(291, 191);
            textBox2.Multiline = false;
            textBox2.Name = "textBox2";
            textBox2.Padding = new Padding(7);
            textBox2.PasswordChar = false;
            textBox2.Size = new Size(412, 30);
            textBox2.TabIndex = 110;
            textBox2.Texts = "Bovedilla, terminado en planta, 60x25x20cm";
            textBox2.UnderlinedStyle = true;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.BackColor = SystemColors.Control;
            textBox3.BorderColor = SystemColors.ControlDarkDark;
            textBox3.BorderFocusColor = Color.Black;
            textBox3.BorderSize = 2;
            textBox3.Location = new Point(291, 304);
            textBox3.Multiline = false;
            textBox3.Name = "textBox3";
            textBox3.Padding = new Padding(7);
            textBox3.PasswordChar = false;
            textBox3.Size = new Size(412, 30);
            textBox3.TabIndex = 111;
            textBox3.Texts = "1";
            textBox3.UnderlinedStyle = true;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.BackColor = SystemColors.Control;
            textBox4.BorderColor = SystemColors.ControlDarkDark;
            textBox4.BorderFocusColor = Color.Black;
            textBox4.BorderSize = 2;
            textBox4.Location = new Point(291, 361);
            textBox4.Multiline = false;
            textBox4.Name = "textBox4";
            textBox4.Padding = new Padding(7);
            textBox4.PasswordChar = false;
            textBox4.Size = new Size(412, 30);
            textBox4.TabIndex = 112;
            textBox4.Texts = "Masa (kg)";
            textBox4.UnderlinedStyle = true;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.BackColor = SystemColors.Control;
            textBox5.BorderColor = SystemColors.ControlDarkDark;
            textBox5.BorderFocusColor = Color.Black;
            textBox5.BorderSize = 2;
            textBox5.Location = new Point(291, 420);
            textBox5.Multiline = false;
            textBox5.Name = "textBox5";
            textBox5.Padding = new Padding(7);
            textBox5.PasswordChar = false;
            textBox5.Size = new Size(412, 30);
            textBox5.TabIndex = 113;
            textBox5.Texts = "MEX - Estado de México";
            textBox5.UnderlinedStyle = true;
            // 
            // NavegacionProcesos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 500);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textOtro);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ComboTecno);
            Controls.Add(label8);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(500, 500);
            Name = "NavegacionProcesos";
            Text = "NavegacionProcesos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label8;
        private ComboBox ComboTecno;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Sistema_de_sanciones.Templates.TextBox textOtro;
        private Sistema_de_sanciones.Templates.TextBox textBox1;
        private Sistema_de_sanciones.Templates.TextBox textBox2;
        private Sistema_de_sanciones.Templates.TextBox textBox3;
        private Sistema_de_sanciones.Templates.TextBox textBox4;
        private Sistema_de_sanciones.Templates.TextBox textBox5;
    }
}