using System.ComponentModel.DataAnnotations;

namespace CalendarioForestalServer.Models
{
    public class ListaActividades
    {
        [Required]
        public int IdListaActividades { get; set; }

        [Required]
        public int? idActividad { get; set; }

        [Required]
        public int? IdRegistro { get; set; }
    }
}
