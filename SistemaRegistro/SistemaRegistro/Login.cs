using System.Data.SqlClient;
using System.Data;
using SistemaRegistro.ConexionBD;
using SistemaRegistro.Controladores;
using Microsoft.VisualBasic.Logging;

namespace SistemaRegistro
{
    public partial class Login : Form
    {
        //Instancia de la BD
        private Conexion ConexionBD = new Conexion();

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
            textUsuario.Texts = "Usuario*";
            textUsuario.ForeColor = Color.Gray;

            textPassword.Texts = "Contraseña*";
            textPassword.ForeColor = Color.Black;

        }

        public void logear(string usuario, string password)

        {
            try
            {
                //manda a llamar el procedimieto almacenado login que consulta si existen el usuario y la contraseña en la base de datos
                SqlCommand comando = new SqlCommand("login");
                comando.Connection = ConexionBD.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Usuario", usuario);
                comando.Parameters.AddWithValue("@Contrasena", password);
                SqlDataAdapter sda = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //Según corresponda su perfil en la B.D accederá a los módulos correspondientes.  
                //comprueba que haya habido una coincidencia en la base de datos
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                   
                    //this.Close();
                    if (dt.Rows[0][1].ToString() == "Administrador")
                    {
                        new Menu(this, dt.Rows[0][0].ToString(), 0, Convert.ToInt32(dt.Rows[0][2].ToString())).Show();

                    }
                    else if (dt.Rows[0][1].ToString() == "Usuario")
                    {
                        new Menu(this, dt.Rows[0][0].ToString(), 1, Convert.ToInt32(dt.Rows[0][2].ToString())).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrecta", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                ConexionBD.CerrarConexion();


            }
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //manda a llamar el procedimiento almacenado logear, para verificar los campos correspondientes
            logear(textUsuario.Texts, Encrypt.GetSHA256(textPassword.Texts.Trim()));
            limpiar();
        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            pbOcultar.BringToFront();
            textPassword.PasswordChar = false;
        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            pbMostrar.BringToFront();
            textPassword.PasswordChar = true;
        }
    }
}