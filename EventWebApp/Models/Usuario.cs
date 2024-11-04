using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventWebApp.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public ICollection<Comentario> Comentarios { get; set; }
        public ICollection<Participacao> Participacoes { get; set; }
    }

}