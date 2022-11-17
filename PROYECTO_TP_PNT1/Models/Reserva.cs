using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PROYECTO_TP_PNT1.Models
{
    public class Reserva
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idReserva { get; set; }
        [Display(Name = "Fecha de entrada")]
        public DateTime entrada { get; set; }
        [Display(Name = "Fecha de salida")]
        public DateTime salida { get; set; }
        
        [Display(Name = "Confirmado")]
        public bool confirmado { get; set; }
        [Display(Name = "¿Desayuno incluido?")]
        public bool desayuno { get; set; }
        [Display(Name = "N° Personas")]
        public int cantPersonas { get; set; }
        [Display(Name = "Cantidad de Habitaciones")]
        public int CantHabitaciones { get; set; }

        [Display(Name = "idAlojamiento")]
        public int? idAlojamiento { get; set; }
        [Display(Name = "alojamiento")]
        public Alojamiento alojamiento { get; set; }

        [Display(Name = "idCliente")]
        public int? idCliente { get; set; }

        [Display(Name = "cliente")]
        public Cliente cliente { get; set; }

    
        [Display(Name = "Precio Total")]
        public double precioTotal { get; set; }

       
      
       
    }
}
