using Microsoft.EntityFrameworkCore;
using Nextsoft.Infra.Data.Mapping;
using NextSoft.Domain.Entitites;

namespace Nextsoft.Infra.Data.Context
{
    public class SqlServerContext : DbContext
    {
        public DbSet<Morador> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Data Source=PARADA-NOTE\SQLEXPRESS;Initial Catalog=Desenvolvimento;Persist Security Info=True;User ID=sa;Password=123456");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Morador>(new MoradorMap().Configure);
        }
    }
}
