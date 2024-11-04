using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventWebApp.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public ICollection<Evento> Eventos { get; set; }
    }

}