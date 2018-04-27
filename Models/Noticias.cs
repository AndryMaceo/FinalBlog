using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalBlog.Models
{
    public class Noticias
    {
        [Key]
        public int NoticiaId { get; set; }
        [Required(ErrorMessage = "El titulo de la noticia es obligatorio"), MaxLength(250, ErrorMessage = "El titulo de la noticia solo puede tener 250 caracteres")]
        public string NoticiaTitulo { get; set; }
        [Required(ErrorMessage = "La descripción de la noticia es obligatoria")]
        public string NoticiaDescripcion { get; set; }
        public string UsuarioCreador { get; set; }
    }
}