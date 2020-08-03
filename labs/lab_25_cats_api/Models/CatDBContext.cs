using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace lab_25_cats_api.Models
{
    public partial class CatDBContext : DbContext
    {
        public CatDBContext()
        {
        }

        public CatDBContext(DbContextOptions<CatDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Breed> Breed { get; set; }
        public virtual DbSet<Cats> Cats { get; set; }
        public virtual DbSet<Dogs> Dogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\mssqllocaldb;Initial Catalog = CatDB;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Breed>(entity =>
            {
                entity.Property(e => e.BreedName).HasMaxLength(50);
            });

            modelBuilder.Entity<Cats>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("PK__Cats__17B6DD06AA3D3A1C");

                entity.Property(e => e.CatId).HasColumnName("catId");

                entity.Property(e => e.CatDescription).HasMaxLength(50);

                entity.Property(e => e.CatName).HasMaxLength(50);
            });

            modelBuilder.Entity<Dogs>(entity =>
            {
                entity.HasKey(e => e.DogId)
                    .HasName("PK__Dogs__0731A664EEF20F72");

                entity.Property(e => e.DogId).HasColumnName("dogId");

                entity.Property(e => e.DogDescription).HasMaxLength(50);

                entity.Property(e => e.DogName)
                    .HasColumnName("dogName")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
