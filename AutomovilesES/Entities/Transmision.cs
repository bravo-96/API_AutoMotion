using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Automoviles.Models.Entities
{
    [Table(name: "Transmisiones")]

    public class Transmision
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Transmision Del Vehiculo")]
        public int Id { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Tipo de transmision")]
        public string Nombre { get; set; }
    }
}
