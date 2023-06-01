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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textPassword = new Sistema_de_sanciones.Templates.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textUsuario = new Sistema_de_sanciones.Templates.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textPassword, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textUsuario, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnEntrar, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1084, 661);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textPassword
            // 
            this.textPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPassword.BackColor = System.Drawing.SystemColors.Control;
            this.textPassword.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textPassword.BorderFocusColor = System.Drawing.Color.Black;
            this.textPassword.BorderSize = 2;
            this.textPassword.Location = new System.Drawing.Point(417, 407);
            this.textPassword.Multiline = false;
            this.textPassword.Name = "textPassword";
            this.textPassword.Padding = new System.Windows.Forms.Padding(7);
            this.textPassword.PasswordChar = true;
            this.textPassword.Size = new System.Drawing.Size(250, 30);
            this.textPassword.TabIndex = 22;
            this.textPassword.Texts = "Contraseña*";
            this.textPassword.UnderlinedStyle = true;
            this.textPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.textPassword.Leave += new System.EventHandler(this.textPassword_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 550);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(8, 8);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntrar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEntrar.Location = new System.Drawing.Point(500, 483);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(84, 33);
            this.btnEntrar.TabIndex = 19;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(446, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Iniciar sesión";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(304, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // textUsuario
            // 
            this.textUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.textUsuario.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textUsuario.BorderFocusColor = System.Drawing.Color.Black;
            this.textUsuario.BorderSize = 2;
            this.textUsuario.Location = new System.Drawing.Point(417, 342);
            this.textUsuario.Multiline = false;
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Padding = new System.Windows.Forms.Padding(7);
            this.textUsuario.PasswordChar = false;
            this.textUsuario.Size = new System.Drawing.Size(250, 30);
            this.textUsuario.TabIndex = 20;
            this.textUsuario.Texts = "Nombre de usuario*";
            this.textUsuario.UnderlinedStyle = true;
            this.textUsuario.Enter += new System.EventHandler(this.btnUsuario_Enter);
            this.textUsuario.Leave += new System.EventHandler(this.textUsuario_Leave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Login";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnEntrar;
        private Sistema_de_sanciones.Templates.TextBox textPassword;
        private Sistema_de_sanciones.Templates.TextBox textUsuario;
    }
}