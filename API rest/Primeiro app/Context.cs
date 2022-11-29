using Microsoft.EntityFrameworkCore;
using Primeiro_app.dataModel;

namespace Primeiro_app
{
    public class Context:DbContext
    {

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost; Initial Catalog= EntityAPIRest;User ID=EntityAPI; password=EntityAPI; language=Portuguese;Trusted_Connection=true;TrustServerCertificate=true;");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
