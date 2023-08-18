namespace SistemaRegistro
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarUsuario));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            EditarUsuarios = new TabPage();
            comboEstatus = new ComboBox();
            label9 = new Label();
            pbMostrar1 = new PictureBox();
            pbOcultar1 = new PictureBox();
            pbMostrar = new PictureBox();
            textConfPassword = new Templates.TextBox();
            textPassword = new Templates.TextBox();
            pbOcultar = new PictureBox();
            textUsuario = new Templates.TextBox();
            textTelefono = new Templates.TextBox();
            textCorreo = new Templates.TextBox();
            textApellidoM = new Templates.TextBox();
            textApellidoP = new Templates.TextBox();
            textNombre = new Templates.TextBox();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label12 = new Label();
            label13 = new Label();
            label1 = new Label();
            radioBtnUser = new RadioButton();
            radioBtnAdmin = new RadioButton();
            label3 = new Label();
            label2 = new Label();
            buttonCancelar_Mod = new Button();
            buttonGuardar_Mod = new Button();
            label8 = new Label();
            tabControl1 = new TabControl();
            ListaUsuario = new TabPage();
            panel2 = new Panel();
            textNusuario = new TextBox();
            dataGridView1 = new DataGridView();
            btnSeleccionT = new Button();
            button1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel1 = new Panel();
            EditarUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMostrar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOcultar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMostrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOcultar).BeginInit();
            tabControl1.SuspendLayout();
            ListaUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // EditarUsuarios
            // 
            EditarUsuarios.BackColor = Color.FromArgb(242, 230, 230);
            EditarUsuarios.Controls.Add(comboEstatus);
            EditarUsuarios.Controls.Add(label9);
            EditarUsuarios.Controls.Add(pbMostrar1);
            EditarUsuarios.Controls.Add(pbOcultar1);
            EditarUsuarios.Controls.Add(pbMostrar);
            EditarUsuarios.Controls.Add(textConfPassword);
            EditarUsuarios.Controls.Add(textPassword);
            EditarUsuarios.Controls.Add(pbOcultar);
            EditarUsuarios.Controls.Add(textUsuario);
            EditarUsuarios.Controls.Add(textTelefono);
            EditarUsuarios.Controls.Add(textCorreo);
            EditarUsuarios.Controls.Add(textApellidoM);
            EditarUsuarios.Controls.Add(textApellidoP);
            EditarUsuarios.Controls.Add(textNombre);
            EditarUsuarios.Controls.Add(label4);
            EditarUsuarios.Controls.Add(label5);
            EditarUsuarios.Controls.Add(label7);
            EditarUsuarios.Controls.Add(label6);
            EditarUsuarios.Controls.Add(label12);
            EditarUsuarios.Controls.Add(label13);
            EditarUsuarios.Controls.Add(label1);
            EditarUsuarios.Controls.Add(radioBtnUser);
            EditarUsuarios.Controls.Add(radioBtnAdmin);
            EditarUsuarios.Controls.Add(label3);
            EditarUsuarios.Controls.Add(label2);
            EditarUsuarios.Controls.Add(buttonCancelar_Mod);
            EditarUsuarios.Controls.Add(buttonGuardar_Mod);
            EditarUsuarios.Controls.Add(label8);
            EditarUsuarios.Location = new Point(4, 24);
            EditarUsuarios.Name = "EditarUsuarios";
            EditarUsuarios.Padding = new Padding(3);
            EditarUsuarios.Size = new Size(767, 492);
            EditarUsuarios.TabIndex = 1;
            EditarUsuarios.Text = "Editar Usuario";
            // 
            // comboEstatus
            // 
            comboEstatus.Anchor = AnchorStyles.None;
            comboEstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEstatus.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboEstatus.ForeColor = Color.FromArgb(97, 97, 96);
            comboEstatus.FormattingEnabled = true;
            comboEstatus.Items.AddRange(new object[] { "Activo", "Inactivo" });
            comboEstatus.Location = new Point(5, 380);
            comboEstatus.Name = "comboEstatus";
            comboEstatus.Size = new Size(196, 24);
            comboEstatus.TabIndex = 106;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(190, 31, 36);
            label9.Location = new Point(80, 349);
            label9.Name = "label9";
            label9.Size = new Size(51, 16);
            label9.TabIndex = 105;
            label9.Text = "Estatus";
            // 
            // pbMostrar1
            // 
            pbMostrar1.Anchor = AnchorStyles.None;
            pbMostrar1.Cursor = Cursors.Hand;
            pbMostrar1.Image = (Image)resources.GetObject("pbMostrar1.Image");
            pbMostrar1.Location = new Point(688, 290);
            pbMostrar1.Name = "pbMostrar1";
            pbMostrar1.Size = new Size(46, 23);
            pbMostrar1.SizeMode = PictureBoxSizeMode.Zoom;
            pbMostrar1.TabIndex = 102;
            pbMostrar1.TabStop = false;
            pbMostrar1.Click += pbMostrar1_Click;
            // 
            // pbOcultar1
            // 
            pbOcultar1.Anchor = AnchorStyles.None;
            pbOcultar1.Cursor = Cursors.Hand;
            pbOcultar1.Image = (Image)resources.GetObject("pbOcultar1.Image");
            pbOcultar1.Location = new Point(688, 290);
            pbOcultar1.Name = "pbOcultar1";
            pbOcultar1.Size = new Size(44, 23);
            pbOcultar1.SizeMode = PictureBoxSizeMode.Zoom;
            pbOcultar1.TabIndex = 101;
            pbOcultar1.TabStop = false;
            pbOcultar1.Click += pbOcultar1_Click;
            // 
            // pbMostrar
            // 
            pbMostrar.Anchor = AnchorStyles.None;
            pbMostrar.Cursor = Cursors.Hand;
            pbMostrar.Image = (Image)resources.GetObject("pbMostrar.Image");
            pbMostrar.Location = new Point(415, 290);
            pbMostrar.Name = "pbMostrar";
            pbMostrar.Size = new Size(47, 23);
            pbMostrar.SizeMode = PictureBoxSizeMode.Zoom;
            pbMostrar.TabIndex = 100;
            pbMostrar.TabStop = false;
            pbMostrar.Click += pbMostrar_Click;
            // 
            // textConfPassword
            // 
            textConfPassword.Anchor = AnchorStyles.None;
            textConfPassword.BackColor = SystemColors.Control;
            textConfPassword.BorderColor = Color.Black;
            textConfPassword.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textConfPassword.BorderSize = 2;
            textConfPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textConfPassword.ForeColor = Color.DimGray;
            textConfPassword.Location = new Point(536, 283);
            textConfPassword.Multiline = false;
            textConfPassword.Name = "textConfPassword";
            textConfPassword.Padding = new Padding(7, 8, 7, 8);
            textConfPassword.PasswordChar = true;
            textConfPassword.Size = new Size(196, 36);
            textConfPassword.TabIndex = 99;
            textConfPassword.Texts = "Contraseña*";
            textConfPassword.UnderlinedStyle = true;
            textConfPassword.Enter += textConfPassword_Enter;
            textConfPassword.Leave += textConfPassword_Leave;
            // 
            // textPassword
            // 
            textPassword.Anchor = AnchorStyles.None;
            textPassword.BackColor = SystemColors.Control;
            textPassword.BorderColor = Color.Black;
            textPassword.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textPassword.BorderSize = 2;
            textPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textPassword.ForeColor = Color.DimGray;
            textPassword.Location = new Point(266, 283);
            textPassword.Multiline = false;
            textPassword.Name = "textPassword";
            textPassword.Padding = new Padding(7, 8, 7, 8);
            textPassword.PasswordChar = true;
            textPassword.Size = new Size(196, 36);
            textPassword.TabIndex = 98;
            textPassword.Texts = "Contraseña*";
            textPassword.UnderlinedStyle = true;
            textPassword.Enter += textPassword_Enter;
            textPassword.Leave += textPassword_Leave;
            // 
            // pbOcultar
            // 
            pbOcultar.Anchor = AnchorStyles.None;
            pbOcultar.Cursor = Cursors.Hand;
            pbOcultar.Image = (Image)resources.GetObject("pbOcultar.Image");
            pbOcultar.Location = new Point(415, 290);
            pbOcultar.Name = "pbOcultar";
            pbOcultar.Size = new Size(47, 23);
            pbOcultar.SizeMode = PictureBoxSizeMode.Zoom;
            pbOcultar.TabIndex = 103;
            pbOcultar.TabStop = false;
            pbOcultar.Click += pbOcultar_Click;
            // 
            // textUsuario
            // 
            textUsuario.Anchor = AnchorStyles.None;
            textUsuario.BackColor = SystemColors.Control;
            textUsuario.BorderColor = Color.Black;
            textUsuario.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textUsuario.BorderSize = 2;
            textUsuario.Enabled = false;
            textUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textUsuario.ForeColor = Color.DimGray;
            textUsuario.Location = new Point(5, 283);
            textUsuario.Multiline = false;
            textUsuario.Name = "textUsuario";
            textUsuario.Padding = new Padding(7, 8, 7, 8);
            textUsuario.PasswordChar = false;
            textUsuario.Size = new Size(196, 36);
            textUsuario.TabIndex = 97;
            textUsuario.Texts = "Ejemplo: jperez";
            textUsuario.UnderlinedStyle = true;
            textUsuario.Enter += textUsuario_Enter;
            textUsuario.Leave += textUsuario_Leave;
            // 
            // textTelefono
            // 
            textTelefono.Anchor = AnchorStyles.None;
            textTelefono.BackColor = SystemColors.Control;
            textTelefono.BorderColor = Color.Black;
            textTelefono.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textTelefono.BorderSize = 2;
            textTelefono.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textTelefono.ForeColor = Color.DimGray;
            textTelefono.Location = new Point(549, 159);
            textTelefono.Multiline = false;
            textTelefono.Name = "textTelefono";
            textTelefono.Padding = new Padding(7, 8, 7, 8);
            textTelefono.PasswordChar = false;
            textTelefono.Size = new Size(196, 36);
            textTelefono.TabIndex = 96;
            textTelefono.Texts = "Ejemplo: 2281144037";
            textTelefono.UnderlinedStyle = true;
            textTelefono.Enter += textTelefono_Enter;
            textTelefono.Leave += textTelefono_Leave;
            // 
            // textCorreo
            // 
            textCorreo.Anchor = AnchorStyles.None;
            textCorreo.BackColor = SystemColors.Control;
            textCorreo.BorderColor = Color.Black;
            textCorreo.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textCorreo.BorderSize = 2;
            textCorreo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textCorreo.ForeColor = Color.DimGray;
            textCorreo.Location = new Point(266, 159);
            textCorreo.Multiline = false;
            textCorreo.Name = "textCorreo";
            textCorreo.Padding = new Padding(7, 8, 7, 8);
            textCorreo.PasswordChar = false;
            textCorreo.Size = new Size(212, 36);
            textCorreo.TabIndex = 95;
            textCorreo.Texts = "ejemplo@unam.org.mx";
            textCorreo.UnderlinedStyle = true;
            textCorreo.Enter += textCorreo_Enter;
            textCorreo.Leave += textCorreo_Leave;
            // 
            // textApellidoM
            // 
            textApellidoM.Anchor = AnchorStyles.None;
            textApellidoM.BackColor = SystemColors.Control;
            textApellidoM.BorderColor = Color.Black;
            textApellidoM.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textApellidoM.BorderSize = 2;
            textApellidoM.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textApellidoM.ForeColor = Color.DimGray;
            textApellidoM.Location = new Point(549, 59);
            textApellidoM.Multiline = false;
            textApellidoM.Name = "textApellidoM";
            textApellidoM.Padding = new Padding(7, 8, 7, 8);
            textApellidoM.PasswordChar = false;
            textApellidoM.Size = new Size(198, 36);
            textApellidoM.TabIndex = 94;
            textApellidoM.Texts = "Ejemplo: Hernández";
            textApellidoM.UnderlinedStyle = true;
            textApellidoM.Enter += textApellidoM_Enter;
            textApellidoM.KeyPress += textApelldioM_KeyPress;
            textApellidoM.Leave += textApellidoM_Leave;
            // 
            // textApellidoP
            // 
            textApellidoP.Anchor = AnchorStyles.None;
            textApellidoP.BackColor = SystemColors.Control;
            textApellidoP.BorderColor = Color.Black;
            textApellidoP.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textApellidoP.BorderSize = 2;
            textApellidoP.Enabled = false;
            textApellidoP.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textApellidoP.ForeColor = Color.DimGray;
            textApellidoP.Location = new Point(266, 59);
            textApellidoP.Multiline = false;
            textApellidoP.Name = "textApellidoP";
            textApellidoP.Padding = new Padding(7, 8, 7, 8);
            textApellidoP.PasswordChar = false;
            textApellidoP.Size = new Size(212, 36);
            textApellidoP.TabIndex = 93;
            textApellidoP.Texts = "Ejemplo: Pérez";
            textApellidoP.UnderlinedStyle = true;
            textApellidoP.Enter += textApellidoP_Enter;
            textApellidoP.Leave += textApellidoP_Leave;
            // 
            // textNombre
            // 
            textNombre.Anchor = AnchorStyles.None;
            textNombre.BackColor = SystemColors.Control;
            textNombre.BorderColor = Color.Black;
            textNombre.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textNombre.BorderSize = 2;
            textNombre.Enabled = false;
            textNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textNombre.ForeColor = Color.DimGray;
            textNombre.Location = new Point(5, 59);
            textNombre.Multiline = false;
            textNombre.Name = "textNombre";
            textNombre.Padding = new Padding(7, 8, 7, 8);
            textNombre.PasswordChar = false;
            textNombre.Size = new Size(191, 36);
            textNombre.TabIndex = 92;
            textNombre.Texts = "Ejemplo: Juan";
            textNombre.UnderlinedStyle = true;
            textNombre.Enter += textNombre_Enter;
            textNombre.Leave += textNombre_Leave;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(190, 31, 36);
            label4.Location = new Point(5, 252);
            label4.Name = "label4";
            label4.Size = new Size(60, 16);
            label4.TabIndex = 91;
            label4.Text = "Usuario*";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(190, 31, 36);
            label5.Location = new Point(549, 130);
            label5.Name = "label5";
            label5.Size = new Size(67, 16);
            label5.TabIndex = 90;
            label5.Text = "Teléfono*";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(190, 31, 36);
            label7.Location = new Point(266, 130);
            label7.Name = "label7";
            label7.Size = new Size(130, 16);
            label7.TabIndex = 89;
            label7.Text = "Correo electrónico*";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(190, 31, 36);
            label6.Location = new Point(549, 40);
            label6.Name = "label6";
            label6.Size = new Size(117, 16);
            label6.TabIndex = 88;
            label6.Text = "Apellido materno";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(190, 31, 36);
            label12.Location = new Point(266, 40);
            label12.Name = "label12";
            label12.Size = new Size(118, 16);
            label12.TabIndex = 87;
            label12.Text = "Apellido paterno*";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(190, 31, 36);
            label13.Location = new Point(3, 40);
            label13.Name = "label13";
            label13.Size = new Size(62, 16);
            label13.TabIndex = 86;
            label13.Text = "Nombre*";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(190, 31, 36);
            label1.Location = new Point(80, 130);
            label1.Name = "label1";
            label1.Size = new Size(46, 16);
            label1.TabIndex = 81;
            label1.Text = "Perfil*";
            // 
            // radioBtnUser
            // 
            radioBtnUser.Anchor = AnchorStyles.None;
            radioBtnUser.AutoSize = true;
            radioBtnUser.Enabled = false;
            radioBtnUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioBtnUser.ForeColor = Color.Black;
            radioBtnUser.Location = new Point(136, 170);
            radioBtnUser.Name = "radioBtnUser";
            radioBtnUser.Size = new Size(73, 21);
            radioBtnUser.TabIndex = 80;
            radioBtnUser.Text = "Usuario";
            radioBtnUser.UseVisualStyleBackColor = true;
            // 
            // radioBtnAdmin
            // 
            radioBtnAdmin.Anchor = AnchorStyles.None;
            radioBtnAdmin.AutoSize = true;
            radioBtnAdmin.Checked = true;
            radioBtnAdmin.Enabled = false;
            radioBtnAdmin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioBtnAdmin.ForeColor = Color.Black;
            radioBtnAdmin.Location = new Point(11, 170);
            radioBtnAdmin.Name = "radioBtnAdmin";
            radioBtnAdmin.Size = new Size(115, 21);
            radioBtnAdmin.TabIndex = 79;
            radioBtnAdmin.TabStop = true;
            radioBtnAdmin.Text = "Administrador";
            radioBtnAdmin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(190, 31, 36);
            label3.Location = new Point(549, 252);
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
            label2.ForeColor = Color.FromArgb(190, 31, 36);
            label2.Location = new Point(266, 252);
            label2.Name = "label2";
            label2.Size = new Size(135, 16);
            label2.TabIndex = 77;
            label2.Text = "Ingresa Contraseña*";
            // 
            // buttonCancelar_Mod
            // 
            buttonCancelar_Mod.Anchor = AnchorStyles.None;
            buttonCancelar_Mod.BackColor = Color.FromArgb(190, 31, 36);
            buttonCancelar_Mod.FlatAppearance.BorderSize = 0;
            buttonCancelar_Mod.FlatStyle = FlatStyle.Flat;
            buttonCancelar_Mod.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar_Mod.ForeColor = SystemColors.ButtonFace;
            buttonCancelar_Mod.Location = new Point(491, 449);
            buttonCancelar_Mod.Name = "buttonCancelar_Mod";
            buttonCancelar_Mod.Size = new Size(126, 35);
            buttonCancelar_Mod.TabIndex = 67;
            buttonCancelar_Mod.Text = "REGRESAR";
            buttonCancelar_Mod.UseVisualStyleBackColor = false;
            buttonCancelar_Mod.Click += buttonCancelar_Mod_Click;
            // 
            // buttonGuardar_Mod
            // 
            buttonGuardar_Mod.Anchor = AnchorStyles.None;
            buttonGuardar_Mod.BackColor = Color.FromArgb(190, 31, 36);
            buttonGuardar_Mod.FlatAppearance.BorderSize = 0;
            buttonGuardar_Mod.FlatStyle = FlatStyle.Flat;
            buttonGuardar_Mod.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGuardar_Mod.ForeColor = SystemColors.ButtonFace;
            buttonGuardar_Mod.Location = new Point(642, 449);
            buttonGuardar_Mod.Name = "buttonGuardar_Mod";
            buttonGuardar_Mod.Size = new Size(115, 35);
            buttonGuardar_Mod.TabIndex = 66;
            buttonGuardar_Mod.Text = "GUARDAR";
            buttonGuardar_Mod.UseVisualStyleBackColor = false;
            buttonGuardar_Mod.Click += buttonGuardar_Mod_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(190, 31, 36);
            label8.Location = new Point(295, 12);
            label8.Name = "label8";
            label8.Size = new Size(143, 19);
            label8.TabIndex = 52;
            label8.Text = "Modificar Usuario";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(ListaUsuario);
            tabControl1.Controls.Add(EditarUsuarios);
            tabControl1.Location = new Point(-4, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(775, 520);
            tabControl1.TabIndex = 21;
            // 
            // ListaUsuario
            // 
            ListaUsuario.BackColor = Color.FromArgb(242, 230, 230);
            ListaUsuario.Controls.Add(panel2);
            ListaUsuario.Controls.Add(textNusuario);
            ListaUsuario.Controls.Add(dataGridView1);
            ListaUsuario.Controls.Add(btnSeleccionT);
            ListaUsuario.Controls.Add(button1);
            ListaUsuario.Location = new Point(4, 24);
            ListaUsuario.Name = "ListaUsuario";
            ListaUsuario.Padding = new Padding(3);
            ListaUsuario.Size = new Size(767, 492);
            ListaUsuario.TabIndex = 0;
            ListaUsuario.Text = "Lista Usuario";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Location = new Point(11, 448);
            panel2.Name = "panel2";
            panel2.Size = new Size(199, 38);
            panel2.TabIndex = 83;
            panel2.Visible = false;
            // 
            // textNusuario
            // 
            textNusuario.Location = new Point(11, 461);
            textNusuario.Name = "textNusuario";
            textNusuario.Size = new Size(100, 23);
            textNusuario.TabIndex = 82;
            textNusuario.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = Color.FromArgb(242, 230, 230);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
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
            dataGridView1.Location = new Point(1, 3);
            dataGridView1.Name = "dataGridView1";
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
            dataGridView1.Size = new Size(760, 438);
            dataGridView1.TabIndex = 74;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            dataGridView1.RowPostPaint += dataGridView1_RowPostPaint;
            // 
            // btnSeleccionT
            // 
            btnSeleccionT.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSeleccionT.BackColor = Color.FromArgb(190, 31, 36);
            btnSeleccionT.FlatAppearance.BorderSize = 0;
            btnSeleccionT.FlatStyle = FlatStyle.Flat;
            btnSeleccionT.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSeleccionT.ForeColor = SystemColors.ButtonFace;
            btnSeleccionT.Location = new Point(450, 447);
            btnSeleccionT.Name = "btnSeleccionT";
            btnSeleccionT.Size = new Size(144, 39);
            btnSeleccionT.TabIndex = 72;
            btnSeleccionT.Text = "Seleccionar todo";
            btnSeleccionT.UseVisualStyleBackColor = false;
            btnSeleccionT.Click += btnSeleccionT_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(190, 31, 36);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(614, 447);
            button1.Name = "button1";
            button1.Size = new Size(151, 39);
            button1.TabIndex = 71;
            button1.Text = "Borra Selección";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.Location = new Point(-1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 24);
            panel1.TabIndex = 22;
            // 
            // ListarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(242, 230, 230);
            ClientSize = new Size(768, 522);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListarUsuario";
            Text = "ListarUsuario";
            Load += ListarUsuarios_Load;
            EditarUsuarios.ResumeLayout(false);
            EditarUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMostrar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOcultar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMostrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOcultar).EndInit();
            tabControl1.ResumeLayout(false);
            ListaUsuario.ResumeLayout(false);
            ListaUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabPage EditarUsuarios;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label12;
        private Label label13;
        private Label label1;
        private RadioButton radioBtnUser;
        private RadioButton radioBtnAdmin;
        private Label label3;
        private Label label2;
        private Button buttonCancelar_Mod;
        private Button buttonGuardar_Mod;
        private Label label8;
        private TabControl tabControl1;
        private SistemaRegistro.Templates.TextBox textUsuario;
        private SistemaRegistro.Templates.TextBox textTelefono;
        private SistemaRegistro.Templates.TextBox textCorreo;
        private SistemaRegistro.Templates.TextBox textApellidoM;
        private SistemaRegistro.Templates.TextBox textApellidoP;
        private SistemaRegistro.Templates.TextBox textNombre;
        private ErrorProvider errorProvider1;
        private PictureBox pbMostrar1;
        private PictureBox pbOcultar1;
        private PictureBox pbMostrar;
        private Templates.TextBox textConfPassword;
        private Templates.TextBox textPassword;
        private PictureBox pbOcultar;
        private Label label9;
        private ComboBox comboEstatus;
        private Panel panel1;
        private TabPage ListaUsuario;
        private DataGridView dataGridView1;
        private Button btnSeleccionT;
        private Button button1;
        private TextBox textNusuario;
        private Panel panel2;
    }
}