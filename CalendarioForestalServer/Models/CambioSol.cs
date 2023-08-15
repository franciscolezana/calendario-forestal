using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CalendarioForestalServer.Models
{
    public class CambioSol
    {
        [Required]
        public int IdCambioSol { get; set; }

        [Required]
        public string? NombreCambio { get; set; }
    }
}
