using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Automoviles.Models.Entities
{
    [Table(name: "Modelos")]
    public class Modelo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Codigo del modelo")]
        public int Id { get; set; }

        [StringLength(60)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Modelo")]
        public string Nombre { get; set; }
    }
}
