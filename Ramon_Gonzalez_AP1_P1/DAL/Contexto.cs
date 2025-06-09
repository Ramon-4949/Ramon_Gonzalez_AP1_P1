using Microsoft.EntityFrameworkCore;
using Ramon_Gonzalez_AP1_P1.Models;

namespace Ramon_Gonzalez_AP1_P1.DAL
{
    public class Contexto: DbContext 
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) 
        {
        }

        public DbSet<Aportes> Aportes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Aportes>()
                .Property(a => a.Persona)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Aportes>()
                .Property(a => a.Persona)
                .IsRequired()
                .HasMaxLength(250);

            modelBuilder.Entity<Aportes>()
                .Property(a => a.Monto)
                .HasPrecision(18, 2);
        }
    }
}
