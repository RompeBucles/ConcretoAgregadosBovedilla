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

        public void InsertarDatosFormulario(modeloEntrdasSalidas entrdasSalidas)
        {

            SqlCommand comando = new SqlCommand("insertarDatosFormulario");
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
                return oListaProducto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                return oListaProducto;
            }
        }

    }

}
