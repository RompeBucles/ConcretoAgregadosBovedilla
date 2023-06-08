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
            tabControl1 = new TabControl();
            ListaUsuario = new TabPage();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Column6 = new DataGridViewCheckBoxColumn();
            EditarUsuarios = new TabPage();
            label3 = new Label();
            label2 = new Label();
            textBox8 = new Sistema_de_sanciones.Templates.TextBox();
            textBox7 = new Sistema_de_sanciones.Templates.TextBox();
            textBox6 = new Sistema_de_sanciones.Templates.TextBox();
            textBox4 = new Sistema_de_sanciones.Templates.TextBox();
            textBox1 = new Sistema_de_sanciones.Templates.TextBox();
            textUsuario = new Sistema_de_sanciones.Templates.TextBox();
            buttonCancelar_Mod = new Button();
            buttonGuardar_Mod = new Button();
            label8 = new Label();
            VerUsuario = new TabPage();
            label11 = new Label();
            label10 = new Label();
            fechaActualizacion = new DateTimePicker();
            fecha_Alta = new DateTimePicker();
            buttonCancelar_Ver = new Button();
            textUserName = new Sistema_de_sanciones.Templates.TextBox();
            textNum = new Sistema_de_sanciones.Templates.TextBox();
            textCorreoE = new Sistema_de_sanciones.Templates.TextBox();
            textCargo1 = new Sistema_de_sanciones.Templates.TextBox();
            textSegundoApellido = new Sistema_de_sanciones.Templates.TextBox();
            textPrimerApellido = new Sistema_de_sanciones.Templates.TextBox();
            textNombres = new Sistema_de_sanciones.Templates.TextBox();
            label9 = new Label();
            label1 = new Label();
            radioBtnUser = new RadioButton();
            radioBtnAdmin = new RadioButton();
            textBox5 = new Sistema_de_sanciones.Templates.TextBox();
            textBox2 = new Sistema_de_sanciones.Templates.TextBox();
            tabControl1.SuspendLayout();
            ListaUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            EditarUsuarios.SuspendLayout();
            VerUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(ListaUsuario);
            tabControl1.Controls.Add(EditarUsuarios);
            tabControl1.Controls.Add(VerUsuario);
            tabControl1.Location = new Point(-3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(768, 519);
            tabControl1.TabIndex = 21;
            // 
            // ListaUsuario
            // 
            ListaUsuario.BackColor = SystemColors.Control;
            ListaUsuario.Controls.Add(button1);
            ListaUsuario.Controls.Add(dataGridView1);
            ListaUsuario.Location = new Point(4, 24);
            ListaUsuario.Name = "ListaUsuario";
            ListaUsuario.Padding = new Padding(3);
            ListaUsuario.Size = new Size(760, 491);
            ListaUsuario.TabIndex = 0;
            ListaUsuario.Text = "Lista Usuario";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(97, 97, 96);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(609, 449);
            button1.Name = "button1";
            button1.Size = new Size(151, 39);
            button1.TabIndex = 67;
            button1.Text = "Borra Selección";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Editar, Column6 });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(757, 443);
            dataGridView1.TabIndex = 27;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre completo";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Perfil";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Correo electrónico";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Telefono";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Usuario";
            Column5.Name = "Column5";
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
            EditarUsuarios.BackColor = SystemColors.Control;
            EditarUsuarios.Controls.Add(textBox5);
            EditarUsuarios.Controls.Add(textBox2);
            EditarUsuarios.Controls.Add(label1);
            EditarUsuarios.Controls.Add(radioBtnUser);
            EditarUsuarios.Controls.Add(radioBtnAdmin);
            EditarUsuarios.Controls.Add(label3);
            EditarUsuarios.Controls.Add(label2);
            EditarUsuarios.Controls.Add(textBox8);
            EditarUsuarios.Controls.Add(textBox7);
            EditarUsuarios.Controls.Add(textBox6);
            EditarUsuarios.Controls.Add(textBox4);
            EditarUsuarios.Controls.Add(textBox1);
            EditarUsuarios.Controls.Add(textUsuario);
            EditarUsuarios.Controls.Add(buttonCancelar_Mod);
            EditarUsuarios.Controls.Add(buttonGuardar_Mod);
            EditarUsuarios.Controls.Add(label8);
            EditarUsuarios.Location = new Point(4, 24);
            EditarUsuarios.Name = "EditarUsuarios";
            EditarUsuarios.Padding = new Padding(3);
            EditarUsuarios.Size = new Size(760, 491);
            EditarUsuarios.TabIndex = 1;
            EditarUsuarios.Text = "Editar Usuario";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(555, 238);
            label3.Name = "label3";
            label3.Size = new Size(151, 16);
            label3.TabIndex = 78;
            label3.Text = "Confirmar Contraseña*";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(272, 238);
            label2.Name = "label2";
            label2.Size = new Size(135, 16);
            label2.TabIndex = 77;
            label2.Text = "Ingresa Contraseña*";
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.None;
            textBox8.BackColor = SystemColors.Control;
            textBox8.BorderColor = SystemColors.ControlDarkDark;
            textBox8.BorderFocusColor = Color.Black;
            textBox8.BorderSize = 2;
            textBox8.Location = new Point(555, 268);
            textBox8.Multiline = false;
            textBox8.Name = "textBox8";
            textBox8.Padding = new Padding(7);
            textBox8.PasswordChar = true;
            textBox8.Size = new Size(196, 30);
            textBox8.TabIndex = 75;
            textBox8.Texts = "Nombre de usuario*";
            textBox8.UnderlinedStyle = true;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.None;
            textBox7.BackColor = SystemColors.Control;
            textBox7.BorderColor = SystemColors.ControlDarkDark;
            textBox7.BorderFocusColor = Color.Black;
            textBox7.BorderSize = 2;
            textBox7.Location = new Point(272, 268);
            textBox7.Multiline = false;
            textBox7.Name = "textBox7";
            textBox7.Padding = new Padding(7);
            textBox7.PasswordChar = true;
            textBox7.Size = new Size(196, 30);
            textBox7.TabIndex = 74;
            textBox7.Texts = "Contraseña*";
            textBox7.UnderlinedStyle = true;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.BackColor = SystemColors.Control;
            textBox6.BorderColor = SystemColors.ControlDarkDark;
            textBox6.BorderFocusColor = Color.Black;
            textBox6.BorderSize = 2;
            textBox6.Location = new Point(9, 268);
            textBox6.Multiline = false;
            textBox6.Name = "textBox6";
            textBox6.Padding = new Padding(7);
            textBox6.PasswordChar = false;
            textBox6.Size = new Size(196, 30);
            textBox6.TabIndex = 73;
            textBox6.Texts = "Usuario*";
            textBox6.UnderlinedStyle = true;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.BackColor = SystemColors.Control;
            textBox4.BorderColor = SystemColors.ControlDarkDark;
            textBox4.BorderFocusColor = Color.Black;
            textBox4.BorderSize = 2;
            textBox4.Location = new Point(272, 155);
            textBox4.Multiline = false;
            textBox4.Name = "textBox4";
            textBox4.Padding = new Padding(7);
            textBox4.PasswordChar = false;
            textBox4.Size = new Size(212, 30);
            textBox4.TabIndex = 71;
            textBox4.Texts = "Correo electrónico*";
            textBox4.UnderlinedStyle = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderColor = SystemColors.ControlDarkDark;
            textBox1.BorderFocusColor = Color.Black;
            textBox1.BorderSize = 2;
            textBox1.Location = new Point(272, 52);
            textBox1.Multiline = false;
            textBox1.Name = "textBox1";
            textBox1.Padding = new Padding(7);
            textBox1.PasswordChar = false;
            textBox1.Size = new Size(212, 30);
            textBox1.TabIndex = 69;
            textBox1.Texts = "Apellido paterno*";
            textBox1.UnderlinedStyle = true;
            // 
            // textUsuario
            // 
            textUsuario.Anchor = AnchorStyles.None;
            textUsuario.BackColor = SystemColors.Control;
            textUsuario.BorderColor = SystemColors.ControlDarkDark;
            textUsuario.BorderFocusColor = Color.Black;
            textUsuario.BorderSize = 2;
            textUsuario.Location = new Point(9, 52);
            textUsuario.Multiline = false;
            textUsuario.Name = "textUsuario";
            textUsuario.Padding = new Padding(7);
            textUsuario.PasswordChar = false;
            textUsuario.Size = new Size(191, 30);
            textUsuario.TabIndex = 68;
            textUsuario.Texts = "Nombre*";
            textUsuario.UnderlinedStyle = true;
            // 
            // buttonCancelar_Mod
            // 
            buttonCancelar_Mod.Anchor = AnchorStyles.None;
            buttonCancelar_Mod.BackColor = Color.FromArgb(97, 97, 96);
            buttonCancelar_Mod.FlatAppearance.BorderSize = 0;
            buttonCancelar_Mod.FlatStyle = FlatStyle.Flat;
            buttonCancelar_Mod.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar_Mod.ForeColor = SystemColors.ButtonFace;
            buttonCancelar_Mod.Location = new Point(487, 439);
            buttonCancelar_Mod.Name = "buttonCancelar_Mod";
            buttonCancelar_Mod.Size = new Size(126, 35);
            buttonCancelar_Mod.TabIndex = 67;
            buttonCancelar_Mod.Text = "CANCELAR";
            buttonCancelar_Mod.UseVisualStyleBackColor = false;
            // 
            // buttonGuardar_Mod
            // 
            buttonGuardar_Mod.Anchor = AnchorStyles.None;
            buttonGuardar_Mod.BackColor = Color.FromArgb(97, 97, 96);
            buttonGuardar_Mod.FlatAppearance.BorderSize = 0;
            buttonGuardar_Mod.FlatStyle = FlatStyle.Flat;
            buttonGuardar_Mod.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGuardar_Mod.ForeColor = SystemColors.ButtonFace;
            buttonGuardar_Mod.Location = new Point(638, 439);
            buttonGuardar_Mod.Name = "buttonGuardar_Mod";
            buttonGuardar_Mod.Size = new Size(115, 35);
            buttonGuardar_Mod.TabIndex = 66;
            buttonGuardar_Mod.Text = "GUARDAR";
            buttonGuardar_Mod.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(301, 12);
            label8.Name = "label8";
            label8.Size = new Size(143, 19);
            label8.TabIndex = 52;
            label8.Text = "Modificar Usuario";
            // 
            // VerUsuario
            // 
            VerUsuario.BackColor = SystemColors.Control;
            VerUsuario.Controls.Add(label11);
            VerUsuario.Controls.Add(label10);
            VerUsuario.Controls.Add(fechaActualizacion);
            VerUsuario.Controls.Add(fecha_Alta);
            VerUsuario.Controls.Add(buttonCancelar_Ver);
            VerUsuario.Controls.Add(textUserName);
            VerUsuario.Controls.Add(textNum);
            VerUsuario.Controls.Add(textCorreoE);
            VerUsuario.Controls.Add(textCargo1);
            VerUsuario.Controls.Add(textSegundoApellido);
            VerUsuario.Controls.Add(textPrimerApellido);
            VerUsuario.Controls.Add(textNombres);
            VerUsuario.Controls.Add(label9);
            VerUsuario.Location = new Point(4, 24);
            VerUsuario.Name = "VerUsuario";
            VerUsuario.Padding = new Padding(3);
            VerUsuario.Size = new Size(760, 491);
            VerUsuario.TabIndex = 2;
            VerUsuario.Text = "Ver Usuario";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Brown;
            label11.Location = new Point(465, 263);
            label11.Name = "label11";
            label11.Size = new Size(116, 15);
            label11.TabIndex = 79;
            label11.Text = "Fecha Modificación";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Brown;
            label10.Location = new Point(-110, 233);
            label10.Name = "label10";
            label10.Size = new Size(66, 15);
            label10.TabIndex = 78;
            label10.Text = "Fecha Alta";
            // 
            // fechaActualizacion
            // 
            fechaActualizacion.CustomFormat = "dddd dd MMMM yyyy, hh:mm:ss";
            fechaActualizacion.Enabled = false;
            fechaActualizacion.Format = DateTimePickerFormat.Custom;
            fechaActualizacion.Location = new Point(444, 281);
            fechaActualizacion.Name = "fechaActualizacion";
            fechaActualizacion.Size = new Size(240, 23);
            fechaActualizacion.TabIndex = 77;
            // 
            // fecha_Alta
            // 
            fecha_Alta.CustomFormat = "dddd dd MMMM yyyy, hh:mm:ss";
            fecha_Alta.Enabled = false;
            fecha_Alta.Format = DateTimePickerFormat.Custom;
            fecha_Alta.Location = new Point(97, 281);
            fecha_Alta.Name = "fecha_Alta";
            fecha_Alta.Size = new Size(240, 23);
            fecha_Alta.TabIndex = 76;
            fecha_Alta.Value = new DateTime(2022, 11, 2, 0, 0, 0, 0);
            // 
            // buttonCancelar_Ver
            // 
            buttonCancelar_Ver.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar_Ver.BackColor = Color.FromArgb(97, 97, 96);
            buttonCancelar_Ver.FlatAppearance.BorderSize = 0;
            buttonCancelar_Ver.FlatStyle = FlatStyle.Flat;
            buttonCancelar_Ver.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar_Ver.ForeColor = SystemColors.ButtonFace;
            buttonCancelar_Ver.Location = new Point(616, 449);
            buttonCancelar_Ver.Name = "buttonCancelar_Ver";
            buttonCancelar_Ver.Size = new Size(126, 35);
            buttonCancelar_Ver.TabIndex = 75;
            buttonCancelar_Ver.Text = "CANCELAR";
            buttonCancelar_Ver.UseVisualStyleBackColor = false;
            // 
            // textUserName
            // 
            textUserName.Anchor = AnchorStyles.Top;
            textUserName.BackColor = SystemColors.Control;
            textUserName.BorderColor = Color.DimGray;
            textUserName.BorderFocusColor = Color.IndianRed;
            textUserName.BorderSize = 2;
            textUserName.Enabled = false;
            textUserName.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textUserName.ForeColor = Color.Black;
            textUserName.Location = new Point(509, 178);
            textUserName.Margin = new Padding(3, 4, 3, 4);
            textUserName.Multiline = false;
            textUserName.Name = "textUserName";
            textUserName.Padding = new Padding(7);
            textUserName.PasswordChar = false;
            textUserName.Size = new Size(173, 31);
            textUserName.TabIndex = 71;
            textUserName.Texts = "Nombre de Usuario *";
            textUserName.UnderlinedStyle = true;
            // 
            // textNum
            // 
            textNum.Anchor = AnchorStyles.Top;
            textNum.BackColor = SystemColors.Control;
            textNum.BorderColor = Color.DimGray;
            textNum.BorderFocusColor = Color.IndianRed;
            textNum.BorderSize = 2;
            textNum.Enabled = false;
            textNum.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textNum.ForeColor = Color.Black;
            textNum.Location = new Point(304, 178);
            textNum.Margin = new Padding(3, 4, 3, 4);
            textNum.Multiline = false;
            textNum.Name = "textNum";
            textNum.Padding = new Padding(7);
            textNum.PasswordChar = false;
            textNum.Size = new Size(173, 31);
            textNum.TabIndex = 69;
            textNum.Texts = "Número de teléfono *";
            textNum.UnderlinedStyle = true;
            // 
            // textCorreoE
            // 
            textCorreoE.Anchor = AnchorStyles.Top;
            textCorreoE.BackColor = SystemColors.Control;
            textCorreoE.BorderColor = Color.DimGray;
            textCorreoE.BorderFocusColor = Color.IndianRed;
            textCorreoE.BorderSize = 2;
            textCorreoE.Enabled = false;
            textCorreoE.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textCorreoE.ForeColor = Color.Black;
            textCorreoE.Location = new Point(95, 178);
            textCorreoE.Margin = new Padding(3, 4, 3, 4);
            textCorreoE.Multiline = false;
            textCorreoE.Name = "textCorreoE";
            textCorreoE.Padding = new Padding(7);
            textCorreoE.PasswordChar = false;
            textCorreoE.Size = new Size(173, 31);
            textCorreoE.TabIndex = 68;
            textCorreoE.Texts = "Correo eléctronico *";
            textCorreoE.UnderlinedStyle = true;
            // 
            // textCargo1
            // 
            textCargo1.Anchor = AnchorStyles.Top;
            textCargo1.BackColor = SystemColors.Control;
            textCargo1.BorderColor = Color.DimGray;
            textCargo1.BorderFocusColor = Color.IndianRed;
            textCargo1.BorderSize = 2;
            textCargo1.Enabled = false;
            textCargo1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textCargo1.ForeColor = Color.Black;
            textCargo1.Location = new Point(95, 352);
            textCargo1.Margin = new Padding(3, 4, 3, 4);
            textCargo1.Multiline = false;
            textCargo1.Name = "textCargo1";
            textCargo1.Padding = new Padding(7);
            textCargo1.PasswordChar = false;
            textCargo1.Size = new Size(173, 31);
            textCargo1.TabIndex = 67;
            textCargo1.Texts = "Cargo *";
            textCargo1.UnderlinedStyle = true;
            // 
            // textSegundoApellido
            // 
            textSegundoApellido.Anchor = AnchorStyles.Top;
            textSegundoApellido.BackColor = SystemColors.Control;
            textSegundoApellido.BorderColor = Color.DimGray;
            textSegundoApellido.BorderFocusColor = Color.IndianRed;
            textSegundoApellido.BorderSize = 2;
            textSegundoApellido.Enabled = false;
            textSegundoApellido.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textSegundoApellido.ForeColor = Color.Black;
            textSegundoApellido.Location = new Point(509, 91);
            textSegundoApellido.Margin = new Padding(3, 4, 3, 4);
            textSegundoApellido.Multiline = false;
            textSegundoApellido.Name = "textSegundoApellido";
            textSegundoApellido.Padding = new Padding(7);
            textSegundoApellido.PasswordChar = false;
            textSegundoApellido.Size = new Size(173, 31);
            textSegundoApellido.TabIndex = 66;
            textSegundoApellido.Texts = "Segundo Apellido";
            textSegundoApellido.UnderlinedStyle = true;
            // 
            // textPrimerApellido
            // 
            textPrimerApellido.Anchor = AnchorStyles.Top;
            textPrimerApellido.BackColor = SystemColors.Control;
            textPrimerApellido.BorderColor = Color.DimGray;
            textPrimerApellido.BorderFocusColor = Color.IndianRed;
            textPrimerApellido.BorderSize = 2;
            textPrimerApellido.Enabled = false;
            textPrimerApellido.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textPrimerApellido.ForeColor = Color.Black;
            textPrimerApellido.Location = new Point(304, 91);
            textPrimerApellido.Margin = new Padding(3, 4, 3, 4);
            textPrimerApellido.Multiline = false;
            textPrimerApellido.Name = "textPrimerApellido";
            textPrimerApellido.Padding = new Padding(7);
            textPrimerApellido.PasswordChar = false;
            textPrimerApellido.Size = new Size(173, 31);
            textPrimerApellido.TabIndex = 65;
            textPrimerApellido.Texts = "Primer Apellido *";
            textPrimerApellido.UnderlinedStyle = true;
            // 
            // textNombres
            // 
            textNombres.Anchor = AnchorStyles.Top;
            textNombres.BackColor = SystemColors.Control;
            textNombres.BorderColor = Color.DimGray;
            textNombres.BorderFocusColor = Color.IndianRed;
            textNombres.BorderSize = 2;
            textNombres.Enabled = false;
            textNombres.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textNombres.ForeColor = Color.Black;
            textNombres.Location = new Point(95, 91);
            textNombres.Margin = new Padding(3, 4, 3, 4);
            textNombres.Multiline = false;
            textNombres.Name = "textNombres";
            textNombres.Padding = new Padding(7);
            textNombres.PasswordChar = false;
            textNombres.Size = new Size(173, 31);
            textNombres.TabIndex = 64;
            textNombres.Texts = "Nombres *";
            textNombres.UnderlinedStyle = true;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(349, 16);
            label9.Name = "label9";
            label9.Size = new Size(118, 19);
            label9.TabIndex = 63;
            label9.Text = "Datos Usuario";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(80, 134);
            label1.Name = "label1";
            label1.Size = new Size(46, 16);
            label1.TabIndex = 81;
            label1.Text = "Perfil*";
            // 
            // radioBtnUser
            // 
            radioBtnUser.Anchor = AnchorStyles.None;
            radioBtnUser.AutoSize = true;
            radioBtnUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtnUser.Location = new Point(131, 164);
            radioBtnUser.Name = "radioBtnUser";
            radioBtnUser.Size = new Size(71, 21);
            radioBtnUser.TabIndex = 80;
            radioBtnUser.Text = "Usuario";
            radioBtnUser.UseVisualStyleBackColor = true;
            // 
            // radioBtnAdmin
            // 
            radioBtnAdmin.Anchor = AnchorStyles.None;
            radioBtnAdmin.AutoSize = true;
            radioBtnAdmin.Checked = true;
            radioBtnAdmin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtnAdmin.Location = new Point(6, 164);
            radioBtnAdmin.Name = "radioBtnAdmin";
            radioBtnAdmin.Size = new Size(109, 21);
            radioBtnAdmin.TabIndex = 79;
            radioBtnAdmin.TabStop = true;
            radioBtnAdmin.Text = "Administrador";
            radioBtnAdmin.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.BackColor = SystemColors.Control;
            textBox5.BorderColor = SystemColors.ControlDarkDark;
            textBox5.BorderFocusColor = Color.Black;
            textBox5.BorderSize = 2;
            textBox5.Location = new Point(555, 155);
            textBox5.Multiline = false;
            textBox5.Name = "textBox5";
            textBox5.Padding = new Padding(7);
            textBox5.PasswordChar = false;
            textBox5.Size = new Size(196, 30);
            textBox5.TabIndex = 83;
            textBox5.Texts = "Teléfono*";
            textBox5.UnderlinedStyle = true;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderColor = SystemColors.ControlDarkDark;
            textBox2.BorderFocusColor = Color.Black;
            textBox2.BorderSize = 2;
            textBox2.Location = new Point(555, 52);
            textBox2.Multiline = false;
            textBox2.Name = "textBox2";
            textBox2.Padding = new Padding(7);
            textBox2.PasswordChar = false;
            textBox2.Size = new Size(198, 30);
            textBox2.TabIndex = 82;
            textBox2.Texts = "Apellido materno";
            textBox2.UnderlinedStyle = true;
            // 
            // ListarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(768, 522);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListarUsuario";
            Text = "ListarUsuario";
            tabControl1.ResumeLayout(false);
            ListaUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            EditarUsuarios.ResumeLayout(false);
            EditarUsuarios.PerformLayout();
            VerUsuario.ResumeLayout(false);
            VerUsuario.PerformLayout();
            ResumeLayout(false);
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
        private Sistema_de_sanciones.Templates.TextBox textBox8;
        private Sistema_de_sanciones.Templates.TextBox textBox7;
        private Sistema_de_sanciones.Templates.TextBox textBox6;
        private Sistema_de_sanciones.Templates.TextBox textBox4;
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
        private Label label1;
        private RadioButton radioBtnUser;
        private RadioButton radioBtnAdmin;
        private Sistema_de_sanciones.Templates.TextBox textBox5;
        private Sistema_de_sanciones.Templates.TextBox textBox2;
    }
}