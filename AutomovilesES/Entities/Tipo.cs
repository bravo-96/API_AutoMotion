﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Automoviles.Models.Entities
{
    [Table(name: "Tipos")]

    public class Tipo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Código Del Vehiculo")]
        public int Id { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Tipo de vehiculo")]
        public string Nombre { get; set; }

    }
}
