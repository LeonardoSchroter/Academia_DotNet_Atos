using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtosEntity_codeFirst.DataModels;
using Microsoft.EntityFrameworkCore;

namespace AtosEntity_codeFirst
{
    internal class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Email> Emails { get; set; }

        public Contexto()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost; Initial Catalog=AtosEntity1;User ID=AtosEntity1; password=AtosEntity1; language=Portuguese;Trusted_Connection=true;TrustServerCertificate=true;");
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>()
                .HasOne(e => e.pessoa)
                .WithMany(e=>e.emails)
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
