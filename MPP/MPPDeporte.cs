using BEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class MPPDeporte
    {
        public static BEDeporte Map(SqlDataReader reader)
        {
            BEDeporte deporte = new BEDeporte(); //creo un objeto BEDeporte
            deporte.IdDeporte = Convert.ToInt32(reader["ID_DEPORTE"]); //le asigno los datos de la tabla
            deporte.Descripcion = reader["DESCRIPCION"].ToString();
            return deporte;
        }
    }
}
