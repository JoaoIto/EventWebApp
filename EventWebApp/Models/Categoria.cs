using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventWebApp.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }


        [Required(ErrorMessage = "O nome da categoria é obrigatório.")]
        [StringLength(50, ErrorMessage = "O nome da categoria não pode exceder 50 caracteres.")]
        [MinLength(3, ErrorMessage = "O nome da categoria deve ter pelo menos 3 caracteres.")]
        [RegularExpression(@"^[a-zA-Zà-úÀ-Ú\s]*$", ErrorMessage = "O nome da categoria deve conter apenas letras.")]
        public string Nome { get; set; }
        public ICollection<Evento> Eventos { get; set; }
    }

}