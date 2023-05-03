using System;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class ExistenciaProd
    {
        public int Id { get; set; }
        public decimal Existencia { get; set; }
        public int ProductoId { get; set; }

        public void ActualizarExistencia(SqlConnection con, SqlTransaction transaction, VentaDetalle concepto)
        {
            string query = "Update Existencias set Existencia = Existencia-@Cantidad where ProductoId = @ProductoId";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Transaction = transaction;

                cmd.Parameters.AddWithValue("@ProductoId", concepto.ProductoId);
                cmd.Parameters.AddWithValue("@Cantidad", concepto.Cantidad);
                cmd.ExecuteNonQuery();
            }

        }
        public void AgregarExistenciaEnCero(SqlConnection con, SqlTransaction transaction, int productoId)
        {
            string query = "Insert into Existencias (Existencia, ProductoId) + VALUES (0, @ProductoId)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.CommandType = CommandType.Text; cmd.Transaction = transaction;

                cmd.Parameters.AddWithValue("@ProductoId", productoId);
            }

        }


        public SqlDataAdapter ObtenerExistenciaProd()
        {
            try
            {
                string query = "select * from Existencias";
                SqlDataAdapter existencias = new SqlDataAdapter(query, Conexion.ConectionString);

                return existencias;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }

}
