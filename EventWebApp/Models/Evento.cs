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
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "A data do evento é obrigatória.")]
        public DateTime Data { get; set; }

        public ICollection<Categoria> Eventos { get; set; }
    }

}