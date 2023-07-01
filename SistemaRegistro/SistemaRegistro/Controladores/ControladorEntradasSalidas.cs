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
    public class controladorEntradasSalidas
    {
        private Conexion ConexionBD = new Conexion();
        private SqlDataReader LeerFilas; //Permite renderizar los datos de la BD.
        public void InsertarEntradasSalidas(modeloEntrdasSalidas entrdasSalidas)
        {

            SqlCommand comando = new SqlCommand("insertarEntradasSalidas");
            comando.Connection = ConexionBD.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Producto", entrdasSalidas.id_producto);
            comando.Parameters.AddWithValue("@NombreFlujo", entrdasSalidas.nombreFlujo);
            comando.Parameters.AddWithValue("@TipoFlujo", entrdasSalidas.tipoFlujo);
            comando.Parameters.AddWithValue("@Recursos", entrdasSalidas.recursos);
            comando.Parameters.AddWithValue("@Emisiones", entrdasSalidas.emisiones);
            comando.Parameters.AddWithValue("@Valor", entrdasSalidas.valor);
            comando.Parameters.AddWithValue("@Unidad", entrdasSalidas.unidad);
            comando.Parameters.AddWithValue("@TratamientoDato", entrdasSalidas.tratamientoDato);
            comando.Parameters.AddWithValue("@Adquisicion", entrdasSalidas.adquisicionDato);
            comando.Parameters.AddWithValue("@Citas", entrdasSalidas.citaReferencia);
            comando.Parameters.AddWithValue("@Comentario", entrdasSalidas.comentario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            ConexionBD.CerrarConexion();
        }
        public List<modeloListaProducto> obtenerListaProducto()
        {
            List<modeloListaProducto> oListaProducto = new List<modeloListaProducto>();
            oListaProducto.Add(new modeloListaProducto { id = 0, producto = "Producto*" });
            try
            {
                SqlCommand comando = new SqlCommand("cargarComboProducto");
                comando.Connection = ConexionBD.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandTimeout = 600;

                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    oListaProducto.Add(new modeloListaProducto
                    {
                        id = Convert.ToInt32(dr["id"]),
                        producto = Convert.ToString(dr["producto"])
                    });
                }
                dr.Close();
                ConexionBD.CerrarConexion();
                return oListaProducto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                return oListaProducto;
            }
        }

        public DataTable SeleccionarEntrasSalidas()
        {
            DataTable Tabla = new DataTable();
            SqlCommand comando = new SqlCommand("seleccionarEntradasSalidas");
            comando.Connection = ConexionBD.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            ConexionBD.CerrarConexion();
            return Tabla;
        }

        public void EliminarEntradasSalidas(int id)
        {
            SqlCommand comando = new SqlCommand("eliminarEntradasSalidas");
            comando.Connection = ConexionBD.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            ConexionBD.CerrarConexion();
        }

        public bool EditarEntradasSalidas(modeloEntrdasSalidas entrdasSalidas, int id)
        {
            SqlCommand comando = new SqlCommand("editarEntradasSalidas");
            comando.Connection = ConexionBD.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID", id);
            comando.Parameters.AddWithValue("@NombreFlujo", entrdasSalidas.nombreFlujo);
            comando.Parameters.AddWithValue("@TipoFlujo", entrdasSalidas.tipoFlujo);
            comando.Parameters.AddWithValue("@Recursos", entrdasSalidas.recursos);
            comando.Parameters.AddWithValue("@Emisiones", entrdasSalidas.emisiones);
            comando.Parameters.AddWithValue("@Valor", entrdasSalidas.valor);
            comando.Parameters.AddWithValue("@Unidad", entrdasSalidas.unidad);
            comando.Parameters.AddWithValue("@TratamientoDato", entrdasSalidas.tratamientoDato);
            comando.Parameters.AddWithValue("@Adquisicion", entrdasSalidas.adquisicionDato);
            comando.Parameters.AddWithValue("@Citas", entrdasSalidas.citaReferencia);
            comando.Parameters.AddWithValue("@Comentario", entrdasSalidas.comentario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            ConexionBD.CerrarConexion();
            return true;

        }

    }

}
