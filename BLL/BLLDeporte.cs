using BEntity;
using DAL;

namespace BLL
{
    public class BLLDeporte
    {
        public static List<BEDeporte> ObtenerListaDeportes()
        {
            try
            {
                //llamo al método de la DAL para que me traiga el listado de la base de datos
                return DALDeporte.ObtenerListaDeportes();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
