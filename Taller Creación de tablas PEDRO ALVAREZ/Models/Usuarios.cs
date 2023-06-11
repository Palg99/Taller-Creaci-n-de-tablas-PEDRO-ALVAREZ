using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TallerPedroAlvarez.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varcahar(10)")]

        public string NombreUsuario { get; set; }
        [Required]
        [Column(TypeName = "varcahar(10)")]

        public string clave { get; set; }
        [Required]

        public Boolean estado { get; set; }

        public int GeneroId { get; set; }

        public Genero genero { get; set; }

        public List<HistorialAcceso> ListHistorialAcceso { get; set; }
    }
}