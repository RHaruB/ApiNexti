namespace ApiNexti.ViewModels
{
    public class EventoVM
    {
        public int ID { get; set; }
        public DateTime FechaEvento { get; set; }
        public string LugarEvento { get; set; }
        public int NumEntradas { get; set; }
        public string DescripcionEvento { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool Eliminado { get; set; }
    }
}
