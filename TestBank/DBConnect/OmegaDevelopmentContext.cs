using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TestBank.Models;

namespace TestBank.DBConnect
{
    public partial class OmegaDevelopmentContext : DbContext
    {
        public virtual DbSet<client> Userdata { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=OmegaDevelopment;Username=postgres;Password=1234");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<client>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("userdata");

                entity.Property(e => e.Balance).HasColumnName("balance");
                entity.Property(e => e.Pin).HasColumnName("pin");
                entity.Property(e => e.Userlogin)
                    .HasMaxLength(128)
                    .HasColumnName("userlogin");
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);


    }
}
