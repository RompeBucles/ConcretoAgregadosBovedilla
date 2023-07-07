namespace SistemaRegistro
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnEntrar = new Button();
            textPassword = new Templates.TextBox();
            textUsuario = new Templates.TextBox();
            label11 = new Label();
            label1 = new Label();
            pbMostrar = new PictureBox();
            pbOcultar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMostrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOcultar).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(190, 31, 36);
            label2.Location = new Point(397, 215);
            label2.Name = "label2";
            label2.Size = new Size(191, 32);
            label2.TabIndex = 103;
            label2.Text = "Iniciar sesión";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(255, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(475, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 102;
            pictureBox1.TabStop = false;
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.None;
            btnEntrar.BackColor = Color.FromArgb(190, 31, 36);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(453, 460);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(84, 33);
            btnEntrar.TabIndex = 104;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // textPassword
            // 
            textPassword.Anchor = AnchorStyles.None;
            textPassword.BackColor = Color.FromArgb(242, 230, 230);
            textPassword.BorderColor = Color.Black;
            textPassword.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textPassword.BorderSize = 2;
            textPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textPassword.Location = new Point(356, 380);
            textPassword.Margin = new Padding(3, 4, 3, 4);
            textPassword.Multiline = false;
            textPassword.Name = "textPassword";
            textPassword.Padding = new Padding(8, 9, 8, 9);
            textPassword.PasswordChar = true;
            textPassword.Size = new Size(272, 39);
            textPassword.TabIndex = 106;
            textPassword.Texts = "Contraseña*";
            textPassword.UnderlinedStyle = true;
            textPassword.Enter += textPassword_Enter;
            textPassword.Leave += textUsuario_Leave;
            // 
            // textUsuario
            // 
            textUsuario.Anchor = AnchorStyles.None;
            textUsuario.BackColor = Color.FromArgb(242, 230, 230);
            textUsuario.BorderColor = Color.Black;
            textUsuario.BorderFocusColor = Color.FromArgb(190, 31, 36);
            textUsuario.BorderSize = 2;
            textUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textUsuario.ForeColor = SystemColors.GrayText;
            textUsuario.Location = new Point(359, 309);
            textUsuario.Margin = new Padding(3, 4, 3, 4);
            textUsuario.Multiline = true;
            textUsuario.Name = "textUsuario";
            textUsuario.Padding = new Padding(8, 9, 8, 9);
            textUsuario.PasswordChar = false;
            textUsuario.Size = new Size(267, 39);
            textUsuario.TabIndex = 105;
            textUsuario.Texts = "Usuario*";
            textUsuario.UnderlinedStyle = true;
            textUsuario.Enter += textUsuario_Enter;
            textUsuario.Leave += textUsuario_Leave;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(421, 277);
            label11.Name = "label11";
            label11.Size = new Size(143, 18);
            label11.TabIndex = 107;
            label11.Text = "Nombre de usuario";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(447, 356);
            label1.Name = "label1";
            label1.Size = new Size(90, 18);
            label1.TabIndex = 108;
            label1.Text = "Contraseña";
            // 
            // pbMostrar
            // 
            pbMostrar.Anchor = AnchorStyles.None;
            pbMostrar.Cursor = Cursors.Hand;
            pbMostrar.Image = (Image)resources.GetObject("pbMostrar.Image");
            pbMostrar.Location = new Point(577, 392);
            pbMostrar.Name = "pbMostrar";
            pbMostrar.Size = new Size(47, 23);
            pbMostrar.SizeMode = PictureBoxSizeMode.Zoom;
            pbMostrar.TabIndex = 109;
            pbMostrar.TabStop = false;
            pbMostrar.Click += pbMostrar_Click;
            // 
            // pbOcultar
            // 
            pbOcultar.Anchor = AnchorStyles.None;
            pbOcultar.Cursor = Cursors.Hand;
            pbOcultar.Image = Properties.Resources.ojo_cruzado;
            pbOcultar.Location = new Point(578, 392);
            pbOcultar.Name = "pbOcultar";
            pbOcultar.Size = new Size(46, 23);
            pbOcultar.SizeMode = PictureBoxSizeMode.Zoom;
            pbOcultar.TabIndex = 110;
            pbOcultar.TabStop = false;
            pbOcultar.Click += pbOcultar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 230, 230);
            ClientSize = new Size(984, 561);
            Controls.Add(pbMostrar);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btnEntrar);
            Controls.Add(textPassword);
            Controls.Add(textUsuario);
            Controls.Add(label11);
            Controls.Add(label1);
            Controls.Add(pbOcultar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(500, 500);
            Name = "Login";
            Text = "Login";
            Enter += textUsuario_Enter;
            Leave += textUsuario_Leave;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMostrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOcultar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private Button btnEntrar;
        private SistemaRegistro.Templates.TextBox textPassword;
        private SistemaRegistro.Templates.TextBox textUsuario;
        private Label label11;
        private Label label1;
        private PictureBox pbMostrar;
        private PictureBox pbOcultar;
    }
}