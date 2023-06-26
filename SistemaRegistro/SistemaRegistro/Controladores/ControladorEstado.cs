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
    public class controladorEstado
    {
        private Conexion ConexionBD = new Conexion();

        //Este controlador sirve para obtener el listado de los estados de mexico, esto mediante un
        //procedimiento almacenado que hace una consulta a la base de datos.
        public List<modeloEstado> obtenerListaEstado()
        {
            List<modeloEstado> oListaEstado = new List<modeloEstado>();
            oListaEstado.Add(new modeloEstado { id = 0, valor = "Estado*" });
            try
            {
                SqlCommand comando = new SqlCommand("llenarEstado");
                comando.Connection = ConexionBD.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandTimeout = 600;

                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    oListaEstado.Add(new modeloEstado
                    {
                        id = Convert.ToInt32(dr["id"]),
                        valor = Convert.ToString(dr["valor"])
                    });
                }
                dr.Close();
                ConexionBD.CerrarConexion();
                return oListaEstado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                return oListaEstado;
            }


        }
    }
}
