using SistemaRegistro.ConexionBD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SistemaRegistro.Modelo;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistro.Controladores
{
    public class controladorArea
    {
        private Conexion ConexionBD = new Conexion();

        //Este controaldor sirve para poder rellenar las listas de areas, esto mediante el uso de un procedimiento almacenado
        //que hace una consulta a la base de datos.
        public List<modeloArea> obtenerListaArea(int entidad)
        {
            List<modeloArea> oListaArea = new List<modeloArea>();
            oListaArea.Add(new modeloArea { id = 0, valor = "Area*" });
            try
            {
                SqlCommand comando = new SqlCommand("llenarArea");
                comando.Connection = ConexionBD.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandTimeout = 600;
                comando.Parameters.AddWithValue("@id", entidad);

                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    oListaArea.Add(new modeloArea
                    {
                        id = Convert.ToInt32(dr["id"]),
                        valor = Convert.ToString(dr["valor"])
                    });
                }
                dr.Close();
                ConexionBD.CerrarConexion();

                return oListaArea;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                return oListaArea;
            }


        }
    }
}
