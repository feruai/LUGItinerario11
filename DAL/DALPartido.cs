using BEntity;
using MPP;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPartido
    {
        private DALDeporte dalDeporte = new DALDeporte();

        public static void EliminarPartido(int idPartido)
        {
            try
            {
                string connectionString = ConnectionUtils.GetConnectionString();
                SqlConnection connection = new SqlConnection(connectionString);

                using (connection)
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM Partido WHERE ID_PARTIDO=@ID_PARTIDO", connection))
                    {
                        command.Parameters.AddWithValue("@ID_PARTIDO", idPartido);
                        int filasAfectadas = command.ExecuteNonQuery();

                        if (filasAfectadas == 0)
                        {
                            throw new Exception("No se encontró ningún partido con el ID proporcionado");
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                {
                    throw;
                }
            }
        }

        public static void GuardarPartido(BEPartido partido)
        {
            //usaré un INSERT para guardar el partido 
            try
            {
                string connectionString = ConnectionUtils.GetConnectionString();
                SqlConnection connection = new SqlConnection(connectionString);

                using (connection)
                {
                    connection.Open();
                    //insertaré todos los campos menos el ID_PARTIDO, ya que es autoincrementable en la base de datos
                    using (SqlCommand command = new SqlCommand("INSERT INTO Partido (ID_DEPORTE,EQUIPO_LOCAL,EQUIPO_VISITANTE" +
                        ",FECHA_REGISTRO,FECHA_PARTIDO,MARCADOR_LOCAL,MARCADOR_VISITANTE) VALUES (@ID_DEPORTE,@EQUIPO_LOCAL,@EQUIPO_VISITANTE" +
                            ",@FECHA_REGISTRO,@FECHA_PARTIDO,@MARCADOR_LOCAL,@MARCADOR_VISITANTE)", connection))
                    {

                        command.Parameters.AddWithValue("@ID_DEPORTE", partido.Deporte.IdDeporte); //cambio realizado
                        command.Parameters.AddWithValue("@EQUIPO_LOCAL", partido.EquipoLocal);
                        command.Parameters.AddWithValue("@EQUIPO_VISITANTE", partido.EquipoVisitante);
                        command.Parameters.AddWithValue("@FECHA_REGISTRO", partido.FechaRegistro);
                        command.Parameters.AddWithValue("@FECHA_PARTIDO", partido.FechaPartido);
                        command.Parameters.AddWithValue("@MARCADOR_LOCAL", partido.MarcadorLocal);
                        command.Parameters.AddWithValue("@MARCADOR_VISITANTE", partido.MarcadorVisitante);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public static void ModificarResultado(int idPart, int marcLocal, int marcVisitante)
        {
            try
            {
                string connectionString = ConnectionUtils.GetConnectionString();
                SqlConnection connection = new SqlConnection(connectionString);

                using (connection)
                {
                    using (connection)
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("UPDATE Partido SET MARCADOR_LOCAL=@MARCADOR_LOCAL,MARCADOR_VISITANTE=@MARCADOR_VISITANTE " +
                            "WHERE ID_PARTIDO=@ID_PARTIDO", connection))
                        {
                            command.Parameters.AddWithValue("@ID_PARTIDO", idPart);
                            command.Parameters.AddWithValue("@MARCADOR_LOCAL", marcLocal);
                            command.Parameters.AddWithValue("@MARCADOR_VISITANTE", marcVisitante);
                            int filasAfectadas = command.ExecuteNonQuery();

                            if (filasAfectadas == 0)
                            {
                                throw new Exception("No se encontró ningún partido con ese ID");
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<BEPartido> ObtenerListaPartidos()
        {
            List<BEPartido> listaPartidos = new List<BEPartido>();

            //usaré un SELECT para obtener la lista de partidos, mediante un datareader
            try
            {
                string connectionString = ConnectionUtils.GetConnectionString();
                SqlConnection connection = new SqlConnection(connectionString);

                using (connection)
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT ID_PARTIDO,ID_DEPORTE,EQUIPO_LOCAL,EQUIPO_VISITANTE,FECHA_REGISTRO,FECHA_PARTIDO,MARCADOR_LOCAL,MARCADOR_VISITANTE FROM Partido", connection))
                    {
                        using SqlDataReader reader = command.ExecuteReader();
                        {
                            while (reader.Read())
                            {
                                BEDeporte deporte = DALDeporte.ObtenerDeportesPorId(Convert.ToInt32(reader["ID_DEPORTE"].ToString()));
                                BEPartido partido = MPPPartido.Map(reader, deporte);
                                listaPartidos.Add(partido); //agrego el objeto obtenido de la iteracion del ciclo a la lista
                            }
                        }
                    }
                }
                return listaPartidos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool PartidoAptoParaModificar(int idPart)
        {
            bool resultado = false;
            //este metodo valida que si se quieren modificar los marcadores de un partido, la fecha debe ser 
            //igual a la de HOY
            try
            {
                string connectionString = ConnectionUtils.GetConnectionString();
                SqlConnection connection = new SqlConnection(connectionString);

                using (connection)
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT ID_PARTIDO,ID_DEPORTE,EQUIPO_LOCAL,EQUIPO_VISITANTE,FECHA_REGISTRO,FECHA_PARTIDO,MARCADOR_LOCAL,MARCADOR_VISITANTE FROM Partido", connection))
                    {
                        using SqlDataReader reader = command.ExecuteReader();
                        {
                            while (reader.Read())
                            {
                                BEDeporte deporte = DALDeporte.ObtenerDeportesPorId(Convert.ToInt32(reader["ID_DEPORTE"].ToString()));
                                BEPartido partido = MPPPartido.Map(reader, deporte);
                               
                                if (partido.IdPartido==idPart && partido.FechaPartido == DateTime.Now.Date)
                                {
                                    resultado = true;
                                }
                               
                            }
                        }
                    }
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}