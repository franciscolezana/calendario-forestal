namespace CalendarioForestal.Models
{
    public class DataItem
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Nombre { get; set; } = "";
        public string Detalles { get; set; } = "";
        public string FaseLunar { get; set; } = "";
        public string Epoca { get; set; } = "";
        public string Tiempo { get; set; } = "";
        public string Arbol { get; set; } = "";
        public string CambioSol { get; set; } = "";
        public string Cuatrimestre { get; set; } = "";
    }

    public class DetailItem
    {
        public string Nombre { get; set; } = "";
        public string Detalle { get; set; } = "";
    }
}
