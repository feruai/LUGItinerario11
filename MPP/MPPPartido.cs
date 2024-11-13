using BEntity;
using System.Data.SqlClient;

namespace MPP
{
    public class MPPPartido
    {
        public static BEPartido Map(SqlDataReader reader, BEDeporte deporte)
        {
            BEPartido partido = new BEPartido();
            partido.IdPartido = Convert.ToInt32(reader["ID_PARTIDO"]);
            partido.Deporte.IdDeporte = Convert.ToInt32(reader["ID_DEPORTE"]);  //cambio realizado
            partido.EquipoLocal = reader["EQUIPO_LOCAL"].ToString();
            partido.EquipoVisitante = reader["EQUIPO_VISITANTE"].ToString();
            partido.FechaRegistro = Convert.ToDateTime(reader["FECHA_REGISTRO"]);
            partido.FechaPartido = Convert.ToDateTime(reader["FECHA_PARTIDO"]);
            partido.MarcadorLocal = Convert.ToInt32(reader["MARCADOR_LOCAL"]);
            partido.MarcadorVisitante = Convert.ToInt32(reader["MARCADOR_VISITANTE"]);
            partido.Deporte = deporte;  

            return partido;
        }
    }
}
