using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Ramon_Gonzalez_AP1_P1.DAL;

namespace Ramon_Gonzalez_AP1_P1.DAL
{
    public class ContextoFactory : IDesignTimeDbContextFactory<Contexto>
    {
        public Contexto CreateDbContext(String[] arg)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Contexto>()
                optionsBuilder.UserSqlServer("Server=Aplicada1_Parcial1.mssql.somee.com;packet size=4096;user id=David-4949_SQLLogin_1;pwd=a4jmmtc9gb;data source=Aplicada1_Parcial1.mssql.somee.com;persist security info=False;initial catalog=Aplicada1_Parcial1;TrustServerCertificate=True");

            return new Contexto(optionsBuilder.Options);
        }
    }
}
