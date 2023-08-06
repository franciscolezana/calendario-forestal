using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CalendarioForestal.Models
{
    public class Tiempo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idTiempo { get; set; }

        [Required]
        public string? nombreTiempo { get; set; }

        public ICollection<Registro>? Registros { get; set; }

    }
}
