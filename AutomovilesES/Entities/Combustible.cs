using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Automoviles.Models.Entities
{
    [Table(name: "Combustibles")]

    public class Combustible
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Tipo de combustible")]
        public int Id { get; set; }


        [StringLength(30)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Combustible")]
        public string Nombre { get; set; }
    }
}
