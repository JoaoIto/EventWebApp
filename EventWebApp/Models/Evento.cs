using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventWebApp.Models
{
    public class Evento
    {
        public int EventoId { get; set; }

        [Required(ErrorMessage = "O nome do evento é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome do evento não pode exceder 100 caracteres.")]
        [MinLength(5, ErrorMessage = "O nome do evento deve ter pelo menos 5 caracteres.")]
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "A data do evento é obrigatória.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [CustomValidation(typeof(Evento), nameof(ValidarDataFutura), ErrorMessage = "A data do evento deve ser no futuro.")]
        public DateTime Data { get; set; }

        [Range(1, 1000, ErrorMessage = "A capacidade máxima deve ser entre 1 e 1000.")]
        public int CapacidadeMaxima { get; set; }

        public ICollection<Categoria> Eventos { get; set; }

        public static ValidationResult ValidarDataFutura(DateTime data, ValidationContext context)
        {
            return data >= DateTime.Today
                ? ValidationResult.Success
                : new ValidationResult("A data do evento deve ser no futuro.");
        }
    }

}