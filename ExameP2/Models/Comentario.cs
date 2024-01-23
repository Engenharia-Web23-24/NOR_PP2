using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExameP2.Models
{
    public class Comentario
    {
        public int Id { get; set; }

        [Required]
        [ForeignKey("NoticiaId")]
        public int? Noticiaid { get; set; }
        public Noticia Noticia { get; set; }
        public string? Username { get; set; }
        [Required]
        public string Texto { get; set; }
        public DateTime Data { get; set; }
    }
}