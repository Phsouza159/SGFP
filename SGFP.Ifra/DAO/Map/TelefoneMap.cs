using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SGFP.Domain.Entidades;

namespace SGFP.Infra.DAO.Map
{
    public class TelefoneMap : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.ToTable("SGFP_014_TELEFONE");

            // builder.Ignore(p => p.)
            builder
                .HasKey(p => p.Id)
                .HasName("PK_014");

            builder
                .Property(p => p.DDD)
                .HasColumnName("DDD")
                .HasColumnType("char(3)")
                .IsRequired();

            builder
                .Property(p => p.Numero)
                .HasColumnName("NUMERO")
                .HasColumnType("char(10)")
                .IsRequired();

            builder
                .Property(p => p.TipoTelefone)
                .HasColumnName("TIPO_TELEFONE")
                .HasColumnType("int")
                .IsRequired();
        }
    }
}
