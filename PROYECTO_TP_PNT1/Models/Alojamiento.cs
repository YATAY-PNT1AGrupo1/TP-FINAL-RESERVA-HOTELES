using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PROYECTO_TP_PNT1.Models
{
    public class Alojamiento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        
        public int idAlojamiento { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string nombre { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Direccion")]
        [Required(ErrorMessage = "La direccion es obligatoria.")]
        public string direccion{ get; set; }

        [Display(Name = "Habitaciones disponibles")]
        [Required(ErrorMessage = "La cantidad de habitaciones es obligatoria.")]
        public int cantHabitacionesDisponibles { get; set; }

        [Range(1, 1000, ErrorMessage = "La cantidad no puede ser negativa.")]
        [EnumDataType(typeof(TipoDeAlojamiento))]
        [Display(Name = "Alojamiento de tipo")]
        public TipoDeAlojamiento tipo { get; set; }

        [Range(1, 100000, ErrorMessage = "El precio no puede ser negativo.")]
        [Display(Name = "Precio")]
        [Required(ErrorMessage = "El precio es obligatorio.")]
        public double precio { get; set; }

    }
}
