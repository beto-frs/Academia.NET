using AulaMVCEF.Models;
using Microsoft.EntityFrameworkCore;

namespace AulaMVCEF
{
    public class Contexto : DbContext
    {
        public DbSet<PessoaModel> Pessoas { get; set; }

        public DbSet<EmailModel> Emails { get; set; }

        public Contexto()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=192.168.64.250,1433;Initial Catalog=EntityCodeFirst;User ID=sa;Password=H4ck3rSn4k3@@")
                .UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<EmailModel>()
                .HasOne(e => e.pessoa)
                .WithMany(e => e.Emails)
                .OnDelete(DeleteBehavior.ClientCascade);
        }




    }
}
