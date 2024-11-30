using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventWebApp.Models
{
    public class Comentario
    {
        public int ComentarioId { get; set; }

        [Required(ErrorMessage = "O texto do comentário é obrigatório.")]
        [StringLength(500, ErrorMessage = "O texto do comentário não pode exceder 500 caracteres.")]
        [MinLength(5, ErrorMessage = "O texto do comentário deve ter pelo menos 5 caracteres.")]
        public string Texto { get; set; }

        [Required(ErrorMessage = "O ID do evento é obrigatório.")]
        public int EventoId { get; set; }

        public Evento Evento { get; set; }

        [Required(ErrorMessage = "O ID do usuário é obrigatório.")]
        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }
    }

}