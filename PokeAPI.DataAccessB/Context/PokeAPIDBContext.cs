using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PokeAPI.Entity_Layer.Entities;

namespace PokeAPI.Entity_Layer.Context
{
    public partial class PokeAPIDBContext : DbContext
    {
        public PokeAPIDBContext()
        {
        }

        public PokeAPIDBContext(DbContextOptions<PokeAPIDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FavoritePokemon> FavoritePokemons { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=PokeAPIDB.mssql.somee.com;Database=PokeAPIDB;User=jzzz03_SQLLogin_1;Password=bl4jsjt34x;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FavoritePokemon>(entity =>
            {
                entity.ToTable("FavoritePokemon");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IDPokemon).HasColumnName("IDPokemon");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
