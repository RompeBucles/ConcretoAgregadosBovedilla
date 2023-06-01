namespace PrototipoVentanas
{
    partial class ListarUsuario
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
            this.ListaUsuario = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EditarUsuarios = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rjComboBox1 = new Sistema_de_sanciones.Templates.RjComboBox();
            this.textBox8 = new Sistema_de_sanciones.Templates.TextBox();
            this.textBox7 = new Sistema_de_sanciones.Templates.TextBox();
            this.textBox6 = new Sistema_de_sanciones.Templates.TextBox();
            this.textBox5 = new Sistema_de_sanciones.Templates.TextBox();
            this.textBox4 = new Sistema_de_sanciones.Templates.TextBox();
            this.textBox2 = new Sistema_de_sanciones.Templates.TextBox();
            this.textBox1 = new Sistema_de_sanciones.Templates.TextBox();
            this.textUsuario = new Sistema_de_sanciones.Templates.TextBox();
            this.buttonCancelar_Mod = new System.Windows.Forms.Button();
            this.buttonGuardar_Mod = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.VerUsuario = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.fechaActualizacion = new System.Windows.Forms.DateTimePicker();
            this.fecha_Alta = new System.Windows.Forms.DateTimePicker();
            this.buttonCancelar_Ver = new System.Windows.Forms.Button();
            this.textUserName = new Sistema_de_sanciones.Templates.TextBox();
            this.textNum = new Sistema_de_sanciones.Templates.TextBox();
            this.textCorreoE = new Sistema_de_sanciones.Templates.TextBox();
            this.textCargo1 = new Sistema_de_sanciones.Templates.TextBox();
            this.textSegundoApellido = new Sistema_de_sanciones.Templates.TextBox();
            this.textPrimerApellido = new Sistema_de_sanciones.Templates.TextBox();
            this.textNombres = new Sistema_de_sanciones.Templates.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.ListaUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.EditarUsuarios.SuspendLayout();
            this.VerUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.ListaUsuario);
            this.tabControl1.Controls.Add(this.EditarUsuarios);
            this.tabControl1.Controls.Add(this.VerUsuario);
            this.tabControl1.Location = new System.Drawing.Point(-3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 519);
            this.tabControl1.TabIndex = 21;
            // 
            // ListaUsuario
            // 
            this.ListaUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.ListaUsuario.Controls.Add(this.button1);
            this.ListaUsuario.Controls.Add(this.dataGridView1);
            this.ListaUsuario.Location = new System.Drawing.Point(4, 24);
            this.ListaUsuario.Name = "ListaUsuario";
            this.ListaUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.ListaUsuario.Size = new System.Drawing.Size(760, 491);
            this.ListaUsuario.TabIndex = 0;
            this.ListaUsuario.Text = "Lista Usuario";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(96)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(609, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 39);
            this.button1.TabIndex = 67;
            this.button1.Text = "Borra Selección";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Editar,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(757, 443);
            this.dataGridView1.TabIndex = 27;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre completo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Perfil";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Correo electrónico";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefono";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Usuario";
            this.Column5.Name = "Column5";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Eliminar";
            this.Column6.Name = "Column6";
            // 
            // EditarUsuarios
            // 
            this.EditarUsuarios.BackColor = System.Drawing.SystemColors.Control;
            this.EditarUsuarios.Controls.Add(this.label3);
            this.EditarUsuarios.Controls.Add(this.label2);
            this.EditarUsuarios.Controls.Add(this.rjComboBox1);
            this.EditarUsuarios.Controls.Add(this.textBox8);
            this.EditarUsuarios.Controls.Add(this.textBox7);
            this.EditarUsuarios.Controls.Add(this.textBox6);
            this.EditarUsuarios.Controls.Add(this.textBox5);
            this.EditarUsuarios.Controls.Add(this.textBox4);
            this.EditarUsuarios.Controls.Add(this.textBox2);
            this.EditarUsuarios.Controls.Add(this.textBox1);
            this.EditarUsuarios.Controls.Add(this.textUsuario);
            this.EditarUsuarios.Controls.Add(this.buttonCancelar_Mod);
            this.EditarUsuarios.Controls.Add(this.buttonGuardar_Mod);
            this.EditarUsuarios.Controls.Add(this.label8);
            this.EditarUsuarios.Location = new System.Drawing.Point(4, 24);
            this.EditarUsuarios.Name = "EditarUsuarios";
            this.EditarUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.EditarUsuarios.Size = new System.Drawing.Size(760, 491);
            this.EditarUsuarios.TabIndex = 1;
            this.EditarUsuarios.Text = "Editar Usuario";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(557, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 78;
            this.label3.Text = "Confirmar Contraseña*";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(272, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 77;
            this.label2.Text = "Ingresa Contraseña*";
            // 
            // rjComboBox1
            // 
            this.rjComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox1.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.rjComboBox1.BorderSize = 1;
            this.rjComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox1.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.rjComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.Location = new System.Drawing.Point(9, 165);
            this.rjComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox1.Name = "rjComboBox1";
            this.rjComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox1.Size = new System.Drawing.Size(200, 30);
            this.rjComboBox1.TabIndex = 76;
            this.rjComboBox1.Texts = "Perfil*";
            // 
            // textBox8
            // 
            this.textBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox8.BackColor = System.Drawing.SystemColors.Control;
            this.textBox8.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox8.BorderFocusColor = System.Drawing.Color.Black;
            this.textBox8.BorderSize = 2;
            this.textBox8.Location = new System.Drawing.Point(557, 268);
            this.textBox8.Multiline = false;
            this.textBox8.Name = "textBox8";
            this.textBox8.Padding = new System.Windows.Forms.Padding(7);
            this.textBox8.PasswordChar = true;
            this.textBox8.Size = new System.Drawing.Size(196, 30);
            this.textBox8.TabIndex = 75;
            this.textBox8.Texts = "Nombre de usuario*";
            this.textBox8.UnderlinedStyle = true;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox7.BorderFocusColor = System.Drawing.Color.Black;
            this.textBox7.BorderSize = 2;
            this.textBox7.Location = new System.Drawing.Point(272, 268);
            this.textBox7.Multiline = false;
            this.textBox7.Name = "textBox7";
            this.textBox7.Padding = new System.Windows.Forms.Padding(7);
            this.textBox7.PasswordChar = true;
            this.textBox7.Size = new System.Drawing.Size(196, 30);
            this.textBox7.TabIndex = 74;
            this.textBox7.Texts = "Contraseña*";
            this.textBox7.UnderlinedStyle = true;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox6.BorderFocusColor = System.Drawing.Color.Black;
            this.textBox6.BorderSize = 2;
            this.textBox6.Location = new System.Drawing.Point(9, 268);
            this.textBox6.Multiline = false;
            this.textBox6.Name = "textBox6";
            this.textBox6.Padding = new System.Windows.Forms.Padding(7);
            this.textBox6.PasswordChar = false;
            this.textBox6.Size = new System.Drawing.Size(196, 30);
            this.textBox6.TabIndex = 73;
            this.textBox6.Texts = "Usuario*";
            this.textBox6.UnderlinedStyle = true;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox5.BorderFocusColor = System.Drawing.Color.Black;
            this.textBox5.BorderSize = 2;
            this.textBox5.Location = new System.Drawing.Point(557, 155);
            this.textBox5.Multiline = false;
            this.textBox5.Name = "textBox5";
            this.textBox5.Padding = new System.Windows.Forms.Padding(7);
            this.textBox5.PasswordChar = false;
            this.textBox5.Size = new System.Drawing.Size(196, 30);
            this.textBox5.TabIndex = 72;
            this.textBox5.Texts = "telefono*";
            this.textBox5.UnderlinedStyle = true;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox4.BorderFocusColor = System.Drawing.Color.Black;
            this.textBox4.BorderSize = 2;
            this.textBox4.Location = new System.Drawing.Point(272, 155);
            this.textBox4.Multiline = false;
            this.textBox4.Name = "textBox4";
            this.textBox4.Padding = new System.Windows.Forms.Padding(7);
            this.textBox4.PasswordChar = false;
            this.textBox4.Size = new System.Drawing.Size(212, 30);
            this.textBox4.TabIndex = 71;
            this.textBox4.Texts = "Correo electrónico*";
            this.textBox4.UnderlinedStyle = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.BorderFocusColor = System.Drawing.Color.Black;
            this.textBox2.BorderSize = 2;
            this.textBox2.Location = new System.Drawing.Point(555, 52);
            this.textBox2.Multiline = false;
            this.textBox2.Name = "textBox2";
            this.textBox2.Padding = new System.Windows.Forms.Padding(7);
            this.textBox2.PasswordChar = false;
            this.textBox2.Size = new System.Drawing.Size(198, 30);
            this.textBox2.TabIndex = 70;
            this.textBox2.Texts = "Apellido materno*";
            this.textBox2.UnderlinedStyle = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.BorderFocusColor = System.Drawing.Color.Black;
            this.textBox1.BorderSize = 2;
            this.textBox1.Location = new System.Drawing.Point(272, 52);
            this.textBox1.Multiline = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.Padding = new System.Windows.Forms.Padding(7);
            this.textBox1.PasswordChar = false;
            this.textBox1.Size = new System.Drawing.Size(212, 30);
            this.textBox1.TabIndex = 69;
            this.textBox1.Texts = "Apellido paterno*";
            this.textBox1.UnderlinedStyle = true;
            // 
            // textUsuario
            // 
            this.textUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.textUsuario.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textUsuario.BorderFocusColor = System.Drawing.Color.Black;
            this.textUsuario.BorderSize = 2;
            this.textUsuario.Location = new System.Drawing.Point(9, 52);
            this.textUsuario.Multiline = false;
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Padding = new System.Windows.Forms.Padding(7);
            this.textUsuario.PasswordChar = false;
            this.textUsuario.Size = new System.Drawing.Size(191, 30);
            this.textUsuario.TabIndex = 68;
            this.textUsuario.Texts = "Nombre*";
            this.textUsuario.UnderlinedStyle = true;
            // 
            // buttonCancelar_Mod
            // 
            this.buttonCancelar_Mod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancelar_Mod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(96)))));
            this.buttonCancelar_Mod.FlatAppearance.BorderSize = 0;
            this.buttonCancelar_Mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar_Mod.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar_Mod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCancelar_Mod.Location = new System.Drawing.Point(487, 439);
            this.buttonCancelar_Mod.Name = "buttonCancelar_Mod";
            this.buttonCancelar_Mod.Size = new System.Drawing.Size(126, 35);
            this.buttonCancelar_Mod.TabIndex = 67;
            this.buttonCancelar_Mod.Text = "CANCELAR";
            this.buttonCancelar_Mod.UseVisualStyleBackColor = false;
            // 
            // buttonGuardar_Mod
            // 
            this.buttonGuardar_Mod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGuardar_Mod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(96)))));
            this.buttonGuardar_Mod.FlatAppearance.BorderSize = 0;
            this.buttonGuardar_Mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar_Mod.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGuardar_Mod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGuardar_Mod.Location = new System.Drawing.Point(638, 439);
            this.buttonGuardar_Mod.Name = "buttonGuardar_Mod";
            this.buttonGuardar_Mod.Size = new System.Drawing.Size(115, 35);
            this.buttonGuardar_Mod.TabIndex = 66;
            this.buttonGuardar_Mod.Text = "GUARDAR";
            this.buttonGuardar_Mod.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(301, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 19);
            this.label8.TabIndex = 52;
            this.label8.Text = "Modificar Usuario";
            // 
            // VerUsuario
            // 
            this.VerUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.VerUsuario.Controls.Add(this.label11);
            this.VerUsuario.Controls.Add(this.label10);
            this.VerUsuario.Controls.Add(this.fechaActualizacion);
            this.VerUsuario.Controls.Add(this.fecha_Alta);
            this.VerUsuario.Controls.Add(this.buttonCancelar_Ver);
            this.VerUsuario.Controls.Add(this.textUserName);
            this.VerUsuario.Controls.Add(this.textNum);
            this.VerUsuario.Controls.Add(this.textCorreoE);
            this.VerUsuario.Controls.Add(this.textCargo1);
            this.VerUsuario.Controls.Add(this.textSegundoApellido);
            this.VerUsuario.Controls.Add(this.textPrimerApellido);
            this.VerUsuario.Controls.Add(this.textNombres);
            this.VerUsuario.Controls.Add(this.label9);
            this.VerUsuario.Location = new System.Drawing.Point(4, 24);
            this.VerUsuario.Name = "VerUsuario";
            this.VerUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.VerUsuario.Size = new System.Drawing.Size(760, 491);
            this.VerUsuario.TabIndex = 2;
            this.VerUsuario.Text = "Ver Usuario";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Brown;
            this.label11.Location = new System.Drawing.Point(465, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 15);
            this.label11.TabIndex = 79;
            this.label11.Text = "Fecha Modificación";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Brown;
            this.label10.Location = new System.Drawing.Point(-110, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 15);
            this.label10.TabIndex = 78;
            this.label10.Text = "Fecha Alta";
            // 
            // fechaActualizacion
            // 
            this.fechaActualizacion.CustomFormat = "dddd dd MMMM yyyy, hh:mm:ss";
            this.fechaActualizacion.Enabled = false;
            this.fechaActualizacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaActualizacion.Location = new System.Drawing.Point(444, 281);
            this.fechaActualizacion.Name = "fechaActualizacion";
            this.fechaActualizacion.Size = new System.Drawing.Size(240, 23);
            this.fechaActualizacion.TabIndex = 77;
            // 
            // fecha_Alta
            // 
            this.fecha_Alta.CustomFormat = "dddd dd MMMM yyyy, hh:mm:ss";
            this.fecha_Alta.Enabled = false;
            this.fecha_Alta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_Alta.Location = new System.Drawing.Point(97, 281);
            this.fecha_Alta.Name = "fecha_Alta";
            this.fecha_Alta.Size = new System.Drawing.Size(240, 23);
            this.fecha_Alta.TabIndex = 76;
            this.fecha_Alta.Value = new System.DateTime(2022, 11, 2, 0, 0, 0, 0);
            // 
            // buttonCancelar_Ver
            // 
            this.buttonCancelar_Ver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar_Ver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(96)))));
            this.buttonCancelar_Ver.FlatAppearance.BorderSize = 0;
            this.buttonCancelar_Ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar_Ver.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar_Ver.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCancelar_Ver.Location = new System.Drawing.Point(616, 449);
            this.buttonCancelar_Ver.Name = "buttonCancelar_Ver";
            this.buttonCancelar_Ver.Size = new System.Drawing.Size(126, 35);
            this.buttonCancelar_Ver.TabIndex = 75;
            this.buttonCancelar_Ver.Text = "CANCELAR";
            this.buttonCancelar_Ver.UseVisualStyleBackColor = false;
            // 
            // textUserName
            // 
            this.textUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textUserName.BackColor = System.Drawing.SystemColors.Control;
            this.textUserName.BorderColor = System.Drawing.Color.DimGray;
            this.textUserName.BorderFocusColor = System.Drawing.Color.IndianRed;
            this.textUserName.BorderSize = 2;
            this.textUserName.Enabled = false;
            this.textUserName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textUserName.ForeColor = System.Drawing.Color.Black;
            this.textUserName.Location = new System.Drawing.Point(509, 178);
            this.textUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textUserName.Multiline = false;
            this.textUserName.Name = "textUserName";
            this.textUserName.Padding = new System.Windows.Forms.Padding(7);
            this.textUserName.PasswordChar = false;
            this.textUserName.Size = new System.Drawing.Size(173, 31);
            this.textUserName.TabIndex = 71;
            this.textUserName.Texts = "Nombre de Usuario *";
            this.textUserName.UnderlinedStyle = true;
            // 
            // textNum
            // 
            this.textNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textNum.BackColor = System.Drawing.SystemColors.Control;
            this.textNum.BorderColor = System.Drawing.Color.DimGray;
            this.textNum.BorderFocusColor = System.Drawing.Color.IndianRed;
            this.textNum.BorderSize = 2;
            this.textNum.Enabled = false;
            this.textNum.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNum.ForeColor = System.Drawing.Color.Black;
            this.textNum.Location = new System.Drawing.Point(304, 178);
            this.textNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textNum.Multiline = false;
            this.textNum.Name = "textNum";
            this.textNum.Padding = new System.Windows.Forms.Padding(7);
            this.textNum.PasswordChar = false;
            this.textNum.Size = new System.Drawing.Size(173, 31);
            this.textNum.TabIndex = 69;
            this.textNum.Texts = "Número de teléfono *";
            this.textNum.UnderlinedStyle = true;
            // 
            // textCorreoE
            // 
            this.textCorreoE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textCorreoE.BackColor = System.Drawing.SystemColors.Control;
            this.textCorreoE.BorderColor = System.Drawing.Color.DimGray;
            this.textCorreoE.BorderFocusColor = System.Drawing.Color.IndianRed;
            this.textCorreoE.BorderSize = 2;
            this.textCorreoE.Enabled = false;
            this.textCorreoE.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCorreoE.ForeColor = System.Drawing.Color.Black;
            this.textCorreoE.Location = new System.Drawing.Point(95, 178);
            this.textCorreoE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textCorreoE.Multiline = false;
            this.textCorreoE.Name = "textCorreoE";
            this.textCorreoE.Padding = new System.Windows.Forms.Padding(7);
            this.textCorreoE.PasswordChar = false;
            this.textCorreoE.Size = new System.Drawing.Size(173, 31);
            this.textCorreoE.TabIndex = 68;
            this.textCorreoE.Texts = "Correo eléctronico *";
            this.textCorreoE.UnderlinedStyle = true;
            // 
            // textCargo1
            // 
            this.textCargo1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textCargo1.BackColor = System.Drawing.SystemColors.Control;
            this.textCargo1.BorderColor = System.Drawing.Color.DimGray;
            this.textCargo1.BorderFocusColor = System.Drawing.Color.IndianRed;
            this.textCargo1.BorderSize = 2;
            this.textCargo1.Enabled = false;
            this.textCargo1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCargo1.ForeColor = System.Drawing.Color.Black;
            this.textCargo1.Location = new System.Drawing.Point(95, 352);
            this.textCargo1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textCargo1.Multiline = false;
            this.textCargo1.Name = "textCargo1";
            this.textCargo1.Padding = new System.Windows.Forms.Padding(7);
            this.textCargo1.PasswordChar = false;
            this.textCargo1.Size = new System.Drawing.Size(173, 31);
            this.textCargo1.TabIndex = 67;
            this.textCargo1.Texts = "Cargo *";
            this.textCargo1.UnderlinedStyle = true;
            // 
            // textSegundoApellido
            // 
            this.textSegundoApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textSegundoApellido.BackColor = System.Drawing.SystemColors.Control;
            this.textSegundoApellido.BorderColor = System.Drawing.Color.DimGray;
            this.textSegundoApellido.BorderFocusColor = System.Drawing.Color.IndianRed;
            this.textSegundoApellido.BorderSize = 2;
            this.textSegundoApellido.Enabled = false;
            this.textSegundoApellido.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textSegundoApellido.ForeColor = System.Drawing.Color.Black;
            this.textSegundoApellido.Location = new System.Drawing.Point(509, 91);
            this.textSegundoApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textSegundoApellido.Multiline = false;
            this.textSegundoApellido.Name = "textSegundoApellido";
            this.textSegundoApellido.Padding = new System.Windows.Forms.Padding(7);
            this.textSegundoApellido.PasswordChar = false;
            this.textSegundoApellido.Size = new System.Drawing.Size(173, 31);
            this.textSegundoApellido.TabIndex = 66;
            this.textSegundoApellido.Texts = "Segundo Apellido";
            this.textSegundoApellido.UnderlinedStyle = true;
            // 
            // textPrimerApellido
            // 
            this.textPrimerApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textPrimerApellido.BackColor = System.Drawing.SystemColors.Control;
            this.textPrimerApellido.BorderColor = System.Drawing.Color.DimGray;
            this.textPrimerApellido.BorderFocusColor = System.Drawing.Color.IndianRed;
            this.textPrimerApellido.BorderSize = 2;
            this.textPrimerApellido.Enabled = false;
            this.textPrimerApellido.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textPrimerApellido.ForeColor = System.Drawing.Color.Black;
            this.textPrimerApellido.Location = new System.Drawing.Point(304, 91);
            this.textPrimerApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPrimerApellido.Multiline = false;
            this.textPrimerApellido.Name = "textPrimerApellido";
            this.textPrimerApellido.Padding = new System.Windows.Forms.Padding(7);
            this.textPrimerApellido.PasswordChar = false;
            this.textPrimerApellido.Size = new System.Drawing.Size(173, 31);
            this.textPrimerApellido.TabIndex = 65;
            this.textPrimerApellido.Texts = "Primer Apellido *";
            this.textPrimerApellido.UnderlinedStyle = true;
            // 
            // textNombres
            // 
            this.textNombres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textNombres.BackColor = System.Drawing.SystemColors.Control;
            this.textNombres.BorderColor = System.Drawing.Color.DimGray;
            this.textNombres.BorderFocusColor = System.Drawing.Color.IndianRed;
            this.textNombres.BorderSize = 2;
            this.textNombres.Enabled = false;
            this.textNombres.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNombres.ForeColor = System.Drawing.Color.Black;
            this.textNombres.Location = new System.Drawing.Point(95, 91);
            this.textNombres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textNombres.Multiline = false;
            this.textNombres.Name = "textNombres";
            this.textNombres.Padding = new System.Windows.Forms.Padding(7);
            this.textNombres.PasswordChar = false;
            this.textNombres.Size = new System.Drawing.Size(173, 31);
            this.textNombres.TabIndex = 64;
            this.textNombres.Texts = "Nombres *";
            this.textNombres.UnderlinedStyle = true;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(349, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 19);
            this.label9.TabIndex = 63;
            this.label9.Text = "Datos Usuario";
            // 
            // ListarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(768, 522);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarUsuario";
            this.Text = "ListarUsuario";
            this.tabControl1.ResumeLayout(false);
            this.ListaUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.EditarUsuarios.ResumeLayout(false);
            this.EditarUsuarios.PerformLayout();
            this.VerUsuario.ResumeLayout(false);
            this.VerUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage EditarUsuarios;
        private Button buttonCancelar_Mod;
        private Button buttonGuardar_Mod;
        private Label label8;
        private TabPage VerUsuario;
        private Label label11;
        private Label label10;
        public DateTimePicker fechaActualizacion;
        public DateTimePicker fecha_Alta;
        private Button buttonCancelar_Ver;
        public Sistema_de_sanciones.Templates.TextBox textUserName;
        public Sistema_de_sanciones.Templates.TextBox textNum;
        public Sistema_de_sanciones.Templates.TextBox textCorreoE;
        public Sistema_de_sanciones.Templates.TextBox textCargo1;
        public Sistema_de_sanciones.Templates.TextBox textSegundoApellido;
        public Sistema_de_sanciones.Templates.TextBox textPrimerApellido;
        public Sistema_de_sanciones.Templates.TextBox textNombres;
        private Label label9;
        private TabPage ListaUsuario;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label2;
        private Sistema_de_sanciones.Templates.RjComboBox rjComboBox1;
        private Sistema_de_sanciones.Templates.TextBox textBox8;
        private Sistema_de_sanciones.Templates.TextBox textBox7;
        private Sistema_de_sanciones.Templates.TextBox textBox6;
        private Sistema_de_sanciones.Templates.TextBox textBox5;
        private Sistema_de_sanciones.Templates.TextBox textBox4;
        private Sistema_de_sanciones.Templates.TextBox textBox2;
        private Sistema_de_sanciones.Templates.TextBox textBox1;
        private Sistema_de_sanciones.Templates.TextBox textUsuario;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewButtonColumn Editar;
        private DataGridViewCheckBoxColumn Column6;
        private Button button1;
    }
}