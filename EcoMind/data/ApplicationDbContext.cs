using Microsoft.EntityFrameworkCore;

namespace ConsumoEnergetico.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }
    
    public DbSet<Usuario>? Usuarios { get; set; }
    public DbSet<Dispositivo>? Dispositivos { get; set; }
    public DbSet<Consumo>? Consumos { get; set; }
    public DbSet<GeracaoEnergia>? GeracaoEnergia { get; set; }
}
