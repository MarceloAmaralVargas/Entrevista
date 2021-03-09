using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marcelo.Persistencia.Maps
{
    class UsuarioDeuclerioMap : IEntityTypeConfiguration<UsuarioDeuclerio>
    {
        public void Configure(EntityTypeBuilder<UsuarioDeuclerio> builder)
        {
            builder.ToTable("UsuarioDeuclerio");
            {
                builder.HasNoKey();

                builder.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                builder.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            }
        }
    }
}
