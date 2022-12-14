using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Automoviles.Models.Entities
{
    [Table(name: "Marcas")]

    public class Marca
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Codigo de la marca")]
        public int Id { get; set; }


        [StringLength(60)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Marca")]
        public string Nombre { get; set; }
    }
}
