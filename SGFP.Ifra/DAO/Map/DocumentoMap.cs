using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGFP.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGFP.Infra.DAO.Map
{
    public class DocumentoMap : IEntityTypeConfiguration<Documento>
    {
        public void Configure(EntityTypeBuilder<Documento> builder)
        {
            builder.ToTable("SGFP_005_DOCUMENTO");

            builder.Ignore(p => p.Notifications);

            //builder
            //    .HasIndex(p => p.Id)
            //    .HasName("PK_005");

        }
    }
}
