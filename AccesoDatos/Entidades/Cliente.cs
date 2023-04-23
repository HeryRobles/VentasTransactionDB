using System.Data.SqlClient;
using System.Data;
using System;

namespace AccesoDatos
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    public void AgregarCliente(Cliente cliente)
    {
        
        try
        {
            string query = "INSERT INTO Clientes (Nombre) VALUES (@Nombre)";

            using (SqlConnection con = new SqlConnection(query))
            {
                SqlTransaction transaction = con.BeginTransaction();
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Transaction = transaction;

                    cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    
                    cmd.ExecuteNonQuery();
                }

                con.Close();
            }

        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
