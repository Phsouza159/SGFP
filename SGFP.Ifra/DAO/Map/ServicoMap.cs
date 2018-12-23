using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SGFP.Domain.Entidades;

namespace SGFP.Infra.DAO.Map
{
    public class ServicoMap : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            builder.ToTable("SGFP_013_SERVICO");

            builder
                .HasKey(p => p.Id)
                .HasName("PK_013");

            builder
                .Property(p => p.NomeServico)
                .HasColumnName("NOME_SERVICO")
                .HasColumnType("varchar(35)")
                .IsRequired();

            builder
                .Property(p => p.Valor)
                .HasColumnName("VALOR")
                .HasColumnType("float");
        }
    }
}
