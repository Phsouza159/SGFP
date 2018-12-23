using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SGFP.Domain.Entidades;

namespace SGFP.Infra.DAO.Map
{
    public class MaoDeObraMap : IEntityTypeConfiguration<MaoDeObra>
    {
        public void Configure(EntityTypeBuilder<MaoDeObra> builder)
        {
            builder.ToTable("SGFP_010_MAO_DE_OBRA");

            builder.Ignore(p => p.Notifications);

            builder
                .HasKey(p => p.Id)
                .HasName("PK_010");

            builder
                .Property(p => p.JornadaTrabalho)
                .HasColumnName("JORNADA_TRABALHO")
                .HasColumnType("float");

            builder
                .Property(p => p.LimiteHoraExtra)
                .HasColumnName("LIMITE_HORA_EXTRA")
                .HasColumnType("float");

            builder
                .Property(p => p.Nome)
                .HasColumnName("NOME")
                .HasColumnType("varchar(25)")
                .IsRequired();

            builder
                .Property(p => p.TipoMaoObra)
                .HasColumnName("TIPO_MAO_OBRA")
                .HasColumnType("varchar(25)")
                .IsRequired();

            builder
                .Property(p => p.Valor)
                .HasColumnName("VALOR")
                .HasColumnType("float");

            builder
                .Property(p => p.ValorHoraExtra)
                .HasColumnName("VALOR_HORA_EXTRA")
                .HasColumnType("float");

            builder
                .Property(p => p.Ativo)
                .HasColumnName("FLAG_ATIVO")
                .HasColumnType("bit")
                .IsRequired();
        }
    }
}
