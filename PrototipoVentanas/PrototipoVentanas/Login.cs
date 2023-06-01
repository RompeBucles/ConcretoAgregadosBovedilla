using System.Data;

namespace PrototipoVentanas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnUsuario_Enter(object sender, EventArgs e)
        {
             if (textUsuario.Texts == "Nombre de usuario*")
            {
                textUsuario.Texts = "";
                textUsuario.ForeColor = Color.Black;

            }
        }

        private void textUsuario_Leave(object sender, EventArgs e)
        {
            if (textUsuario.Texts == "")
            {
                textUsuario.Texts = "Nombre de usuario*";
                textUsuario.ForeColor = Color.Black;

            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (textPassword.Texts == "Contraseña*")
            {
                textPassword.Texts = "";
                textPassword.ForeColor = Color.Black;

            }
        }

        private void textPassword_Leave(object sender, EventArgs e)
        {
            if (textPassword.Texts == "")
            {
                textPassword.Texts = "Contraseña*";
                textPassword.ForeColor = Color.Black;

            }
        }
        private void limpiar()
        {
            textUsuario.Texts = "Nombre de usuario*";
            textUsuario.ForeColor = Color.Black;

            textPassword.Texts = "Contraseña*";
            textPassword.ForeColor = Color.Black;

        }

        public void logear(string usuario)

        {
            
                
                
                if (usuario == "Administrador")
                {
                    this.Hide();
                    new Menu(this, 0).Show();
                }
                else if(usuario == "Usuario")
                {
                    this.Hide();
                    new Menu(this, 1).Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrecta");
                }
           
          
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            logear(textUsuario.Texts);
            limpiar();
        }
    }
}