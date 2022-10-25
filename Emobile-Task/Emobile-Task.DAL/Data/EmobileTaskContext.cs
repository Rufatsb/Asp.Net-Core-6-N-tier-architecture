using System;
using System.Collections.Generic;
using Emobile_Task.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Emobile_Task.DAL.Data
{
    public partial class EmobileTaskContext : DbContext
    {
        public EmobileTaskContext()
        {
        }

        public EmobileTaskContext(DbContextOptions<EmobileTaskContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Travel> Travels { get; set; } = null!;



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Countries)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.CountriesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cities_Countries");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Travel>(entity =>
            {
                entity.ToTable("Travel");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Travels)
                    .HasForeignKey(d => d.CitiesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Travel_Cities");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
