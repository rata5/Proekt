﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Proekt.Data.Entities;

namespace Proekt.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Garages> Garages { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cars>()
                .HasOne(c => c.Garages)
                .WithMany()
                .HasForeignKey(g => g.GarageId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Maintenance>()
                .HasOne(m => m.Garages)
                .WithMany()
                .HasForeignKey(m => m.GarageId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Maintenance>()
                .HasOne(m => m.Cars)
                .WithMany()
                .HasForeignKey(m => m.CarId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}