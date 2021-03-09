using System;
using Marcelo.Persistencia.Maps;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Marcelo.Persistencia
{
    public partial class BancoDeuclerioContext : DbContext
    {
        public BancoDeuclerioContext()
        {
        }

        public BancoDeuclerioContext(DbContextOptions<BancoDeuclerioContext> options) : base(options)
        {
        }

        public DbSet<LogErroDeuclerio> LogErroDeuclerio { get; set; }
        public DbSet<UsuarioDeuclerio> UsuarioDeuclerio { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)        
        {
            builder.ApplyConfiguration(new LogErroDeuclerioMap());
            builder.ApplyConfiguration(new UsuarioDeuclerioMap());
        }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LogErroDeuclerio>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Mensagem).IsUnicode(false);

                entity.Property(e => e.NomeUsuario).IsRequired();

                entity.Property(e => e.StarkTracer)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsuarioDeuclerio>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        */
    }
}
