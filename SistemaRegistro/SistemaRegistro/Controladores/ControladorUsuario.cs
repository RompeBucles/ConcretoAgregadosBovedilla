using SistemaRegistro.ConexionBD;
using SistemaRegistro.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistro.Controladores
{

    public class ControladorUsuario
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
        public DataTable SeleccionarDatosUsuario()
        {
            DataTable Tabla = new DataTable();
            SqlCommand comando = new SqlCommand("seleccionarDatosUsuario");
            comando.Connection = ConexionBD.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            ConexionBD.CerrarConexion();
            return Tabla;
        }

        public bool EditarUsuario(modeloUsuarios usuarios,int id)
        {
            SqlCommand comando = new SqlCommand("editarUsuario");
            comando.Connection = ConexionBD.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID", id);
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
            return true;

        }

    }
}
