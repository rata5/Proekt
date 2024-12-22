using Microsoft.EntityFrameworkCore;
using Proekt.Data.Entities;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Cars> Cars { get; set; }; 
    public DbSet<Garages> Garages { get; set; }
    public DbSet<Maintenance> Maintenances { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cars>()
            .HasOne(c => c.Garages)
            .WithMany(g => g.Car)
            .HasForeignKey(c => c.GarageId);
        
        modelBuilder.Entity<Maintenance>()
            .HasOne(m => m.Garages) 
            .WithMany() 
            .HasForeignKey(m => m.GarageId);

        modelBuilder.Entity<Maintenance>()
            .HasOne(m => m.Cars)
            .WithMany() 
            .HasForeignKey(m => m.CarId);
    }
}