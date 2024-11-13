namespace BEntity
{
    public class BEPartido
    {
        #region ATRIBUTOS
        private int idPartido;
        private BEDeporte deporte; // cambio la FK por un objeto
        private string equipoLocal;
        private string equipoVisitante;
        private DateTime fechaRegistro;
        private DateTime fechaPartido;
        private int marcadorLocal;
        private int marcadorVisitante;
       
        #endregion

        #region PROPIEDADES
        public int IdPartido { get => idPartido; set => idPartido = value; }
        public BEDeporte Deporte { get => deporte; set => deporte = value; }
        public string EquipoLocal { get => equipoLocal; set => equipoLocal = value; }
        public string EquipoVisitante { get => equipoVisitante; set => equipoVisitante = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public DateTime FechaPartido { get => fechaPartido; set => fechaPartido = value; }
        public int MarcadorLocal { get => marcadorLocal; set => marcadorLocal = value; }
        public int MarcadorVisitante { get => marcadorVisitante; set => marcadorVisitante = value; }

        public string DescripcionDeporte { get => Deporte.Descripcion; } //se agrega esta propiedad para obtener la descripción del deporte
        #endregion

        #region CONSTRUCTORES
        public BEPartido() // Constructor sin parámetros
        {
            idPartido = 0; // Valor por defecto
            deporte = new BEDeporte(); // Valor por defecto
            equipoLocal = string.Empty; // Cadena vacía
            equipoVisitante = string.Empty; // Cadena vacía
            fechaRegistro = DateTime.MinValue.Date; // Fecha mínima
            fechaPartido = DateTime.MinValue.Date; // Fecha mínima
            marcadorLocal = 0; // Valor por defecto
            marcadorVisitante = 0; // Valor por defecto
        }
        #endregion
    }
}
