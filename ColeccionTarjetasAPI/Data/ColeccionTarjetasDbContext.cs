using ColeccionTarjetasAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ColeccionTarjetasAPI.Data
{
    public class ColeccionTarjetasDbContext: DbContext  
    {
        public ColeccionTarjetasDbContext(DbContextOptions<ColeccionTarjetasDbContext> options): base(options)
        {
        }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<TarjetasDeCredito> TarjetasDeCreditos { get; set; }

    }
}
