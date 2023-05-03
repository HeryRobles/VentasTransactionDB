using AccesoDatos;
using System;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }


        public void CrearProducto(Producto producto)
        {
            try
            {
                string query = "INSERT INTO Productos" +
                    "(Descripcion,PrecioUnitario) " +
                    "VALUES" + 
                    "(@Descripcion,@PrecioUnitario); select scope_identity()";

                using (SqlConnection con = new SqlConnection(Conexion.ConectionString))
                {
                    SqlTransaction transaction; 
                    con.Open();
                    transaction = con.BeginTransaction();

                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Transaction = transaction;

                            cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                            cmd.Parameters.AddWithValue("@PrecioUnitario", producto.PrecioUnitario);

                            //cmd.ExecuteNonQuery();

                            if(!int.TryParse(cmd.ExecuteScalar().ToString(), out int idProducto))
                            {
                                throw new Exception("No se agregó el producto correctamente");
                            }
                            ExistenciaProd existencias = new ExistenciaProd();
                            existencias.AgregarExistenciaEnCero(con, transaction, idProducto);
                        }
                        transaction.Commit();

                    }catch(Exception ex) 
                    { 
                        transaction.Rollback();
                        throw new Exception(ex.Message);
                    }

                }  

            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public void ActualizarProducto(Producto producto)
        {
            try
            {
                string query = "UPDATE Productos SET Descripcion = @Descripcion, PrecioUnitario = @PrecioUnitario WHERE Id = @Id";

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

                            cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                            cmd.Parameters.AddWithValue("@PrecioUnitario", producto.PrecioUnitario);
                            cmd.Parameters.AddWithValue("@Id", producto.Id);

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
                throw new Exception(ex.Message);
            }
        }
        public void EliminarProducto(int id)
        {
            try
            {
                string query = "DELETE FROM Existencias where ProductoId = @Id; DELETE FROM Productos where Id =@Id";

                using (SqlConnection con = new SqlConnection(query))
                {                    
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Transaction = transaction;

                            cmd.Parameters.AddWithValue("@Id", id);

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
                throw new Exception(ex.Message);
            }
        }

        public SqlDataAdapter MostrarProducto()
        {
            try
            {
                string query = "SELECT * FROM Productos";
                SqlDataAdapter productos= new SqlDataAdapter(query, Conexion.ConectionString);

                

                return productos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        
    }

}

//using (SqlConnection con = new SqlConnection(query))
//{
//    con.Open();

//    using (SqlCommand cmd = new SqlCommand(query, con))
//    {
//        cmd.CommandType = CommandType.Text;

//        cmd.Parameters.AddWithValue("@Id", id);

//        using (SqlDataReader reader = cmd.ExecuteReader())
//        {
//            if (reader.HasRows)
//            {
//                while (reader.Read())
//                {
//                    Producto producto = new Producto();

//                    producto.Id = reader.GetInt32(0);
//                    producto.Descripcion = reader.GetString(1);
//                    producto.PrecioUnitario = reader.GetDecimal(2);

//                    return producto;
//                }
//            }
//        }
//    }
//}

