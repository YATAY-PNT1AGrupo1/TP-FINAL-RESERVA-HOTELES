using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PROYECTO_TP_PNT1.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idCliente { get; set; }


        [DataType(DataType.Text)]
        [Display(Name = "Nombre/s")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string nombre { get; set; }


        [DataType(DataType.Text)]
        [Display(Name = "Apellido/s")]
        [Required(ErrorMessage = "El apellido es obligatorio.")]
        public string apellido { get; set; }

        [RegularExpression("^(\\d{2}\\.{1}\\d{3}\\.\\d{3})|(\\d{2}\\s{1}\\d{3}\\s\\d{3})$", ErrorMessage = "Coloque el formato correcto.")]
        
        [StringLength(10)]
        [Display(Name = "DNI")]
        [Required(ErrorMessage = "El DNI es obligatorio")]
        public string dni { get; set; }

       
        [Range(18, 100, ErrorMessage = "Debes ser mayor de edad.")]
        [Display(Name = "Edad")]
        [Required]
        public int edad { get; set; }
       
      

}
}
