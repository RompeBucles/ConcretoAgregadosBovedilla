namespace PrototipoVentanas
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
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnEntrar = new Button();
            textUsuario = new Sistema_de_sanciones.Templates.TextBox();
            textPassword = new Sistema_de_sanciones.Templates.TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pictureBox2, 0, 6);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(btnEntrar, 0, 5);
            tableLayoutPanel1.Controls.Add(textUsuario, 0, 3);
            tableLayoutPanel1.Controls.Add(textPassword, 0, 4);
            tableLayoutPanel1.Location = new Point(-2, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 153F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(985, 560);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(3, 500);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(8, 8);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(179, 41, 45);
            label2.Location = new Point(397, 232);
            label2.Name = "label2";
            label2.Size = new Size(191, 32);
            label2.TabIndex = 16;
            label2.Text = "Iniciar sesión";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(255, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(475, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.None;
            btnEntrar.BackColor = SystemColors.ScrollBar;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrar.Location = new Point(450, 432);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(84, 33);
            btnEntrar.TabIndex = 19;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // textUsuario
            // 
            textUsuario.Anchor = AnchorStyles.None;
            textUsuario.BackColor = SystemColors.Control;
            textUsuario.BorderColor = SystemColors.ControlDarkDark;
            textUsuario.BorderFocusColor = Color.Black;
            textUsuario.BorderSize = 2;
            textUsuario.Location = new Point(367, 298);
            textUsuario.Multiline = false;
            textUsuario.Name = "textUsuario";
            textUsuario.Padding = new Padding(7);
            textUsuario.PasswordChar = false;
            textUsuario.Size = new Size(250, 30);
            textUsuario.TabIndex = 21;
            textUsuario.Texts = "Nombre de usuario*";
            textUsuario.UnderlinedStyle = true;
            textUsuario.Enter += textUsuario_Enter;
            textUsuario.Leave += textUsuario_Leave;
            // 
            // textPassword
            // 
            textPassword.Anchor = AnchorStyles.None;
            textPassword.BackColor = SystemColors.Control;
            textPassword.BorderColor = SystemColors.ControlDarkDark;
            textPassword.BorderFocusColor = Color.Black;
            textPassword.BorderSize = 2;
            textPassword.Location = new Point(367, 360);
            textPassword.Multiline = false;
            textPassword.Name = "textPassword";
            textPassword.Padding = new Padding(7);
            textPassword.PasswordChar = true;
            textPassword.Size = new Size(250, 30);
            textPassword.TabIndex = 23;
            textPassword.Texts = "Contraseña*";
            textPassword.UnderlinedStyle = true;
            textPassword.Enter += textPassword_Enter;
            textPassword.Leave += textPassword_Leave;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(500, 500);
            Name = "Login";
            Text = "Login";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnEntrar;
        private Sistema_de_sanciones.Templates.TextBox textUsuario;
        private Sistema_de_sanciones.Templates.TextBox textPassword;
    }
}