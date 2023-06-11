using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TallerPedroAlvarez.Models
{
    public class Genero
    {
        public int Id { get; set; }

        public String Nombre { get; set; }

        public Boolean Estado { get; set; }
    }
}