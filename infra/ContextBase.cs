using entidades;
using Microsoft.EntityFrameworkCore;

namespace infra
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Vaga> vagas { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var conectionString = "Server=localhost;Port=3306;Database=vagas;User=root;Password=@Teste;";
                optionsBuilder.UseMySql(conectionString, ServerVersion.AutoDetect(conectionString));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}