using Microsoft.EntityFrameworkCore;

namespace TallerPedroAlvarez.Models
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> option) : base(option)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
