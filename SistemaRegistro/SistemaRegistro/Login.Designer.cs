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
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnEntrar = new Button();
            textPassword = new Sistema_de_sanciones.Templates.TextBox();
            textUsuario = new Sistema_de_sanciones.Templates.TextBox();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(btnEntrar, 0, 7);
            tableLayoutPanel1.Controls.Add(textPassword, 0, 6);
            tableLayoutPanel1.Controls.Add(textUsuario, 0, 4);
            tableLayoutPanel1.Controls.Add(label11, 0, 3);
            tableLayoutPanel1.Controls.Add(pictureBox2, 0, 8);
            tableLayoutPanel1.Controls.Add(label1, 0, 5);
            tableLayoutPanel1.Location = new Point(-2, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 143F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(985, 560);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(190, 31, 36);
            label2.Location = new Point(397, 231);
            label2.Name = "label2";
            label2.Size = new Size(191, 32);
            label2.TabIndex = 16;
            label2.Text = "Iniciar sesión";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(255, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(475, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.None;
            btnEntrar.BackColor = Color.FromArgb(190, 31, 36);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(450, 459);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(84, 33);
            btnEntrar.TabIndex = 19;
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
            textPassword.Location = new Point(356, 396);
            textPassword.Margin = new Padding(3, 4, 3, 4);
            textPassword.Multiline = false;
            textPassword.Name = "textPassword";
            textPassword.Padding = new Padding(8, 9, 8, 9);
            textPassword.PasswordChar = true;
            textPassword.Size = new Size(272, 39);
            textPassword.TabIndex = 23;
            textPassword.Texts = "Contraseña*";
            textPassword.UnderlinedStyle = true;
            textPassword.Enter += textPassword_Enter;
            textPassword.Leave += textPassword_Leave;
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
            textUsuario.Location = new Point(359, 325);
            textUsuario.Margin = new Padding(3, 4, 3, 4);
            textUsuario.Multiline = true;
            textUsuario.Name = "textUsuario";
            textUsuario.Padding = new Padding(8, 9, 8, 9);
            textUsuario.PasswordChar = false;
            textUsuario.Size = new Size(267, 39);
            textUsuario.TabIndex = 21;
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
            label11.Location = new Point(421, 293);
            label11.Name = "label11";
            label11.Size = new Size(143, 18);
            label11.TabIndex = 100;
            label11.Text = "Nombre de usuario";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(3, 518);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(8, 8);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(447, 372);
            label1.Name = "label1";
            label1.Size = new Size(90, 18);
            label1.TabIndex = 101;
            label1.Text = "Contraseña";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 230, 230);
            ClientSize = new Size(984, 561);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(500, 500);
            Name = "Login";
            Text = "Login";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Label label11;
        private Label label1;
    }
}