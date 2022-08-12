using Automoviles.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Automoviles.Models.Entities
{
    [Table(name: "Vehiculos")]
    public class Vehiculo
    {
        [Key]                                                           /*ID*/
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Código Del Vehiculo")]
        public int Id { get; set; }

        [Display(Name = "Precio")]                                   /*PRECIO*/
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Currency)]
        public decimal Precio { get; set; }

        [StringLength(4)]                                           /*AÑO*/
        [Display(Name = "Año")]
        public string Anio { get; set; }



        //////////////////////////////////////////////////////////////////
        // Foreing Keys 

        [Required(ErrorMessage = "El campo {0} es requerido")]         /*MODELO FK*/
        [Display(Name = "Modelo del Vehiculo")]
        public int ModeloId { get; set; }
        public Modelo Modelo { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]          /*PAIS FK.*/
        [Display(Name = "Pais de origen del Vehiculo")]
        public int PaisId { get; set; }
        public Pais Pais { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]          /*COLOR FK.*/
        [Display(Name = "Color del Vehiculo")]
        public int ColorId { get; set; }
        public Color Color { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]       /*COMBUSTIBLE FK.*/
        [Display(Name = "Combustible del Vehiculo")]
        public int CombustibleId { get; set; }
        public Combustible Combustible { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]       /*SEGURO FK.*/
        [Display(Name = "Seguro del Vehiculo")]
        public int SeguroId { get; set; }
        public Seguro Seguro { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]      /*TIPO FK.*/
        [Display(Name = "Tipo de Vehiculo")]
        public int TipoId { get; set; }
        public Tipo Tipo { get; set; }

        [Display(Name = "Nombre de la Marca:")]                       /*MARCA FK.*/
        [Column("MarcaId")]
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }

        [Display(Name = "Tipo de transmisión:")]                       /*Transmision FK.*/
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int TransmisionId { get; set; }
        public Transmision Transmision { get; set; }
    }
}
