using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace CalendarioForestalServer.Models
{
    public class Cuatrimestre
    {
        [Required]
        public int IdCuatrimestre { get; set; }

        [Required]
        public string? NombreCuatrimestre { get; set; }
    }
}
