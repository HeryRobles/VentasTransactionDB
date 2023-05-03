using System.Data.SqlClient;
using System.Data;
using System;
using Microsoft.SqlServer.Dac.Extensibility;

namespace AccesoDatos
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public void AgregarCliente(Cliente cliente)
        {

            try
            {
                string query = "INSERT INTO Clientes (Nombre) VALUES (@Nombre)";

                using (SqlConnection con = new SqlConnection(Conexion.ConectionString))
                {
             
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Transaction = transaction;

                            cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);

                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception(ex.Message);
                    }
                    
                    
                } 


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());   
                throw new Exception(ex.Message);
            }
        }

        public void EliminarCliente(int id)
        {
            try
            {
                string query = "DELETE FROM Clientes where Id = @Id";
                using(SqlConnection con = new SqlConnection(Conexion.ConectionString))
                {
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();
                    try
                    {
                        using(SqlCommand cmd = new SqlCommand(query,con))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Transaction = transaction;
                            cmd.Parameters.AddWithValue("@Id", id);
                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }catch(Exception ex) { transaction.Rollback();
                    throw new Exception(ex.ToString());} 
                }
            }catch(Exception ex) { throw new Exception(ex.ToString()); }
        }

        public void ActualizarCliente(Cliente cliente)
        {
            try
            {
                string query = "UPDATE Clientes set Nombre = @Nombre where Id= @Id";
                using (SqlConnection con = new SqlConnection(Conexion.ConectionString)) 
                {
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();
                    try
                    {
                        using(SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Transaction = transaction;
                            cmd.Parameters.AddWithValue("@id", cliente.Id);
                            cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }catch(Exception ex) { transaction.Rollback(); throw new Exception(ex.Message); }
                }
                
            }catch(Exception ex) { throw new Exception(ex.Message); }
        }
        public SqlDataAdapter MostrarClientes()
        {
            
            try
            {
                string query = "select * from Clientes";
                SqlDataAdapter clientes = new SqlDataAdapter(query, Conexion.ConectionString);

                return clientes;


            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message); 
            }
        }

        //public SqlDataAdapter ObtenerListaClientes()
        //{
        //    try
        //    {
        //        string query = "SELECT * FROM Clientes";
        //        SqlDataAdapter clientes = new SqlDataAdapter(query, Conexion.ConectionString);

        //        return clientes;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
    }
 
}
