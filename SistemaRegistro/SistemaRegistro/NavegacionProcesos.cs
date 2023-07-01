using SistemaRegistro.ConexionBD;
using SistemaRegistro.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRegistro
{
    public partial class NavegacionProcesos : Form
    {
        private Conexion ConexionBD = new Conexion();
        public NavegacionProcesos()
        {
            InitializeComponent();
        }

        private void NavegacionProcesos_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT NombreProceso FROM ingresoDatos");
                comando.Connection = ConexionBD.AbrirConexion();
                comando.CommandTimeout = 600;

                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    ComboProcesos.Items.Add(dr["NombreProceso"]);
                }
                dr.Close();
                ConexionBD.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void ComboProcesos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT a.NombreProceso as Proceso, CONCAT(a.producto, ', ', a.tecnologia, ', ', a.otro) AS producto_tecnologia, a.nombreFlujoR as NombreFlujo, a.valorR as ValorR, a.unidad as UnidadR, b.valor as Estado , c.valor as Area, CONCAT(a.latitud, ', ', a.longitud) AS representacionGeografica FROM ingresoDatos AS a JOIN estado AS b ON a.id_estado = b.id JOIN area AS c ON a.id_area = c.id where NombreProceso =@nombreProceso");
                //SqlCommand comando = new SqlCommand("SELECT a.NombreProceso, CONCAT(a.producto, ', ', a.tecnologia, ', ', a.otro) AS producto_tecnologia, a.nombreFlujoR, a.valorR, a.unidad, b.valor, c.valor CONCAT(a.latitud, ', ', a.longitud) AS representacionGeografica FROM ingresoDatos AS a JOIN estado AS b ON a.id_estado = b.id JOIN area AS c ON a.id_area = c.id");
                comando.Parameters.AddWithValue("@nombreProceso", ComboProcesos.Text);
                comando.Connection = ConexionBD.AbrirConexion();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    string nombreProceso = dr["Proceso"].ToString();
                    string prodcutoT = dr["producto_tecnologia"].ToString();
                    string nombreFlujo = dr["NombreFlujo"].ToString();
                    string valor = dr["ValorR"].ToString();
                    string unidadR = dr["UnidadR"].ToString();
                    string valorE = dr["Estado"].ToString();
                    string valorA = dr["Area"].ToString();
                    string representacion = dr["representacionGeografica"].ToString();

                    textNombreP.Texts = nombreProceso;
                    textProductoT.Texts = prodcutoT;
                    textNombreR.Texts = nombreFlujo;
                    textValorR.Texts = valor;
                    textUnidad.Texts = unidadR;
                    textEstado.Texts = valorE;
                    textArea.Texts = valorA;
                    textRepresentacion.Texts = representacion;
                }
                dr.Close();
                ConexionBD.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Intentelo mas tarde"+ ex);
            }
        }
    }
}
