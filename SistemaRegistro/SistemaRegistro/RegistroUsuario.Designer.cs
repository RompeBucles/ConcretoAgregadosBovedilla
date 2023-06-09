namespace SistemaRegistro
{
    partial class RegistroUsuario
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
            labelUsuario = new Label();
            textNombre = new Sistema_de_sanciones.Templates.TextBox();
            textApellidoP = new Sistema_de_sanciones.Templates.TextBox();
            textApellidoM = new Sistema_de_sanciones.Templates.TextBox();
            textCorreo = new Sistema_de_sanciones.Templates.TextBox();
            textTelefono = new Sistema_de_sanciones.Templates.TextBox();
            textUsuario = new Sistema_de_sanciones.Templates.TextBox();
            textPassword = new Sistema_de_sanciones.Templates.TextBox();
            Guardar = new Button();
            textConfPassword = new Sistema_de_sanciones.Templates.TextBox();
            label2 = new Label();
            label3 = new Label();
            radioBtnAdmin = new RadioButton();
            radioBtnUser = new RadioButton();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // labelUsuario
            // 
            labelUsuario.Anchor = AnchorStyles.Top;
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsuario.ForeColor = Color.FromArgb(190, 31, 36);
            labelUsuario.Location = new Point(307, 24);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(138, 19);
            labelUsuario.TabIndex = 28;
            labelUsuario.Text = "Registro Usuario";
            // 
            // textNombre
            // 
            textNombre.Anchor = AnchorStyles.None;
            textNombre.BackColor = SystemColors.Control;
            textNombre.BorderColor = Color.Black;
            textNombre.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textNombre.BorderSize = 2;
            textNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textNombre.ForeColor = Color.DimGray;
            textNombre.Location = new Point(21, 109);
            textNombre.Multiline = false;
            textNombre.Name = "textNombre";
            textNombre.Padding = new Padding(7, 8, 7, 8);
            textNombre.PasswordChar = false;
            textNombre.Size = new Size(191, 36);
            textNombre.TabIndex = 29;
            textNombre.Texts = "Ejemplo: Juan";
            textNombre.UnderlinedStyle = true;
            textNombre.Enter += textNombre_Enter;
            textNombre.Leave += textNombre_Leave;
            // 
            // textApellidoP
            // 
            textApellidoP.Anchor = AnchorStyles.None;
            textApellidoP.BackColor = SystemColors.Control;
            textApellidoP.BorderColor = Color.Black;
            textApellidoP.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textApellidoP.BorderSize = 2;
            textApellidoP.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textApellidoP.ForeColor = Color.DimGray;
            textApellidoP.Location = new Point(275, 109);
            textApellidoP.Multiline = false;
            textApellidoP.Name = "textApellidoP";
            textApellidoP.Padding = new Padding(7, 8, 7, 8);
            textApellidoP.PasswordChar = false;
            textApellidoP.Size = new Size(212, 36);
            textApellidoP.TabIndex = 30;
            textApellidoP.Texts = "Ejemplo: Pérez";
            textApellidoP.UnderlinedStyle = true;
            textApellidoP.Enter += textApellidoP_Enter;
            textApellidoP.Leave += textApellidoP_Leave;
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
            textApellidoM.Location = new Point(545, 109);
            textApellidoM.Multiline = false;
            textApellidoM.Name = "textApellidoM";
            textApellidoM.Padding = new Padding(7, 8, 7, 8);
            textApellidoM.PasswordChar = false;
            textApellidoM.Size = new Size(198, 36);
            textApellidoM.TabIndex = 31;
            textApellidoM.Texts = "Ejemplo: Hernández";
            textApellidoM.UnderlinedStyle = true;
            textApellidoM.Enter += textApellidoM_Enter;
            textApellidoM.Leave += textApellidoM_Leave;
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
            textCorreo.Location = new Point(275, 220);
            textCorreo.Multiline = false;
            textCorreo.Name = "textCorreo";
            textCorreo.Padding = new Padding(7, 8, 7, 8);
            textCorreo.PasswordChar = false;
            textCorreo.Size = new Size(212, 36);
            textCorreo.TabIndex = 33;
            textCorreo.Texts = "ejemplo@unam.org.mx";
            textCorreo.UnderlinedStyle = true;
            textCorreo.Enter += textCorreo_Enter;
            textCorreo.Leave += textCorreo_Leave;
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
            textTelefono.Location = new Point(545, 220);
            textTelefono.Multiline = false;
            textTelefono.Name = "textTelefono";
            textTelefono.Padding = new Padding(7, 8, 7, 8);
            textTelefono.PasswordChar = false;
            textTelefono.Size = new Size(196, 36);
            textTelefono.TabIndex = 34;
            textTelefono.Texts = "Ejemplo: 2281144037";
            textTelefono.UnderlinedStyle = true;
            textTelefono.Enter += textTelefono_Enter;
            textTelefono.Leave += textTelefono_Leave;
            // 
            // textUsuario
            // 
            textUsuario.Anchor = AnchorStyles.None;
            textUsuario.BackColor = SystemColors.Control;
            textUsuario.BorderColor = Color.Black;
            textUsuario.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textUsuario.BorderSize = 2;
            textUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textUsuario.ForeColor = Color.DimGray;
            textUsuario.Location = new Point(23, 333);
            textUsuario.Multiline = false;
            textUsuario.Name = "textUsuario";
            textUsuario.Padding = new Padding(7, 8, 7, 8);
            textUsuario.PasswordChar = false;
            textUsuario.Size = new Size(196, 36);
            textUsuario.TabIndex = 35;
            textUsuario.Texts = "Ejemplo: jperez";
            textUsuario.UnderlinedStyle = true;
            textUsuario.Enter += textUsuario_Enter;
            textUsuario.Leave += textUsuario_Leave;
            // 
            // textPassword
            // 
            textPassword.Anchor = AnchorStyles.None;
            textPassword.BackColor = SystemColors.Control;
            textPassword.BorderColor = Color.Black;
            textPassword.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textPassword.BorderSize = 2;
            textPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textPassword.ForeColor = SystemColors.ControlText;
            textPassword.Location = new Point(275, 333);
            textPassword.Multiline = false;
            textPassword.Name = "textPassword";
            textPassword.Padding = new Padding(7, 8, 7, 8);
            textPassword.PasswordChar = true;
            textPassword.Size = new Size(196, 36);
            textPassword.TabIndex = 36;
            textPassword.Texts = "Contraseña*";
            textPassword.UnderlinedStyle = true;
            textPassword.Enter += textPassword_Enter;
            textPassword.Leave += textPassword_Leave;
            // 
            // Guardar
            // 
            Guardar.Anchor = AnchorStyles.None;
            Guardar.BackColor = Color.FromArgb(190, 31, 36);
            Guardar.FlatAppearance.BorderSize = 0;
            Guardar.FlatStyle = FlatStyle.Flat;
            Guardar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Guardar.ForeColor = SystemColors.ButtonFace;
            Guardar.Location = new Point(626, 475);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(115, 35);
            Guardar.TabIndex = 38;
            Guardar.Text = "GUARDAR";
            Guardar.UseVisualStyleBackColor = false;
            Guardar.Click += Guardar_Click;
            // 
            // textConfPassword
            // 
            textConfPassword.Anchor = AnchorStyles.None;
            textConfPassword.BackColor = SystemColors.Control;
            textConfPassword.BorderColor = Color.Black;
            textConfPassword.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textConfPassword.BorderSize = 2;
            textConfPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textConfPassword.ForeColor = SystemColors.ControlText;
            textConfPassword.Location = new Point(545, 333);
            textConfPassword.Multiline = false;
            textConfPassword.Name = "textConfPassword";
            textConfPassword.Padding = new Padding(7, 8, 7, 8);
            textConfPassword.PasswordChar = true;
            textConfPassword.Size = new Size(196, 36);
            textConfPassword.TabIndex = 39;
            textConfPassword.Texts = "Contraseña*";
            textConfPassword.UnderlinedStyle = true;
            textConfPassword.Enter += textConfPassword_Enter;
            textConfPassword.Leave += textConfPassword_Leave;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(190, 31, 36);
            label2.Location = new Point(275, 307);
            label2.Name = "label2";
            label2.Size = new Size(135, 16);
            label2.TabIndex = 64;
            label2.Text = "Ingresa Contraseña*";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(190, 31, 36);
            label3.Location = new Point(547, 307);
            label3.Name = "label3";
            label3.Size = new Size(151, 16);
            label3.TabIndex = 67;
            label3.Text = "Confirmar Contraseña*";
            // 
            // radioBtnAdmin
            // 
            radioBtnAdmin.Anchor = AnchorStyles.None;
            radioBtnAdmin.AutoSize = true;
            radioBtnAdmin.Checked = true;
            radioBtnAdmin.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            radioBtnAdmin.ForeColor = Color.Black;
            radioBtnAdmin.Location = new Point(21, 233);
            radioBtnAdmin.Name = "radioBtnAdmin";
            radioBtnAdmin.Size = new Size(124, 23);
            radioBtnAdmin.TabIndex = 68;
            radioBtnAdmin.TabStop = true;
            radioBtnAdmin.Text = "Administrador";
            radioBtnAdmin.UseVisualStyleBackColor = true;
            // 
            // radioBtnUser
            // 
            radioBtnUser.Anchor = AnchorStyles.None;
            radioBtnUser.AutoSize = true;
            radioBtnUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            radioBtnUser.ForeColor = Color.Black;
            radioBtnUser.Location = new Point(151, 233);
            radioBtnUser.Name = "radioBtnUser";
            radioBtnUser.Size = new Size(78, 23);
            radioBtnUser.TabIndex = 69;
            radioBtnUser.Text = "Usuario";
            radioBtnUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(190, 31, 36);
            label1.Location = new Point(99, 193);
            label1.Name = "label1";
            label1.Size = new Size(46, 16);
            label1.TabIndex = 70;
            label1.Text = "Perfil*";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(190, 31, 36);
            label4.Location = new Point(21, 90);
            label4.Name = "label4";
            label4.Size = new Size(62, 16);
            label4.TabIndex = 71;
            label4.Text = "Nombre*";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(190, 31, 36);
            label5.Location = new Point(275, 90);
            label5.Name = "label5";
            label5.Size = new Size(118, 16);
            label5.TabIndex = 72;
            label5.Text = "Apellido paterno*";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(190, 31, 36);
            label6.Location = new Point(547, 90);
            label6.Name = "label6";
            label6.Size = new Size(117, 16);
            label6.TabIndex = 73;
            label6.Text = "Apellido materno";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(190, 31, 36);
            label7.Location = new Point(280, 193);
            label7.Name = "label7";
            label7.Size = new Size(130, 16);
            label7.TabIndex = 74;
            label7.Text = "Correo electrónico*";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(190, 31, 36);
            label8.Location = new Point(547, 193);
            label8.Name = "label8";
            label8.Size = new Size(67, 16);
            label8.TabIndex = 75;
            label8.Text = "Teléfono*";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(190, 31, 36);
            label9.Location = new Point(23, 314);
            label9.Name = "label9";
            label9.Size = new Size(60, 16);
            label9.TabIndex = 76;
            label9.Text = "Usuario*";
            // 
            // RegistroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(242, 230, 230);
            ClientSize = new Size(768, 522);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(radioBtnUser);
            Controls.Add(radioBtnAdmin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textConfPassword);
            Controls.Add(Guardar);
            Controls.Add(textPassword);
            Controls.Add(textUsuario);
            Controls.Add(textTelefono);
            Controls.Add(textCorreo);
            Controls.Add(textApellidoM);
            Controls.Add(textApellidoP);
            Controls.Add(textNombre);
            Controls.Add(labelUsuario);
            ForeColor = Color.FromArgb(190, 31, 36);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistroUsuario";
            Text = "RegistroUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelUsuario;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox12;
        private TextBox textBox13;
        private Sistema_de_sanciones.Templates.TextBox textApellidoM;
        private Sistema_de_sanciones.Templates.TextBox textCorreo;
        private Sistema_de_sanciones.Templates.TextBox textTelefono;
        private Sistema_de_sanciones.Templates.TextBox textUsuario;
        private Sistema_de_sanciones.Templates.TextBox textPassword;
        private Sistema_de_sanciones.Templates.TextBox textConfPassword;
        private Sistema_de_sanciones.Templates.TextBox textNombre;
        private Sistema_de_sanciones.Templates.TextBox textApellidoP;
        private Button Guardar;
        private Label label2;
        private Label label3;
        private RadioButton radioBtnAdmin;
        private RadioButton radioBtnUser;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}