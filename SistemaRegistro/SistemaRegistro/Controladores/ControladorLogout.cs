﻿using SistemaRegistro.ConexionBD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistro.Controladores
{
    public class logout
    {
        private Conexion ConexionBD = new Conexion();
        //Método que llama al procedimiento almacenado logout
        public void logoutx(int id)
        {
            try
            {

                SqlCommand comando = new SqlCommand("logout");
                comando.Connection = ConexionBD.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Usuario", id);
                SqlDataAdapter sda = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ConexionBD.CerrarConexion();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
