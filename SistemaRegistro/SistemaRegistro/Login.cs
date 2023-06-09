namespace SistemaRegistro
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textUsuario_Enter(object sender, EventArgs e)
        {
            if (textUsuario.Texts == "Usuario*")
            {
                textUsuario.Texts = "";
                textUsuario.ForeColor = Color.Black;

            }
        }

        private void textUsuario_Leave(object sender, EventArgs e)
        {
            if (textUsuario.Texts == "")
            {
                textUsuario.Texts = "Usuario*";
                textUsuario.ForeColor = Color.Gray;

            }
        }

        private void textPassword_Enter(object sender, EventArgs e)
        {
            if (textPassword.Texts == "Contrase�a*")
            {
                textPassword.Texts = "";
                textPassword.ForeColor = Color.Black;

            }
        }
        private void textPassword_Leave(object sender, EventArgs e)
        {
            if (textPassword.Texts == "")
            {
                textPassword.Texts = "Contrase�a*";
                textPassword.ForeColor = Color.Black;

            }

        }

        private void limpiar()
        {
            textUsuario.Texts = "Usuario*";
            textUsuario.ForeColor = Color.Gray;

            textPassword.Texts = "Contrase�a*";
            textPassword.ForeColor = Color.Black;

        }

        public void logear(string usuario)

        {

            if (usuario == "Administrador")
            {
                this.Hide();
                new Menu(this, 0).Show();

            }
            else if (usuario == "Usuario")
            {
                this.Hide();
                new Menu(this, 1).Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contrase�a Incorrecta");
            }

        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            logear(textUsuario.Texts);
            limpiar();
        }
    }
}