using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Automoviles.Models.Entities
{
    [Table(name: "Seguros")]

    public class Seguro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Código del seguro")]
        public int Id { get; set; }


        [StringLength(60)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Nombre del seguro:")]
        public string Nombre { get; set; }
    }
}
