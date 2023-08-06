using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CalendarioForestal.Models
{
    public class CambioSol
    {
        public CambioSol(ICollection<Registro> registros)
        {
            Registros = registros;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idCambioSol { get; set; }

        [Required]
        public string? nombreCambio { get; set; }

        public ICollection<Registro> Registros { get; set; }
    }
}
