using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Automoviles.Models.DTO
{
    [Table(name: "Colores")]

    public class ColorDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Código del color")]
        public int Id { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Nombre del color")]
        public string Nombre { get; set; }
    }
}
