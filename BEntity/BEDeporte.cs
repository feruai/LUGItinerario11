using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEntity
{
    public class BEDeporte
    {
        #region ATRIBUTOS
        private int idDeporte;
        private string descripcion;
        #endregion

        #region PROPIEDADES
        public int IdDeporte { get => idDeporte; set => idDeporte = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        #endregion

    }
}
