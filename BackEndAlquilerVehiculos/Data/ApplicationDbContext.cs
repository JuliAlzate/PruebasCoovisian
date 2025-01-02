
using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace BackEndAlquilerVehiculos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Carro> Carro { get; set; }
        public DbSet<Alquiler> Alquiler { get; set; }
        public DbSet<Pago> Pago { get; set; }

    }
}
