﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CalendarioForestalServer.Models
{
    public class Arbol
    {
        [Required]
        public int IdArbol { get; set; }

        [Required]
        public string? NombreCicloArbol { get; set; }

    }
}
