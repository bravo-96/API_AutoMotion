using Automoviles.Models.DTO;
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
        [Column("id")]
        [Display(Name = "Código Del Vehiculo")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]         /*MODELO*/
        [Column("Modelo")]
        [Display(Name = "Modelo del Vehiculo")]
        [ForeignKey("ModeloId")]
        public int ModeloId { get; set; }
        public Modelo Modelo { get; set; }

        [Display(Name = "Precio")]                     /*PRECIO*/
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("PrecioId")]
        [DataType(DataType.Currency)]
        public string Precio { get; set; }

        [StringLength(4)]                                           /*AÑO*/
        [Column("Año")]
        [Display(Name = "Año")]
        [DataType(DataType.Text)]
        public string Anio { get; set; }



        //////////////////////////////////////////////////////////////////
        // Foreing Keys 

        [Display(Name = "Nombre de la Marca:")]                       /*MARCA FK.*/
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey("MarcaId")]
        [Column("MarcaId")]
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]          /*PAIS FK.*/
        [Column("PaisId")]
        [Display(Name = "Pais de origen del Vehiculo")]
        [ForeignKey("PaisId")]
        public int PaisId { get; set; }
        public Pais Pais { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]          /*COLOR FK.*/
        [Column("ColorId")]
        [Display(Name = "Color del Vehiculo")]
        [ForeignKey("ColorId")]
        public int ColorId { get; set; }
        public Color Color { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]       /*COMBUSTIBLE FK.*/
        [Column("CombustibleId")]
        [Display(Name = "Combustible del Vehiculo")]
        [ForeignKey("CombustibleId")]
        public int CombustibleId { get; set; }
        public Combustible Combustible { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]       /*SEGURO FK.*/
        [Column("SeguroId")]
        [Display(Name = "Seguro del Vehiculo")]
        [ForeignKey("SeguroId")]
        public int SeguroId { get; set; }
        public Seguro Seguro { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]      /*TIPO FK.*/
        [Column("TipoId")]
        [Display(Name = "Tipo de Vehiculo")]
        [ForeignKey("TipoId")]
        public int TipoId { get; set; }
        public Tipo Tipo { get; set; }

        [Display(Name = "Tipo de transmisión:")]                       /*Transmision FK.*/
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey("TrnasmisionId")]
        [Column("TransmisionId")]
        public int TransmisionId { get; set; }
        public Transmision Transmision { get; set; }
    }
}
