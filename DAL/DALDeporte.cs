using BEntity;
using MPP;
using System.Configuration;
using System.Data.SqlClient;


namespace DAL
{
    public class DALDeporte
    {
        public static List<BEDeporte> ObtenerListaDeportes()
        {
            List<BEDeporte> listaDeportes = new List<BEDeporte>();
            try
            {
                //me conecto a la tabla de deportes
                string connectionString = ConnectionUtils.GetConnectionString();
                SqlConnection connection = new SqlConnection(connectionString);

                using (connection)
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Deporte", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listaDeportes.Add(MPPDeporte.Map(reader)); //agrego el objeto creado a la lista
                            }

                        }

                    }
                    return listaDeportes;    //retorno la lista
                }
            }

            catch (Exception ex)
            {
                throw;
            }

        }

        public static BEDeporte ObtenerDeportesPorId(int idDeporte)
        {           
            try
            {        
                //me conecto a la tabla de deportes
                string connectionString = ConnectionUtils.GetConnectionString();
                SqlConnection connection = new SqlConnection(connectionString);

                using (connection)
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT ID_DEPORTE,DESCRIPCION FROM Deporte WHERE ID_DEPORTE=@ID", connection))
                    {
                        command.Parameters.AddWithValue("@ID", idDeporte);   
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                return MPPDeporte.Map(reader);
                            }
                        }
                    }
                    return null;    //retorno la lista
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
