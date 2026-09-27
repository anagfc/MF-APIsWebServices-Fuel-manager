using Microsoft.EntityFrameworkCore;

namespace MF_APIsWebServices_Fuel_manager.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Veiculo> Veiculos { get; set; }
        DbSet<Consumo> Consumos { get; set; }
    }
}
