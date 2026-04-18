using Microsoft.EntityFrameworkCore;

namespace Micro_dev_backend__2_semestre.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
