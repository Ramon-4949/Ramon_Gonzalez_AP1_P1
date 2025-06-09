using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Ramon_Gonzalez_AP1_P1.Models
{
    public class Aportes
    {
        [Key]
        public int AportesId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public String Persona { get; set; } = String.Empty;

        [Range(0.01, double.MaxValue, ErrorMessage = "El Monto debe ser mayor a 0")]
        public decimal Monto { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateOnly Fecha { get; set; } = DateOnly.FromDateTime(DateTime.Today);


    }
}


//Listo para Iniciar