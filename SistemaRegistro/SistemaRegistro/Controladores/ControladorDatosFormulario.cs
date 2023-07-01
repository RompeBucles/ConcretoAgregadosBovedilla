using SistemaRegistro.ConexionBD;
using SistemaRegistro.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRegistro.Controladores
{
    public class ControladorDatosFormulario
    {
        private Conexion ConexionBD = new Conexion(); //Mando a llamar a la conexion a la base de datos.
        private SqlDataReader LeerFilas; //Permite renderizar los datos de la BD.
       
        public void InsertarDatosFormulario(modeloIngresoDatos datos)
        {

            SqlCommand comando = new SqlCommand("insertarDatosFormulario");
            comando.Connection = ConexionBD.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Producto", datos.producto);
            comando.Parameters.AddWithValue("@Tecnologia", datos.tecnologia);
            comando.Parameters.AddWithValue("@Otro", datos.otro);
            comando.Parameters.AddWithValue("@NombreProceso", datos.nombreProceso);
            comando.Parameters.AddWithValue("@TipoProceso", datos.tipoProceso);
            comando.Parameters.AddWithValue("@Autor", datos.autor);
            comando.Parameters.AddWithValue("@Correo", datos.correo);
            comando.Parameters.AddWithValue("@NombreFlujoR", datos.nombreFlujoR);
            comando.Parameters.AddWithValue("@Unidad", datos.unidad);
            comando.Parameters.AddWithValue("@ValorR", datos.valorR);
            comando.Parameters.AddWithValue("@Objetivo", datos.objetivo);
            comando.Parameters.AddWithValue("@LimiteSistema", datos.limitesSistema);
            comando.Parameters.AddWithValue("@Imagen", datos.imagen);
            comando.Parameters.AddWithValue("@TipoTecnologia", datos.tipoTecnologia);
            comando.Parameters.AddWithValue("@CondicionesOperacion", datos.condicionesOperacion);
            comando.Parameters.AddWithValue("@FechaReferencia", datos.fechaReferencia);
            comando.Parameters.AddWithValue("@DatosValidos", datos.datosValidos);
            comando.Parameters.AddWithValue("@Descripcion", datos.descripcion);
            comando.Parameters.AddWithValue("@Estado", datos.id_estado);
            comando.Parameters.AddWithValue("@Area", datos.id_area);
            comando.Parameters.AddWithValue("@Latitud", datos.latitud);
            comando.Parameters.AddWithValue("@Longitud ", datos.longitud);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            ConexionBD.CerrarConexion();
        }

        public DataTable SeleccionarDatosFormulario()
        {
            DataTable Tabla = new DataTable();
            SqlCommand comando = new SqlCommand("seleccionarDatosFormulario");
            comando.Connection = ConexionBD.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            ConexionBD.CerrarConexion();
            return Tabla;
        }

        public void aCSV(DataGridView dg, string ar)
        {
            try
            {
                // Prueba que el DataGridView no esté vacío
                if (dg.RowCount > 0)
                {
                    using (StreamWriter swOut = new StreamWriter(ar, false, Encoding.UTF8))
                    {
                        // Obtener las columnas visibles y no de botones
                        var visibleColumns = dg.Columns.Cast<DataGridViewColumn>()
                            .Where(column => column.Visible && column.GetType() != typeof(DataGridViewButtonColumn) && column.GetType() != typeof(DataGridViewCheckBoxColumn))
                            .ToList();

                        // Obtener los índices de las columnas visibles
                        var columnIndices = visibleColumns.Select(column => column.Index).ToList();

                        // Obtener los nombres de las columnas visibles
                        var columnHeaders = visibleColumns.Select(column => column.HeaderText).ToList();

                        // Escribir el encabezado de las columnas visibles
                        swOut.WriteLine(string.Join(",", columnHeaders));

                        // Escribir los datos de las filas
                        foreach (DataGridViewRow row in dg.Rows)
                        {
                            var cellValues = new List<string>();

                            foreach (int columnIndex in columnIndices)
                            {
                                object value = row.Cells[columnIndex].Value;
                                string stringValue = value != null ? value.ToString() : string.Empty;

                                // Comprobar si el valor contiene comas y encerrarlo entre comillas dobles
                                if (stringValue.Contains(","))
                                {
                                    stringValue = "\"" + stringValue + "\"";
                                }

                                cellValues.Add(stringValue);
                            }

                            swOut.WriteLine(string.Join(",", cellValues));
                        }
                    }
                    MessageBox.Show("Archivo CSV exportado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"intentalo de nuevo o mas tarde");
            }
        }
        public bool EditarDatosFormulario(modeloIngresoDatos datos, int id)
        {
            SqlCommand comando = new SqlCommand("editarDatosFormulario");
            comando.Connection = ConexionBD.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID", id);
            comando.Parameters.AddWithValue("@NombreProceso", datos.nombreProceso);
            comando.Parameters.AddWithValue("@TipoProceso", datos.tipoProceso);
            comando.Parameters.AddWithValue("@Autor", datos.autor);
            comando.Parameters.AddWithValue("@Correo", datos.correo);
            comando.Parameters.AddWithValue("@NombreFlujoR", datos.nombreFlujoR);
            comando.Parameters.AddWithValue("@Unidad", datos.unidad);
            comando.Parameters.AddWithValue("@ValorR", datos.valorR);
            comando.Parameters.AddWithValue("@Objetivo", datos.objetivo);
            comando.Parameters.AddWithValue("@LimiteSistema", datos.limitesSistema);
            comando.Parameters.AddWithValue("@Imagen", datos.imagen);
            comando.Parameters.AddWithValue("@TipoTecnologia", datos.tipoTecnologia);
            comando.Parameters.AddWithValue("@CondicionesOperacion", datos.condicionesOperacion);
            comando.Parameters.AddWithValue("@FechaReferencia", datos.fechaReferencia);
            comando.Parameters.AddWithValue("@DatosValidos", datos.datosValidos);
            comando.Parameters.AddWithValue("@Descripcion", datos.descripcion);
            comando.Parameters.AddWithValue("@Estado", datos.id_estado);
            comando.Parameters.AddWithValue("@Area", datos.id_area);
            comando.Parameters.AddWithValue("@Latitud", datos.latitud);
            comando.Parameters.AddWithValue("@Longitud", datos.longitud);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            ConexionBD.CerrarConexion();
            return true;

        }
        public void EliminarDatosFormulario(int id)
        {

            SqlCommand comando = new SqlCommand("EliminarRegistroYEntradas");
            comando.Connection = ConexionBD.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            ConexionBD.CerrarConexion();

        }
    }
}
