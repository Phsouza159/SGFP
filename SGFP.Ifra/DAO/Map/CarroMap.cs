using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGFP.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGFP.Infra.DAO.Map
{
    public class CarroMap : IEntityTypeConfiguration<Carro>
    {
        public void Configure(EntityTypeBuilder<Carro> builder)
        {
            builder.ToTable("SGFP_002_CARRO");

            builder.Ignore(p => p.Notifications);

            builder
                 .HasIndex(p => p.Id)
                 .HasName("PK_002");

            builder
                .Property(p => p.Marca)
                .HasColumnName("MARCA")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(p => p.Modelo)
                .HasColumnName("MODELO")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(p => p.Placa)
                .HasColumnName("PLACA")
                .HasColumnType("varchar(8)")
                .IsRequired();

            builder
                .Property(p => p.Chassi)
                .HasColumnName("CHASSI")
                .HasColumnType("varchar(15)")
                .IsRequired();

            builder
                .Property(p => p.AnoFabricao)
                .HasColumnName("ANO_FABRICAO")
                .HasColumnType("datetime")
                .IsRequired();

            builder
                .Property(p => p.Cor)
                .HasColumnName("COR")
                .HasColumnType("varchar(12)")
                .IsRequired();

        }
    }
}
