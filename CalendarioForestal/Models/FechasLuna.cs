using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CalendarioForestal.Models
{
    public class FechasLuna
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idFechasLuna { get; set; }

        [Required]
        public int idMes { get; set; }

        [Required]
        public DateTime fecha { get; set; }

        public int? anio { get; set; }

        [Required]
        public int idFaseLunar { get; set; }

        public FaseLunar? FaseLunar { get; set; }
    }
}
