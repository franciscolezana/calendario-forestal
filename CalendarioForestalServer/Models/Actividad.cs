using System.ComponentModel.DataAnnotations;

namespace CalendarioForestalServer.Models
{
    public class Actividad
    {
        [Required]
        public int IdActividad { get; set; }

        [Required]
        public string? NombreActividad { get; set; }

        [Required]
        public string? Descripcion { get; set; }
    }
}
