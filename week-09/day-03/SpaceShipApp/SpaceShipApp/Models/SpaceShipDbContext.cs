using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SpaceShipApp.Models
{
    public partial class SpaceShipDbContext : DbContext
    {
        public SpaceShipDbContext()
        {
        }

        public SpaceShipDbContext(DbContextOptions<SpaceShipDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Planet> Planet { get; set; }
        public virtual DbSet<Spaceship> Spaceship { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SpaceShipDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Planet>(entity =>
            {
                entity.ToTable("planet");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Population).HasColumnName("population");
            });

            modelBuilder.Entity<Spaceship>(entity =>
            {
                entity.ToTable("spaceship");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaxCapacity).HasColumnName("max_capacity");

                entity.Property(e => e.Planet)
                    .HasColumnName("planet")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Utilization).HasColumnName("utilization");
            });
        }
    }
}
