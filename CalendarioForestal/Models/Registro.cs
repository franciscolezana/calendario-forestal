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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRegistro { get; set; }

        [Required]
        public int Dia { get; set; }

        [Required]
        public int Mes { get; set; }

        [Required]
        public int Anio { get; set; }

        [Required]
        public bool Act1 { get; set; }

        [Required]
        public bool Act2 { get; set; }

        [Required]
        public bool Act3 { get; set; }

        [Required]
        public bool Act4 { get; set; }

        [Required]
        public bool Act5 { get; set; }

        [Required]
        public bool Act6 { get; set; }

        [Required]
        public bool Act7 { get; set; }

        [Required]
        public bool Act8 { get; set; }

        [Required]
        public bool Act9 { get; set; }

        [Required]
        public bool Act10 { get; set; }

        [Required]
        public bool Act11 { get; set; }

        [Required]
        public bool Act12 { get; set; }

        [Required]
        public bool Act13 { get; set; }

        [Required]
        public bool Act14 { get; set; }

        [Required]
        public bool Act15 { get; set; }

        [Required]
        public bool Act16 { get; set; }

        [Required]
        public bool Act17 { get; set; }

        [Required]
        public bool Act18 { get; set; }

        [Required]
        public bool Act19 { get; set; }

        [Required]
        public bool Act20 { get; set; }

        [Required]
        public bool Act21 { get; set; }

        [Required]
        public bool Act22 { get; set; }

        [Required]
        public bool Act23 { get; set; }

        [Required]
        public int idFaseLunar { get; set; }

        [Required]
        public int IdEpoca { get; set; }

        [Required]
        public int IdTiempo { get; set; }

        [Required]
        public int IdArbol { get; set; }

        [Required]
        public int IdCambioSol { get; set; }

        [Required]
        public int IdCuatrimestre { get; set; }

        public Arbol? Arbol { get; set; }

        public CambioSol? CambioSol { get; set; }

        public Cuatrimestre? Cuatrimestre { get; set; }

        public Epoca? Epoca { get; set; }

        public FaseLunar? FaseLunar { get; set; }

        public Tiempo? Tiempo { get; set; }

    }
}
