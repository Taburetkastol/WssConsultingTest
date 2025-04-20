using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.DataContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<Division> Divisions { get; set; } = null!;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Division>(entity =>
            {
                entity.ToTable("Divisions");
                entity.HasKey(d => d.Id);
                entity.Property(d => d.Name).IsRequired().HasMaxLength(200);
                entity.Property(d => d.ParentId);
                entity.Property(d => d.Order);
                // Контроль одновременного доступа к записи.
                // Используется при обновлении и сохранении записи.
                entity.Property(d => d.RowVersion).IsRowVersion();
            });
        }
    }
}