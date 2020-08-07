using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace gameDev_api.Models
{
    public partial class GamesContext : DbContext
    {
        public GamesContext()
        {
        }

        public GamesContext(DbContextOptions<GamesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Developer> Developer { get; set; }
        public virtual DbSet<Games> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\mssqllocaldb; Initial Catalog = Games;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Developer>(entity =>
            {
                entity.HasKey(e => e.DevId)
                    .HasName("PK__Develope__0147852C5C589458");

                entity.Property(e => e.DevId).HasColumnName("devId");

                entity.Property(e => e.DevDescription)
                    .HasColumnName("devDescription")
                    .HasMaxLength(50);

                entity.Property(e => e.DevName)
                    .HasColumnName("devName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Games>(entity =>
            {
                entity.HasKey(e => e.GameId)
                    .HasName("PK__Games__DA90B4520FED526D");

                entity.Property(e => e.GameId).HasColumnName("gameId");

                entity.Property(e => e.DevId).HasColumnName("devId");

                entity.Property(e => e.GameDescription)
                    .HasColumnName("gameDescription")
                    .HasMaxLength(50);

                entity.Property(e => e.GameName)
                    .HasColumnName("gameName")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Dev)
                    .WithMany(p => p.Games)
                    .HasForeignKey(d => d.DevId)
                    .HasConstraintName("FK__Games__devId__25869641");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
