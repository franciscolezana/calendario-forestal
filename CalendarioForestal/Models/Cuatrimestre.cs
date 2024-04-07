﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace CalendarioForestal.Models
{
    public class Cuatrimestre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idCuatrimestre { get; set; }

        [Required]
        public string? nombreCuatrimestre { get; set; }

        public ICollection<Registro>? Registros { get; set; }
    }
}
