using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Automoviles.Models.DTO
{
    [Table(name: "Paises")]

    public class PaisDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Codigo del pais")]
        public int Id { get; set; }


        [StringLength(30)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Nombre del país")]
        public string Nombre { get; set; }
    }
}
