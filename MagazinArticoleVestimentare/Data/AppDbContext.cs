using MagazinArticoleVestimentare.Models;
using Microsoft.EntityFrameworkCore;

namespace MagazinArticoleVestimentare.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProdusComandat>().HasKey(pc => new
            {
                pc.ProdusId,
                pc.ComandaId
            });
            modelBuilder.Entity<ProdusComandat>().HasOne(c => c.Comanda)
                .WithMany(pc => pc.ProdusComandat).HasForeignKey(c => c.ComandaId);

            modelBuilder.Entity<ProdusComandat>().HasOne(c => c.Produse)
                .WithMany(pc => pc.ProdusComandat).HasForeignKey(c => c.ProdusId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Produse> Produse { get; set; }
        public DbSet<Comanda> Comanda { get; set; }

        public DbSet<ProdusComandat> ProdusComandat { get; set; }

        public DbSet<Clienti> Clienti { get; set; }
    }
}
