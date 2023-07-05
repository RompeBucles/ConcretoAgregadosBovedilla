using SistemaRegistro.ConexionBD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRegistro.Modelo;

namespace SistemaRegistro.Controladores
{

    public class ControladorBitacora
    {
        private Conexion ConexionBD = new Conexion();
        private SqlDataReader LeerFilas; //Permite renderizar los datos de la BD.

        public DataTable SeleccionarDatosBitacora()
        {
            DataTable Tabla = new DataTable();
            SqlCommand comando = new SqlCommand("seleccionarDatosBitacora");
            comando.Connection = ConexionBD.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            ConexionBD.CerrarConexion();
            return Tabla;
        }

        public void InsertBitacora(modeloBitacora modeloBi)
        {
            SqlCommand comando = new SqlCommand("insertBitacora");
            comando.Connection = ConexionBD.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Operacion", modeloBi.operacion);
            comando.Parameters.AddWithValue("@Fecha", modeloBi.fecha);
            comando.Parameters.AddWithValue("@DescripcionEvento", modeloBi.descripcionEvento);
            comando.Parameters.AddWithValue("@Usuario", modeloBi.usuario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            ConexionBD.CerrarConexion();
        }
    }
}
