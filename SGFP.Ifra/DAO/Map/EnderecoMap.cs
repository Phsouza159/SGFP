using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGFP.Domain.Entidades;

namespace SGFP.Infra.DAO.Map
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("SGFP_007_ENDERECO");

            builder.Ignore(p => p.Notifications);

            builder
                 .HasIndex(p => p.Id)
                 .HasName("PK_007");

            builder
                 .Property(p => p.CEP)
                 .HasColumnName("CEP")
                 .HasColumnType("varchar(8)");

            builder
                .Property(p => p.Municipio)
                .HasColumnName("MUNICIPIO")
                .HasColumnType("varchar(25)")
                .IsRequired();

            builder
                .Property(p => p.Andress)
                .HasColumnName("ENDERECO")
                .HasColumnType("varchar(45)")
                .IsRequired();

            builder
                .Property(p => p.Complemento)
                .HasColumnName("COMPLEMENTO")
                .HasColumnType("varchar(45)");
        }
    }
}
