using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SistemaRegistro.ConexionBD;
using SistemaRegistro.Modelo;

namespace SistemaRegistro.Controladores
{
    public class ControladorListaUsuarios
    {


        private Conexion ConexionBD = new Conexion();

        public List<ModeloListaUsuarios> obtenerListaUsuarios()
        {
            List<ModeloListaUsuarios> oListaUsuarios = new List<ModeloListaUsuarios>();
            oListaUsuarios.Add(new ModeloListaUsuarios { Id = 0, usuario = "Usuario" });
            try
            {
                SqlCommand comando = new SqlCommand("validaUsuario");
                comando.Connection = ConexionBD.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandTimeout = 600;

                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    oListaUsuarios.Add(new ModeloListaUsuarios
                    {
                        Id = Convert.ToInt32(dr["id"]),
                        usuario = Convert.ToString(dr["usuario"])
                    });
                }
                dr.Close();
                ConexionBD.CerrarConexion();
                return oListaUsuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                return oListaUsuarios;
            }


        }


        //SqlCommand comando = new SqlCommand("consultaBitacora");
        //comando.Connection = ConexionBD.AbrirConexion();
        //    comando.CommandType = CommandType.StoredProcedure;
        //    SqlDataAdapter da = new SqlDataAdapter(comando);
        //DataSet dt = new DataSet();
        //da.Fill(dt);
        //    return dt;
    }
}
