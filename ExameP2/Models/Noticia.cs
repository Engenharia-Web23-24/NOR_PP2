using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ExameP2.Models
{
    public class Noticia
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Texto { get; set; }

        [DisplayName("Comentários")]
       
        public virtual List<Comentario>? Comentarios { get; set; }
    }
}
