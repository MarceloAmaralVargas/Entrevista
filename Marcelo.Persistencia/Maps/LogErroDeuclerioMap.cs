using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marcelo.Persistencia.Maps
{
    class LogErroDeuclerioMap : IEntityTypeConfiguration<LogErroDeuclerio>
    {
        public void Configure(EntityTypeBuilder<LogErroDeuclerio> builder)
        {
            builder.ToTable("LogErroDeuclerio");
            {
                builder.HasNoKey();

                builder.Property(e => e.Mensagem).IsUnicode(false);

                builder.Property(e => e.NomeUsuario).IsRequired();

                builder.Property(e => e.StarkTracer)
                    .IsRequired()
                    .IsUnicode(false);

                builder.Property(e => e.Url)
                    .IsRequired()
                    .IsUnicode(false);
            }
        }
    }
}
