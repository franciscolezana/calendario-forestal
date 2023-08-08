using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CalendarioForestal.Models
{
    public class FaseLunar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idFaseLunar { get; set; }

        [Required]
        public string? nombreFaseLunar { get; set; }

        public ICollection<FechasLuna>? FechasLunas { get; set; }

        public ICollection<Registro>? Registros { get; set; }
    }
}
