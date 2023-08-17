using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CalendarioForestal.Models
{
    public class Registro
    {
        [Required]
        public int IdRegistro { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public string? NombreFaseLunar { get; set; } = "";

        [Required]
        public string? NombreEpoca { get; set; } = "";

        [Required]
        public string? NombreTiempo { get; set; } = "";

        [Required]
        public string? NombreCicloArbol { get; set; } = "";

        [Required]
        public string? NombreCambioSol { get; set; } = "";

        [Required]
        public string? NombreCuatrimestre { get; set; } = "";

        [Required]
        public int IdActividad { get; set; }

        [Required]
        public string? NombreActividad { get; set; } = "";

        [Required]
        public string? DescripcionActividad { get; set; } = "";
    }
}
