using SistemaRegistro.ConexionBD;
using SistemaRegistro.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistro.Controladores
{
    public class ControladorDatosFormulario
    {
        private Conexion ConexionBD = new Conexion(); //Mando a llamar a la conexion a la base de datos.
        private SqlDataReader LeerFilas; //Permite renderizar los datos de la BD.

        public void InsertarUsuario(modeloUsuarios usuarios)
        {

            SqlCommand comando = new SqlCommand("insertarUsuario");
            comando.Connection = ConexionBD.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", usuarios.nombre);
            comando.Parameters.AddWithValue("@ApellidoP", usuarios.apellidoP);
            comando.Parameters.AddWithValue("@ApellidoM", usuarios.apellidoM);
            comando.Parameters.AddWithValue("@Perfil", usuarios.perfil);
            comando.Parameters.AddWithValue("@CorreoElectronico", usuarios.correo);
            comando.Parameters.AddWithValue("@Telefono", usuarios.telefono);
            comando.Parameters.AddWithValue("@Usuario", usuarios.usuario);
            comando.Parameters.AddWithValue("@Contraseña", usuarios.contrasena);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            ConexionBD.CerrarConexion();
        }
    }
}
