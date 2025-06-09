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

        
    }
}
